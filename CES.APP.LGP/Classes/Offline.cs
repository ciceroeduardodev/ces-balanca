using CES.APP.XGP.Interfaces;
using CES.MOD.CES.CES;
using CES.MOD.CES.Public;
using CES.MOD.CES.XGP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CES.APP.XGP.Classes
{
    public class Offline : IMetodos
    {
        const string cFileName = "json-data.offline";
        const string cFileNameOld = "json-data-old.offline";

        public modXGP GetXGP(string pBAL_Token)
        {
            if (!File.Exists(cFileName))
                return default(modXGP);

            StreamReader oReader = new StreamReader(cFileName);
            modXGP modXGP = JsonConvert.DeserializeObject<modXGP>(oReader.ReadToEnd());
            oReader.Close();
            return modXGP;
        }

        public modBALANCA GetBalanca(string pBAL_Token)
        {
            return GetXGP("").BAL;
        }

        public List<MOD.CES.XGP.modENTIDADE> GetPessoaFisica(int pCLI_Id)
        {
            return GetXGP("").Current.PFs;
        }

        public List<MOD.CES.XGP.modENTIDADE> GetPessoaJuridica(int pCLI_Id)
        {
            return GetXGP("").Current.PJs;
        }

        public List<modPRODUTO> GetProduto(int pCLI_Id)
        {
            return GetXGP("").Current.PRDs;
        }

        public List<modMOVIMENTO> GetEntradasPendentes(int pCLI_Id)
        {
            return GetXGP("").Current.MOVs_EntradasPendentes;
        }

        public List<modMOVIMENTO> GetSaidasTop100(int pCLI_Id)
        {
            return GetXGP("").Current.MOVs_SaidasTop100;
        }

        public string GetTicket(int pCLI_Id, int pBAL_Id)
        {
            return String.Format("offline.{0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
        }

        public MOD.CES.XGP.modENTIDADE PostEntidade(MOD.CES.XGP.modENTIDADE pENT, ref PostReturn pReturn)
        {
            modXGP oXGP;
            
            try
            {

                oXGP = GetXGP("");
                               
                if (pENT.ENT.ENT_Tipo.ToUpper() == "F")
                {
                    pENT.ENT.ENT_Id = oXGP.Current.PFs.Max(x => x.ENT.ENT_Id) + 1;
                    oXGP.Current.PFs.Add(pENT);
                    oXGP.ToSync.PFs.Add(pENT);
                }
                else
                {
                    pENT.ENT.ENT_Id = oXGP.Current.PJs.Max(x => x.ENT.ENT_Id) + 1;
                    oXGP.Current.PJs.Add(pENT);
                    oXGP.ToSync.PJs.Add(pENT);
                }

                pReturn.Status = true;
                Commit(oXGP);
                return pENT;
            }
            catch (Exception pEx)
            {
                pReturn.Status = false;
                pReturn.Message = pEx.Message;
                return null;
            }
        }

        public modMOVIMENTO PostEntrada(modMOVIMENTO pMOV, ref PostReturn pReturn)
        {

            modXGP oXGP;
            try
            {

                oXGP = GetXGP("");

                pMOV.BAL.BAL_Nome = oXGP.BAL.BAL_Nome;
                pMOV.Motorista = oXGP.Current.PFs.Single(x => x.ENT.ENT_Id == pMOV.Motorista.ENT_Id).ENT;
                pMOV.Cliente = oXGP.Current.PJs.Single(x => x.ENT.ENT_Id == pMOV.Cliente.ENT_Id).ENT;
                pMOV.Fornecedor = oXGP.Current.PJs.Single(x => x.ENT.ENT_Id == pMOV.Fornecedor.ENT_Id).ENT;
                pMOV.Transportadora = oXGP.Current.PJs.Single(x => x.ENT.ENT_Id == pMOV.Transportadora.ENT_Id).ENT;
                pMOV.PRD = oXGP.Current.PRDs.Single(x => x.PRD_Id == pMOV.PRD.PRD_Id);

                oXGP.Current.MOVs_EntradasPendentes.Add(pMOV);
                oXGP.ToSync.MOVs_EntradasPendentes.Add(pMOV);

                pReturn.Status = true;
                Commit(oXGP);
                return pMOV;
            }
            catch (Exception pEx)
            {
                pReturn.Status = false;
                pReturn.Message = pEx.Message;
                return null;
            }
        }

        public modPRODUTO PostProduto(modPRODUTO pPRD, ref PostReturn pReturn)
        {
            modXGP oXGP;

            try
            {
                oXGP = GetXGP("");
                pPRD.PRD_Id = oXGP.Current.PRDs.Max(x => x.PRD_Id) + 1;
                oXGP.Current.PRDs.Add(pPRD);
                oXGP.ToSync.PRDs.Add(pPRD);
                pReturn.Status = true;
                Commit(oXGP);
                return pPRD;
            }
            catch (Exception pEx)
            {
                pReturn.Status = false;
                pReturn.Message = pEx.Message;
                return null;
            }
        }

        public modMOVIMENTO PostSaida(modMOVIMENTO pMOV, ref PostReturn pReturn)
        {
            modXGP oXGP;
            modMOVIMENTO modInputToDelete;

            try
            {
                oXGP = GetXGP("");

                pMOV.BAL.BAL_Nome = oXGP.BAL.BAL_Nome;
                pMOV.Motorista = oXGP.Current.PFs.Single(x => x.ENT.ENT_Id == pMOV.Motorista.ENT_Id).ENT;
                pMOV.Cliente = oXGP.Current.PFs.Single(x => x.ENT.ENT_Id == pMOV.Motorista.ENT_Id).ENT;
                pMOV.Fornecedor = oXGP.Current.PJs.Single(x => x.ENT.ENT_Id == pMOV.Fornecedor.ENT_Id).ENT;
                pMOV.Transportadora = oXGP.Current.PJs.Single(x => x.ENT.ENT_Id == pMOV.Transportadora.ENT_Id).ENT;
                pMOV.PRD = oXGP.Current.PRDs.Single(x => x.PRD_Id == pMOV.PRD.PRD_Id);

                oXGP.Current.MOVs_SaidasTop100.Add(pMOV);
                oXGP.ToSync.MOVs_SaidasTop100.Add(pMOV);

                modInputToDelete = new modMOVIMENTO();
                modInputToDelete = oXGP.Current.MOVs_EntradasPendentes.Single(x => x.MOV_Ticket == pMOV.MOV_Ticket);
                oXGP.Current.MOVs_EntradasPendentes.Remove(modInputToDelete);

                modInputToDelete = new modMOVIMENTO();
                modInputToDelete = oXGP.ToSync.MOVs_EntradasPendentes.Single(x => x.MOV_Ticket == pMOV.MOV_Ticket);
                oXGP.ToSync.MOVs_EntradasPendentes.Remove(modInputToDelete);

                pReturn.Status = true;
                Commit(oXGP);
                return pMOV;

            }
            catch (Exception pEx)
            {
                pReturn.Status = false;
                pReturn.Message = pEx.Message;
                return null;
            }
        }

        public static void Commit(modXGP pXGP)
        {
            try
            {
                string sJsonXGP = JsonConvert.SerializeObject(pXGP);

                if (File.Exists(cFileName))
                {
                    File.Delete(cFileNameOld);                   
                    File.Copy(cFileName, cFileNameOld);
                }

                StreamWriter oStreamWriter = new StreamWriter(cFileName);
                oStreamWriter.Write(sJsonXGP);
                oStreamWriter.Close();
            }
            catch (Exception pEx)
            {
                General.SetError(pEx, true);
            }
        }

        public modBALANCA PostConfigInicial(modCLIENTE pCLI, modBALANCA pBAL, ref PostReturn pReturn)
        {
            throw new NotImplementedException();
        }

        public modCLIENTE GetCliente(modCLIENTE pCLI)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProduto(modPRODUTO pPRD, ref PostReturn pReturn)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntidade(MOD.CES.XGP.modENTIDADE pENT, ref PostReturn pReturn)
        {
            throw new NotImplementedException();
        }
    }
}
