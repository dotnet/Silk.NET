// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ADDRINFO_DNS_SERVER"/> struct.</summary>
public static unsafe partial class ADDRINFO_DNS_SERVERTests
{
    /// <summary>Validates that the <see cref = "ADDRINFO_DNS_SERVER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ADDRINFO_DNS_SERVER>(), Is.EqualTo(sizeof(ADDRINFO_DNS_SERVER)));
    }

    /// <summary>Validates that the <see cref = "ADDRINFO_DNS_SERVER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ADDRINFO_DNS_SERVER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ADDRINFO_DNS_SERVER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ADDRINFO_DNS_SERVER), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(ADDRINFO_DNS_SERVER), Is.EqualTo(32));
        }
    }
}