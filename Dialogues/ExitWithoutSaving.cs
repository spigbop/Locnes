using Locnes.ToolsService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locnes.Dialogues
{
    public partial class ExitWithoutSaving : Form
    {
        public ExitWithoutSaving()
        {
            InitializeComponent();
        }

        private void comp_cancel_Click(object sender, EventArgs e) => this.Hide();
        private void comp_dontsave_Click(object sender, EventArgs e) => Application.Exit();
    }
}
