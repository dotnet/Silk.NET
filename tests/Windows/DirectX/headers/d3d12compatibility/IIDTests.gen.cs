// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12compatibility.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D12CompatibilityDevice"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D12CompatibilityDeviceTest()
    {
        Assert.That(IID_ID3D12CompatibilityDevice, Is.EqualTo(new Guid(0x8f1c0e3c, 0xfae3, 0x4a82, 0xb0, 0x98, 0xbf, 0xe1, 0x70, 0x82, 0x07, 0xff)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_D3D11On12CreatorID"/> property is correct.</summary>
    [Test]
    public static void IID_D3D11On12CreatorIDTest()
    {
        Assert.That(IID_D3D11On12CreatorID, Is.EqualTo(new Guid(0xedbf5678, 0x2960, 0x4e81, 0x84, 0x29, 0x99, 0xd4, 0xb2, 0x63, 0x0c, 0x4e)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_D3D9On12CreatorID"/> property is correct.</summary>
    [Test]
    public static void IID_D3D9On12CreatorIDTest()
    {
        Assert.That(IID_D3D9On12CreatorID, Is.EqualTo(new Guid(0xfffcbb7f, 0x15d3, 0x42a2, 0x84, 0x1e, 0x9d, 0x8d, 0x32, 0xf3, 0x7d, 0xdd)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_OpenGLOn12CreatorID"/> property is correct.</summary>
    [Test]
    public static void IID_OpenGLOn12CreatorIDTest()
    {
        Assert.That(IID_OpenGLOn12CreatorID, Is.EqualTo(new Guid(0x6bb3cd34, 0x0d19, 0x45ab, 0x97, 0xed, 0xd7, 0x20, 0xba, 0x3d, 0xfc, 0x80)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_OpenCLOn12CreatorID"/> property is correct.</summary>
    [Test]
    public static void IID_OpenCLOn12CreatorIDTest()
    {
        Assert.That(IID_OpenCLOn12CreatorID, Is.EqualTo(new Guid(0x3f76bb74, 0x91b5, 0x4a88, 0xb1, 0x26, 0x20, 0xca, 0x03, 0x31, 0xcd, 0x60)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_DirectMLTensorFlowCreatorID"/> property is correct.</summary>
    [Test]
    public static void IID_DirectMLTensorFlowCreatorIDTest()
    {
        Assert.That(IID_DirectMLTensorFlowCreatorID, Is.EqualTo(new Guid(0xcb7490ac, 0x8a0f, 0x44ec, 0x9b, 0x7b, 0x6f, 0x4c, 0xaf, 0xe8, 0xe9, 0xab)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_DirectMLPyTorchCreatorID"/> property is correct.</summary>
    [Test]
    public static void IID_DirectMLPyTorchCreatorIDTest()
    {
        Assert.That(IID_DirectMLPyTorchCreatorID, Is.EqualTo(new Guid(0xaf029192, 0xfba1, 0x4b05, 0x91, 0x16, 0x23, 0x5e, 0x06, 0x56, 0x03, 0x54)));
    }
}