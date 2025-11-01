namespace WindowsFormsCleanArchitecture
{
    partial class FormNewEditBeer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboBrand = new ComboBox();
            txtName = new TextBox();
            txtAlcohol = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 83);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 139);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Alcohol:";
            // 
            // cboBrand
            // 
            cboBrand.FormattingEnabled = true;
            cboBrand.Location = new Point(172, 83);
            cboBrand.Name = "cboBrand";
            cboBrand.Size = new Size(121, 23);
            cboBrand.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(172, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 4;
            // 
            // txtAlcohol
            // 
            txtAlcohol.Location = new Point(172, 136);
            txtAlcohol.Name = "txtAlcohol";
            txtAlcohol.Size = new Size(121, 23);
            txtAlcohol.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(101, 189);
            button1.Name = "button1";
            button1.Size = new Size(90, 32);
            button1.TabIndex = 6;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormNewEditBeer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 244);
            Controls.Add(button1);
            Controls.Add(txtAlcohol);
            Controls.Add(txtName);
            Controls.Add(cboBrand);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNewEditBeer";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Nueva Cerveza";
            Load += FormNewEditBeer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboBrand;
        private TextBox txtName;
        private TextBox txtAlcohol;
        private Button button1;
    }
}