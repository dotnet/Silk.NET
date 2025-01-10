// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10misc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.GUID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "GUID"/> class.</summary>
public static partial class GUIDTests
{
    /// <summary>Validates that the value of the <see cref = "GUID_DeviceType"/> property is correct.</summary>

    [Test]
    public static void GUID_DeviceTypeTest()
    {
        Assert.That(
            GUID_DeviceType,
            Is.EqualTo(
                new Guid(0xd722fb4d, 0x7a68, 0x437a, 0xb2, 0x0c, 0x58, 0x04, 0xee, 0x24, 0x94, 0xa6)
            )
        );
    }
}
