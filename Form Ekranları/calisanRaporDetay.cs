﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VeritabanıGörsel
{
    public partial class calisanRaporDetay : Form
    {
        public static calisanRaporDetay calisanrapordetay = new calisanRaporDetay();
        public calisanRaporDetay()
        {
            InitializeComponent();
        }

        private void calisanRaporDetay_Load(object sender, EventArgs e)
        {
            calisanRapor1.SetDataSource(raporCalisan.ds.Tables[0]);
           calisanRapor1.SetParameterValue("userName", ""+raporCalisan.kullaniciAdi+"");
            crystalReportViewer1.ReportSource = calisanRapor1;

        }
    }
}
