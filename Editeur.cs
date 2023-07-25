using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Locnes.ToolsService;
using System.Runtime.InteropServices;

namespace Locnes
{
    public partial class Editeur : Form
    {
        public static Editeur instance;

        public Editeur()
        {
            InitializeComponent();
            instance = this;
        }

        public string OpenFolder { get { return _openfolder; } set { _openfolder = value; programtitle.Text = $"{value} .::. Locnes Editéur 1.0"; } }
        private string _openfolder = null;
        public List<string> OpenPaths = new List<string>() { };
        public List<string> PathFinals = new List<string>() { };
        public int ActivePathIndex = 0;

        private readonly char[] BracketStarters = { '{', '[', '(' };
        private readonly string[] BracketEnders = { "}", "]", ")" };

        private bool prop_cooldown = false;

        private void WriteEvents(object sender, EventArgs e)
        {
            string _thistext = comp_writer.Text;

            if (OpenPaths.Count == 0 && _thistext != "") { OpenPaths.Add("unsaved_0\\Unsaved 1"); PathFinals.Add(_thistext); UpdateOpenFiles(); }
            if (PathFinals.Count != 0) { PathFinals[ActivePathIndex] = _thistext; }

            comp_linecounter.Text = string.Empty;
            for (int _l = 1; _l < comp_writer.Lines.Length + 1; _l++)
            {
                comp_linecounter.AppendText(_l.ToString() + Environment.NewLine);
            }
            if (comp_linecounter.Text == "") comp_linecounter.Text = "1";

            if (_thistext == "") return;
            if (prop_cooldown) { prop_cooldown = false; return; }
            char _textlast = _thistext.Last();
            for (int _i = 0; _i < BracketStarters.Count(); _i++)
            {
                if (_textlast == BracketStarters[_i])
                {
                    string _ender = BracketEnders[_i];
                    comp_writer.AppendText(_ender);
                    prop_cooldown = true;
                    break;
                }
            }
        }

        private void SelectEvents(object sender, EventArgs e)
        {
            int _index = comp_writer.SelectionStart;
            int _line = comp_writer.GetLineFromCharIndex(_index);
            int _col = _index - comp_writer.GetFirstCharIndexFromLine(_line);
            comp_linecount.Text = string.Format("Line {0}, Column {1}", _line + 1, _col + 1);
        }



        private void Editeur_Load(object sender, EventArgs e)
        {
            ToolStripManager.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColors());

            //comp_tools.Hide();
            //comp_searcher_blackout.BackColor = Color.FromArgb(100, Color.Black);
            comp_searcher_blackout.Hide();
            comp_searcher_blackout.Location = new Point(0, 0);

            comp_writer.SelectionTabs = new int[] { 25, 50, 75 };

            SetBeepInternal(comp_writer, false);

            UpdateOpenFiles();
        }



        #region public functions
        public void RequestNewTree(TreeView tree)
        {
            comp_filetree.Nodes.Clear();
            foreach (TreeNode _node in tree.Nodes) { comp_filetree.Nodes.Add(_node.Clone() as TreeNode); comp_filetree.Invalidate(); }
        }
        public void ClearWriter() => comp_writer.Clear();
        public void ToggleSearcher()
        {
            if (comp_searcher_blackout.Visible)
            {
                comp_searcher_blackout.Hide();
                comp_writer.Enabled = true;
            }
            else
            {
                comp_searcher_blackout.Show();
                comp_writer.Enabled = false;
                comp_searcher.Select();
            }
        }
        public List<Control> TabControls = new List<Control>();
        public bool ExtendedWriter = false;
        public void UpdateOpenFiles()
        {
            int _i = 0;
            foreach (Control _cont in TabControls) { _cont.Dispose(); }
            foreach (string _path in OpenPaths)
            {
                Button _tab = new Button();
                _tab.Name = $"tab_{_i}";
                _tab.Parent = comp_tab_template.Parent;
                _tab.Text = Path.GetFileName(_path);
                _tab.Location = new Point(comp_tab_template.Location.X + _i * 142, comp_tab_template.Location.Y);
                _tab.Size = comp_tab_template.Size;
                _tab.Font = comp_tab_template.Font;
                _tab.BackColor = comp_tab_template.BackColor;
                _tab.ForeColor = comp_tab_template.ForeColor;
                _tab.FlatStyle = comp_tab_template.FlatStyle;
                _tab.FlatAppearance.BorderSize = comp_tab_template.FlatAppearance.BorderSize;
                _tab.Click += comp_tab_template_Click;
                _tab.Visible = true;
                comp_splitpanel.Panel2.Controls.Add(_tab);
                TabControls.Add(_tab);
                Button _tabexit = new Button();
                _tabexit.Name = $"tabexit_{_i}";
                _tabexit.Parent = comp_tabexit_template.Parent;
                _tabexit.Location = new Point(comp_tabexit_template.Location.X + _i * 142, comp_tabexit_template.Location.Y);
                _tabexit.Size = comp_tabexit_template.Size;
                _tabexit.ImageKey = comp_tabexit_template.ImageKey;
                _tabexit.ImageList = comp_tabexit_template.ImageList;
                _tabexit.BackColor = comp_tabexit_template.BackColor;
                _tabexit.FlatStyle = comp_tabexit_template.FlatStyle;
                _tabexit.FlatAppearance.BorderSize = comp_tabexit_template.FlatAppearance.BorderSize;
                _tabexit.Click += comp_tabexit_template_Click;
                _tabexit.Visible = true;
                comp_splitpanel.Panel2.Controls.Add(_tabexit);
                TabControls.Add(_tabexit);
                _i++;
            }
            //if (OpenPaths.Count == 0 && !ExtendedWriter)
            //{
            //    comp_writer.Location = new Point(comp_writer.Location.X, comp_writer.Location.Y - 22);
            //    comp_writer.Size = new Size(comp_writer.Size.Width, comp_writer.Size.Height + 22);
            //    comp_linecounter.Location = new Point(comp_linecounter.Location.X, comp_linecounter.Location.Y - 22);
            //    comp_linecounter.Size = new Size(comp_linecounter.Size.Width, comp_linecounter.Size.Height + 22);
            //    ExtendedWriter = true;
            //}
            //else if(OpenPaths.Count != 0 && ExtendedWriter)
            //{
            //    comp_writer.Location = new Point(comp_writer.Location.X, comp_writer.Location.Y + 22);
            //    comp_writer.Size = new Size(comp_writer.Size.Width, comp_writer.Size.Height - 22);
            //    comp_linecounter.Location = new Point(comp_linecounter.Location.X, comp_linecounter.Location.Y + 22);
            //    comp_linecounter.Size = new Size(comp_linecounter.Size.Width, comp_linecounter.Size.Height - 22);
            //    ExtendedWriter = false;
            //}
        }
        #endregion

