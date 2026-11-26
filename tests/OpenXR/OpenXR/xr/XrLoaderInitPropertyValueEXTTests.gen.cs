// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "LoaderInitPropertyValueEXT"/> struct.</summary>
public static unsafe partial class XrLoaderInitPropertyValueEXTTests
{
    /// <summary>Validates that the <see cref = "LoaderInitPropertyValueEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<LoaderInitPropertyValueEXT>(),
            Is.EqualTo(sizeof(LoaderInitPropertyValueEXT))
        );
    }

    /// <summary>Validates that the <see cref = "LoaderInitPropertyValueEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(LoaderInitPropertyValueEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "LoaderInitPropertyValueEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(LoaderInitPropertyValueEXT), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(LoaderInitPropertyValueEXT), Is.EqualTo(8));
        }
    }
}
