createglobal7:
	dotnet new globaljson --sdk-version 7.0.410
	
createglobal3:
	dotnet new globaljson --sdk-version 3.1.426

createconsole:
	cd ${folder} && dotnet new console -n ${name}

runapp:
	cd ${folder} && dotnet run