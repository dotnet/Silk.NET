// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IP_MCAST_COUNTER_INFO"/> struct.</summary>
public static unsafe partial class IP_MCAST_COUNTER_INFOTests
{
    /// <summary>Validates that the <see cref = "IP_MCAST_COUNTER_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IP_MCAST_COUNTER_INFO>(), Is.EqualTo(sizeof(IP_MCAST_COUNTER_INFO)));
    }

    /// <summary>Validates that the <see cref = "IP_MCAST_COUNTER_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IP_MCAST_COUNTER_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IP_MCAST_COUNTER_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IP_MCAST_COUNTER_INFO), Is.EqualTo(32));
    }
}