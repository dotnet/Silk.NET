// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "NET_PHYSICAL_LOCATION_LH"/> struct.</summary>
public static unsafe partial class NET_PHYSICAL_LOCATION_LHTests
{
    /// <summary>Validates that the <see cref = "NET_PHYSICAL_LOCATION_LH"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NET_PHYSICAL_LOCATION_LH>(), Is.EqualTo(sizeof(NET_PHYSICAL_LOCATION_LH)));
    }

    /// <summary>Validates that the <see cref = "NET_PHYSICAL_LOCATION_LH"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NET_PHYSICAL_LOCATION_LH).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NET_PHYSICAL_LOCATION_LH"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(NET_PHYSICAL_LOCATION_LH), Is.EqualTo(12));
    }
}