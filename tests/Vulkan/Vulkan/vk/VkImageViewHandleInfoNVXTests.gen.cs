// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "ImageViewHandleInfoNVX"/> struct.</summary>
public static unsafe partial class VkImageViewHandleInfoNVXTests
{
    /// <summary>Validates that the <see cref = "ImageViewHandleInfoNVX"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ImageViewHandleInfoNVX>(),
            Is.EqualTo(sizeof(ImageViewHandleInfoNVX))
        );
    }

    /// <summary>Validates that the <see cref = "ImageViewHandleInfoNVX"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ImageViewHandleInfoNVX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ImageViewHandleInfoNVX"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ImageViewHandleInfoNVX), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(ImageViewHandleInfoNVX), Is.EqualTo(20));
        }
    }
}
