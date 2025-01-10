// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.SID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SID"/> struct.</summary>
public static unsafe partial class SIDTests
{
    /// <summary>Validates that the value of the <see cref = "SID_SCommandBarState"/> property is correct.</summary>

    [Test]
    public static void SID_SCommandBarStateTest()
    {
        Assert.That(
            SID_SCommandBarState,
            Is.EqualTo(
                new Guid(0xB99EAA5C, 0x3850, 0x4400, 0xBC, 0x33, 0x2C, 0xE5, 0x34, 0x04, 0x8B, 0xF8)
            )
        );
    }
}
