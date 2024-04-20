using System.Drawing;
using System.Windows.Forms;

namespace Projekt3_Aksamitnyi62325
{
    partial class home_Form
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
            this.rotatingFigure_Button = new System.Windows.Forms.Button();
            this.polyhedrons_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rotatingFigure_Button
            // 
            this.rotatingFigure_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotatingFigure_Button.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotatingFigure_Button.Location = new System.Drawing.Point(130, 293);
            this.rotatingFigure_Button.Margin = new System.Windows.Forms.Padding(2);
            this.rotatingFigure_Button.Name = "rotatingFigure_Button";
            this.rotatingFigure_Button.Size = new System.Drawing.Size(316, 110);
            this.rotatingFigure_Button.TabIndex = 0;
            this.rotatingFigure_Button.Text = "Rotating Figure";
            this.rotatingFigure_Button.UseVisualStyleBackColor = true;
            this.rotatingFigure_Button.Click += new System.EventHandler(this.rotatingFigure_Button_ClickHandler);
            // 
            // polyhedrons_Button
            // 
            this.polyhedrons_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.polyhedrons_Button.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polyhedrons_Button.Location = new System.Drawing.Point(701, 293);
            this.polyhedrons_Button.Margin = new System.Windows.Forms.Padding(2);
            this.polyhedrons_Button.Name = "polyhedrons_Button";
            this.polyhedrons_Button.Size = new System.Drawing.Size(316, 110);
            this.polyhedrons_Button.TabIndex = 1;
            this.polyhedrons_Button.Text = "Polyhedrons";
            this.polyhedrons_Button.UseVisualStyleBackColor = true;
            this.polyhedrons_Button.Click += new System.EventHandler(this.polyhedrons_Button_ClickHandler);
            // 
            // home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 664);
            this.Controls.Add(this.polyhedrons_Button);
            this.Controls.Add(this.rotatingFigure_Button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "home_Form";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private Button rotatingFigure_Button;
        private Button polyhedrons_Button;
    }
}

