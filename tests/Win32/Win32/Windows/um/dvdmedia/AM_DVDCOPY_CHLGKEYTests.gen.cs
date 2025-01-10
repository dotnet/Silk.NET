// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "AM_DVDCOPY_CHLGKEY"/> struct.</summary>
public static unsafe partial class AM_DVDCOPY_CHLGKEYTests
{
    /// <summary>Validates that the <see cref = "AM_DVDCOPY_CHLGKEY"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AM_DVDCOPY_CHLGKEY>(), Is.EqualTo(sizeof(AM_DVDCOPY_CHLGKEY)));
    }

    /// <summary>Validates that the <see cref = "AM_DVDCOPY_CHLGKEY"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AM_DVDCOPY_CHLGKEY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AM_DVDCOPY_CHLGKEY"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AM_DVDCOPY_CHLGKEY), Is.EqualTo(12));
    }
}
