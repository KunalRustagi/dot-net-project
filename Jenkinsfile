pipeline {
 agent any
 
 stages {
  stage('Restore PACKAGES') {
   steps {
    sh "dotnet restore "
   }
  }
  stage('Clean') {
   steps {
    sh 'dotnet clean'
   }
  }
  stage('Build') {
   steps {
    sh 'dotnet build '
   }
  }
  stage('Pack') {
   steps {
    sh 'dotnet pack '
   }
  }
stage('Test'){
   steps {
    sh "dotnet test"
   }
  }
  stage('Publish') {
   steps {
    sh "dotnet publish"
   }
 }
}
}