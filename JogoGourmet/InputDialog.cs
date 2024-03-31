using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet
{
    public partial class InputDialog : Form
    {
        public string UserInput { get; private set; }
        public InputDialog(string label)
        {
            InitializeComponent();
            labelDialog.Text = label;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            UserInput = textBoxDialog.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
