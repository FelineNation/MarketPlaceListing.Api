build:
	docker build -t marketplace-api .

run:
	docker run -d -p 8080:8080 marketplace-api

stop:
	docker stop $$(docker ps -aq --filter ancestor=marketplace-api)

remove:
	docker rm $$(docker ps -aq --filter ancestor=marketplace-api) && docker rmi marketplace-api