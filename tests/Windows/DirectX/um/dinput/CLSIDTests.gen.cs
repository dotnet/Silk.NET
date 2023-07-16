// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_DirectInput"/> property is correct.</summary>
    [Test]
    public static void CLSID_DirectInputTest()
    {
        Assert.That(CLSID_DirectInput, Is.EqualTo(new Guid(0x25E609E0, 0xB259, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DirectInputDevice"/> property is correct.</summary>
    [Test]
    public static void CLSID_DirectInputDeviceTest()
    {
        Assert.That(CLSID_DirectInputDevice, Is.EqualTo(new Guid(0x25E609E1, 0xB259, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DirectInput8"/> property is correct.</summary>
    [Test]
    public static void CLSID_DirectInput8Test()
    {
        Assert.That(CLSID_DirectInput8, Is.EqualTo(new Guid(0x25E609E4, 0xB259, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DirectInputDevice8"/> property is correct.</summary>
    [Test]
    public static void CLSID_DirectInputDevice8Test()
    {
        Assert.That(CLSID_DirectInputDevice8, Is.EqualTo(new Guid(0x25E609E5, 0xB259, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }
}