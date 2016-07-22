

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Sys_LogDetail_CreateDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Sys_LogDetail] DROP CONSTRAINT [DF_Sys_LogDetail_CreateDate]
END

GO


/****** Object:  Table [dbo].[Sys_LogDetail]    Script Date: 07/22/2016 18:09:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sys_LogDetail]') AND type in (N'U'))
DROP TABLE [dbo].[Sys_LogDetail]
GO



/****** Object:  Table [dbo].[Sys_LogDetail]    Script Date: 07/22/2016 18:09:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sys_LogDetail](
	[SysLogDetailId] [nvarchar](50) NOT NULL,
	[SysLogId] [nvarchar](50) NULL,
	[PropertyName] [nvarchar](50) NULL,
	[PropertyField] [nvarchar](50) NULL,
	[NewValue] [varchar](2000) NULL,
	[OldValue] [nvarchar](50) NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Sys_LogDetail] PRIMARY KEY CLUSTERED 
(
	[SysLogDetailId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系统日志明细主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_LogDetail', @level2type=N'COLUMN',@level2name=N'SysLogDetailId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日志主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_LogDetail', @level2type=N'COLUMN',@level2name=N'SysLogId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'属性名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_LogDetail', @level2type=N'COLUMN',@level2name=N'PropertyName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'属性字段' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_LogDetail', @level2type=N'COLUMN',@level2name=N'PropertyField'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'属性新值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_LogDetail', @level2type=N'COLUMN',@level2name=N'NewValue'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'属性旧值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_LogDetail', @level2type=N'COLUMN',@level2name=N'OldValue'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_LogDetail', @level2type=N'COLUMN',@level2name=N'CreateDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sys_LogDetail' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_LogDetail'
GO

ALTER TABLE [dbo].[Sys_LogDetail] ADD  CONSTRAINT [DF_Sys_LogDetail_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO


