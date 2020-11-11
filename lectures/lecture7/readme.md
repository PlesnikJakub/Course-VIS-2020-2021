# Project setup with DB

In this article we wil go through settup of .net project with connection to SQL server.

## Step 1 - Create DB and connect
### Local database

You can install many different database engines/servers. With MS stack we will use we can prefer Microsoft SQL Server Express. With this instaled to your computer you can connect to this database directly from Visual Studio or install SSMS.

* https://www.microsoft.com/en-us/sql-server/sql-server-downloads

You may have installed server but you need to create database. You can do that with query when connected to masted db. 

```sql
USE master;
GO
IF DB_ID (N'mytest') IS NOT NULL
DROP DATABASE mytest;
GO
CREATE DATABASE mytest;
GO
```

### Remote database 

You can have your database on totaly different computer/server. For example our university system https://dbman.cs.vsb.cz/ can provide such database. Retrieve connection string and conenct Visual Studio to this DB instance.

## Step 2 - Connect to database and create tables
 
You can create new database tables manualy with TSSQL or Table designer. There is also option to use tool for defining ER diagram and generate SQL create script from that.

* https://docs.microsoft.com/en-us/sql/relational-databases/tables/create-tables-database-engine?view=sql-server-ver15


## Step 3 - Fill database with data

Again you have a two options. 
1. You can write your script manualy 
2. You can use some IDE that have excel like table to create and modify data

:warning: If you will use option 2, after filling DB with data export data to inser script to have in as a backup.

```sql
CREATE TABLE [dbo].[CUSTOMERS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NAME] [varchar](20) NOT NULL,
	[AGE] [int] NOT NULL,
	[ADDRESS] [char](25) NULL,
	[SALARY] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

```

## Step 4 - Implement connection to data 

You can check project in this folder and find class **DBConnector** this class is responsible for creating a connection to SQL DB. You can find some inpiration there. There is also a tons of matirals from different sources.

```sql
INSERT INTO CUSTOMERS (NAME,AGE,ADDRESS,SALARY)
VALUES ('Ramesh', 32, 'Ahmedabad', 150.00 );

INSERT INTO CUSTOMERS (NAME,AGE,ADDRESS,SALARY)
VALUES ('Khilan', 25, 'Delhi', 150.00 );

```

## Step 5 - Implement queries

Check following classes to see how you can implement DB queries.

* DataLayer3.TableDataGateway.CustomerTableGateway
* DataLayer.DataMapper.DataMapper

## Step 6 - Celebrate

Good job making it all the way down there! :rocket: