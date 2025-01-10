// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.DirectX.D3DKEYEXCHANGE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3DKEYEXCHANGE"/> class.</summary>
public static partial class D3DKEYEXCHANGETests
{
    /// <summary>Validates that the value of the <see cref = "D3DKEYEXCHANGE_RSAES_OAEP"/> property is correct.</summary>

    [Test]
    public static void D3DKEYEXCHANGE_RSAES_OAEPTest()
    {
        Assert.That(
            D3DKEYEXCHANGE_RSAES_OAEP,
            Is.EqualTo(
                new Guid(0xc1949895, 0xd72a, 0x4a1d, 0x8e, 0x5d, 0xed, 0x85, 0x7d, 0x17, 0x15, 0x20)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DKEYEXCHANGE_DXVA"/> property is correct.</summary>

    [Test]
    public static void D3DKEYEXCHANGE_DXVATest()
    {
        Assert.That(
            D3DKEYEXCHANGE_DXVA,
            Is.EqualTo(
                new Guid(0x43d3775c, 0x38e5, 0x4924, 0x8d, 0x86, 0xd3, 0xfc, 0xcf, 0x15, 0x3e, 0x9b)
            )
        );
    }
}
