// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "AM_PROPERTY_SPHLI"/> struct.</summary>
public static unsafe partial class AM_PROPERTY_SPHLITests
{
    /// <summary>Validates that the <see cref = "AM_PROPERTY_SPHLI"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AM_PROPERTY_SPHLI>(), Is.EqualTo(sizeof(AM_PROPERTY_SPHLI)));
    }

    /// <summary>Validates that the <see cref = "AM_PROPERTY_SPHLI"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AM_PROPERTY_SPHLI).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AM_PROPERTY_SPHLI"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AM_PROPERTY_SPHLI), Is.EqualTo(24));
    }
}