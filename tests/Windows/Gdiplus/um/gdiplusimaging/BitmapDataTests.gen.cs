// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "BitmapData"/> struct.</summary>
public static unsafe partial class BitmapDataTests
{
    /// <summary>Validates that the <see cref = "BitmapData"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BitmapData>(), Is.EqualTo(sizeof(BitmapData)));
    }

    /// <summary>Validates that the <see cref = "BitmapData"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BitmapData).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BitmapData"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BitmapData), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(BitmapData), Is.EqualTo(24));
        }
    }
}