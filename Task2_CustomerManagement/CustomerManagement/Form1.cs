using System.Data;

namespace CustomerManagement;

public partial class Form1 : Form
{
    // 全局变量，用于存储当前选中客户的编号
    private string customerid = "";

    // 使用内存列表模拟数据库存储（实际项目中应使用SQL Server数据库）
    private List<CustomerInfo> customerList = new List<CustomerInfo>();
    private int nextCustomerId = 1;

    public Form1()
    {
        InitializeComponent();
    }

    /// <summary>
    /// 客户信息实体类
    /// </summary>
    private class CustomerInfo
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; } = "";
        public string Company { get; set; } = "";
        public string Sex { get; set; } = "";
        public int Age { get; set; }
        public string Telephone { get; set; } = "";
        public string Address { get; set; } = "";
    }

    /// <summary>
    /// 窗体加载事件
    /// </summary>
    private void Form1_Load(object sender, EventArgs e)
    {
        // 加载客户信息
        DataBind_Customer();
    }

    /// <summary>
    /// 加载客户信息到ListView控件
    /// </summary>
    private void DataBind_Customer()
    {
        // 清空ListView控件
        lv_Customer.Items.Clear();

        // 遍历客户列表，将数据绑定到ListView控件
        foreach (var customer in customerList)
        {
            ListViewItem item = new ListViewItem(customer.CustomerID.ToString());
            item.SubItems.Add(customer.CustomerName);
            item.SubItems.Add(customer.Company);
            item.SubItems.Add(customer.Sex);
            item.SubItems.Add(customer.Age.ToString());
            item.SubItems.Add(customer.Telephone);
            item.SubItems.Add(customer.Address);
            lv_Customer.Items.Add(item);
        }
    }

    /// <summary>
    /// 保存按钮点击事件
    /// </summary>
    private void btn_Save_Click(object sender, EventArgs e)
    {
        // 1、验证数据
        if (string.IsNullOrWhiteSpace(txt_Name.Text))
        {
            MessageBox.Show("请输入客户姓名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt_Name.Focus();
            return;
        }

        // 2、获取输入数据
        string customerName = txt_Name.Text.Trim();
        string company = txt_Company.Text.Trim();
        string sex = rbtn_Sex1.Checked ? "男" : "女";
        int age = (int)nudown_Age.Value;
        string telephone = txt_Telephone.Text.Trim();
        string address = txt_Address.Text.Trim();

        // 3、判断是添加操作还是修改操作
        if (string.IsNullOrEmpty(customerid))
        {
            // 添加操作
            CustomerInfo newCustomer = new CustomerInfo
            {
                CustomerID = nextCustomerId++,
                CustomerName = customerName,
                Company = company,
                Sex = sex,
                Age = age,
                Telephone = telephone,
                Address = address
            };
            customerList.Add(newCustomer);
            lbl_Note.Text = "操作结果：客户信息添加成功！";
            lbl_Note.ForeColor = Color.Green;
        }
        else
        {
            // 修改操作
            if (!int.TryParse(customerid, out int id))
            {
                lbl_Note.Text = "操作结果：无效的客户编号！";
                lbl_Note.ForeColor = Color.Red;
                return;
            }
            var customer = customerList.FirstOrDefault(c => c.CustomerID == id);
            if (customer != null)
            {
                customer.CustomerName = customerName;
                customer.Company = company;
                customer.Sex = sex;
                customer.Age = age;
                customer.Telephone = telephone;
                customer.Address = address;
                lbl_Note.Text = "操作结果：客户信息修改成功！";
                lbl_Note.ForeColor = Color.Green;
            }
        }

        // 4、重新加载客户信息
        DataBind_Customer();

        // 5、清空各控件
        ClearTextBox();
    }

    /// <summary>
    /// 删除按钮点击事件
    /// </summary>
    private void btn_Del_Click(object sender, EventArgs e)
    {
        // 1、判断是否选中要删除的客户
        if (string.IsNullOrEmpty(customerid))
        {
            MessageBox.Show("请先选择要删除的客户！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 2、删除确认
        DialogResult result = MessageBox.Show("确定要删除该客户信息吗？", "删除确认", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            // 3、执行删除操作
            if (!int.TryParse(customerid, out int id))
            {
                lbl_Note.Text = "操作结果：无效的客户编号！";
                lbl_Note.ForeColor = Color.Red;
                return;
            }
            var customer = customerList.FirstOrDefault(c => c.CustomerID == id);
            if (customer != null)
            {
                customerList.Remove(customer);
                lbl_Note.Text = "操作结果：客户信息删除成功！";
                lbl_Note.ForeColor = Color.Green;
            }

            // 4、重新加载客户信息
            DataBind_Customer();

            // 5、清空各控件
            ClearTextBox();
        }
    }

    /// <summary>
    /// 取消按钮点击事件
    /// </summary>
    private void btn_Cancel_Click(object sender, EventArgs e)
    {
        // 清空各控件的值，还原各变量的状态
        ClearTextBox();
    }

    /// <summary>
    /// ListView选中项改变事件
    /// </summary>
    private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
    {
        // 判断是否有选中列表项
        if (lv_Customer.SelectedItems.Count > 0)
        {
            // 获取选中的列表项
            ListViewItem selectedItem = lv_Customer.SelectedItems[0];

            // 将选中客户的编号存储到全局变量
            customerid = selectedItem.SubItems[0].Text;

            // 将选中客户的信息显示到各文本框中
            txt_Name.Text = selectedItem.SubItems[1].Text;
            txt_Company.Text = selectedItem.SubItems[2].Text;
            
            // 设置性别单选按钮
            if (selectedItem.SubItems[3].Text == "男")
            {
                rbtn_Sex1.Checked = true;
            }
            else
            {
                rbtn_Sex2.Checked = true;
            }

            // 设置年龄
            if (int.TryParse(selectedItem.SubItems[4].Text, out int age))
            {
                nudown_Age.Value = age;
            }

            txt_Telephone.Text = selectedItem.SubItems[5].Text;
            txt_Address.Text = selectedItem.SubItems[6].Text;

            // 将状态改为"修改"
            lbl_Status.Text = "修改";
            lbl_Status.ForeColor = Color.Red;
        }
    }

    /// <summary>
    /// 清空各控件的值
    /// </summary>
    private void ClearTextBox()
    {
        txt_Name.Text = "";
        txt_Company.Text = "";
        rbtn_Sex1.Checked = true;
        nudown_Age.Value = 25;
        txt_Telephone.Text = "";
        txt_Address.Text = "";
        customerid = "";
        lbl_Status.Text = "添加";
        lbl_Status.ForeColor = Color.Blue;
    }
}
