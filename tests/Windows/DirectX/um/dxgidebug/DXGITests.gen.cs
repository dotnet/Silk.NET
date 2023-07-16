// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.DirectX.DXGI;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DXGI"/> class.</summary>
public static partial class DXGITests
{
    /// <summary>Validates that the value of the <see cref = "DXGI_DEBUG_ALL"/> property is correct.</summary>
    [Test]
    public static void DXGI_DEBUG_ALLTest()
    {
        Assert.That(DXGI_DEBUG_ALL, Is.EqualTo(new Guid(0xe48ae283, 0xda80, 0x490b, 0x87, 0xe6, 0x43, 0xe9, 0xa9, 0xcf, 0xda, 0x8)));
    }

    /// <summary>Validates that the value of the <see cref = "DXGI_DEBUG_DX"/> property is correct.</summary>
    [Test]
    public static void DXGI_DEBUG_DXTest()
    {
        Assert.That(DXGI_DEBUG_DX, Is.EqualTo(new Guid(0x35cdd7fc, 0x13b2, 0x421d, 0xa5, 0xd7, 0x7e, 0x44, 0x51, 0x28, 0x7d, 0x64)));
    }

    /// <summary>Validates that the value of the <see cref = "DXGI_DEBUG_DXGI"/> property is correct.</summary>
    [Test]
    public static void DXGI_DEBUG_DXGITest()
    {
        Assert.That(DXGI_DEBUG_DXGI, Is.EqualTo(new Guid(0x25cddaa4, 0xb1c6, 0x47e1, 0xac, 0x3e, 0x98, 0x87, 0x5b, 0x5a, 0x2e, 0x2a)));
    }

    /// <summary>Validates that the value of the <see cref = "DXGI_DEBUG_APP"/> property is correct.</summary>
    [Test]
    public static void DXGI_DEBUG_APPTest()
    {
        Assert.That(DXGI_DEBUG_APP, Is.EqualTo(new Guid(0x6cd6e01, 0x4219, 0x4ebd, 0x87, 0x9, 0x27, 0xed, 0x23, 0x36, 0xc, 0x62)));
    }
}