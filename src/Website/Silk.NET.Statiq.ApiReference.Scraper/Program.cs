// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.CommandLine;
using System.CommandLine.Invocation;
using System.Diagnostics;
using Silk.NET.Statiq.ApiReference.Scraper;

static FileInfo? ResolveProjectOrSolutionInCwd()
{
    var slnOrProj = Directory.GetFiles(Environment.CurrentDirectory, "*.sln")
        .Concat(Directory.GetFiles(Environment.CurrentDirectory, "*.csproj"));
    string? candidateFile = null;
    foreach (var theFile in slnOrProj)
    {
        if (candidateFile is null)
        {
            candidateFile = theFile;
        }
        else
        {
            // multiple files detected! we can't safely decide which one to use...
            return null;
        }
    }

    if (candidateFile is null)
    {
        return null;
    }

    return new(candidateFile);
}

var slnOrProjInCwd = ResolveProjectOrSolutionInCwd();
var rootCommand = new RootCommand
{
    slnOrProjInCwd is null
        ? new Option<FileInfo>
        (
            new[] { "--project", "-p" },
            "The input solution or project file to generate for."
        )
        {
            IsRequired = true
        }
        : new
        (
            new[] { "--project", "-p" },
            () => slnOrProjInCwd, // add a default value factory if we've found an individual project or solution
            "The input solution or project file to generate for."
        ),
    new Option<FileInfo>
    (
        new[] { "--output", "-o" },
        "The output API documentation. Recommended extensions: .jgz, .json.gz, .silkdoc"
    )
    {
        IsRequired = true
    },
    new Option<LogMode>
    (
        new[] { "--logging", "-l" },
        () => Debugger.IsAttached ? LogMode.VVerbose : LogMode.Standard,
        "The debug logging verbosity."
    )
};

rootCommand.Handler = CommandHandler.Create<FileInfo, FileInfo, LogMode>(Scraper.RunAsync);
return await rootCommand.InvokeAsync(args);
