// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.MEDIATYPE;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MEDIATYPE"/> class.</summary>
public static partial class MEDIATYPETests
{
    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_Video"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_VideoTest()
    {
        Assert.That(MEDIATYPE_Video, Is.EqualTo(new Guid(0x73646976, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_Audio"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_AudioTest()
    {
        Assert.That(MEDIATYPE_Audio, Is.EqualTo(new Guid(0x73647561, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_Text"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_TextTest()
    {
        Assert.That(MEDIATYPE_Text, Is.EqualTo(new Guid(0x73747874, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_Midi"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_MidiTest()
    {
        Assert.That(MEDIATYPE_Midi, Is.EqualTo(new Guid(0x7364696D, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_Stream"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_StreamTest()
    {
        Assert.That(MEDIATYPE_Stream, Is.EqualTo(new Guid(0xe436eb83, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_Interleaved"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_InterleavedTest()
    {
        Assert.That(MEDIATYPE_Interleaved, Is.EqualTo(new Guid(0x73766169, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_File"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_FileTest()
    {
        Assert.That(MEDIATYPE_File, Is.EqualTo(new Guid(0x656c6966, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_ScriptCommand"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_ScriptCommandTest()
    {
        Assert.That(MEDIATYPE_ScriptCommand, Is.EqualTo(new Guid(0x73636d64, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_AUXLine21Data"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_AUXLine21DataTest()
    {
        Assert.That(MEDIATYPE_AUXLine21Data, Is.EqualTo(new Guid(0x670aea80, 0x3a82, 0x11d0, 0xb7, 0x9b, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_AUXTeletextPage"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_AUXTeletextPageTest()
    {
        Assert.That(MEDIATYPE_AUXTeletextPage, Is.EqualTo(new Guid(0x11264acb, 0x37de, 0x4eba, 0x8c, 0x35, 0x7f, 0x4, 0xa1, 0xa6, 0x83, 0x32)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_CC_CONTAINER"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_CC_CONTAINERTest()
    {
        Assert.That(MEDIATYPE_CC_CONTAINER, Is.EqualTo(new Guid(0xaeb312e9, 0x3357, 0x43ca, 0xb7, 0x1, 0x97, 0xec, 0x19, 0x8e, 0x2b, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_DTVCCData"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_DTVCCDataTest()
    {
        Assert.That(MEDIATYPE_DTVCCData, Is.EqualTo(new Guid(0xfb77e152, 0x53b2, 0x499c, 0xb4, 0x6b, 0x50, 0x9f, 0xc3, 0x3e, 0xdf, 0xd7)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_MSTVCaption"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_MSTVCaptionTest()
    {
        Assert.That(MEDIATYPE_MSTVCaption, Is.EqualTo(new Guid(0xB88B8A89, 0xB049, 0x4C80, 0xAD, 0xCF, 0x58, 0x98, 0x98, 0x5E, 0x22, 0xC1)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_VBI"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_VBITest()
    {
        Assert.That(MEDIATYPE_VBI, Is.EqualTo(new Guid(0xf72a76e1, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_Timecode"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_TimecodeTest()
    {
        Assert.That(MEDIATYPE_Timecode, Is.EqualTo(new Guid(0x482dee3, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_LMRT"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_LMRTTest()
    {
        Assert.That(MEDIATYPE_LMRT, Is.EqualTo(new Guid(0x74726c6d, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_URL_STREAM"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_URL_STREAMTest()
    {
        Assert.That(MEDIATYPE_URL_STREAM, Is.EqualTo(new Guid(0x736c7275, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_MPEG1SystemStream"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_MPEG1SystemStreamTest()
    {
        Assert.That(MEDIATYPE_MPEG1SystemStream, Is.EqualTo(new Guid(0xe436eb82, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_AnalogVideo"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_AnalogVideoTest()
    {
        Assert.That(MEDIATYPE_AnalogVideo, Is.EqualTo(new Guid(0x482dde1, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
    }

    /// <summary>Validates that the value of the <see cref = "MEDIATYPE_AnalogAudio"/> property is correct.</summary>
    [Test]
    public static void MEDIATYPE_AnalogAudioTest()
    {
        Assert.That(MEDIATYPE_AnalogAudio, Is.EqualTo(new Guid(0x482dee1, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)));
    }
}