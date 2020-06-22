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
                List<CFTPList> ftp_list = CFTP.GetFileList(CFTP.GetFtpCME());

                DataTable Dt = CUtil.LinqQueryToDataTable(ftp_list);

                var qry = from data in Dt.AsEnumerable()
                          orderby data.Field<string>("dirFlag") descending, data.Field<string>("Date")
                          select data;

                RepositoryItemImageEdit ImageEdit = gridControl1.RepositoryItems.Add("ImageEdit") as RepositoryItemImageEdit;
                gridView1.Columns["ImageEdit"].ColumnEdit = ImageEdit;
                gridControl1.RepositoryItems.Add(ImageEdit);
                ImageEdit.Images = imageCollection1.Images[;
                
                //RepositoryItemPictureEdit pictureEdit = gridControl1.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
                //pictureEdit.SizeMode = PictureSizeMode.Clip;
                //pictureEdit.NullText = " ";
                //gridView1.Columns["Picture"].ColumnEdit = pictureEdit;
                //gridControl1.RepositoryItems.Add(pictureEdit);

                //pictureEdit.i
                gridControl1.DataSource = qry.CopyToDataTable();

                gridView1.PopulateColumns();
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(ex.Message);
            }
          
            

        }
    }
}
