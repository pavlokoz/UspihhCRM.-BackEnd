ALTER TABLE [dbo].[TeacherSubject]  WITH CHECK ADD  CONSTRAINT [FK_TeacherSubject_Teacher] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teacher] ([TeacherId])
GO
ALTER TABLE [dbo].[TeacherSubject] CHECK CONSTRAINT [FK_TeacherSubject_Teacher]
