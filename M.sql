USE [MartSystem]
GO
/****** Object:  Table [dbo].[Branch]    Script Date: 6/14/2020 11:47:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branch](
	[Branch_ID] [int] NOT NULL,
	[Branch_Address] [varchar](140) NULL,
	[Contact_Number] [varchar](12) NULL,
	[City] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[Branch_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Department_No] [int] NOT NULL,
	[Department_Name] [varchar](40) NULL,
	[No_Of_Employees] [int] NULL,
	[Manager] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[Department_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Employee_ID] [int] NOT NULL,
	[First_Name] [varchar](40) NULL,
	[Last_Name] [varchar](40) NULL,
	[Contact_Number] [varchar](19) NULL,
	[Address] [varchar](140) NULL,
	[Hire_Date] [datetime] NULL,
	[Account_Number] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees_Details]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees_Details](
	[Employee_ID] [int] NULL,
	[Job_ID] [int] NULL,
	[Branch_ID] [int] NULL,
	[Department_No] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jobs](
	[Job_ID] [int] NOT NULL,
	[Position] [varchar](40) NULL,
	[Salary] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Job_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LogIn_Details]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LogIn_Details](
	[UserName] [varchar](40) NOT NULL,
	[Employee_ID] [int] NULL,
	[Pasword] [varchar](40) NULL,
	[Email] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Categories]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Categories](
	[Category_ID] [int] NOT NULL,
	[Category_Name] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[Category_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Product_ID] [int] NOT NULL,
	[Product_Name] [varchar](40) NULL,
	[Supplier_ID] [int] NULL,
	[Category_ID] [int] NULL,
	[Product_desc] [varchar](40) NULL,
	[Unit_Price] [int] NULL,
	[Expire_Date] [varchar](40) NULL,
	[Product_Total_Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SaleID] [int] NOT NULL,
	[Customer_Name] [varchar](40) NULL,
	[Customer_Contact] [varchar](40) NULL,
	[Datee] [date] NULL,
	[Timee] [time](7) NULL,
	[Form_Of_Payment] [varchar](40) NULL,
	[Total] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SaleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales_Information]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales_Information](
	[Sale_ID] [int] NOT NULL,
	[Product_ID] [int] NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Sale_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Supplier_ID] [int] NOT NULL,
	[Supplier_Name] [varchar](40) NULL,
	[Contact] [varchar](40) NULL,
PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employees_Details]  WITH CHECK ADD FOREIGN KEY([Branch_ID])
REFERENCES [dbo].[Branch] ([Branch_ID])
GO
ALTER TABLE [dbo].[Employees_Details]  WITH CHECK ADD FOREIGN KEY([Department_No])
REFERENCES [dbo].[Department] ([Department_No])
GO
ALTER TABLE [dbo].[Employees_Details]  WITH CHECK ADD FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employees] ([Employee_ID])
GO
ALTER TABLE [dbo].[Employees_Details]  WITH CHECK ADD FOREIGN KEY([Job_ID])
REFERENCES [dbo].[Jobs] ([Job_ID])
GO
ALTER TABLE [dbo].[LogIn_Details]  WITH CHECK ADD FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employees] ([Employee_ID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([Category_ID])
REFERENCES [dbo].[Product_Categories] ([Category_ID])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[Supplier] ([Supplier_ID])
GO
ALTER TABLE [dbo].[Sales_Information]  WITH CHECK ADD FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Products] ([Product_ID])
GO
/****** Object:  StoredProcedure [dbo].[CategoryList]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CategoryList]
AS
SELECT * FROM Product_Categories
GO
/****** Object:  StoredProcedure [dbo].[ProductsDisplay]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductsDisplay]
AS
SELECT * FROM Products
GO
/****** Object:  StoredProcedure [dbo].[RemoveSupplier]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemoveSupplier] @id INT
AS
DELETE FROM Supplier WHERE Supplier_ID = @id
DELETE FROM Products WHERE Supplier_ID = @id
GO
/****** Object:  StoredProcedure [dbo].[SuppliersList]    Script Date: 6/14/2020 11:48:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SuppliersList]
AS
SELECT * FROM Supplier
GO
