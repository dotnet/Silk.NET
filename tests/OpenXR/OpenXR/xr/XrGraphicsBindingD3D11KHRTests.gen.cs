// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "GraphicsBindingD3D11KHR"/> struct.</summary>
public static unsafe partial class XrGraphicsBindingD3D11KHRTests
{
    /// <summary>Validates that the <see cref = "GraphicsBindingD3D11KHR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<GraphicsBindingD3D11KHR>(),
            Is.EqualTo(sizeof(GraphicsBindingD3D11KHR))
        );
    }

    /// <summary>Validates that the <see cref = "GraphicsBindingD3D11KHR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GraphicsBindingD3D11KHR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GraphicsBindingD3D11KHR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(GraphicsBindingD3D11KHR), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(GraphicsBindingD3D11KHR), Is.EqualTo(12));
        }
    }
}
