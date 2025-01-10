// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "Windows"/> class.</summary>
public static partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref = "EVENTCONTEXT_VOLUMESLIDER"/> property is correct.</summary>

    [Test]
    public static void EVENTCONTEXT_VOLUMESLIDERTest()
    {
        Assert.That(
            EVENTCONTEXT_VOLUMESLIDER,
            Is.EqualTo(
                new Guid(0xE2C2E9DE, 0x09B1, 0x4B04, 0x84, 0xE5, 0x07, 0x93, 0x12, 0x25, 0xEE, 0x04)
            )
        );
    }
}
