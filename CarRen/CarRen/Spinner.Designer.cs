
namespace CarRen
{
    partial class Spinner
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spinner));
            this.Car = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Progress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Percent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            this.Progress.SuspendLayout();
            this.SuspendLayout();
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.Color.Transparent;
            this.Car.FillColor = System.Drawing.Color.Transparent;
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.ImageRotate = 0F;
            this.Car.Location = new System.Drawing.Point(14, 37);
            this.Car.Name = "Car";
            this.Car.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Car.ShadowDecoration.Parent = this.Car;
            this.Car.Size = new System.Drawing.Size(176, 157);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Car.TabIndex = 0;
            this.Car.TabStop = false;
            this.Car.Click += new System.EventHandler(this.Car_Click);
            // 
            // Progress
            // 
            this.Progress.Controls.Add(this.Percent);
            this.Progress.Controls.Add(this.Car);
            this.Progress.FillColor = System.Drawing.Color.SlateGray;
            this.Progress.FillThickness = 10;
            this.Progress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Progress.ForeColor = System.Drawing.Color.Transparent;
            this.Progress.InnerColor = System.Drawing.Color.SlateGray;
            this.Progress.Location = new System.Drawing.Point(299, 73);
            this.Progress.Minimum = 0;
            this.Progress.Name = "Progress";
            this.Progress.ProgressColor = System.Drawing.Color.LightGray;
            this.Progress.ProgressColor2 = System.Drawing.Color.LightGray;
            this.Progress.ProgressThickness = 10;
            this.Progress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Progress.ShadowDecoration.Parent = this.Progress;
            this.Progress.Size = new System.Drawing.Size(216, 216);
            this.Progress.TabIndex = 1;
            this.Progress.Text = "guna2CircleProgressBar1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(271, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(309, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tomasz Nowicki";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Percent
            // 
            this.Percent.AutoSize = true;
            this.Percent.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Percent.ForeColor = System.Drawing.Color.LightGray;
            this.Percent.Location = new System.Drawing.Point(90, 171);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(23, 23);
            this.Percent.TabIndex = 4;
            this.Percent.Text = "%";
            this.Percent.Click += new System.EventHandler(this.label3_Click);
            // 
            // Spinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(845, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Spinner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Spinner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            this.Progress.ResumeLayout(false);
            this.Progress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox Car;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Progress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Percent;
    }
}

