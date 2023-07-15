// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DISK_GEOMETRY_EX"/> struct.</summary>
public static unsafe partial class DISK_GEOMETRY_EXTests
{
    /// <summary>Validates that the <see cref = "DISK_GEOMETRY_EX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DISK_GEOMETRY_EX>(), Is.EqualTo(sizeof(DISK_GEOMETRY_EX)));
    }

    /// <summary>Validates that the <see cref = "DISK_GEOMETRY_EX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DISK_GEOMETRY_EX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DISK_GEOMETRY_EX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DISK_GEOMETRY_EX), Is.EqualTo(40));
    }
}