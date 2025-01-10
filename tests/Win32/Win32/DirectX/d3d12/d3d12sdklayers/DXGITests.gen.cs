// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using NUnit.Framework;
using static Silk.NET.DirectX.DXGI;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DXGI"/> class.</summary>
public static partial class DXGITests
{
    /// <summary>Validates that the value of the <see cref = "DXGI_DEBUG_D3D12"/> property is correct.</summary>

    [Test]
    public static void DXGI_DEBUG_D3D12Test()
    {
        Assert.That(
            DXGI_DEBUG_D3D12,
            Is.EqualTo(
                new Guid(0xcf59a98c, 0xa950, 0x4326, 0x91, 0xef, 0x9b, 0xba, 0xa1, 0x7b, 0xfd, 0x95)
            )
        );
    }
}
