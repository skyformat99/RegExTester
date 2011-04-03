using System.Windows.Forms;

namespace RegExTester
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    partial class frmMain
    {


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.sbpStatus = new System.Windows.Forms.StatusBarPanel();
            this.sbpContext = new System.Windows.Forms.StatusBarPanel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.llRegExCheatSheet = new System.Windows.Forms.LinkLabel();
            this.llRegExLibrary = new System.Windows.Forms.LinkLabel();
            this.llIndentedInput = new System.Windows.Forms.LinkLabel();
            this.cbIndentedInput = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.llAbout = new System.Windows.Forms.LinkLabel();
            this.cbCultureInvariant = new System.Windows.Forms.CheckBox();
            this.llCultureInvariant = new System.Windows.Forms.LinkLabel();
            this.llSingleLine = new System.Windows.Forms.LinkLabel();
            this.llMultiLine = new System.Windows.Forms.LinkLabel();
            this.llIgnoreCase = new System.Windows.Forms.LinkLabel();
            this.cbSingleLine = new System.Windows.Forms.CheckBox();
            this.cbMultiLine = new System.Windows.Forms.CheckBox();
            this.cbIgnoreCase = new System.Windows.Forms.CheckBox();
            this.txtRegEx = new System.Windows.Forms.TextBox();
            this.lblRegEx = new System.Windows.Forms.Label();
            this.nestedSplitContainer = new System.Windows.Forms.SplitContainer();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.rtbTextContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.undoTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator1TSMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.cutTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator2TSMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.findTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator3TSMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblText = new System.Windows.Forms.Label();
            this.lvResult = new System.Windows.Forms.ListView();
            this.chMatch = new System.Windows.Forms.ColumnHeader();
            this.chPosition = new System.Windows.Forms.ColumnHeader();
            this.chLenght = new System.Windows.Forms.ColumnHeader();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnCopyContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyGeneric1TSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGeneric2TSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyGeneric3TSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sbpStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpContext)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.nestedSplitContainer.Panel1.SuspendLayout();
            this.nestedSplitContainer.Panel2.SuspendLayout();
            this.nestedSplitContainer.SuspendLayout();
            this.rtbTextContextMenuStrip.SuspendLayout();
            this.btnCopyContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 435);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.sbpStatus,
            this.sbpContext});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(765, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusBar";
            // 
            // sbpStatus
            // 
            this.sbpStatus.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.sbpStatus.Name = "sbpStatus";
            this.sbpStatus.Text = "Nothing searched yet.";
            this.sbpStatus.Width = 739;
            // 
            // sbpContext
            // 
            this.sbpContext.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
            this.sbpContext.Name = "sbpContext";
            this.sbpContext.Width = 10;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.llRegExCheatSheet);
            this.splitContainer.Panel1.Controls.Add(this.llRegExLibrary);
            this.splitContainer.Panel1.Controls.Add(this.llIndentedInput);
            this.splitContainer.Panel1.Controls.Add(this.cbIndentedInput);
            this.splitContainer.Panel1.Controls.Add(this.btnCopy);
            this.splitContainer.Panel1.Controls.Add(this.btnTest);
            this.splitContainer.Panel1.Controls.Add(this.llAbout);
            this.splitContainer.Panel1.Controls.Add(this.cbCultureInvariant);
            this.splitContainer.Panel1.Controls.Add(this.llCultureInvariant);
            this.splitContainer.Panel1.Controls.Add(this.llSingleLine);
            this.splitContainer.Panel1.Controls.Add(this.llMultiLine);
            this.splitContainer.Panel1.Controls.Add(this.llIgnoreCase);
            this.splitContainer.Panel1.Controls.Add(this.cbSingleLine);
            this.splitContainer.Panel1.Controls.Add(this.cbMultiLine);
            this.splitContainer.Panel1.Controls.Add(this.cbIgnoreCase);
            this.splitContainer.Panel1.Controls.Add(this.txtRegEx);
            this.splitContainer.Panel1.Controls.Add(this.lblRegEx);
            this.splitContainer.Panel1MinSize = 90;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.nestedSplitContainer);
            this.splitContainer.Size = new System.Drawing.Size(765, 435);
            this.splitContainer.SplitterDistance = 90;
            this.splitContainer.TabIndex = 0;
            // 
            // llRegExCheatSheet
            // 
            this.llRegExCheatSheet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llRegExCheatSheet.AutoSize = true;
            this.llRegExCheatSheet.Location = new System.Drawing.Point(425, 5);
            this.llRegExCheatSheet.Name = "llRegExCheatSheet";
            this.llRegExCheatSheet.Size = new System.Drawing.Size(114, 13);
            this.llRegExCheatSheet.TabIndex = 14;
            this.llRegExCheatSheet.TabStop = true;
            this.llRegExCheatSheet.Text = "RegEx CheetSheet";
            this.llRegExCheatSheet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRegExCheatSheet_LinkClicked);
            // 
            // llRegExLibrary
            // 
            this.llRegExLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llRegExLibrary.AutoSize = true;
            this.llRegExLibrary.Location = new System.Drawing.Point(545, 5);
            this.llRegExLibrary.Name = "llRegExLibrary";
            this.llRegExLibrary.Size = new System.Drawing.Size(87, 13);
            this.llRegExLibrary.TabIndex = 15;
            this.llRegExLibrary.TabStop = true;
            this.llRegExLibrary.Text = "RegEx Library";
            this.llRegExLibrary.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRegExLibrary_LinkClicked);
            // 
            // llIndentedInput
            // 
            this.llIndentedInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llIndentedInput.AutoSize = true;
            this.llIndentedInput.Location = new System.Drawing.Point(559, 56);
            this.llIndentedInput.Name = "llIndentedInput";
            this.llIndentedInput.Size = new System.Drawing.Size(13, 13);
            this.llIndentedInput.TabIndex = 13;
            this.llIndentedInput.TabStop = true;
            this.llIndentedInput.Text = "?";
            this.llIndentedInput.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llIndentedInput_LinkClicked);
            // 
            // cbIndentedInput
            // 
            this.cbIndentedInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIndentedInput.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbIndentedInput.Location = new System.Drawing.Point(454, 51);
            this.cbIndentedInput.Name = "cbIndentedInput";
            this.cbIndentedInput.Size = new System.Drawing.Size(107, 24);
            this.cbIndentedInput.TabIndex = 12;
            this.cbIndentedInput.Text = "Indented Input";
            this.cbIndentedInput.CheckedChanged += new System.EventHandler(this.cbIndentedInput_CheckedChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(588, 51);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(669, 51);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test [F5]";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // llAbout
            // 
            this.llAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llAbout.Location = new System.Drawing.Point(638, 5);
            this.llAbout.Name = "llAbout";
            this.llAbout.Size = new System.Drawing.Size(120, 16);
            this.llAbout.TabIndex = 16;
            this.llAbout.TabStop = true;
            this.llAbout.Text = "About This Program";
            this.llAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAbout_LinkClicked);
            // 
            // cbCultureInvariant
            // 
            this.cbCultureInvariant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCultureInvariant.Checked = true;
            this.cbCultureInvariant.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCultureInvariant.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbCultureInvariant.Location = new System.Drawing.Point(128, 51);
            this.cbCultureInvariant.Name = "cbCultureInvariant";
            this.cbCultureInvariant.Size = new System.Drawing.Size(120, 24);
            this.cbCultureInvariant.TabIndex = 6;
            this.cbCultureInvariant.Text = "Culture Invariant";
            // 
            // llCultureInvariant
            // 
            this.llCultureInvariant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llCultureInvariant.AutoSize = true;
            this.llCultureInvariant.Location = new System.Drawing.Point(244, 56);
            this.llCultureInvariant.Name = "llCultureInvariant";
            this.llCultureInvariant.Size = new System.Drawing.Size(13, 13);
            this.llCultureInvariant.TabIndex = 7;
            this.llCultureInvariant.TabStop = true;
            this.llCultureInvariant.Text = "?";
            this.llCultureInvariant.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCultureInvariant_LinkClicked);
            // 
            // llSingleLine
            // 
            this.llSingleLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llSingleLine.AutoSize = true;
            this.llSingleLine.Location = new System.Drawing.Point(435, 56);
            this.llSingleLine.Name = "llSingleLine";
            this.llSingleLine.Size = new System.Drawing.Size(13, 13);
            this.llSingleLine.TabIndex = 11;
            this.llSingleLine.TabStop = true;
            this.llSingleLine.Text = "?";
            this.llSingleLine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSingleLine_LinkClicked);
            // 
            // llMultiLine
            // 
            this.llMultiLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llMultiLine.AutoSize = true;
            this.llMultiLine.Location = new System.Drawing.Point(335, 56);
            this.llMultiLine.Name = "llMultiLine";
            this.llMultiLine.Size = new System.Drawing.Size(13, 13);
            this.llMultiLine.TabIndex = 9;
            this.llMultiLine.TabStop = true;
            this.llMultiLine.Text = "?";
            this.llMultiLine.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMultiLine_LinkClicked);
            // 
            // llIgnoreCase
            // 
            this.llIgnoreCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llIgnoreCase.AutoSize = true;
            this.llIgnoreCase.Location = new System.Drawing.Point(109, 56);
            this.llIgnoreCase.Name = "llIgnoreCase";
            this.llIgnoreCase.Size = new System.Drawing.Size(13, 13);
            this.llIgnoreCase.TabIndex = 5;
            this.llIgnoreCase.TabStop = true;
            this.llIgnoreCase.Text = "?";
            this.llIgnoreCase.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llIgnoreCase_LinkClicked);
            // 
            // cbSingleLine
            // 
            this.cbSingleLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbSingleLine.Checked = true;
            this.cbSingleLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSingleLine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbSingleLine.Location = new System.Drawing.Point(354, 51);
            this.cbSingleLine.Name = "cbSingleLine";
            this.cbSingleLine.Size = new System.Drawing.Size(84, 24);
            this.cbSingleLine.TabIndex = 10;
            this.cbSingleLine.Text = "Single Line";
            // 
            // cbMultiLine
            // 
            this.cbMultiLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbMultiLine.Checked = true;
            this.cbMultiLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMultiLine.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbMultiLine.Location = new System.Drawing.Point(263, 51);
            this.cbMultiLine.Name = "cbMultiLine";
            this.cbMultiLine.Size = new System.Drawing.Size(77, 24);
            this.cbMultiLine.TabIndex = 8;
            this.cbMultiLine.Text = "Multi Line";
            // 
            // cbIgnoreCase
            // 
            this.cbIgnoreCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIgnoreCase.Checked = true;
            this.cbIgnoreCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIgnoreCase.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbIgnoreCase.Location = new System.Drawing.Point(20, 51);
            this.cbIgnoreCase.Name = "cbIgnoreCase";
            this.cbIgnoreCase.Size = new System.Drawing.Size(95, 24);
            this.cbIgnoreCase.TabIndex = 4;
            this.cbIgnoreCase.Text = "Ignore Case";
            // 
            // txtRegEx
            // 
            this.txtRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegEx.Location = new System.Drawing.Point(11, 24);
            this.txtRegEx.Name = "txtRegEx";
            this.txtRegEx.Size = new System.Drawing.Size(740, 21);
            this.txtRegEx.TabIndex = 1;
            // 
            // lblRegEx
            // 
            this.lblRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegEx.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegEx.Location = new System.Drawing.Point(8, 5);
            this.lblRegEx.Name = "lblRegEx";
            this.lblRegEx.Size = new System.Drawing.Size(743, 16);
            this.lblRegEx.TabIndex = 0;
            this.lblRegEx.Text = "Regular Expression";
            // 
            // nestedSplitContainer
            // 
            this.nestedSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nestedSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nestedSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.nestedSplitContainer.Name = "nestedSplitContainer";
            this.nestedSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // nestedSplitContainer.Panel1
            // 
            this.nestedSplitContainer.Panel1.Controls.Add(this.rtbText);
            this.nestedSplitContainer.Panel1.Controls.Add(this.lblText);
            this.nestedSplitContainer.Panel1MinSize = 61;
            // 
            // nestedSplitContainer.Panel2
            // 
            this.nestedSplitContainer.Panel2.Controls.Add(this.lvResult);
            this.nestedSplitContainer.Panel2.Controls.Add(this.lblResults);
            this.nestedSplitContainer.Panel2MinSize = 89;
            this.nestedSplitContainer.Size = new System.Drawing.Size(765, 341);
            this.nestedSplitContainer.SplitterDistance = 197;
            this.nestedSplitContainer.TabIndex = 0;
            // 
            // rtbText
            // 
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.ContextMenuStrip = this.rtbTextContextMenuStrip;
            this.rtbText.HideSelection = false;
            this.rtbText.Location = new System.Drawing.Point(11, 28);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(740, 156);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            this.rtbText.WordWrap = false;
            // 
            // rtbTextContextMenuStrip
            // 
            this.rtbTextContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoTSMenuItem,
            this.redoTSMenuItem,
            this.separator1TSMenuItem,
            this.cutTSMenuItem,
            this.copyToolStripMenuItem,
            this.pasteTSMenuItem,
            this.deleteTSMenuItem,
            this.separator2TSMenuItem,
            this.findTSMenuItem,
            this.findNextTSMenuItem,
            this.separator3TSMenuItem,
            this.selectAllTSMenuItem});
            this.rtbTextContextMenuStrip.Name = "rtbTextContextMenuStrip";
            this.rtbTextContextMenuStrip.ShowImageMargin = false;
            this.rtbTextContextMenuStrip.Size = new System.Drawing.Size(107, 220);
            // 
            // undoTSMenuItem
            // 
            this.undoTSMenuItem.Name = "undoTSMenuItem";
            this.undoTSMenuItem.Size = new System.Drawing.Size(106, 22);
            this.undoTSMenuItem.Text = "&Undo";
            this.undoTSMenuItem.Click += new System.EventHandler(this.undoTSMenuItem_Click);
            // 
            // redoTSMenuItem
            // 
            this.redoTSMenuItem.Name = "redoTSMenuItem";
            this.redoTSMenuItem.Size = new System.Drawing.Size(106, 22);
            this.redoTSMenuItem.Text = "&Redo";
            this.redoTSMenuItem.Click += new System.EventHandler(this.redoTSMenuItem_Click);
            // 
            // separator1TSMenuItem
            // 
            this.separator1TSMenuItem.Name = "separator1TSMenuItem";
            this.separator1TSMenuItem.Size = new System.Drawing.Size(103, 6);
            // 
            // cutTSMenuItem
            // 
            this.cutTSMenuItem.Name = "cutTSMenuItem";
            this.cutTSMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cutTSMenuItem.Text = "Cu&t";
            this.cutTSMenuItem.Click += new System.EventHandler(this.cutTSMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteTSMenuItem
            // 
            this.pasteTSMenuItem.Name = "pasteTSMenuItem";
            this.pasteTSMenuItem.Size = new System.Drawing.Size(106, 22);
            this.pasteTSMenuItem.Text = "&Paste";
            this.pasteTSMenuItem.Click += new System.EventHandler(this.pasteTSMenuItem_Click);
            // 
            // deleteTSMenuItem
            // 
            this.deleteTSMenuItem.Name = "deleteTSMenuItem";
            this.deleteTSMenuItem.Size = new System.Drawing.Size(106, 22);
            this.deleteTSMenuItem.Text = "&Delete";
            this.deleteTSMenuItem.Click += new System.EventHandler(this.deleteTSMenuItem_Click);
            // 
            // separator2TSMenuItem
            // 
            this.separator2TSMenuItem.Name = "separator2TSMenuItem";
            this.separator2TSMenuItem.Size = new System.Drawing.Size(103, 6);
            // 
            // findTSMenuItem
            // 
            this.findTSMenuItem.Name = "findTSMenuItem";
            this.findTSMenuItem.Size = new System.Drawing.Size(106, 22);
            this.findTSMenuItem.Text = "&Find...";
            this.findTSMenuItem.Click += new System.EventHandler(this.findTSMenuItem_Click);
            // 
            // findNextTSMenuItem
            // 
            this.findNextTSMenuItem.Name = "findNextTSMenuItem";
            this.findNextTSMenuItem.Size = new System.Drawing.Size(106, 22);
            this.findNextTSMenuItem.Text = "Find &Next";
            this.findNextTSMenuItem.Click += new System.EventHandler(this.findNextTSMenuItem_Click);
            // 
            // separator3TSMenuItem
            // 
            this.separator3TSMenuItem.Name = "separator3TSMenuItem";
            this.separator3TSMenuItem.Size = new System.Drawing.Size(103, 6);
            // 
            // selectAllTSMenuItem
            // 
            this.selectAllTSMenuItem.Name = "selectAllTSMenuItem";
            this.selectAllTSMenuItem.Size = new System.Drawing.Size(106, 22);
            this.selectAllTSMenuItem.Text = "Select &All";
            this.selectAllTSMenuItem.Click += new System.EventHandler(this.selectAllTSMenuItem_Click);
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(8, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(743, 16);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Test Text";
            // 
            // lvResult
            // 
            this.lvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMatch,
            this.chPosition,
            this.chLenght});
            this.lvResult.FullRowSelect = true;
            this.lvResult.GridLines = true;
            this.lvResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvResult.Location = new System.Drawing.Point(11, 27);
            this.lvResult.MultiSelect = false;
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(740, 95);
            this.lvResult.TabIndex = 1;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            this.lvResult.SelectedIndexChanged += new System.EventHandler(this.lvResult_SelectedIndexChanged);
            // 
            // chMatch
            // 
            this.chMatch.Text = "Match";
            this.chMatch.Width = 408;
            // 
            // chPosition
            // 
            this.chPosition.Text = "Position";
            this.chPosition.Width = 87;
            // 
            // chLenght
            // 
            this.chLenght.Text = "Lenght";
            this.chLenght.Width = 98;
            // 
            // lblResults
            // 
            this.lblResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResults.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(8, 9);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(743, 15);
            this.lblResults.TabIndex = 0;
            this.lblResults.Text = "Test Results";
            // 
            // btnCopyContextMenuStrip
            // 
            this.btnCopyContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyGeneric1TSMenuItem,
            this.copyGeneric2TSMenuItem,
            this.copyGeneric3TSMenuItem});
            this.btnCopyContextMenuStrip.Name = "btnCopyContextMenuStrip";
            this.btnCopyContextMenuStrip.ShowImageMargin = false;
            this.btnCopyContextMenuStrip.Size = new System.Drawing.Size(149, 70);
            // 
            // copyGeneric1TSMenuItem
            // 
            this.copyGeneric1TSMenuItem.Name = "copyGeneric1TSMenuItem";
            this.copyGeneric1TSMenuItem.Size = new System.Drawing.Size(148, 22);
            this.copyGeneric1TSMenuItem.Tag = "cs";
            this.copyGeneric1TSMenuItem.Text = "&C# escaped string";
            this.copyGeneric1TSMenuItem.Click += new System.EventHandler(this.copyGenericTSMenuItem_Click);
            // 
            // copyGeneric2TSMenuItem
            // 
            this.copyGeneric2TSMenuItem.Name = "copyGeneric2TSMenuItem";
            this.copyGeneric2TSMenuItem.Size = new System.Drawing.Size(148, 22);
            this.copyGeneric2TSMenuItem.Tag = "html";
            this.copyGeneric2TSMenuItem.Text = "&HTML encoded";
            this.copyGeneric2TSMenuItem.Click += new System.EventHandler(this.copyGenericTSMenuItem_Click);
            // 
            // copyGeneric3TSMenuItem
            // 
            this.copyGeneric3TSMenuItem.Name = "copyGeneric3TSMenuItem";
            this.copyGeneric3TSMenuItem.Size = new System.Drawing.Size(148, 22);
            this.copyGeneric3TSMenuItem.Tag = "plain";
            this.copyGeneric3TSMenuItem.Text = "&Plain text";
            this.copyGeneric3TSMenuItem.Click += new System.EventHandler(this.copyGenericTSMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(765, 457);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusBar);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(773, 306);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegEx Tester";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sbpStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpContext)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.nestedSplitContainer.Panel1.ResumeLayout(false);
            this.nestedSplitContainer.Panel2.ResumeLayout(false);
            this.nestedSplitContainer.ResumeLayout(false);
            this.rtbTextContextMenuStrip.ResumeLayout(false);
            this.btnCopyContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion


        private StatusBar statusBar;
        private StatusBarPanel sbpStatus;
        private StatusBarPanel sbpContext;
        private SplitContainer splitContainer;
        private SplitContainer nestedSplitContainer;
        private Button btnCopy;
        private Button btnTest;
        private LinkLabel llAbout;
        private CheckBox cbCultureInvariant;
        private LinkLabel llCultureInvariant;
        private LinkLabel llSingleLine;
        private LinkLabel llMultiLine;
        private LinkLabel llIgnoreCase;
        private CheckBox cbSingleLine;
        private CheckBox cbMultiLine;
        private CheckBox cbIgnoreCase;
        private TextBox txtRegEx;
        private Label lblRegEx;
        private RichTextBox rtbText;
        private Label lblText;
        private Label lblResults;
        private ListView lvResult;
        private ColumnHeader chMatch;
        private ColumnHeader chPosition;
        private ColumnHeader chLenght;
        private LinkLabel llIndentedInput;
        private CheckBox cbIndentedInput;
        private LinkLabel llRegExLibrary;
        private System.ComponentModel.IContainer components;
        private LinkLabel llRegExCheatSheet;
        private ContextMenuStrip rtbTextContextMenuStrip;
        private ToolStripMenuItem undoTSMenuItem;
        private ToolStripSeparator separator1TSMenuItem;
        private ToolStripMenuItem cutTSMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteTSMenuItem;
        private ToolStripMenuItem deleteTSMenuItem;
        private ToolStripSeparator separator2TSMenuItem;
        private ToolStripMenuItem selectAllTSMenuItem;
        private ToolStripMenuItem redoTSMenuItem;
        private ToolStripMenuItem findTSMenuItem;
        private ToolStripMenuItem findNextTSMenuItem;
        private ToolStripSeparator separator3TSMenuItem;
        private ContextMenuStrip btnCopyContextMenuStrip;
        private ToolStripMenuItem copyGeneric1TSMenuItem;
        private ToolStripMenuItem copyGeneric2TSMenuItem;
        private ToolStripMenuItem copyGeneric3TSMenuItem;

    }
}