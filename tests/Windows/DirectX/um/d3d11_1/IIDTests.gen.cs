// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D11BlendState1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11BlendState1Test()
    {
        Assert.That(IID_ID3D11BlendState1, Is.EqualTo(new Guid(0xcc86fabe, 0xda55, 0x401d, 0x85, 0xe7, 0xe3, 0xc9, 0xde, 0x28, 0x77, 0xe9)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11RasterizerState1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11RasterizerState1Test()
    {
        Assert.That(IID_ID3D11RasterizerState1, Is.EqualTo(new Guid(0x1217d7a6, 0x5039, 0x418c, 0xb0, 0x42, 0x9c, 0xbe, 0x25, 0x6a, 0xfd, 0x6e)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3DDeviceContextState"/> property is correct.</summary>
    [Test]
    public static void IID_ID3DDeviceContextStateTest()
    {
        Assert.That(IID_ID3DDeviceContextState, Is.EqualTo(new Guid(0x5c1e0d8a, 0x7c23, 0x48f9, 0x8c, 0x59, 0xa9, 0x29, 0x58, 0xce, 0xff, 0x11)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11DeviceContext1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11DeviceContext1Test()
    {
        Assert.That(IID_ID3D11DeviceContext1, Is.EqualTo(new Guid(0xbb2c6faa, 0xb5fb, 0x4082, 0x8e, 0x6b, 0x38, 0x8b, 0x8c, 0xfa, 0x90, 0xe1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11VideoContext1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11VideoContext1Test()
    {
        Assert.That(IID_ID3D11VideoContext1, Is.EqualTo(new Guid(0xA7F026DA, 0xA5F8, 0x4487, 0xA5, 0x64, 0x15, 0xE3, 0x43, 0x57, 0x65, 0x1E)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11VideoDevice1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11VideoDevice1Test()
    {
        Assert.That(IID_ID3D11VideoDevice1, Is.EqualTo(new Guid(0x29DA1D51, 0x1321, 0x4454, 0x80, 0x4B, 0xF5, 0xFC, 0x9F, 0x86, 0x1F, 0x0F)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11VideoProcessorEnumerator1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11VideoProcessorEnumerator1Test()
    {
        Assert.That(IID_ID3D11VideoProcessorEnumerator1, Is.EqualTo(new Guid(0x465217F2, 0x5568, 0x43CF, 0xB5, 0xB9, 0xF6, 0x1D, 0x54, 0x53, 0x1C, 0xA1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Device1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11Device1Test()
    {
        Assert.That(IID_ID3D11Device1, Is.EqualTo(new Guid(0xa04bfb29, 0x08ef, 0x43d6, 0xa4, 0x9c, 0xa9, 0xbd, 0xbd, 0xcb, 0xe6, 0x86)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3DUserDefinedAnnotation"/> property is correct.</summary>
    [Test]
    public static void IID_ID3DUserDefinedAnnotationTest()
    {
        Assert.That(IID_ID3DUserDefinedAnnotation, Is.EqualTo(new Guid(0xb2daad8b, 0x03d4, 0x4dbf, 0x95, 0xeb, 0x32, 0xab, 0x4b, 0x63, 0xd0, 0xab)));
    }
}