// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10sdklayers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.DirectX.DXGI;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DXGI"/> class.</summary>
public static partial class DXGITests
{
    /// <summary>Validates that the value of the <see cref = "DXGI_DEBUG_D3D10"/> property is correct.</summary>
    [Test]
    public static void DXGI_DEBUG_D3D10Test()
    {
        Assert.That(DXGI_DEBUG_D3D10, Is.EqualTo(new Guid(0x243b4c52, 0x3606, 0x4d3a, 0x99, 0xd7, 0xa7, 0xe7, 0xb3, 0x3e, 0xd7, 0x6)));
    }
}