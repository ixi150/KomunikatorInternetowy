namespace GaduGaduGadu
{
    partial class GaduForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GaduForm));
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.labelErrorLogin = new System.Windows.Forms.Label();
            this.groupBoxLogOut = new System.Windows.Forms.GroupBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelLoggedAs = new System.Windows.Forms.Label();
            this.groupBoxLogIn = new System.Windows.Forms.GroupBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.tabPageRegister = new System.Windows.Forms.TabPage();
            this.labelRegisterError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRegisterPass2 = new System.Windows.Forms.TextBox();
            this.labelRegisterPass2 = new System.Windows.Forms.Label();
            this.textBoxRegisterPass = new System.Windows.Forms.TextBox();
            this.labelRegisterPass = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxRegisterEmail = new System.Windows.Forms.TextBox();
            this.labelRegisterEmail = new System.Windows.Forms.Label();
            this.textBoxRegisterLogin = new System.Windows.Forms.TextBox();
            this.labelRegisterLogin = new System.Windows.Forms.Label();
            this.tabPageTalk = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBoxChat = new System.Windows.Forms.RichTextBox();
            this.textBoxInput = new System.Windows.Forms.RichTextBox();
            this.tabPageDEBUG = new System.Windows.Forms.TabPage();
            this.debugTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPageDB_users = new System.Windows.Forms.TabPage();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.tabPageDB_contacts = new System.Windows.Forms.TabPage();
            this.dataGridViewContacts = new System.Windows.Forms.DataGridView();
            this.buttonDebugRefresh = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.flowLayoutContacts = new System.Windows.Forms.FlowLayoutPanel();
            this.tabsControl.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.groupBoxLogOut.SuspendLayout();
            this.groupBoxLogIn.SuspendLayout();
            this.tabPageRegister.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageTalk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPageDEBUG.SuspendLayout();
            this.tabPageDB_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPageDB_contacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.flowLayoutContacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabsControl
            // 
            this.tabsControl.Controls.Add(this.tabPageLogin);
            this.tabsControl.Controls.Add(this.tabPageRegister);
            this.tabsControl.Controls.Add(this.tabPageTalk);
            this.tabsControl.Controls.Add(this.tabPageDEBUG);
            this.tabsControl.Controls.Add(this.tabPageDB_users);
            this.tabsControl.Controls.Add(this.tabPageDB_contacts);
            this.tabsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsControl.HotTrack = true;
            this.tabsControl.Location = new System.Drawing.Point(0, 0);
            this.tabsControl.Multiline = true;
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(897, 617);
            this.tabsControl.TabIndex = 3;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.labelErrorLogin);
            this.tabPageLogin.Controls.Add(this.groupBoxLogOut);
            this.tabPageLogin.Controls.Add(this.groupBoxLogIn);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(889, 591);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // labelErrorLogin
            // 
            this.labelErrorLogin.ForeColor = System.Drawing.Color.Red;
            this.labelErrorLogin.Location = new System.Drawing.Point(17, 109);
            this.labelErrorLogin.Name = "labelErrorLogin";
            this.labelErrorLogin.Size = new System.Drawing.Size(185, 74);
            this.labelErrorLogin.TabIndex = 4;
            this.labelErrorLogin.Text = "Error with login";
            // 
            // groupBoxLogOut
            // 
            this.groupBoxLogOut.Controls.Add(this.buttonLogOut);
            this.groupBoxLogOut.Controls.Add(this.labelLoggedAs);
            this.groupBoxLogOut.Location = new System.Drawing.Point(214, 6);
            this.groupBoxLogOut.Name = "groupBoxLogOut";
            this.groupBoxLogOut.Size = new System.Drawing.Size(165, 102);
            this.groupBoxLogOut.TabIndex = 3;
            this.groupBoxLogOut.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogOut.Location = new System.Drawing.Point(6, 73);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(153, 23);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            // 
            // labelLoggedAs
            // 
            this.labelLoggedAs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoggedAs.Location = new System.Drawing.Point(6, 19);
            this.labelLoggedAs.Name = "labelLoggedAs";
            this.labelLoggedAs.Size = new System.Drawing.Size(153, 46);
            this.labelLoggedAs.TabIndex = 1;
            this.labelLoggedAs.Text = "Logged as ...";
            this.labelLoggedAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxLogIn
            // 
            this.groupBoxLogIn.Controls.Add(this.buttonLogIn);
            this.groupBoxLogIn.Controls.Add(this.textBox2);
            this.groupBoxLogIn.Controls.Add(this.labelPass);
            this.groupBoxLogIn.Controls.Add(this.textBox1);
            this.groupBoxLogIn.Controls.Add(this.labelLogin);
            this.groupBoxLogIn.Location = new System.Drawing.Point(8, 6);
            this.groupBoxLogIn.Name = "groupBoxLogIn";
            this.groupBoxLogIn.Size = new System.Drawing.Size(200, 102);
            this.groupBoxLogIn.TabIndex = 2;
            this.groupBoxLogIn.TabStop = false;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(9, 73);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(185, 23);
            this.buttonLogIn.TabIndex = 4;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 2;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(6, 48);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(53, 13);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 0;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(6, 22);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            // 
            // tabPageRegister
            // 
            this.tabPageRegister.Controls.Add(this.labelRegisterError);
            this.tabPageRegister.Controls.Add(this.groupBox1);
            this.tabPageRegister.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegister.Size = new System.Drawing.Size(889, 591);
            this.tabPageRegister.TabIndex = 1;
            this.tabPageRegister.Text = "Register";
            this.tabPageRegister.UseVisualStyleBackColor = true;
            // 
            // labelRegisterError
            // 
            this.labelRegisterError.ForeColor = System.Drawing.Color.Red;
            this.labelRegisterError.Location = new System.Drawing.Point(17, 162);
            this.labelRegisterError.Name = "labelRegisterError";
            this.labelRegisterError.Size = new System.Drawing.Size(185, 74);
            this.labelRegisterError.TabIndex = 5;
            this.labelRegisterError.Text = "Error with register";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRegisterPass2);
            this.groupBox1.Controls.Add(this.labelRegisterPass2);
            this.groupBox1.Controls.Add(this.textBoxRegisterPass);
            this.groupBox1.Controls.Add(this.labelRegisterPass);
            this.groupBox1.Controls.Add(this.buttonRegister);
            this.groupBox1.Controls.Add(this.textBoxRegisterEmail);
            this.groupBox1.Controls.Add(this.labelRegisterEmail);
            this.groupBox1.Controls.Add(this.textBoxRegisterLogin);
            this.groupBox1.Controls.Add(this.labelRegisterLogin);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 153);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // textBoxRegisterPass2
            // 
            this.textBoxRegisterPass2.Location = new System.Drawing.Point(63, 97);
            this.textBoxRegisterPass2.Name = "textBoxRegisterPass2";
            this.textBoxRegisterPass2.Size = new System.Drawing.Size(131, 20);
            this.textBoxRegisterPass2.TabIndex = 7;
            // 
            // labelRegisterPass2
            // 
            this.labelRegisterPass2.AutoSize = true;
            this.labelRegisterPass2.Location = new System.Drawing.Point(6, 100);
            this.labelRegisterPass2.Name = "labelRegisterPass2";
            this.labelRegisterPass2.Size = new System.Drawing.Size(59, 13);
            this.labelRegisterPass2.TabIndex = 8;
            this.labelRegisterPass2.Text = "Password2";
            // 
            // textBoxRegisterPass
            // 
            this.textBoxRegisterPass.Location = new System.Drawing.Point(63, 71);
            this.textBoxRegisterPass.Name = "textBoxRegisterPass";
            this.textBoxRegisterPass.Size = new System.Drawing.Size(131, 20);
            this.textBoxRegisterPass.TabIndex = 5;
            // 
            // labelRegisterPass
            // 
            this.labelRegisterPass.AutoSize = true;
            this.labelRegisterPass.Location = new System.Drawing.Point(6, 74);
            this.labelRegisterPass.Name = "labelRegisterPass";
            this.labelRegisterPass.Size = new System.Drawing.Size(53, 13);
            this.labelRegisterPass.TabIndex = 6;
            this.labelRegisterPass.Text = "Password";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(6, 123);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(188, 23);
            this.buttonRegister.TabIndex = 4;
            this.buttonRegister.Text = "Log In";
            this.buttonRegister.UseVisualStyleBackColor = true;
            // 
            // textBoxRegisterEmail
            // 
            this.textBoxRegisterEmail.Location = new System.Drawing.Point(63, 45);
            this.textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            this.textBoxRegisterEmail.Size = new System.Drawing.Size(131, 20);
            this.textBoxRegisterEmail.TabIndex = 2;
            // 
            // labelRegisterEmail
            // 
            this.labelRegisterEmail.AutoSize = true;
            this.labelRegisterEmail.Location = new System.Drawing.Point(6, 48);
            this.labelRegisterEmail.Name = "labelRegisterEmail";
            this.labelRegisterEmail.Size = new System.Drawing.Size(35, 13);
            this.labelRegisterEmail.TabIndex = 3;
            this.labelRegisterEmail.Text = "E-mail";
            // 
            // textBoxRegisterLogin
            // 
            this.textBoxRegisterLogin.Location = new System.Drawing.Point(63, 19);
            this.textBoxRegisterLogin.Name = "textBoxRegisterLogin";
            this.textBoxRegisterLogin.Size = new System.Drawing.Size(131, 20);
            this.textBoxRegisterLogin.TabIndex = 0;
            // 
            // labelRegisterLogin
            // 
            this.labelRegisterLogin.AutoSize = true;
            this.labelRegisterLogin.Location = new System.Drawing.Point(6, 22);
            this.labelRegisterLogin.Name = "labelRegisterLogin";
            this.labelRegisterLogin.Size = new System.Drawing.Size(33, 13);
            this.labelRegisterLogin.TabIndex = 1;
            this.labelRegisterLogin.Text = "Login";
            // 
            // tabPageTalk
            // 
            this.tabPageTalk.Controls.Add(this.splitContainer1);
            this.tabPageTalk.Location = new System.Drawing.Point(4, 22);
            this.tabPageTalk.Name = "tabPageTalk";
            this.tabPageTalk.Size = new System.Drawing.Size(889, 591);
            this.tabPageTalk.TabIndex = 2;
            this.tabPageTalk.Text = "Talk";
            this.tabPageTalk.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(889, 591);
            this.splitContainer1.SplitterDistance = 550;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBoxChat);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.buttonDebugRefresh);
            this.splitContainer2.Panel2.Controls.Add(this.textBoxInput);
            this.splitContainer2.Size = new System.Drawing.Size(550, 591);
            this.splitContainer2.SplitterDistance = 448;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBoxChat
            // 
            this.textBoxChat.AcceptsTab = true;
            this.textBoxChat.AutoWordSelection = true;
            this.textBoxChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxChat.Location = new System.Drawing.Point(0, 0);
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.ReadOnly = true;
            this.textBoxChat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBoxChat.ShowSelectionMargin = true;
            this.textBoxChat.Size = new System.Drawing.Size(550, 448);
            this.textBoxChat.TabIndex = 0;
            this.textBoxChat.Text = "IXI 12323213123:\nale mi sie to coś podoba no nie? \n\n<color=red>Inny IXI</color> 1" +
    "312312:\nmi się nie podoba NP.\n";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.EnableAutoDragDrop = true;
            this.textBoxInput.Location = new System.Drawing.Point(0, 0);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(550, 139);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.Text = "";
            this.textBoxInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            // 
            // tabPageDEBUG
            // 
            this.tabPageDEBUG.Controls.Add(this.debugTextBox);
            this.tabPageDEBUG.Location = new System.Drawing.Point(4, 22);
            this.tabPageDEBUG.Name = "tabPageDEBUG";
            this.tabPageDEBUG.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDEBUG.Size = new System.Drawing.Size(889, 591);
            this.tabPageDEBUG.TabIndex = 5;
            this.tabPageDEBUG.Text = "DEBUG";
            this.tabPageDEBUG.UseVisualStyleBackColor = true;
            // 
            // debugTextBox
            // 
            this.debugTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.debugTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugTextBox.Location = new System.Drawing.Point(3, 3);
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.Size = new System.Drawing.Size(883, 585);
            this.debugTextBox.TabIndex = 0;
            this.debugTextBox.Text = "";
            // 
            // tabPageDB_users
            // 
            this.tabPageDB_users.Controls.Add(this.dataGridViewUsers);
            this.tabPageDB_users.Cursor = System.Windows.Forms.Cursors.No;
            this.tabPageDB_users.Location = new System.Drawing.Point(4, 22);
            this.tabPageDB_users.Name = "tabPageDB_users";
            this.tabPageDB_users.Size = new System.Drawing.Size(889, 591);
            this.tabPageDB_users.TabIndex = 3;
            this.tabPageDB_users.Text = "DEBUG users";
            this.tabPageDB_users.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(889, 591);
            this.dataGridViewUsers.TabIndex = 1;
            // 
            // tabPageDB_contacts
            // 
            this.tabPageDB_contacts.BackColor = System.Drawing.Color.Transparent;
            this.tabPageDB_contacts.Controls.Add(this.dataGridViewContacts);
            this.tabPageDB_contacts.Cursor = System.Windows.Forms.Cursors.No;
            this.tabPageDB_contacts.ForeColor = System.Drawing.Color.Black;
            this.tabPageDB_contacts.ImageKey = "(none)";
            this.tabPageDB_contacts.Location = new System.Drawing.Point(4, 22);
            this.tabPageDB_contacts.Name = "tabPageDB_contacts";
            this.tabPageDB_contacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDB_contacts.Size = new System.Drawing.Size(889, 591);
            this.tabPageDB_contacts.TabIndex = 4;
            this.tabPageDB_contacts.Text = "DEBUG contacts";
            // 
            // dataGridViewContacts
            // 
            this.dataGridViewContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewContacts.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewContacts.Name = "dataGridViewContacts";
            this.dataGridViewContacts.Size = new System.Drawing.Size(883, 585);
            this.dataGridViewContacts.TabIndex = 0;
            // 
            // buttonDebugRefresh
            // 
            this.buttonDebugRefresh.Location = new System.Drawing.Point(407, 113);
            this.buttonDebugRefresh.Name = "buttonDebugRefresh";
            this.buttonDebugRefresh.Size = new System.Drawing.Size(140, 23);
            this.buttonDebugRefresh.TabIndex = 2;
            this.buttonDebugRefresh.Text = "debug Refresh";
            this.buttonDebugRefresh.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.flowLayoutContacts);
            this.splitContainer3.Size = new System.Drawing.Size(335, 591);
            this.splitContainer3.SplitterDistance = 500;
            this.splitContainer3.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioB";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // flowLayoutContacts
            // 
            this.flowLayoutContacts.AutoScroll = true;
            this.flowLayoutContacts.Controls.Add(this.radioButton5);
            this.flowLayoutContacts.Controls.Add(this.radioButton2);
            this.flowLayoutContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutContacts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutContacts.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutContacts.Name = "flowLayoutContacts";
            this.flowLayoutContacts.Size = new System.Drawing.Size(335, 500);
            this.flowLayoutContacts.TabIndex = 5;
            this.flowLayoutContacts.WrapContents = false;
            // 
            // GaduForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 617);
            this.Controls.Add(this.tabsControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GaduForm";
            this.Text = "Gadka";
            this.tabsControl.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.groupBoxLogOut.ResumeLayout(false);
            this.groupBoxLogIn.ResumeLayout(false);
            this.groupBoxLogIn.PerformLayout();
            this.tabPageRegister.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageTalk.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPageDEBUG.ResumeLayout(false);
            this.tabPageDB_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPageDB_contacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContacts)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.flowLayoutContacts.ResumeLayout(false);
            this.flowLayoutContacts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageRegister;
        private System.Windows.Forms.TabPage tabPageTalk;
        private System.Windows.Forms.TabPage tabPageDB_users;
        private System.Windows.Forms.TabPage tabPageDB_contacts;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridView dataGridViewContacts;
        private System.Windows.Forms.Label labelErrorLogin;
        private System.Windows.Forms.GroupBox groupBoxLogOut;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelLoggedAs;
        private System.Windows.Forms.GroupBox groupBoxLogIn;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelRegisterError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRegisterPass2;
        private System.Windows.Forms.Label labelRegisterPass2;
        private System.Windows.Forms.TextBox textBoxRegisterPass;
        private System.Windows.Forms.Label labelRegisterPass;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxRegisterEmail;
        private System.Windows.Forms.Label labelRegisterEmail;
        private System.Windows.Forms.TextBox textBoxRegisterLogin;
        private System.Windows.Forms.Label labelRegisterLogin;
        private System.Windows.Forms.RichTextBox textBoxChat;
        private System.Windows.Forms.TabPage tabPageDEBUG;
        private System.Windows.Forms.RichTextBox debugTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox textBoxInput;
        private System.Windows.Forms.Button buttonDebugRefresh;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutContacts;
    }
}

