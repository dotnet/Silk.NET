// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidclass.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.GUID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "GUID"/> class.</summary>
public static partial class GUIDTests
{
    /// <summary>Validates that the value of the <see cref = "GUID_DEVINTERFACE_HID"/> property is correct.</summary>
    [Test]
    public static void GUID_DEVINTERFACE_HIDTest()
    {
        Assert.That(GUID_DEVINTERFACE_HID, Is.EqualTo(new Guid(0x4D1E55B2, 0xF16F, 0x11CF, 0x88, 0xCB, 0x00, 0x11, 0x11, 0x00, 0x00, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_HID_INTERFACE_NOTIFY"/> property is correct.</summary>
    [Test]
    public static void GUID_HID_INTERFACE_NOTIFYTest()
    {
        Assert.That(GUID_HID_INTERFACE_NOTIFY, Is.EqualTo(new Guid(0x2c4e2e88, 0x25e6, 0x4c33, 0x88, 0x2f, 0x3d, 0x82, 0xe6, 0x07, 0x36, 0x81)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_HID_INTERFACE_HIDPARSE"/> property is correct.</summary>
    [Test]
    public static void GUID_HID_INTERFACE_HIDPARSETest()
    {
        Assert.That(GUID_HID_INTERFACE_HIDPARSE, Is.EqualTo(new Guid(0xf5c315a5, 0x69ac, 0x4bc2, 0x92, 0x79, 0xd0, 0xb6, 0x45, 0x76, 0xf4, 0x4b)));
    }
}