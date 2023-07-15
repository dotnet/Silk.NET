// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "SharpenParams"/> struct.</summary>
public static unsafe partial class SharpenParamsTests
{
    /// <summary>Validates that the <see cref = "SharpenParams"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SharpenParams>(), Is.EqualTo(sizeof(SharpenParams)));
    }

    /// <summary>Validates that the <see cref = "SharpenParams"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SharpenParams).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SharpenParams"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SharpenParams), Is.EqualTo(8));
    }
}