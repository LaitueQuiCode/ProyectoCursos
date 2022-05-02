namespace ProyectoCursos
{
    partial class MantenedorAlumnos
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
            this.alumnosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // alumnosDataGridView
            // 
            this.alumnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alumnosDataGridView.Location = new System.Drawing.Point(61, 44);
            this.alumnosDataGridView.Name = "alumnosDataGridView";
            this.alumnosDataGridView.Size = new System.Drawing.Size(240, 150);
            this.alumnosDataGridView.TabIndex = 0;
            // 
            // MantenedorAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alumnosDataGridView);
            this.Name = "MantenedorAlumnos";
            this.Text = "mantenedor alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.alumnosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView alumnosDataGridView;
    }
}