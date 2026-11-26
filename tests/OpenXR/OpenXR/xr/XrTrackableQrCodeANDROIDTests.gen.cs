// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "TrackableQrCodeANDROID"/> struct.</summary>
public static unsafe partial class XrTrackableQrCodeANDROIDTests
{
    /// <summary>Validates that the <see cref = "TrackableQrCodeANDROID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<TrackableQrCodeANDROID>(),
            Is.EqualTo(sizeof(TrackableQrCodeANDROID))
        );
    }

    /// <summary>Validates that the <see cref = "TrackableQrCodeANDROID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TrackableQrCodeANDROID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TrackableQrCodeANDROID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TrackableQrCodeANDROID), Is.EqualTo(88));
        }
        else
        {
            Assert.That(sizeof(TrackableQrCodeANDROID), Is.EqualTo(72));
        }
    }
}
