// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "StdVideoH265ScalingLists"/> struct.</summary>
public static unsafe partial class StdVideoH265ScalingListsTests
{
    /// <summary>Validates that the <see cref = "StdVideoH265ScalingLists"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<StdVideoH265ScalingLists>(),
            Is.EqualTo(sizeof(StdVideoH265ScalingLists))
        );
    }

    /// <summary>Validates that the <see cref = "StdVideoH265ScalingLists"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(StdVideoH265ScalingLists).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "StdVideoH265ScalingLists"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(StdVideoH265ScalingLists), Is.EqualTo(1000));
    }
}
