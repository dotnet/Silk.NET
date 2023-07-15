// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "ImageCodecInfo"/> struct.</summary>
public static unsafe partial class ImageCodecInfoTests
{
    /// <summary>Validates that the <see cref = "ImageCodecInfo"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ImageCodecInfo>(), Is.EqualTo(sizeof(ImageCodecInfo)));
    }

    /// <summary>Validates that the <see cref = "ImageCodecInfo"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ImageCodecInfo).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ImageCodecInfo"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ImageCodecInfo), Is.EqualTo(104));
        }
        else
        {
            Assert.That(sizeof(ImageCodecInfo), Is.EqualTo(76));
        }
    }
}