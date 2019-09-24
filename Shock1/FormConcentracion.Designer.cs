namespace Shock1
{
    partial class FormConcentracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConcentracion));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCuartil = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDecil = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPercentil = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPCP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPP = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblResultado = new MaterialSkin.Controls.MaterialLabel();
            this.btnCalcular = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(32, 102);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Cuartil (1-4)";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(32, 149);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(85, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Decil (1-10)";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(32, 194);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(118, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Percentil (1-100)";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 232);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(104, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Personalizado";
            // 
            // txtCuartil
            // 
            this.txtCuartil.Depth = 0;
            this.txtCuartil.Hint = "";
            this.txtCuartil.Location = new System.Drawing.Point(223, 102);
            this.txtCuartil.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCuartil.Name = "txtCuartil";
            this.txtCuartil.PasswordChar = '\0';
            this.txtCuartil.SelectedText = "";
            this.txtCuartil.SelectionLength = 0;
            this.txtCuartil.SelectionStart = 0;
            this.txtCuartil.Size = new System.Drawing.Size(75, 23);
            this.txtCuartil.TabIndex = 0;
            this.txtCuartil.UseSystemPasswordChar = false;
          
            // 
            // txtDecil
            // 
            this.txtDecil.Depth = 0;
            this.txtDecil.Hint = "";
            this.txtDecil.Location = new System.Drawing.Point(223, 146);
            this.txtDecil.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDecil.Name = "txtDecil";
            this.txtDecil.PasswordChar = '\0';
            this.txtDecil.SelectedText = "";
            this.txtDecil.SelectionLength = 0;
            this.txtDecil.SelectionStart = 0;
            this.txtDecil.Size = new System.Drawing.Size(75, 23);
            this.txtDecil.TabIndex = 4;
            this.txtDecil.UseSystemPasswordChar = false;
            // 
            // txtPercentil
            // 
            this.txtPercentil.Depth = 0;
            this.txtPercentil.Hint = "";
            this.txtPercentil.Location = new System.Drawing.Point(223, 194);
            this.txtPercentil.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPercentil.Name = "txtPercentil";
            this.txtPercentil.PasswordChar = '\0';
            this.txtPercentil.SelectedText = "";
            this.txtPercentil.SelectionLength = 0;
            this.txtPercentil.SelectionStart = 0;
            this.txtPercentil.Size = new System.Drawing.Size(75, 23);
            this.txtPercentil.TabIndex = 4;
            this.txtPercentil.UseSystemPasswordChar = false;
            // 
            // txtPCP
            // 
            this.txtPCP.Depth = 0;
            this.txtPCP.Hint = "";
            this.txtPCP.Location = new System.Drawing.Point(223, 277);
            this.txtPCP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPCP.Name = "txtPCP";
            this.txtPCP.PasswordChar = '\0';
            this.txtPCP.SelectedText = "";
            this.txtPCP.SelectionLength = 0;
            this.txtPCP.SelectionStart = 0;
            this.txtPCP.Size = new System.Drawing.Size(75, 23);
            this.txtPCP.TabIndex = 4;
            this.txtPCP.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(32, 277);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(168, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Cantidad de Particiones";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(38, 326);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(86, 19);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Posición (i)";
            // 
            // txtPP
            // 
            this.txtPP.Depth = 0;
            this.txtPP.Hint = "";
            this.txtPP.Location = new System.Drawing.Point(223, 326);
            this.txtPP.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPP.Name = "txtPP";
            this.txtPP.PasswordChar = '\0';
            this.txtPP.SelectedText = "";
            this.txtPP.SelectionLength = 0;
            this.txtPP.SelectionStart = 0;
            this.txtPP.Size = new System.Drawing.Size(75, 23);
            this.txtPP.TabIndex = 7;
            this.txtPP.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(12, 64);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(188, 19);
            this.materialLabel7.TabIndex = 11;
            this.materialLabel7.Text = "Medidas de Concentración";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Depth = 0;
            this.lblResultado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblResultado.Location = new System.Drawing.Point(424, 195);
            this.lblResultado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 19);
            this.lblResultado.TabIndex = 13;
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalcular.Depth = 0;
            this.btnCalcular.Location = new System.Drawing.Point(217, 377);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCalcular.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Primary = false;
            this.btnCalcular.Size = new System.Drawing.Size(81, 36);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(151, 377);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = false;
            this.btnSalir.Size = new System.Drawing.Size(49, 36);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 422);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtPP);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtPCP);
            this.Controls.Add(this.txtPercentil);
            this.Controls.Add(this.txtDecil);
            this.Controls.Add(this.txtCuartil);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Particiones";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCuartil;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDecil;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPercentil;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPCP;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPP;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel lblResultado;
        private MaterialSkin.Controls.MaterialFlatButton btnCalcular;
        private MaterialSkin.Controls.MaterialFlatButton btnSalir;
    }
}