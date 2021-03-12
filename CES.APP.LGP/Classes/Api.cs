using CES.MOD.CES.Public;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CES.APP.XGP.Classes
{
    public class Api
    {

        public static T Get<T>(string pMethod)
        {

            HttpClient oClient = new HttpClient();

            T oResponse;

            HttpResponseMessage oHttpResponseMessage = new HttpResponseMessage();

            oClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["API_BaseUrl"].ToString());
            oClient.DefaultRequestHeaders.Accept.Clear();
            oHttpResponseMessage = oClient.GetAsync(pMethod).Result;

            if (oHttpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                string sResult = oHttpResponseMessage.Content.ReadAsStringAsync().Result;
                oResponse = JsonConvert.DeserializeObject<T>(sResult);
                return oResponse;
            }
            return default(T);

        }

        public static T Post<T>(string pMethod, object pInput, ref PostReturn pReturn)
        {

            try
            {
                HttpClient oClient = new HttpClient();

                T oRetorno;

                HttpResponseMessage oHttpResponseMessage = new HttpResponseMessage();

                oClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["API_BaseUrl"].ToString());
                oClient.DefaultRequestHeaders.Accept.Clear();
                oClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                oHttpResponseMessage = oClient.PostAsJsonAsync(pMethod, pInput).Result;

                if (oHttpResponseMessage.StatusCode == HttpStatusCode.OK)
                {
                    string sResult = oHttpResponseMessage.Content.ReadAsStringAsync().Result;
                    pReturn.Status = true;
                    pReturn.Message = "Operação realizada com sucesso!";
                    oRetorno = JsonConvert.DeserializeObject<T>(sResult);
                    return oRetorno;
                }
                else
                {
                    pReturn.Status = false;
                    //pReturn.Message = oHttpResponseMessage.Content.ReadAsAsync().me
                    return default(T);
                }
            }
            catch (Exception pEx)
            {
                pReturn.Status = false;
                pReturn.Message = string.Format("Erro de comunicação com a API. {0}", pEx.Message);
                return default(T);
            }
        }        
    }   
}
