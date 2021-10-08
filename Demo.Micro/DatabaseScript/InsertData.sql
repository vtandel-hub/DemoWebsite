USE [CertificationDB]
GO

INSERT INTO [dbo].[Certifications]
           ([Code]
           ,[Name]
           ,[Cost]
           ,[Description]
           ,[Prerequisite])
     VALUES
		   ('AZ-900'
           ,'Azure Fundamentals'
           ,'99'
           ,'This is a fundamentals certification of azure.'
           ,'N/A'
		   ),
		   ('AZ-204'
           ,'Azure Developer'
           ,'$160'
           ,'This is a developer certification of azure.'
           ,'AZ-900'
		   ),
		   ('AZ-104'
           ,'Azure Administrator'
           ,'$160'
           ,'This is an Admin certification of azure.'
           ,'AZ-900'
		   ),
		   ('AZ-400'
           ,'Azure DevOps'
           ,'$160'
           ,'This is a devops certification of azure.'
           ,'AZ-204 or AZ-104'
		   ),
		   ('AZ-500'
           ,'Azure Security Engineer'
           ,'$160'
           ,'This is a security engineer certification of azure.'
           ,'AZ-900'
		   )

GO


