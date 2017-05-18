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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbFileLocation = new System.Windows.Forms.TextBox();
            this.btnResources = new System.Windows.Forms.Button();
            this.gbResources = new System.Windows.Forms.GroupBox();
            this.dataGridShowPlugins = new System.Windows.Forms.DataGridView();
            this.gpRconData = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.gbPluginCompare = new System.Windows.Forms.GroupBox();
            this.dgError = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.dgPluginCompare = new System.Windows.Forms.DataGridView();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtbMultiLine = new System.Windows.Forms.RichTextBox();
            this.gbResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShowPlugins)).BeginInit();
            this.gpRconData.SuspendLayout();
            this.gbPluginCompare.SuspendLayout();
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
            this.tbFileLocation.Size = new System.Drawing.Size(326, 21);
            this.tbFileLocation.TabIndex = 2;
            // 
            // btnResources
            // 
            this.btnResources.Location = new System.Drawing.Point(338, 21);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(136, 23);
            this.btnResources.TabIndex = 4;
            this.btnResources.Text = "Link Resources";
            this.btnResources.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResources.UseVisualStyleBackColor = true;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // gbResources
            // 
            this.gbResources.Controls.Add(this.dataGridShowPlugins);
            this.gbResources.Controls.Add(this.tbFileLocation);
            this.gbResources.Controls.Add(this.btnResources);
            this.gbResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResources.Location = new System.Drawing.Point(12, 12);
            this.gbResources.Name = "gbResources";
            this.gbResources.Size = new System.Drawing.Size(480, 335);
            this.gbResources.TabIndex = 5;
            this.gbResources.TabStop = false;
            this.gbResources.Text = "Plugin Resources";
            // 
            // dataGridShowPlugins
            // 
            this.dataGridShowPlugins.AllowUserToOrderColumns = true;
            this.dataGridShowPlugins.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridShowPlugins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridShowPlugins.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridShowPlugins.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridShowPlugins.Location = new System.Drawing.Point(6, 49);
            this.dataGridShowPlugins.Name = "dataGridShowPlugins";
            this.dataGridShowPlugins.ReadOnly = true;
            this.dataGridShowPlugins.RowHeadersVisible = false;
            this.dataGridShowPlugins.RowTemplate.Height = 24;
            this.dataGridShowPlugins.Size = new System.Drawing.Size(468, 279);
            this.dataGridShowPlugins.TabIndex = 14;
            // 
            // gpRconData
            // 
            this.gpRconData.Controls.Add(this.rtbMultiLine);
            this.gpRconData.Controls.Add(this.btnCheck);
            this.gpRconData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpRconData.Location = new System.Drawing.Point(498, 12);
            this.gpRconData.Name = "gpRconData";
            this.gpRconData.Size = new System.Drawing.Size(375, 335);
            this.gpRconData.TabIndex = 6;
            this.gpRconData.TabStop = false;
            this.gpRconData.Text = "Raw Rcon Data";
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
            // gbPluginCompare
            // 
            this.gbPluginCompare.Controls.Add(this.dgError);
            this.gbPluginCompare.Controls.Add(this.label1);
            this.gbPluginCompare.Controls.Add(this.lbUpdate);
            this.gbPluginCompare.Controls.Add(this.progressbar);
            this.gbPluginCompare.Controls.Add(this.dgPluginCompare);
            this.gbPluginCompare.Enabled = false;
            this.gbPluginCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPluginCompare.Location = new System.Drawing.Point(12, 353);
            this.gbPluginCompare.Name = "gbPluginCompare";
            this.gbPluginCompare.Size = new System.Drawing.Size(861, 321);
            this.gbPluginCompare.TabIndex = 7;
            this.gbPluginCompare.TabStop = false;
            this.gbPluginCompare.Text = "Plugin Compare";
            // 
            // dgError
            // 
            this.dgError.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgError.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgError.Location = new System.Drawing.Point(6, 242);
            this.dgError.Name = "dgError";
            this.dgError.RowHeadersVisible = false;
            this.dgError.RowTemplate.Height = 24;
            this.dgError.Size = new System.Drawing.Size(848, 73);
            this.dgError.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Plugins with info issues";
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.Location = new System.Drawing.Point(7, 55);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(107, 16);
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
            this.dgPluginCompare.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgPluginCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPluginCompare.Location = new System.Drawing.Point(6, 78);
            this.dgPluginCompare.Name = "dgPluginCompare";
            this.dgPluginCompare.RowHeadersVisible = false;
            this.dgPluginCompare.RowTemplate.Height = 24;
            this.dgPluginCompare.Size = new System.Drawing.Size(848, 141);
            this.dgPluginCompare.TabIndex = 0;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(RustPluginChecker.Form1);
            // 
            // rtbMultiLine
            // 
            this.rtbMultiLine.Location = new System.Drawing.Point(6, 22);
            this.rtbMultiLine.Name = "rtbMultiLine";
            this.rtbMultiLine.Size = new System.Drawing.Size(362, 266);
            this.rtbMultiLine.TabIndex = 12;
            this.rtbMultiLine.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 686);
            this.Controls.Add(this.gbPluginCompare);
            this.Controls.Add(this.gpRconData);
            this.Controls.Add(this.gbResources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Rust Plugin Checker v0.1";
            this.gbResources.ResumeLayout(false);
            this.gbResources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridShowPlugins)).EndInit();
            this.gpRconData.ResumeLayout(false);
            this.gbPluginCompare.ResumeLayout(false);
            this.gbPluginCompare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPluginCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbFileLocation;
        private System.Windows.Forms.Button btnResources;
        private System.Windows.Forms.GroupBox gbResources;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.DataGridView dataGridShowPlugins;
        private System.Windows.Forms.GroupBox gpRconData;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox gbPluginCompare;
        private System.Windows.Forms.DataGridView dgPluginCompare;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.DataGridView dgError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.RichTextBox rtbMultiLine;
    }
}

