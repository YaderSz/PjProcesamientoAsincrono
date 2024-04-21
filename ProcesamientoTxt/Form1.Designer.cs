namespace ProcesamientoTxt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProcesar = new Button();
            dgvArchivos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvArchivos).BeginInit();
            SuspendLayout();
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(211, 92);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(163, 60);
            btnProcesar.TabIndex = 1;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // dgvArchivos
            // 
            dgvArchivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchivos.Location = new Point(48, 208);
            dgvArchivos.Name = "dgvArchivos";
            dgvArchivos.RowTemplate.Height = 25;
            dgvArchivos.Size = new Size(491, 150);
            dgvArchivos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(592, 450);
            Controls.Add(dgvArchivos);
            Controls.Add(btnProcesar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArchivos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnProcesar;
        private DataGridView dgvArchivos;
    }
}