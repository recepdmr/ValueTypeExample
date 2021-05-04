# Start this docker command
	docker run --name testdb -e POSTGRES_PASSWORD=password -d -p 5432:5432 postgres