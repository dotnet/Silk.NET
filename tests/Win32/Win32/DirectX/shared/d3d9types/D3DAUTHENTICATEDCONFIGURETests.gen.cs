// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.DirectX.D3DAUTHENTICATEDCONFIGURE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3DAUTHENTICATEDCONFIGURE"/> class.</summary>
public static partial class D3DAUTHENTICATEDCONFIGURETests
{
    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDCONFIGURE_INITIALIZE"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDCONFIGURE_INITIALIZETest()
    {
        Assert.That(
            D3DAUTHENTICATEDCONFIGURE_INITIALIZE,
            Is.EqualTo(
                new Guid(0x6114bdb, 0x3523, 0x470a, 0x8d, 0xca, 0xfb, 0xc2, 0x84, 0x51, 0x54, 0xf0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDCONFIGURE_PROTECTION"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDCONFIGURE_PROTECTIONTest()
    {
        Assert.That(
            D3DAUTHENTICATEDCONFIGURE_PROTECTION,
            Is.EqualTo(
                new Guid(0x50455658, 0x3f47, 0x4362, 0xbf, 0x99, 0xbf, 0xdf, 0xcd, 0xe9, 0xed, 0x29)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDCONFIGURE_CRYPTOSESSION"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDCONFIGURE_CRYPTOSESSIONTest()
    {
        Assert.That(
            D3DAUTHENTICATEDCONFIGURE_CRYPTOSESSION,
            Is.EqualTo(
                new Guid(0x6346cc54, 0x2cfc, 0x4ad4, 0x82, 0x24, 0xd1, 0x58, 0x37, 0xde, 0x77, 0x0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDCONFIGURE_SHAREDRESOURCE"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDCONFIGURE_SHAREDRESOURCETest()
    {
        Assert.That(
            D3DAUTHENTICATEDCONFIGURE_SHAREDRESOURCE,
            Is.EqualTo(
                new Guid(0x772d047, 0x1b40, 0x48e8, 0x9c, 0xa6, 0xb5, 0xf5, 0x10, 0xde, 0x9f, 0x1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDCONFIGURE_ENCRYPTIONWHENACCESSIBLE"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDCONFIGURE_ENCRYPTIONWHENACCESSIBLETest()
    {
        Assert.That(
            D3DAUTHENTICATEDCONFIGURE_ENCRYPTIONWHENACCESSIBLE,
            Is.EqualTo(
                new Guid(0x41fff286, 0x6ae0, 0x4d43, 0x9d, 0x55, 0xa4, 0x6e, 0x9e, 0xfd, 0x15, 0x8a)
            )
        );
    }
}
