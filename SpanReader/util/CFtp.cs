using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SpanReader.util
{

    public class CFTPList
    {
        string uri_path;
        string dirInfo;
        string dirFlag;
        string size;
        string date;
        string filename;


        public string Uri_path { get => uri_path; set => uri_path = value; }
        public string DirInfo { get => dirInfo; set => dirInfo = value; }
        public string DirFlag { get => dirFlag; set => dirFlag = value; }

        public string Size { get => size; set => size = value; }
        public string Date { get => date; set => date = value; }
        public string Filename { get => filename; set => filename = value; }
        
    };


    public static class CFTP
    {
        public static string GetFtpCME()
        {
            string sUri = "ftp://ftp.cmegroup.com/pub/span/data/cme";
            return sUri;
        }

        public static List<CFTPList> GetFileList(string strUri)
        {
            FtpWebRequest reqFTP;
            StringBuilder result = new StringBuilder();

            List<CFTPList> List_Dir = new List<CFTPList>();

            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(strUri));
                reqFTP.UseBinary = true;
                reqFTP.UsePassive = true;

                reqFTP.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                WebResponse response = reqFTP.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream());


                string line = reader.ReadLine();
                while (line != null)
                {
                    CFTPList ftplist = new CFTPList();

                    var dirDetails = line.Split(new char[] { ' ' }, 9, StringSplitOptions.RemoveEmptyEntries);

                    ftplist.Uri_path = strUri;
                    ftplist.DirInfo = dirDetails[0];
                    ftplist.DirFlag = dirDetails[0].Substring(0, 1);
                    ftplist.Size = dirDetails[4];

                    if (ftplist.DirFlag == "d")
                    {
                        ftplist.Date = string.Format("{0}-{1}-{2}", dirDetails[7], dirDetails[5], dirDetails[6]);

                    }
                    else
                    {
                        ftplist.Date = string.Format("{0}-{1}-{2}", dirDetails[5], dirDetails[6], dirDetails[7]);
                    }
                    
                    ftplist.Filename = dirDetails[8];

                    List_Dir.Add(ftplist);

                    line = reader.ReadLine();
                }

                reader.Close();
                response.Close();

                return List_Dir;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }
    }
}
