﻿CREATE TABLE [dbo].[PaymentDetail](
	[PaymentId] [bigint] NOT NULL,
	[BankName] [nvarchar](50) NOT NULL,
	[CheckNumber] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_PaymentDetail] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]