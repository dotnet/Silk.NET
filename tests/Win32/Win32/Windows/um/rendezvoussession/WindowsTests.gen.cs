// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "Windows"/> class.</summary>
public static partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref = "DIID_DRendezvousSessionEvents"/> property is correct.</summary>

    [Test]
    public static void DIID_DRendezvousSessionEventsTest()
    {
        Assert.That(
            DIID_DRendezvousSessionEvents,
            Is.EqualTo(
                new Guid(0x3FA19CF8, 0x64C4, 0x4F53, 0xAE, 0x60, 0x63, 0x5B, 0x38, 0x06, 0xEC, 0xA6)
            )
        );
    }
}
