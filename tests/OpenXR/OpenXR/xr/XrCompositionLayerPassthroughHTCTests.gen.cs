// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "CompositionLayerPassthroughHTC"/> struct.</summary>
public static unsafe partial class XrCompositionLayerPassthroughHTCTests
{
    /// <summary>Validates that the <see cref = "CompositionLayerPassthroughHTC"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CompositionLayerPassthroughHTC>(),
            Is.EqualTo(sizeof(CompositionLayerPassthroughHTC))
        );
    }

    /// <summary>Validates that the <see cref = "CompositionLayerPassthroughHTC"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CompositionLayerPassthroughHTC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CompositionLayerPassthroughHTC"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CompositionLayerPassthroughHTC), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(CompositionLayerPassthroughHTC), Is.EqualTo(40));
        }
    }
}
