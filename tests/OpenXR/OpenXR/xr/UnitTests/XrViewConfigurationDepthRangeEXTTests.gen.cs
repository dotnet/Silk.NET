// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "ViewConfigurationDepthRangeEXT"/> struct.</summary>
public static unsafe partial class XrViewConfigurationDepthRangeEXTTests
{
    /// <summary>Validates that the <see cref = "ViewConfigurationDepthRangeEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ViewConfigurationDepthRangeEXT>(),
            Is.EqualTo(sizeof(ViewConfigurationDepthRangeEXT))
        );
    }

    /// <summary>Validates that the <see cref = "ViewConfigurationDepthRangeEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ViewConfigurationDepthRangeEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ViewConfigurationDepthRangeEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ViewConfigurationDepthRangeEXT), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(ViewConfigurationDepthRangeEXT), Is.EqualTo(24));
        }
    }
}
