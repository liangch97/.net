namespace ListViewBasicDemo;

public partial class Form1 : Form
{
    private int itemCount = 0;

    public Form1()
    {
        InitializeComponent();
    }

    /// <summary>
    /// 添加项按钮点击事件
    /// </summary>
    private void btn_AddItem_Click(object sender, EventArgs e)
    {
        itemCount++;
        // 创建一个列表项，并为第一列赋值
        ListViewItem item = new ListViewItem(itemCount.ToString());
        // 为该列表项的子项信息（即第2列以及其他列）赋值
        item.SubItems.Add("张三" + itemCount);
        item.SubItems.Add(itemCount % 2 == 0 ? "男" : "女");
        item.SubItems.Add("广东省广州市海珠区新港西路" + itemCount + "号");
        // 将该列表项添加到ListView控件中
        listView1.Items.Add(item);
    }

    /// <summary>
    /// 移除项按钮点击事件
    /// </summary>
    private void btn_RemoveItem_Click(object sender, EventArgs e)
    {
        // 首先判断是否有选中要移除的项
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("请先选择要移除的项！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        
        // 遍历选中的每一个列表项，并将每个选中项从ListView控件中移除
        foreach (ListViewItem item in listView1.SelectedItems)
        {
            listView1.Items.Remove(item);
        }
    }

    /// <summary>
    /// 清空项按钮点击事件
    /// </summary>
    private void btn_ClearItem_Click(object sender, EventArgs e)
    {
        // 清空ListView控件中的所有列表项
        listView1.Items.Clear();
        itemCount = 0;
    }

    /// <summary>
    /// ListView选中项改变事件
    /// </summary>
    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        // 首先判断是否有选中列表项
        if (listView1.SelectedItems.Count > 0)
        {
            // 获取选中的第一个列表项
            ListViewItem selectedItem = listView1.SelectedItems[0];
            // 将选中行的第二列的值（即"姓名"列的值）赋值给文本框
            txt_SelectedName.Text = selectedItem.SubItems[1].Text;
        }
        else
        {
            txt_SelectedName.Text = "";
        }
    }
}
