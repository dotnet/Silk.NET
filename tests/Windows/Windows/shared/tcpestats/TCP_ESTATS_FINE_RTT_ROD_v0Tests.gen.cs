// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TCP_ESTATS_FINE_RTT_ROD_v0"/> struct.</summary>
public static unsafe partial class TCP_ESTATS_FINE_RTT_ROD_v0Tests
{
    /// <summary>Validates that the <see cref = "TCP_ESTATS_FINE_RTT_ROD_v0"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TCP_ESTATS_FINE_RTT_ROD_v0>(), Is.EqualTo(sizeof(TCP_ESTATS_FINE_RTT_ROD_v0)));
    }

    /// <summary>Validates that the <see cref = "TCP_ESTATS_FINE_RTT_ROD_v0"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TCP_ESTATS_FINE_RTT_ROD_v0).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TCP_ESTATS_FINE_RTT_ROD_v0"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TCP_ESTATS_FINE_RTT_ROD_v0), Is.EqualTo(16));
    }
}