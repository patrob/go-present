projectPath="GoPresent.Api/GoPresent.Api.csproj"
contextName="GoPresentDbContext"

list:
	cat makefile | grep .*:

up:
	docker compose up -d

down:
	docker compose down

reset:
	make down && make up

format:
	dotnet format

test:
	dotnet test

add_migration:
	dotnet ef migrations add "$(name)" --context $(contextName) --startup-project $(projectPath) --project $(projectPath) --output-dir "Data/Migrations"

remove_migrations:
	dotnet ef migrations remove --context $(contextName) --startup-project $(projectPath) --project $(projectPath) --force

run_migrations:
	dotnet ef database update --context $(contextName) --startup-project $(projectPath) --project $(projectPath)

run_migrations_local:
	export ASPNETCORE_ENVIRONMENT=Local																							&& \
	dotnet ef database update --context $(contextName) --startup-project $(projectPath) --project $(projectPath)

rollback_migration:
	dotnet ef database update "$(name)" --context $(contextName) --startup-project $(projectPath) --project $(projectPath)
