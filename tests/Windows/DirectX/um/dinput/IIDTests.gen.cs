// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IDirectInputA"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInputATest()
    {
        Assert.That(IID_IDirectInputA, Is.EqualTo(new Guid(0x89521360, 0xAA8A, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInputW"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInputWTest()
    {
        Assert.That(IID_IDirectInputW, Is.EqualTo(new Guid(0x89521361, 0xAA8A, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInput2A"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInput2ATest()
    {
        Assert.That(IID_IDirectInput2A, Is.EqualTo(new Guid(0x5944E662, 0xAA8A, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInput2W"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInput2WTest()
    {
        Assert.That(IID_IDirectInput2W, Is.EqualTo(new Guid(0x5944E663, 0xAA8A, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInput7A"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInput7ATest()
    {
        Assert.That(IID_IDirectInput7A, Is.EqualTo(new Guid(0x9A4CB684, 0x236D, 0x11D3, 0x8E, 0x9D, 0x00, 0xC0, 0x4F, 0x68, 0x44, 0xAE)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInput7W"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInput7WTest()
    {
        Assert.That(IID_IDirectInput7W, Is.EqualTo(new Guid(0x9A4CB685, 0x236D, 0x11D3, 0x8E, 0x9D, 0x00, 0xC0, 0x4F, 0x68, 0x44, 0xAE)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInput8A"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInput8ATest()
    {
        Assert.That(IID_IDirectInput8A, Is.EqualTo(new Guid(0xBF798030, 0x483A, 0x4DA2, 0xAA, 0x99, 0x5D, 0x64, 0xED, 0x36, 0x97, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInput8W"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInput8WTest()
    {
        Assert.That(IID_IDirectInput8W, Is.EqualTo(new Guid(0xBF798031, 0x483A, 0x4DA2, 0xAA, 0x99, 0x5D, 0x64, 0xED, 0x36, 0x97, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInputDeviceA"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInputDeviceATest()
    {
        Assert.That(IID_IDirectInputDeviceA, Is.EqualTo(new Guid(0x5944E680, 0xC92E, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInputDeviceW"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInputDeviceWTest()
    {
        Assert.That(IID_IDirectInputDeviceW, Is.EqualTo(new Guid(0x5944E681, 0xC92E, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInputDevice2A"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInputDevice2ATest()
    {
        Assert.That(IID_IDirectInputDevice2A, Is.EqualTo(new Guid(0x5944E682, 0xC92E, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInputDevice2W"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInputDevice2WTest()
    {
        Assert.That(IID_IDirectInputDevice2W, Is.EqualTo(new Guid(0x5944E683, 0xC92E, 0x11CF, 0xBF, 0xC7, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInputDevice7A"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInputDevice7ATest()
    {
        Assert.That(IID_IDirectInputDevice7A, Is.EqualTo(new Guid(0x57D7C6BC, 0x2356, 0x11D3, 0x8E, 0x9D, 0x00, 0xC0, 0x4F, 0x68, 0x44, 0xAE)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInputDevice7W"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInputDevice7WTest()
    {
        Assert.That(IID_IDirectInputDevice7W, Is.EqualTo(new Guid(0x57D7C6BD, 0x2356, 0x11D3, 0x8E, 0x9D, 0x00, 0xC0, 0x4F, 0x68, 0x44, 0xAE)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInputDevice8A"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInputDevice8ATest()
    {
        Assert.That(IID_IDirectInputDevice8A, Is.EqualTo(new Guid(0x54D41080, 0xDC15, 0x4833, 0xA4, 0x1B, 0x74, 0x8F, 0x73, 0xA3, 0x81, 0x79)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInputDevice8W"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInputDevice8WTest()
    {
        Assert.That(IID_IDirectInputDevice8W, Is.EqualTo(new Guid(0x54D41081, 0xDC15, 0x4833, 0xA4, 0x1B, 0x74, 0x8F, 0x73, 0xA3, 0x81, 0x79)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectInputEffect"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectInputEffectTest()
    {
        Assert.That(IID_IDirectInputEffect, Is.EqualTo(new Guid(0xE7E1F7C0, 0x88D2, 0x11D0, 0x9A, 0xD0, 0x00, 0xA0, 0xC9, 0xA0, 0x6E, 0x35)));
    }
}