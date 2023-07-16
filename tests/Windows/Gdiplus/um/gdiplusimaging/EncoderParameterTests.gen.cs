// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "EncoderParameter"/> struct.</summary>
public static unsafe partial class EncoderParameterTests
{
    /// <summary>Validates that the <see cref = "EncoderParameter"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EncoderParameter>(), Is.EqualTo(sizeof(EncoderParameter)));
    }

    /// <summary>Validates that the <see cref = "EncoderParameter"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EncoderParameter).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EncoderParameter"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(EncoderParameter), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(EncoderParameter), Is.EqualTo(28));
        }
    }
}