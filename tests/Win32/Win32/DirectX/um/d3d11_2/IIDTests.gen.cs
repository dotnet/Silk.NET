// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D11DeviceContext2"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11DeviceContext2Test()
    {
        Assert.That(
            IID_ID3D11DeviceContext2,
            Is.EqualTo(
                new Guid(0x420d5b32, 0xb90c, 0x4da4, 0xbe, 0xf0, 0x35, 0x9f, 0x6a, 0x24, 0xa8, 0x3a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D11Device2"/> property is correct.</summary>

    [Test]
    public static void IID_ID3D11Device2Test()
    {
        Assert.That(
            IID_ID3D11Device2,
            Is.EqualTo(
                new Guid(0x9d06dffa, 0xd1e5, 0x4d07, 0x83, 0xa8, 0x1b, 0xb1, 0x23, 0xf2, 0xf8, 0x41)
            )
        );
    }
}
