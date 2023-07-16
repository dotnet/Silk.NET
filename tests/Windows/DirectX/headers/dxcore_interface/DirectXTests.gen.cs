// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using static Silk.NET.DirectX.DirectX;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DirectX"/> class.</summary>
public static partial class DirectXTests
{
    /// <summary>Validates that the value of the <see cref = "DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICS"/> property is correct.</summary>
    [Test]
    public static void DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICSTest()
    {
        Assert.That(DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICS, Is.EqualTo(new Guid(0x8c47866b, 0x7583, 0x450d, 0xf0, 0xf0, 0x6b, 0xad, 0xa8, 0x95, 0xaf, 0x4b)));
    }

    /// <summary>Validates that the value of the <see cref = "DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICS"/> property is correct.</summary>
    [Test]
    public static void DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICSTest()
    {
        Assert.That(DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICS, Is.EqualTo(new Guid(0x0c9ece4d, 0x2f6e, 0x4f01, 0x8c, 0x96, 0xe8, 0x9e, 0x33, 0x1b, 0x47, 0xb1)));
    }

    /// <summary>Validates that the value of the <see cref = "DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTE"/> property is correct.</summary>
    [Test]
    public static void DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTETest()
    {
        Assert.That(DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTE, Is.EqualTo(new Guid(0x248e2800, 0xa793, 0x4724, 0xab, 0xaa, 0x23, 0xa6, 0xde, 0x1b, 0xe0, 0x90)));
    }
}