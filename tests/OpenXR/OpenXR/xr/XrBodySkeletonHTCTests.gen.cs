// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "BodySkeletonHTC"/> struct.</summary>
public static unsafe partial class XrBodySkeletonHTCTests
{
    /// <summary>Validates that the <see cref = "BodySkeletonHTC"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BodySkeletonHTC>(), Is.EqualTo(sizeof(BodySkeletonHTC)));
    }

    /// <summary>Validates that the <see cref = "BodySkeletonHTC"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BodySkeletonHTC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BodySkeletonHTC"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BodySkeletonHTC), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(BodySkeletonHTC), Is.EqualTo(16));
        }
    }
}
