using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SpanReader.Mscreen;
using SpanReader.screen;
using SpanReader.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpanReader
{
    public partial class spanMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        

        public spanMain()
        {
            InitializeComponent();
        }



        private void elmCME_Click(object sender, EventArgs e)
        {

            try
            {
                if (!MainContainer.Controls.Contains(frmFTP.Instance))
                {
                    MainContainer.Controls.Add(frmFTP.Instance);
                    frmFTP.Instance.Dock = DockStyle.Fill;
                    frmFTP.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    frmFTP.Instance.Parent = this;
                }
                frmFTP.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }

        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(filetype1.Instance))
                {
                    MainContainer.Controls.Add(filetype1.Instance);
                    filetype1.Instance.Dock = DockStyle.Fill;
                    filetype1.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    filetype1.Instance.Parent = this;
                }
                filetype1.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }

        private void elmType2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(filetype2.Instance))
                {
                    MainContainer.Controls.Add(filetype2.Instance);
                    filetype2.Instance.Dock = DockStyle.Fill;
                    filetype2.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    filetype2.Instance.Parent = this;
                }
                filetype2.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }


        private void elmType3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(filetype3.Instance))
                {
                    MainContainer.Controls.Add(filetype3.Instance);
                    filetype3.Instance.Dock = DockStyle.Fill;
                    filetype3.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    filetype3.Instance.Parent = this;
                }
                filetype3.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }

        private void elmType5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(filetype5.Instance))
                {
                    MainContainer.Controls.Add(filetype5.Instance);
                    filetype5.Instance.Dock = DockStyle.Fill;
                    filetype5.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    filetype5.Instance.Parent = this;
                }
                filetype5.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }


        private void elmFileType6_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(filetype6.Instance))
                {
                    MainContainer.Controls.Add(filetype6.Instance);
                    filetype6.Instance.Dock = DockStyle.Fill;
                    filetype6.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    filetype6.Instance.Parent = this;
                }
                filetype6.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }


        private void elmType8_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(filetype8.Instance))
                {
                    MainContainer.Controls.Add(filetype8.Instance);
                    filetype8.Instance.Dock = DockStyle.Fill;
                    filetype8.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    filetype8.Instance.Parent = this;
                }
                filetype8.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }

        private void elmTypeB_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(fileTypeB.Instance))
                {
                    MainContainer.Controls.Add(fileTypeB.Instance);
                    fileTypeB.Instance.Dock = DockStyle.Fill;
                    fileTypeB.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    fileTypeB.Instance.Parent = this;
                }
                fileTypeB.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }

        private void elmTypeC_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(fileTypeC.Instance))
                {
                    MainContainer.Controls.Add(fileTypeC.Instance);
                    fileTypeC.Instance.Dock = DockStyle.Fill;
                    fileTypeC.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    fileTypeC.Instance.Parent = this;
                }
                fileTypeC.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }

        private void elmTypeE_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(filetypeE.Instance))
                {
                    MainContainer.Controls.Add(filetypeE.Instance);
                    filetypeE.Instance.Dock = DockStyle.Fill;
                    filetypeE.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    filetypeE.Instance.Parent = this;
                }
                filetypeE.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }

        private void elmTypeP_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(filetypeP.Instance))
                {
                    MainContainer.Controls.Add(filetypeP.Instance);
                    filetypeP.Instance.Dock = DockStyle.Fill;
                    filetypeP.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    filetypeP.Instance.Parent = this;
                }
                filetypeP.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }

        private void elmTypeR_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(filetypeR.Instance))
                {
                    MainContainer.Controls.Add(filetypeR.Instance);
                    filetypeR.Instance.Dock = DockStyle.Fill;
                    filetypeR.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    filetypeR.Instance.Parent = this;
                }
                filetypeR.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }


        private void elmRiskArray_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(mRiskArray.Instance))
                {
                    MainContainer.Controls.Add(mRiskArray.Instance);
                    mRiskArray.Instance.Dock = DockStyle.Fill;
                    mRiskArray.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    mRiskArray.Instance.Parent = this;
                }
                mRiskArray.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }

        private void elmTypeS_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(filetypeS.Instance))
                {
                    MainContainer.Controls.Add(filetypeS.Instance);
                    filetypeS.Instance.Dock = DockStyle.Fill;
                    filetypeS.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    filetypeS.Instance.Parent = this;
                }
                filetypeS.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }

        private void elmTypeZ_Click(object sender, EventArgs e)
        {
            try
            {
                if (!MainContainer.Controls.Contains(filetypeZ.Instance))
                {
                    MainContainer.Controls.Add(filetypeZ.Instance);
                    filetypeZ.Instance.Dock = DockStyle.Fill;
                    filetypeZ.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    filetypeZ.Instance.Parent = this;
                }
                filetypeZ.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }


        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void elmCCM_Click(object sender, EventArgs e)
        {
            try
            {

                if (!MainContainer.Controls.Contains(mCCM.Instance))
                {
                    MainContainer.Controls.Add(mCCM.Instance);
                    mCCM.Instance.Dock = DockStyle.Fill;
                    mCCM.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    mCCM.Instance.Parent = this;
                }
                mCCM.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }



        private void elmSeriesToSeries_Click(object sender, EventArgs e)
        {
            try
            {

                if (!MainContainer.Controls.Contains(mkSeriesToSeries.Instance))
                {
                    MainContainer.Controls.Add(mkSeriesToSeries.Instance);
                    mkSeriesToSeries.Instance.Dock = DockStyle.Fill;
                    mkSeriesToSeries.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    mkSeriesToSeries.Instance.Parent = this;
                }
                mkSeriesToSeries.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }



        private void elmTierToTier_Click(object sender, EventArgs e)
        {
            try
            {

                if (!MainContainer.Controls.Contains(IntraSpread.Instance))
                {
                    MainContainer.Controls.Add(IntraSpread.Instance);
                    IntraSpread.Instance.Dock = DockStyle.Fill;
                    IntraSpread.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    IntraSpread.Instance.Parent = this;
                }
                IntraSpread.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }
        private void elmMrktInfo_Click(object sender, EventArgs e)
        {
            try
            {

                if (!MainContainer.Controls.Contains(mMrktInfo.Instance))
                {
                    MainContainer.Controls.Add(mMrktInfo.Instance);
                    mMrktInfo.Instance.Dock = DockStyle.Fill;
                    mMrktInfo.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    mMrktInfo.Instance.Parent = this;
                }
                mMrktInfo.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }


        private void elmFilePModify_Click(object sender, EventArgs e)
        {
            try
            {

                if (!MainContainer.Controls.Contains(mTypeP.Instance))
                {
                    MainContainer.Controls.Add(mTypeP.Instance);
                    mTypeP.Instance.Dock = DockStyle.Fill;
                    mTypeP.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    mTypeP.Instance.Parent = this;
                }
                mTypeP.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }



        private void elmTierInfo_Click(object sender, EventArgs e)
        {
            try
            {

                if (!MainContainer.Controls.Contains(InterSpread.Instance))
                {
                    MainContainer.Controls.Add(InterSpread.Instance);
                    InterSpread.Instance.Dock = DockStyle.Fill;
                    InterSpread.Instance.BringToFront();

                    //filetype2.Instance.PrintStat += PrintStat;
                    InterSpread.Instance.Parent = this;
                }
                InterSpread.Instance.BringToFront();
            }
            catch (Exception ex)
            {

                //PrintStat(this, ex.Message);
            }
        }

        /// <summary>
        /// SPAN FILE을 LOAD 한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void elmFileLoad_Click(object sender, EventArgs e)
        {


            string strFileName;

            try
            {
                
              


                using (OpenFileDialog OpenDlg = new OpenFileDialog())
                {
                    OpenDlg.InitialDirectory = @"D:\Span\Data";
                    OpenDlg.Title = "Span Data Load";
                    OpenDlg.DefaultExt = "pa2";
                    OpenDlg.Filter = "Tops Data File (*.pa2)|*.pa2";

                    if (OpenDlg.ShowDialog() != DialogResult.OK)
                    {
                        XtraMessageBox.Show("취소 되었습니다.");
                        return;
                    }
                    else
                    {
                        strFileName = OpenDlg.FileName.ToString();
                    }
                }

                string caption = string.Format("SPAN FILE Loading 중 입니다. {0}", Path.GetFileName(strFileName));

                splashScreenManager1.ShowWaitForm();
                splashScreenManager1.SetWaitFormCaption(caption);
                

                using (StreamReader sReader = new StreamReader(strFileName))
                {
                    string line;

                    splashScreenManager1.SetWaitFormDescription("file type 별 구분 문석 중 입니다.");
                    while ((line = sReader.ReadLine()) != null)
                    {
                        if (line.Substring(0, 2).ToString() == "1 ")
                        {
                            _st_type1 st_type1 = new _st_type1();

                            CTrans<_st_type1> trans = new CTrans<_st_type1>();
                            st_type1 = trans.ByteToStruct(line);


                            CSpanData.Instance.mk_type1.AddData(st_type1);


                        }
                        else if (line.Substring(0, 2).ToString() == "2 ")
                        {
                            _st_type2 st_type2 = new _st_type2();

                            CTrans<_st_type2> trans = new CTrans<_st_type2>();
                            st_type2 = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_type2.AddData(st_type2);


                        }

                        else if (line.Substring(0, 2).ToString() == "3 ")
                        {
                            _st_type3 st_type3 = new _st_type3();

                            CTrans<_st_type3> trans = new CTrans<_st_type3>();
                            st_type3 = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_type3.AddData(st_type3);


                        }

                        else if (line.Substring(0, 2).ToString() == "5 ")
                        {
                            _st_type5 st_type5 = new _st_type5();

                            CTrans<_st_type5> trans = new CTrans<_st_type5>();
                            st_type5 = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_type5.AddData(st_type5);


                        }

                        else if (line.Substring(0, 2).ToString() == "6 ")
                        {
                            _st_type6 st_type6 = new _st_type6();

                            CTrans<_st_type6> trans = new CTrans<_st_type6>();
                            st_type6 = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_type6.AddData(st_type6);


                        }

                        else if (line.Substring(0, 2).ToString() == "81")
                        {
                            _st_type81 st_type81 = new _st_type81();

                            CTrans<_st_type81> trans = new CTrans<_st_type81>();
                            st_type81 = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_type81.AddData(st_type81);


                        }

                        else if (line.Substring(0, 2).ToString() == "82")
                        {
                            _st_type82 st_type82 = new _st_type82();

                            CTrans<_st_type82> trans = new CTrans<_st_type82>();
                            st_type82 = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_type82.AddData(st_type82);


                        }

                        else if (line.Substring(0, 2).ToString() == "B ")
                        {
                            _st_typeB st_typeB = new _st_typeB();

                            CTrans<_st_typeB> trans = new CTrans<_st_typeB>();
                            st_typeB = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_typeB.AddData(st_typeB);

                        }

                        else if (line.Substring(0, 2).ToString() == "C ")
                        {
                            _st_typeC st_typeC = new _st_typeC();

                            CTrans<_st_typeC> trans = new CTrans<_st_typeC>();
                            st_typeC = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_typeC.AddData(st_typeC);

                        }


                        else if (line.Substring(0, 2).ToString() == "E ")
                        {
                            _st_typeE st_typeE = new _st_typeE();

                            CTrans<_st_typeE> trans = new CTrans<_st_typeE>();
                            st_typeE = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_typeE.AddData(st_typeE);


                        }

                        else if (line.Substring(0, 2).ToString() == "P ")
                        {
                            _st_typeP st_typeP = new _st_typeP();

                            CTrans<_st_typeP> trans = new CTrans<_st_typeP>();
                            st_typeP = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_typeP.AddData(st_typeP);


                        }
                        else if (line.Substring(0, 2).ToString() == "R ")
                        {
                            _st_typeR st_typeR = new _st_typeR();

                            CTrans<_st_typeR> trans = new CTrans<_st_typeR>();
                            st_typeR = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_typeR.AddData(st_typeR);


                        }

                        else if (line.Substring(0, 2).ToString() == "S ")
                        {
                            _st_typeS st_typeS = new _st_typeS();

                            CTrans<_st_typeS> trans = new CTrans<_st_typeS>();
                            st_typeS = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_typeS.AddData(st_typeS);


                        }

                        else if (line.Substring(0, 2).ToString() == "Z ")
                        {
                            _st_typeZ st_typeZ = new _st_typeZ();

                            CTrans<_st_typeZ> trans = new CTrans<_st_typeZ>();
                            st_typeZ = trans.ByteToStruct(line);

                            CSpanData.Instance.mk_typeZ.AddData(st_typeZ);


                        }
                    }
                }

                splashScreenManager1.SetWaitFormDescription("Market 정보를 Mapping 합니다.");
                //DataTable dt2 = CSpanData.Instance.dt_type2;
                ///당시기준 품목과 Mapping 테이블을 만든다.
                CSpanData.Instance.MakeMarketInfo();


                ///당사기준 품목과 연관된 SeriesToSeries 테이블을 만든다.
                splashScreenManager1.SetWaitFormDescription("SeriesToSeries 정보를 생성합니다.");
                CSpanData.Instance.MakeSeriesToSeries();



                CSpanData.Instance.MakefileP_modify();

                splashScreenManager1.SetWaitFormDescription("RiskArray 정보를 생성합니다. ");
                CSpanData.Instance.MakeRiskArray();

                CSpanData.Instance.MakefileC_Modify();

                splashScreenManager1.SetWaitFormDescription("Inter Tier 정보를 생성합니다. ");
                CSpanData.Instance.MakeInterTierInfo();


                splashScreenManager1.SetWaitFormDescription("Intra Tier 정보를 생성합니다. ");
                CSpanData.Instance.MakeIntraTierInfo();


               
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                splashScreenManager1.CloseWaitForm();
            }

            XtraMessageBox.Show("Loading 완료 되었습니다.");
        }

    }
}
