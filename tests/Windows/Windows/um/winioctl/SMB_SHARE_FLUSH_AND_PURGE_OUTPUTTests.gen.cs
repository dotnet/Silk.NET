// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SMB_SHARE_FLUSH_AND_PURGE_OUTPUT"/> struct.</summary>
public static unsafe partial class SMB_SHARE_FLUSH_AND_PURGE_OUTPUTTests
{
    /// <summary>Validates that the <see cref = "SMB_SHARE_FLUSH_AND_PURGE_OUTPUT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SMB_SHARE_FLUSH_AND_PURGE_OUTPUT>(), Is.EqualTo(sizeof(SMB_SHARE_FLUSH_AND_PURGE_OUTPUT)));
    }

    /// <summary>Validates that the <see cref = "SMB_SHARE_FLUSH_AND_PURGE_OUTPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SMB_SHARE_FLUSH_AND_PURGE_OUTPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SMB_SHARE_FLUSH_AND_PURGE_OUTPUT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SMB_SHARE_FLUSH_AND_PURGE_OUTPUT), Is.EqualTo(4));
    }
}