ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_User] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_User]
