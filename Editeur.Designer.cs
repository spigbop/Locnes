namespace Locnes
{
    partial class Editeur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editeur));
            comp_filetree = new TreeView();
            comp_rightclicker = new ContextMenuStrip(components);
            comp_rightclick_button_template = new ToolStripMenuItem();
            comp_iconlist = new ImageList(components);
            comp_headerpanel = new Panel();
            comp_tools = new ToolStrip();
            comp_tools_file = new ToolStripDropDownButton();
            prop_save = new ToolStripMenuItem();
            prop_saveas = new ToolStripMenuItem();
            prop_exit = new ToolStripMenuItem();
            comp_tools_view = new ToolStripDropDownButton();
            prop_searcher = new ToolStripMenuItem();
            read_view_searcher = new ToolStripMenuItem();
            comp_splitpanel = new SplitContainer();
            comp_writepanel = new Panel();
            comp_writer = new RichTextBox();
            comp_linecounter = new TextBox();
            comp_searcher_blackout = new Panel();
            comp_searcher_matchpanel = new Panel();
            comp_searcher_matches_shortcuts = new ListBox();
            comp_searcher_matches = new ListBox();
            comp_searcher_boxcontainer = new Panel();
            pictureBox1 = new PictureBox();
            comp_searcher = new TextBox();
            comp_tabexit_template = new Button();
            comp_smallbuttonlist = new ImageList(components);
            comp_tab_template = new Button();
            comp_footerpanel = new Panel();
            eyecandy_resize = new PictureBox();
            comp_linecount = new Label();
            comp_exitbutton = new Button();
            comp_maximizebutton = new Button();
            comp_hidebutton = new Button();
            comp_dragarea = new Panel();
            programtitle = new Label();
            comp_logobutton = new PictureBox();
            prop_open = new ToolStripMenuItem();
            prop_openfolder = new ToolStripMenuItem();
            comp_rightclicker.SuspendLayout();
            comp_headerpanel.SuspendLayout();
            comp_tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comp_splitpanel).BeginInit();
            comp_splitpanel.Panel1.SuspendLayout();
            comp_splitpanel.Panel2.SuspendLayout();
            comp_splitpanel.SuspendLayout();
            comp_writepanel.SuspendLayout();
            comp_searcher_blackout.SuspendLayout();
            comp_searcher_matchpanel.SuspendLayout();
            comp_searcher_boxcontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            comp_footerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eyecandy_resize).BeginInit();
            comp_dragarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comp_logobutton).BeginInit();
            SuspendLayout();
            // 
            // comp_filetree
            // 
            comp_filetree.BackColor = Color.FromArgb(37, 37, 37);
            comp_filetree.BorderStyle = BorderStyle.None;
            comp_filetree.ContextMenuStrip = comp_rightclicker;
            comp_filetree.Dock = DockStyle.Fill;
            comp_filetree.DrawMode = TreeViewDrawMode.OwnerDrawAll;
            comp_filetree.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comp_filetree.ForeColor = SystemColors.ActiveBorder;
            comp_filetree.ImageKey = "file-16.png";
            comp_filetree.ImageList = comp_iconlist;
            comp_filetree.Location = new Point(0, 0);
            comp_filetree.Name = "comp_filetree";
            comp_filetree.Scrollable = false;
            comp_filetree.SelectedImageKey = "file-16.png";
            comp_filetree.Size = new Size(154, 457);
            comp_filetree.TabIndex = 0;
            comp_filetree.DrawNode += comp_filetree_DrawNode;
            comp_filetree.DoubleClick += comp_filetree_DoubleClick;
            // 
            // comp_rightclicker
            // 
            comp_rightclicker.BackColor = Color.FromArgb(42, 42, 42);
            comp_rightclicker.Items.AddRange(new ToolStripItem[] { comp_rightclick_button_template });
            comp_rightclicker.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            comp_rightclicker.Name = "comp_rightclicker";
            comp_rightclicker.Size = new Size(118, 26);
            // 
            // comp_rightclick_button_template
            // 
            comp_rightclick_button_template.DisplayStyle = ToolStripItemDisplayStyle.Text;
            comp_rightclick_button_template.ForeColor = SystemColors.ActiveBorder;
            comp_rightclick_button_template.Name = "comp_rightclick_button_template";
            comp_rightclick_button_template.Size = new Size(117, 22);
            comp_rightclick_button_template.Text = "Rename";
            // 
            // comp_iconlist
            // 
            comp_iconlist.ColorDepth = ColorDepth.Depth16Bit;
            comp_iconlist.ImageStream = (ImageListStreamer)resources.GetObject("comp_iconlist.ImageStream");
            comp_iconlist.TransparentColor = Color.Transparent;
            comp_iconlist.Images.SetKeyName(0, "file-16.png");
            comp_iconlist.Images.SetKeyName(1, "textfile-16.png");
            comp_iconlist.Images.SetKeyName(2, "folder-16.png");
            comp_iconlist.Images.SetKeyName(3, "phyton-16.png");
            comp_iconlist.Images.SetKeyName(4, "c-16.png");
            comp_iconlist.Images.SetKeyName(5, "cplusplus-16.png");
            comp_iconlist.Images.SetKeyName(6, "csharp-16.png");
            comp_iconlist.Images.SetKeyName(7, "javascript-16.png");
            // 
            // comp_headerpanel
            // 
            comp_headerpanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comp_headerpanel.Controls.Add(comp_tools);
            comp_headerpanel.Location = new Point(-6, 23);
            comp_headerpanel.Name = "comp_headerpanel";
            comp_headerpanel.Size = new Size(814, 32);
            comp_headerpanel.TabIndex = 3;
            // 
            // comp_tools
            // 
            comp_tools.Items.AddRange(new ToolStripItem[] { comp_tools_file, comp_tools_view });
            comp_tools.Location = new Point(0, 0);
            comp_tools.Name = "comp_tools";
            comp_tools.Size = new Size(814, 25);
            comp_tools.TabIndex = 5;
            comp_tools.Text = "Tools";
            comp_tools.MouseMove += DragWindow;
            // 
            // comp_tools_file
            // 
            comp_tools_file.DisplayStyle = ToolStripItemDisplayStyle.Text;
            comp_tools_file.DropDownItems.AddRange(new ToolStripItem[] { prop_open, prop_openfolder, prop_save, prop_saveas, prop_exit });
            comp_tools_file.ForeColor = Color.White;
            comp_tools_file.Image = (Image)resources.GetObject("comp_tools_file.Image");
            comp_tools_file.ImageTransparentColor = Color.Magenta;
            comp_tools_file.Name = "comp_tools_file";
            comp_tools_file.Size = new Size(38, 22);
            comp_tools_file.Text = "File";
            // 
            // prop_save
            // 
            prop_save.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            prop_save.ForeColor = SystemColors.ActiveBorder;
            prop_save.Image = (Image)resources.GetObject("prop_save.Image");
            prop_save.Name = "prop_save";
            prop_save.ShortcutKeys = Keys.Control | Keys.S;
            prop_save.Size = new Size(198, 22);
            prop_save.Text = "Save";
            prop_save.Click += prop_save_Click;
            // 
            // prop_saveas
            // 
            prop_saveas.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            prop_saveas.ForeColor = SystemColors.ActiveBorder;
            prop_saveas.Name = "prop_saveas";
            prop_saveas.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            prop_saveas.Size = new Size(198, 22);
            prop_saveas.Text = "Save As";
            prop_saveas.Click += prop_saveas_Click;
            // 
            // prop_exit
            // 
            prop_exit.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            prop_exit.ForeColor = SystemColors.ActiveBorder;
            prop_exit.Name = "prop_exit";
            prop_exit.ShortcutKeys = Keys.Alt | Keys.F4;
            prop_exit.Size = new Size(198, 22);
            prop_exit.Text = "Exit";
            prop_exit.Click += prop_exit_Click;
            // 
            // comp_tools_view
            // 
            comp_tools_view.DisplayStyle = ToolStripItemDisplayStyle.Text;
            comp_tools_view.DropDownItems.AddRange(new ToolStripItem[] { prop_searcher });
            comp_tools_view.ForeColor = Color.White;
            comp_tools_view.Image = (Image)resources.GetObject("comp_tools_view.Image");
            comp_tools_view.ImageTransparentColor = Color.Magenta;
            comp_tools_view.Name = "comp_tools_view";
            comp_tools_view.Size = new Size(45, 22);
            comp_tools_view.Text = "View";
            // 
            // prop_searcher
            // 
            prop_searcher.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            prop_searcher.ForeColor = SystemColors.ActiveBorder;
            prop_searcher.Image = (Image)resources.GetObject("prop_searcher.Image");
            prop_searcher.Name = "prop_searcher";
            prop_searcher.ShortcutKeys = Keys.Control | Keys.Space;
            prop_searcher.Size = new Size(239, 22);
            prop_searcher.Text = "Toggle Searcher";
            prop_searcher.Click += prop_searcher_Click;
            // 
            // read_view_searcher
            // 
            read_view_searcher.Name = "read_view_searcher";
            read_view_searcher.ShortcutKeys = Keys.Control | Keys.Space;
            read_view_searcher.Size = new Size(199, 22);
            read_view_searcher.Text = "Searcher";
            // 
            // comp_splitpanel
            // 
            comp_splitpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comp_splitpanel.Location = new Point(0, 51);
            comp_splitpanel.Name = "comp_splitpanel";
            // 
            // comp_splitpanel.Panel1
            // 
            comp_splitpanel.Panel1.Controls.Add(comp_filetree);
            // 
            // comp_splitpanel.Panel2
            // 
            comp_splitpanel.Panel2.Controls.Add(comp_writepanel);
            comp_splitpanel.Panel2.Controls.Add(comp_searcher_blackout);
            comp_splitpanel.Panel2.Controls.Add(comp_tabexit_template);
            comp_splitpanel.Panel2.Controls.Add(comp_tab_template);
            comp_splitpanel.Size = new Size(800, 457);
            comp_splitpanel.SplitterDistance = 154;
            comp_splitpanel.TabIndex = 4;
            // 
            // comp_writepanel
            // 
            comp_writepanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comp_writepanel.BackColor = Color.FromArgb(42, 42, 42);
            comp_writepanel.Controls.Add(comp_writer);
            comp_writepanel.Controls.Add(comp_linecounter);
            comp_writepanel.Location = new Point(1, 26);
            comp_writepanel.Name = "comp_writepanel";
            comp_writepanel.Size = new Size(641, 431);
            comp_writepanel.TabIndex = 4;
            // 
            // comp_writer
            // 
            comp_writer.AcceptsTab = true;
            comp_writer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comp_writer.BackColor = Color.FromArgb(42, 42, 42);
            comp_writer.BorderStyle = BorderStyle.None;
            comp_writer.ForeColor = SystemColors.ActiveBorder;
            comp_writer.Location = new Point(46, 0);
            comp_writer.Name = "comp_writer";
            comp_writer.Size = new Size(592, 431);
            comp_writer.TabIndex = 2;
            comp_writer.Text = "";
            comp_writer.SelectionChanged += SelectEvents;
            comp_writer.TextChanged += WriteEvents;
            // 
            // comp_linecounter
            // 
            comp_linecounter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comp_linecounter.BackColor = Color.FromArgb(42, 42, 42);
            comp_linecounter.BorderStyle = BorderStyle.None;
            comp_linecounter.Cursor = Cursors.UpArrow;
            comp_linecounter.Enabled = false;
            comp_linecounter.ForeColor = Color.FromArgb(120, 120, 120);
            comp_linecounter.Location = new Point(0, 0);
            comp_linecounter.Multiline = true;
            comp_linecounter.Name = "comp_linecounter";
            comp_linecounter.Size = new Size(34, 431);
            comp_linecounter.TabIndex = 1;
            comp_linecounter.Text = "1";
            comp_linecounter.TextAlign = HorizontalAlignment.Right;
            // 
            // comp_searcher_blackout
            // 
            comp_searcher_blackout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comp_searcher_blackout.BackColor = Color.Transparent;
            comp_searcher_blackout.Controls.Add(comp_searcher_matchpanel);
            comp_searcher_blackout.Controls.Add(comp_searcher_boxcontainer);
            comp_searcher_blackout.Location = new Point(3000, 0);
            comp_searcher_blackout.Name = "comp_searcher_blackout";
            comp_searcher_blackout.Size = new Size(487, 518);
            comp_searcher_blackout.TabIndex = 3;
            // 
            // comp_searcher_matchpanel
            // 
            comp_searcher_matchpanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comp_searcher_matchpanel.BackColor = Color.FromArgb(42, 42, 42);
            comp_searcher_matchpanel.Controls.Add(comp_searcher_matches_shortcuts);
            comp_searcher_matchpanel.Controls.Add(comp_searcher_matches);
            comp_searcher_matchpanel.Location = new Point(145, 60);
            comp_searcher_matchpanel.Name = "comp_searcher_matchpanel";
            comp_searcher_matchpanel.Size = new Size(62, 90);
            comp_searcher_matchpanel.TabIndex = 2;
            // 
            // comp_searcher_matches_shortcuts
            // 
            comp_searcher_matches_shortcuts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            comp_searcher_matches_shortcuts.BackColor = Color.FromArgb(42, 42, 42);
            comp_searcher_matches_shortcuts.BorderStyle = BorderStyle.None;
            comp_searcher_matches_shortcuts.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comp_searcher_matches_shortcuts.ForeColor = Color.FromArgb(120, 120, 120);
            comp_searcher_matches_shortcuts.FormattingEnabled = true;
            comp_searcher_matches_shortcuts.ItemHeight = 16;
            comp_searcher_matches_shortcuts.Items.AddRange(new object[] { "", "Ctrl + Alt + \\", "Ctrl + Shift + S" });
            comp_searcher_matches_shortcuts.Location = new Point(-181, 4);
            comp_searcher_matches_shortcuts.Name = "comp_searcher_matches_shortcuts";
            comp_searcher_matches_shortcuts.Size = new Size(86, 80);
            comp_searcher_matches_shortcuts.TabIndex = 2;
            // 
            // comp_searcher_matches
            // 
            comp_searcher_matches.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comp_searcher_matches.BackColor = Color.FromArgb(42, 42, 42);
            comp_searcher_matches.BorderStyle = BorderStyle.None;
            comp_searcher_matches.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comp_searcher_matches.ForeColor = SystemColors.ActiveBorder;
            comp_searcher_matches.FormattingEnabled = true;
            comp_searcher_matches.ItemHeight = 16;
            comp_searcher_matches.Items.AddRange(new object[] { "View  ▶  Toolbox", "Edit  ▶  Toggle Comment", "File  ▶  Save All Open" });
            comp_searcher_matches.Location = new Point(3, 4);
            comp_searcher_matches.Name = "comp_searcher_matches";
            comp_searcher_matches.Size = new Size(0, 80);
            comp_searcher_matches.TabIndex = 1;
            // 
            // comp_searcher_boxcontainer
            // 
            comp_searcher_boxcontainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comp_searcher_boxcontainer.BackColor = Color.FromArgb(42, 42, 42);
            comp_searcher_boxcontainer.Controls.Add(pictureBox1);
            comp_searcher_boxcontainer.Controls.Add(comp_searcher);
            comp_searcher_boxcontainer.Location = new Point(145, 22);
            comp_searcher_boxcontainer.Name = "comp_searcher_boxcontainer";
            comp_searcher_boxcontainer.Size = new Size(62, 32);
            comp_searcher_boxcontainer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // comp_searcher
            // 
            comp_searcher.BackColor = Color.FromArgb(42, 42, 42);
            comp_searcher.BorderStyle = BorderStyle.None;
            comp_searcher.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comp_searcher.ForeColor = SystemColors.ActiveBorder;
            comp_searcher.Location = new Point(33, 8);
            comp_searcher.Name = "comp_searcher";
            comp_searcher.Size = new Size(301, 16);
            comp_searcher.TabIndex = 0;
            // 
            // comp_tabexit_template
            // 
            comp_tabexit_template.AutoSize = true;
            comp_tabexit_template.BackColor = Color.FromArgb(48, 48, 48);
            comp_tabexit_template.FlatAppearance.BorderSize = 0;
            comp_tabexit_template.FlatStyle = FlatStyle.Flat;
            comp_tabexit_template.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comp_tabexit_template.ForeColor = SystemColors.ActiveBorder;
            comp_tabexit_template.ImageKey = "dismiss-10.png";
            comp_tabexit_template.ImageList = comp_smallbuttonlist;
            comp_tabexit_template.Location = new Point(114, 0);
            comp_tabexit_template.Name = "comp_tabexit_template";
            comp_tabexit_template.Size = new Size(26, 27);
            comp_tabexit_template.TabIndex = 2;
            comp_tabexit_template.TextAlign = ContentAlignment.MiddleLeft;
            comp_tabexit_template.UseVisualStyleBackColor = false;
            comp_tabexit_template.Visible = false;
            comp_tabexit_template.Click += comp_tabexit_template_Click;
            // 
            // comp_smallbuttonlist
            // 
            comp_smallbuttonlist.ColorDepth = ColorDepth.Depth8Bit;
            comp_smallbuttonlist.ImageStream = (ImageListStreamer)resources.GetObject("comp_smallbuttonlist.ImageStream");
            comp_smallbuttonlist.TransparentColor = Color.Transparent;
            comp_smallbuttonlist.Images.SetKeyName(0, "changes-10.png");
            comp_smallbuttonlist.Images.SetKeyName(1, "dismiss-10.png");
            comp_smallbuttonlist.Images.SetKeyName(2, "collapse-10.png");
            comp_smallbuttonlist.Images.SetKeyName(3, "expand-10.png");
            comp_smallbuttonlist.Images.SetKeyName(4, "minimize-10.png");
            comp_smallbuttonlist.Images.SetKeyName(5, "maximize-10.png");
            comp_smallbuttonlist.Images.SetKeyName(6, "hide-10.png");
            comp_smallbuttonlist.Images.SetKeyName(7, "resize-10.png");
            // 
            // comp_tab_template
            // 
            comp_tab_template.AutoSize = true;
            comp_tab_template.BackColor = Color.FromArgb(48, 48, 48);
            comp_tab_template.FlatAppearance.BorderSize = 0;
            comp_tab_template.FlatStyle = FlatStyle.Flat;
            comp_tab_template.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comp_tab_template.ForeColor = SystemColors.ActiveBorder;
            comp_tab_template.Location = new Point(1, 0);
            comp_tab_template.Name = "comp_tab_template";
            comp_tab_template.Size = new Size(115, 27);
            comp_tab_template.TabIndex = 1;
            comp_tab_template.Text = "Template";
            comp_tab_template.TextAlign = ContentAlignment.MiddleLeft;
            comp_tab_template.UseVisualStyleBackColor = false;
            comp_tab_template.Visible = false;
            // 
            // comp_footerpanel
            // 
            comp_footerpanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comp_footerpanel.BackColor = Color.FromArgb(35, 35, 35);
            comp_footerpanel.Controls.Add(eyecandy_resize);
            comp_footerpanel.Controls.Add(comp_linecount);
            comp_footerpanel.Location = new Point(-6, 506);
            comp_footerpanel.Name = "comp_footerpanel";
            comp_footerpanel.Size = new Size(813, 27);
            comp_footerpanel.TabIndex = 5;
            // 
            // eyecandy_resize
            // 
            eyecandy_resize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            eyecandy_resize.Image = (Image)resources.GetObject("eyecandy_resize.Image");
            eyecandy_resize.Location = new Point(793, 11);
            eyecandy_resize.Name = "eyecandy_resize";
            eyecandy_resize.Size = new Size(10, 10);
            eyecandy_resize.TabIndex = 1;
            eyecandy_resize.TabStop = false;
            // 
            // comp_linecount
            // 
            comp_linecount.AutoSize = true;
            comp_linecount.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comp_linecount.ImageAlign = ContentAlignment.MiddleLeft;
            comp_linecount.ImageKey = "(none)";
            comp_linecount.Location = new Point(12, 5);
            comp_linecount.Name = "comp_linecount";
            comp_linecount.Size = new Size(95, 16);
            comp_linecount.TabIndex = 0;
            comp_linecount.Text = "Line 1, Column 1";
            // 
            // comp_exitbutton
            // 
            comp_exitbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comp_exitbutton.BackColor = Color.FromArgb(35, 35, 35);
            comp_exitbutton.FlatAppearance.BorderSize = 0;
            comp_exitbutton.FlatStyle = FlatStyle.Flat;
            comp_exitbutton.ImageKey = "dismiss-10.png";
            comp_exitbutton.ImageList = comp_smallbuttonlist;
            comp_exitbutton.Location = new Point(776, 0);
            comp_exitbutton.Name = "comp_exitbutton";
            comp_exitbutton.Size = new Size(24, 24);
            comp_exitbutton.TabIndex = 6;
            comp_exitbutton.UseVisualStyleBackColor = false;
            comp_exitbutton.Click += prop_exit_Click;
            // 
            // comp_maximizebutton
            // 
            comp_maximizebutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comp_maximizebutton.BackColor = Color.FromArgb(35, 35, 35);
            comp_maximizebutton.FlatAppearance.BorderSize = 0;
            comp_maximizebutton.FlatStyle = FlatStyle.Flat;
            comp_maximizebutton.ImageKey = "maximize-10.png";
            comp_maximizebutton.ImageList = comp_smallbuttonlist;
            comp_maximizebutton.Location = new Point(752, 0);
            comp_maximizebutton.Name = "comp_maximizebutton";
            comp_maximizebutton.Size = new Size(24, 24);
            comp_maximizebutton.TabIndex = 7;
            comp_maximizebutton.UseVisualStyleBackColor = false;
            // 
            // comp_hidebutton
            // 
            comp_hidebutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comp_hidebutton.BackColor = Color.FromArgb(35, 35, 35);
            comp_hidebutton.FlatAppearance.BorderSize = 0;
            comp_hidebutton.FlatStyle = FlatStyle.Flat;
            comp_hidebutton.ImageKey = "hide-10.png";
            comp_hidebutton.ImageList = comp_smallbuttonlist;
            comp_hidebutton.Location = new Point(728, 0);
            comp_hidebutton.Name = "comp_hidebutton";
            comp_hidebutton.Size = new Size(24, 24);
            comp_hidebutton.TabIndex = 8;
            comp_hidebutton.UseVisualStyleBackColor = false;
            comp_hidebutton.Click += comp_hidebutton_Click;
            // 
            // comp_dragarea
            // 
            comp_dragarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comp_dragarea.BackColor = Color.FromArgb(35, 35, 35);
            comp_dragarea.Controls.Add(programtitle);
            comp_dragarea.Controls.Add(comp_logobutton);
            comp_dragarea.Location = new Point(0, 0);
            comp_dragarea.Name = "comp_dragarea";
            comp_dragarea.Size = new Size(800, 55);
            comp_dragarea.TabIndex = 9;
            comp_dragarea.MouseMove += DragWindow;
            // 
            // programtitle
            // 
            programtitle.AutoSize = true;
            programtitle.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            programtitle.ForeColor = Color.White;
            programtitle.Location = new Point(26, 5);
            programtitle.Name = "programtitle";
            programtitle.Size = new Size(110, 16);
            programtitle.TabIndex = 1;
            programtitle.Text = "Locnes Editéur 1.0";
            programtitle.MouseMove += DragWindow;
            // 
            // comp_logobutton
            // 
            comp_logobutton.Image = (Image)resources.GetObject("comp_logobutton.Image");
            comp_logobutton.Location = new Point(4, 5);
            comp_logobutton.Name = "comp_logobutton";
            comp_logobutton.Size = new Size(16, 16);
            comp_logobutton.TabIndex = 0;
            comp_logobutton.TabStop = false;
            // 
            // prop_open
            // 
            prop_open.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            prop_open.ForeColor = SystemColors.ActiveBorder;
            prop_open.Name = "prop_open";
            prop_open.Size = new Size(198, 22);
            prop_open.Text = "Open File";
            prop_open.Click += prop_open_Click;
            // 
            // prop_openfolder
            // 
            prop_openfolder.Font = new Font("Bahnschrift", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            prop_openfolder.ForeColor = SystemColors.ActiveBorder;
            prop_openfolder.Name = "prop_openfolder";
            prop_openfolder.Size = new Size(198, 22);
            prop_openfolder.Text = "Open Folder";
            // 
            // Editeur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            ClientSize = new Size(800, 530);
            Controls.Add(comp_hidebutton);
            Controls.Add(comp_maximizebutton);
            Controls.Add(comp_exitbutton);
            Controls.Add(comp_splitpanel);
            Controls.Add(comp_footerpanel);
            Controls.Add(comp_headerpanel);
            Controls.Add(comp_dragarea);
            Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Editeur";
            Text = "C:\\ThatProject\\MyFolder\\MyFile.txt .::. Locnes Editéur 1.0";
            Load += Editeur_Load;
            comp_rightclicker.ResumeLayout(false);
            comp_headerpanel.ResumeLayout(false);
            comp_headerpanel.PerformLayout();
            comp_tools.ResumeLayout(false);
            comp_tools.PerformLayout();
            comp_splitpanel.Panel1.ResumeLayout(false);
            comp_splitpanel.Panel2.ResumeLayout(false);
            comp_splitpanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comp_splitpanel).EndInit();
            comp_splitpanel.ResumeLayout(false);
            comp_writepanel.ResumeLayout(false);
            comp_writepanel.PerformLayout();
            comp_searcher_blackout.ResumeLayout(false);
            comp_searcher_matchpanel.ResumeLayout(false);
            comp_searcher_boxcontainer.ResumeLayout(false);
            comp_searcher_boxcontainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            comp_footerpanel.ResumeLayout(false);
            comp_footerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eyecandy_resize).EndInit();
            comp_dragarea.ResumeLayout(false);
            comp_dragarea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comp_logobutton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView comp_filetree;
        private ImageList comp_iconlist;
        private TabPage comp_writertab;
        private Panel comp_headerpanel;
        private SplitContainer comp_splitpanel;
        private Panel comp_footer;
        private Panel comp_footerpanel;
        private Button comp_tab_template;
        private Button comp_tabexit_template;
        private ImageList comp_smallbuttonlist;
        private Label comp_linecount;
        private ContextMenuStrip comp_rightclicker;
        private ToolStripMenuItem comp_rightclick_button_template;
        private Panel comp_searcher_blackout;
        private Panel comp_searcher_boxcontainer;
        private PictureBox pictureBox1;
        private TextBox comp_searcher;
        private Panel comp_searcher_matchpanel;
        private ListBox comp_searcher_matches;
        private ListBox comp_searcher_matches_shortcuts;
        private ToolStrip comp_tools;
        private ToolStripDropDownButton read_view;
        private ToolStripMenuItem read_view_searcher;
        private ToolStripDropDownButton comp_tools_file;
        private ToolStripMenuItem prop_exit;
        private Panel comp_writepanel;
        private TextBox comp_linecounter;
        private Button comp_exitbutton;
        private Button comp_maximizebutton;
        private Button comp_hidebutton;
        private Panel comp_dragarea;
        private PictureBox comp_logobutton;
        private Label programtitle;
        private PictureBox eyecandy_resize;
        private RichTextBox comp_writer;
        private ToolStripDropDownButton comp_tools_view;
        private ToolStripMenuItem prop_save;
        private ToolStripMenuItem prop_saveas;
        private ToolStripMenuItem prop_searcher;
        private ToolStripMenuItem prop_open;
        private ToolStripMenuItem prop_openfolder;
    }
}