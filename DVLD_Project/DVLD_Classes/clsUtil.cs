using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Classes
{
    public static class clsUtil
    {
        static string GenerateGUID()
        {
            return Guid.NewGuid().ToString();
        }
        static bool CreateAFileIfDoesNotExist(string ImageDirectory)
        {
            if (!Directory.Exists(ImageDirectory))
            {
                try
                {
                    Directory.CreateDirectory(ImageDirectory);
                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }
            return true;
        }
        static string ReplaceFileNameWithGuid(string FilePath)
        {
            string Extention = Path.GetExtension(FilePath);
            string NewFileName = GenerateGUID();
            return NewFileName + Extention;
        }
        public static bool CopieImageToProjectImagesFolder(ref string ImagePath)
        {
            string Destination = ConfigurationManager.AppSettings["People Images Direcotry"];
           
            if (!CreateAFileIfDoesNotExist(Destination))
            {
                return false;
            }

            string NewImagePath = Path.Combine(Destination , ReplaceFileNameWithGuid(ImagePath));

            try
            {
                File.Copy(ImagePath, NewImagePath, true);
                ImagePath = NewImagePath;
                return true;
            }
            catch (IOException Ex)
            {
                MessageBox.Show("Error: " + Ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        static public string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] HashByte = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(HashByte).Replace("-", "");
            }
        }

    }
}