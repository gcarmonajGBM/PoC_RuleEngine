CREATE TABLE [dbo].[RuleRelationship](
	[RuleRelationshipID] [int] IDENTITY(1,1) NOT NULL,
	[ID] [int] NULL,
	[RuleID] [int] NULL,
	[BeginDate] [date] NOT NULL,
	[BeginDateTime] [datetimeoffset](7) NOT NULL,
	[EndDate] [date] NULL,
	[EndDateTime] [datetimeoffset](7) NULL,
	[CreatedDate] [date] NOT NULL,
	[CreatedDateTime] [datetimeoffset](7) NOT NULL,
	[CreatedBy] [varchar](128) NOT NULL,
	[RuleRelationshipOrder] [int] NULL,
 CONSTRAINT [PK_RuleRelationship] PRIMARY KEY CLUSTERED 
(
	[RuleRelationshipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RuleRelationship]  WITH CHECK ADD  CONSTRAINT [FK_RuleRelationship_RuleID_Rule] FOREIGN KEY([RuleID])
REFERENCES [dbo].[Rule] ([RuleID])
GO

ALTER TABLE [dbo].[RuleRelationship] CHECK CONSTRAINT [FK_RuleRelationship_RuleID_Rule]
GO
ALTER TABLE [dbo].[RuleRelationship] ADD  CONSTRAINT [DF_RuleRelationship_BeginDate]  DEFAULT (getdate()) FOR [BeginDate]
GO
ALTER TABLE [dbo].[RuleRelationship] ADD  CONSTRAINT [DF_RuleRelationship_BeginDateTime]  DEFAULT (sysdatetimeoffset()) FOR [BeginDateTime]
GO
ALTER TABLE [dbo].[RuleRelationship] ADD  CONSTRAINT [DF_RuleRelationship_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[RuleRelationship] ADD  CONSTRAINT [DF_RuleRelationship_CreatedDateTime]  DEFAULT (sysdatetimeoffset()) FOR [CreatedDateTime]
GO
ALTER TABLE [dbo].[RuleRelationship] ADD  CONSTRAINT [DF_RuleRelationship_CreatedBy]  DEFAULT (host_name()) FOR [CreatedBy]
GO
ALTER TABLE [dbo].[RuleRelationship] ADD  CONSTRAINT [DF_RuleRelationship_RuleRelationshipOrder]  DEFAULT ((0)) FOR [RuleRelationshipOrder]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID of the relationshipt between rule and authorized product' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleRelationship', @level2type=N'COLUMN',@level2name=N'RuleRelationshipID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Authorized product ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleRelationship', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Authorized product Role ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleRelationship', @level2type=N'COLUMN',@level2name=N'RuleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The start date is the first day for which this record is valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleRelationship', @level2type=N'COLUMN',@level2name=N'BeginDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The start date time defines the moment, the time of day for when the record becomes valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleRelationship', @level2type=N'COLUMN',@level2name=N'BeginDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The end date is the last day for which this record is valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleRelationship', @level2type=N'COLUMN',@level2name=N'EndDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The end date time defines the moment, the time of day for when the record is no longer valid.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleRelationship', @level2type=N'COLUMN',@level2name=N'EndDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The created date time value indicates the date and time the record was created.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleRelationship', @level2type=N'COLUMN',@level2name=N'CreatedDateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'The created by defines the user that create the row.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleRelationship', @level2type=N'COLUMN',@level2name=N'CreatedBy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Orden de la regla en el producto' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RuleRelationship', @level2type=N'COLUMN',@level2name=N'RuleRelationshipOrder'