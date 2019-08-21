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
            this.cbAcumulada = new MaterialSkin.Controls.MaterialCheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(12, 73);
            this.dataGV.Name = "dataGV";
            this.dataGV.Size = new System.Drawing.Size(424, 330);
            this.dataGV.TabIndex = 0;
            // 
            // lblXi
            // 
            this.lblXi.AutoSize = true;
            this.lblXi.Depth = 0;
            this.lblXi.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblXi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblXi.Location = new System.Drawing.Point(442, 173);
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
            this.lblFi.Location = new System.Drawing.Point(443, 202);
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
            this.btnInsert.Location = new System.Drawing.Point(470, 242);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsert.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Primary = false;
            this.btnInsert.Size = new System.Drawing.Size(76, 36);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // txtXi
            // 
            this.txtXi.Depth = 0;
            this.txtXi.Hint = "";
            this.txtXi.Location = new System.Drawing.Point(475, 173);
            this.txtXi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtXi.Name = "txtXi";
            this.txtXi.PasswordChar = '\0';
            this.txtXi.SelectedText = "";
            this.txtXi.SelectionLength = 0;
            this.txtXi.SelectionStart = 0;
            this.txtXi.Size = new System.Drawing.Size(113, 23);
            this.txtXi.TabIndex = 1;
            this.txtXi.TabStop = false;
            this.txtXi.UseSystemPasswordChar = false;
            // 
            // txtFi
            // 
            this.txtFi.Depth = 0;
            this.txtFi.Hint = "";
            this.txtFi.Location = new System.Drawing.Point(474, 202);
            this.txtFi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFi.Name = "txtFi";
            this.txtFi.PasswordChar = '\0';
            this.txtFi.SelectedText = "";
            this.txtFi.SelectionLength = 0;
            this.txtFi.SelectionStart = 0;
            this.txtFi.Size = new System.Drawing.Size(113, 23);
            this.txtFi.TabIndex = 2;
            this.txtFi.TabStop = false;
            this.txtFi.UseSystemPasswordChar = false;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.Depth = 0;
            this.btnClear.Location = new System.Drawing.Point(446, 367);
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
            // cbAcumulada
            // 
            this.cbAcumulada.AutoSize = true;
            this.cbAcumulada.Depth = 0;
            this.cbAcumulada.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbAcumulada.Location = new System.Drawing.Point(446, 327);
            this.cbAcumulada.Margin = new System.Windows.Forms.Padding(0);
            this.cbAcumulada.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbAcumulada.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbAcumulada.Name = "cbAcumulada";
            this.cbAcumulada.Ripple = true;
            this.cbAcumulada.Size = new System.Drawing.Size(100, 30);
            this.cbAcumulada.TabIndex = 4;
            this.cbAcumulada.Text = "Acumulada";
            this.cbAcumulada.UseVisualStyleBackColor = true;
            this.cbAcumulada.CheckedChanged += new System.EventHandler(this.CbAcumulada_CheckedChanged);
            // 
            // cbRelativa
            // 
            this.cbRelativa.AutoSize = true;
            this.cbRelativa.Depth = 0;
            this.cbRelativa.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbRelativa.Location = new System.Drawing.Point(546, 327);
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
            this.lblTest.Location = new System.Drawing.Point(471, 250);
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
            this.lblN.Location = new System.Drawing.Point(37, 417);
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
            this.materialLabel4.Location = new System.Drawing.Point(85, 417);
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
            this.lblMedia.Location = new System.Drawing.Point(139, 417);
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
            this.btnExit.Location = new System.Drawing.Point(674, 400);
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
            this.rbContinuo.Location = new System.Drawing.Point(546, 73);
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
            this.rbDiscreto.Location = new System.Drawing.Point(446, 73);
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
            this.txtXi2.Location = new System.Drawing.Point(612, 173);
            this.txtXi2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtXi2.Name = "txtXi2";
            this.txtXi2.PasswordChar = '\0';
            this.txtXi2.SelectedText = "";
            this.txtXi2.SelectionLength = 0;
            this.txtXi2.SelectionStart = 0;
            this.txtXi2.Size = new System.Drawing.Size(111, 23);
            this.txtXi2.TabIndex = 2;
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
            this.lblDash.Location = new System.Drawing.Point(594, 175);
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
            this.btnDelete.Location = new System.Drawing.Point(565, 242);
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
            this.lblLRI.Location = new System.Drawing.Point(516, 151);
            this.lblLRI.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLRI.Name = "lblLRI";
            this.lblLRI.Size = new System.Drawing.Size(30, 19);
            this.lblLRI.TabIndex = 22;
            this.lblLRI.Text = "LRI";
            this.lblLRI.Visible = false;
            // 
            // lblLRS
            // 
            this.lblLRS.AutoSize = true;
            this.lblLRS.Depth = 0;
            this.lblLRS.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLRS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLRS.Location = new System.Drawing.Point(653, 151);
            this.lblLRS.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLRS.Name = "lblLRS";
            this.lblLRS.Size = new System.Drawing.Size(35, 19);
            this.lblLRS.TabIndex = 23;
            this.lblLRS.Text = "LRS";
            this.lblLRS.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(731, 445);
            this.Controls.Add(this.lblLRS);
            this.Controls.Add(this.lblLRI);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.txtXi2);
            this.Controls.Add(this.rbDiscreto);
            this.Controls.Add(this.rbContinuo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.cbRelativa);
            this.Controls.Add(this.cbAcumulada);
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
            this.Text = "ShockStats";
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
        private MaterialSkin.Controls.MaterialCheckBox cbAcumulada;
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
    }
}