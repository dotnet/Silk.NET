// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "RenderModelAssetNodePropertiesEXT"/> struct.</summary>
public static unsafe partial class XrRenderModelAssetNodePropertiesEXTTests
{
    /// <summary>Validates that the <see cref = "RenderModelAssetNodePropertiesEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<RenderModelAssetNodePropertiesEXT>(),
            Is.EqualTo(sizeof(RenderModelAssetNodePropertiesEXT))
        );
    }

    /// <summary>Validates that the <see cref = "RenderModelAssetNodePropertiesEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RenderModelAssetNodePropertiesEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RenderModelAssetNodePropertiesEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RenderModelAssetNodePropertiesEXT), Is.EqualTo(64));
    }
}
