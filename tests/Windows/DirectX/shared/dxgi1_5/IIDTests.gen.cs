// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IDXGIOutput5"/> property is correct.</summary>
    [Test]
    public static void IID_IDXGIOutput5Test()
    {
        Assert.That(IID_IDXGIOutput5, Is.EqualTo(new Guid(0x80A07424, 0xAB52, 0x42EB, 0x83, 0x3C, 0x0C, 0x42, 0xFD, 0x28, 0x2D, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGISwapChain4"/> property is correct.</summary>
    [Test]
    public static void IID_IDXGISwapChain4Test()
    {
        Assert.That(IID_IDXGISwapChain4, Is.EqualTo(new Guid(0x3D585D5A, 0xBD4A, 0x489E, 0xB1, 0xF4, 0x3D, 0xBC, 0xB6, 0x45, 0x2F, 0xFB)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIDevice4"/> property is correct.</summary>
    [Test]
    public static void IID_IDXGIDevice4Test()
    {
        Assert.That(IID_IDXGIDevice4, Is.EqualTo(new Guid(0x95B4F95F, 0xD8DA, 0x4CA4, 0x9E, 0xE6, 0x3B, 0x76, 0xD5, 0x96, 0x8A, 0x10)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIFactory5"/> property is correct.</summary>
    [Test]
    public static void IID_IDXGIFactory5Test()
    {
        Assert.That(IID_IDXGIFactory5, Is.EqualTo(new Guid(0x7632e1f5, 0xee65, 0x4dca, 0x87, 0xfd, 0x84, 0xcd, 0x75, 0xf8, 0x83, 0x8d)));
    }
}