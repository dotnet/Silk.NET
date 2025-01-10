// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "TCP_ESTATS_OBS_REC_RW_v0"/> struct.</summary>
public static unsafe partial class TCP_ESTATS_OBS_REC_RW_v0Tests
{
    /// <summary>Validates that the <see cref = "TCP_ESTATS_OBS_REC_RW_v0"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<TCP_ESTATS_OBS_REC_RW_v0>(),
            Is.EqualTo(sizeof(TCP_ESTATS_OBS_REC_RW_v0))
        );
    }

    /// <summary>Validates that the <see cref = "TCP_ESTATS_OBS_REC_RW_v0"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TCP_ESTATS_OBS_REC_RW_v0).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TCP_ESTATS_OBS_REC_RW_v0"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TCP_ESTATS_OBS_REC_RW_v0), Is.EqualTo(1));
    }
}
