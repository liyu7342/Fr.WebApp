
/****** Object:  Table [dbo].[Sys_MenuPermission]    Script Date: 07/22/2016 18:10:18 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sys_MenuPermission]') AND type in (N'U'))
DROP TABLE [dbo].[Sys_MenuPermission]
GO


/****** Object:  Table [dbo].[Sys_MenuPermission]    Script Date: 07/22/2016 18:10:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sys_MenuPermission](
	[MenuPermissionId] [nvarchar](50) NOT NULL,
	[MenuId] [nvarchar](50) NULL,
	[RoleId] [nvarchar](50) NULL,
	[SortCode] [int] NULL,
	[Status] [tinyint] NULL,
	[Remark] [nvarchar](200) NULL,
	[CreateTime] [datetime] NULL,
	[CreateUserId] [nvarchar](50) NULL,
	[CreateUserName] [nvarchar](200) NULL,
	[ModifyTime] [datetime] NULL,
	[ModifyUserId] [nvarchar](50) NULL,
	[ModifyUserName] [nvarchar](200) NULL,
 CONSTRAINT [PK_Sys_MenuPermission] PRIMARY KEY CLUSTERED 
(
	[MenuPermissionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'MenuPermissionId' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission', @level2type=N'COLUMN',@level2name=N'MenuPermissionId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission', @level2type=N'COLUMN',@level2name=N'MenuId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission', @level2type=N'COLUMN',@level2name=N'RoleId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission', @level2type=N'COLUMN',@level2name=N'SortCode'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission', @level2type=N'COLUMN',@level2name=N'Status'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission', @level2type=N'COLUMN',@level2name=N'Remark'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission', @level2type=N'COLUMN',@level2name=N'CreateUserId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission', @level2type=N'COLUMN',@level2name=N'CreateUserName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission', @level2type=N'COLUMN',@level2name=N'ModifyTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission', @level2type=N'COLUMN',@level2name=N'ModifyUserId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission', @level2type=N'COLUMN',@level2name=N'ModifyUserName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sys_MenuPermission' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_MenuPermission'
GO


