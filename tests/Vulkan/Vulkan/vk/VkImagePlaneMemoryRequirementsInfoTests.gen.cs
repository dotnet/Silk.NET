// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "ImagePlaneMemoryRequirementsInfo"/> struct.</summary>
public static unsafe partial class VkImagePlaneMemoryRequirementsInfoTests
{
    /// <summary>Validates that the <see cref = "ImagePlaneMemoryRequirementsInfo"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ImagePlaneMemoryRequirementsInfo>(),
            Is.EqualTo(sizeof(ImagePlaneMemoryRequirementsInfo))
        );
    }

    /// <summary>Validates that the <see cref = "ImagePlaneMemoryRequirementsInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ImagePlaneMemoryRequirementsInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ImagePlaneMemoryRequirementsInfo"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ImagePlaneMemoryRequirementsInfo), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(ImagePlaneMemoryRequirementsInfo), Is.EqualTo(12));
        }
    }
}
