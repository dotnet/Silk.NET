// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis.MSBuild;
using Ultz.Extensions.Logging;

namespace Silk.NET.Statiq.ApiReference.Scraper;

public class ProgressLogger : IProgress<ProjectLoadProgress>
{
    public void Report(ProjectLoadProgress value)
    {
        Log.Trace
        (
            $"{value.Operation.ToString().TrimEnd('e')}ing {value.FilePath} for " +
            $"{value.TargetFramework} ({value.ElapsedTime} elapsed)"
        );
    }
}
