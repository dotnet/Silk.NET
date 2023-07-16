// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IN6_PKTINFO"/> struct.</summary>
public static unsafe partial class IN6_PKTINFOTests
{
    /// <summary>Validates that the <see cref = "IN6_PKTINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IN6_PKTINFO>(), Is.EqualTo(sizeof(IN6_PKTINFO)));
    }

    /// <summary>Validates that the <see cref = "IN6_PKTINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IN6_PKTINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IN6_PKTINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IN6_PKTINFO), Is.EqualTo(20));
    }
}