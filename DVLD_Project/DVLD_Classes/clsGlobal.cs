using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using System.Web;
using Microsoft.Win32;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace DVLD_Project
{
    static public class clsGlobal
    {
        static public clsUser CurrentUser;

        static private bool DoesRegistryExist(string ProjectRegistrySubKeyPath, string ProjectName)
        {
            string RegistryPath = Path.Combine(ProjectRegistrySubKeyPath.Replace(@"HKEY_CURRENT_USER\", ""),ProjectName);

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                if (key != null) return true;
                else return false;
            }

        }
        static private bool DeleteLoginInfoIfExist(string RegistryPath, string RegistryName)
        {
            try
            {
                using (RegistryKey Key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
                {
                    using (RegistryKey SubKey = Key.OpenSubKey(RegistryPath.Replace(@"HKEY_CURRENT_USER\", ""), true))
                    {
                        if (SubKey != null)
                        {
                            SubKey.DeleteValue(RegistryName);
                            return true;
                        }

                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        static public bool RememberUsernameAndPassword(string Username, string Password, bool RememberIt = true)
        {
            string RegistryName = "Login Info";
            string ProjectName = ConfigurationManager.AppSettings["Project Name"];
            string ProjectRegistrySubKeyPath = ConfigurationManager.AppSettings["Project Registry Sub Key Path"];
            string RegistryPath = Path.Combine(ProjectRegistrySubKeyPath, ProjectName);

            if (!RememberIt)
            {
                return DeleteLoginInfoIfExist(RegistryPath, RegistryName);
            }

            string RegistryValue = Username + "#//#" + Password;

            try
            {
                Registry.SetValue(RegistryPath, RegistryName, RegistryValue, RegistryValueKind.String);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        static public bool GetStoredCredential(ref string Username, ref string Password)
        {

            string RegistryName = "Login Info";
            string ProjectName = ConfigurationManager.AppSettings["Project Name"];
            string ProjectRegistrySubKeyPath = ConfigurationManager.AppSettings["Project Registry Sub Key Path"];
            string RegistryPath = Path.Combine(ProjectRegistrySubKeyPath, ProjectName);

            if (!DoesRegistryExist(ProjectRegistrySubKeyPath, RegistryName))
                return false;

            try
            {
                string Result = Registry.GetValue(RegistryPath, RegistryName, null).ToString();
                if (Result != null)
                {
                    string[] LoginInfoParts = Result.Split(new string[] { "#//#" }, StringSplitOptions.None);
                    Username = LoginInfoParts[0];
                    Password = LoginInfoParts[1];
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
    }
}
