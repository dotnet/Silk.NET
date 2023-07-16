// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TXFS_GET_TRANSACTED_VERSION"/> struct.</summary>
public static unsafe partial class TXFS_GET_TRANSACTED_VERSIONTests
{
    /// <summary>Validates that the <see cref = "TXFS_GET_TRANSACTED_VERSION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TXFS_GET_TRANSACTED_VERSION>(), Is.EqualTo(sizeof(TXFS_GET_TRANSACTED_VERSION)));
    }

    /// <summary>Validates that the <see cref = "TXFS_GET_TRANSACTED_VERSION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TXFS_GET_TRANSACTED_VERSION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TXFS_GET_TRANSACTED_VERSION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TXFS_GET_TRANSACTED_VERSION), Is.EqualTo(16));
    }
}