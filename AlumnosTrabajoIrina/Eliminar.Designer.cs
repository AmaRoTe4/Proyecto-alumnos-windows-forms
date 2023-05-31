namespace AlumnosTrabajoIrina
{
    partial class Eliminar
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
            this.textData = new System.Windows.Forms.Label();
            this.txtBoxData = new System.Windows.Forms.TextBox();
            this.textInfo = new System.Windows.Forms.Label();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textData
            // 
            this.textData.AutoSize = true;
            this.textData.Location = new System.Drawing.Point(24, 50);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(26, 13);
            this.textData.TabIndex = 3;
            this.textData.Text = "DNI";
            // 
            // txtBoxData
            // 
            this.txtBoxData.Location = new System.Drawing.Point(67, 47);
            this.txtBoxData.Name = "txtBoxData";
            this.txtBoxData.Size = new System.Drawing.Size(370, 20);
            this.txtBoxData.TabIndex = 2;
            this.txtBoxData.TextChanged += new System.EventHandler(this.txtBoxData_TextChanged);
            // 
            // textInfo
            // 
            this.textInfo.AutoSize = true;
            this.textInfo.Location = new System.Drawing.Point(27, 79);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(227, 13);
            this.textInfo.TabIndex = 4;
            this.textInfo.Text = "Agrege el dni del alumno que pretende eliminar";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(486, 42);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(101, 28);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(486, 79);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(101, 28);
            this.btn_volver.TabIndex = 6;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 125);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.txtBoxData);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textData;
        private System.Windows.Forms.TextBox txtBoxData;
        private System.Windows.Forms.Label textInfo;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_volver;
    }
}