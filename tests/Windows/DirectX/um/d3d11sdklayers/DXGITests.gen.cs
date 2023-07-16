// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.DirectX.DXGI;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DXGI"/> class.</summary>
public static partial class DXGITests
{
    /// <summary>Validates that the value of the <see cref = "DXGI_DEBUG_D3D11"/> property is correct.</summary>
    [Test]
    public static void DXGI_DEBUG_D3D11Test()
    {
        Assert.That(DXGI_DEBUG_D3D11, Is.EqualTo(new Guid(0x4b99317b, 0xac39, 0x4aa6, 0xbb, 0xb, 0xba, 0xa0, 0x47, 0x84, 0x79, 0x8f)));
    }
}