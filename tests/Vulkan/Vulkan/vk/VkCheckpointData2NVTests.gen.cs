// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref = "CheckpointData2NV"/> struct.</summary>
public static unsafe partial class VkCheckpointData2NVTests
{
    /// <summary>Validates that the <see cref = "CheckpointData2NV"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CheckpointData2NV>(), Is.EqualTo(sizeof(CheckpointData2NV)));
    }

    /// <summary>Validates that the <see cref = "CheckpointData2NV"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CheckpointData2NV).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CheckpointData2NV"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CheckpointData2NV), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(CheckpointData2NV), Is.EqualTo(24));
        }
    }
}
