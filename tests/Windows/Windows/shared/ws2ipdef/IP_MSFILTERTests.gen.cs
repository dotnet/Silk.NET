// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IP_MSFILTER"/> struct.</summary>
public static unsafe partial class IP_MSFILTERTests
{
    /// <summary>Validates that the <see cref = "IP_MSFILTER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IP_MSFILTER>(), Is.EqualTo(sizeof(IP_MSFILTER)));
    }

    /// <summary>Validates that the <see cref = "IP_MSFILTER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IP_MSFILTER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IP_MSFILTER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IP_MSFILTER), Is.EqualTo(20));
    }
}