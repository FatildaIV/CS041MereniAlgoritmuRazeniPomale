
namespace CS031MereniAlgoritmuProhozeni
{
    partial class MereniAlgoritmuProhozeniForm
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
            this.testButton = new System.Windows.Forms.Button();
            this.vystupTextBox = new System.Windows.Forms.TextBox();
            this.meritProhozeniButton = new System.Windows.Forms.Button();
            this.meritRazeniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.testButton.Location = new System.Drawing.Point(16, 15);
            this.testButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(321, 132);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Spustit Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // vystupTextBox
            // 
            this.vystupTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vystupTextBox.Location = new System.Drawing.Point(16, 273);
            this.vystupTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vystupTextBox.Multiline = true;
            this.vystupTextBox.Name = "vystupTextBox";
            this.vystupTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.vystupTextBox.Size = new System.Drawing.Size(1033, 265);
            this.vystupTextBox.TabIndex = 1;
            // 
            // meritProhozeniButton
            // 
            this.meritProhozeniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.meritProhozeniButton.Location = new System.Drawing.Point(375, 15);
            this.meritProhozeniButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.meritProhozeniButton.Name = "meritProhozeniButton";
            this.meritProhozeniButton.Size = new System.Drawing.Size(321, 132);
            this.meritProhozeniButton.TabIndex = 2;
            this.meritProhozeniButton.Text = "Měřit prohození";
            this.meritProhozeniButton.UseVisualStyleBackColor = true;
            this.meritProhozeniButton.Click += new System.EventHandler(this.meritProhozeniButton_Click);
            // 
            // meritRazeniButton
            // 
            this.meritRazeniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.meritRazeniButton.Location = new System.Drawing.Point(729, 15);
            this.meritRazeniButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.meritRazeniButton.Name = "meritRazeniButton";
            this.meritRazeniButton.Size = new System.Drawing.Size(321, 132);
            this.meritRazeniButton.TabIndex = 3;
            this.meritRazeniButton.Text = "Měřit řazení";
            this.meritRazeniButton.UseVisualStyleBackColor = true;
            this.meritRazeniButton.Click += new System.EventHandler(this.meritRazeniButton_Click);
            // 
            // MereniAlgoritmuProhozeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.meritRazeniButton);
            this.Controls.Add(this.meritProhozeniButton);
            this.Controls.Add(this.vystupTextBox);
            this.Controls.Add(this.testButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MereniAlgoritmuProhozeniForm";
            this.Text = "CS041 Meření Algoritmu Pomalého Řazení - Václav Tomášek";
            this.Load += new System.EventHandler(this.MereniAlgoritmuProhozeniForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.TextBox vystupTextBox;
        private System.Windows.Forms.Button meritProhozeniButton;
        private System.Windows.Forms.Button meritRazeniButton;
    }
}

