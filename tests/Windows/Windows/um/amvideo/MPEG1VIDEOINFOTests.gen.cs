// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MPEG1VIDEOINFO"/> struct.</summary>
public static unsafe partial class MPEG1VIDEOINFOTests
{
    /// <summary>Validates that the <see cref = "MPEG1VIDEOINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MPEG1VIDEOINFO>(), Is.EqualTo(sizeof(MPEG1VIDEOINFO)));
    }

    /// <summary>Validates that the <see cref = "MPEG1VIDEOINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MPEG1VIDEOINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MPEG1VIDEOINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MPEG1VIDEOINFO), Is.EqualTo(104));
    }
}