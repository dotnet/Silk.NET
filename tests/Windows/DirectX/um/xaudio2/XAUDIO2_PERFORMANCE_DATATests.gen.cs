// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "XAUDIO2_PERFORMANCE_DATA"/> struct.</summary>
public static unsafe partial class XAUDIO2_PERFORMANCE_DATATests
{
    /// <summary>Validates that the <see cref = "XAUDIO2_PERFORMANCE_DATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XAUDIO2_PERFORMANCE_DATA>(), Is.EqualTo(sizeof(XAUDIO2_PERFORMANCE_DATA)));
    }

    /// <summary>Validates that the <see cref = "XAUDIO2_PERFORMANCE_DATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XAUDIO2_PERFORMANCE_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "XAUDIO2_PERFORMANCE_DATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(XAUDIO2_PERFORMANCE_DATA), Is.EqualTo(64));
    }
}