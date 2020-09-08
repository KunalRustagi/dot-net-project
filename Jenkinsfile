pipeline {
 agent any
 
 stages {
  stage('Restore PACKAGES') {
   steps {
    sh "export PATH=/usr/local/share/dotnet:$PATH"   	
    sh "dotnet restore "
   }
  }
  stage('Clean') {
   steps {
    sh "export PATH=/usr/local/share/dotnet:$PATH"	
    sh 'dotnet clean'
   }
  }
  stage('Build') {
   steps {
    sh "export PATH=/usr/local/share/dotnet:$PATH"
    sh 'dotnet build '
   }
  }
  stage('Pack') {
   steps {
    sh "export PATH=/usr/local/share/dotnet:$PATH"
    sh 'dotnet pack '
   }
  }
stage('Test'){
   steps {
    sh "export PATH=/usr/local/share/dotnet:$PATH"
    sh "dotnet test"
   }
  }
  stage('Publish') {
   steps {
    sh "export PATH=/usr/local/share/dotnet:$PATH"
    sh "dotnet publish"
   }
 }
}
}