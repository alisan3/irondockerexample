# Commands to perform on this project

//dotnet publish -o ./docker/publish
docker image build . -t irondockerexample
docker container run irondockerexample
