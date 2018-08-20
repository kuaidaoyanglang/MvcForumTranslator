using System.Drawing;
using System.Windows.Forms;

namespace MvcForumTranslator
{
    partial class MainFrm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMacth = new System.Windows.Forms.Button();
            this.txtConnString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewOK = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtFormer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listViewNo = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnMacth);
            this.groupBox1.Controls.Add(this.txtConnString);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1209, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnMacth
            // 
            this.btnMacth.AutoSize = true;
            this.btnMacth.Location = new System.Drawing.Point(1144, 20);
            this.btnMacth.Name = "btnMacth";
            this.btnMacth.Size = new System.Drawing.Size(55, 48);
            this.btnMacth.TabIndex = 6;
            this.btnMacth.Text = "连接";
            this.btnMacth.UseVisualStyleBackColor = true;
            this.btnMacth.Click += new System.EventHandler(this.btnMacth_Click);
            // 
            // txtConnString
            // 
            this.txtConnString.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtConnString.Location = new System.Drawing.Point(92, 20);
            this.txtConnString.Multiline = true;
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(1035, 48);
            this.txtConnString.TabIndex = 2;
            this.txtConnString.Text = "data source=.;initial catalog=MvcForum;persist security info=True;user id=sa;pass" +
    "word=MS!1yanglang;MultipleActiveResultSets=True;App=EntityFramework";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "连接字符串";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listViewOK);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已经匹配";
            // 
            // listViewOK
            // 
            this.listViewOK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOK.FullRowSelect = true;
            this.listViewOK.GridLines = true;
            this.listViewOK.Location = new System.Drawing.Point(3, 17);
            this.listViewOK.Name = "listViewOK";
            this.listViewOK.Size = new System.Drawing.Size(870, 210);
            this.listViewOK.TabIndex = 0;
            this.listViewOK.UseCompatibleStateImageBehavior = false;
            this.listViewOK.View = System.Windows.Forms.View.Details;
            this.listViewOK.SelectedIndexChanged += new System.EventHandler(this.listViewOK_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "单词";
            this.columnHeader2.Width = 212;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "中文";
            this.columnHeader3.Width = 323;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnConfirm);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.txtFormer);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1202, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(1047, 86);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(57, 21);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "匹配";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1122, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 77);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "写入";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1047, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 21);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(86, 87);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(935, 21);
            this.txtResult.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "查询结果:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(86, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(935, 21);
            this.txtSearch.TabIndex = 3;
            // 
            // txtFormer
            // 
            this.txtFormer.Location = new System.Drawing.Point(86, 31);
            this.txtFormer.Name = "txtFormer";
            this.txtFormer.Size = new System.Drawing.Size(935, 21);
            this.txtFormer.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "查询单词:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "原单词:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.listViewNo);
            this.groupBox4.Location = new System.Drawing.Point(617, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(597, 230);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "未匹配";
            // 
            // listViewNo
            // 
            this.listViewNo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewNo.FullRowSelect = true;
            this.listViewNo.GridLines = true;
            this.listViewNo.Location = new System.Drawing.Point(3, 17);
            this.listViewNo.Name = "listViewNo";
            this.listViewNo.Size = new System.Drawing.Size(591, 210);
            this.listViewNo.TabIndex = 0;
            this.listViewNo.UseCompatibleStateImageBehavior = false;
            this.listViewNo.View = System.Windows.Forms.View.Details;
            this.listViewNo.SelectedIndexChanged += new System.EventHandler(this.listViewNo_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "编号";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "单词";
            this.columnHeader5.Width = 222;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "中文";
            this.columnHeader6.Width = 301;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 452);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainFrm";
            this.Text = "MvcForum翻译机";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        private GroupBox groupBox1;

        private TextBox txtConnString;

        private Label label1;

        private Button btnMacth;

        private GroupBox groupBox2;

        private ListView listViewOK;

        private ColumnHeader columnHeader1;

        private ColumnHeader columnHeader2;

        private ColumnHeader columnHeader3;

        private GroupBox groupBox3;

        private Button btnConfirm;

        private Button btnSave;

        private Button btnSearch;

        private TextBox txtResult;

        private Label label5;

        private TextBox txtSearch;

        private TextBox txtFormer;

        private Label label4;

        private Label label3;

        private GroupBox groupBox4;

        private ListView listViewNo;

        private ColumnHeader columnHeader4;

        private ColumnHeader columnHeader5;

        private ColumnHeader columnHeader6;

        private FolderBrowserDialog folderBrowserDialog1;

        private OpenFileDialog openFileDialog1;

        #endregion
    }
}

