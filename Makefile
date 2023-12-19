.PHONY: run runl runweb

run:
	start crossplatform1.exe && dotnet run
runl:
	dotnet crossplatform1.dll
runweb:
	dotnet run
