namespace Shock1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.lblXi = new MaterialSkin.Controls.MaterialLabel();
            this.lblFi = new MaterialSkin.Controls.MaterialLabel();
            this.btnInsert = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtXi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtFi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnClear = new MaterialSkin.Controls.MaterialFlatButton();
            this.cbRelativa = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblTest = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblN = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblMedia = new MaterialSkin.Controls.MaterialLabel();
            this.btnExit = new MaterialSkin.Controls.MaterialFlatButton();
            this.rbContinuo = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbDiscreto = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtXi2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDash = new MaterialSkin.Controls.MaterialLabel();
            this.btnDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblLRI = new MaterialSkin.Controls.MaterialLabel();
            this.lblLRS = new MaterialSkin.Controls.MaterialLabel();
            this.btnParticiones = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblF = new MaterialSkin.Controls.MaterialLabel();
            this.lblFisher = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPearson = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblMediana = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lblModa = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblS = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCV = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(10, 73);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(547, 330);
            this.dataGV.TabIndex = 10;
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Depth = 0;
            this.lblXi.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblXi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblXi.Location = new System.Drawing.Point(563, 173);
            this.lblXi.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblXi.Name = "lblXi";
            this.lblXi.Size = new System.Drawing.Size(26, 19);
            this.lblXi.TabIndex = 1;
            this.lblXi.Text = "Xi:";
            // 
            // lblFi
            // 
            this.lblFi.AutoSize = true;
            this.lblFi.Depth = 0;
            this.lblFi.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFi.Location = new System.Drawing.Point(564, 202);
            this.lblFi.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFi.Name = "lblFi";
            this.lblFi.Size = new System.Drawing.Size(25, 19);
            this.lblFi.TabIndex = 2;
            this.lblFi.Text = "Fi:";
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsert.Depth = 0;
            this.btnInsert.Location = new System.Drawing.Point(633, 242);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Primary = false;
            this.btnInsert.Size = new System.Drawing.Size(76, 36);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // txtXi
            // 
            this.txtXi.Depth = 0;
            this.txtXi.Hint = "";
            this.txtXi.Location = new System.Drawing.Point(596, 173);
            this.txtXi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtXi.Name = "txtXi";
            this.txtXi.PasswordChar = '\0';
            this.txtXi.SelectedText = "";
            this.txtXi.SelectionLength = 0;
            this.txtXi.SelectionStart = 0;
            this.txtXi.Size = new System.Drawing.Size(113, 23);
            this.txtXi.TabIndex = 0;
            this.txtXi.TabStop = false;
            this.txtXi.UseSystemPasswordChar = false;
            // 
            // txtFi
            // 
            this.txtFi.Depth = 0;
            this.txtFi.Hint = "";
            this.txtFi.Location = new System.Drawing.Point(595, 202);
            this.txtFi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFi.Name = "txtFi";
            this.txtFi.PasswordChar = '\0';
            this.txtFi.SelectedText = "";
            this.txtFi.SelectionLength = 0;
            this.txtFi.SelectionStart = 0;
            this.txtFi.Size = new System.Drawing.Size(113, 23);
            this.txtFi.TabIndex = 1;
            this.txtFi.TabStop = false;
            this.txtFi.UseSystemPasswordChar = false;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(564, 368);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClear.Name = "btnClear";
            this.btnClear.Primary = false;
            this.btnClear.Size = new System.Drawing.Size(66, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click_1);
            // 
            // cbRelativa
            // 
            this.cbRelativa.AutoSize = true;
            this.cbRelativa.Depth = 0;
            this.cbRelativa.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbRelativa.Location = new System.Drawing.Point(739, 368);
            this.cbRelativa.Margin = new System.Windows.Forms.Padding(0);
            this.cbRelativa.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbRelativa.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbRelativa.Name = "cbRelativa";
            this.cbRelativa.Ripple = true;
            this.cbRelativa.Size = new System.Drawing.Size(79, 30);
            this.cbRelativa.TabIndex = 5;
            this.cbRelativa.Text = "Relativa";
            this.cbRelativa.UseVisualStyleBackColor = true;
            this.cbRelativa.CheckedChanged += new System.EventHandler(this.CbRelativa_CheckedChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Depth = 0;
            this.lblTest.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTest.Location = new System.Drawing.Point(592, 250);
            this.lblTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 19);
            this.lblTest.TabIndex = 8;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 417);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(25, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "n: ";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Depth = 0;
            this.lblN.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblN.Location = new System.Drawing.Point(63, 417);
            this.lblN.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(0, 19);
            this.lblN.TabIndex = 10;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(155, 417);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(54, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Media:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Depth = 0;
            this.lblMedia.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMedia.Location = new System.Drawing.Point(225, 417);
            this.lblMedia.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(0, 19);
            this.lblMedia.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Depth = 0;
            this.btnExit.Location = new System.Drawing.Point(795, 424);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = false;
            this.btnExit.Size = new System.Drawing.Size(49, 36);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // rbContinuo
            // 
            this.rbContinuo.AutoSize = true;
            this.rbContinuo.Depth = 0;
            this.rbContinuo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbContinuo.Location = new System.Drawing.Point(733, 73);
            this.rbContinuo.Margin = new System.Windows.Forms.Padding(0);
            this.rbContinuo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbContinuo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbContinuo.Name = "rbContinuo";
            this.rbContinuo.Ripple = true;
            this.rbContinuo.Size = new System.Drawing.Size(85, 30);
            this.rbContinuo.TabIndex = 17;
            this.rbContinuo.Text = "Continuo";
            this.rbContinuo.UseVisualStyleBackColor = true;
            this.rbContinuo.CheckedChanged += new System.EventHandler(this.RbContinuo_CheckedChanged);
            // 
            // rbDiscreto
            // 
            this.rbDiscreto.AutoSize = true;
            this.rbDiscreto.Checked = true;
            this.rbDiscreto.Depth = 0;
            this.rbDiscreto.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbDiscreto.Location = new System.Drawing.Point(628, 73);
            this.rbDiscreto.Margin = new System.Windows.Forms.Padding(0);
            this.rbDiscreto.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbDiscreto.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbDiscreto.Name = "rbDiscreto";
            this.rbDiscreto.Ripple = true;
            this.rbDiscreto.Size = new System.Drawing.Size(80, 30);
            this.rbDiscreto.TabIndex = 18;
            this.rbDiscreto.TabStop = true;
            this.rbDiscreto.Text = "Discreto";
            this.rbDiscreto.UseVisualStyleBackColor = true;
            this.rbDiscreto.CheckedChanged += new System.EventHandler(this.RbDiscreto_CheckedChanged);
            // 
            // txtXi2
            // 
            this.txtXi2.Depth = 0;
            this.txtXi2.Hint = "";
            this.txtXi2.Location = new System.Drawing.Point(733, 173);
            this.txtXi2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtXi2.Name = "txtXi2";
            this.txtXi2.PasswordChar = '\0';
            this.txtXi2.SelectedText = "";
            this.txtXi2.SelectionLength = 0;
            this.txtXi2.SelectionStart = 0;
            this.txtXi2.Size = new System.Drawing.Size(111, 23);
            this.txtXi2.TabIndex = 1;
            this.txtXi2.TabStop = false;
            this.txtXi2.UseSystemPasswordChar = false;
            this.txtXi2.Visible = false;
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Depth = 0;
            this.lblDash.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDash.Location = new System.Drawing.Point(715, 175);
            this.lblDash.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(13, 19);
            this.lblDash.TabIndex = 20;
            this.lblDash.Text = "-";
            this.lblDash.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Location = new System.Drawing.Point(733, 242);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = false;
            this.btnDelete.Size = new System.Drawing.Size(74, 36);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // lblLRI
            // 
            this.lblLRI.AutoSize = true;
            this.lblLRI.Depth = 0;
            this.lblLRI.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLRI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLRI.Location = new System.Drawing.Point(637, 151);
            this.lblLRI.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLRI.Name = "lblLRI";
            this.lblLRI.Size = new System.Drawing.Size(34, 19);
            this.lblLRI.TabIndex = 22;
            this.lblLRI.Text = "LRI:";
            this.lblLRI.Visible = false;
            // 
            // lblLRS
            // 
            this.lblLRS.AutoSize = true;
            this.lblLRS.Depth = 0;
            this.lblLRS.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLRS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLRS.Location = new System.Drawing.Point(774, 151);
            this.lblLRS.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLRS.Name = "lblLRS";
            this.lblLRS.Size = new System.Drawing.Size(39, 19);
            this.lblLRS.TabIndex = 23;
            this.lblLRS.Text = "LRS:";
            this.lblLRS.Visible = false;
            // 
            // btnParticiones
            // 
            this.btnParticiones.AutoSize = true;
            this.btnParticiones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnParticiones.Depth = 0;
            this.btnParticiones.Location = new System.Drawing.Point(611, 290);
            this.btnParticiones.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnParticiones.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnParticiones.Name = "btnParticiones";
            this.btnParticiones.Primary = false;
            this.btnParticiones.Size = new System.Drawing.Size(207, 36);
            this.btnParticiones.TabIndex = 26;
            this.btnParticiones.Text = "Medidas de concentración";
            this.btnParticiones.UseVisualStyleBackColor = true;
            this.btnParticiones.Click += new System.EventHandler(this.BtnParticiones_Click);
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Depth = 0;
            this.lblF.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblF.Location = new System.Drawing.Point(310, 447);
            this.lblF.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(54, 19);
            this.lblF.TabIndex = 27;
            this.lblF.Text = "Fisher:";
            // 
            // lblFisher
            // 
            this.lblFisher.AutoSize = true;
            this.lblFisher.Depth = 0;
            this.lblFisher.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFisher.Location = new System.Drawing.Point(375, 447);
            this.lblFisher.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFisher.Name = "lblFisher";
            this.lblFisher.Size = new System.Drawing.Size(0, 19);
            this.lblFisher.TabIndex = 28;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(310, 417);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 29;
            this.materialLabel1.Text = "Pearson:";
            // 
            // lblPearson
            // 
            this.lblPearson.AutoSize = true;
            this.lblPearson.Depth = 0;
            this.lblPearson.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPearson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPearson.Location = new System.Drawing.Point(375, 417);
            this.lblPearson.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPearson.Name = "lblPearson";
            this.lblPearson.Size = new System.Drawing.Size(0, 19);
            this.lblPearson.TabIndex = 30;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(155, 447);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Mediana:";
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Depth = 0;
            this.lblMediana.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMediana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMediana.Location = new System.Drawing.Point(225, 447);
            this.lblMediana.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(0, 19);
            this.lblMediana.TabIndex = 32;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 447);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(51, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Moda:";
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Depth = 0;
            this.lblModa.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblModa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblModa.Location = new System.Drawing.Point(60, 447);
            this.lblModa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(0, 19);
            this.lblModa.TabIndex = 10;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(449, 417);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(35, 19);
            this.materialLabel6.TabIndex = 33;
            this.materialLabel6.Text = "s/σ:";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Depth = 0;
            this.lblS.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblS.Location = new System.Drawing.Point(490, 417);
            this.lblS.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(0, 19);
            this.lblS.TabIndex = 34;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(449, 447);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(41, 19);
            this.materialLabel7.TabIndex = 33;
            this.materialLabel7.Text = "C.V.:";
            // 
            // lblCV
            // 
            this.lblCV.AutoSize = true;
            this.lblCV.Depth = 0;
            this.lblCV.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCV.Location = new System.Drawing.Point(490, 447);
            this.lblCV.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(0, 19);
            this.lblCV.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(865, 475);
            this.Controls.Add(this.lblCV);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.lblMediana);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lblPearson);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblFisher);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.btnParticiones);
            this.Controls.Add(this.lblLRS);
            this.Controls.Add(this.lblLRI);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.txtXi2);
            this.Controls.Add(this.rbDiscreto);
            this.Controls.Add(this.rbContinuo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblModa);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.cbRelativa);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtFi);
            this.Controls.Add(this.txtXi);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblFi);
            this.Controls.Add(this.lblXi);
            this.Controls.Add(this.dataGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shock!Stats";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV;
        private MaterialSkin.Controls.MaterialLabel lblXi;
        private MaterialSkin.Controls.MaterialLabel lblFi;
        private MaterialSkin.Controls.MaterialFlatButton btnInsert;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtXi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFi;
        private MaterialSkin.Controls.MaterialFlatButton btnClear;
        private MaterialSkin.Controls.MaterialCheckBox cbRelativa;
        private MaterialSkin.Controls.MaterialLabel lblTest;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblN;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblMedia;
        private MaterialSkin.Controls.MaterialFlatButton btnExit;
        private MaterialSkin.Controls.MaterialRadioButton rbContinuo;
        private MaterialSkin.Controls.MaterialRadioButton rbDiscreto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtXi2;
        private MaterialSkin.Controls.MaterialLabel lblDash;
        private MaterialSkin.Controls.MaterialFlatButton btnDelete;
        private MaterialSkin.Controls.MaterialLabel lblLRI;
        private MaterialSkin.Controls.MaterialLabel lblLRS;
        private MaterialSkin.Controls.MaterialFlatButton btnParticiones;
        private MaterialSkin.Controls.MaterialLabel lblF;
        private MaterialSkin.Controls.MaterialLabel lblFisher;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblPearson;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblMediana;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblModa;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblS;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel lblCV;
    }
}