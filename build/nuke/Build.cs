using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.MSBuild;
using static Nuke.Common.Tools.MSBuild.MSBuildTasks;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

[CheckBuildProjectConfigurations]
[UnsetVisualStudioEnvironmentVariables]
class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main () => Execute<Build>(x => x.Compile);

    bool HasDesktopMsBuild
    {
        get
        {
            if (ForceDotnet)
            {
                return false;
            }
            
            try
            {
                MSBuildToolPathResolver.Resolve(); // throws if it can't find msbuild
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
    
    bool HasProcessedSolutions { get; set; }

    [Parameter("The feature sets to build - Could include Core, iOS, or Android. Any projects that aren't " +
               "categorized into a feature set will always be built.")]
    string[] FeatureSets = {"core"};

    [Parameter("Forces the build system to use \"dotnet build\" instead of \"msbuild\" if available.")]
    readonly bool ForceDotnet;

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly string Configuration = IsLocalBuild ? "Debug" : "Release";

    [Parameter("The API key used to push packages and symbols packages to NuGet")] readonly string NugetApiKey;
    [Parameter("NuGet -NoServiceEndpoint")] readonly bool NugetNoServiceEndpoint;
    [Parameter("NuGet feed")] readonly string NugetFeed = "https://api.nuget.org/v3/index.json";
    [Parameter("NuGet username")] readonly string NugetUsername;
    [Parameter("NuGet password")] readonly string NugetPassword;
    //[Parameter("NuGet feed")] readonly string NugetFeed = "https://api.nuget.org/v3/index.json";

    [Solution] readonly Solution Solution;

    Solution ProcessedSolution
    {
        get
        {
            if (!HasProcessedSolutions)
            {
                OriginalSolutionDirectory = Solution.Directory;
                Projects.ProcessSolution(Solution, FeatureSets, HasDesktopMsBuild);
                HasProcessedSolutions = true;
            }
            
            return Solution;
        }
    }
    
    AbsolutePath OriginalSolutionDirectory { get; set; }

    AbsolutePath SourceDirectory => RootDirectory / "src";

    Target Clean => _ => _
        .Before(Restore)
        .Executes(() =>
        {
            if (!HasProcessedSolutions)
            {
                var slnDir = Path.Combine(Solution.Directory!, "build", "sln");
                if (Directory.Exists(slnDir))
                {
                    Directory.Delete(slnDir, true);
                }
            }
            else
            {
                Logger.Warn
                (
                    "Solution has already been preprocessed prior to the Clean target. " +
                    "Unable to clean the preprocessed solution folder."
                );
            }
            
            
            if (HasDesktopMsBuild)
            {
                MSBuild
                (
                    s => s.SetTargetPath
                            (ProcessedSolution)
                        .SetTargets("Clean")
                        .SetMaxCpuCount(Environment.ProcessorCount)
                );
            }
            else
            {
                DotNetClean(s => s.SetProject(ProcessedSolution));
            }
        });

    Target Restore => _ => _
        .After(Clean)
        .Executes(() =>
        {
            if (HasDesktopMsBuild)
            {
                MSBuild
                (
                    s => s
                        .SetTargetPath(ProcessedSolution)
                        .SetTargets("Restore")
                        .SetMaxCpuCount(Environment.ProcessorCount)
                );
            }
            else
            {
                DotNetRestore
                (
                    s => s
                        .SetProjectFile(ProcessedSolution)
                );
            }
        });

    Target Compile => _ => _
        .DependsOn(Clean, Restore)
        .Executes(() =>
        {
            if (HasDesktopMsBuild)
            {
                MSBuild
                (
                    s => s
                        .SetTargets("Build")
                        .SetTargetPath(ProcessedSolution)
                        .SetConfiguration(Configuration)
                        .SetMaxCpuCount(Environment.ProcessorCount)
                        .SetNodeReuse(IsLocalBuild)
                );
            }
            else
            {
                DotNetBuild
                (
                    s => s
                        .SetProjectFile(ProcessedSolution)
                        .SetConfiguration(Configuration)
                        .SetNoRestore(true)
                );
            }
        });

    Target RegenerateBindings => _ => _
        .DependsOn(Clean, Restore)
        .Executes
        (
            () =>
            {
                var project = ProcessedSolution.GetProject("Silk.NET.BuildTools");
                if (project == default)
                {
                    Logger.Error("Couldn't find BuildTools in the solution file.");
                    return;
                }

                DotNetRun
                (
                    s => s.SetProjectFile(project)
                        .SetConfiguration("Release")
                        .SetApplicationArguments(Path.Combine(OriginalSolutionDirectory, "generator.json"))
                );
            }
        );

    Target FullCompile => _ => _
        .DependsOn(RegenerateBindings, Compile);

    Target Pack => _ => _
        .DependsOn(Clean, Restore)
        .After(RegenerateBindings)
        .Executes(() =>
        {
            if (HasDesktopMsBuild)
            {
                MSBuild
                (
                    s => s
                        .SetTargets("Pack")
                        .SetTargetPath(ProcessedSolution)
                        .SetConfiguration(Configuration)
                        .SetMaxCpuCount(Environment.ProcessorCount)
                        .SetNodeReuse(IsLocalBuild)
                );
            }
            else
            {
                DotNetPack
                (
                    s => s
                        .SetProject(ProcessedSolution)
                        .SetConfiguration(Configuration)
                        .SetNoRestore(true)
                );
            }
        });

    Target FullPack => _ => _
        .DependsOn(RegenerateBindings, Pack);

    Target PushToNuGet => _ => _
        .DependsOn(Pack)
        .Executes(PushPackages);

    Target FullPushToNuGet => _ => _
        .DependsOn(FullPack, PushToNuGet);

    async Task PushPackages()
    {
        const int rateLimit = 300;
        var allFiles = Directory.GetFiles(OriginalSolutionDirectory / "build" / "output_packages", "*.nupkg")
            .Select((x, i) => new {Index = i, Value = x})
            .GroupBy(x => x.Index / rateLimit)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();
        var first = true;
        var feed = NuGetInterface.OpenNuGetFeed(NugetFeed, NugetUsername, NugetPassword);
        var uploadResource = await NuGetInterface.GetUploadResourceAsync(feed);
        var symbolsResource = await NuGetInterface.GetSymbolsUploadResourceAsync(feed);
        foreach (var files in allFiles)
        {
            if (first)
            {
                first = false;
            }
            else
            {
                await Task.Delay(TimeSpan.FromHours(1));
            }

            var exceptions = new List<Exception>();

            foreach (var file in files)
            {
                try
                {
                    await NuGetInterface.UploadPackageAsync(uploadResource, NugetNoServiceEndpoint, file, NugetApiKey, symbolsResource);
                }
                catch (Exception ex)
                {
                    exceptions.Add(new Exception($"Failed to push package \"{file}\"", ex));
                }
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
