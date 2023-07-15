// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D10ShaderReflectionType"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10ShaderReflectionTypeTest()
    {
        Assert.That(IID_ID3D10ShaderReflectionType, Is.EqualTo(new Guid(0xc530ad7d, 0x9b16, 0x4395, 0xa9, 0x79, 0xba, 0x2e, 0xcf, 0xf8, 0x3a, 0xdd)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10ShaderReflectionVariable"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10ShaderReflectionVariableTest()
    {
        Assert.That(IID_ID3D10ShaderReflectionVariable, Is.EqualTo(new Guid(0x1bf63c95, 0x2650, 0x405d, 0x99, 0xc1, 0x36, 0x36, 0xbd, 0x1d, 0xa0, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10ShaderReflectionConstantBuffer"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10ShaderReflectionConstantBufferTest()
    {
        Assert.That(IID_ID3D10ShaderReflectionConstantBuffer, Is.EqualTo(new Guid(0x66c66a94, 0xdddd, 0x4b62, 0xa6, 0x6a, 0xf0, 0xda, 0x33, 0xc2, 0xb4, 0xd0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10ShaderReflection"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10ShaderReflectionTest()
    {
        Assert.That(IID_ID3D10ShaderReflection, Is.EqualTo(new Guid(0xd40e20b6, 0xf8f7, 0x42ad, 0xab, 0x20, 0x4b, 0xaf, 0x8f, 0x15, 0xdf, 0xaa)));
    }
}