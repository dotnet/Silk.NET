// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ifmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MIB_IFTABLE"/> struct.</summary>
public static unsafe partial class MIB_IFTABLETests
{
    /// <summary>Validates that the <see cref = "MIB_IFTABLE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIB_IFTABLE>(), Is.EqualTo(sizeof(MIB_IFTABLE)));
    }

    /// <summary>Validates that the <see cref = "MIB_IFTABLE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIB_IFTABLE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MIB_IFTABLE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MIB_IFTABLE), Is.EqualTo(864));
    }
}