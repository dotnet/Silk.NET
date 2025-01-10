// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.DirectX.D3DAUTHENTICATEDQUERY;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3DAUTHENTICATEDQUERY"/> class.</summary>
public static partial class D3DAUTHENTICATEDQUERYTests
{
    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_PROTECTION"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_PROTECTIONTest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_PROTECTION,
            Is.EqualTo(
                new Guid(0xa84eb584, 0xc495, 0x48aa, 0xb9, 0x4d, 0x8b, 0xd2, 0xd6, 0xfb, 0xce, 0x5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_CHANNELTYPE"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_CHANNELTYPETest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_CHANNELTYPE,
            Is.EqualTo(
                new Guid(0xbc1b18a5, 0xb1fb, 0x42ab, 0xbd, 0x94, 0xb5, 0x82, 0x8b, 0x4b, 0xf7, 0xbe)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_DEVICEHANDLE"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_DEVICEHANDLETest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_DEVICEHANDLE,
            Is.EqualTo(
                new Guid(0xec1c539d, 0x8cff, 0x4e2a, 0xbc, 0xc4, 0xf5, 0x69, 0x2f, 0x99, 0xf4, 0x80)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_CRYPTOSESSION"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_CRYPTOSESSIONTest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_CRYPTOSESSION,
            Is.EqualTo(
                new Guid(0x2634499e, 0xd018, 0x4d74, 0xac, 0x17, 0x7f, 0x72, 0x40, 0x59, 0x52, 0x8d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_RESTRICTEDSHAREDRESOURCEPROCESSCOUNT"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_RESTRICTEDSHAREDRESOURCEPROCESSCOUNTTest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_RESTRICTEDSHAREDRESOURCEPROCESSCOUNT,
            Is.EqualTo(
                new Guid(0xdb207b3, 0x9450, 0x46a6, 0x82, 0xde, 0x1b, 0x96, 0xd4, 0x4f, 0x9c, 0xf2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_RESTRICTEDSHAREDRESOURCEPROCESS"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_RESTRICTEDSHAREDRESOURCEPROCESSTest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_RESTRICTEDSHAREDRESOURCEPROCESS,
            Is.EqualTo(
                new Guid(0x649bbadb, 0xf0f4, 0x4639, 0xa1, 0x5b, 0x24, 0x39, 0x3f, 0xc3, 0xab, 0xac)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_UNRESTRICTEDPROTECTEDSHAREDRESOURCECOUNT"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_UNRESTRICTEDPROTECTEDSHAREDRESOURCECOUNTTest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_UNRESTRICTEDPROTECTEDSHAREDRESOURCECOUNT,
            Is.EqualTo(
                new Guid(0x12f0bd6, 0xe662, 0x4474, 0xbe, 0xfd, 0xaa, 0x53, 0xe5, 0x14, 0x3c, 0x6d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_OUTPUTIDCOUNT"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_OUTPUTIDCOUNTTest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_OUTPUTIDCOUNT,
            Is.EqualTo(
                new Guid(0x2c042b5e, 0x8c07, 0x46d5, 0xaa, 0xbe, 0x8f, 0x75, 0xcb, 0xad, 0x4c, 0x31)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_OUTPUTID"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_OUTPUTIDTest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_OUTPUTID,
            Is.EqualTo(
                new Guid(0x839ddca3, 0x9b4e, 0x41e4, 0xb0, 0x53, 0x89, 0x2b, 0xd2, 0xa1, 0x1e, 0xe7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_ACCESSIBILITYATTRIBUTES"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_ACCESSIBILITYATTRIBUTESTest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_ACCESSIBILITYATTRIBUTES,
            Is.EqualTo(
                new Guid(0x6214d9d2, 0x432c, 0x4abb, 0x9f, 0xce, 0x21, 0x6e, 0xea, 0x26, 0x9e, 0x3b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_ENCRYPTIONWHENACCESSIBLEGUIDCOUNT"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_ENCRYPTIONWHENACCESSIBLEGUIDCOUNTTest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_ENCRYPTIONWHENACCESSIBLEGUIDCOUNT,
            Is.EqualTo(
                new Guid(0xb30f7066, 0x203c, 0x4b07, 0x93, 0xfc, 0xce, 0xaa, 0xfd, 0x61, 0x24, 0x1e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_ENCRYPTIONWHENACCESSIBLEGUID"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_ENCRYPTIONWHENACCESSIBLEGUIDTest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_ENCRYPTIONWHENACCESSIBLEGUID,
            Is.EqualTo(
                new Guid(0xf83a5958, 0xe986, 0x4bda, 0xbe, 0xb0, 0x41, 0x1f, 0x6a, 0x7a, 0x1, 0xb7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3DAUTHENTICATEDQUERY_CURRENTENCRYPTIONWHENACCESSIBLE"/> property is correct.</summary>

    [Test]
    public static void D3DAUTHENTICATEDQUERY_CURRENTENCRYPTIONWHENACCESSIBLETest()
    {
        Assert.That(
            D3DAUTHENTICATEDQUERY_CURRENTENCRYPTIONWHENACCESSIBLE,
            Is.EqualTo(
                new Guid(0xec1791c7, 0xdad3, 0x4f15, 0x9e, 0xc3, 0xfa, 0xa9, 0x3d, 0x60, 0xd4, 0xf0)
            )
        );
    }
}
