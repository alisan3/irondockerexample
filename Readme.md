# Commands to perform on this project

dotnet publish -o ./publish
docker image build . -t irondockerexample
docker container run irondockerexample
