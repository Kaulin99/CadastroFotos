use CadastroFotos
GO

create table Usuario
(Id int not null primary key identity, Nome varchar(100) not null,  Login varchar(100) not null,  Senha varchar(100) not null )

create table Fotos
(Id int not null primary key identity,  Local varchar(100) not null, DiaFoto datetime, DiaInserido datetime, DiaEditado datetime  )

/*----------------------------------------------------------------------------------*/
                              --Procedures genéricas--
/*----------------------------------------------------------------------------------*/

create or alter procedure spDeletar(
	@id int,
	@tabela varchar(max)
)
as
begin
	declare @sql varchar(max)
	set @sql = 'delete from ' + @tabela + ' where id = ' +  cast( @id as varchar(max))
	exec(@sql)
end
go

create or alter procedure spConsulta(
	@id int,
	@tabela varchar(max)
)
as
begin
	declare @sql varchar(max)
	set @sql = 'select * from ' + @tabela + ' where id = ' + cast( @id as varchar(max))
	exec(@sql)
end
go

create or alter procedure spListagem(
	@tabela varchar(max)
)
as
begin
	declare @sql varchar(max)
	set @sql = 'select * from ' + @tabela
	exec(@sql)
end
go

create or alter procedure spProximoId(
	@tabela varchar(max)
)
as
begin
	exec('select isnull(max(id)+1,1) as MAIOR from ' + @tabela) 
end
go


/*----------------------------------------------------------------------------------*/
					 --Procedures específicas da tabela Usuario--
/*----------------------------------------------------------------------------------*/

create or alter procedure spInserir_Usuario(
	@Nome varchar(max),
	@login varchar(max),
	@Senha varchar(max)
	)
as
begin
	insert into Usuario(Nome,Login,Senha)
	values (@Nome,@login,@Senha)
end

go


create or alter procedure spEditarUsuario(
	@id int,
	@Nome varchar(max),
	@login varchar(max),
	@Senha varchar(max)
)
as
begin
	update Usuario set Nome = @Nome,Login = @login, Senha = @Senha
	where id = @Id
end
go