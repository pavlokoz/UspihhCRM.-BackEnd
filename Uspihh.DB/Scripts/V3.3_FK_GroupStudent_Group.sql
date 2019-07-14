ALTER TABLE [dbo].[GroupStudent]  WITH CHECK ADD  CONSTRAINT [FK_GroupStudent_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([GroupId])
GO
ALTER TABLE [dbo].[GroupStudent] CHECK CONSTRAINT [FK_GroupStudent_Group]
GO