        public void comp_tab_template_Click(object sender, EventArgs e)
        {
            var _comp = sender as Button;
            int _index = int.Parse(_comp.Name.Split('_')[1]);
            comp_writer.Text = PathFinals[_index];
            ActivePathIndex = _index;
        }

        public void SelectLastTab()
        {
            if (PathFinals.Count == 0) { comp_writer.Clear(); ActivePathIndex = 0; return; }
            comp_writer.Text = PathFinals.Last();
            ActivePathIndex = PathFinals.Count - 1;
        }

        public void comp_tabexit_template_Click(object sender, EventArgs e)
        {
            var _comp = sender as Button;
            int _index = int.Parse(_comp.Name.Split('_')[1]);
            OpenPaths.RemoveAt(_index);
            PathFinals.RemoveAt(_index);
            UpdateOpenFiles();
            if (PathFinals.Count == 0) { comp_writer.Clear(); ActivePathIndex = 0; return; }
            if (ActivePathIndex == _index) { SelectPreviousTab(); }
        }

        public void SelectPreviousTab()
        {
            if (PathFinals.Count == 0) { comp_writer.Clear(); ActivePathIndex = 0; return; }
            if (ActivePathIndex == 0) { SelectNextTab(); return; }
            ActivePathIndex = ActivePathIndex - 1;
            comp_writer.Text = PathFinals[ActivePathIndex];
        }

        public void SelectNextTab()
        {
            if (PathFinals.Count == 0) { comp_writer.Clear(); ActivePathIndex = 0; return; }
            if (PathFinals.Count! > ActivePathIndex) { SelectLastTab(); return; }
            ActivePathIndex = ActivePathIndex + 1;
            comp_writer.Text = PathFinals[ActivePathIndex];
        }

