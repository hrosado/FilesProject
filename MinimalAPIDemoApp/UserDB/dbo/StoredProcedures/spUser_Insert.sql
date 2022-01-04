CREATE PROCEDURE [dbo].[spUser_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	insert intodbo.[User] (FirstName, LastName)
	values (@FirstName, @LastName);
end
