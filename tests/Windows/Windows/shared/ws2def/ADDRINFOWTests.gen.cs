// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ADDRINFOW"/> struct.</summary>
public static unsafe partial class ADDRINFOWTests
{
    /// <summary>Validates that the <see cref = "ADDRINFOW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ADDRINFOW>(), Is.EqualTo(sizeof(ADDRINFOW)));
    }

    /// <summary>Validates that the <see cref = "ADDRINFOW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ADDRINFOW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ADDRINFOW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ADDRINFOW), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(ADDRINFOW), Is.EqualTo(32));
        }
    }
}