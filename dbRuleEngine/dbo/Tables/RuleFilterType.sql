CREATE TABLE [dbo].[RuleFilterType](
	[RuleFilterTypeID] [int] IDENTITY(1,1) NOT NULL,
	[RuleFilterTypeDescription] [varchar](150) NULL,
	[BeginDate] [date] NOT NULL,
	[BeginDateTime] [datetimeoffset](7) NOT NULL,
	[EndDate] [date] NULL,
	[EndDateTime] [datetimeoffset](7) NULL,
	[CreatedDate] [date] NOT NULL,
	[CreatedDateTime] [datetimeoffset](7) NOT NULL,
	[CreatedBy] [varchar](128) NOT NULL,
 CONSTRAINT [PK_RuleFilterType] PRIMARY KEY CLUSTERED 
(
	[RuleFilterTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RuleFilterType] ADD  CONSTRAINT [DF_RuleFilterType_BeginDate]  DEFAULT (getdate()) FOR [BeginDate]
GO
ALTER TABLE [dbo].[RuleFilterType] ADD  CONSTRAINT [DF_RuleFilterType_BeginDateTime]  DEFAULT (sysdatetimeoffset()) FOR [BeginDateTime]
GO
ALTER TABLE [dbo].[RuleFilterType] ADD  CONSTRAINT [DF_RuleFilterType_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[RuleFilterType] ADD  CONSTRAINT [DF_RuleFilterType_CreatedDateTime]  DEFAULT (sysdatetimeoffset()) FOR [CreatedDateTime]
GO
ALTER TABLE [dbo].[RuleFilterType] ADD  CONSTRAINT [DF_RuleFilterType_CreatedBy]  DEFAULT (host_name()) FOR [CreatedBy]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the filter type' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleFilterType', @level2type=N'COLUMN',@level2name=N'RuleFilterTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Description of the filter type' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleFilterType', @level2type=N'COLUMN',@level2name=N'RuleFilterTypeDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The start date is the first day for which this record is valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleFilterType', @level2type=N'COLUMN',@level2name=N'BeginDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The start date time defines the moment, the time of day for when the record becomes valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleFilterType', @level2type=N'COLUMN',@level2name=N'BeginDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The end date is the last day for which this record is valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleFilterType', @level2type=N'COLUMN',@level2name=N'EndDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The end date time defines the moment, the time of day for when the record is no longer valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleFilterType', @level2type=N'COLUMN',@level2name=N'EndDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The created date time value indicates the date and time the record was created.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleFilterType', @level2type=N'COLUMN',@level2name=N'CreatedDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The created by defines the user that create the row.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleFilterType', @level2type=N'COLUMN',@level2name=N'CreatedBy'
