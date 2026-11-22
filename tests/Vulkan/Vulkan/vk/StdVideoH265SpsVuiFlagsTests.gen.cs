// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "StdVideoH265SpsVuiFlags"/> struct.</summary>
public static unsafe partial class StdVideoH265SpsVuiFlagsTests
{
    /// <summary>Validates that the <see cref = "StdVideoH265SpsVuiFlags"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<StdVideoH265SpsVuiFlags>(),
            Is.EqualTo(sizeof(StdVideoH265SpsVuiFlags))
        );
    }

    /// <summary>Validates that the <see cref = "StdVideoH265SpsVuiFlags"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(StdVideoH265SpsVuiFlags).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "StdVideoH265SpsVuiFlags"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(StdVideoH265SpsVuiFlags), Is.EqualTo(4));
    }
}
