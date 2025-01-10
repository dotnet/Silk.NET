// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IDirect3D9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3D9Test()
    {
        Assert.That(
            IID_IDirect3D9,
            Is.EqualTo(
                new Guid(0x81bdcbca, 0x64d4, 0x426d, 0xae, 0x8d, 0xad, 0x1, 0x47, 0xf4, 0x27, 0x5c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DDevice9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DDevice9Test()
    {
        Assert.That(
            IID_IDirect3DDevice9,
            Is.EqualTo(
                new Guid(0xd0223b96, 0xbf7a, 0x43fd, 0x92, 0xbd, 0xa4, 0x3b, 0xd, 0x82, 0xb9, 0xeb)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DResource9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DResource9Test()
    {
        Assert.That(
            IID_IDirect3DResource9,
            Is.EqualTo(
                new Guid(0x5eec05d, 0x8f7d, 0x4362, 0xb9, 0x99, 0xd1, 0xba, 0xf3, 0x57, 0xc7, 0x4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DBaseTexture9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DBaseTexture9Test()
    {
        Assert.That(
            IID_IDirect3DBaseTexture9,
            Is.EqualTo(
                new Guid(0x580ca87e, 0x1d3c, 0x4d54, 0x99, 0x1d, 0xb7, 0xd3, 0xe3, 0xc2, 0x98, 0xce)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DTexture9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DTexture9Test()
    {
        Assert.That(
            IID_IDirect3DTexture9,
            Is.EqualTo(
                new Guid(0x85c31227, 0x3de5, 0x4f00, 0x9b, 0x3a, 0xf1, 0x1a, 0xc3, 0x8c, 0x18, 0xb5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DCubeTexture9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DCubeTexture9Test()
    {
        Assert.That(
            IID_IDirect3DCubeTexture9,
            Is.EqualTo(
                new Guid(0xfff32f81, 0xd953, 0x473a, 0x92, 0x23, 0x93, 0xd6, 0x52, 0xab, 0xa9, 0x3f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DVolumeTexture9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DVolumeTexture9Test()
    {
        Assert.That(
            IID_IDirect3DVolumeTexture9,
            Is.EqualTo(
                new Guid(0x2518526c, 0xe789, 0x4111, 0xa7, 0xb9, 0x47, 0xef, 0x32, 0x8d, 0x13, 0xe6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DVertexBuffer9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DVertexBuffer9Test()
    {
        Assert.That(
            IID_IDirect3DVertexBuffer9,
            Is.EqualTo(
                new Guid(0xb64bb1b5, 0xfd70, 0x4df6, 0xbf, 0x91, 0x19, 0xd0, 0xa1, 0x24, 0x55, 0xe3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DIndexBuffer9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DIndexBuffer9Test()
    {
        Assert.That(
            IID_IDirect3DIndexBuffer9,
            Is.EqualTo(
                new Guid(0x7c9dd65e, 0xd3f7, 0x4529, 0xac, 0xee, 0x78, 0x58, 0x30, 0xac, 0xde, 0x35)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DSurface9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DSurface9Test()
    {
        Assert.That(
            IID_IDirect3DSurface9,
            Is.EqualTo(
                new Guid(0xcfbaf3a, 0x9ff6, 0x429a, 0x99, 0xb3, 0xa2, 0x79, 0x6a, 0xf8, 0xb8, 0x9b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DVolume9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DVolume9Test()
    {
        Assert.That(
            IID_IDirect3DVolume9,
            Is.EqualTo(
                new Guid(0x24f416e6, 0x1f67, 0x4aa7, 0xb8, 0x8e, 0xd3, 0x3f, 0x6f, 0x31, 0x28, 0xa1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DSwapChain9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DSwapChain9Test()
    {
        Assert.That(
            IID_IDirect3DSwapChain9,
            Is.EqualTo(
                new Guid(0x794950f2, 0xadfc, 0x458a, 0x90, 0x5e, 0x10, 0xa1, 0xb, 0xb, 0x50, 0x3b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DVertexDeclaration9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DVertexDeclaration9Test()
    {
        Assert.That(
            IID_IDirect3DVertexDeclaration9,
            Is.EqualTo(
                new Guid(0xdd13c59c, 0x36fa, 0x4098, 0xa8, 0xfb, 0xc7, 0xed, 0x39, 0xdc, 0x85, 0x46)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DVertexShader9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DVertexShader9Test()
    {
        Assert.That(
            IID_IDirect3DVertexShader9,
            Is.EqualTo(
                new Guid(0xefc5557e, 0x6265, 0x4613, 0x8a, 0x94, 0x43, 0x85, 0x78, 0x89, 0xeb, 0x36)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DPixelShader9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DPixelShader9Test()
    {
        Assert.That(
            IID_IDirect3DPixelShader9,
            Is.EqualTo(
                new Guid(0x6d3bdbdc, 0x5b02, 0x4415, 0xb8, 0x52, 0xce, 0x5e, 0x8b, 0xcc, 0xb2, 0x89)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DStateBlock9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DStateBlock9Test()
    {
        Assert.That(
            IID_IDirect3DStateBlock9,
            Is.EqualTo(
                new Guid(0xb07c4fe5, 0x310d, 0x4ba8, 0xa2, 0x3c, 0x4f, 0xf, 0x20, 0x6f, 0x21, 0x8b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DQuery9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DQuery9Test()
    {
        Assert.That(
            IID_IDirect3DQuery9,
            Is.EqualTo(
                new Guid(0xd9771460, 0xa695, 0x4f26, 0xbb, 0xd3, 0x27, 0xb8, 0x40, 0xb5, 0x41, 0xcc)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_HelperName"/> property is correct.</summary>

    [Test]
    public static void IID_HelperNameTest()
    {
        Assert.That(
            IID_HelperName,
            Is.EqualTo(
                new Guid(0xe4a36723, 0xfdfe, 0x4b22, 0xb1, 0x46, 0x3c, 0x4, 0xc0, 0x7f, 0x4c, 0xc8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3D9Ex"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3D9ExTest()
    {
        Assert.That(
            IID_IDirect3D9Ex,
            Is.EqualTo(
                new Guid(0x02177241, 0x69FC, 0x400C, 0x8F, 0xF1, 0x93, 0xA4, 0x4D, 0xF6, 0x86, 0x1D)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DDevice9Ex"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DDevice9ExTest()
    {
        Assert.That(
            IID_IDirect3DDevice9Ex,
            Is.EqualTo(
                new Guid(0xb18b10ce, 0x2649, 0x405a, 0x87, 0xf, 0x95, 0xf7, 0x77, 0xd4, 0x31, 0x3a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DSwapChain9Ex"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DSwapChain9ExTest()
    {
        Assert.That(
            IID_IDirect3DSwapChain9Ex,
            Is.EqualTo(
                new Guid(0x91886caf, 0x1c3d, 0x4d2e, 0xa0, 0xab, 0x3e, 0x4c, 0x7d, 0x8d, 0x33, 0x3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3D9ExOverlayExtension"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3D9ExOverlayExtensionTest()
    {
        Assert.That(
            IID_IDirect3D9ExOverlayExtension,
            Is.EqualTo(
                new Guid(0x187aeb13, 0xaaf5, 0x4c59, 0x87, 0x6d, 0xe0, 0x59, 0x8, 0x8c, 0xd, 0xf8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DDevice9Video"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DDevice9VideoTest()
    {
        Assert.That(
            IID_IDirect3DDevice9Video,
            Is.EqualTo(
                new Guid(0x26dc4561, 0xa1ee, 0x4ae7, 0x96, 0xda, 0x11, 0x8a, 0x36, 0xc0, 0xec, 0x95)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DAuthenticatedChannel9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DAuthenticatedChannel9Test()
    {
        Assert.That(
            IID_IDirect3DAuthenticatedChannel9,
            Is.EqualTo(
                new Guid(0xff24beee, 0xda21, 0x4beb, 0x98, 0xb5, 0xd2, 0xf8, 0x99, 0xf9, 0x8a, 0xf9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirect3DCryptoSession9"/> property is correct.</summary>

    [Test]
    public static void IID_IDirect3DCryptoSession9Test()
    {
        Assert.That(
            IID_IDirect3DCryptoSession9,
            Is.EqualTo(
                new Guid(0xfa0ab799, 0x7a9c, 0x48ca, 0x8c, 0x5b, 0x23, 0x7e, 0x71, 0xa5, 0x44, 0x34)
            )
        );
    }
}
