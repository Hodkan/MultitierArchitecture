using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace MultitierArchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            List<EntityStaff> StaffList = LogicStaff.LLStaffList();
            dataGridView1.DataSource = (StaffList);


        }
    }
}
