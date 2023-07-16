// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "KERB_NET_ADDRESS"/> struct.</summary>
public static unsafe partial class KERB_NET_ADDRESSTests
{
    /// <summary>Validates that the <see cref = "KERB_NET_ADDRESS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<KERB_NET_ADDRESS>(), Is.EqualTo(sizeof(KERB_NET_ADDRESS)));
    }

    /// <summary>Validates that the <see cref = "KERB_NET_ADDRESS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KERB_NET_ADDRESS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "KERB_NET_ADDRESS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(KERB_NET_ADDRESS), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(KERB_NET_ADDRESS), Is.EqualTo(12));
        }
    }
}