#load nuget:?package=Cake.Script

// required config
config.appName = "Sample";
config.git.projectUrl = "https://github.com/bigdaddylulu/NVC";
config.file.solution = "./src/nvc.sln";
config.version.major = "1";
config.version.minor = "0";
config.xunit.enabled = false;

// optional if you want to publish a pacakge to nuget
// Pack("Sample.Core", "Sample Core Description", new []{"awesome", "service"});

RunTarget(target);