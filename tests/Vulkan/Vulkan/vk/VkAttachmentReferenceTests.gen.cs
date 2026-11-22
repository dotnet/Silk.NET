// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "AttachmentReference"/> struct.</summary>
public static unsafe partial class VkAttachmentReferenceTests
{
    /// <summary>Validates that the <see cref = "AttachmentReference"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AttachmentReference>(), Is.EqualTo(sizeof(AttachmentReference)));
    }

    /// <summary>Validates that the <see cref = "AttachmentReference"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AttachmentReference).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AttachmentReference"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AttachmentReference), Is.EqualTo(8));
    }
}
