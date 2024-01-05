// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12shader.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D12ShaderReflectionType"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12ShaderReflectionTypeTest()
    {
        Assert.That(
            IID_ID3D12ShaderReflectionType,
            Is.EqualTo(
                new Guid(0xe913c351, 0x783d, 0x48ca, 0xa1, 0xd1, 0x4f, 0x30, 0x62, 0x84, 0xad, 0x56)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12ShaderReflectionVariable"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12ShaderReflectionVariableTest()
    {
        Assert.That(
            IID_ID3D12ShaderReflectionVariable,
            Is.EqualTo(
                new Guid(0x8337a8a6, 0xa216, 0x444a, 0xb2, 0xf4, 0x31, 0x47, 0x33, 0xa7, 0x3a, 0xea)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12ShaderReflectionConstantBuffer"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12ShaderReflectionConstantBufferTest()
    {
        Assert.That(
            IID_ID3D12ShaderReflectionConstantBuffer,
            Is.EqualTo(
                new Guid(0xc59598b4, 0x48b3, 0x4869, 0xb9, 0xb1, 0xb1, 0x61, 0x8b, 0x14, 0xa8, 0xb7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12ShaderReflection"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12ShaderReflectionTest()
    {
        Assert.That(
            IID_ID3D12ShaderReflection,
            Is.EqualTo(
                new Guid(0x5a58797d, 0xa72c, 0x478d, 0x8b, 0xa2, 0xef, 0xc6, 0xb0, 0xef, 0xe8, 0x8e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12LibraryReflection"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12LibraryReflectionTest()
    {
        Assert.That(
            IID_ID3D12LibraryReflection,
            Is.EqualTo(
                new Guid(0x8e349d19, 0x54db, 0x4a56, 0x9d, 0xc9, 0x11, 0x9d, 0x87, 0xbd, 0xb8, 0x4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12FunctionReflection"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12FunctionReflectionTest()
    {
        Assert.That(
            IID_ID3D12FunctionReflection,
            Is.EqualTo(
                new Guid(0x1108795c, 0x2772, 0x4ba9, 0xb2, 0xa8, 0xd4, 0x64, 0xdc, 0x7e, 0x27, 0x99)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D12FunctionParameterReflection"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D12FunctionParameterReflectionTest()
    {
        Assert.That(
            IID_ID3D12FunctionParameterReflection,
            Is.EqualTo(
                new Guid(0xec25f42d, 0x7006, 0x4f2b, 0xb3, 0x3e, 0x2, 0xcc, 0x33, 0x75, 0x73, 0x3f)
            )
        );
    }
}
