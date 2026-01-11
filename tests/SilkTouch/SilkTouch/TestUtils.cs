// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
}
