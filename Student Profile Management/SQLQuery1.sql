Create database Student_Profile

Create table Admin_Login(
Admin_ID varchar(20),
Admin_Password varchar(20));

insert into Admin_Login(Admin_ID,Admin_Password)
values
('Admin','123');

Student_Name,Father_Name,Mother_Name,Student_address,Department,Program,Birthday,Gender,Student_ID

Create table Student_Registration(
Student_Name varchar(50),
Father_Name varchar(50),
Mother_Name varchar(50),
Student_address varchar(50),
Department varchar(20),
Program varchar(20),
Birthday varchar(50),
Gender varchar(50),
cgpa varchar(50),
Student_ID varchar(50));

Create table Student_Login(
Student_ID varchar(50),
Student_Passwrd varchar(50));

Create table Student_updateloginId(
Student_ID varchar(50));

insert into Student_updateloginId(Student_ID)
values
('0');


select * from dep_cse;


create table dep_cse(
Subject_Name varchar(10));

insert into dep_cse(Subject_Name)
values
('ENG 101'),
('ENG 111'),
('MAT 101'),
('MAT 111'),
('MAT 121'),
('EEE 101'),
('EEE 111'),
('CSE 101'),
('CSE 102'),
('CSE 111'),
('CSE 112'),
('CSE 121'),
('CSE 122'),
('CSE 307'),
('CSE 308'),
('CSE 223'),
('CSE 224'),
('CSE 100'),
('CSE 200'),
('CSE 300'),
('CSE 400');


create table dep_eee(
Subject_Name varchar(10));

insert into dep_eee(Subject_Name)
values
('ENG 101'),
('ENG 111'),
('MAT 101'),
('MAT 111'),
('MAT 121'),
('CSE 101'),
('CSE 111'),
('EEE 101'),
('EEE 102'),
('EEE 111'),
('EEE 112'),
('EEE 121'),
('EEE 122'),
('EEE 307'),
('EEE 308'),
('EEE 223'),
('EEE 224'),
('EEE 100'),
('EEE 200'),
('EEE 300'),
('EEE 400');

create table dep_textile(
Subject_Name varchar(10));

insert into dep_textile(Subject_Name)
values
('ENG 101'),
('ENG 111'),
('MAT 101'),
('MAT 111'),
('MAT 121'),
('CSE 101'),
('CSE 111'),
('TEX 101'),
('TEX 102'),
('TEX 111'),
('TEX 112'),
('TEX 121'),
('TEX 122'),
('TEX 307'),
('TEX 308'),
('TEX 223'),
('TEX 224'),
('TEX 100'),
('TEX 200'),
('TEX 300'),
('TEX 400');

create table dep_English(
Subject_Name varchar(10));

insert into dep_English(Subject_Name)
values
('ENG 101'),
('ENG 111'),
('MAT 101'),
('MAT 111'),
('MAT 121'),
('CSE 101'),
('CSE 111'),
('ENG 101'),
('ENG 102'),
('ENG 111'),
('ENG 112'),
('ENG 121'),
('ENG 122'),
('ENG 307'),
('ENG 308'),
('ENG 223'),
('ENG 224'),
('ENG 100'),
('ENG 200'),
('ENG 300'),
('ENG 400');

create table dep_law(
Subject_Name varchar(10));

insert into dep_law(Subject_Name)
values
('ENG 101'),
('ENG 111'),
('MAT 101'),
('MAT 111'),
('MAT 121'),
('EEE 101'),
('EEE 111'),
('CSE 101'),
('CSE 102'),
('CSE 111'),
('CSE 112'),
('CSE 121'),
('CSE 122'),
('CSE 307'),
('CSE 308'),
('CSE 223'),
('CSE 224'),
('CSE 100'),
('CSE 200'),
('CSE 300'),
('CSE 400');





create table sub_list(
Student_ID varchar(20),
Subject_Name varchar(20),
Subject_Grade Varchar(20));

select * from sub_list;