// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DxcBuffer"/> struct.</summary>
public static unsafe partial class DxcBufferTests
{
    /// <summary>Validates that the <see cref = "DxcBuffer"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxcBuffer>(), Is.EqualTo(sizeof(DxcBuffer)));
    }

    /// <summary>Validates that the <see cref = "DxcBuffer"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxcBuffer).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxcBuffer"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DxcBuffer), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(DxcBuffer), Is.EqualTo(12));
        }
    }
}