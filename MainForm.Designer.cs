namespace Mirage_Security
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.formBorder = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.minimizeButton = new FontAwesome.Sharp.IconButton();
            this.closeButton = new FontAwesome.Sharp.IconButton();
            this.formLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.fileButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.fileDescLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.fileLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.fileStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.fileImage = new System.Windows.Forms.PictureBox();
            this.formTopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.formTopPanelDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.processDescLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.processLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.processStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.processImage = new System.Windows.Forms.PictureBox();
            this.processButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.registryDescLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.registryLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.registryStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.registryImage = new System.Windows.Forms.PictureBox();
            this.registryButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.driverDescLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.driverLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.driverStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.driverImage = new System.Windows.Forms.PictureBox();
            this.driverButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.mutexDescLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.mutexLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.mutexStatus = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.mutexImage = new System.Windows.Forms.PictureBox();
            this.mutexButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileImage)).BeginInit();
            this.formTopPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processImage)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registryStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registryImage)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverImage)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mutexStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutexImage)).BeginInit();
            this.SuspendLayout();
            // 
            // formBorder
            // 
            this.formBorder.AnimateWindow = true;
            this.formBorder.AnimationInterval = 100;
            this.formBorder.ContainerControl = this;
            this.formBorder.ResizeForm = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.minimizeButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimizeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.minimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeButton.IconSize = 16;
            this.minimizeButton.Location = new System.Drawing.Point(638, 8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(31, 20);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.closeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.closeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeButton.IconSize = 16;
            this.closeButton.Location = new System.Drawing.Point(669, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(31, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = false;
            this.formLabel.BackColor = System.Drawing.Color.Transparent;
            this.formLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.formLabel.IsSelectionEnabled = false;
            this.formLabel.Location = new System.Drawing.Point(286, 4);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(125, 23);
            this.formLabel.TabIndex = 3;
            this.formLabel.Text = "Mirage Security";
            this.formLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileButton
            // 
            this.fileButton.Animated = true;
            this.fileButton.BorderRadius = 6;
            this.fileButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.fileButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fileButton.CheckedState.Parent = this.fileButton;
            this.fileButton.CustomImages.Parent = this.fileButton;
            this.fileButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(133)))), ((int)(((byte)(230)))));
            this.fileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fileButton.ForeColor = System.Drawing.Color.White;
            this.fileButton.HoverState.Parent = this.fileButton;
            this.fileButton.Location = new System.Drawing.Point(55, 174);
            this.fileButton.Name = "fileButton";
            this.fileButton.ShadowDecoration.Parent = this.fileButton;
            this.fileButton.Size = new System.Drawing.Size(83, 28);
            this.fileButton.TabIndex = 4;
            this.fileButton.Text = "Enable";
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.panel1.BorderColor = System.Drawing.Color.Transparent;
            this.panel1.BorderRadius = 12;
            this.panel1.Controls.Add(this.fileDescLabel);
            this.panel1.Controls.Add(this.fileLabel);
            this.panel1.Controls.Add(this.fileStatus);
            this.panel1.Controls.Add(this.fileImage);
            this.panel1.Controls.Add(this.fileButton);
            this.panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(66)))));
            this.panel1.Location = new System.Drawing.Point(27, 59);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(200, 221);
            this.panel1.TabIndex = 5;
            // 
            // fileDescLabel
            // 
            this.fileDescLabel.AutoSize = false;
            this.fileDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileDescLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileDescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(108)))), ((int)(((byte)(127)))));
            this.fileDescLabel.Location = new System.Drawing.Point(0, 119);
            this.fileDescLabel.Name = "fileDescLabel";
            this.fileDescLabel.Size = new System.Drawing.Size(194, 39);
            this.fileDescLabel.TabIndex = 8;
            this.fileDescLabel.Text = "Generates files and directories  to simulate virtualization";
            this.fileDescLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = false;
            this.fileLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.fileLabel.Location = new System.Drawing.Point(0, 90);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(194, 27);
            this.fileLabel.TabIndex = 7;
            this.fileLabel.Text = "File Artifacts";
            this.fileLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileStatus
            // 
            this.fileStatus.BackColor = System.Drawing.Color.Transparent;
            this.fileStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(72)))), ((int)(((byte)(34)))));
            this.fileStatus.Location = new System.Drawing.Point(7, 9);
            this.fileStatus.Name = "fileStatus";
            this.fileStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.fileStatus.ShadowDecoration.Parent = this.fileStatus;
            this.fileStatus.Size = new System.Drawing.Size(8, 8);
            this.fileStatus.TabIndex = 6;
            this.fileStatus.TabStop = false;
            // 
            // fileImage
            // 
            this.fileImage.BackColor = System.Drawing.Color.Transparent;
            this.fileImage.Image = ((System.Drawing.Image)(resources.GetObject("fileImage.Image")));
            this.fileImage.Location = new System.Drawing.Point(67, 22);
            this.fileImage.Name = "fileImage";
            this.fileImage.Size = new System.Drawing.Size(56, 56);
            this.fileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fileImage.TabIndex = 5;
            this.fileImage.TabStop = false;
            // 
            // formTopPanel
            // 
            this.formTopPanel.Controls.Add(this.formLabel);
            this.formTopPanel.Controls.Add(this.minimizeButton);
            this.formTopPanel.Controls.Add(this.closeButton);
            this.formTopPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(66)))));
            this.formTopPanel.Location = new System.Drawing.Point(0, 0);
            this.formTopPanel.Name = "formTopPanel";
            this.formTopPanel.ShadowDecoration.Parent = this.formTopPanel;
            this.formTopPanel.Size = new System.Drawing.Size(700, 31);
            this.formTopPanel.TabIndex = 6;
            // 
            // formTopPanelDrag
            // 
            this.formTopPanelDrag.ContainerControl = this;
            this.formTopPanelDrag.TargetControl = this.formTopPanel;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.Controls.Add(this.processDescLabel);
            this.guna2Panel1.Controls.Add(this.processLabel);
            this.guna2Panel1.Controls.Add(this.processStatus);
            this.guna2Panel1.Controls.Add(this.processImage);
            this.guna2Panel1.Controls.Add(this.processButton);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(66)))));
            this.guna2Panel1.Location = new System.Drawing.Point(249, 59);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(200, 221);
            this.guna2Panel1.TabIndex = 9;
            // 
            // processDescLabel
            // 
            this.processDescLabel.AutoSize = false;
            this.processDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.processDescLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processDescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(108)))), ((int)(((byte)(127)))));
            this.processDescLabel.Location = new System.Drawing.Point(0, 119);
            this.processDescLabel.Name = "processDescLabel";
            this.processDescLabel.Size = new System.Drawing.Size(194, 39);
            this.processDescLabel.TabIndex = 8;
            this.processDescLabel.Text = "Simulates the use of common security / forensic tools";
            this.processDescLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = false;
            this.processLabel.BackColor = System.Drawing.Color.Transparent;
            this.processLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.processLabel.Location = new System.Drawing.Point(0, 90);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(194, 27);
            this.processLabel.TabIndex = 7;
            this.processLabel.Text = "Processes";
            this.processLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processStatus
            // 
            this.processStatus.BackColor = System.Drawing.Color.Transparent;
            this.processStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(72)))), ((int)(((byte)(34)))));
            this.processStatus.Location = new System.Drawing.Point(7, 9);
            this.processStatus.Name = "processStatus";
            this.processStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.processStatus.ShadowDecoration.Parent = this.processStatus;
            this.processStatus.Size = new System.Drawing.Size(8, 8);
            this.processStatus.TabIndex = 6;
            this.processStatus.TabStop = false;
            // 
            // processImage
            // 
            this.processImage.BackColor = System.Drawing.Color.Transparent;
            this.processImage.Image = ((System.Drawing.Image)(resources.GetObject("processImage.Image")));
            this.processImage.Location = new System.Drawing.Point(67, 22);
            this.processImage.Name = "processImage";
            this.processImage.Size = new System.Drawing.Size(56, 56);
            this.processImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processImage.TabIndex = 5;
            this.processImage.TabStop = false;
            // 
            // processButton
            // 
            this.processButton.Animated = true;
            this.processButton.BorderRadius = 6;
            this.processButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.processButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.processButton.CheckedState.Parent = this.processButton;
            this.processButton.CustomImages.Parent = this.processButton;
            this.processButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(133)))), ((int)(((byte)(230)))));
            this.processButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.processButton.ForeColor = System.Drawing.Color.White;
            this.processButton.HoverState.Parent = this.processButton;
            this.processButton.Location = new System.Drawing.Point(55, 174);
            this.processButton.Name = "processButton";
            this.processButton.ShadowDecoration.Parent = this.processButton;
            this.processButton.Size = new System.Drawing.Size(83, 28);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "Enable";
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.Controls.Add(this.registryDescLabel);
            this.guna2Panel2.Controls.Add(this.registryLabel);
            this.guna2Panel2.Controls.Add(this.registryStatus);
            this.guna2Panel2.Controls.Add(this.registryImage);
            this.guna2Panel2.Controls.Add(this.registryButton);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(66)))));
            this.guna2Panel2.Location = new System.Drawing.Point(139, 304);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(200, 221);
            this.guna2Panel2.TabIndex = 10;
            // 
            // registryDescLabel
            // 
            this.registryDescLabel.AutoSize = false;
            this.registryDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.registryDescLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registryDescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(108)))), ((int)(((byte)(127)))));
            this.registryDescLabel.Location = new System.Drawing.Point(3, 119);
            this.registryDescLabel.Name = "registryDescLabel";
            this.registryDescLabel.Size = new System.Drawing.Size(194, 39);
            this.registryDescLabel.TabIndex = 8;
            this.registryDescLabel.Text = "Creates keys commonly found in virtualized guests";
            this.registryDescLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registryLabel
            // 
            this.registryLabel.AutoSize = false;
            this.registryLabel.BackColor = System.Drawing.Color.Transparent;
            this.registryLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.registryLabel.Location = new System.Drawing.Point(3, 90);
            this.registryLabel.Name = "registryLabel";
            this.registryLabel.Size = new System.Drawing.Size(194, 27);
            this.registryLabel.TabIndex = 7;
            this.registryLabel.Text = "Registry Keys";
            this.registryLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registryStatus
            // 
            this.registryStatus.BackColor = System.Drawing.Color.Transparent;
            this.registryStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(72)))), ((int)(((byte)(34)))));
            this.registryStatus.Location = new System.Drawing.Point(10, 9);
            this.registryStatus.Name = "registryStatus";
            this.registryStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.registryStatus.ShadowDecoration.Parent = this.registryStatus;
            this.registryStatus.Size = new System.Drawing.Size(8, 8);
            this.registryStatus.TabIndex = 6;
            this.registryStatus.TabStop = false;
            // 
            // registryImage
            // 
            this.registryImage.BackColor = System.Drawing.Color.Transparent;
            this.registryImage.Image = ((System.Drawing.Image)(resources.GetObject("registryImage.Image")));
            this.registryImage.Location = new System.Drawing.Point(70, 22);
            this.registryImage.Name = "registryImage";
            this.registryImage.Size = new System.Drawing.Size(56, 56);
            this.registryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.registryImage.TabIndex = 5;
            this.registryImage.TabStop = false;
            // 
            // registryButton
            // 
            this.registryButton.Animated = true;
            this.registryButton.BorderRadius = 6;
            this.registryButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.registryButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.registryButton.CheckedState.Parent = this.registryButton;
            this.registryButton.CustomImages.Parent = this.registryButton;
            this.registryButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(133)))), ((int)(((byte)(230)))));
            this.registryButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.registryButton.ForeColor = System.Drawing.Color.White;
            this.registryButton.HoverState.Parent = this.registryButton;
            this.registryButton.Location = new System.Drawing.Point(58, 174);
            this.registryButton.Name = "registryButton";
            this.registryButton.ShadowDecoration.Parent = this.registryButton;
            this.registryButton.Size = new System.Drawing.Size(83, 28);
            this.registryButton.TabIndex = 4;
            this.registryButton.Text = "Enable";
            this.registryButton.Click += new System.EventHandler(this.registryButton_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.guna2Panel3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 12;
            this.guna2Panel3.Controls.Add(this.driverDescLabel);
            this.guna2Panel3.Controls.Add(this.driverLabel);
            this.guna2Panel3.Controls.Add(this.driverStatus);
            this.guna2Panel3.Controls.Add(this.driverImage);
            this.guna2Panel3.Controls.Add(this.driverButton);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(66)))));
            this.guna2Panel3.Location = new System.Drawing.Point(361, 304);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(200, 221);
            this.guna2Panel3.TabIndex = 11;
            // 
            // driverDescLabel
            // 
            this.driverDescLabel.AutoSize = false;
            this.driverDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.driverDescLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverDescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(108)))), ((int)(((byte)(127)))));
            this.driverDescLabel.Location = new System.Drawing.Point(3, 119);
            this.driverDescLabel.Name = "driverDescLabel";
            this.driverDescLabel.Size = new System.Drawing.Size(194, 39);
            this.driverDescLabel.TabIndex = 8;
            this.driverDescLabel.Text = "Creates drivers used by virtualization softwre";
            this.driverDescLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = false;
            this.driverLabel.BackColor = System.Drawing.Color.Transparent;
            this.driverLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.driverLabel.Location = new System.Drawing.Point(3, 90);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(194, 27);
            this.driverLabel.TabIndex = 7;
            this.driverLabel.Text = "Device Drivers";
            this.driverLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // driverStatus
            // 
            this.driverStatus.BackColor = System.Drawing.Color.Transparent;
            this.driverStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(72)))), ((int)(((byte)(34)))));
            this.driverStatus.Location = new System.Drawing.Point(10, 9);
            this.driverStatus.Name = "driverStatus";
            this.driverStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.driverStatus.ShadowDecoration.Parent = this.driverStatus;
            this.driverStatus.Size = new System.Drawing.Size(8, 8);
            this.driverStatus.TabIndex = 6;
            this.driverStatus.TabStop = false;
            // 
            // driverImage
            // 
            this.driverImage.BackColor = System.Drawing.Color.Transparent;
            this.driverImage.Image = ((System.Drawing.Image)(resources.GetObject("driverImage.Image")));
            this.driverImage.Location = new System.Drawing.Point(70, 22);
            this.driverImage.Name = "driverImage";
            this.driverImage.Size = new System.Drawing.Size(56, 56);
            this.driverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.driverImage.TabIndex = 5;
            this.driverImage.TabStop = false;
            // 
            // driverButton
            // 
            this.driverButton.Animated = true;
            this.driverButton.BorderRadius = 6;
            this.driverButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.driverButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.driverButton.CheckedState.Parent = this.driverButton;
            this.driverButton.CustomImages.Parent = this.driverButton;
            this.driverButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(133)))), ((int)(((byte)(230)))));
            this.driverButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.driverButton.ForeColor = System.Drawing.Color.White;
            this.driverButton.HoverState.Parent = this.driverButton;
            this.driverButton.Location = new System.Drawing.Point(58, 174);
            this.driverButton.Name = "driverButton";
            this.driverButton.ShadowDecoration.Parent = this.driverButton;
            this.driverButton.Size = new System.Drawing.Size(83, 28);
            this.driverButton.TabIndex = 4;
            this.driverButton.Text = "Enable";
            this.driverButton.Click += new System.EventHandler(this.driverButton_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.guna2Panel4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 12;
            this.guna2Panel4.Controls.Add(this.mutexDescLabel);
            this.guna2Panel4.Controls.Add(this.mutexLabel);
            this.guna2Panel4.Controls.Add(this.mutexStatus);
            this.guna2Panel4.Controls.Add(this.mutexImage);
            this.guna2Panel4.Controls.Add(this.mutexButton);
            this.guna2Panel4.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(36)))), ((int)(((byte)(66)))));
            this.guna2Panel4.Location = new System.Drawing.Point(473, 59);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(200, 221);
            this.guna2Panel4.TabIndex = 12;
            // 
            // mutexDescLabel
            // 
            this.mutexDescLabel.AutoSize = false;
            this.mutexDescLabel.BackColor = System.Drawing.Color.Transparent;
            this.mutexDescLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutexDescLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(108)))), ((int)(((byte)(127)))));
            this.mutexDescLabel.Location = new System.Drawing.Point(0, 119);
            this.mutexDescLabel.Name = "mutexDescLabel";
            this.mutexDescLabel.Size = new System.Drawing.Size(194, 39);
            this.mutexDescLabel.TabIndex = 8;
            this.mutexDescLabel.Text = "Emulates sandboxing and previous infection markers";
            this.mutexDescLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mutexLabel
            // 
            this.mutexLabel.AutoSize = false;
            this.mutexLabel.BackColor = System.Drawing.Color.Transparent;
            this.mutexLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutexLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(157)))), ((int)(((byte)(169)))));
            this.mutexLabel.Location = new System.Drawing.Point(0, 90);
            this.mutexLabel.Name = "mutexLabel";
            this.mutexLabel.Size = new System.Drawing.Size(194, 27);
            this.mutexLabel.TabIndex = 7;
            this.mutexLabel.Text = "Global Mutexes";
            this.mutexLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mutexStatus
            // 
            this.mutexStatus.BackColor = System.Drawing.Color.Transparent;
            this.mutexStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(72)))), ((int)(((byte)(34)))));
            this.mutexStatus.Location = new System.Drawing.Point(7, 9);
            this.mutexStatus.Name = "mutexStatus";
            this.mutexStatus.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.mutexStatus.ShadowDecoration.Parent = this.mutexStatus;
            this.mutexStatus.Size = new System.Drawing.Size(8, 8);
            this.mutexStatus.TabIndex = 6;
            this.mutexStatus.TabStop = false;
            // 
            // mutexImage
            // 
            this.mutexImage.BackColor = System.Drawing.Color.Transparent;
            this.mutexImage.Image = ((System.Drawing.Image)(resources.GetObject("mutexImage.Image")));
            this.mutexImage.Location = new System.Drawing.Point(67, 22);
            this.mutexImage.Name = "mutexImage";
            this.mutexImage.Size = new System.Drawing.Size(56, 56);
            this.mutexImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mutexImage.TabIndex = 5;
            this.mutexImage.TabStop = false;
            // 
            // mutexButton
            // 
            this.mutexButton.Animated = true;
            this.mutexButton.BorderRadius = 6;
            this.mutexButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.mutexButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mutexButton.CheckedState.Parent = this.mutexButton;
            this.mutexButton.CustomImages.Parent = this.mutexButton;
            this.mutexButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(133)))), ((int)(((byte)(230)))));
            this.mutexButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mutexButton.ForeColor = System.Drawing.Color.White;
            this.mutexButton.HoverState.Parent = this.mutexButton;
            this.mutexButton.Location = new System.Drawing.Point(55, 174);
            this.mutexButton.Name = "mutexButton";
            this.mutexButton.ShadowDecoration.Parent = this.mutexButton;
            this.mutexButton.Size = new System.Drawing.Size(83, 28);
            this.mutexButton.TabIndex = 4;
            this.mutexButton.Text = "Enable";
            this.mutexButton.Click += new System.EventHandler(this.mutexButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(31)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(701, 554);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mirage Security";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileImage)).EndInit();
            this.formTopPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processImage)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registryStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registryImage)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.driverStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverImage)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mutexStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mutexImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm formBorder;
        private FontAwesome.Sharp.IconButton minimizeButton;
        private FontAwesome.Sharp.IconButton closeButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel formLabel;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2Button fileButton;
        private System.Windows.Forms.PictureBox fileImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox fileStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel fileLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel fileDescLabel;
        private Guna.UI2.WinForms.Guna2Panel formTopPanel;
        private Guna.UI2.WinForms.Guna2DragControl formTopPanelDrag;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel mutexDescLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel mutexLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox mutexStatus;
        private System.Windows.Forms.PictureBox mutexImage;
        private Guna.UI2.WinForms.Guna2Button mutexButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel driverDescLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel driverLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox driverStatus;
        private System.Windows.Forms.PictureBox driverImage;
        private Guna.UI2.WinForms.Guna2Button driverButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel registryDescLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel registryLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox registryStatus;
        private System.Windows.Forms.PictureBox registryImage;
        private Guna.UI2.WinForms.Guna2Button registryButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel processDescLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel processLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox processStatus;
        private System.Windows.Forms.PictureBox processImage;
        private Guna.UI2.WinForms.Guna2Button processButton;
    }
}

