CREATE TABLE [dbo].[RuleType](
	[RuleTypeID] [int] IDENTITY(1,1) NOT NULL,
	[RuleTypeName] [varchar](50) NOT NULL,
	[RuleTypeDescription] [varchar](200) NULL,
	[BeginDate] [date] NOT NULL,
	[BeginDateTime] [datetimeoffset](7) NOT NULL,
	[EndDate] [date] NULL,
	[EndDateTime] [datetimeoffset](7) NULL,
	[CreatedBy] [varchar](128) NOT NULL,
	[CreatedDateTime] [datetimeoffset](7) NOT NULL,
	[RuleTypeNameSpanish] [varchar](50) NULL,
	[RuleTypeDescriptionSpanish] [varchar](200) NULL,
 CONSTRAINT [PK_RuleType] PRIMARY KEY CLUSTERED 
(
	[RuleTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RuleType] ADD  CONSTRAINT [DF_RuleType_BeginDate]  DEFAULT (getdate()) FOR [BeginDate]
GO
ALTER TABLE [dbo].[RuleType] ADD  CONSTRAINT [DF_RuleType_BeginDateTime]  DEFAULT (sysdatetimeoffset()) FOR [BeginDateTime]
GO
ALTER TABLE [dbo].[RuleType] ADD  CONSTRAINT [DEF_RuleTypeCreatedBy]  DEFAULT (host_name()) FOR [CreatedBy]
GO
ALTER TABLE [dbo].[RuleType] ADD  CONSTRAINT [DF_RuleType_CreatedDateTime]  DEFAULT (sysdatetimeoffset()) FOR [CreatedDateTime]
GO
EXEC sys.sp_addextendedproperty @name=N'English_Column_Description', @value=N'This is the primary key for the RuleType catalog.  RuleTypes generally categoriz rules in groupings' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleType', @level2type=N'COLUMN',@level2name=N'RuleTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'English_Column_Description', @value=N'This is the value of the RuleType catalog. ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleType', @level2type=N'COLUMN',@level2name=N'RuleTypeName'
GO
EXEC sys.sp_addextendedproperty @name=N'English_Column_Description', @value=N'This is the description of the RuleType catalog' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleType', @level2type=N'COLUMN',@level2name=N'RuleTypeDescription'
GO
EXEC sys.sp_addextendedproperty @name=N'English_Column_Description', @value=N'Data records in the Noetic Master Model are valid for a specific time period.  The start date is the first day for which this record is valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleType', @level2type=N'COLUMN',@level2name=N'BeginDate'
GO
EXEC sys.sp_addextendedproperty @name=N'English_Column_Description', @value=N'Data records in the Noetic Master Model are valid for a specific time period.  The start date time defines the moment, the time of day for when the record becomes valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleType', @level2type=N'COLUMN',@level2name=N'BeginDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'English_Column_Description', @value=N'Data records in the Noetic Master Model are  valid for a specific time period.  The end date is the last day for which this record is valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleType', @level2type=N'COLUMN',@level2name=N'EndDate'
GO
EXEC sys.sp_addextendedproperty @name=N'English_Column_Description', @value=N'Data records in the Noetic Master Model are valid for a specific time period.  The end date time defines the moment, the time of day for when the record is no longer valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleType', @level2type=N'COLUMN',@level2name=N'EndDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'English_Column_Description', @value=N'Data records in the Noetic Master Model are  valid for a specific time period.  The end date is the last day for which this record is valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleType', @level2type=N'COLUMN',@level2name=N'CreatedBy'
GO
EXEC sys.sp_addextendedproperty @name=N'English_Column_Description', @value=N'Each data record in the Noetic Master Model bears a Creation Stamp indicating when and by whom it was entered into storage.  The Created Date Time value indicates the date and time the record was created.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleType', @level2type=N'COLUMN',@level2name=N'CreatedDateTime'