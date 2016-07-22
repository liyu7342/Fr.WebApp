

/****** Object:  Table [dbo].[Sys_UserRole_Power]    Script Date: 07/22/2016 18:12:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sys_UserRole_Power]') AND type in (N'U'))
DROP TABLE [dbo].[Sys_UserRole_Power]
GO



/****** Object:  Table [dbo].[Sys_UserRole_Power]    Script Date: 07/22/2016 18:12:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Sys_UserRole_Power](
	[UserRolePowerId] [nvarchar](50) NOT NULL,
	[UserRoleId] [nvarchar](50) NULL,
	[PowerId] [nvarchar](50) NULL,
	[CreateTime] [datetime] NULL,
	[CreateUserId] [nvarchar](50) NULL,
	[CreateUserName] [nvarchar](200) NULL,
	[ModifyTime] [datetime] NULL,
	[ModifyUserId] [nvarchar](50) NULL,
	[ModifyUserName] [nvarchar](200) NULL,
 CONSTRAINT [PK_SYS_USERROLE_POWER] PRIMARY KEY NONCLUSTERED 
(
	[UserRolePowerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户角色功能权限Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole_Power', @level2type=N'COLUMN',@level2name=N'UserRolePowerId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户角色Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole_Power', @level2type=N'COLUMN',@level2name=N'UserRoleId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'功能权限Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole_Power', @level2type=N'COLUMN',@level2name=N'PowerId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole_Power', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole_Power', @level2type=N'COLUMN',@level2name=N'CreateUserId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole_Power', @level2type=N'COLUMN',@level2name=N'CreateUserName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole_Power', @level2type=N'COLUMN',@level2name=N'ModifyTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole_Power', @level2type=N'COLUMN',@level2name=N'ModifyUserId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole_Power', @level2type=N'COLUMN',@level2name=N'ModifyUserName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户角色功能权限表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole_Power'
GO


