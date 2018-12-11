namespace Lab_10
{
    partial class WikiRiver
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tS1 = new System.Windows.Forms.ToolStrip();
            this.tlB1 = new System.Windows.Forms.ToolStripButton();
            this.tlB2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlB3 = new System.Windows.Forms.ToolStripButton();
            this.tlB4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlB5 = new System.Windows.Forms.ToolStripButton();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.bindSrcRivers = new System.Windows.Forms.BindingSource(this.components);
            this.tS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcRivers)).BeginInit();
            this.SuspendLayout();
            // 
            // tS1
            // 
            this.tS1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tS1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlB1,
            this.tlB2,
            this.toolStripSeparator3,
            this.tlB3,
            this.tlB4,
            this.toolStripSeparator2,
            this.tlB5});
            this.tS1.Location = new System.Drawing.Point(5, 5);
            this.tS1.Margin = new System.Windows.Forms.Padding(5);
            this.tS1.Name = "tS1";
            this.tS1.Padding = new System.Windows.Forms.Padding(0);
            this.tS1.Size = new System.Drawing.Size(772, 40);
            this.tS1.TabIndex = 0;
            this.tS1.Text = "toolStrip1";
            // 
            // tlB1
            // 
            this.tlB1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlB1.Image = global::Lab_10.Properties.Resources._001_plus;
            this.tlB1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlB1.Margin = new System.Windows.Forms.Padding(2);
            this.tlB1.Name = "tlB1";
            this.tlB1.Size = new System.Drawing.Size(36, 36);
            this.tlB1.Text = "toolStripButton1";
            this.tlB1.Click += new System.EventHandler(this.tlB1_Click);
            // 
            // tlB2
            // 
            this.tlB2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlB2.Image = global::Lab_10.Properties.Resources._005_writing;
            this.tlB2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlB2.Margin = new System.Windows.Forms.Padding(2);
            this.tlB2.Name = "tlB2";
            this.tlB2.Size = new System.Drawing.Size(36, 36);
            this.tlB2.Text = "toolStripButton2";
            this.tlB2.Click += new System.EventHandler(this.tlB2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // tlB3
            // 
            this.tlB3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlB3.Image = global::Lab_10.Properties.Resources._002_minus;
            this.tlB3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlB3.Margin = new System.Windows.Forms.Padding(2);
            this.tlB3.Name = "tlB3";
            this.tlB3.Size = new System.Drawing.Size(36, 36);
            this.tlB3.Text = "toolStripButton3";
            this.tlB3.Click += new System.EventHandler(this.tlB3_Click);
            // 
            // tlB4
            // 
            this.tlB4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlB4.Image = global::Lab_10.Properties.Resources._004_cancel_form;
            this.tlB4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlB4.Margin = new System.Windows.Forms.Padding(2);
            this.tlB4.Name = "tlB4";
            this.tlB4.Size = new System.Drawing.Size(36, 36);
            this.tlB4.Text = "toolStripButton4";
            this.tlB4.Click += new System.EventHandler(this.tlB4_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // tlB5
            // 
            this.tlB5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlB5.Image = global::Lab_10.Properties.Resources._006_logout;
            this.tlB5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlB5.Margin = new System.Windows.Forms.Padding(2);
            this.tlB5.Name = "tlB5";
            this.tlB5.Size = new System.Drawing.Size(36, 36);
            this.tlB5.Text = "toolStripButton5";
            this.tlB5.Click += new System.EventHandler(this.tlB5_Click);
            // 
            // dGV1
            // 
            this.dGV1.AllowUserToAddRows = false;
            this.dGV1.AllowUserToDeleteRows = false;
            this.dGV1.AutoGenerateColumns = false;
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.DataSource = this.bindSrcRivers;
            this.dGV1.Location = new System.Drawing.Point(8, 53);
            this.dGV1.Name = "dGV1";
            this.dGV1.ReadOnly = true;
            this.dGV1.Size = new System.Drawing.Size(766, 389);
            this.dGV1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.tS1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tS1.ResumeLayout(false);
            this.tS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcRivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tS1;
        private System.Windows.Forms.ToolStripButton tlB1;
        private System.Windows.Forms.ToolStripButton tlB2;
        private System.Windows.Forms.ToolStripButton tlB3;
        private System.Windows.Forms.ToolStripButton tlB4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlB5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.BindingSource bindSrcRivers;
    }
}

