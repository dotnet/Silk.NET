// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "AM_DVDCOPY_BUSKEY"/> struct.</summary>
public static unsafe partial class AM_DVDCOPY_BUSKEYTests
{
    /// <summary>Validates that the <see cref = "AM_DVDCOPY_BUSKEY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AM_DVDCOPY_BUSKEY>(), Is.EqualTo(sizeof(AM_DVDCOPY_BUSKEY)));
    }

    /// <summary>Validates that the <see cref = "AM_DVDCOPY_BUSKEY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AM_DVDCOPY_BUSKEY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AM_DVDCOPY_BUSKEY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AM_DVDCOPY_BUSKEY), Is.EqualTo(6));
    }
}