namespace AlumnosTrabajoIrina
{
    partial class Listar
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
            this.boxText = new System.Windows.Forms.GroupBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.btn_volver = new System.Windows.Forms.Button();
            this.boxText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // boxText
            // 
            this.boxText.Controls.Add(this.gridData);
            this.boxText.Location = new System.Drawing.Point(21, 30);
            this.boxText.Name = "boxText";
            this.boxText.Size = new System.Drawing.Size(753, 191);
            this.boxText.TabIndex = 0;
            this.boxText.TabStop = false;
            this.boxText.Text = "Data";
            // 
            // gridData
            // 
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Location = new System.Drawing.Point(18, 19);
            this.gridData.Name = "gridData";
            this.gridData.Size = new System.Drawing.Size(712, 150);
            this.gridData.TabIndex = 0;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(358, 243);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Salir";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 278);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.boxText);
            this.Name = "Listar";
            this.Text = "Listar";
            this.boxText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxText;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Button btn_volver;
    }
}