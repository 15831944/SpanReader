using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SpanReader.util;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using System.Net;
using System.IO;
using System.IO.Compression;

namespace SpanReader.Mscreen
{
    public partial class frmFTP : DevExpress.XtraEditors.XtraUserControl
    {
        
        private static frmFTP instance;

        public frmFTP()
        {
            InitializeComponent();
        }

        public static frmFTP Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmFTP();


                    ///Double click 이벤트를 등록한다. 
                    //instance.AddEvent();

                    //instance.LoadLineInfo();
                }
                return instance;
            }
        }

        public static void GetCmeList()
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();

                List<CFTPList> ftp_list = CFTP.GetFileList(CFTP.GetFtpCME());

                DataTable Dt = CUtil.LinqQueryToDataTable(ftp_list);

                var qry = from data in Dt.AsEnumerable()
                          orderby data.Field<string>("dirFlag") descending, data.Field<string>("Date")
                          select data;

                //RepositoryItemImageEdit ImageEdit = gridControl1.RepositoryItems.Add("ImageEdit") as RepositoryItemImageEdit;
                //gridView1.Columns["Image"].ColumnEdit = ImageEdit;
                //gridControl1.RepositoryItems.Add(ImageEdit);
                
                
                //RepositoryItemPictureEdit pictureEdit = gridControl1.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
                //pictureEdit.SizeMode = PictureSizeMode.Clip;
                //pictureEdit.NullText = " ";
                //gridView1.Columns["Picture"].ColumnEdit = pictureEdit;
                //gridControl1.RepositoryItems.Add(pictureEdit);

                //pictureEdit.i
                gridControl1.DataSource = qry.CopyToDataTable();

                gridView1.PopulateColumns();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show(ex.Message);
            }
          
            

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            string downloadFile = "";

            try
            {
                
                DataRow Dr = gridView1.GetFocusedDataRow();

                if (Dr["DirFlag"].ToString().Trim() == "d")
                {
                    XtraMessageBox.Show("Directory는 Down이 불가해요");
                    return;
                }

                if (Dr["Size"].ToString().Trim() == "0")
                {
                    XtraMessageBox.Show("Size가 0이에요");
                    return;
                }


                string filename = "";
               

                using (XtraSaveFileDialog saveDlg = new XtraSaveFileDialog())
                {
                    saveDlg.FileName = Dr["Filename"].ToString();

                    saveDlg.ShowDialog();

                    downloadFile = saveDlg.FileName;
                }

                splashScreenManager1.ShowWaitForm();


                filename = string.Format("{0}/{1}", Dr["Uri_Path"], Dr["Filename"]);
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(filename);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                //// This example assumes the FTP site uses anonymous logon.
                //request.Credentials = new NetworkCredential("anonymous", "janeDoe@contoso.com");

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();

                FileStream targetFileStream = new FileStream(downloadFile, FileMode.Create, FileAccess.Write);
                byte[] bufferByteArray = new byte[1024];
                while (true)
                {
                    int byteCount = responseStream.Read(bufferByteArray, 0, bufferByteArray.Length);

                    if (byteCount == 0)
                    {
                        break;
                    }

                    targetFileStream.Write(bufferByteArray, 0, byteCount);
                }

               

                responseStream.Close();
                targetFileStream.Close();
                response.Close();
                ExtractZip(downloadFile);

                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex )
            {
                XtraMessageBox.Show(ex.Message);
                splashScreenManager1.CloseWaitForm();
            }

            
        }

        private void ExtractZip(string ZfilePath)
        {
            try
            {
                using (ZipArchive zipArchive = ZipFile.OpenRead(ZfilePath))
                {
                    foreach (ZipArchiveEntry zipArchiveEntry in zipArchive.Entries)
                    {
                        try
                        {
                            string folderPath = Path.GetDirectoryName(ZfilePath);
                            string extractPath = Path.GetFileNameWithoutExtension(ZfilePath);

                            folderPath = Path.Combine(folderPath, extractPath);

                            if (!Directory.Exists(folderPath))
                            {
                                Directory.CreateDirectory(folderPath);
                            }

                            zipArchiveEntry.ExtractToFile(Path.Combine(folderPath, zipArchiveEntry.FullName), true);
                        }
                        catch (Exception ex)
                        {

                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }
    }
}
