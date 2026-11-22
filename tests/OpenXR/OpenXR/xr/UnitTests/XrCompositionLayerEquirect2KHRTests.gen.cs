// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "CompositionLayerEquirect2KHR"/> struct.</summary>
public static unsafe partial class XrCompositionLayerEquirect2KHRTests
{
    /// <summary>Validates that the <see cref = "CompositionLayerEquirect2KHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CompositionLayerEquirect2KHR>(),
            Is.EqualTo(sizeof(CompositionLayerEquirect2KHR))
        );
    }

    /// <summary>Validates that the <see cref = "CompositionLayerEquirect2KHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CompositionLayerEquirect2KHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CompositionLayerEquirect2KHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CompositionLayerEquirect2KHR), Is.EqualTo(120));
        }
        else
        {
            Assert.That(sizeof(CompositionLayerEquirect2KHR), Is.EqualTo(96));
        }
    }
}
