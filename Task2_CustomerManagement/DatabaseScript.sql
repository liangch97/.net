-- 创建数据库 DB_CASE0705
CREATE DATABASE DB_CASE0705;
GO

USE DB_CASE0705;
GO

-- 创建客户信息表 Customer_Info
CREATE TABLE Customer_Info
(
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,    -- 客户编号，主键、自增
    CustomerName VARCHAR(20) NOT NULL,            -- 客户姓名
    Company VARCHAR(50),                          -- 单位
    Sex VARCHAR(2),                               -- 性别
    Age INT,                                      -- 年龄
    Telephone VARCHAR(20),                        -- 联系电话
    Address VARCHAR(200)                          -- 联系地址
);
GO

-- 插入测试数据
INSERT INTO Customer_Info (CustomerName, Company, Sex, Age, Telephone, Address)
VALUES ('张三', '中山大学', '男', 25, '13800138000', '广东省广州市海珠区新港西路135号');

INSERT INTO Customer_Info (CustomerName, Company, Sex, Age, Telephone, Address)
VALUES ('李四', '华南理工大学', '女', 28, '13900139000', '广东省广州市天河区五山路381号');

INSERT INTO Customer_Info (CustomerName, Company, Sex, Age, Telephone, Address)
VALUES ('王五', '暨南大学', '男', 30, '13700137000', '广东省广州市天河区黄埔大道西601号');
GO
