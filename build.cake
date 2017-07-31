#load nuget:?package=Cake.Script

// required config
config.appName = "Sample";
config.git.projectUrl = "https://github.com/bigdaddylulu/NVC";
config.file.solution = "./src/NovabCalc.sln";
config.version.major = "1";
config.version.minor = "0";

// optional if you want to publish a pacakge to nuget
// Pack("Sample.Core", "Sample Core Description", new []{"awesome", "service"});

RunTarget(target);