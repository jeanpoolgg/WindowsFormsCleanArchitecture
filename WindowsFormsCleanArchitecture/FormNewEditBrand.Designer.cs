namespace WindowsFormsCleanArchitecture
{
    partial class FormNewEditBrand
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
            txtName = new TextBox();
            lblName = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(55, 36);
            lblName.Name = "lblName";
            lblName.Size = new Size(115, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre de la marca";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(124, 79);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(114, 36);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FormNewEditBrand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 164);
            Controls.Add(btnGuardar);
            Controls.Add(lblName);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormNewEditBrand";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nueva Marca";
            Load += FormNewEditBrand_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Button btnGuardar;
    }
}