timestamps {

node () {

	stage ('.nettest - Checkout') {
 	 checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '7f7e9ccd-d1e6-4eff-b711-303a150f8f82', url: 'https://github.com/KunalRustagi/dot-net-project']]]) 
	}
	stage ('build') {
 			// Shell build step
sh """ 
export PATH=/usr/local/share/dotnet:$PATH
dotnet build
 """ 
	}
		stage ('test') {
 			// Shell build step
sh """ 
export PATH=/usr/local/share/dotnet:$PATH
dotnet test
 """ 
	}

	stage ('run') {
 			// Shell build step
sh """ 
export PATH=/usr/local/share/dotnet:$PATH
cd firstcoreproject
dotnet run

 """ 
	}
		stage ('publish') {
 			// Shell build step
sh """ 
export PATH=/usr/local/share/dotnet:$PATH

dotnet publish 
 """ 
	}
}
}