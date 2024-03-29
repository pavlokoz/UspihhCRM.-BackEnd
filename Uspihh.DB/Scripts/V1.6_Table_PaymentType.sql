﻿CREATE TABLE [dbo].[PaymentType](
	[PaymentTypeId] [smallint] IDENTITY(1,1) NOT NULL,
	[PaymentTypeName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_PaymentType] PRIMARY KEY CLUSTERED 
(
	[PaymentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]