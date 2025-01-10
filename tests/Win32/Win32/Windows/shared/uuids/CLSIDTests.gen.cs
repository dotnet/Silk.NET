// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_CaptureGraphBuilder"/> property is correct.</summary>

    [Test]
    public static void CLSID_CaptureGraphBuilderTest()
    {
        Assert.That(
            CLSID_CaptureGraphBuilder,
            Is.EqualTo(
                new Guid(0xBF87B6E0, 0x8C27, 0x11d0, 0xB3, 0xF0, 0x0, 0xAA, 0x00, 0x37, 0x61, 0xC5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CaptureGraphBuilder2"/> property is correct.</summary>

    [Test]
    public static void CLSID_CaptureGraphBuilder2Test()
    {
        Assert.That(
            CLSID_CaptureGraphBuilder2,
            Is.EqualTo(
                new Guid(0xBF87B6E1, 0x8C27, 0x11d0, 0xB3, 0xF0, 0x0, 0xAA, 0x00, 0x37, 0x61, 0xC5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ProtoFilterGraph"/> property is correct.</summary>

    [Test]
    public static void CLSID_ProtoFilterGraphTest()
    {
        Assert.That(
            CLSID_ProtoFilterGraph,
            Is.EqualTo(
                new Guid(0xe436ebb0, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_SystemClock"/> property is correct.</summary>

    [Test]
    public static void CLSID_SystemClockTest()
    {
        Assert.That(
            CLSID_SystemClock,
            Is.EqualTo(
                new Guid(0xe436ebb1, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FilterMapper"/> property is correct.</summary>

    [Test]
    public static void CLSID_FilterMapperTest()
    {
        Assert.That(
            CLSID_FilterMapper,
            Is.EqualTo(
                new Guid(0xe436ebb2, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FilterGraph"/> property is correct.</summary>

    [Test]
    public static void CLSID_FilterGraphTest()
    {
        Assert.That(
            CLSID_FilterGraph,
            Is.EqualTo(
                new Guid(0xe436ebb3, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FilterGraphNoThread"/> property is correct.</summary>

    [Test]
    public static void CLSID_FilterGraphNoThreadTest()
    {
        Assert.That(
            CLSID_FilterGraphNoThread,
            Is.EqualTo(
                new Guid(0xe436ebb8, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FilterGraphPrivateThread"/> property is correct.</summary>

    [Test]
    public static void CLSID_FilterGraphPrivateThreadTest()
    {
        Assert.That(
            CLSID_FilterGraphPrivateThread,
            Is.EqualTo(
                new Guid(0xa3ecbc41, 0x581a, 0x4476, 0xb6, 0x93, 0xa6, 0x33, 0x40, 0x46, 0x2d, 0x8b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MPEG1Doc"/> property is correct.</summary>

    [Test]
    public static void CLSID_MPEG1DocTest()
    {
        Assert.That(
            CLSID_MPEG1Doc,
            Is.EqualTo(
                new Guid(0xe4bbd160, 0x4269, 0x11ce, 0x83, 0x8d, 0x0, 0xaa, 0x0, 0x55, 0x59, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FileSource"/> property is correct.</summary>

    [Test]
    public static void CLSID_FileSourceTest()
    {
        Assert.That(
            CLSID_FileSource,
            Is.EqualTo(
                new Guid(0x701722e0, 0x8ae3, 0x11ce, 0xa8, 0x5c, 0x00, 0xaa, 0x00, 0x2f, 0xea, 0xb5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MPEG1PacketPlayer"/> property is correct.</summary>

    [Test]
    public static void CLSID_MPEG1PacketPlayerTest()
    {
        Assert.That(
            CLSID_MPEG1PacketPlayer,
            Is.EqualTo(
                new Guid(0x26c25940, 0x4ca9, 0x11ce, 0xa8, 0x28, 0x0, 0xaa, 0x0, 0x2f, 0xea, 0xb5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MPEG1Splitter"/> property is correct.</summary>

    [Test]
    public static void CLSID_MPEG1SplitterTest()
    {
        Assert.That(
            CLSID_MPEG1Splitter,
            Is.EqualTo(
                new Guid(0x336475d0, 0x942a, 0x11ce, 0xa8, 0x70, 0x00, 0xaa, 0x00, 0x2f, 0xea, 0xb5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CMpegVideoCodec"/> property is correct.</summary>

    [Test]
    public static void CLSID_CMpegVideoCodecTest()
    {
        Assert.That(
            CLSID_CMpegVideoCodec,
            Is.EqualTo(
                new Guid(0xfeb50740, 0x7bef, 0x11ce, 0x9b, 0xd9, 0x0, 0x0, 0xe2, 0x2, 0x59, 0x9c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CMpegAudioCodec"/> property is correct.</summary>

    [Test]
    public static void CLSID_CMpegAudioCodecTest()
    {
        Assert.That(
            CLSID_CMpegAudioCodec,
            Is.EqualTo(
                new Guid(0x4a2286e0, 0x7bef, 0x11ce, 0x9b, 0xd9, 0x0, 0x0, 0xe2, 0x2, 0x59, 0x9c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_TextRender"/> property is correct.</summary>

    [Test]
    public static void CLSID_TextRenderTest()
    {
        Assert.That(
            CLSID_TextRender,
            Is.EqualTo(
                new Guid(0xe30629d3, 0x27e5, 0x11ce, 0x87, 0x5d, 0x0, 0x60, 0x8c, 0xb7, 0x80, 0x66)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_InfTee"/> property is correct.</summary>

    [Test]
    public static void CLSID_InfTeeTest()
    {
        Assert.That(
            CLSID_InfTee,
            Is.EqualTo(
                new Guid(0xf8388a40, 0xd5bb, 0x11d0, 0xbe, 0x5a, 0x0, 0x80, 0xc7, 0x6, 0x56, 0x8e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AviSplitter"/> property is correct.</summary>

    [Test]
    public static void CLSID_AviSplitterTest()
    {
        Assert.That(
            CLSID_AviSplitter,
            Is.EqualTo(
                new Guid(0x1b544c20, 0xfd0b, 0x11ce, 0x8c, 0x63, 0x0, 0xaa, 0x00, 0x44, 0xb5, 0x1e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AviReader"/> property is correct.</summary>

    [Test]
    public static void CLSID_AviReaderTest()
    {
        Assert.That(
            CLSID_AviReader,
            Is.EqualTo(
                new Guid(0x1b544c21, 0xfd0b, 0x11ce, 0x8c, 0x63, 0x0, 0xaa, 0x00, 0x44, 0xb5, 0x1e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VfwCapture"/> property is correct.</summary>

    [Test]
    public static void CLSID_VfwCaptureTest()
    {
        Assert.That(
            CLSID_VfwCapture,
            Is.EqualTo(
                new Guid(0x1b544c22, 0xfd0b, 0x11ce, 0x8c, 0x63, 0x0, 0xaa, 0x00, 0x44, 0xb5, 0x1e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CaptureProperties"/> property is correct.</summary>

    [Test]
    public static void CLSID_CapturePropertiesTest()
    {
        Assert.That(
            CLSID_CaptureProperties,
            Is.EqualTo(
                new Guid(0x1B544c22, 0xFD0B, 0x11ce, 0x8C, 0x63, 0x00, 0xAA, 0x00, 0x44, 0xB5, 0x1F)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FGControl"/> property is correct.</summary>

    [Test]
    public static void CLSID_FGControlTest()
    {
        Assert.That(
            CLSID_FGControl,
            Is.EqualTo(
                new Guid(0xe436ebb4, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MOVReader"/> property is correct.</summary>

    [Test]
    public static void CLSID_MOVReaderTest()
    {
        Assert.That(
            CLSID_MOVReader,
            Is.EqualTo(
                new Guid(0x44584800, 0xf8ee, 0x11ce, 0xb2, 0xd4, 0x00, 0xdd, 0x1, 0x10, 0x1b, 0x85)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_QuickTimeParser"/> property is correct.</summary>

    [Test]
    public static void CLSID_QuickTimeParserTest()
    {
        Assert.That(
            CLSID_QuickTimeParser,
            Is.EqualTo(
                new Guid(0xd51bd5a0, 0x7548, 0x11cf, 0xa5, 0x20, 0x0, 0x80, 0xc7, 0x7e, 0xf5, 0x8a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_QTDec"/> property is correct.</summary>

    [Test]
    public static void CLSID_QTDecTest()
    {
        Assert.That(
            CLSID_QTDec,
            Is.EqualTo(
                new Guid(0xfdfe9681, 0x74a3, 0x11d0, 0xaf, 0xa7, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AVIDoc"/> property is correct.</summary>

    [Test]
    public static void CLSID_AVIDocTest()
    {
        Assert.That(
            CLSID_AVIDoc,
            Is.EqualTo(
                new Guid(0xd3588ab0, 0x0781, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0xb, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VideoRenderer"/> property is correct.</summary>

    [Test]
    public static void CLSID_VideoRendererTest()
    {
        Assert.That(
            CLSID_VideoRenderer,
            Is.EqualTo(
                new Guid(0x70e102b0, 0x5556, 0x11ce, 0x97, 0xc0, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_Colour"/> property is correct.</summary>

    [Test]
    public static void CLSID_ColourTest()
    {
        Assert.That(
            CLSID_Colour,
            Is.EqualTo(
                new Guid(0x1643e180, 0x90f5, 0x11ce, 0x97, 0xd5, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_Dither"/> property is correct.</summary>

    [Test]
    public static void CLSID_DitherTest()
    {
        Assert.That(
            CLSID_Dither,
            Is.EqualTo(
                new Guid(0x1da08500, 0x9edc, 0x11cf, 0xbc, 0x10, 0x00, 0xaa, 0x00, 0xac, 0x74, 0xf6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ModexRenderer"/> property is correct.</summary>

    [Test]
    public static void CLSID_ModexRendererTest()
    {
        Assert.That(
            CLSID_ModexRenderer,
            Is.EqualTo(
                new Guid(0x7167665, 0x5011, 0x11cf, 0xbf, 0x33, 0x0, 0xaa, 0x0, 0x55, 0x59, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AudioRender"/> property is correct.</summary>

    [Test]
    public static void CLSID_AudioRenderTest()
    {
        Assert.That(
            CLSID_AudioRender,
            Is.EqualTo(
                new Guid(0xe30629d1, 0x27e5, 0x11ce, 0x87, 0x5d, 0x0, 0x60, 0x8c, 0xb7, 0x80, 0x66)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AudioProperties"/> property is correct.</summary>

    [Test]
    public static void CLSID_AudioPropertiesTest()
    {
        Assert.That(
            CLSID_AudioProperties,
            Is.EqualTo(
                new Guid(0x05589faf, 0xc356, 0x11ce, 0xbf, 0x01, 0x0, 0xaa, 0x0, 0x55, 0x59, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DSoundRender"/> property is correct.</summary>

    [Test]
    public static void CLSID_DSoundRenderTest()
    {
        Assert.That(
            CLSID_DSoundRender,
            Is.EqualTo(
                new Guid(0x79376820, 0x07D0, 0x11CF, 0xA2, 0x4D, 0x0, 0x20, 0xAF, 0xD7, 0x97, 0x67)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AudioRecord"/> property is correct.</summary>

    [Test]
    public static void CLSID_AudioRecordTest()
    {
        Assert.That(
            CLSID_AudioRecord,
            Is.EqualTo(
                new Guid(0xe30629d2, 0x27e5, 0x11ce, 0x87, 0x5d, 0x0, 0x60, 0x8c, 0xb7, 0x80, 0x66)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AudioInputMixerProperties"/> property is correct.</summary>

    [Test]
    public static void CLSID_AudioInputMixerPropertiesTest()
    {
        Assert.That(
            CLSID_AudioInputMixerProperties,
            Is.EqualTo(
                new Guid(0x2ca8ca52, 0x3c3f, 0x11d2, 0xb7, 0x3d, 0x0, 0xc0, 0x4f, 0xb6, 0xbd, 0x3d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AVIDec"/> property is correct.</summary>

    [Test]
    public static void CLSID_AVIDecTest()
    {
        Assert.That(
            CLSID_AVIDec,
            Is.EqualTo(
                new Guid(0xcf49d4e0, 0x1115, 0x11ce, 0xb0, 0x3a, 0x0, 0x20, 0xaf, 0xb, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AVIDraw"/> property is correct.</summary>

    [Test]
    public static void CLSID_AVIDrawTest()
    {
        Assert.That(
            CLSID_AVIDraw,
            Is.EqualTo(
                new Guid(0xa888df60, 0x1e90, 0x11cf, 0xac, 0x98, 0x0, 0xaa, 0x0, 0x4c, 0xf, 0xa9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ACMWrapper"/> property is correct.</summary>

    [Test]
    public static void CLSID_ACMWrapperTest()
    {
        Assert.That(
            CLSID_ACMWrapper,
            Is.EqualTo(
                new Guid(0x6a08cf80, 0x0e18, 0x11cf, 0xa2, 0x4d, 0x0, 0x20, 0xaf, 0xd7, 0x97, 0x67)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AsyncReader"/> property is correct.</summary>

    [Test]
    public static void CLSID_AsyncReaderTest()
    {
        Assert.That(
            CLSID_AsyncReader,
            Is.EqualTo(
                new Guid(0xe436ebb5, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_URLReader"/> property is correct.</summary>

    [Test]
    public static void CLSID_URLReaderTest()
    {
        Assert.That(
            CLSID_URLReader,
            Is.EqualTo(
                new Guid(0xe436ebb6, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_PersistMonikerPID"/> property is correct.</summary>

    [Test]
    public static void CLSID_PersistMonikerPIDTest()
    {
        Assert.That(
            CLSID_PersistMonikerPID,
            Is.EqualTo(
                new Guid(0xe436ebb7, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AVICo"/> property is correct.</summary>

    [Test]
    public static void CLSID_AVICoTest()
    {
        Assert.That(
            CLSID_AVICo,
            Is.EqualTo(
                new Guid(0xd76e2820, 0x1563, 0x11cf, 0xac, 0x98, 0x0, 0xaa, 0x0, 0x4c, 0xf, 0xa9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FileWriter"/> property is correct.</summary>

    [Test]
    public static void CLSID_FileWriterTest()
    {
        Assert.That(
            CLSID_FileWriter,
            Is.EqualTo(
                new Guid(0x8596e5f0, 0xda5, 0x11d0, 0xbd, 0x21, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AviDest"/> property is correct.</summary>

    [Test]
    public static void CLSID_AviDestTest()
    {
        Assert.That(
            CLSID_AviDest,
            Is.EqualTo(
                new Guid(0xe2510970, 0xf137, 0x11ce, 0x8b, 0x67, 0x0, 0xaa, 0x0, 0xa3, 0xf1, 0xa6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AviMuxProptyPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_AviMuxProptyPageTest()
    {
        Assert.That(
            CLSID_AviMuxProptyPage,
            Is.EqualTo(
                new Guid(0xc647b5c0, 0x157c, 0x11d0, 0xbd, 0x23, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AviMuxProptyPage1"/> property is correct.</summary>

    [Test]
    public static void CLSID_AviMuxProptyPage1Test()
    {
        Assert.That(
            CLSID_AviMuxProptyPage1,
            Is.EqualTo(
                new Guid(0xa9ae910, 0x85c0, 0x11d0, 0xbd, 0x42, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AVIMIDIRender"/> property is correct.</summary>

    [Test]
    public static void CLSID_AVIMIDIRenderTest()
    {
        Assert.That(
            CLSID_AVIMIDIRender,
            Is.EqualTo(
                new Guid(0x07b65360, 0xc445, 0x11ce, 0xaf, 0xde, 0x00, 0xaa, 0x00, 0x6c, 0x14, 0xf4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WMAsfReader"/> property is correct.</summary>

    [Test]
    public static void CLSID_WMAsfReaderTest()
    {
        Assert.That(
            CLSID_WMAsfReader,
            Is.EqualTo(
                new Guid(0x187463a0, 0x5bb7, 0x11d3, 0xac, 0xbe, 0x0, 0x80, 0xc7, 0x5e, 0x24, 0x6e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WMAsfWriter"/> property is correct.</summary>

    [Test]
    public static void CLSID_WMAsfWriterTest()
    {
        Assert.That(
            CLSID_WMAsfWriter,
            Is.EqualTo(
                new Guid(0x7c23220e, 0x55bb, 0x11d3, 0x8b, 0x16, 0x0, 0xc0, 0x4f, 0xb6, 0xbd, 0x3d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MPEG2Demultiplexer"/> property is correct.</summary>

    [Test]
    public static void CLSID_MPEG2DemultiplexerTest()
    {
        Assert.That(
            CLSID_MPEG2Demultiplexer,
            Is.EqualTo(
                new Guid(0xafb6c280, 0x2c41, 0x11d3, 0x8a, 0x60, 0x00, 0x00, 0xf8, 0x1e, 0x0e, 0x4a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MPEG2Demultiplexer_NoClock"/> property is correct.</summary>

    [Test]
    public static void CLSID_MPEG2Demultiplexer_NoClockTest()
    {
        Assert.That(
            CLSID_MPEG2Demultiplexer_NoClock,
            Is.EqualTo(
                new Guid(0x687d3367, 0x3644, 0x467a, 0xad, 0xfe, 0x6c, 0xd7, 0xa8, 0x5c, 0x4a, 0x2c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MMSPLITTER"/> property is correct.</summary>

    [Test]
    public static void CLSID_MMSPLITTERTest()
    {
        Assert.That(
            CLSID_MMSPLITTER,
            Is.EqualTo(
                new Guid(0x3ae86b20, 0x7be8, 0x11d1, 0xab, 0xe6, 0x00, 0xa0, 0xc9, 0x05, 0xf3, 0x75)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_StreamBufferSink"/> property is correct.</summary>

    [Test]
    public static void CLSID_StreamBufferSinkTest()
    {
        Assert.That(
            CLSID_StreamBufferSink,
            Is.EqualTo(
                new Guid(0x2db47ae5, 0xcf39, 0x43c2, 0xb4, 0xd6, 0xc, 0xd8, 0xd9, 0x9, 0x46, 0xf4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_SBE2Sink"/> property is correct.</summary>

    [Test]
    public static void CLSID_SBE2SinkTest()
    {
        Assert.That(
            CLSID_SBE2Sink,
            Is.EqualTo(
                new Guid(0xe2448508, 0x95da, 0x4205, 0x9a, 0x27, 0x7e, 0xc8, 0x1e, 0x72, 0x3b, 0x1a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_StreamBufferSource"/> property is correct.</summary>

    [Test]
    public static void CLSID_StreamBufferSourceTest()
    {
        Assert.That(
            CLSID_StreamBufferSource,
            Is.EqualTo(
                new Guid(0xc9f5fe02, 0xf851, 0x4eb5, 0x99, 0xee, 0xad, 0x60, 0x2a, 0xf1, 0xe6, 0x19)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_StreamBufferConfig"/> property is correct.</summary>

    [Test]
    public static void CLSID_StreamBufferConfigTest()
    {
        Assert.That(
            CLSID_StreamBufferConfig,
            Is.EqualTo(
                new Guid(0xfa8a68b2, 0xc864, 0x4ba2, 0xad, 0x53, 0xd3, 0x87, 0x6a, 0x87, 0x49, 0x4b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_StreamBufferPropertyHandler"/> property is correct.</summary>

    [Test]
    public static void CLSID_StreamBufferPropertyHandlerTest()
    {
        Assert.That(
            CLSID_StreamBufferPropertyHandler,
            Is.EqualTo(
                new Guid(0xe37a73f8, 0xfb01, 0x43dc, 0x91, 0x4e, 0xaa, 0xee, 0x76, 0x9, 0x5a, 0xb9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_StreamBufferThumbnailHandler"/> property is correct.</summary>

    [Test]
    public static void CLSID_StreamBufferThumbnailHandlerTest()
    {
        Assert.That(
            CLSID_StreamBufferThumbnailHandler,
            Is.EqualTo(
                new Guid(0x713790ee, 0x5ee1, 0x45ba, 0x80, 0x70, 0xa1, 0x33, 0x7d, 0x27, 0x62, 0xfa)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_Mpeg2VideoStreamAnalyzer"/> property is correct.</summary>

    [Test]
    public static void CLSID_Mpeg2VideoStreamAnalyzerTest()
    {
        Assert.That(
            CLSID_Mpeg2VideoStreamAnalyzer,
            Is.EqualTo(
                new Guid(0x6cfad761, 0x735d, 0x4aa5, 0x8a, 0xfc, 0xaf, 0x91, 0xa7, 0xd6, 0x1e, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_StreamBufferRecordingAttributes"/> property is correct.</summary>

    [Test]
    public static void CLSID_StreamBufferRecordingAttributesTest()
    {
        Assert.That(
            CLSID_StreamBufferRecordingAttributes,
            Is.EqualTo(
                new Guid(0xccaa63ac, 0x1057, 0x4778, 0xae, 0x92, 0x12, 0x6, 0xab, 0x9a, 0xce, 0xe6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_StreamBufferComposeRecording"/> property is correct.</summary>

    [Test]
    public static void CLSID_StreamBufferComposeRecordingTest()
    {
        Assert.That(
            CLSID_StreamBufferComposeRecording,
            Is.EqualTo(
                new Guid(0xd682c4ba, 0xa90a, 0x42fe, 0xb9, 0xe1, 0x3, 0x10, 0x98, 0x49, 0xc4, 0x23)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_SBE2File"/> property is correct.</summary>

    [Test]
    public static void CLSID_SBE2FileTest()
    {
        Assert.That(
            CLSID_SBE2File,
            Is.EqualTo(
                new Guid(0x93a094d7, 0x51e8, 0x485b, 0x90, 0x4a, 0x8d, 0x6b, 0x97, 0xdc, 0x6b, 0x39)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVVideoCodec"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVVideoCodecTest()
    {
        Assert.That(
            CLSID_DVVideoCodec,
            Is.EqualTo(
                new Guid(0xb1b77c00, 0xc3e4, 0x11cf, 0xaf, 0x79, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVVideoEnc"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVVideoEncTest()
    {
        Assert.That(
            CLSID_DVVideoEnc,
            Is.EqualTo(
                new Guid(0x13aa3650, 0xbb6f, 0x11d0, 0xaf, 0xb9, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVSplitter"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVSplitterTest()
    {
        Assert.That(
            CLSID_DVSplitter,
            Is.EqualTo(
                new Guid(0x4eb31670, 0x9fc6, 0x11cf, 0xaf, 0x6e, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVMux"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVMuxTest()
    {
        Assert.That(
            CLSID_DVMux,
            Is.EqualTo(
                new Guid(0x129d7e40, 0xc10d, 0x11d0, 0xaf, 0xb9, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_SeekingPassThru"/> property is correct.</summary>

    [Test]
    public static void CLSID_SeekingPassThruTest()
    {
        Assert.That(
            CLSID_SeekingPassThru,
            Is.EqualTo(
                new Guid(0x60af76c, 0x68dd, 0x11d0, 0x8f, 0xc1, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0x9d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_Line21Decoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_Line21DecoderTest()
    {
        Assert.That(
            CLSID_Line21Decoder,
            Is.EqualTo(
                new Guid(0x6e8d4a20, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_Line21Decoder2"/> property is correct.</summary>

    [Test]
    public static void CLSID_Line21Decoder2Test()
    {
        Assert.That(
            CLSID_Line21Decoder2,
            Is.EqualTo(
                new Guid(0xe4206432, 0x01a1, 0x4bee, 0xb3, 0xe1, 0x37, 0x02, 0xc8, 0xed, 0xc5, 0x74)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CCAFilter"/> property is correct.</summary>

    [Test]
    public static void CLSID_CCAFilterTest()
    {
        Assert.That(
            CLSID_CCAFilter,
            Is.EqualTo(
                new Guid(0x3d07a539, 0x35ca, 0x447c, 0x9b, 0x5, 0x8d, 0x85, 0xce, 0x92, 0x4f, 0x9e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_OverlayMixer"/> property is correct.</summary>

    [Test]
    public static void CLSID_OverlayMixerTest()
    {
        Assert.That(
            CLSID_OverlayMixer,
            Is.EqualTo(
                new Guid(0xcd8743a1, 0x3736, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VBISurfaces"/> property is correct.</summary>

    [Test]
    public static void CLSID_VBISurfacesTest()
    {
        Assert.That(
            CLSID_VBISurfaces,
            Is.EqualTo(
                new Guid(0x814b9800, 0x1c88, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WSTDecoder"/> property is correct.</summary>

    [Test]
    public static void CLSID_WSTDecoderTest()
    {
        Assert.That(
            CLSID_WSTDecoder,
            Is.EqualTo(
                new Guid(0x70bc06e0, 0x5666, 0x11d3, 0xa1, 0x84, 0x0, 0x10, 0x5a, 0xef, 0x9f, 0x33)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MjpegDec"/> property is correct.</summary>

    [Test]
    public static void CLSID_MjpegDecTest()
    {
        Assert.That(
            CLSID_MjpegDec,
            Is.EqualTo(
                new Guid(0x301056d0, 0x6dff, 0x11d2, 0x9e, 0xeb, 0x0, 0x60, 0x8, 0x3, 0x9e, 0x37)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MJPGEnc"/> property is correct.</summary>

    [Test]
    public static void CLSID_MJPGEncTest()
    {
        Assert.That(
            CLSID_MJPGEnc,
            Is.EqualTo(
                new Guid(0xb80ab0a0, 0x7416, 0x11d2, 0x9e, 0xeb, 0x0, 0x60, 0x8, 0x3, 0x9e, 0x37)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_SystemDeviceEnum"/> property is correct.</summary>

    [Test]
    public static void CLSID_SystemDeviceEnumTest()
    {
        Assert.That(
            CLSID_SystemDeviceEnum,
            Is.EqualTo(
                new Guid(0x62BE5D10, 0x60EB, 0x11d0, 0xBD, 0x3B, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CDeviceMoniker"/> property is correct.</summary>

    [Test]
    public static void CLSID_CDeviceMonikerTest()
    {
        Assert.That(
            CLSID_CDeviceMoniker,
            Is.EqualTo(
                new Guid(0x4315D437, 0x5B8C, 0x11d0, 0xBD, 0x3B, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VideoInputDeviceCategory"/> property is correct.</summary>

    [Test]
    public static void CLSID_VideoInputDeviceCategoryTest()
    {
        Assert.That(
            CLSID_VideoInputDeviceCategory,
            Is.EqualTo(
                new Guid(0x860BB310, 0x5D01, 0x11d0, 0xBD, 0x3B, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CVidCapClassManager"/> property is correct.</summary>

    [Test]
    public static void CLSID_CVidCapClassManagerTest()
    {
        Assert.That(
            CLSID_CVidCapClassManager,
            Is.EqualTo(
                new Guid(0x860BB310, 0x5D01, 0x11d0, 0xBD, 0x3B, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_LegacyAmFilterCategory"/> property is correct.</summary>

    [Test]
    public static void CLSID_LegacyAmFilterCategoryTest()
    {
        Assert.That(
            CLSID_LegacyAmFilterCategory,
            Is.EqualTo(
                new Guid(0x083863F1, 0x70DE, 0x11d0, 0xBD, 0x40, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CQzFilterClassManager"/> property is correct.</summary>

    [Test]
    public static void CLSID_CQzFilterClassManagerTest()
    {
        Assert.That(
            CLSID_CQzFilterClassManager,
            Is.EqualTo(
                new Guid(0x083863F1, 0x70DE, 0x11d0, 0xBD, 0x40, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VideoCompressorCategory"/> property is correct.</summary>

    [Test]
    public static void CLSID_VideoCompressorCategoryTest()
    {
        Assert.That(
            CLSID_VideoCompressorCategory,
            Is.EqualTo(
                new Guid(0x33d9a760, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CIcmCoClassManager"/> property is correct.</summary>

    [Test]
    public static void CLSID_CIcmCoClassManagerTest()
    {
        Assert.That(
            CLSID_CIcmCoClassManager,
            Is.EqualTo(
                new Guid(0x33d9a760, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AudioCompressorCategory"/> property is correct.</summary>

    [Test]
    public static void CLSID_AudioCompressorCategoryTest()
    {
        Assert.That(
            CLSID_AudioCompressorCategory,
            Is.EqualTo(
                new Guid(0x33d9a761, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CAcmCoClassManager"/> property is correct.</summary>

    [Test]
    public static void CLSID_CAcmCoClassManagerTest()
    {
        Assert.That(
            CLSID_CAcmCoClassManager,
            Is.EqualTo(
                new Guid(0x33d9a761, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AudioInputDeviceCategory"/> property is correct.</summary>

    [Test]
    public static void CLSID_AudioInputDeviceCategoryTest()
    {
        Assert.That(
            CLSID_AudioInputDeviceCategory,
            Is.EqualTo(
                new Guid(0x33d9a762, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CWaveinClassManager"/> property is correct.</summary>

    [Test]
    public static void CLSID_CWaveinClassManagerTest()
    {
        Assert.That(
            CLSID_CWaveinClassManager,
            Is.EqualTo(
                new Guid(0x33d9a762, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AudioRendererCategory"/> property is correct.</summary>

    [Test]
    public static void CLSID_AudioRendererCategoryTest()
    {
        Assert.That(
            CLSID_AudioRendererCategory,
            Is.EqualTo(
                new Guid(0xe0f158e1, 0xcb04, 0x11d0, 0xbd, 0x4e, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CWaveOutClassManager"/> property is correct.</summary>

    [Test]
    public static void CLSID_CWaveOutClassManagerTest()
    {
        Assert.That(
            CLSID_CWaveOutClassManager,
            Is.EqualTo(
                new Guid(0xe0f158e1, 0xcb04, 0x11d0, 0xbd, 0x4e, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MidiRendererCategory"/> property is correct.</summary>

    [Test]
    public static void CLSID_MidiRendererCategoryTest()
    {
        Assert.That(
            CLSID_MidiRendererCategory,
            Is.EqualTo(
                new Guid(0x4EfE2452, 0x168A, 0x11d1, 0xBC, 0x76, 0x0, 0xc0, 0x4F, 0xB9, 0x45, 0x3B)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CMidiOutClassManager"/> property is correct.</summary>

    [Test]
    public static void CLSID_CMidiOutClassManagerTest()
    {
        Assert.That(
            CLSID_CMidiOutClassManager,
            Is.EqualTo(
                new Guid(0x4EfE2452, 0x168A, 0x11d1, 0xBC, 0x76, 0x0, 0xc0, 0x4F, 0xB9, 0x45, 0x3B)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_TransmitCategory"/> property is correct.</summary>

    [Test]
    public static void CLSID_TransmitCategoryTest()
    {
        Assert.That(
            CLSID_TransmitCategory,
            Is.EqualTo(
                new Guid(0xcc7bfb41, 0xf175, 0x11d1, 0xa3, 0x92, 0x0, 0xe0, 0x29, 0x1f, 0x39, 0x59)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DeviceControlCategory"/> property is correct.</summary>

    [Test]
    public static void CLSID_DeviceControlCategoryTest()
    {
        Assert.That(
            CLSID_DeviceControlCategory,
            Is.EqualTo(
                new Guid(0xcc7bfb46, 0xf175, 0x11d1, 0xa3, 0x92, 0x0, 0xe0, 0x29, 0x1f, 0x39, 0x59)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ActiveMovieCategories"/> property is correct.</summary>

    [Test]
    public static void CLSID_ActiveMovieCategoriesTest()
    {
        Assert.That(
            CLSID_ActiveMovieCategories,
            Is.EqualTo(
                new Guid(0xda4e3da0, 0xd07d, 0x11d0, 0xbd, 0x50, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVDHWDecodersCategory"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVDHWDecodersCategoryTest()
    {
        Assert.That(
            CLSID_DVDHWDecodersCategory,
            Is.EqualTo(
                new Guid(0x2721AE20, 0x7E70, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MediaEncoderCategory"/> property is correct.</summary>

    [Test]
    public static void CLSID_MediaEncoderCategoryTest()
    {
        Assert.That(
            CLSID_MediaEncoderCategory,
            Is.EqualTo(
                new Guid(0x7D22E920, 0x5CA9, 0x4787, 0x8C, 0x2B, 0xA6, 0x77, 0x9B, 0xD1, 0x17, 0x81)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MediaMultiplexerCategory"/> property is correct.</summary>

    [Test]
    public static void CLSID_MediaMultiplexerCategoryTest()
    {
        Assert.That(
            CLSID_MediaMultiplexerCategory,
            Is.EqualTo(
                new Guid(0x236C9559, 0xADCE, 0x4736, 0xBF, 0x72, 0xBA, 0xB3, 0x4E, 0x39, 0x21, 0x96)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_FilterMapper2"/> property is correct.</summary>

    [Test]
    public static void CLSID_FilterMapper2Test()
    {
        Assert.That(
            CLSID_FilterMapper2,
            Is.EqualTo(
                new Guid(0xcda42200, 0xbd88, 0x11d0, 0xbd, 0x4e, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MemoryAllocator"/> property is correct.</summary>

    [Test]
    public static void CLSID_MemoryAllocatorTest()
    {
        Assert.That(
            CLSID_MemoryAllocator,
            Is.EqualTo(
                new Guid(0x1e651cc0, 0xb199, 0x11d0, 0x82, 0x12, 0x00, 0xc0, 0x4f, 0xc3, 0x2c, 0x45)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MediaPropertyBag"/> property is correct.</summary>

    [Test]
    public static void CLSID_MediaPropertyBagTest()
    {
        Assert.That(
            CLSID_MediaPropertyBag,
            Is.EqualTo(
                new Guid(0xcdbd8d00, 0xc193, 0x11d0, 0xbd, 0x4e, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DvdGraphBuilder"/> property is correct.</summary>

    [Test]
    public static void CLSID_DvdGraphBuilderTest()
    {
        Assert.That(
            CLSID_DvdGraphBuilder,
            Is.EqualTo(
                new Guid(0xFCC152B7, 0xF372, 0x11d0, 0x8E, 0x00, 0x00, 0xC0, 0x4F, 0xD7, 0xC0, 0x8B)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVDNavigator"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVDNavigatorTest()
    {
        Assert.That(
            CLSID_DVDNavigator,
            Is.EqualTo(
                new Guid(0x9b8c4620, 0x2c1a, 0x11d0, 0x84, 0x93, 0x0, 0xa0, 0x24, 0x38, 0xad, 0x48)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVDState"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVDStateTest()
    {
        Assert.That(
            CLSID_DVDState,
            Is.EqualTo(
                new Guid(0xf963c5cf, 0xa659, 0x4a93, 0x96, 0x38, 0xca, 0xf3, 0xcd, 0x27, 0x7d, 0x13)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_SmartTee"/> property is correct.</summary>

    [Test]
    public static void CLSID_SmartTeeTest()
    {
        Assert.That(
            CLSID_SmartTee,
            Is.EqualTo(
                new Guid(0xcc58e280, 0x8aa1, 0x11d1, 0xb3, 0xf1, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DtvCcFilter"/> property is correct.</summary>

    [Test]
    public static void CLSID_DtvCcFilterTest()
    {
        Assert.That(
            CLSID_DtvCcFilter,
            Is.EqualTo(
                new Guid(0xfb056ba0, 0x2502, 0x45b9, 0x8e, 0x86, 0x2b, 0x40, 0xde, 0x84, 0xad, 0x29)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CaptionsFilter"/> property is correct.</summary>

    [Test]
    public static void CLSID_CaptionsFilterTest()
    {
        Assert.That(
            CLSID_CaptionsFilter,
            Is.EqualTo(
                new Guid(0x2F7EE4B6, 0x6FF5, 0x4EB4, 0xB2, 0x4A, 0x2B, 0xFC, 0x41, 0x11, 0x71, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_SubtitlesFilter"/> property is correct.</summary>

    [Test]
    public static void CLSID_SubtitlesFilterTest()
    {
        Assert.That(
            CLSID_SubtitlesFilter,
            Is.EqualTo(
                new Guid(0x9f22cfea, 0xce07, 0x41ab, 0x8b, 0xa0, 0xc7, 0x36, 0x4a, 0xf9, 0x0a, 0xf9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DirectShowPluginControl"/> property is correct.</summary>

    [Test]
    public static void CLSID_DirectShowPluginControlTest()
    {
        Assert.That(
            CLSID_DirectShowPluginControl,
            Is.EqualTo(
                new Guid(0x8670c736, 0xf614, 0x427b, 0x8a, 0xda, 0xbb, 0xad, 0xc5, 0x87, 0x19, 0x4b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DirectDrawProperties"/> property is correct.</summary>

    [Test]
    public static void CLSID_DirectDrawPropertiesTest()
    {
        Assert.That(
            CLSID_DirectDrawProperties,
            Is.EqualTo(
                new Guid(0x944d4c00, 0xdd52, 0x11ce, 0xbf, 0x0e, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_PerformanceProperties"/> property is correct.</summary>

    [Test]
    public static void CLSID_PerformancePropertiesTest()
    {
        Assert.That(
            CLSID_PerformanceProperties,
            Is.EqualTo(
                new Guid(0x59ce6880, 0xacf8, 0x11cf, 0xb5, 0x6e, 0x00, 0x80, 0xc7, 0xc4, 0xb6, 0x8a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_QualityProperties"/> property is correct.</summary>

    [Test]
    public static void CLSID_QualityPropertiesTest()
    {
        Assert.That(
            CLSID_QualityProperties,
            Is.EqualTo(
                new Guid(0x418afb70, 0xf8b8, 0x11ce, 0xaa, 0xc6, 0x00, 0x20, 0xaf, 0x0b, 0x99, 0xa3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VPObject"/> property is correct.</summary>

    [Test]
    public static void CLSID_VPObjectTest()
    {
        Assert.That(
            CLSID_VPObject,
            Is.EqualTo(
                new Guid(0xce292861, 0xfc88, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VPVBIObject"/> property is correct.</summary>

    [Test]
    public static void CLSID_VPVBIObjectTest()
    {
        Assert.That(
            CLSID_VPVBIObject,
            Is.EqualTo(
                new Guid(0x814b9801, 0x1c88, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ModexProperties"/> property is correct.</summary>

    [Test]
    public static void CLSID_ModexPropertiesTest()
    {
        Assert.That(
            CLSID_ModexProperties,
            Is.EqualTo(
                new Guid(0x0618aa30, 0x6bc4, 0x11cf, 0xbf, 0x36, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVDecPropertiesPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVDecPropertiesPageTest()
    {
        Assert.That(
            CLSID_DVDecPropertiesPage,
            Is.EqualTo(
                new Guid(0x101193c0, 0xbfe, 0x11d0, 0xaf, 0x91, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVEncPropertiesPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVEncPropertiesPageTest()
    {
        Assert.That(
            CLSID_DVEncPropertiesPage,
            Is.EqualTo(
                new Guid(0x4150f050, 0xbb6f, 0x11d0, 0xaf, 0xb9, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVMuxPropertyPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVMuxPropertyPageTest()
    {
        Assert.That(
            CLSID_DVMuxPropertyPage,
            Is.EqualTo(
                new Guid(0x4db880e0, 0xc10d, 0x11d0, 0xaf, 0xb9, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WstDecoderPropertyPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_WstDecoderPropertyPageTest()
    {
        Assert.That(
            CLSID_WstDecoderPropertyPage,
            Is.EqualTo(
                new Guid(0x4e27f80, 0x91e4, 0x11d3, 0xa1, 0x84, 0x0, 0x10, 0x5a, 0xef, 0x9f, 0x33)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_TVTunerFilterPropertyPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_TVTunerFilterPropertyPageTest()
    {
        Assert.That(
            CLSID_TVTunerFilterPropertyPage,
            Is.EqualTo(
                new Guid(0x266eee41, 0x6c63, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CrossbarFilterPropertyPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_CrossbarFilterPropertyPageTest()
    {
        Assert.That(
            CLSID_CrossbarFilterPropertyPage,
            Is.EqualTo(
                new Guid(0x71f96461, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_TVAudioFilterPropertyPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_TVAudioFilterPropertyPageTest()
    {
        Assert.That(
            CLSID_TVAudioFilterPropertyPage,
            Is.EqualTo(
                new Guid(0x71f96463, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VideoProcAmpPropertyPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_VideoProcAmpPropertyPageTest()
    {
        Assert.That(
            CLSID_VideoProcAmpPropertyPage,
            Is.EqualTo(
                new Guid(0x71f96464, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_CameraControlPropertyPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_CameraControlPropertyPageTest()
    {
        Assert.That(
            CLSID_CameraControlPropertyPage,
            Is.EqualTo(
                new Guid(0x71f96465, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AnalogVideoDecoderPropertyPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_AnalogVideoDecoderPropertyPageTest()
    {
        Assert.That(
            CLSID_AnalogVideoDecoderPropertyPage,
            Is.EqualTo(
                new Guid(0x71f96466, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VideoStreamConfigPropertyPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_VideoStreamConfigPropertyPageTest()
    {
        Assert.That(
            CLSID_VideoStreamConfigPropertyPage,
            Is.EqualTo(
                new Guid(0x71f96467, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AudioRendererAdvancedProperties"/> property is correct.</summary>

    [Test]
    public static void CLSID_AudioRendererAdvancedPropertiesTest()
    {
        Assert.That(
            CLSID_AudioRendererAdvancedProperties,
            Is.EqualTo(
                new Guid(0x37e92a92, 0xd9aa, 0x11d2, 0xbf, 0x84, 0x8e, 0xf2, 0xb1, 0x55, 0x5a, 0xed)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VideoMixingRenderer"/> property is correct.</summary>

    [Test]
    public static void CLSID_VideoMixingRendererTest()
    {
        Assert.That(
            CLSID_VideoMixingRenderer,
            Is.EqualTo(
                new Guid(0xB87BEB7B, 0x8D29, 0x423f, 0xAE, 0x4D, 0x65, 0x82, 0xC1, 0x01, 0x75, 0xAC)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VideoRendererDefault"/> property is correct.</summary>

    [Test]
    public static void CLSID_VideoRendererDefaultTest()
    {
        Assert.That(
            CLSID_VideoRendererDefault,
            Is.EqualTo(
                new Guid(0x6BC1CFFA, 0x8FC1, 0x4261, 0xAC, 0x22, 0xCF, 0xB4, 0xCC, 0x38, 0xDB, 0x50)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AllocPresenter"/> property is correct.</summary>

    [Test]
    public static void CLSID_AllocPresenterTest()
    {
        Assert.That(
            CLSID_AllocPresenter,
            Is.EqualTo(
                new Guid(0x99d54f63, 0x1a69, 0x41ae, 0xaa, 0x4d, 0xc9, 0x76, 0xeb, 0x3f, 0x07, 0x13)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_AllocPresenterDDXclMode"/> property is correct.</summary>

    [Test]
    public static void CLSID_AllocPresenterDDXclModeTest()
    {
        Assert.That(
            CLSID_AllocPresenterDDXclMode,
            Is.EqualTo(
                new Guid(0x4444ac9e, 0x242e, 0x471b, 0xa3, 0xc7, 0x45, 0xdc, 0xd4, 0x63, 0x52, 0xbc)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VideoPortManager"/> property is correct.</summary>

    [Test]
    public static void CLSID_VideoPortManagerTest()
    {
        Assert.That(
            CLSID_VideoPortManager,
            Is.EqualTo(
                new Guid(0x6f26a6cd, 0x967b, 0x47fd, 0x87, 0x4a, 0x7a, 0xed, 0x2c, 0x9d, 0x25, 0xa2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_VideoMixingRenderer9"/> property is correct.</summary>

    [Test]
    public static void CLSID_VideoMixingRenderer9Test()
    {
        Assert.That(
            CLSID_VideoMixingRenderer9,
            Is.EqualTo(
                new Guid(0x51b4abf3, 0x748f, 0x4e3b, 0xa2, 0x76, 0xc8, 0x28, 0x33, 0x0e, 0x92, 0x6a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_EnhancedVideoRenderer"/> property is correct.</summary>

    [Test]
    public static void CLSID_EnhancedVideoRendererTest()
    {
        Assert.That(
            CLSID_EnhancedVideoRenderer,
            Is.EqualTo(
                new Guid(0xfa10746c, 0x9b63, 0x4b6c, 0xbc, 0x49, 0xfc, 0x30, 0xe, 0xa5, 0xf2, 0x56)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MFVideoMixer9"/> property is correct.</summary>

    [Test]
    public static void CLSID_MFVideoMixer9Test()
    {
        Assert.That(
            CLSID_MFVideoMixer9,
            Is.EqualTo(
                new Guid(0xE474E05A, 0xAB65, 0x4f6a, 0x82, 0x7C, 0x21, 0x8B, 0x1B, 0xAA, 0xF3, 0x1F)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_MFVideoPresenter9"/> property is correct.</summary>

    [Test]
    public static void CLSID_MFVideoPresenter9Test()
    {
        Assert.That(
            CLSID_MFVideoPresenter9,
            Is.EqualTo(
                new Guid(0x98455561, 0x5136, 0x4d28, 0xab, 0x8, 0x4c, 0xee, 0x40, 0xea, 0x27, 0x81)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_EVRTearlessWindowPresenter9"/> property is correct.</summary>

    [Test]
    public static void CLSID_EVRTearlessWindowPresenter9Test()
    {
        Assert.That(
            CLSID_EVRTearlessWindowPresenter9,
            Is.EqualTo(
                new Guid(0xa0a7a57b, 0x59b2, 0x4919, 0xa6, 0x94, 0xad, 0xd0, 0xa5, 0x26, 0xc3, 0x73)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_EVRPlaybackPipelineOptimizer"/> property is correct.</summary>

    [Test]
    public static void CLSID_EVRPlaybackPipelineOptimizerTest()
    {
        Assert.That(
            CLSID_EVRPlaybackPipelineOptimizer,
            Is.EqualTo(
                new Guid(0x62079164, 0x233b, 0x41f8, 0xa8, 0x0f, 0xf0, 0x17, 0x05, 0xf5, 0x14, 0xa8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_NetworkProvider"/> property is correct.</summary>

    [Test]
    public static void CLSID_NetworkProviderTest()
    {
        Assert.That(
            CLSID_NetworkProvider,
            Is.EqualTo(
                new Guid(0xb2f3a67c, 0x29da, 0x4c78, 0x88, 0x31, 0x9, 0x1e, 0xd5, 0x9, 0xa4, 0x75)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ATSCNetworkProvider"/> property is correct.</summary>

    [Test]
    public static void CLSID_ATSCNetworkProviderTest()
    {
        Assert.That(
            CLSID_ATSCNetworkProvider,
            Is.EqualTo(
                new Guid(0x0dad2fdd, 0x5fd7, 0x11d3, 0x8f, 0x50, 0x00, 0xc0, 0x4f, 0x79, 0x71, 0xe2)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ATSCNetworkPropertyPage"/> property is correct.</summary>

    [Test]
    public static void CLSID_ATSCNetworkPropertyPageTest()
    {
        Assert.That(
            CLSID_ATSCNetworkPropertyPage,
            Is.EqualTo(
                new Guid(0xe3444d16, 0x5ac4, 0x4386, 0x88, 0xdf, 0x13, 0xfd, 0x23, 0x0e, 0x1d, 0xda)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVBSNetworkProvider"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVBSNetworkProviderTest()
    {
        Assert.That(
            CLSID_DVBSNetworkProvider,
            Is.EqualTo(
                new Guid(0xfa4b375a, 0x45b4, 0x4d45, 0x84, 0x40, 0x26, 0x39, 0x57, 0xb1, 0x16, 0x23)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVBTNetworkProvider"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVBTNetworkProviderTest()
    {
        Assert.That(
            CLSID_DVBTNetworkProvider,
            Is.EqualTo(
                new Guid(0x216c62df, 0x6d7f, 0x4e9a, 0x85, 0x71, 0x5, 0xf1, 0x4e, 0xdb, 0x76, 0x6a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DVBCNetworkProvider"/> property is correct.</summary>

    [Test]
    public static void CLSID_DVBCNetworkProviderTest()
    {
        Assert.That(
            CLSID_DVBCNetworkProvider,
            Is.EqualTo(
                new Guid(0xdc0c0fe7, 0x485, 0x4266, 0xb9, 0x3f, 0x68, 0xfb, 0xf8, 0xe, 0xd8, 0x34)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_DShowTVEFilter"/> property is correct.</summary>

    [Test]
    public static void CLSID_DShowTVEFilterTest()
    {
        Assert.That(
            CLSID_DShowTVEFilter,
            Is.EqualTo(
                new Guid(0x05500280, 0xFAA5, 0x4DF9, 0x82, 0x46, 0xBF, 0xC2, 0x3A, 0xC5, 0xCE, 0xA8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_TVEFilterTuneProperties"/> property is correct.</summary>

    [Test]
    public static void CLSID_TVEFilterTunePropertiesTest()
    {
        Assert.That(
            CLSID_TVEFilterTuneProperties,
            Is.EqualTo(
                new Guid(0x05500281, 0xFAA5, 0x4DF9, 0x82, 0x46, 0xBF, 0xC2, 0x3A, 0xC5, 0xCE, 0xA8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_TVEFilterCCProperties"/> property is correct.</summary>

    [Test]
    public static void CLSID_TVEFilterCCPropertiesTest()
    {
        Assert.That(
            CLSID_TVEFilterCCProperties,
            Is.EqualTo(
                new Guid(0x05500282, 0xFAA5, 0x4DF9, 0x82, 0x46, 0xBF, 0xC2, 0x3A, 0xC5, 0xCE, 0xA8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_TVEFilterStatsProperties"/> property is correct.</summary>

    [Test]
    public static void CLSID_TVEFilterStatsPropertiesTest()
    {
        Assert.That(
            CLSID_TVEFilterStatsProperties,
            Is.EqualTo(
                new Guid(0x05500283, 0xFAA5, 0x4DF9, 0x82, 0x46, 0xBF, 0xC2, 0x3A, 0xC5, 0xCE, 0xA8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_IVideoEncoderProxy"/> property is correct.</summary>

    [Test]
    public static void CLSID_IVideoEncoderProxyTest()
    {
        Assert.That(
            CLSID_IVideoEncoderProxy,
            Is.EqualTo(
                new Guid(0xb43c4eec, 0x8c32, 0x4791, 0x91, 0x2, 0x50, 0x8a, 0xda, 0x5e, 0xe8, 0xe7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_ICodecAPIProxy"/> property is correct.</summary>

    [Test]
    public static void CLSID_ICodecAPIProxyTest()
    {
        Assert.That(
            CLSID_ICodecAPIProxy,
            Is.EqualTo(
                new Guid(0x7ff0997a, 0x1999, 0x4286, 0xa7, 0x3c, 0x62, 0x2b, 0x88, 0x14, 0xe7, 0xeb)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_IVideoEncoderCodecAPIProxy"/> property is correct.</summary>

    [Test]
    public static void CLSID_IVideoEncoderCodecAPIProxyTest()
    {
        Assert.That(
            CLSID_IVideoEncoderCodecAPIProxy,
            Is.EqualTo(
                new Guid(0xb05dabd9, 0x56e5, 0x4fdc, 0xaf, 0xa4, 0x8a, 0x47, 0xe9, 0x1f, 0x1c, 0x9c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_SBE2MediaTypeProfile"/> property is correct.</summary>

    [Test]
    public static void CLSID_SBE2MediaTypeProfileTest()
    {
        Assert.That(
            CLSID_SBE2MediaTypeProfile,
            Is.EqualTo(
                new Guid(0x1f26a602, 0x2b5c, 0x4b63, 0xb8, 0xe8, 0x9e, 0xa5, 0xc1, 0xa7, 0xdc, 0x2e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_SBE2FileScan"/> property is correct.</summary>

    [Test]
    public static void CLSID_SBE2FileScanTest()
    {
        Assert.That(
            CLSID_SBE2FileScan,
            Is.EqualTo(
                new Guid(0x3e458037, 0xca6, 0x41aa, 0xa5, 0x94, 0x2a, 0xa6, 0xc0, 0x2d, 0x70, 0x9b)
            )
        );
    }
}
