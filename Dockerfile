FROM microsoft/aspnetcore
COPY dist /app
WORKDIR /app
ENTRYPOINT [ "dotnet", "testMVC.dll" ]