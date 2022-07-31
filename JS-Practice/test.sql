DECLARE @a varchar(100) = 'capone';
DECLARE @Length INT;
DECLARE @i INT = 1;
SET @Length = LEN(@a);
WHILE @i <= @Length
BEGIN 
    PRINT(@a);
    set @i = @i + 1;

END