// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IDXGIAdapter4"/> property is correct.</summary>
    [Test]
    public static void IID_IDXGIAdapter4Test()
    {
        Assert.That(IID_IDXGIAdapter4, Is.EqualTo(new Guid(0x3c8d99d1, 0x4fbf, 0x4181, 0xa8, 0x2c, 0xaf, 0x66, 0xbf, 0x7b, 0xd2, 0x4e)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIOutput6"/> property is correct.</summary>
    [Test]
    public static void IID_IDXGIOutput6Test()
    {
        Assert.That(IID_IDXGIOutput6, Is.EqualTo(new Guid(0x068346e8, 0xaaec, 0x4b84, 0xad, 0xd7, 0x13, 0x7f, 0x51, 0x3f, 0x77, 0xa1)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIFactory6"/> property is correct.</summary>
    [Test]
    public static void IID_IDXGIFactory6Test()
    {
        Assert.That(IID_IDXGIFactory6, Is.EqualTo(new Guid(0xc1b6694f, 0xff09, 0x44a9, 0xb0, 0x3c, 0x77, 0x90, 0x0a, 0x0a, 0x1d, 0x17)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDXGIFactory7"/> property is correct.</summary>
    [Test]
    public static void IID_IDXGIFactory7Test()
    {
        Assert.That(IID_IDXGIFactory7, Is.EqualTo(new Guid(0xa4966eed, 0x76db, 0x44da, 0x84, 0xc1, 0xee, 0x9a, 0x7a, 0xfb, 0x20, 0xa8)));
    }
}