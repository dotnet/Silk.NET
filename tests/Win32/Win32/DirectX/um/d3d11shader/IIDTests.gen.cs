// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D11ShaderReflectionType"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11ShaderReflectionTypeTest()
    {
        Assert.That(
            IID_ID3D11ShaderReflectionType,
            Is.EqualTo(
                new Guid(0x6e6ffa6a, 0x9bae, 0x4613, 0xa5, 0x1e, 0x91, 0x65, 0x2d, 0x50, 0x8c, 0x21)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11ShaderReflectionVariable"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11ShaderReflectionVariableTest()
    {
        Assert.That(
            IID_ID3D11ShaderReflectionVariable,
            Is.EqualTo(
                new Guid(0x51f23923, 0xf3e5, 0x4bd1, 0x91, 0xcb, 0x60, 0x61, 0x77, 0xd8, 0xdb, 0x4c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11ShaderReflectionConstantBuffer"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11ShaderReflectionConstantBufferTest()
    {
        Assert.That(
            IID_ID3D11ShaderReflectionConstantBuffer,
            Is.EqualTo(
                new Guid(0xeb62d63d, 0x93dd, 0x4318, 0x8a, 0xe8, 0xc6, 0xf8, 0x3a, 0xd3, 0x71, 0xb8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11ShaderReflection"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11ShaderReflectionTest()
    {
        Assert.That(
            IID_ID3D11ShaderReflection,
            Is.EqualTo(
                new Guid(0x8d536ca1, 0x0cca, 0x4956, 0xa8, 0x37, 0x78, 0x69, 0x63, 0x75, 0x55, 0x84)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11LibraryReflection"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11LibraryReflectionTest()
    {
        Assert.That(
            IID_ID3D11LibraryReflection,
            Is.EqualTo(
                new Guid(0x54384f1b, 0x5b3e, 0x4bb7, 0xae, 0x1, 0x60, 0xba, 0x30, 0x97, 0xcb, 0xb6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11FunctionReflection"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11FunctionReflectionTest()
    {
        Assert.That(
            IID_ID3D11FunctionReflection,
            Is.EqualTo(
                new Guid(0x207bcecb, 0xd683, 0x4a06, 0xa8, 0xa3, 0x9b, 0x14, 0x9b, 0x9f, 0x73, 0xa4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11FunctionParameterReflection"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11FunctionParameterReflectionTest()
    {
        Assert.That(
            IID_ID3D11FunctionParameterReflection,
            Is.EqualTo(
                new Guid(0x42757488, 0x334f, 0x47fe, 0x98, 0x2e, 0x1a, 0x65, 0xd0, 0x8c, 0xc4, 0x62)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11ModuleInstance"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11ModuleInstanceTest()
    {
        Assert.That(
            IID_ID3D11ModuleInstance,
            Is.EqualTo(
                new Guid(0x469e07f7, 0x45a, 0x48d5, 0xaa, 0x12, 0x68, 0xa4, 0x78, 0xcd, 0xf7, 0x5d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Module"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11ModuleTest()
    {
        Assert.That(
            IID_ID3D11Module,
            Is.EqualTo(
                new Guid(0xcac701ee, 0x80fc, 0x4122, 0x82, 0x42, 0x10, 0xb3, 0x9c, 0x8c, 0xec, 0x34)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Linker"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11LinkerTest()
    {
        Assert.That(
            IID_ID3D11Linker,
            Is.EqualTo(
                new Guid(0x59a6cd0e, 0xe10d, 0x4c1f, 0x88, 0xc0, 0x63, 0xab, 0xa1, 0xda, 0xf3, 0xe)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11LinkingNode"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11LinkingNodeTest()
    {
        Assert.That(
            IID_ID3D11LinkingNode,
            Is.EqualTo(
                new Guid(0xd80dd70c, 0x8d2f, 0x4751, 0x94, 0xa1, 0x3, 0xc7, 0x9b, 0x35, 0x56, 0xdb)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11FunctionLinkingGraph"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11FunctionLinkingGraphTest()
    {
        Assert.That(
            IID_ID3D11FunctionLinkingGraph,
            Is.EqualTo(
                new Guid(0x54133220, 0x1ce8, 0x43d3, 0x82, 0x36, 0x98, 0x55, 0xc5, 0xce, 0xec, 0xff)
            )
        );
    }
}
