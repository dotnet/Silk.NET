// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SOCKADDR_INET"/> struct.</summary>
public static unsafe partial class SOCKADDR_INETTests
{
    /// <summary>Validates that the <see cref = "SOCKADDR_INET"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SOCKADDR_INET>(), Is.EqualTo(sizeof(SOCKADDR_INET)));
    }

    /// <summary>Validates that the <see cref = "SOCKADDR_INET"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(SOCKADDR_INET).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "SOCKADDR_INET"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SOCKADDR_INET), Is.EqualTo(28));
    }
}
