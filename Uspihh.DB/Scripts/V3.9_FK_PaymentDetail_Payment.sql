ALTER TABLE [dbo].[PaymentDetail]  WITH CHECK ADD  CONSTRAINT [FK_PaymentDetail_Payment] FOREIGN KEY([PaymentId])
REFERENCES [dbo].[Payment] ([PaymentId])
GO
ALTER TABLE [dbo].[PaymentDetail] CHECK CONSTRAINT [FK_PaymentDetail_Payment]
