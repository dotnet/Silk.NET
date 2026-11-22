// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "StdVideoEncodeAv1OperatingPointInfoFlags"/> struct.</summary>
public static unsafe partial class StdVideoEncodeAV1OperatingPointInfoFlagsTests
{
    /// <summary>Validates that the <see cref = "StdVideoEncodeAv1OperatingPointInfoFlags"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<StdVideoEncodeAv1OperatingPointInfoFlags>(),
            Is.EqualTo(sizeof(StdVideoEncodeAv1OperatingPointInfoFlags))
        );
    }

    /// <summary>Validates that the <see cref = "StdVideoEncodeAv1OperatingPointInfoFlags"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(StdVideoEncodeAv1OperatingPointInfoFlags).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "StdVideoEncodeAv1OperatingPointInfoFlags"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(StdVideoEncodeAv1OperatingPointInfoFlags), Is.EqualTo(4));
    }
}
