CREATE TABLE [dbo].[Rule](
	[RuleID] [int] IDENTITY(1,1) NOT NULL,
	[RuleName] [varchar](100) NULL,
	[RuleDescription] [varchar](1000) NULL,
	[RuleTypeID] [int] NULL,
	[BeginDate] [date] NOT NULL,
	[BeginDateTime] [datetimeoffset](7) NOT NULL,
	[EndDate] [date] NULL,
	[EndDateTime] [datetimeoffset](7) NULL,
	[CreatedDate] [date] NOT NULL,
	[CreatedDateTime] [datetimeoffset](7) NOT NULL,
	[CreatedBy] [varchar](128) NOT NULL,
 CONSTRAINT [PK_Rule] PRIMARY KEY CLUSTERED 
(
	[RuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Rule]  WITH CHECK ADD  CONSTRAINT [FK_Rule_RuleTypeID_RuleType_RuleTypeID] FOREIGN KEY([RuleTypeID])
REFERENCES [dbo].[RuleType] ([RuleTypeID])
GO

ALTER TABLE [dbo].[Rule] CHECK CONSTRAINT [FK_Rule_RuleTypeID_RuleType_RuleTypeID]
GO
ALTER TABLE [dbo].[Rule] ADD  CONSTRAINT [DF_Rule_BeginDate]  DEFAULT (getdate()) FOR [BeginDate]
GO
ALTER TABLE [dbo].[Rule] ADD  CONSTRAINT [DF_Rule_BeginDateTime]  DEFAULT (sysdatetimeoffset()) FOR [BeginDateTime]
GO
ALTER TABLE [dbo].[Rule] ADD  CONSTRAINT [DF_Rule_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Rule] ADD  CONSTRAINT [DF_Rule_CreatedDateTime]  DEFAULT (sysdatetimeoffset()) FOR [CreatedDateTime]
GO
ALTER TABLE [dbo].[Rule] ADD  CONSTRAINT [DF_Rule_CreatedBy]  DEFAULT (host_name()) FOR [CreatedBy]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the authorized product rule' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Rule', @level2type=N'COLUMN',@level2name=N'RuleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Name of the authorized product rule' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Rule', @level2type=N'COLUMN',@level2name=N'RuleName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Description of the rule' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Rule', @level2type=N'COLUMN',@level2name=N'RuleDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the type of rule' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Rule', @level2type=N'COLUMN',@level2name=N'RuleTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The start date is the first day for which this record is valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Rule', @level2type=N'COLUMN',@level2name=N'BeginDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The start date time defines the moment, the time of day for when the record becomes valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Rule', @level2type=N'COLUMN',@level2name=N'BeginDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The end date is the last day for which this record is valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Rule', @level2type=N'COLUMN',@level2name=N'EndDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The end date time defines the moment, the time of day for when the record is no longer valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Rule', @level2type=N'COLUMN',@level2name=N'EndDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The created date time value indicates the date and time the record was created.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Rule', @level2type=N'COLUMN',@level2name=N'CreatedDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The created by defines the user that create the row.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Rule', @level2type=N'COLUMN',@level2name=N'CreatedBy'