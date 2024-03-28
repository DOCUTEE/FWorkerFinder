create table LikedWorker(
	
	CustomerID varchar(10) not null,
	WorkerID varchar(10) not null

)
alter table LikedWorker
add
Primary key (WorkerID,CustomerID)

insert into LikedWorker
values ('1','1')

insert into LikedWorker
values ('1','2')
insert into LikedWorker
values ('1','3')
insert into LikedWorker
values ('1','4')

delete from LikedWorker
select * from WORKERS
drop table LikedWorker

Select * from LikedWorker where CustomerID = '1' and WorkerID = '1'
select * from LikedWorker