ALTER TABLE [dbo].[GroupTeacher]  WITH CHECK ADD  CONSTRAINT [FK_GroupTeacher_Group] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([GroupId])
GO
ALTER TABLE [dbo].[GroupTeacher] CHECK CONSTRAINT [FK_GroupTeacher_Group]
