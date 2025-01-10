// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_MSAAControl"/> property is correct.</summary>

    [Test]
    public static void CLSID_MSAAControlTest()
    {
        Assert.That(
            CLSID_MSAAControl,
            Is.EqualTo(
                new Guid(0x08cd963f, 0x7a3e, 0x4f5c, 0x9b, 0xd8, 0xd6, 0x92, 0xbb, 0x04, 0x3c, 0x5b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AccStore"/> property is correct.</summary>

    [Test]
    public static void CLSID_AccStoreTest()
    {
        Assert.That(
            CLSID_AccStore,
            Is.EqualTo(
                new Guid(0x5440837F, 0x4BFF, 0x4AE5, 0xA1, 0xB1, 0x77, 0x22, 0xEC, 0xC6, 0x33, 0x2A)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AccDictionary"/> property is correct.</summary>

    [Test]
    public static void CLSID_AccDictionaryTest()
    {
        Assert.That(
            CLSID_AccDictionary,
            Is.EqualTo(
                new Guid(0x6572EE16, 0x5FE5, 0x4331, 0xBB, 0x6D, 0x76, 0xA4, 0x9C, 0x56, 0xE4, 0x23)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AccServerDocMgr"/> property is correct.</summary>

    [Test]
    public static void CLSID_AccServerDocMgrTest()
    {
        Assert.That(
            CLSID_AccServerDocMgr,
            Is.EqualTo(
                new Guid(0x6089A37E, 0xEB8A, 0x482D, 0xBD, 0x6F, 0xF9, 0xF4, 0x69, 0x04, 0xD1, 0x6D)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AccClientDocMgr"/> property is correct.</summary>

    [Test]
    public static void CLSID_AccClientDocMgrTest()
    {
        Assert.That(
            CLSID_AccClientDocMgr,
            Is.EqualTo(
                new Guid(0xFC48CC30, 0x4F3E, 0x4fa1, 0x80, 0x3B, 0xAD, 0x0E, 0x19, 0x6A, 0x83, 0xB1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DocWrap"/> property is correct.</summary>

    [Test]
    public static void CLSID_DocWrapTest()
    {
        Assert.That(
            CLSID_DocWrap,
            Is.EqualTo(
                new Guid(0xBF426F7E, 0x7A5E, 0x44D6, 0x83, 0x0C, 0xA3, 0x90, 0xEA, 0x94, 0x62, 0xA3)
            )
        );
    }
}
