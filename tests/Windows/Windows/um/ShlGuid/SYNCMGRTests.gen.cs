// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.SYNCMGR;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SYNCMGR"/> class.</summary>
public static partial class SYNCMGRTests
{
    /// <summary>Validates that the value of the <see cref = "SYNCMGR_OBJECTID_Icon"/> property is correct.</summary>
    [Test]
    public static void SYNCMGR_OBJECTID_IconTest()
    {
        Assert.That(SYNCMGR_OBJECTID_Icon, Is.EqualTo(new Guid(0x6dbc85c3, 0x5d07, 0x4c72, 0xa7, 0x77, 0x7f, 0xec, 0x78, 0x7, 0x2c, 0x6)));
    }

    /// <summary>Validates that the value of the <see cref = "SYNCMGR_OBJECTID_EventStore"/> property is correct.</summary>
    [Test]
    public static void SYNCMGR_OBJECTID_EventStoreTest()
    {
        Assert.That(SYNCMGR_OBJECTID_EventStore, Is.EqualTo(new Guid(0x4bef34b9, 0xa786, 0x4075, 0xba, 0x88, 0xc, 0x2b, 0x9d, 0x89, 0xa9, 0x8f)));
    }

    /// <summary>Validates that the value of the <see cref = "SYNCMGR_OBJECTID_ConflictStore"/> property is correct.</summary>
    [Test]
    public static void SYNCMGR_OBJECTID_ConflictStoreTest()
    {
        Assert.That(SYNCMGR_OBJECTID_ConflictStore, Is.EqualTo(new Guid(0xd78181f4, 0x2389, 0x47e4, 0xa9, 0x60, 0x60, 0xbc, 0xc2, 0xed, 0x93, 0xb)));
    }

    /// <summary>Validates that the value of the <see cref = "SYNCMGR_OBJECTID_BrowseContent"/> property is correct.</summary>
    [Test]
    public static void SYNCMGR_OBJECTID_BrowseContentTest()
    {
        Assert.That(SYNCMGR_OBJECTID_BrowseContent, Is.EqualTo(new Guid(0x57cbb584, 0xe9b4, 0x47ae, 0xa1, 0x20, 0xc4, 0xdf, 0x33, 0x35, 0xde, 0xe2)));
    }

    /// <summary>Validates that the value of the <see cref = "SYNCMGR_OBJECTID_ShowSchedule"/> property is correct.</summary>
    [Test]
    public static void SYNCMGR_OBJECTID_ShowScheduleTest()
    {
        Assert.That(SYNCMGR_OBJECTID_ShowSchedule, Is.EqualTo(new Guid(0xedc6f3e3, 0x8441, 0x4109, 0xad, 0xf3, 0x6c, 0x1c, 0xa0, 0xb7, 0xde, 0x47)));
    }

    /// <summary>Validates that the value of the <see cref = "SYNCMGR_OBJECTID_QueryBeforeActivate"/> property is correct.</summary>
    [Test]
    public static void SYNCMGR_OBJECTID_QueryBeforeActivateTest()
    {
        Assert.That(SYNCMGR_OBJECTID_QueryBeforeActivate, Is.EqualTo(new Guid(0xd882d80b, 0xe7aa, 0x49ed, 0x86, 0xb7, 0xe6, 0xe1, 0xf7, 0x14, 0xcd, 0xfe)));
    }

    /// <summary>Validates that the value of the <see cref = "SYNCMGR_OBJECTID_QueryBeforeDeactivate"/> property is correct.</summary>
    [Test]
    public static void SYNCMGR_OBJECTID_QueryBeforeDeactivateTest()
    {
        Assert.That(SYNCMGR_OBJECTID_QueryBeforeDeactivate, Is.EqualTo(new Guid(0xa0efc282, 0x60e0, 0x460e, 0x93, 0x74, 0xea, 0x88, 0x51, 0x3c, 0xfc, 0x80)));
    }

    /// <summary>Validates that the value of the <see cref = "SYNCMGR_OBJECTID_QueryBeforeEnable"/> property is correct.</summary>
    [Test]
    public static void SYNCMGR_OBJECTID_QueryBeforeEnableTest()
    {
        Assert.That(SYNCMGR_OBJECTID_QueryBeforeEnable, Is.EqualTo(new Guid(0x4cbf7f0, 0x5beb, 0x4de1, 0xbc, 0x90, 0x90, 0x83, 0x45, 0xc4, 0x80, 0xf6)));
    }

    /// <summary>Validates that the value of the <see cref = "SYNCMGR_OBJECTID_QueryBeforeDisable"/> property is correct.</summary>
    [Test]
    public static void SYNCMGR_OBJECTID_QueryBeforeDisableTest()
    {
        Assert.That(SYNCMGR_OBJECTID_QueryBeforeDisable, Is.EqualTo(new Guid(0xbb5f64aa, 0xf004, 0x4eb5, 0x8e, 0x4d, 0x26, 0x75, 0x19, 0x66, 0x34, 0x4c)));
    }

    /// <summary>Validates that the value of the <see cref = "SYNCMGR_OBJECTID_QueryBeforeDelete"/> property is correct.</summary>
    [Test]
    public static void SYNCMGR_OBJECTID_QueryBeforeDeleteTest()
    {
        Assert.That(SYNCMGR_OBJECTID_QueryBeforeDelete, Is.EqualTo(new Guid(0xf76c3397, 0xafb3, 0x45d7, 0xa5, 0x9f, 0x5a, 0x49, 0xe9, 0x5, 0x43, 0x7e)));
    }

    /// <summary>Validates that the value of the <see cref = "SYNCMGR_OBJECTID_EventLinkClick"/> property is correct.</summary>
    [Test]
    public static void SYNCMGR_OBJECTID_EventLinkClickTest()
    {
        Assert.That(SYNCMGR_OBJECTID_EventLinkClick, Is.EqualTo(new Guid(0x2203bdc1, 0x1af1, 0x4082, 0x8c, 0x30, 0x28, 0x39, 0x9f, 0x41, 0x38, 0x4c)));
    }
}