// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DxcShaderHash"/> struct.</summary>
public static unsafe partial class DxcShaderHashTests
{
    /// <summary>Validates that the <see cref = "DxcShaderHash"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DxcShaderHash>(), Is.EqualTo(sizeof(DxcShaderHash)));
    }

    /// <summary>Validates that the <see cref = "DxcShaderHash"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DxcShaderHash).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DxcShaderHash"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DxcShaderHash), Is.EqualTo(20));
    }
}