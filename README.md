# Modul-8


sql query
-------
create sequence users_id start 20220001
-------
create table tb_users
(
	id character varying(100) default 'ST' || nextval('users_id') primary key,
	name character varying(20),
	alamat character varying(20),
	no_hp character varying(20)
)
-------
create function st_insert
(
	_name character varying,
	_alamat character varying,
	_no_hp character varying
)

returns int as

'
begin
	insert into public.tb_users
	(
		name,
		alamat,
		no_hp
	)
	values
	(
		_name,
		_alamat,
		_no_hp
	);
	if found then
		return 1;
	else
		return 0;
	end if;
end
'

language plpgsql;
-------
create function st_select()
returns table
(
	_id character varying,
	_name character varying,
	_alamat character varying,
	_no_hp character varying
)

language plpgsql as

'
begin
	return query
	select id, name, alamat, no_hp from tb_users;
end
'
-------

create or replace function st_update
(
	_id character varying,
	_name character varying,
	_alamat character varying,
	_no_hp character varying
)

returns int as

'
begin
	update tb_users SET
		name = _name,
		alamat = _alamat,
		no_hp = _no_hp
	where id = _id;
	if found then
		return 1;
	else
		return 0;
	end if;
end
'

language plpgsql;
------

create or replace function st_delete(_id character varying)
returns int as
'
begin
	DELETE FROM public.tb_users
	WHERE id = _id;
	if found then
		return 1;
	else
		return 0;
	end if;
end
'

language plpgsql;
-------


