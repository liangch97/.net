# .NET体系结构与应用开发实验 - 实验11

## 实验名称
Windows 高级控件（1）- ListView 列表视图控件

## 实验目的
学习掌握 ListView 列表视图控件的使用

## 项目结构

### 任务1：ListView控件基本操作 (Task1_ListViewBasic)
位置：`Task1_ListViewBasic/ListViewBasicDemo/`

该项目演示了 ListView 控件的基本操作：
- 设置 ListView 控件外观（Details 视图、网格线、全行选择等）
- 添加列表项（ListViewItem）
- 移除选中的列表项
- 清空所有列表项
- 获取选中项改变事件（SelectedIndexChanged）

### 任务2：ListView实现客户信息管理 (Task2_CustomerManagement)
位置：`Task2_CustomerManagement/CustomerManagement/`

该项目使用 ListView 控件实现客户信息管理功能：
- 添加客户信息
- 加载并显示客户信息列表
- 修改客户信息
- 删除客户信息
- 取消操作

数据库脚本：`Task2_CustomerManagement/DatabaseScript.sql`

## 运行要求
- .NET 8.0 SDK 或更高版本
- Windows 操作系统（用于运行 Windows Forms 应用程序）
- Visual Studio 2022 或更高版本（推荐）

## 如何运行

### 使用命令行
```bash
# 运行任务1
cd Task1_ListViewBasic/ListViewBasicDemo
dotnet run

# 运行任务2
cd Task2_CustomerManagement/CustomerManagement
dotnet run
```

### 使用 Visual Studio
1. 打开对应项目的 `.csproj` 文件
2. 按 F5 运行项目

## 注意事项
- 任务2中的客户信息管理使用内存列表模拟数据库操作
- 如需使用真实的 SQL Server 数据库，请：
  1. 执行 `DatabaseScript.sql` 创建数据库和表
  2. 修改 `Form1.cs` 中的代码，使用 `System.Data.SqlClient` 连接数据库

## 实验内容说明
本实验按照《.NET体系结构与应用开发实验》实验指导任务书完成，包含：
1. ListView 控件的创建和属性设置
2. 列标题（ColumnHeader）的配置
3. 列表项的增删改查操作
4. 事件处理（按钮点击、选中项改变等）
