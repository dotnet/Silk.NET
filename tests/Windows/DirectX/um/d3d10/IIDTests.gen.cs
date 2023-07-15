// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D10DeviceChild"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10DeviceChildTest()
    {
        Assert.That(IID_ID3D10DeviceChild, Is.EqualTo(new Guid(0x9B7E4C00, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10DepthStencilState"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10DepthStencilStateTest()
    {
        Assert.That(IID_ID3D10DepthStencilState, Is.EqualTo(new Guid(0x2B4B1CC8, 0xA4AD, 0x41f8, 0x83, 0x22, 0xCA, 0x86, 0xFC, 0x3E, 0xC6, 0x75)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10BlendState"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10BlendStateTest()
    {
        Assert.That(IID_ID3D10BlendState, Is.EqualTo(new Guid(0xEDAD8D19, 0x8A35, 0x4d6d, 0x85, 0x66, 0x2E, 0xA2, 0x76, 0xCD, 0xE1, 0x61)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10RasterizerState"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10RasterizerStateTest()
    {
        Assert.That(IID_ID3D10RasterizerState, Is.EqualTo(new Guid(0xA2A07292, 0x89AF, 0x4345, 0xBE, 0x2E, 0xC5, 0x3D, 0x9F, 0xBB, 0x6E, 0x9F)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Resource"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10ResourceTest()
    {
        Assert.That(IID_ID3D10Resource, Is.EqualTo(new Guid(0x9B7E4C01, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Buffer"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10BufferTest()
    {
        Assert.That(IID_ID3D10Buffer, Is.EqualTo(new Guid(0x9B7E4C02, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Texture1D"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10Texture1DTest()
    {
        Assert.That(IID_ID3D10Texture1D, Is.EqualTo(new Guid(0x9B7E4C03, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Texture2D"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10Texture2DTest()
    {
        Assert.That(IID_ID3D10Texture2D, Is.EqualTo(new Guid(0x9B7E4C04, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Texture3D"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10Texture3DTest()
    {
        Assert.That(IID_ID3D10Texture3D, Is.EqualTo(new Guid(0x9B7E4C05, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10View"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10ViewTest()
    {
        Assert.That(IID_ID3D10View, Is.EqualTo(new Guid(0xC902B03F, 0x60A7, 0x49BA, 0x99, 0x36, 0x2A, 0x3A, 0xB3, 0x7A, 0x7E, 0x33)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10ShaderResourceView"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10ShaderResourceViewTest()
    {
        Assert.That(IID_ID3D10ShaderResourceView, Is.EqualTo(new Guid(0x9B7E4C07, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10RenderTargetView"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10RenderTargetViewTest()
    {
        Assert.That(IID_ID3D10RenderTargetView, Is.EqualTo(new Guid(0x9B7E4C08, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10DepthStencilView"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10DepthStencilViewTest()
    {
        Assert.That(IID_ID3D10DepthStencilView, Is.EqualTo(new Guid(0x9B7E4C09, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10VertexShader"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10VertexShaderTest()
    {
        Assert.That(IID_ID3D10VertexShader, Is.EqualTo(new Guid(0x9B7E4C0A, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10GeometryShader"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10GeometryShaderTest()
    {
        Assert.That(IID_ID3D10GeometryShader, Is.EqualTo(new Guid(0x6316BE88, 0x54CD, 0x4040, 0xAB, 0x44, 0x20, 0x46, 0x1B, 0xC8, 0x1F, 0x68)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10PixelShader"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10PixelShaderTest()
    {
        Assert.That(IID_ID3D10PixelShader, Is.EqualTo(new Guid(0x4968B601, 0x9D00, 0x4cde, 0x83, 0x46, 0x8E, 0x7F, 0x67, 0x58, 0x19, 0xB6)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10InputLayout"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10InputLayoutTest()
    {
        Assert.That(IID_ID3D10InputLayout, Is.EqualTo(new Guid(0x9B7E4C0B, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10SamplerState"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10SamplerStateTest()
    {
        Assert.That(IID_ID3D10SamplerState, Is.EqualTo(new Guid(0x9B7E4C0C, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Asynchronous"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10AsynchronousTest()
    {
        Assert.That(IID_ID3D10Asynchronous, Is.EqualTo(new Guid(0x9B7E4C0D, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Query"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10QueryTest()
    {
        Assert.That(IID_ID3D10Query, Is.EqualTo(new Guid(0x9B7E4C0E, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Predicate"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10PredicateTest()
    {
        Assert.That(IID_ID3D10Predicate, Is.EqualTo(new Guid(0x9B7E4C10, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Counter"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10CounterTest()
    {
        Assert.That(IID_ID3D10Counter, Is.EqualTo(new Guid(0x9B7E4C11, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Device"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10DeviceTest()
    {
        Assert.That(IID_ID3D10Device, Is.EqualTo(new Guid(0x9B7E4C0F, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Multithread"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10MultithreadTest()
    {
        Assert.That(IID_ID3D10Multithread, Is.EqualTo(new Guid(0x9B7E4E00, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }
}