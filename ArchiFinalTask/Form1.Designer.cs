namespace ArchiFinalTask
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
            this.runBtn = new System.Windows.Forms.Button();
            this.PCTxt = new System.Windows.Forms.TextBox();
            this.IntializeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MemoryGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PiplineGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.MipsGrid = new System.Windows.Forms.DataGridView();
            this.registerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCodetxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MemoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiplineGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MipsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runBtn.Location = new System.Drawing.Point(369, 450);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(145, 45);
            this.runBtn.TabIndex = 35;
            this.runBtn.Text = "Run 1 cycle";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // PCTxt
            // 
            this.PCTxt.Location = new System.Drawing.Point(78, 461);
            this.PCTxt.Name = "PCTxt";
            this.PCTxt.Size = new System.Drawing.Size(100, 20);
            this.PCTxt.TabIndex = 33;
            this.PCTxt.Text = "1000";
            // 
            // IntializeBtn
            // 
            this.IntializeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntializeBtn.Location = new System.Drawing.Point(203, 450);
            this.IntializeBtn.Name = "IntializeBtn";
            this.IntializeBtn.Size = new System.Drawing.Size(145, 45);
            this.IntializeBtn.TabIndex = 34;
            this.IntializeBtn.Text = "Intialize";
            this.IntializeBtn.UseVisualStyleBackColor = true;
            this.IntializeBtn.Click += new System.EventHandler(this.inializeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1153, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Data memory";
            // 
            // MemoryGrid
            // 
            this.MemoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.MemoryGrid.Location = new System.Drawing.Point(1156, 45);
            this.MemoryGrid.Name = "MemoryGrid";
            this.MemoryGrid.ReadOnly = true;
            this.MemoryGrid.Size = new System.Drawing.Size(241, 373);
            this.MemoryGrid.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Value";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(616, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Pipline registers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "MIPS registers";
            // 
            // PiplineGrid
            // 
            this.PiplineGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PiplineGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.PiplineGrid.Location = new System.Drawing.Point(619, 45);
            this.PiplineGrid.Name = "PiplineGrid";
            this.PiplineGrid.ReadOnly = true;
            this.PiplineGrid.Size = new System.Drawing.Size(512, 373);
            this.PiplineGrid.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Register";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "user code";
            // 
            // MipsGrid
            // 
            this.MipsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MipsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerCol,
            this.valueCol});
            this.MipsGrid.Location = new System.Drawing.Point(358, 45);
            this.MipsGrid.Name = "MipsGrid";
            this.MipsGrid.ReadOnly = true;
            this.MipsGrid.Size = new System.Drawing.Size(242, 373);
            this.MipsGrid.TabIndex = 25;
            // 
            // registerCol
            // 
            this.registerCol.HeaderText = "Register";
            this.registerCol.Name = "registerCol";
            this.registerCol.ReadOnly = true;
            // 
            // valueCol
            // 
            this.valueCol.HeaderText = "Value";
            this.valueCol.Name = "valueCol";
            this.valueCol.ReadOnly = true;
            // 
            // UserCodetxt
            // 
            this.UserCodetxt.Location = new System.Drawing.Point(12, 45);
            this.UserCodetxt.Multiline = true;
            this.UserCodetxt.Name = "UserCodetxt";
            this.UserCodetxt.Size = new System.Drawing.Size(311, 373);
            this.UserCodetxt.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "PC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.PCTxt);
            this.Controls.Add(this.IntializeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MemoryGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PiplineGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MipsGrid);
            this.Controls.Add(this.UserCodetxt);
            this.Name = "Form1";
            this.Text = "MIPS Emulator";
            ((System.ComponentModel.ISupportInitialize)(this.MemoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PiplineGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MipsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.TextBox PCTxt;
        private System.Windows.Forms.Button IntializeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView MemoryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PiplineGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MipsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueCol;
        private System.Windows.Forms.TextBox UserCodetxt;
        private System.Windows.Forms.Label label5;
    }
}

