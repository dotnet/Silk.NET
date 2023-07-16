// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11on12.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D11On12Device"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11On12DeviceTest()
    {
        Assert.That(IID_ID3D11On12Device, Is.EqualTo(new Guid(0x85611e73, 0x70a9, 0x490e, 0x96, 0x14, 0xa9, 0xe3, 0x02, 0x77, 0x79, 0x04)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11On12Device1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11On12Device1Test()
    {
        Assert.That(IID_ID3D11On12Device1, Is.EqualTo(new Guid(0xbdb64df4, 0xea2f, 0x4c70, 0xb8, 0x61, 0xaa, 0xab, 0x12, 0x58, 0xbb, 0x5d)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11On12Device2"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D11On12Device2Test()
    {
        Assert.That(IID_ID3D11On12Device2, Is.EqualTo(new Guid(0xdc90f331, 0x4740, 0x43fa, 0x86, 0x6e, 0x67, 0xf1, 0x2c, 0xb5, 0x82, 0x23)));
    }
}