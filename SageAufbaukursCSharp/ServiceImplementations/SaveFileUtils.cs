using SageAufbaukursCSharp.Services;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageAufbaukursCSharp.ServiceImplementations
{
    public class SaveFileUtils : ISaveFileUtils, ISaveTemp
    {
        #region ISaveFileUtils

        public Exception Fault { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Message { get; private set; }

        public string DateiMitPfad { private get;  set; }

        public bool Save(object beleg)
        {

            try
            {

                using (var sw = new StreamWriter(""))
                {
                    sw.Write("Hallo");
                }
                return true ;
            }
            catch(UnauthorizedAccessException uae)
            {
                Message = uae.Message;
                Fault = uae;
                return false;
            }
            catch (ArgumentException ae)
            {
                //DateiMitPfad = Path.Combine(Path.GetTempPath().ToString(), "Uebergabedatei.txt");
                try
                {

                }
                catch (Exception)
                {
                    //Jetzt geb ich auf
                    Fault = ae;
                    return false;
                }
                throw;
            }
            catch (Exception e)
            {
                Fault = e;
                return false;
            }
        }

        public bool Save(object beleg, string path)
        {
            throw new NotImplementedException();
        }
        #endregion ISaveFileUtils


    }
}
