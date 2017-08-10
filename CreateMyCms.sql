create table mycms_user(
Id int primary key,
UserID nvarchar(40) not null,
UserName nvarchar(40)  not null, 
TrueName nvarchar(40), 
UserPsw nvarchar(64)  not null,
Sex int,
Email nvarchar(80),
Phone nvarchar(20),
_Power int,
LoginIp nvarchar(15),
IsForbidden int,
RegTime datetime
)
create table mycms_power(
PowerId int primary key,
PowerName nvarchar(50) not null
)
create table mycms_class(
Id int primary key ,
ClassName nvarchar(50) not null,
ParentId int,
SortRank int, 
IsOnNav int not null,
IsOnIndex int not null,
IsForbidden int not null,
)
create table mycms_news(
Id int primary key,
ClassId int not null,
Title nvarchar(150),
Author nvarchar(50),
AddTime datetime,
Summary nvarchar(MAX),
IsImg Int not null,
Content nvarchar(MAX)
)
create table mycms_temptates(
Id int primary key,
Title nvarchar(100),
TpType nvarchar(50),
_Source nvarchar(50),
IsInclude Int,
)
create table mycms_pic(
Id int primary key,
Title nvarchar(30),
Iwidth int ,
Iheight int,
NewsId int
)
create table mycms_menu(
Menuid int primary key,
MenuName nvarchar(50) not null,
ParentMenu int not null
)
CREATE TABLE [dbo].[SysUser] (
    [UserID]        VARCHAR (255) NOT NULL,
    [UserLoginName] VARCHAR (500) NULL,
    [UserName]      VARCHAR (255) NULL,
    [UserPassword]  VARCHAR (255) NULL,
    [IsMain]        BIT           NULL,
    [OrgID]         NVARCHAR (50) NULL,
    [LastTime]      DATETIME      NULL,
    [LastIP]        VARCHAR (255) NULL,
    [IsUse]         BIT           NULL,
    [Sex]           VARCHAR (255) NULL,
    [Phone]         VARCHAR (255) NULL,
    [PeopleCode]    VARCHAR (255) NULL,
    [Tel]           VARCHAR (255) NULL,
    [Email]         VARCHAR (255) NULL,
    [RegDate]       DATETIME      NULL,
    [OrgName]       VARCHAR (255) NULL,
    [UserStatus]    VARCHAR (255) NULL,
    [UserType]      NVARCHAR (50) NULL,
    CONSTRAINT [PK_SYSUSER] PRIMARY KEY CLUSTERED ([UserID] ASC)
);
