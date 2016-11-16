using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13Nov16_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addressBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addressBindingSource.EndEdit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'joinDataSet.JoinView' table. You can move, or remove it, as needed.
            this.joinViewTableAdapter.Fill(this.joinDataSet.JoinView);
        }
    }
}
