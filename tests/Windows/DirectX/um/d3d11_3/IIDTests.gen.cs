// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Texture2D1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11Texture2D1Test()
    {
        Assert.That(IID_ID3D11Texture2D1, Is.EqualTo(new Guid(0x51218251, 0x1E33, 0x4617, 0x9C, 0xCB, 0x4D, 0x3A, 0x43, 0x67, 0xE7, 0xBB)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Texture3D1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11Texture3D1Test()
    {
        Assert.That(IID_ID3D11Texture3D1, Is.EqualTo(new Guid(0x0C711683, 0x2853, 0x4846, 0x9B, 0xB0, 0xF3, 0xE6, 0x06, 0x39, 0xE4, 0x6A)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11RasterizerState2"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11RasterizerState2Test()
    {
        Assert.That(IID_ID3D11RasterizerState2, Is.EqualTo(new Guid(0x6fbd02fb, 0x209f, 0x46c4, 0xb0, 0x59, 0x2e, 0xd1, 0x55, 0x86, 0xa6, 0xac)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11ShaderResourceView1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11ShaderResourceView1Test()
    {
        Assert.That(IID_ID3D11ShaderResourceView1, Is.EqualTo(new Guid(0x91308b87, 0x9040, 0x411d, 0x8c, 0x67, 0xc3, 0x92, 0x53, 0xce, 0x38, 0x02)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11RenderTargetView1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11RenderTargetView1Test()
    {
        Assert.That(IID_ID3D11RenderTargetView1, Is.EqualTo(new Guid(0xffbe2e23, 0xf011, 0x418a, 0xac, 0x56, 0x5c, 0xee, 0xd7, 0xc5, 0xb9, 0x4b)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11UnorderedAccessView1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11UnorderedAccessView1Test()
    {
        Assert.That(IID_ID3D11UnorderedAccessView1, Is.EqualTo(new Guid(0x7b3b6153, 0xa886, 0x4544, 0xab, 0x37, 0x65, 0x37, 0xc8, 0x50, 0x04, 0x03)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Query1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11Query1Test()
    {
        Assert.That(IID_ID3D11Query1, Is.EqualTo(new Guid(0x631b4766, 0x36dc, 0x461d, 0x8d, 0xb6, 0xc4, 0x7e, 0x13, 0xe6, 0x09, 0x16)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11DeviceContext3"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11DeviceContext3Test()
    {
        Assert.That(IID_ID3D11DeviceContext3, Is.EqualTo(new Guid(0xb4e3c01d, 0xe79e, 0x4637, 0x91, 0xb2, 0x51, 0x0e, 0x9f, 0x4c, 0x9b, 0x8f)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Fence"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11FenceTest()
    {
        Assert.That(IID_ID3D11Fence, Is.EqualTo(new Guid(0xaffde9d1, 0x1df7, 0x4bb7, 0x8a, 0x34, 0x0f, 0x46, 0x25, 0x1d, 0xab, 0x80)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11DeviceContext4"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11DeviceContext4Test()
    {
        Assert.That(IID_ID3D11DeviceContext4, Is.EqualTo(new Guid(0x917600da, 0xf58c, 0x4c33, 0x98, 0xd8, 0x3e, 0x15, 0xb3, 0x90, 0xfa, 0x24)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Device3"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11Device3Test()
    {
        Assert.That(IID_ID3D11Device3, Is.EqualTo(new Guid(0xA05C8C37, 0xD2C6, 0x4732, 0xB3, 0xA0, 0x9C, 0xE0, 0xB0, 0xDC, 0x9A, 0xE6)));
    }
}