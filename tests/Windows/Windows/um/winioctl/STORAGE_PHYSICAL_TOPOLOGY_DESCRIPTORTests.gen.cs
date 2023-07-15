// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTORTests
{
    /// <summary>Validates that the <see cref = "STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR>(), Is.EqualTo(sizeof(STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR)));
    }

    /// <summary>Validates that the <see cref = "STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_PHYSICAL_TOPOLOGY_DESCRIPTOR), Is.EqualTo(56));
    }
}