ALTER TABLE [dbo].[GroupTeacher]  WITH CHECK ADD  CONSTRAINT [FK_GroupTeacher_Teacher] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teacher] ([TeacherId])
GO
ALTER TABLE [dbo].[GroupTeacher] CHECK CONSTRAINT [FK_GroupTeacher_Teacher]
