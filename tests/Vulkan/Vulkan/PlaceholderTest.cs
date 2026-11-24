// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>
/// Vulkan currently does not have any tests due to the issues identified during https://github.com/dotnet/Silk.NET/pull/2650.
/// This ensures tests don't fail with "Zero tests ran".
/// </summary>
public class PlaceholderTest
{
    [Test]
    public void Placeholder() { }
}
