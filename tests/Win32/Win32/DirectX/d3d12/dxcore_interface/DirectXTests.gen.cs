// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using NUnit.Framework;
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DirectX"/> class.</summary>
public static partial class DirectXTests
{
    /// <summary>Validates that the value of the <see cref = "DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICS"/> property is correct.</summary>

    [Test]
    public static void DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICSTest()
    {
        Assert.That(
            DXCORE_ADAPTER_ATTRIBUTE_D3D11_GRAPHICS,
            Is.EqualTo(
                new Guid(0x8c47866b, 0x7583, 0x450d, 0xf0, 0xf0, 0x6b, 0xad, 0xa8, 0x95, 0xaf, 0x4b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICS"/> property is correct.</summary>

    [Test]
    public static void DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICSTest()
    {
        Assert.That(
            DXCORE_ADAPTER_ATTRIBUTE_D3D12_GRAPHICS,
            Is.EqualTo(
                new Guid(0x0c9ece4d, 0x2f6e, 0x4f01, 0x8c, 0x96, 0xe8, 0x9e, 0x33, 0x1b, 0x47, 0xb1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTE"/> property is correct.</summary>

    [Test]
    public static void DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTETest()
    {
        Assert.That(
            DXCORE_ADAPTER_ATTRIBUTE_D3D12_CORE_COMPUTE,
            Is.EqualTo(
                new Guid(0x248e2800, 0xa793, 0x4724, 0xab, 0xaa, 0x23, 0xa6, 0xde, 0x1b, 0xe0, 0x90)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DXCORE_ADAPTER_ATTRIBUTE_D3D12_GENERIC_ML"/> property is correct.</summary>

    [Test]
    public static void DXCORE_ADAPTER_ATTRIBUTE_D3D12_GENERIC_MLTest()
    {
        Assert.That(
            DXCORE_ADAPTER_ATTRIBUTE_D3D12_GENERIC_ML,
            Is.EqualTo(
                new Guid(0xb71b0d41, 0x1088, 0x422f, 0xa2, 0x7c, 0x2, 0x50, 0xb7, 0xd3, 0xa9, 0x88)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DXCORE_ADAPTER_ATTRIBUTE_D3D12_GENERIC_MEDIA"/> property is correct.</summary>

    [Test]
    public static void DXCORE_ADAPTER_ATTRIBUTE_D3D12_GENERIC_MEDIATest()
    {
        Assert.That(
            DXCORE_ADAPTER_ATTRIBUTE_D3D12_GENERIC_MEDIA,
            Is.EqualTo(
                new Guid(0x8eb2c848, 0x82f6, 0x4b49, 0xaa, 0x87, 0xae, 0xcf, 0xcf, 0x1, 0x74, 0xc6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DXCORE_HARDWARE_TYPE_ATTRIBUTE_GPU"/> property is correct.</summary>

    [Test]
    public static void DXCORE_HARDWARE_TYPE_ATTRIBUTE_GPUTest()
    {
        Assert.That(
            DXCORE_HARDWARE_TYPE_ATTRIBUTE_GPU,
            Is.EqualTo(
                new Guid(0xb69eb219, 0x3ded, 0x4464, 0x97, 0x9f, 0xa0, 0xb, 0xd4, 0x68, 0x70, 0x6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DXCORE_HARDWARE_TYPE_ATTRIBUTE_COMPUTE_ACCELERATOR"/> property is correct.</summary>

    [Test]
    public static void DXCORE_HARDWARE_TYPE_ATTRIBUTE_COMPUTE_ACCELERATORTest()
    {
        Assert.That(
            DXCORE_HARDWARE_TYPE_ATTRIBUTE_COMPUTE_ACCELERATOR,
            Is.EqualTo(
                new Guid(0xe0b195da, 0x58ef, 0x4a22, 0x90, 0xf1, 0x1f, 0x28, 0x16, 0x9c, 0xab, 0x8d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DXCORE_HARDWARE_TYPE_ATTRIBUTE_NPU"/> property is correct.</summary>

    [Test]
    public static void DXCORE_HARDWARE_TYPE_ATTRIBUTE_NPUTest()
    {
        Assert.That(
            DXCORE_HARDWARE_TYPE_ATTRIBUTE_NPU,
            Is.EqualTo(
                new Guid(0xd46140c4, 0xadd7, 0x451b, 0x9e, 0x56, 0x6, 0xfe, 0x8c, 0x3b, 0x58, 0xed)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DXCORE_HARDWARE_TYPE_ATTRIBUTE_MEDIA_ACCELERATOR"/> property is correct.</summary>

    [Test]
    public static void DXCORE_HARDWARE_TYPE_ATTRIBUTE_MEDIA_ACCELERATORTest()
    {
        Assert.That(
            DXCORE_HARDWARE_TYPE_ATTRIBUTE_MEDIA_ACCELERATOR,
            Is.EqualTo(
                new Guid(0x66bdb96a, 0x50b, 0x44c7, 0xa4, 0xfd, 0xd1, 0x44, 0xce, 0xa, 0xb4, 0x43)
            )
        );
    }
}
