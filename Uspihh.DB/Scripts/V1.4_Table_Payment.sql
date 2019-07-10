CREATE TABLE [dbo].[Payment](
	[PaymentId] [bigint] IDENTITY(1,1) NOT NULL,
	[PaymentTypeId] [smallint] NOT NULL,
	[GroupId] [bigint] NOT NULL,
	[StudentId] [bigint] NOT NULL,
	[PaymentDate] [datetime] NOT NULL,
	[PaymentAmount] [int] NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]