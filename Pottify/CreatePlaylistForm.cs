using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pottify
{
    public partial class CreatePlaylistForm : Form
    {
        public CreatePlaylistForm()
        {
            InitializeComponent();
        }

        public string name = "";
        public string description = "";
        private ErrorProvider errorProvider = new();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            name = textName.Text;
            description = textDescription.Text;
            if (name == "")
            {
                errorProvider.SetError(textName, "Name cant be empty");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
