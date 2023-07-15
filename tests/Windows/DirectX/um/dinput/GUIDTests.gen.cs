// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.GUID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "GUID"/> class.</summary>
public static partial class GUIDTests
{
    /// <summary>Validates that the value of the <see cref = "GUID_XAxis"/> property is correct.</summary>
    [Test]
    public static void GUID_XAxisTest()
    {
        Assert.That(GUID_XAxis, Is.EqualTo(new Guid(0xA36D02E0, 0xC9F3, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_YAxis"/> property is correct.</summary>
    [Test]
    public static void GUID_YAxisTest()
    {
        Assert.That(GUID_YAxis, Is.EqualTo(new Guid(0xA36D02E1, 0xC9F3, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ZAxis"/> property is correct.</summary>
    [Test]
    public static void GUID_ZAxisTest()
    {
        Assert.That(GUID_ZAxis, Is.EqualTo(new Guid(0xA36D02E2, 0xC9F3, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_RxAxis"/> property is correct.</summary>
    [Test]
    public static void GUID_RxAxisTest()
    {
        Assert.That(GUID_RxAxis, Is.EqualTo(new Guid(0xA36D02F4, 0xC9F3, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_RyAxis"/> property is correct.</summary>
    [Test]
    public static void GUID_RyAxisTest()
    {
        Assert.That(GUID_RyAxis, Is.EqualTo(new Guid(0xA36D02F5, 0xC9F3, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_RzAxis"/> property is correct.</summary>
    [Test]
    public static void GUID_RzAxisTest()
    {
        Assert.That(GUID_RzAxis, Is.EqualTo(new Guid(0xA36D02E3, 0xC9F3, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_Slider"/> property is correct.</summary>
    [Test]
    public static void GUID_SliderTest()
    {
        Assert.That(GUID_Slider, Is.EqualTo(new Guid(0xA36D02E4, 0xC9F3, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_Button"/> property is correct.</summary>
    [Test]
    public static void GUID_ButtonTest()
    {
        Assert.That(GUID_Button, Is.EqualTo(new Guid(0xA36D02F0, 0xC9F3, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_Key"/> property is correct.</summary>
    [Test]
    public static void GUID_KeyTest()
    {
        Assert.That(GUID_Key, Is.EqualTo(new Guid(0x55728220, 0xD33C, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_POV"/> property is correct.</summary>
    [Test]
    public static void GUID_POVTest()
    {
        Assert.That(GUID_POV, Is.EqualTo(new Guid(0xA36D02F2, 0xC9F3, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_Unknown"/> property is correct.</summary>
    [Test]
    public static void GUID_UnknownTest()
    {
        Assert.That(GUID_Unknown, Is.EqualTo(new Guid(0xA36D02F3, 0xC9F3, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SysMouse"/> property is correct.</summary>
    [Test]
    public static void GUID_SysMouseTest()
    {
        Assert.That(GUID_SysMouse, Is.EqualTo(new Guid(0x6F1D2B60, 0xD5A0, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SysKeyboard"/> property is correct.</summary>
    [Test]
    public static void GUID_SysKeyboardTest()
    {
        Assert.That(GUID_SysKeyboard, Is.EqualTo(new Guid(0x6F1D2B61, 0xD5A0, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_Joystick"/> property is correct.</summary>
    [Test]
    public static void GUID_JoystickTest()
    {
        Assert.That(GUID_Joystick, Is.EqualTo(new Guid(0x6F1D2B70, 0xD5A0, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SysMouseEm"/> property is correct.</summary>
    [Test]
    public static void GUID_SysMouseEmTest()
    {
        Assert.That(GUID_SysMouseEm, Is.EqualTo(new Guid(0x6F1D2B80, 0xD5A0, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SysMouseEm2"/> property is correct.</summary>
    [Test]
    public static void GUID_SysMouseEm2Test()
    {
        Assert.That(GUID_SysMouseEm2, Is.EqualTo(new Guid(0x6F1D2B81, 0xD5A0, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SysKeyboardEm"/> property is correct.</summary>
    [Test]
    public static void GUID_SysKeyboardEmTest()
    {
        Assert.That(GUID_SysKeyboardEm, Is.EqualTo(new Guid(0x6F1D2B82, 0xD5A0, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SysKeyboardEm2"/> property is correct.</summary>
    [Test]
    public static void GUID_SysKeyboardEm2Test()
    {
        Assert.That(GUID_SysKeyboardEm2, Is.EqualTo(new Guid(0x6F1D2B83, 0xD5A0, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_ConstantForce"/> property is correct.</summary>
    [Test]
    public static void GUID_ConstantForceTest()
    {
        Assert.That(GUID_ConstantForce, Is.EqualTo(new Guid(0x13541C20, 0x8E33, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_RampForce"/> property is correct.</summary>
    [Test]
    public static void GUID_RampForceTest()
    {
        Assert.That(GUID_RampForce, Is.EqualTo(new Guid(0x13541C21, 0x8E33, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_Square"/> property is correct.</summary>
    [Test]
    public static void GUID_SquareTest()
    {
        Assert.That(GUID_Square, Is.EqualTo(new Guid(0x13541C22, 0x8E33, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_Sine"/> property is correct.</summary>
    [Test]
    public static void GUID_SineTest()
    {
        Assert.That(GUID_Sine, Is.EqualTo(new Guid(0x13541C23, 0x8E33, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_Triangle"/> property is correct.</summary>
    [Test]
    public static void GUID_TriangleTest()
    {
        Assert.That(GUID_Triangle, Is.EqualTo(new Guid(0x13541C24, 0x8E33, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SawtoothUp"/> property is correct.</summary>
    [Test]
    public static void GUID_SawtoothUpTest()
    {
        Assert.That(GUID_SawtoothUp, Is.EqualTo(new Guid(0x13541C25, 0x8E33, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_SawtoothDown"/> property is correct.</summary>
    [Test]
    public static void GUID_SawtoothDownTest()
    {
        Assert.That(GUID_SawtoothDown, Is.EqualTo(new Guid(0x13541C26, 0x8E33, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_Spring"/> property is correct.</summary>
    [Test]
    public static void GUID_SpringTest()
    {
        Assert.That(GUID_Spring, Is.EqualTo(new Guid(0x13541C27, 0x8E33, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_Damper"/> property is correct.</summary>
    [Test]
    public static void GUID_DamperTest()
    {
        Assert.That(GUID_Damper, Is.EqualTo(new Guid(0x13541C28, 0x8E33, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_Inertia"/> property is correct.</summary>
    [Test]
    public static void GUID_InertiaTest()
    {
        Assert.That(GUID_Inertia, Is.EqualTo(new Guid(0x13541C29, 0x8E33, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_Friction"/> property is correct.</summary>
    [Test]
    public static void GUID_FrictionTest()
    {
        Assert.That(GUID_Friction, Is.EqualTo(new Guid(0x13541C2A, 0x8E33, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_CustomForce"/> property is correct.</summary>
    [Test]
    public static void GUID_CustomForceTest()
    {
        Assert.That(GUID_CustomForce, Is.EqualTo(new Guid(0x13541C2B, 0x8E33, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }
}