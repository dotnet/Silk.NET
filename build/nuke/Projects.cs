// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JetBrains.Annotations;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using static Nuke.Common.ProjectModel.ProjectModelTasks;

public static class Projects
{
    // Modify this bit if you want to define another feature set
    public static readonly IReadOnlyList<FeatureSet> FeatureSets = new[]
    {
        new FeatureSet("Legacy-iOS", true, true, "Silk.NET.Windowing.Sdl.iOS", "TriangleIOS"),
        new FeatureSet("Legacy-Android", true, true, "Silk.NET.Windowing.Sdl.Android", "TriangleDroid", "TriangleDroidUvExperiment"),
        new FeatureSet("NUKE", false, false, "Silk.NET.NUKE", "Silk.NET.NUKE.SshAgent"),
    };

    public static Dictionary<string, (Solution Solution, bool UseDesktopMSBuild)> ProcessSolution
    (
        Solution originalSolution,
        string[] featureSets,
        bool hasDesktopMsBuild
    )
    {
        var originalSolutionPath = originalSolution;
        var featureSetSpecificSolutions = new Dictionary<string, (Solution, bool)>();
        var rm = new List<string>();
        foreach (var featureSet in FeatureSets!)
        {
            rm.Clear();
            var featureSetUsed = featureSets.Any
                (x => x.Equals(featureSet.Name, StringComparison.OrdinalIgnoreCase));
            if (featureSetUsed && !hasDesktopMsBuild && featureSet.RequiresDesktopMsBuild)
            {
                throw new NotSupportedException("Desktop MSBuild is not available.");
            }

            foreach (var proj in originalSolution.GetProjects("*"))
            {
                if (!featureSet.Projects.Any(x => x.Equals(proj.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    rm.Add(proj.Path);
                    continue;
                }

                if (!featureSetUsed)
                {
                    Logger.Trace($"\"{proj.Name}\" will not be built as its feature set \"{featureSet.Name}\" has " +
                                 "not been enabled. To build this project, specify the feature set name when " +
                                 "invoking NUKE.");
                }

                originalSolution.RemoveProject(proj);
            }

            if (!featureSet.GenerateExclusiveSln || !featureSetUsed)
            {
                continue;
            }
            
            var sln = ParseSolution(originalSolutionPath);
            featureSetSpecificSolutions[featureSet.Name] = (sln, featureSet.RequiresDesktopMsBuild);
            foreach (var removal in rm)
            {
                sln.RemoveProject(sln.GetProject(removal));
            }
        }

        var slnDir = Path.Combine(originalSolution.Directory!, "build", "sln");
        if (!Directory.Exists(slnDir))
        {
            Directory.CreateDirectory(slnDir);
        }

        featureSetSpecificSolutions["Core"] = (originalSolution, false);

        foreach (var (key, (sln, _)) in featureSetSpecificSolutions)
        {
            sln.SaveAs(Path.Combine(slnDir, key + ".gen.sln"));
        }

        return featureSetSpecificSolutions;
    }

    public struct FeatureSet
    {
        public string Name { get; }
        public bool RequiresDesktopMsBuild { get; }
        public bool GenerateExclusiveSln { get; }
        public string[] Projects { get; }

        public FeatureSet(string name, bool requiresDesktopMsBuild, bool generateExclusiveSln, params string[] projects)
        {
            Name = name;
            RequiresDesktopMsBuild = requiresDesktopMsBuild;
            GenerateExclusiveSln = generateExclusiveSln;
            Projects = projects;
        }
    }
}
