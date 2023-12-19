.PHONY: run runl

run:
	start crossplatform1.exe && dotnet run
runl:
	dotnet crossplatform1.dll