        #region redone systems
        private bool movelimited = false;
        private void DragWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !movelimited)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void comp_filetree_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            if (e.Bounds.Height == 0 || e.Node == null)
                return;

            int _parentincrement = (e.Node.FullPath.Split('\\').Length - 1) * 18;

            if (e.Node.Nodes.Count > 0)
            {
                if (!e.Node.IsExpanded)
                    e.Graphics.DrawImage(comp_smallbuttonlist.Images[3],
                        new PointF(e.Bounds.X + e.Bounds.Height / 10 + 5 + _parentincrement, e.Bounds.Y + e.Bounds.Height / 10));
                else
                    e.Graphics.DrawImage(comp_smallbuttonlist.Images[2],
                        new PointF(e.Bounds.X + e.Bounds.Height / 10 + 5 + _parentincrement, e.Bounds.Y + e.Bounds.Height / 10));
            }

            try
            {
                e.Graphics.DrawImage(comp_iconlist.Images[e.Node.ImageKey],
                    new Point(e.Bounds.X + e.Bounds.Height + _parentincrement, e.Bounds.Y - 1));
            }
            catch
            {
                e.Graphics.DrawImage(comp_iconlist.Images[0],
                    new Point(e.Bounds.X + e.Bounds.Height + _parentincrement, e.Bounds.Y - 1));
            }
            var _textcol = Color.FromArgb(180, 180, 180);
            if (e.Node.IsSelected && e.Node.ImageKey != "folder-16.png") { _textcol = SystemColors.ActiveCaption; }
            e.Graphics.DrawString(e.Node.Text, new Font(comp_filetree.Font, comp_filetree.Font.Style),
                new SolidBrush(_textcol),
                new Rectangle(e.Bounds.X + e.Bounds.Height + _parentincrement + 16, e.Bounds.Y + 1, e.Bounds.Width, e.Bounds.Height));
        }
        #endregion

        #region passers to ToolsService.Actions
        private void prop_exit_Click(object sender, EventArgs e) => Actions.ExitApp();
        private void comp_hidebutton_Click(object sender, EventArgs e) => Actions.MinimiseApp();
        private void prop_openfolder_Click(object sender, EventArgs e) => Actions.OpenFolder();
        private void prop_open_Click(object sender, EventArgs e) => Actions.OpenFiles();
        private void comp_filetree_DoubleClick(object sender, EventArgs e) => Actions.OpenFiles(new string[] { Path.Combine(OpenFolder, comp_filetree.SelectedNode.Name) });
        private void prop_save_Click(object sender, EventArgs e) => Actions.SaveStream(PathFinals[ActivePathIndex], OpenPaths[ActivePathIndex]);
        private void prop_saveas_Click(object sender, EventArgs e) => Actions.SaveStream(PathFinals[ActivePathIndex]);
        private void prop_searcher_Click(object sender, EventArgs e) => ToggleSearcher();
        #endregion

        #region user32.dll code 

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static void SetBeepInternal(RichTextBox rtb, bool beepOn)
        {
            const Int32 WM_USER = 0x400;
            const Int32 EM_GETOLEINTERFACE = WM_USER + 60;
            const Int32 COMFalse = 0;
            const Int32 COMTrue = ~COMFalse; // -1

            ITextServices textServices = null;
            SendMessage(new HandleRef(rtb, rtb.Handle), EM_GETOLEINTERFACE, IntPtr.Zero, ref textServices);
            textServices.OnTxPropertyBitsChange(TXTBIT.ALLOWBEEP, beepOn ? COMTrue : COMFalse);
            Marshal.ReleaseComObject(textServices);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private extern static IntPtr SendMessage(HandleRef hWnd, Int32 msg, IntPtr wParam, ref ITextServices lParam);

        

        [ComImport(), Guid("8d33f740-cf58-11ce-a89d-00aa006cadc5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface ITextServices
        {
            //see: Slots in the V-table
            //     https://learn.microsoft.com/en-us/dotnet/framework/unmanaged-api/metadata/imetadataemit-definemethod-method#slots-in-the-v-table
            void _VtblGap1_16();
            Int32 OnTxPropertyBitsChange(TXTBIT dwMask, Int32 dwBits);
        }

        private enum TXTBIT : uint
        {
            /// <summary>If TRUE, beeping is enabled.</summary>
            ALLOWBEEP = 0x800
        }
        #endregion
    }

    public class CustomProfessionalColors : ProfessionalColorTable
    {
        public override Color ToolStripGradientBegin
        { get { return Color.FromArgb(35, 35, 35); } }

        public override Color ToolStripGradientMiddle
        { get { return Color.FromArgb(35, 35, 35); } }

        public override Color ToolStripGradientEnd
        { get { return Color.FromArgb(35, 35, 35); } }

        public override Color MenuStripGradientBegin
        { get { return Color.FromArgb(35, 35, 35); } }

        public override Color MenuStripGradientEnd
        { get { return Color.FromArgb(35, 35, 35); } }

        public override Color ToolStripBorder
        { get { return Color.FromArgb(35, 35, 35); } }

        public override Color ToolStripDropDownBackground
        { get { return Color.FromArgb(42, 42, 42); } }

        public override Color ImageMarginGradientBegin
        { get { return Color.FromArgb(42, 42, 42); } }

        public override Color ImageMarginGradientEnd
        { get { return Color.FromArgb(42, 42, 42); } }

        public override Color ImageMarginGradientMiddle
        { get { return Color.FromArgb(42, 42, 42); } }

        public override Color MenuItemPressedGradientBegin
        { get { return Color.FromArgb(42, 42, 42); } }

        public override Color MenuItemPressedGradientEnd
        { get { return Color.FromArgb(42, 42, 42); } }

        public override Color MenuItemPressedGradientMiddle
        { get { return Color.FromArgb(42, 42, 42); } }

        public override Color MenuItemSelectedGradientBegin
        { get { return Color.FromArgb(42, 42, 42); } }

        public override Color MenuItemSelectedGradientEnd
        { get { return Color.FromArgb(42, 42, 42); } }



        public override Color ButtonPressedBorder
        { get { return Color.FromArgb(35, 35, 35); } }

        public override Color MenuItemSelected
        { get { return Color.FromArgb(35, 35, 35); } }
    }


}
