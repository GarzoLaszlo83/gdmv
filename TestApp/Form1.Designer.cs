namespace TestApp
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
            this.components = new System.ComponentModel.Container();
            this.graphOfValues1 = new GraphicDisplayOfMeasuredValues.GraphOfValues(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.graphOfValues1)).BeginInit();
            this.SuspendLayout();
            // 
            // graphOfValues1
            // 
            this.graphOfValues1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.graphOfValues1.ErrorImage = null;
            this.graphOfValues1.Image = null;
            this.graphOfValues1.InitialImage = null;
            this.graphOfValues1.Location = new System.Drawing.Point(21, 24);
            this.graphOfValues1.Name = "graphOfValues1";
            this.graphOfValues1.Size = new System.Drawing.Size(182, 152);
            this.graphOfValues1.TabIndex = 0;
            this.graphOfValues1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.graphOfValues1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graphOfValues1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GraphicDisplayOfMeasuredValues.GraphOfValues graphOfValues1;
    }
}

