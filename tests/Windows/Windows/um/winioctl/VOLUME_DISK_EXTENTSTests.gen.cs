// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "VOLUME_DISK_EXTENTS"/> struct.</summary>
public static unsafe partial class VOLUME_DISK_EXTENTSTests
{
    /// <summary>Validates that the <see cref = "VOLUME_DISK_EXTENTS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VOLUME_DISK_EXTENTS>(), Is.EqualTo(sizeof(VOLUME_DISK_EXTENTS)));
    }

    /// <summary>Validates that the <see cref = "VOLUME_DISK_EXTENTS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VOLUME_DISK_EXTENTS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "VOLUME_DISK_EXTENTS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(VOLUME_DISK_EXTENTS), Is.EqualTo(32));
    }
}