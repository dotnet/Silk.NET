// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text;
using Microsoft.CodeAnalysis;

namespace Silk.NET.SilkTouch.UnitTests;

public static class TestUtils
{
    /// <summary>
    /// Creates a project that can be used for testing purposes.
    /// </summary>
    public static Project CreateTestProject() =>
        new AdhocWorkspace().CurrentSolution.AddProject(
            "TestProject",
            "TestAssembly",
            LanguageNames.CSharp
        );

    public static async Task VerifyDocumentsAsync(params IEnumerable<Document> documents)
    {
        var builder = new StringBuilder();
        foreach (var document in documents.OrderBy(doc => doc.Name))
        {
            builder.Append("// ");
            builder.AppendLine(document.Name);

            var root = await document.GetSyntaxRootAsync();
            builder.AppendLine(root!.NormalizeWhitespace().ToString());
            builder.AppendLine();
        }

        await Verify(builder.ToString());
    }
}
