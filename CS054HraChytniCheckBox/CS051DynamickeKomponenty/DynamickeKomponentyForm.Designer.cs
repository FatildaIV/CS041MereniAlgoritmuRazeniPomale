﻿
namespace CS051DynamickeKomponenty
{
    partial class DynamickeKomponentyForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.animaceTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // animaceTimer
            // 
            this.animaceTimer.Enabled = true;
            this.animaceTimer.Interval = 10;
            this.animaceTimer.Tick += new System.EventHandler(this.animaceTimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel.Location = new System.Drawing.Point(681, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(107, 24);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "score: 0000";
            // 
            // DynamickeKomponentyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoreLabel);
            this.Name = "DynamickeKomponentyForm";
            this.Text = "CS054 - Hra Chytni CheckBox - Šlechta Dominik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.DynamickeKomponentyForm_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DynamickeKomponentyForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer animaceTimer;
        private System.Windows.Forms.Label scoreLabel;
    }
}

