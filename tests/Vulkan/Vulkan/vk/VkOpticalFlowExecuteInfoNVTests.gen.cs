// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "OpticalFlowExecuteInfoNV"/> struct.</summary>
public static unsafe partial class VkOpticalFlowExecuteInfoNVTests
{
    /// <summary>Validates that the <see cref = "OpticalFlowExecuteInfoNV"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<OpticalFlowExecuteInfoNV>(),
            Is.EqualTo(sizeof(OpticalFlowExecuteInfoNV))
        );
    }

    /// <summary>Validates that the <see cref = "OpticalFlowExecuteInfoNV"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(OpticalFlowExecuteInfoNV).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "OpticalFlowExecuteInfoNV"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(OpticalFlowExecuteInfoNV), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(OpticalFlowExecuteInfoNV), Is.EqualTo(20));
        }
    }
}
