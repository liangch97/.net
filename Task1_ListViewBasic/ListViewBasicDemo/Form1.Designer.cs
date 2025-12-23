namespace ListViewBasicDemo;

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
        listView1 = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        columnHeader4 = new ColumnHeader();
        btn_AddItem = new Button();
        btn_RemoveItem = new Button();
        btn_ClearItem = new Button();
        label1 = new Label();
        txt_SelectedName = new TextBox();
        SuspendLayout();
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
        listView1.FullRowSelect = true;
        listView1.GridLines = true;
        listView1.Location = new Point(12, 12);
        listView1.MultiSelect = false;
        listView1.Name = "listView1";
        listView1.Size = new Size(560, 300);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.Details;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "编号";
        columnHeader1.Width = 80;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "姓名";
        columnHeader2.Width = 120;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "性别";
        columnHeader3.Width = 80;
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "地址";
        columnHeader4.Width = 260;
        // 
        // btn_AddItem
        // 
        btn_AddItem.Location = new Point(590, 12);
        btn_AddItem.Name = "btn_AddItem";
        btn_AddItem.Size = new Size(100, 35);
        btn_AddItem.TabIndex = 1;
        btn_AddItem.Text = "添加项";
        btn_AddItem.UseVisualStyleBackColor = true;
        btn_AddItem.Click += btn_AddItem_Click;
        // 
        // btn_RemoveItem
        // 
        btn_RemoveItem.Location = new Point(590, 60);
        btn_RemoveItem.Name = "btn_RemoveItem";
        btn_RemoveItem.Size = new Size(100, 35);
        btn_RemoveItem.TabIndex = 2;
        btn_RemoveItem.Text = "移除项";
        btn_RemoveItem.UseVisualStyleBackColor = true;
        btn_RemoveItem.Click += btn_RemoveItem_Click;
        // 
        // btn_ClearItem
        // 
        btn_ClearItem.Location = new Point(590, 108);
        btn_ClearItem.Name = "btn_ClearItem";
        btn_ClearItem.Size = new Size(100, 35);
        btn_ClearItem.TabIndex = 3;
        btn_ClearItem.Text = "清空项";
        btn_ClearItem.UseVisualStyleBackColor = true;
        btn_ClearItem.Click += btn_ClearItem_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 330);
        label1.Name = "label1";
        label1.Size = new Size(80, 17);
        label1.TabIndex = 4;
        label1.Text = "当前选中项：";
        // 
        // txt_SelectedName
        // 
        txt_SelectedName.Location = new Point(98, 327);
        txt_SelectedName.Name = "txt_SelectedName";
        txt_SelectedName.ReadOnly = true;
        txt_SelectedName.Size = new Size(200, 23);
        txt_SelectedName.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(710, 370);
        Controls.Add(txt_SelectedName);
        Controls.Add(label1);
        Controls.Add(btn_ClearItem);
        Controls.Add(btn_RemoveItem);
        Controls.Add(btn_AddItem);
        Controls.Add(listView1);
        Name = "Form1";
        Text = "ListView控件基本操作";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListView listView1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private Button btn_AddItem;
    private Button btn_RemoveItem;
    private Button btn_ClearItem;
    private Label label1;
    private TextBox txt_SelectedName;
}
