namespace Sudoku
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.buttonSpielLaden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(346, 367);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderWidth = 12;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 0;
            this.lineShape4.X2 = 352;
            this.lineShape4.Y1 = 234;
            this.lineShape4.Y2 = 234;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderWidth = 12;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 1;
            this.lineShape3.X2 = 353;
            this.lineShape3.Y1 = 113;
            this.lineShape3.Y2 = 113;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderWidth = 7;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 236;
            this.lineShape2.X2 = 236;
            this.lineShape2.Y1 = 1;
            this.lineShape2.Y2 = 349;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 7;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 116;
            this.lineShape1.X2 = 116;
            this.lineShape1.Y1 = 1;
            this.lineShape1.Y2 = 349;
            // 
            // buttonSpielLaden
            // 
            this.buttonSpielLaden.Location = new System.Drawing.Point(0, 344);
            this.buttonSpielLaden.Name = "buttonSpielLaden";
            this.buttonSpielLaden.Size = new System.Drawing.Size(346, 23);
            this.buttonSpielLaden.TabIndex = 1;
            this.buttonSpielLaden.Text = "Neues Rätsel";
            this.buttonSpielLaden.UseVisualStyleBackColor = true;
            this.buttonSpielLaden.Click += new System.EventHandler(this.buttonSpielLaden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(346, 367);
            this.Controls.Add(this.buttonSpielLaden);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(362, 405);
            this.MinimumSize = new System.Drawing.Size(362, 405);
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button buttonSpielLaden;





    }
}