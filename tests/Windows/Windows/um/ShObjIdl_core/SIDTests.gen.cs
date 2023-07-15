// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.SID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SID"/> struct.</summary>
public static unsafe partial class SIDTests
{
    /// <summary>Validates that the value of the <see cref = "SID_URLExecutionContext"/> property is correct.</summary>
    [Test]
    public static void SID_URLExecutionContextTest()
    {
        Assert.That(SID_URLExecutionContext, Is.EqualTo(new Guid(0xFB5F8EBC, 0xBBB6, 0x4D10, 0xA4, 0x61, 0x77, 0x72, 0x91, 0xA0, 0x90, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "SID_LaunchSourceViewSizePreference"/> property is correct.</summary>
    [Test]
    public static void SID_LaunchSourceViewSizePreferenceTest()
    {
        Assert.That(SID_LaunchSourceViewSizePreference, Is.EqualTo(new Guid(0x80605492, 0x67d9, 0x414f, 0xaf, 0x89, 0xa1, 0xcd, 0xf1, 0x24, 0x2b, 0xc1)));
    }

    /// <summary>Validates that the value of the <see cref = "SID_LaunchTargetViewSizePreference"/> property is correct.</summary>
    [Test]
    public static void SID_LaunchTargetViewSizePreferenceTest()
    {
        Assert.That(SID_LaunchTargetViewSizePreference, Is.EqualTo(new Guid(0x26db2472, 0xb7b7, 0x406b, 0x97, 0x2, 0x73, 0xa, 0x4e, 0x20, 0xd3, 0xbf)));
    }

    /// <summary>Validates that the value of the <see cref = "SID_LaunchSourceAppUserModelId"/> property is correct.</summary>
    [Test]
    public static void SID_LaunchSourceAppUserModelIdTest()
    {
        Assert.That(SID_LaunchSourceAppUserModelId, Is.EqualTo(new Guid(0x2ce78010, 0x74db, 0x48bc, 0x9c, 0x6a, 0x10, 0xf3, 0x72, 0x49, 0x57, 0x23)));
    }

    /// <summary>Validates that the value of the <see cref = "SID_ShellExecuteNamedPropertyStore"/> property is correct.</summary>
    [Test]
    public static void SID_ShellExecuteNamedPropertyStoreTest()
    {
        Assert.That(SID_ShellExecuteNamedPropertyStore, Is.EqualTo(new Guid(0xeb84ada2, 0x00ff, 0x4992, 0x83, 0x24, 0xed, 0x5c, 0xe0, 0x61, 0xcb, 0x29)));
    }
}