// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PACKET_DESCRIPTION"/> struct.</summary>
public static unsafe partial class PACKET_DESCRIPTIONTests
{
    /// <summary>Validates that the <see cref = "PACKET_DESCRIPTION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PACKET_DESCRIPTION>(), Is.EqualTo(sizeof(PACKET_DESCRIPTION)));
    }

    /// <summary>Validates that the <see cref = "PACKET_DESCRIPTION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PACKET_DESCRIPTION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PACKET_DESCRIPTION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PACKET_DESCRIPTION), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(PACKET_DESCRIPTION), Is.EqualTo(20));
        }
    }
}