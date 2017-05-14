namespace RustPluginChecker
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
            this.tbFileLocation = new System.Windows.Forms.TextBox();
            this.btnResources = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridShowPlugins = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbMultiLine = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgError = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.dgPluginCompare = new System.Windows.Forms.DataGridView();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShowPlugins)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPluginCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFileLocation
            // 
            this.tbFileLocation.Enabled = false;
            this.tbFileLocation.Location = new System.Drawing.Point(6, 21);
            this.tbFileLocation.Name = "tbFileLocation";
            this.tbFileLocation.Size = new System.Drawing.Size(326, 22);
            this.tbFileLocation.TabIndex = 2;
            // 
            // btnResources
            // 
            this.btnResources.Location = new System.Drawing.Point(338, 21);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(136, 23);
            this.btnResources.TabIndex = 4;
            this.btnResources.Text = "Link Resources";
            this.btnResources.UseVisualStyleBackColor = true;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridShowPlugins);
            this.groupBox1.Controls.Add(this.tbFileLocation);
            this.groupBox1.Controls.Add(this.btnResources);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 335);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plugin Resources";
            // 
            // dataGridShowPlugins
            // 
            this.dataGridShowPlugins.AllowUserToOrderColumns = true;
            this.dataGridShowPlugins.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridShowPlugins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShowPlugins.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridShowPlugins.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridShowPlugins.Location = new System.Drawing.Point(6, 49);
            this.dataGridShowPlugins.Name = "dataGridShowPlugins";
            this.dataGridShowPlugins.ReadOnly = true;
            this.dataGridShowPlugins.RowTemplate.Height = 24;
            this.dataGridShowPlugins.Size = new System.Drawing.Size(468, 279);
            this.dataGridShowPlugins.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCheck);
            this.groupBox2.Controls.Add(this.tbMultiLine);
            this.groupBox2.Location = new System.Drawing.Point(498, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 335);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raw Rcon Data";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(6, 294);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(362, 34);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check Plugins";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbMultiLine
            // 
            this.tbMultiLine.Location = new System.Drawing.Point(6, 21);
            this.tbMultiLine.Multiline = true;
            this.tbMultiLine.Name = "tbMultiLine";
            this.tbMultiLine.Size = new System.Drawing.Size(362, 267);
            this.tbMultiLine.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgError);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbUpdate);
            this.groupBox3.Controls.Add(this.progressbar);
            this.groupBox3.Controls.Add(this.dgPluginCompare);
            this.groupBox3.Location = new System.Drawing.Point(12, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(861, 321);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PluginCompare";
            // 
            // dgError
            // 
            this.dgError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgError.Location = new System.Drawing.Point(6, 242);
            this.dgError.Name = "dgError";
            this.dgError.RowTemplate.Height = 24;
            this.dgError.Size = new System.Drawing.Size(848, 73);
            this.dgError.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Plugins with info issues";
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.Location = new System.Drawing.Point(7, 55);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(110, 17);
            this.lbUpdate.TabIndex = 9;
            this.lbUpdate.Text = "Needs Updating";
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(6, 21);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(848, 29);
            this.progressbar.TabIndex = 8;
            // 
            // dgPluginCompare
            // 
            this.dgPluginCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPluginCompare.Location = new System.Drawing.Point(6, 78);
            this.dgPluginCompare.Name = "dgPluginCompare";
            this.dgPluginCompare.RowTemplate.Height = 24;
            this.dgPluginCompare.Size = new System.Drawing.Size(848, 141);
            this.dgPluginCompare.TabIndex = 0;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(RustPluginChecker.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 686);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RustPluginChecker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShowPlugins)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPluginCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbFileLocation;
        private System.Windows.Forms.Button btnResources;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridView dataGridShowPlugins;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMultiLine;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgPluginCompare;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.DataGridView dgError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUpdate;
    }
}

