// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IBaseVideoMixer"/> property is correct.</summary>
    [Test]
    public static void IID_IBaseVideoMixerTest()
    {
        Assert.That(IID_IBaseVideoMixer, Is.EqualTo(new Guid(0x61ded640, 0xe912, 0x11ce, 0xa0, 0x99, 0x00, 0xaa, 0x00, 0x47, 0x9a, 0x58)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectDrawVideo"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectDrawVideoTest()
    {
        Assert.That(IID_IDirectDrawVideo, Is.EqualTo(new Guid(0x36d39eb0, 0xdd75, 0x11ce, 0xbf, 0x0e, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IQualProp"/> property is correct.</summary>
    [Test]
    public static void IID_IQualPropTest()
    {
        Assert.That(IID_IQualProp, Is.EqualTo(new Guid(0x1bd0ecb0, 0xf8e2, 0x11ce, 0xaa, 0xc6, 0x00, 0x20, 0xaf, 0x0b, 0x99, 0xa3)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IVPObject"/> property is correct.</summary>
    [Test]
    public static void IID_IVPObjectTest()
    {
        Assert.That(IID_IVPObject, Is.EqualTo(new Guid(0xce292862, 0xfc88, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IVPControl"/> property is correct.</summary>
    [Test]
    public static void IID_IVPControlTest()
    {
        Assert.That(IID_IVPControl, Is.EqualTo(new Guid(0x25df12c1, 0x3de0, 0x11d1, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IVPVBIObject"/> property is correct.</summary>
    [Test]
    public static void IID_IVPVBIObjectTest()
    {
        Assert.That(IID_IVPVBIObject, Is.EqualTo(new Guid(0x814b9802, 0x1c88, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IVPConfig"/> property is correct.</summary>
    [Test]
    public static void IID_IVPConfigTest()
    {
        Assert.That(IID_IVPConfig, Is.EqualTo(new Guid(0xbc29a660, 0x30e3, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IVPNotify"/> property is correct.</summary>
    [Test]
    public static void IID_IVPNotifyTest()
    {
        Assert.That(IID_IVPNotify, Is.EqualTo(new Guid(0xc76794a1, 0xd6c5, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IVPNotify2"/> property is correct.</summary>
    [Test]
    public static void IID_IVPNotify2Test()
    {
        Assert.That(IID_IVPNotify2, Is.EqualTo(new Guid(0xebf47183, 0x8764, 0x11d1, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IVPVBIConfig"/> property is correct.</summary>
    [Test]
    public static void IID_IVPVBIConfigTest()
    {
        Assert.That(IID_IVPVBIConfig, Is.EqualTo(new Guid(0xec529b00, 0x1a1f, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IVPVBINotify"/> property is correct.</summary>
    [Test]
    public static void IID_IVPVBINotifyTest()
    {
        Assert.That(IID_IVPVBINotify, Is.EqualTo(new Guid(0xec529b01, 0x1a1f, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IMixerPinConfig"/> property is correct.</summary>
    [Test]
    public static void IID_IMixerPinConfigTest()
    {
        Assert.That(IID_IMixerPinConfig, Is.EqualTo(new Guid(0x593cdde1, 0x759, 0x11d1, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IMixerPinConfig2"/> property is correct.</summary>
    [Test]
    public static void IID_IMixerPinConfig2Test()
    {
        Assert.That(IID_IMixerPinConfig2, Is.EqualTo(new Guid(0xebf47182, 0x8764, 0x11d1, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDDVideoPortContainer"/> property is correct.</summary>
    [Test]
    public static void IID_IDDVideoPortContainerTest()
    {
        Assert.That(IID_IDDVideoPortContainer, Is.EqualTo(new Guid(0x6C142760, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectDrawKernel"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectDrawKernelTest()
    {
        Assert.That(IID_IDirectDrawKernel, Is.EqualTo(new Guid(0x8D56C120, 0x6A08, 0x11D0, 0x9B, 0x06, 0x00, 0xA0, 0xC9, 0x03, 0xA3, 0xB8)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDirectDrawSurfaceKernel"/> property is correct.</summary>
    [Test]
    public static void IID_IDirectDrawSurfaceKernelTest()
    {
        Assert.That(IID_IDirectDrawSurfaceKernel, Is.EqualTo(new Guid(0x60755DA0, 0x6A40, 0x11D0, 0x9B, 0x06, 0x00, 0xA0, 0xC9, 0x03, 0xA3, 0xB8)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IFullScreenVideo"/> property is correct.</summary>
    [Test]
    public static void IID_IFullScreenVideoTest()
    {
        Assert.That(IID_IFullScreenVideo, Is.EqualTo(new Guid(0xdd1d7110, 0x7836, 0x11cf, 0xbf, 0x47, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IFullScreenVideoEx"/> property is correct.</summary>
    [Test]
    public static void IID_IFullScreenVideoExTest()
    {
        Assert.That(IID_IFullScreenVideoEx, Is.EqualTo(new Guid(0x53479470, 0xf1dd, 0x11cf, 0xbc, 0x42, 0x00, 0xaa, 0x00, 0xac, 0x74, 0xf6)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IAMDirectSound"/> property is correct.</summary>
    [Test]
    public static void IID_IAMDirectSoundTest()
    {
        Assert.That(IID_IAMDirectSound, Is.EqualTo(new Guid(0x546f4260, 0xd53e, 0x11cf, 0xb3, 0xf0, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IMpegAudioDecoder"/> property is correct.</summary>
    [Test]
    public static void IID_IMpegAudioDecoderTest()
    {
        Assert.That(IID_IMpegAudioDecoder, Is.EqualTo(new Guid(0xb45dd570, 0x3c77, 0x11d1, 0xab, 0xe1, 0x00, 0xa0, 0xc9, 0x05, 0xf3, 0x75)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IAMLine21Decoder"/> property is correct.</summary>
    [Test]
    public static void IID_IAMLine21DecoderTest()
    {
        Assert.That(IID_IAMLine21Decoder, Is.EqualTo(new Guid(0x6e8d4a21, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IAMWstDecoder"/> property is correct.</summary>
    [Test]
    public static void IID_IAMWstDecoderTest()
    {
        Assert.That(IID_IAMWstDecoder, Is.EqualTo(new Guid(0xc056de21, 0x75c2, 0x11d3, 0xa1, 0x84, 0x0, 0x10, 0x5a, 0xef, 0x9f, 0x33)));
    }
}