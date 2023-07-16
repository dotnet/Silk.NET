// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.MFPKEY;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFPKEY"/> class.</summary>
public static partial class MFPKEYTests
{
    /// <summary>Validates that the value of the <see cref = "MFPKEY_CLSID"/> property is correct.</summary>
    [Test]
    public static void MFPKEY_CLSIDTest()
    {
        Assert.That(MFPKEY_CLSID.fmtid, Is.EqualTo(new Guid(0xc57a84c0, 0x1a80, 0x40a3, 0x97, 0xb5, 0x92, 0x72, 0xa4, 0x3, 0xc8, 0xae)));
        Assert.That(MFPKEY_CLSID.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_CATEGORY"/> property is correct.</summary>
    [Test]
    public static void MFPKEY_CATEGORYTest()
    {
        Assert.That(MFPKEY_CATEGORY.fmtid, Is.EqualTo(new Guid(0xc57a84c0, 0x1a80, 0x40a3, 0x97, 0xb5, 0x92, 0x72, 0xa4, 0x3, 0xc8, 0xae)));
        Assert.That(MFPKEY_CATEGORY.pid, Is.EqualTo(0x02));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_EXATTRIBUTE_SUPPORTED"/> property is correct.</summary>
    [Test]
    public static void MFPKEY_EXATTRIBUTE_SUPPORTEDTest()
    {
        Assert.That(MFPKEY_EXATTRIBUTE_SUPPORTED.fmtid, Is.EqualTo(new Guid(0x456fe843, 0x3c87, 0x40c0, 0x94, 0x9d, 0x14, 0x9, 0xc9, 0x7d, 0xab, 0x2c)));
        Assert.That(MFPKEY_EXATTRIBUTE_SUPPORTED.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_MULTICHANNEL_CHANNEL_MASK"/> property is correct.</summary>
    [Test]
    public static void MFPKEY_MULTICHANNEL_CHANNEL_MASKTest()
    {
        Assert.That(MFPKEY_MULTICHANNEL_CHANNEL_MASK.fmtid, Is.EqualTo(new Guid(0x58bdaf8c, 0x3224, 0x4692, 0x86, 0xd0, 0x44, 0xd6, 0x5c, 0x5b, 0xf8, 0x2b)));
        Assert.That(MFPKEY_MULTICHANNEL_CHANNEL_MASK.pid, Is.EqualTo(0x01));
    }
}