// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "XAUDIO2_SEND_DESCRIPTOR"/> struct.</summary>
public static unsafe partial class XAUDIO2_SEND_DESCRIPTORTests
{
    /// <summary>Validates that the <see cref = "XAUDIO2_SEND_DESCRIPTOR"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<XAUDIO2_SEND_DESCRIPTOR>(),
            Is.EqualTo(sizeof(XAUDIO2_SEND_DESCRIPTOR))
        );
    }

    /// <summary>Validates that the <see cref = "XAUDIO2_SEND_DESCRIPTOR"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XAUDIO2_SEND_DESCRIPTOR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "XAUDIO2_SEND_DESCRIPTOR"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(XAUDIO2_SEND_DESCRIPTOR), Is.EqualTo(12));
        }
        else
        {
            Assert.That(sizeof(XAUDIO2_SEND_DESCRIPTOR), Is.EqualTo(8));
        }
    }
}
