// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "Windows"/> class.</summary>
public static unsafe partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref = "DEVINTERFACE_AUDIO_RENDER"/> property is correct.</summary>
    [Test]
    public static void DEVINTERFACE_AUDIO_RENDERTest()
    {
        Assert.That(DEVINTERFACE_AUDIO_RENDER, Is.EqualTo(new Guid(0xe6327cad, 0xdcec, 0x4949, 0xae, 0x8a, 0x99, 0x1e, 0x97, 0x6a, 0x79, 0xd2)));
    }

    /// <summary>Validates that the value of the <see cref = "DEVINTERFACE_AUDIO_CAPTURE"/> property is correct.</summary>
    [Test]
    public static void DEVINTERFACE_AUDIO_CAPTURETest()
    {
        Assert.That(DEVINTERFACE_AUDIO_CAPTURE, Is.EqualTo(new Guid(0x2eef81be, 0x33fa, 0x4800, 0x96, 0x70, 0x1c, 0xd4, 0x74, 0x97, 0x2c, 0x3f)));
    }

    /// <summary>Validates that the value of the <see cref = "DEVINTERFACE_MIDI_OUTPUT"/> property is correct.</summary>
    [Test]
    public static void DEVINTERFACE_MIDI_OUTPUTTest()
    {
        Assert.That(DEVINTERFACE_MIDI_OUTPUT, Is.EqualTo(new Guid(0x6dc23320, 0xab33, 0x4ce4, 0x80, 0xd4, 0xbb, 0xb3, 0xeb, 0xbf, 0x28, 0x14)));
    }

    /// <summary>Validates that the value of the <see cref = "DEVINTERFACE_MIDI_INPUT"/> property is correct.</summary>
    [Test]
    public static void DEVINTERFACE_MIDI_INPUTTest()
    {
        Assert.That(DEVINTERFACE_MIDI_INPUT, Is.EqualTo(new Guid(0x504be32c, 0xccf6, 0x4d2c, 0xb7, 0x3f, 0x6f, 0x8b, 0x37, 0x47, 0xe2, 0x2b)));
    }
}