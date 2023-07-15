// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DirectX"/> class.</summary>
public static unsafe partial class DirectXTests
{
    /// <summary>Validates that the value of the <see cref = "D3D12ExperimentalShaderModels"/> property is correct.</summary>
    [Test]
    public static void D3D12ExperimentalShaderModelsTest()
    {
        Assert.That(D3D12ExperimentalShaderModels, Is.EqualTo(new Guid(0x76f5573e, 0xf13a, 0x40f5, 0xb2, 0x97, 0x81, 0xce, 0x9e, 0x18, 0x93, 0x3f)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12TiledResourceTier4"/> property is correct.</summary>
    [Test]
    public static void D3D12TiledResourceTier4Test()
    {
        Assert.That(D3D12TiledResourceTier4, Is.EqualTo(new Guid(0xc9c4725f, 0xa81a, 0x4f56, 0x8c, 0x5b, 0xc5, 0x10, 0x39, 0xd6, 0x94, 0xfb)));
    }
}