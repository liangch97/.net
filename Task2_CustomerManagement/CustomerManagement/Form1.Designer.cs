namespace CustomerManagement;

partial class Form1
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
        groupBox1 = new GroupBox();
        btn_Cancel = new Button();
        btn_Save = new Button();
        txt_Address = new TextBox();
        txt_Telephone = new TextBox();
        nudown_Age = new NumericUpDown();
        rbtn_Sex2 = new RadioButton();
        rbtn_Sex1 = new RadioButton();
        txt_Company = new TextBox();
        txt_Name = new TextBox();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        groupBox2 = new GroupBox();
        btn_Del = new Button();
        lv_Customer = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        columnHeader4 = new ColumnHeader();
        columnHeader5 = new ColumnHeader();
        columnHeader6 = new ColumnHeader();
        columnHeader7 = new ColumnHeader();
        lbl_Status = new Label();
        lbl_Note = new Label();
        label7 = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudown_Age).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btn_Cancel);
        groupBox1.Controls.Add(btn_Save);
        groupBox1.Controls.Add(txt_Address);
        groupBox1.Controls.Add(txt_Telephone);
        groupBox1.Controls.Add(nudown_Age);
        groupBox1.Controls.Add(rbtn_Sex2);
        groupBox1.Controls.Add(rbtn_Sex1);
        groupBox1.Controls.Add(txt_Company);
        groupBox1.Controls.Add(txt_Name);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(560, 180);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "编辑客户信息";
        // 
        // btn_Cancel
        // 
        btn_Cancel.Location = new Point(470, 135);
        btn_Cancel.Name = "btn_Cancel";
        btn_Cancel.Size = new Size(75, 30);
        btn_Cancel.TabIndex = 14;
        btn_Cancel.Text = "取消";
        btn_Cancel.UseVisualStyleBackColor = true;
        btn_Cancel.Click += btn_Cancel_Click;
        // 
        // btn_Save
        // 
        btn_Save.Location = new Point(380, 135);
        btn_Save.Name = "btn_Save";
        btn_Save.Size = new Size(75, 30);
        btn_Save.TabIndex = 13;
        btn_Save.Text = "保存";
        btn_Save.UseVisualStyleBackColor = true;
        btn_Save.Click += btn_Save_Click;
        // 
        // txt_Address
        // 
        txt_Address.Location = new Point(340, 95);
        txt_Address.Name = "txt_Address";
        txt_Address.Size = new Size(205, 23);
        txt_Address.TabIndex = 12;
        // 
        // txt_Telephone
        // 
        txt_Telephone.Location = new Point(100, 95);
        txt_Telephone.Name = "txt_Telephone";
        txt_Telephone.Size = new Size(150, 23);
        txt_Telephone.TabIndex = 11;
        // 
        // nudown_Age
        // 
        nudown_Age.Location = new Point(340, 57);
        nudown_Age.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        nudown_Age.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        nudown_Age.Name = "nudown_Age";
        nudown_Age.Size = new Size(80, 23);
        nudown_Age.TabIndex = 10;
        nudown_Age.Value = new decimal(new int[] { 25, 0, 0, 0 });
        // 
        // rbtn_Sex2
        // 
        rbtn_Sex2.AutoSize = true;
        rbtn_Sex2.Location = new Point(183, 58);
        rbtn_Sex2.Name = "rbtn_Sex2";
        rbtn_Sex2.Size = new Size(37, 21);
        rbtn_Sex2.TabIndex = 9;
        rbtn_Sex2.Text = "女";
        rbtn_Sex2.UseVisualStyleBackColor = true;
        // 
        // rbtn_Sex1
        // 
        rbtn_Sex1.AutoSize = true;
        rbtn_Sex1.Checked = true;
        rbtn_Sex1.Location = new Point(100, 58);
        rbtn_Sex1.Name = "rbtn_Sex1";
        rbtn_Sex1.Size = new Size(37, 21);
        rbtn_Sex1.TabIndex = 8;
        rbtn_Sex1.TabStop = true;
        rbtn_Sex1.Text = "男";
        rbtn_Sex1.UseVisualStyleBackColor = true;
        // 
        // txt_Company
        // 
        txt_Company.Location = new Point(340, 22);
        txt_Company.Name = "txt_Company";
        txt_Company.Size = new Size(205, 23);
        txt_Company.TabIndex = 7;
        // 
        // txt_Name
        // 
        txt_Name.Location = new Point(100, 22);
        txt_Name.Name = "txt_Name";
        txt_Name.Size = new Size(150, 23);
        txt_Name.TabIndex = 6;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(280, 98);
        label6.Name = "label6";
        label6.Size = new Size(56, 17);
        label6.TabIndex = 5;
        label6.Text = "联系地址";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(20, 98);
        label5.Name = "label5";
        label5.Size = new Size(56, 17);
        label5.TabIndex = 4;
        label5.Text = "联系电话";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(280, 59);
        label4.Name = "label4";
        label4.Size = new Size(32, 17);
        label4.TabIndex = 3;
        label4.Text = "年龄";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(20, 59);
        label3.Name = "label3";
        label3.Size = new Size(32, 17);
        label3.TabIndex = 2;
        label3.Text = "性别";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(280, 25);
        label2.Name = "label2";
        label2.Size = new Size(32, 17);
        label2.TabIndex = 1;
        label2.Text = "单位";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(20, 25);
        label1.Name = "label1";
        label1.Size = new Size(32, 17);
        label1.TabIndex = 0;
        label1.Text = "姓名";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btn_Del);
        groupBox2.Controls.Add(lv_Customer);
        groupBox2.Location = new Point(12, 200);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(660, 240);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "客户信息列表";
        // 
        // btn_Del
        // 
        btn_Del.Location = new Point(570, 22);
        btn_Del.Name = "btn_Del";
        btn_Del.Size = new Size(75, 30);
        btn_Del.TabIndex = 1;
        btn_Del.Text = "删除";
        btn_Del.UseVisualStyleBackColor = true;
        btn_Del.Click += btn_Del_Click;
        // 
        // lv_Customer
        // 
        lv_Customer.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
        lv_Customer.FullRowSelect = true;
        lv_Customer.GridLines = true;
        lv_Customer.Location = new Point(15, 22);
        lv_Customer.MultiSelect = false;
        lv_Customer.Name = "lv_Customer";
        lv_Customer.Size = new Size(540, 205);
        lv_Customer.TabIndex = 0;
        lv_Customer.UseCompatibleStateImageBehavior = false;
        lv_Customer.View = View.Details;
        lv_Customer.SelectedIndexChanged += lv_Customer_SelectedIndexChanged;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "编号";
        columnHeader1.Width = 50;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "姓名";
        columnHeader2.Width = 70;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "单位";
        columnHeader3.Width = 100;
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "性别";
        columnHeader4.Width = 50;
        // 
        // columnHeader5
        // 
        columnHeader5.Text = "年龄";
        columnHeader5.Width = 50;
        // 
        // columnHeader6
        // 
        columnHeader6.Text = "联系电话";
        columnHeader6.Width = 100;
        // 
        // columnHeader7
        // 
        columnHeader7.Text = "联系地址";
        columnHeader7.Width = 110;
        // 
        // lbl_Status
        // 
        lbl_Status.AutoSize = true;
        lbl_Status.ForeColor = Color.Blue;
        lbl_Status.Location = new Point(640, 35);
        lbl_Status.Name = "lbl_Status";
        lbl_Status.Size = new Size(32, 17);
        lbl_Status.TabIndex = 2;
        lbl_Status.Text = "添加";
        // 
        // lbl_Note
        // 
        lbl_Note.AutoSize = true;
        lbl_Note.ForeColor = Color.Green;
        lbl_Note.Location = new Point(12, 450);
        lbl_Note.Name = "lbl_Note";
        lbl_Note.Size = new Size(68, 17);
        lbl_Note.TabIndex = 3;
        lbl_Note.Text = "操作结果：";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(590, 35);
        label7.Name = "label7";
        label7.Size = new Size(44, 17);
        label7.TabIndex = 4;
        label7.Text = "状态：";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(690, 480);
        Controls.Add(label7);
        Controls.Add(lbl_Note);
        Controls.Add(lbl_Status);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "Form1";
        Text = "客户信息管理";
        Load += Form1_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nudown_Age).EndInit();
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private GroupBox groupBox1;
    private Button btn_Cancel;
    private Button btn_Save;
    private TextBox txt_Address;
    private TextBox txt_Telephone;
    private NumericUpDown nudown_Age;
    private RadioButton rbtn_Sex2;
    private RadioButton rbtn_Sex1;
    private TextBox txt_Company;
    private TextBox txt_Name;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private GroupBox groupBox2;
    private Button btn_Del;
    private ListView lv_Customer;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private Label lbl_Status;
    private Label lbl_Note;
    private Label label7;
}
