# SourceLink.Demo

Test application that uses the [SourceLink.Demo.Library](https://github.com/picardh-cision/sourcelink-demo-library) nuget package to test and showcase the SourceLink feature.

To be able to compile and execute the application you will need to configure your local nuget client with a Github access token to the following nuget reposity : https://nuget.pkg.github.com/picardh-cision/index.json

```powershell
dotnet nuget add source --username [github username] --password [personal access token] --name PicardhCisionGithub https://nuget.pkg.github.com/picardh-cision/index.json
```

You will also need to disable the `Enable Just My Code` in the _General Debugging_ Visual Studio configuration.
