// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.PPM;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PPM"/> class.</summary>
public static partial class PPMTests
{
    /// <summary>Validates that the value of the <see cref = "PPM_PERFSTATE_CHANGE_GUID"/> property is correct.</summary>
    [Test]
    public static void PPM_PERFSTATE_CHANGE_GUIDTest()
    {
        Assert.That(PPM_PERFSTATE_CHANGE_GUID, Is.EqualTo(new Guid(0xa5b32ddd, 0x7f39, 0x4abc, 0xb8, 0x92, 0x90, 0xe, 0x43, 0xb5, 0x9e, 0xbb)));
    }

    /// <summary>Validates that the value of the <see cref = "PPM_PERFSTATE_DOMAIN_CHANGE_GUID"/> property is correct.</summary>
    [Test]
    public static void PPM_PERFSTATE_DOMAIN_CHANGE_GUIDTest()
    {
        Assert.That(PPM_PERFSTATE_DOMAIN_CHANGE_GUID, Is.EqualTo(new Guid(0x995e6b7f, 0xd653, 0x497a, 0xb9, 0x78, 0x36, 0xa3, 0xc, 0x29, 0xbf, 0x1)));
    }

    /// <summary>Validates that the value of the <see cref = "PPM_IDLESTATE_CHANGE_GUID"/> property is correct.</summary>
    [Test]
    public static void PPM_IDLESTATE_CHANGE_GUIDTest()
    {
        Assert.That(PPM_IDLESTATE_CHANGE_GUID, Is.EqualTo(new Guid(0x4838fe4f, 0xf71c, 0x4e51, 0x9e, 0xcc, 0x84, 0x30, 0xa7, 0xac, 0x4c, 0x6c)));
    }

    /// <summary>Validates that the value of the <see cref = "PPM_PERFSTATES_DATA_GUID"/> property is correct.</summary>
    [Test]
    public static void PPM_PERFSTATES_DATA_GUIDTest()
    {
        Assert.That(PPM_PERFSTATES_DATA_GUID, Is.EqualTo(new Guid(0x5708cc20, 0x7d40, 0x4bf4, 0xb4, 0xaa, 0x2b, 0x01, 0x33, 0x8d, 0x01, 0x26)));
    }

    /// <summary>Validates that the value of the <see cref = "PPM_IDLESTATES_DATA_GUID"/> property is correct.</summary>
    [Test]
    public static void PPM_IDLESTATES_DATA_GUIDTest()
    {
        Assert.That(PPM_IDLESTATES_DATA_GUID, Is.EqualTo(new Guid(0xba138e10, 0xe250, 0x4ad7, 0x86, 0x16, 0xcf, 0x1a, 0x7a, 0xd4, 0x10, 0xe7)));
    }

    /// <summary>Validates that the value of the <see cref = "PPM_IDLE_ACCOUNTING_GUID"/> property is correct.</summary>
    [Test]
    public static void PPM_IDLE_ACCOUNTING_GUIDTest()
    {
        Assert.That(PPM_IDLE_ACCOUNTING_GUID, Is.EqualTo(new Guid(0xe2a26f78, 0xae07, 0x4ee0, 0xa3, 0x0f, 0xce, 0x54, 0xf5, 0x5a, 0x94, 0xcd)));
    }

    /// <summary>Validates that the value of the <see cref = "PPM_IDLE_ACCOUNTING_EX_GUID"/> property is correct.</summary>
    [Test]
    public static void PPM_IDLE_ACCOUNTING_EX_GUIDTest()
    {
        Assert.That(PPM_IDLE_ACCOUNTING_EX_GUID, Is.EqualTo(new Guid(0xd67abd39, 0x81f8, 0x4a5e, 0x81, 0x52, 0x72, 0xe3, 0x1e, 0xc9, 0x12, 0xee)));
    }

    /// <summary>Validates that the value of the <see cref = "PPM_THERMALCONSTRAINT_GUID"/> property is correct.</summary>
    [Test]
    public static void PPM_THERMALCONSTRAINT_GUIDTest()
    {
        Assert.That(PPM_THERMALCONSTRAINT_GUID, Is.EqualTo(new Guid(0xa852c2c8, 0x1a4c, 0x423b, 0x8c, 0x2c, 0xf3, 0x0d, 0x82, 0x93, 0x1a, 0x88)));
    }

    /// <summary>Validates that the value of the <see cref = "PPM_PERFMON_PERFSTATE_GUID"/> property is correct.</summary>
    [Test]
    public static void PPM_PERFMON_PERFSTATE_GUIDTest()
    {
        Assert.That(PPM_PERFMON_PERFSTATE_GUID, Is.EqualTo(new Guid(0x7fd18652, 0xcfe, 0x40d2, 0xb0, 0xa1, 0xb, 0x6, 0x6a, 0x87, 0x75, 0x9e)));
    }

    /// <summary>Validates that the value of the <see cref = "PPM_THERMAL_POLICY_CHANGE_GUID"/> property is correct.</summary>
    [Test]
    public static void PPM_THERMAL_POLICY_CHANGE_GUIDTest()
    {
        Assert.That(PPM_THERMAL_POLICY_CHANGE_GUID, Is.EqualTo(new Guid(0x48f377b8, 0x6880, 0x4c7b, 0x8b, 0xdc, 0x38, 0x1, 0x76, 0xc6, 0x65, 0x4d)));
    }
}