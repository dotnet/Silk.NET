// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "MutableDescriptorTypeListEXT"/> struct.</summary>
public static unsafe partial class VkMutableDescriptorTypeListEXTTests
{
    /// <summary>Validates that the <see cref = "MutableDescriptorTypeListEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MutableDescriptorTypeListEXT>(),
            Is.EqualTo(sizeof(MutableDescriptorTypeListEXT))
        );
    }

    /// <summary>Validates that the <see cref = "MutableDescriptorTypeListEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MutableDescriptorTypeListEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MutableDescriptorTypeListEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MutableDescriptorTypeListEXT), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(MutableDescriptorTypeListEXT), Is.EqualTo(8));
        }
    }
}
