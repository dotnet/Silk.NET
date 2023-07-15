// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Debug"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11DebugTest()
    {
        Assert.That(IID_ID3D11Debug, Is.EqualTo(new Guid(0x79cf2233, 0x7536, 0x4948, 0x9d, 0x36, 0x1e, 0x46, 0x92, 0xdc, 0x57, 0x60)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11SwitchToRef"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11SwitchToRefTest()
    {
        Assert.That(IID_ID3D11SwitchToRef, Is.EqualTo(new Guid(0x1ef337e3, 0x58e7, 0x4f83, 0xa6, 0x92, 0xdb, 0x22, 0x1f, 0x5e, 0xd4, 0x7e)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11TracingDevice"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11TracingDeviceTest()
    {
        Assert.That(IID_ID3D11TracingDevice, Is.EqualTo(new Guid(0x1911c771, 0x1587, 0x413e, 0xa7, 0xe0, 0xfb, 0x26, 0xc3, 0xde, 0x02, 0x68)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11RefTrackingOptions"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11RefTrackingOptionsTest()
    {
        Assert.That(IID_ID3D11RefTrackingOptions, Is.EqualTo(new Guid(0x193dacdf, 0x0db2, 0x4c05, 0xa5, 0x5c, 0xef, 0x06, 0xca, 0xc5, 0x6f, 0xd9)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11RefDefaultTrackingOptions"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11RefDefaultTrackingOptionsTest()
    {
        Assert.That(IID_ID3D11RefDefaultTrackingOptions, Is.EqualTo(new Guid(0x03916615, 0xc644, 0x418c, 0x9b, 0xf4, 0x75, 0xdb, 0x5b, 0xe6, 0x3c, 0xa0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11InfoQueue"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11InfoQueueTest()
    {
        Assert.That(IID_ID3D11InfoQueue, Is.EqualTo(new Guid(0x6543dbb6, 0x1b48, 0x42f5, 0xab, 0x82, 0xe9, 0x7e, 0xc7, 0x43, 0x26, 0xf6)));
    }
}