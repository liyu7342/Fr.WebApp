

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Sys_Company_Status]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Sys_Company] DROP CONSTRAINT [DF_Sys_Company_Status]
END

GO



/****** Object:  Table [dbo].[Sys_Company]    Script Date: 07/22/2016 18:08:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sys_Company]') AND type in (N'U'))
DROP TABLE [dbo].[Sys_Company]
GO

USE [Fr_db]
GO

/****** Object:  Table [dbo].[Sys_Company]    Script Date: 07/22/2016 18:08:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sys_Company](
	[CompanyId] [nvarchar](50) NOT NULL,
	[CompanyName] [nvarchar](200) NULL,
	[parentId] [nvarchar](50) NULL,
	[Status] [smallint] NOT NULL,
	[CreateTime] [datetime] NULL,
	[CreateUserId] [nvarchar](50) NULL,
	[CreateUserName] [nvarchar](200) NULL,
	[ModifyTime] [datetime] NULL,
	[ModifyUserId] [nvarchar](50) NULL,
	[ModifyUserName] [nvarchar](200) NULL,
 CONSTRAINT [PK_SYS_COMPANY] PRIMARY KEY NONCLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公司Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Company', @level2type=N'COLUMN',@level2name=N'CompanyId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公司名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Company', @level2type=N'COLUMN',@level2name=N'CompanyName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'父公司Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Company', @level2type=N'COLUMN',@level2name=N'parentId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Company', @level2type=N'COLUMN',@level2name=N'Status'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Company', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Company', @level2type=N'COLUMN',@level2name=N'CreateUserId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Company', @level2type=N'COLUMN',@level2name=N'CreateUserName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Company', @level2type=N'COLUMN',@level2name=N'ModifyTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Company', @level2type=N'COLUMN',@level2name=N'ModifyUserId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Company', @level2type=N'COLUMN',@level2name=N'ModifyUserName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'公司' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Company'
GO

ALTER TABLE [dbo].[Sys_Company] ADD  CONSTRAINT [DF_Sys_Company_Status]  DEFAULT ((0)) FOR [Status]
GO


