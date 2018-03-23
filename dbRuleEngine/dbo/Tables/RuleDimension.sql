CREATE TABLE [dbo].[RuleDimension](
	[RuleDimensionID] [int] IDENTITY(1,1) NOT NULL,
	[RuleID] [int] NULL,
	[RuleDimensionTypeID] [int] NULL,
	[RuleParentDimensionID] [int] NULL,
	[RuleFilterTypeID] [int] NULL,
	[BeginDate] [date] NOT NULL,
	[BeginDateTime] [datetimeoffset](7) NOT NULL,
	[EndDate] [date] NULL,
	[EndDateTime] [datetimeoffset](7) NULL,
	[CreatedDate] [date] NOT NULL,
	[CreatedDateTime] [datetimeoffset](7) NOT NULL,
	[CreatedBy] [varchar](128) NOT NULL,
 CONSTRAINT [PK_RuleDimension] PRIMARY KEY CLUSTERED 
(
	[RuleDimensionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RuleDimension]  WITH CHECK ADD  CONSTRAINT [FK_RuleDimension_RuleDimensionTypeID_RuleDimensionType] FOREIGN KEY([RuleDimensionTypeID])
REFERENCES [dbo].[RuleDimensionType] ([RuleDimensionTypeID])
GO

ALTER TABLE [dbo].[RuleDimension] CHECK CONSTRAINT [FK_RuleDimension_RuleDimensionTypeID_RuleDimensionType]
GO
ALTER TABLE [dbo].[RuleDimension]  WITH CHECK ADD  CONSTRAINT [FK_RuleDimension_RuleFilterTypeID_RuleFilterType] FOREIGN KEY([RuleFilterTypeID])
REFERENCES [dbo].[RuleFilterType] ([RuleFilterTypeID])
GO

ALTER TABLE [dbo].[RuleDimension] CHECK CONSTRAINT [FK_RuleDimension_RuleFilterTypeID_RuleFilterType]
GO
ALTER TABLE [dbo].[RuleDimension]  WITH CHECK ADD  CONSTRAINT [FK_RuleDimension_RuleID_Rule] FOREIGN KEY([RuleID])
REFERENCES [dbo].[Rule] ([RuleID])
GO

ALTER TABLE [dbo].[RuleDimension] CHECK CONSTRAINT [FK_RuleDimension_RuleID_Rule]
GO
ALTER TABLE [dbo].[RuleDimension]  WITH CHECK ADD  CONSTRAINT [FK_RuleDimension_RuleParentDimensionID_RuleDimension_RuleDim] FOREIGN KEY([RuleParentDimensionID])
REFERENCES [dbo].[RuleDimension] ([RuleDimensionID])
GO

ALTER TABLE [dbo].[RuleDimension] CHECK CONSTRAINT [FK_RuleDimension_RuleParentDimensionID_RuleDimension_RuleDim]
GO
ALTER TABLE [dbo].[RuleDimension] ADD  CONSTRAINT [DF_RuleDimension_BeginDate]  DEFAULT (getdate()) FOR [BeginDate]
GO
ALTER TABLE [dbo].[RuleDimension] ADD  CONSTRAINT [DF_RuleDimension_BeginDateTime]  DEFAULT (sysdatetimeoffset()) FOR [BeginDateTime]
GO
ALTER TABLE [dbo].[RuleDimension] ADD  CONSTRAINT [DF_RuleDimension_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[RuleDimension] ADD  CONSTRAINT [DF_RuleDimension_CreatedDateTime]  DEFAULT (sysdatetimeoffset()) FOR [CreatedDateTime]
GO
ALTER TABLE [dbo].[RuleDimension] ADD  CONSTRAINT [DF_RuleDimension_CreatedBy]  DEFAULT (host_name()) FOR [CreatedBy]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the relationship betwheen dimension and rule' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleDimension', @level2type=N'COLUMN',@level2name=N'RuleDimensionID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the authorized product rule' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleDimension', @level2type=N'COLUMN',@level2name=N'RuleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the authorized product dimension type' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleDimension', @level2type=N'COLUMN',@level2name=N'RuleDimensionTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the parent row' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleDimension', @level2type=N'COLUMN',@level2name=N'RuleParentDimensionID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the filter type' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleDimension', @level2type=N'COLUMN',@level2name=N'RuleFilterTypeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The start date is the first day for which this record is valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleDimension', @level2type=N'COLUMN',@level2name=N'BeginDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The start date time defines the moment, the time of day for when the record becomes valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleDimension', @level2type=N'COLUMN',@level2name=N'BeginDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The end date is the last day for which this record is valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleDimension', @level2type=N'COLUMN',@level2name=N'EndDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The end date time defines the moment, the time of day for when the record is no longer valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleDimension', @level2type=N'COLUMN',@level2name=N'EndDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The created date time value indicates the date and time the record was created.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleDimension', @level2type=N'COLUMN',@level2name=N'CreatedDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The created by defines the user that create the row.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleDimension', @level2type=N'COLUMN',@level2name=N'CreatedBy'
