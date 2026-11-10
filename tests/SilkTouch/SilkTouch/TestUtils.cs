// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Silk.NET.SilkTouch.UnitTests;

public static class TestUtils
{
    /// <summary>
    /// Creates a project that can be used for testing purposes.
    /// </summary>
    public static Project CreateTestProject()
    {
        var workspace = new AdhocWorkspace();

        var projectId = ProjectId.CreateNewId();
        var projectInfo = ProjectInfo.Create(
            projectId,
            VersionStamp.Create(),
            name: "TestProject",
            assemblyName: "TestAssembly",
            language: LanguageNames.CSharp,
#pragma warning disable IL3000
            // Without this, basic types like System.Int32 are missing
            metadataReferences: [MetadataReference.CreateFromFile(typeof(object).Assembly.Location)]
#pragma warning restore IL3000
        );

        return workspace.AddProject(projectInfo);
    }

    public static async Task VerifyDocumentsAsync(
        IEnumerable<Document> documents,
        [CallerFilePath] string sourcePath = ""
    )
    {
        var builder = new StringBuilder();
        var isFirst = true;
        foreach (var document in documents.OrderBy(doc => doc.Name))
        {
            if (!isFirst)
            {
                builder.AppendLine();
            }

            isFirst = false;

            builder.Append("// ");
            builder.Append(document.Name);
            if (document.FilePath != null)
            {
                builder.Append(" @ ");
                builder.Append(document.FilePath);
            }
            builder.AppendLine();

            var root = await document.GetSyntaxRootAsync();
            builder.AppendLine(root!.NormalizeWhitespace().ToString());
        }

        await Verify(builder.ToString(), sourceFile: sourcePath);
    }
}
