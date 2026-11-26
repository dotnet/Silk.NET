// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "GraphicsRequirementsD3D12KHR"/> struct.</summary>
public static unsafe partial class XrGraphicsRequirementsD3D12KHRTests
{
    /// <summary>Validates that the <see cref = "GraphicsRequirementsD3D12KHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<GraphicsRequirementsD3D12KHR>(),
            Is.EqualTo(sizeof(GraphicsRequirementsD3D12KHR))
        );
    }

    /// <summary>Validates that the <see cref = "GraphicsRequirementsD3D12KHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GraphicsRequirementsD3D12KHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GraphicsRequirementsD3D12KHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(GraphicsRequirementsD3D12KHR), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(GraphicsRequirementsD3D12KHR), Is.EqualTo(20));
        }
    }
}
