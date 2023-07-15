// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D11DeviceChild"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11DeviceChildTest()
    {
        Assert.That(IID_ID3D11DeviceChild, Is.EqualTo(new Guid(0x1841e5c8, 0x16b0, 0x489b, 0xbc, 0xc8, 0x44, 0xcf, 0xb0, 0xd5, 0xde, 0xae)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11DepthStencilState"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11DepthStencilStateTest()
    {
        Assert.That(IID_ID3D11DepthStencilState, Is.EqualTo(new Guid(0x03823efb, 0x8d8f, 0x4e1c, 0x9a, 0xa2, 0xf6, 0x4b, 0xb2, 0xcb, 0xfd, 0xf1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11BlendState"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11BlendStateTest()
    {
        Assert.That(IID_ID3D11BlendState, Is.EqualTo(new Guid(0x75b68faa, 0x347d, 0x4159, 0x8f, 0x45, 0xa0, 0x64, 0x0f, 0x01, 0xcd, 0x9a)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11RasterizerState"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11RasterizerStateTest()
    {
        Assert.That(IID_ID3D11RasterizerState, Is.EqualTo(new Guid(0x9bb4ab81, 0xab1a, 0x4d8f, 0xb5, 0x06, 0xfc, 0x04, 0x20, 0x0b, 0x6e, 0xe7)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Resource"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11ResourceTest()
    {
        Assert.That(IID_ID3D11Resource, Is.EqualTo(new Guid(0xdc8e63f3, 0xd12b, 0x4952, 0xb4, 0x7b, 0x5e, 0x45, 0x02, 0x6a, 0x86, 0x2d)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Buffer"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11BufferTest()
    {
        Assert.That(IID_ID3D11Buffer, Is.EqualTo(new Guid(0x48570b85, 0xd1ee, 0x4fcd, 0xa2, 0x50, 0xeb, 0x35, 0x07, 0x22, 0xb0, 0x37)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Texture1D"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11Texture1DTest()
    {
        Assert.That(IID_ID3D11Texture1D, Is.EqualTo(new Guid(0xf8fb5c27, 0xc6b3, 0x4f75, 0xa4, 0xc8, 0x43, 0x9a, 0xf2, 0xef, 0x56, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Texture2D"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11Texture2DTest()
    {
        Assert.That(IID_ID3D11Texture2D, Is.EqualTo(new Guid(0x6f15aaf2, 0xd208, 0x4e89, 0x9a, 0xb4, 0x48, 0x95, 0x35, 0xd3, 0x4f, 0x9c)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Texture3D"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11Texture3DTest()
    {
        Assert.That(IID_ID3D11Texture3D, Is.EqualTo(new Guid(0x037e866e, 0xf56d, 0x4357, 0xa8, 0xaf, 0x9d, 0xab, 0xbe, 0x6e, 0x25, 0x0e)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11View"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11ViewTest()
    {
        Assert.That(IID_ID3D11View, Is.EqualTo(new Guid(0x839d1216, 0xbb2e, 0x412b, 0xb7, 0xf4, 0xa9, 0xdb, 0xeb, 0xe0, 0x8e, 0xd1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11ShaderResourceView"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11ShaderResourceViewTest()
    {
        Assert.That(IID_ID3D11ShaderResourceView, Is.EqualTo(new Guid(0xb0e06fe0, 0x8192, 0x4e1a, 0xb1, 0xca, 0x36, 0xd7, 0x41, 0x47, 0x10, 0xb2)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11RenderTargetView"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11RenderTargetViewTest()
    {
        Assert.That(IID_ID3D11RenderTargetView, Is.EqualTo(new Guid(0xdfdba067, 0x0b8d, 0x4865, 0x87, 0x5b, 0xd7, 0xb4, 0x51, 0x6c, 0xc1, 0x64)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11DepthStencilView"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11DepthStencilViewTest()
    {
        Assert.That(IID_ID3D11DepthStencilView, Is.EqualTo(new Guid(0x9fdac92a, 0x1876, 0x48c3, 0xaf, 0xad, 0x25, 0xb9, 0x4f, 0x84, 0xa9, 0xb6)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11UnorderedAccessView"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11UnorderedAccessViewTest()
    {
        Assert.That(IID_ID3D11UnorderedAccessView, Is.EqualTo(new Guid(0x28acf509, 0x7f5c, 0x48f6, 0x86, 0x11, 0xf3, 0x16, 0x01, 0x0a, 0x63, 0x80)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11VertexShader"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11VertexShaderTest()
    {
        Assert.That(IID_ID3D11VertexShader, Is.EqualTo(new Guid(0x3b301d64, 0xd678, 0x4289, 0x88, 0x97, 0x22, 0xf8, 0x92, 0x8b, 0x72, 0xf3)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11HullShader"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11HullShaderTest()
    {
        Assert.That(IID_ID3D11HullShader, Is.EqualTo(new Guid(0x8e5c6061, 0x628a, 0x4c8e, 0x82, 0x64, 0xbb, 0xe4, 0x5c, 0xb3, 0xd5, 0xdd)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11DomainShader"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11DomainShaderTest()
    {
        Assert.That(IID_ID3D11DomainShader, Is.EqualTo(new Guid(0xf582c508, 0x0f36, 0x490c, 0x99, 0x77, 0x31, 0xee, 0xce, 0x26, 0x8c, 0xfa)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11GeometryShader"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11GeometryShaderTest()
    {
        Assert.That(IID_ID3D11GeometryShader, Is.EqualTo(new Guid(0x38325b96, 0xeffb, 0x4022, 0xba, 0x02, 0x2e, 0x79, 0x5b, 0x70, 0x27, 0x5c)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11PixelShader"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11PixelShaderTest()
    {
        Assert.That(IID_ID3D11PixelShader, Is.EqualTo(new Guid(0xea82e40d, 0x51dc, 0x4f33, 0x93, 0xd4, 0xdb, 0x7c, 0x91, 0x25, 0xae, 0x8c)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11ComputeShader"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11ComputeShaderTest()
    {
        Assert.That(IID_ID3D11ComputeShader, Is.EqualTo(new Guid(0x4f5b196e, 0xc2bd, 0x495e, 0xbd, 0x01, 0x1f, 0xde, 0xd3, 0x8e, 0x49, 0x69)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11InputLayout"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11InputLayoutTest()
    {
        Assert.That(IID_ID3D11InputLayout, Is.EqualTo(new Guid(0xe4819ddc, 0x4cf0, 0x4025, 0xbd, 0x26, 0x5d, 0xe8, 0x2a, 0x3e, 0x07, 0xb7)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11SamplerState"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11SamplerStateTest()
    {
        Assert.That(IID_ID3D11SamplerState, Is.EqualTo(new Guid(0xda6fea51, 0x564c, 0x4487, 0x98, 0x10, 0xf0, 0xd0, 0xf9, 0xb4, 0xe3, 0xa5)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Asynchronous"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11AsynchronousTest()
    {
        Assert.That(IID_ID3D11Asynchronous, Is.EqualTo(new Guid(0x4b35d0cd, 0x1e15, 0x4258, 0x9c, 0x98, 0x1b, 0x13, 0x33, 0xf6, 0xdd, 0x3b)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Query"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11QueryTest()
    {
        Assert.That(IID_ID3D11Query, Is.EqualTo(new Guid(0xd6c00747, 0x87b7, 0x425e, 0xb8, 0x4d, 0x44, 0xd1, 0x08, 0x56, 0x0a, 0xfd)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Predicate"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11PredicateTest()
    {
        Assert.That(IID_ID3D11Predicate, Is.EqualTo(new Guid(0x9eb576dd, 0x9f77, 0x4d86, 0x81, 0xaa, 0x8b, 0xab, 0x5f, 0xe4, 0x90, 0xe2)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Counter"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11CounterTest()
    {
        Assert.That(IID_ID3D11Counter, Is.EqualTo(new Guid(0x6e8c49fb, 0xa371, 0x4770, 0xb4, 0x40, 0x29, 0x08, 0x60, 0x22, 0xb7, 0x41)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11ClassInstance"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11ClassInstanceTest()
    {
        Assert.That(IID_ID3D11ClassInstance, Is.EqualTo(new Guid(0xa6cd7faa, 0xb0b7, 0x4a2f, 0x94, 0x36, 0x86, 0x62, 0xa6, 0x57, 0x97, 0xcb)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11ClassLinkage"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11ClassLinkageTest()
    {
        Assert.That(IID_ID3D11ClassLinkage, Is.EqualTo(new Guid(0xddf57cba, 0x9543, 0x46e4, 0xa1, 0x2b, 0xf2, 0x07, 0xa0, 0xfe, 0x7f, 0xed)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11CommandList"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11CommandListTest()
    {
        Assert.That(IID_ID3D11CommandList, Is.EqualTo(new Guid(0xa24bc4d1, 0x769e, 0x43f7, 0x80, 0x13, 0x98, 0xff, 0x56, 0x6c, 0x18, 0xe2)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11DeviceContext"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11DeviceContextTest()
    {
        Assert.That(IID_ID3D11DeviceContext, Is.EqualTo(new Guid(0xc0bfa96c, 0xe089, 0x44fb, 0x8e, 0xaf, 0x26, 0xf8, 0x79, 0x61, 0x90, 0xda)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11VideoDecoder"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11VideoDecoderTest()
    {
        Assert.That(IID_ID3D11VideoDecoder, Is.EqualTo(new Guid(0x3C9C5B51, 0x995D, 0x48d1, 0x9B, 0x8D, 0xFA, 0x5C, 0xAE, 0xDE, 0xD6, 0x5C)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11VideoProcessorEnumerator"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11VideoProcessorEnumeratorTest()
    {
        Assert.That(IID_ID3D11VideoProcessorEnumerator, Is.EqualTo(new Guid(0x31627037, 0x53AB, 0x4200, 0x90, 0x61, 0x05, 0xFA, 0xA9, 0xAB, 0x45, 0xF9)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11VideoProcessor"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11VideoProcessorTest()
    {
        Assert.That(IID_ID3D11VideoProcessor, Is.EqualTo(new Guid(0x1D7B0652, 0x185F, 0x41c6, 0x85, 0xCE, 0x0C, 0x5B, 0xE3, 0xD4, 0xAE, 0x6C)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11AuthenticatedChannel"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11AuthenticatedChannelTest()
    {
        Assert.That(IID_ID3D11AuthenticatedChannel, Is.EqualTo(new Guid(0x3015A308, 0xDCBD, 0x47aa, 0xA7, 0x47, 0x19, 0x24, 0x86, 0xD1, 0x4D, 0x4A)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11CryptoSession"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11CryptoSessionTest()
    {
        Assert.That(IID_ID3D11CryptoSession, Is.EqualTo(new Guid(0x9B32F9AD, 0xBDCC, 0x40a6, 0xA3, 0x9D, 0xD5, 0xC8, 0x65, 0x84, 0x57, 0x20)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11VideoDecoderOutputView"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11VideoDecoderOutputViewTest()
    {
        Assert.That(IID_ID3D11VideoDecoderOutputView, Is.EqualTo(new Guid(0xC2931AEA, 0x2A85, 0x4f20, 0x86, 0x0F, 0xFB, 0xA1, 0xFD, 0x25, 0x6E, 0x18)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11VideoProcessorInputView"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11VideoProcessorInputViewTest()
    {
        Assert.That(IID_ID3D11VideoProcessorInputView, Is.EqualTo(new Guid(0x11EC5A5F, 0x51DC, 0x4945, 0xAB, 0x34, 0x6E, 0x8C, 0x21, 0x30, 0x0E, 0xA5)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11VideoProcessorOutputView"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11VideoProcessorOutputViewTest()
    {
        Assert.That(IID_ID3D11VideoProcessorOutputView, Is.EqualTo(new Guid(0xA048285E, 0x25A9, 0x4527, 0xBD, 0x93, 0xD6, 0x8B, 0x68, 0xC4, 0x42, 0x54)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11VideoContext"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11VideoContextTest()
    {
        Assert.That(IID_ID3D11VideoContext, Is.EqualTo(new Guid(0x61F21C45, 0x3C0E, 0x4a74, 0x9C, 0xEA, 0x67, 0x10, 0x0D, 0x9A, 0xD5, 0xE4)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11VideoDevice"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11VideoDeviceTest()
    {
        Assert.That(IID_ID3D11VideoDevice, Is.EqualTo(new Guid(0x10EC4D5B, 0x975A, 0x4689, 0xB9, 0xE4, 0xD0, 0xAA, 0xC3, 0x0F, 0xE3, 0x33)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Device"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11DeviceTest()
    {
        Assert.That(IID_ID3D11Device, Is.EqualTo(new Guid(0xdb6f6ddb, 0xac77, 0x4e88, 0x82, 0x53, 0x81, 0x9d, 0xf9, 0xbb, 0xf1, 0x40)));
    }
}