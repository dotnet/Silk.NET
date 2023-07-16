// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.GUID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "GUID"/> class.</summary>
public static partial class GUIDTests
{
    /// <summary>Validates that the value of the <see cref = "GUID_TS_SERVICE_DATAOBJECT"/> property is correct.</summary>
    [Test]
    public static void GUID_TS_SERVICE_DATAOBJECTTest()
    {
        Assert.That(GUID_TS_SERVICE_DATAOBJECT, Is.EqualTo(new Guid(0x6086fbb5, 0xe225, 0x46ce, 0xa7, 0x70, 0xc1, 0xbb, 0xd3, 0xe0, 0x5d, 0x7b)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_TS_SERVICE_ACCESSIBLE"/> property is correct.</summary>
    [Test]
    public static void GUID_TS_SERVICE_ACCESSIBLETest()
    {
        Assert.That(GUID_TS_SERVICE_ACCESSIBLE, Is.EqualTo(new Guid(0xf9786200, 0xa5bf, 0x4a0f, 0x8c, 0x24, 0xfb, 0x16, 0xf5, 0xd1, 0xaa, 0xbb)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_TS_SERVICE_ACTIVEX"/> property is correct.</summary>
    [Test]
    public static void GUID_TS_SERVICE_ACTIVEXTest()
    {
        Assert.That(GUID_TS_SERVICE_ACTIVEX, Is.EqualTo(new Guid(0xea937a50, 0xc9a6, 0x4b7d, 0x89, 0x4a, 0x49, 0xd9, 0x9b, 0x78, 0x48, 0x34)));
    }
}