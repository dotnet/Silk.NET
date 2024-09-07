// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_D3D12Debug"/> property is correct.</summary>

    [Test]
    public static void CLSID_D3D12DebugTest()
    {
        Assert.That(
            CLSID_D3D12Debug,
            Is.EqualTo(
                new Guid(0xf2352aeb, 0xdd84, 0x49fe, 0xb9, 0x7b, 0xa9, 0xdc, 0xfd, 0xcc, 0x1b, 0x4f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D3D12Tools"/> property is correct.</summary>

    [Test]
    public static void CLSID_D3D12ToolsTest()
    {
        Assert.That(
            CLSID_D3D12Tools,
            Is.EqualTo(
                new Guid(0xe38216b1, 0x3c8c, 0x4833, 0xaa, 0x09, 0x0a, 0x06, 0xb6, 0x5d, 0x96, 0xc8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D3D12DeviceRemovedExtendedData"/> property is correct.</summary>

    [Test]
    public static void CLSID_D3D12DeviceRemovedExtendedDataTest()
    {
        Assert.That(
            CLSID_D3D12DeviceRemovedExtendedData,
            Is.EqualTo(
                new Guid(0x4a75bbc4, 0x9ff4, 0x4ad8, 0x9f, 0x18, 0xab, 0xae, 0x84, 0xdc, 0x5f, 0xf2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D3D12SDKConfiguration"/> property is correct.</summary>

    [Test]
    public static void CLSID_D3D12SDKConfigurationTest()
    {
        Assert.That(
            CLSID_D3D12SDKConfiguration,
            Is.EqualTo(
                new Guid(0x7cda6aca, 0xa03e, 0x49c8, 0x94, 0x58, 0x03, 0x34, 0xd2, 0x0e, 0x07, 0xce)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_D3D12DeviceFactory"/> property is correct.</summary>

    [Test]
    public static void CLSID_D3D12DeviceFactoryTest()
    {
        Assert.That(
            CLSID_D3D12DeviceFactory,
            Is.EqualTo(
                new Guid(0x114863bf, 0xc386, 0x4aee, 0xb3, 0x9d, 0x8f, 0x0b, 0xbb, 0x06, 0x29, 0x55)
            )
        );
    }
}
