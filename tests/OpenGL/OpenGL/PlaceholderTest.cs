// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using NUnit.Framework;

namespace Silk.NET.OpenGL.UnitTests;

/// <summary>
/// ClangSharp does not generate any tests for OpenGL because there is currently nothing for it to test.
/// This ensures tests don't fail with "Zero tests ran".
/// </summary>
public class PlaceholderTest
{
    [Test]
    public void Placeholder() { }
}
