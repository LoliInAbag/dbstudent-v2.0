declare @doc varchar(max)
declare @hdoc int
select @doc = BulkColumn from openrowset(bulk 'd:\\tes1t.xml', single_blob) xml
exec sp_xml_preparedocument @hdoc output, @doc
select *
from openxml(@hdoc,'/ROOT/Customer/Order/offer	')
with (CustomerID nvarchar(10), EmployeeID nvarchar(10), OrderDate nvarchar(max))

