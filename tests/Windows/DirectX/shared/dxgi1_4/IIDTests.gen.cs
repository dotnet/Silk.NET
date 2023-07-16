// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IDXGISwapChain3"/> property is correct.</summary>
    [Test]
    public static void IID_IDXGISwapChain3Test()
    {
        Assert.That(IID_IDXGISwapChain3, Is.EqualTo(new Guid(0x94d99bdb, 0xf1f8, 0x4ab0, 0xb2, 0x36, 0x7d, 0xa0, 0x17, 0x0e, 0xda, 0xb1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIOutput4"/> property is correct.</summary>
    [Test]
    public static void IID_IDXGIOutput4Test()
    {
        Assert.That(IID_IDXGIOutput4, Is.EqualTo(new Guid(0xdc7dca35, 0x2196, 0x414d, 0x9F, 0x53, 0x61, 0x78, 0x84, 0x03, 0x2a, 0x60)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIFactory4"/> property is correct.</summary>
    [Test]
    public static void IID_IDXGIFactory4Test()
    {
        Assert.That(IID_IDXGIFactory4, Is.EqualTo(new Guid(0x1bc6ea02, 0xef36, 0x464f, 0xbf, 0x0c, 0x21, 0xca, 0x39, 0xe5, 0x16, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIAdapter3"/> property is correct.</summary>
    [Test]
    public static void IID_IDXGIAdapter3Test()
    {
        Assert.That(IID_IDXGIAdapter3, Is.EqualTo(new Guid(0x645967A4, 0x1392, 0x4310, 0xA7, 0x98, 0x80, 0x53, 0xCE, 0x3E, 0x93, 0xFD)));
    }
}