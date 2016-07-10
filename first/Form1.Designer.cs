namespace first
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
            this.buttonDoSomething = new System.Windows.Forms.Button();
            this.textDoSomething = new System.Windows.Forms.TextBox();
            this.labelDoSomething = new System.Windows.Forms.Label();
            this.panelDataSet = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDataSet = new System.Windows.Forms.Label();
            this.panelDataTable = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.labelDataTable = new System.Windows.Forms.Label();
            this.buttonAddToDataSets = new System.Windows.Forms.Button();
            this.buttonAddToDataTable = new System.Windows.Forms.Button();
            this.buttonUpdateDS1 = new System.Windows.Forms.Button();
            this.panelDataSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDoSomething
            // 
            this.buttonDoSomething.Location = new System.Drawing.Point(21, 23);
            this.buttonDoSomething.Name = "buttonDoSomething";
            this.buttonDoSomething.Size = new System.Drawing.Size(137, 23);
            this.buttonDoSomething.TabIndex = 0;
            this.buttonDoSomething.Text = "Update label";
            this.buttonDoSomething.UseVisualStyleBackColor = true;
            this.buttonDoSomething.Click += new System.EventHandler(this.buttonDoSomething_Click);
            // 
            // textDoSomething
            // 
            this.textDoSomething.Location = new System.Drawing.Point(172, 26);
            this.textDoSomething.Name = "textDoSomething";
            this.textDoSomething.Size = new System.Drawing.Size(100, 20);
            this.textDoSomething.TabIndex = 1;
            // 
            // labelDoSomething
            // 
            this.labelDoSomething.AutoSize = true;
            this.labelDoSomething.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoSomething.Location = new System.Drawing.Point(320, 28);
            this.labelDoSomething.Name = "labelDoSomething";
            this.labelDoSomething.Size = new System.Drawing.Size(91, 20);
            this.labelDoSomething.TabIndex = 2;
            this.labelDoSomething.Text = "Update this";
            // 
            // panelDataSet
            // 
            this.panelDataSet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelDataSet.Controls.Add(this.buttonUpdateDS1);
            this.panelDataSet.Controls.Add(this.dataGridView3);
            this.panelDataSet.Controls.Add(this.dataGridView2);
            this.panelDataSet.Controls.Add(this.dataGridView1);
            this.panelDataSet.Controls.Add(this.labelDataSet);
            this.panelDataSet.Location = new System.Drawing.Point(21, 65);
            this.panelDataSet.Name = "panelDataSet";
            this.panelDataSet.Size = new System.Drawing.Size(874, 250);
            this.panelDataSet.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(568, 51);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(252, 146);
            this.dataGridView3.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(290, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(220, 152);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelDataSet
            // 
            this.labelDataSet.AutoSize = true;
            this.labelDataSet.Location = new System.Drawing.Point(28, 24);
            this.labelDataSet.Name = "labelDataSet";
            this.labelDataSet.Size = new System.Drawing.Size(49, 13);
            this.labelDataSet.TabIndex = 0;
            this.labelDataSet.Text = "Data Set";
            // 
            // panelDataTable
            // 
            this.panelDataTable.BackColor = System.Drawing.SystemColors.Info;
            this.panelDataTable.Controls.Add(this.dataGridView4);
            this.panelDataTable.Controls.Add(this.labelDataTable);
            this.panelDataTable.Location = new System.Drawing.Point(21, 372);
            this.panelDataTable.Name = "panelDataTable";
            this.panelDataTable.Size = new System.Drawing.Size(874, 218);
            this.panelDataTable.TabIndex = 4;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(152, 26);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(523, 169);
            this.dataGridView4.TabIndex = 1;
            // 
            // labelDataTable
            // 
            this.labelDataTable.AutoSize = true;
            this.labelDataTable.Location = new System.Drawing.Point(31, 26);
            this.labelDataTable.Name = "labelDataTable";
            this.labelDataTable.Size = new System.Drawing.Size(60, 13);
            this.labelDataTable.TabIndex = 0;
            this.labelDataTable.Text = "Data Table";
            // 
            // buttonAddToDataSets
            // 
            this.buttonAddToDataSets.Location = new System.Drawing.Point(363, 321);
            this.buttonAddToDataSets.Name = "buttonAddToDataSets";
            this.buttonAddToDataSets.Size = new System.Drawing.Size(133, 44);
            this.buttonAddToDataSets.TabIndex = 5;
            this.buttonAddToDataSets.Text = "Fill in data sets";
            this.buttonAddToDataSets.UseVisualStyleBackColor = true;
            this.buttonAddToDataSets.Click += new System.EventHandler(this.buttonAddData_Click);
            // 
            // buttonAddToDataTable
            // 
            this.buttonAddToDataTable.Location = new System.Drawing.Point(342, 596);
            this.buttonAddToDataTable.Name = "buttonAddToDataTable";
            this.buttonAddToDataTable.Size = new System.Drawing.Size(189, 44);
            this.buttonAddToDataTable.TabIndex = 6;
            this.buttonAddToDataTable.Text = "Add data to data table";
            this.buttonAddToDataTable.UseVisualStyleBackColor = true;
            this.buttonAddToDataTable.Click += new System.EventHandler(this.buttonAddToDataTable_Click);
            // 
            // buttonUpdateDS1
            // 
            this.buttonUpdateDS1.Location = new System.Drawing.Point(78, 206);
            this.buttonUpdateDS1.Name = "buttonUpdateDS1";
            this.buttonUpdateDS1.Size = new System.Drawing.Size(110, 30);
            this.buttonUpdateDS1.TabIndex = 4;
            this.buttonUpdateDS1.Text = "Update";
            this.buttonUpdateDS1.UseVisualStyleBackColor = true;
            this.buttonUpdateDS1.Click += new System.EventHandler(this.buttonUpdateDS1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 652);
            this.Controls.Add(this.buttonAddToDataTable);
            this.Controls.Add(this.buttonAddToDataSets);
            this.Controls.Add(this.panelDataTable);
            this.Controls.Add(this.panelDataSet);
            this.Controls.Add(this.labelDoSomething);
            this.Controls.Add(this.textDoSomething);
            this.Controls.Add(this.buttonDoSomething);
            this.Name = "Form1";
            this.Text = "First program";
            this.panelDataSet.ResumeLayout(false);
            this.panelDataSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDataTable.ResumeLayout(false);
            this.panelDataTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDoSomething;
        private System.Windows.Forms.TextBox textDoSomething;
        private System.Windows.Forms.Label labelDoSomething;
        private System.Windows.Forms.Panel panelDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelDataSet;
        private System.Windows.Forms.Panel panelDataTable;
        private System.Windows.Forms.Label labelDataTable;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button buttonAddToDataSets;
        private System.Windows.Forms.Button buttonAddToDataTable;
        private System.Windows.Forms.Button buttonUpdateDS1;
    }
}

