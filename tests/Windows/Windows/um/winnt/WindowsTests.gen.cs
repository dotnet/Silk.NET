// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.Windows;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "Windows"/> class.</summary>
public static partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref = "NO_SUBGROUP_GUID"/> property is correct.</summary>
    [Test]
    public static void NO_SUBGROUP_GUIDTest()
    {
        Assert.That(NO_SUBGROUP_GUID, Is.EqualTo(new Guid(0xFEA3413E, 0x7E05, 0x4911, 0x9A, 0x71, 0x70, 0x03, 0x31, 0xF1, 0xC2, 0x94)));
    }

    /// <summary>Validates that the value of the <see cref = "ALL_POWERSCHEMES_GUID"/> property is correct.</summary>
    [Test]
    public static void ALL_POWERSCHEMES_GUIDTest()
    {
        Assert.That(ALL_POWERSCHEMES_GUID, Is.EqualTo(new Guid(0x68A1E95E, 0x13EA, 0x41E1, 0x80, 0x11, 0x0C, 0x49, 0x6C, 0xA4, 0x90, 0xB0)));
    }
}