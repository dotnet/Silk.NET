// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MPEG2VIDEOINFO"/> struct.</summary>
public static unsafe partial class MPEG2VIDEOINFOTests
{
    /// <summary>Validates that the <see cref = "MPEG2VIDEOINFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MPEG2VIDEOINFO>(), Is.EqualTo(sizeof(MPEG2VIDEOINFO)));
    }

    /// <summary>Validates that the <see cref = "MPEG2VIDEOINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MPEG2VIDEOINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MPEG2VIDEOINFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MPEG2VIDEOINFO), Is.EqualTo(136));
    }
}
