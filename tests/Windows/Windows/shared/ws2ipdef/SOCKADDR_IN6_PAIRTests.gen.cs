// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SOCKADDR_IN6_PAIR"/> struct.</summary>
public static unsafe partial class SOCKADDR_IN6_PAIRTests
{
    /// <summary>Validates that the <see cref = "SOCKADDR_IN6_PAIR"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SOCKADDR_IN6_PAIR>(), Is.EqualTo(sizeof(SOCKADDR_IN6_PAIR)));
    }

    /// <summary>Validates that the <see cref = "SOCKADDR_IN6_PAIR"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SOCKADDR_IN6_PAIR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SOCKADDR_IN6_PAIR"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SOCKADDR_IN6_PAIR), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SOCKADDR_IN6_PAIR), Is.EqualTo(8));
        }
    }
}