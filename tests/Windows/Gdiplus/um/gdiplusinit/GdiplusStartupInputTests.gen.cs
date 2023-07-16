// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "GdiplusStartupInput"/> struct.</summary>
public static unsafe partial class GdiplusStartupInputTests
{
    /// <summary>Validates that the <see cref = "GdiplusStartupInput"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GdiplusStartupInput>(), Is.EqualTo(sizeof(GdiplusStartupInput)));
    }

    /// <summary>Validates that the <see cref = "GdiplusStartupInput"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GdiplusStartupInput).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GdiplusStartupInput"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(GdiplusStartupInput), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(GdiplusStartupInput), Is.EqualTo(16));
        }
    }
}