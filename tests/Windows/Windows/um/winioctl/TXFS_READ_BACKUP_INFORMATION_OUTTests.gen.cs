// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TXFS_READ_BACKUP_INFORMATION_OUT"/> struct.</summary>
public static unsafe partial class TXFS_READ_BACKUP_INFORMATION_OUTTests
{
    /// <summary>Validates that the <see cref = "TXFS_READ_BACKUP_INFORMATION_OUT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TXFS_READ_BACKUP_INFORMATION_OUT>(), Is.EqualTo(sizeof(TXFS_READ_BACKUP_INFORMATION_OUT)));
    }

    /// <summary>Validates that the <see cref = "TXFS_READ_BACKUP_INFORMATION_OUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TXFS_READ_BACKUP_INFORMATION_OUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TXFS_READ_BACKUP_INFORMATION_OUT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TXFS_READ_BACKUP_INFORMATION_OUT), Is.EqualTo(4));
    }
}