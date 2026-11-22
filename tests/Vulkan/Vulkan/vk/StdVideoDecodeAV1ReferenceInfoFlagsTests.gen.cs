// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "StdVideoDecodeAv1ReferenceInfoFlags"/> struct.</summary>
public static unsafe partial class StdVideoDecodeAV1ReferenceInfoFlagsTests
{
    /// <summary>Validates that the <see cref = "StdVideoDecodeAv1ReferenceInfoFlags"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<StdVideoDecodeAv1ReferenceInfoFlags>(),
            Is.EqualTo(sizeof(StdVideoDecodeAv1ReferenceInfoFlags))
        );
    }

    /// <summary>Validates that the <see cref = "StdVideoDecodeAv1ReferenceInfoFlags"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(StdVideoDecodeAv1ReferenceInfoFlags).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "StdVideoDecodeAv1ReferenceInfoFlags"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(StdVideoDecodeAv1ReferenceInfoFlags), Is.EqualTo(4));
    }
}
