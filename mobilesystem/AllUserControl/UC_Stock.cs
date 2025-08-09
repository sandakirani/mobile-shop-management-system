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

namespace mobilesystem.AllUserControl
{
    public partial class UC_Stock : UserControl
    {
        function fn = new function();
        String query;
        public UC_Stock()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void UC_Stock_Enter(object sender, EventArgs e)
        {

            query = "select * from newMobile";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int bid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "select * from newMobile where mid = " + bid + "";
            DataSet ds = fn.getData(query);

            Companylabel.Text = ds.Tables[0].Rows[0][1].ToString();
            Modellabel.Text = ds.Tables[0].Rows[0][2].ToString();
            Ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            Internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            Expandablelabel.Text = ds.Tables[0].Rows[0][5].ToString();
            Displaylabel.Text = ds.Tables[0].Rows[0][6].ToString();
            Rearlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            Frontlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            Fingerprintlabel.Text = ds.Tables[0].Rows[0][9].ToString();
            Simlabel.Text = ds.Tables[0].Rows[0][10].ToString();
            Networklabel.Text = ds.Tables[0].Rows[0][11].ToString();
            Pricelabel.Text = ds.Tables[0].Rows[0][12].ToString();
        }


    }
}
