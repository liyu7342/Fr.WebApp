
/****** Object:  Table [dbo].[Sys_Power]    Script Date: 07/22/2016 18:10:38 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sys_Power]') AND type in (N'U'))
DROP TABLE [dbo].[Sys_Power]
GO



/****** Object:  Table [dbo].[Sys_Power]    Script Date: 07/22/2016 18:10:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sys_Power](
	[PowerId] [nvarchar](50) NOT NULL,
	[PowerCode] [nvarchar](200) NULL,
	[PowerName] [nvarchar](200) NULL,
	[CreateTime] [datetime] NULL,
	[CreateUserId] [nvarchar](50) NULL,
	[CreateUserName] [nvarchar](200) NULL,
	[ModifyTime] [datetime] NULL,
	[ModifyUserId] [nvarchar](50) NULL,
	[ModifyUserName] [nvarchar](200) NULL,
	[CreateTime2] [datetime] NULL,
	[CreateUserId2] [nvarchar](50) NULL,
	[CreateUserName2] [nvarchar](200) NULL,
	[ModifyTime2] [datetime] NULL,
	[ModifyUserId2] [nvarchar](50) NULL,
	[ModifyUserName2] [nvarchar](200) NULL,
 CONSTRAINT [PK_SYS_POWER] PRIMARY KEY NONCLUSTERED 
(
	[PowerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'功能Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'PowerId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'功能编码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'PowerCode'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'功能名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'PowerName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'CreateUserId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'CreateUserName' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'CreateUserName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'ModifyTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'ModifyUserId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ModifyUserName' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'ModifyUserName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'CreateTime2'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'CreateUserId2'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'CreateUserName2'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'ModifyTime2'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'ModifyUserId2'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power', @level2type=N'COLUMN',@level2name=N'ModifyUserName2'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'功能权限表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Power'
GO


