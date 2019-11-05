using KiemTra.DAL.Entity;
using KiemTraGiuaKi.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraGiuaKi
{
    public partial class Form1 : Form
    {
        List<danh_sach> danhSach;
        List<NhomDS> nhomDS;
        string pathData;
        string pathDataNhom;

        public Form1()
        {
            
            InitializeComponent();
            pathDataNhom = Application.StartupPath + @"\data\tennhom.data";
            pathData = Application.StartupPath + @"\data\dulieu.data";
            
            dgv1.AutoGenerateColumns = false;

            nhomDS = NhomDS.GetListFromFile(pathDataNhom);
            bds1.DataSource = nhomDS;
            dgv1.DataSource = bds1;
        }

        private void ToolStripLabel5_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var nhomDS = (NhomDS)bds1.Current;
            danhSach = danh_sach.GetFromFile(pathData, nhomDS.TenNhom);
            dgv2.AutoGenerateColumns = false;
            bds2.DataSource = danhSach;
            dgv2.DataSource = bds2;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
