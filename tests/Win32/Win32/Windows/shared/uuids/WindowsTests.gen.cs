// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "Windows"/> class.</summary>
public static partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref = "CAPTION_FORMAT_ATSC"/> property is correct.</summary>

    [Test]
    public static void CAPTION_FORMAT_ATSCTest()
    {
        Assert.That(
            CAPTION_FORMAT_ATSC,
            Is.EqualTo(
                new Guid(0x3ed9cb31, 0xfd10, 0x4ade, 0xbc, 0xcc, 0xfb, 0x91, 0x5, 0xd2, 0xf3, 0xef)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CAPTION_FORMAT_DVB"/> property is correct.</summary>

    [Test]
    public static void CAPTION_FORMAT_DVBTest()
    {
        Assert.That(
            CAPTION_FORMAT_DVB,
            Is.EqualTo(
                new Guid(0x12230db4, 0xff2a, 0x447e, 0xbb, 0x88, 0x68, 0x41, 0xc4, 0x16, 0xd0, 0x68)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CAPTION_FORMAT_DIRECTV"/> property is correct.</summary>

    [Test]
    public static void CAPTION_FORMAT_DIRECTVTest()
    {
        Assert.That(
            CAPTION_FORMAT_DIRECTV,
            Is.EqualTo(
                new Guid(0xe9ca1ce7, 0x915e, 0x47be, 0x9b, 0xb9, 0xbf, 0x1d, 0x8a, 0x13, 0xa5, 0xec)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CAPTION_FORMAT_ECHOSTAR"/> property is correct.</summary>

    [Test]
    public static void CAPTION_FORMAT_ECHOSTARTest()
    {
        Assert.That(
            CAPTION_FORMAT_ECHOSTAR,
            Is.EqualTo(
                new Guid(0xebb1a262, 0x1158, 0x4b99, 0xae, 0x80, 0x92, 0xac, 0x77, 0x69, 0x52, 0xc4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "AMPROPSETID_Pin"/> property is correct.</summary>

    [Test]
    public static void AMPROPSETID_PinTest()
    {
        Assert.That(
            AMPROPSETID_Pin,
            Is.EqualTo(
                new Guid(0x9b00f101, 0x1567, 0x11d1, 0xb3, 0xf1, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "LOOK_UPSTREAM_ONLY"/> property is correct.</summary>

    [Test]
    public static void LOOK_UPSTREAM_ONLYTest()
    {
        Assert.That(
            LOOK_UPSTREAM_ONLY,
            Is.EqualTo(
                new Guid(0xac798be0, 0x98e3, 0x11d1, 0xb3, 0xf1, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "LOOK_DOWNSTREAM_ONLY"/> property is correct.</summary>

    [Test]
    public static void LOOK_DOWNSTREAM_ONLYTest()
    {
        Assert.That(
            LOOK_DOWNSTREAM_ONLY,
            Is.EqualTo(
                new Guid(0xac798be1, 0x98e3, 0x11d1, 0xb3, 0xf1, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DSATTRIB_UDCRTag"/> property is correct.</summary>

    [Test]
    public static void DSATTRIB_UDCRTagTest()
    {
        Assert.That(
            DSATTRIB_UDCRTag,
            Is.EqualTo(
                new Guid(0xEB7836CA, 0x14FF, 0x4919, 0xbc, 0xe7, 0x3a, 0xf1, 0x23, 0x19, 0xe5, 0x0c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DSATTRIB_PicSampleSeq"/> property is correct.</summary>

    [Test]
    public static void DSATTRIB_PicSampleSeqTest()
    {
        Assert.That(
            DSATTRIB_PicSampleSeq,
            Is.EqualTo(
                new Guid(0x2f5bae02, 0x7b8f, 0x4f60, 0x82, 0xd6, 0xe4, 0xea, 0x2f, 0x1f, 0x4c, 0x99)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DSATTRIB_OptionalVideoAttributes"/> property is correct.</summary>

    [Test]
    public static void DSATTRIB_OptionalVideoAttributesTest()
    {
        Assert.That(
            DSATTRIB_OptionalVideoAttributes,
            Is.EqualTo(
                new Guid(0x5A5F08CA, 0x55C2, 0x4033, 0x92, 0xAB, 0x55, 0xDB, 0x8F, 0x78, 0x12, 0x26)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DSATTRIB_CC_CONTAINER_INFO"/> property is correct.</summary>

    [Test]
    public static void DSATTRIB_CC_CONTAINER_INFOTest()
    {
        Assert.That(
            DSATTRIB_CC_CONTAINER_INFO,
            Is.EqualTo(
                new Guid(0xe7e050fb, 0xdd5d, 0x40dd, 0x99, 0x15, 0x35, 0xDC, 0xB8, 0x1B, 0xDC, 0x8a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DSATTRIB_TRANSPORT_PROPERTIES"/> property is correct.</summary>

    [Test]
    public static void DSATTRIB_TRANSPORT_PROPERTIESTest()
    {
        Assert.That(
            DSATTRIB_TRANSPORT_PROPERTIES,
            Is.EqualTo(
                new Guid(0xb622f612, 0x47ad, 0x4671, 0xad, 0x6c, 0x5, 0xa9, 0x8e, 0x65, 0xde, 0x3a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DSATTRIB_PBDATAG_ATTRIBUTE"/> property is correct.</summary>

    [Test]
    public static void DSATTRIB_PBDATAG_ATTRIBUTETest()
    {
        Assert.That(
            DSATTRIB_PBDATAG_ATTRIBUTE,
            Is.EqualTo(
                new Guid(0xe0b56679, 0x12b9, 0x43cc, 0xb7, 0xdf, 0x57, 0x8c, 0xaa, 0x5a, 0x7b, 0x63)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DSATTRIB_CAPTURE_STREAMTIME"/> property is correct.</summary>

    [Test]
    public static void DSATTRIB_CAPTURE_STREAMTIMETest()
    {
        Assert.That(
            DSATTRIB_CAPTURE_STREAMTIME,
            Is.EqualTo(
                new Guid(0x0c1a5614, 0x30cd, 0x4f40, 0xbc, 0xbf, 0xd0, 0x3e, 0x52, 0x30, 0x62, 0x07)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DSATTRIB_DSHOW_STREAM_DESC"/> property is correct.</summary>

    [Test]
    public static void DSATTRIB_DSHOW_STREAM_DESCTest()
    {
        Assert.That(
            DSATTRIB_DSHOW_STREAM_DESC,
            Is.EqualTo(
                new Guid(0x5fb5673b, 0xa2a, 0x4565, 0x82, 0x7b, 0x68, 0x53, 0xfd, 0x75, 0xe6, 0x11)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "DSATTRIB_SAMPLE_LIVE_STREAM_TIME"/> property is correct.</summary>

    [Test]
    public static void DSATTRIB_SAMPLE_LIVE_STREAM_TIMETest()
    {
        Assert.That(
            DSATTRIB_SAMPLE_LIVE_STREAM_TIME,
            Is.EqualTo(
                new Guid(0x892cd111, 0x72f3, 0x411d, 0x8b, 0x91, 0xa9, 0xe9, 0x12, 0x3a, 0xc2, 0x9a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "UUID_UdriTagTables"/> property is correct.</summary>

    [Test]
    public static void UUID_UdriTagTablesTest()
    {
        Assert.That(
            UUID_UdriTagTables,
            Is.EqualTo(
                new Guid(0xe1b98d74, 0x9778, 0x4878, 0xb6, 0x64, 0xeb, 0x20, 0x20, 0x36, 0x4d, 0x88)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "UUID_WMDRMTagTables"/> property is correct.</summary>

    [Test]
    public static void UUID_WMDRMTagTablesTest()
    {
        Assert.That(
            UUID_WMDRMTagTables,
            Is.EqualTo(
                new Guid(0x5DCD1101, 0x9263, 0x45bb, 0xa4, 0xd5, 0xc4, 0x15, 0xab, 0x8c, 0x58, 0x9c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "ENCAPIPARAM_BITRATE"/> property is correct.</summary>

    [Test]
    public static void ENCAPIPARAM_BITRATETest()
    {
        Assert.That(
            ENCAPIPARAM_BITRATE,
            Is.EqualTo(
                new Guid(0x49cc4c43, 0xca83, 0x4ad4, 0xa9, 0xaf, 0xf3, 0x69, 0x6a, 0xf6, 0x66, 0xdf)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "ENCAPIPARAM_PEAK_BITRATE"/> property is correct.</summary>

    [Test]
    public static void ENCAPIPARAM_PEAK_BITRATETest()
    {
        Assert.That(
            ENCAPIPARAM_PEAK_BITRATE,
            Is.EqualTo(
                new Guid(0x703f16a9, 0x3d48, 0x44a1, 0xb0, 0x77, 0x1, 0x8d, 0xff, 0x91, 0x5d, 0x19)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "ENCAPIPARAM_BITRATE_MODE"/> property is correct.</summary>

    [Test]
    public static void ENCAPIPARAM_BITRATE_MODETest()
    {
        Assert.That(
            ENCAPIPARAM_BITRATE_MODE,
            Is.EqualTo(
                new Guid(0xee5fb25c, 0xc713, 0x40d1, 0x9d, 0x58, 0xc0, 0xd7, 0x24, 0x1e, 0x25, 0xf)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "ENCAPIPARAM_SAP_MODE"/> property is correct.</summary>

    [Test]
    public static void ENCAPIPARAM_SAP_MODETest()
    {
        Assert.That(
            ENCAPIPARAM_SAP_MODE,
            Is.EqualTo(
                new Guid(0xc0171db, 0xfefc, 0x4af7, 0x99, 0x91, 0xa5, 0x65, 0x7c, 0x19, 0x1c, 0xd1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CODECAPI_CHANGELISTS"/> property is correct.</summary>

    [Test]
    public static void CODECAPI_CHANGELISTSTest()
    {
        Assert.That(
            CODECAPI_CHANGELISTS,
            Is.EqualTo(
                new Guid(0x62b12acf, 0xf6b0, 0x47d9, 0x94, 0x56, 0x96, 0xf2, 0x2c, 0x4e, 0x0b, 0x9d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CODECAPI_VIDEO_ENCODER"/> property is correct.</summary>

    [Test]
    public static void CODECAPI_VIDEO_ENCODERTest()
    {
        Assert.That(
            CODECAPI_VIDEO_ENCODER,
            Is.EqualTo(
                new Guid(0x7112e8e1, 0x3d03, 0x47ef, 0x8e, 0x60, 0x03, 0xf1, 0xcf, 0x53, 0x73, 0x01)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CODECAPI_AUDIO_ENCODER"/> property is correct.</summary>

    [Test]
    public static void CODECAPI_AUDIO_ENCODERTest()
    {
        Assert.That(
            CODECAPI_AUDIO_ENCODER,
            Is.EqualTo(
                new Guid(0xb9d19a3e, 0xf897, 0x429c, 0xbc, 0x46, 0x81, 0x38, 0xb7, 0x27, 0x2b, 0x2d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CODECAPI_SETALLDEFAULTS"/> property is correct.</summary>

    [Test]
    public static void CODECAPI_SETALLDEFAULTSTest()
    {
        Assert.That(
            CODECAPI_SETALLDEFAULTS,
            Is.EqualTo(
                new Guid(0x6c5e6a7c, 0xacf8, 0x4f55, 0xa9, 0x99, 0x1a, 0x62, 0x81, 0x09, 0x05, 0x1b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CODECAPI_ALLSETTINGS"/> property is correct.</summary>

    [Test]
    public static void CODECAPI_ALLSETTINGSTest()
    {
        Assert.That(
            CODECAPI_ALLSETTINGS,
            Is.EqualTo(
                new Guid(0x6a577e92, 0x83e1, 0x4113, 0xad, 0xc2, 0x4f, 0xce, 0xc3, 0x2f, 0x83, 0xa1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CODECAPI_SUPPORTSEVENTS"/> property is correct.</summary>

    [Test]
    public static void CODECAPI_SUPPORTSEVENTSTest()
    {
        Assert.That(
            CODECAPI_SUPPORTSEVENTS,
            Is.EqualTo(
                new Guid(0x0581af97, 0x7693, 0x4dbd, 0x9d, 0xca, 0x3f, 0x9e, 0xbd, 0x65, 0x85, 0xa1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CODECAPI_CURRENTCHANGELIST"/> property is correct.</summary>

    [Test]
    public static void CODECAPI_CURRENTCHANGELISTTest()
    {
        Assert.That(
            CODECAPI_CURRENTCHANGELIST,
            Is.EqualTo(
                new Guid(0x1cb14e83, 0x7d72, 0x4657, 0x83, 0xfd, 0x47, 0xa2, 0xc5, 0xb9, 0xd1, 0x3d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "CODECAPI_AVDecMmcssClass"/> property is correct.</summary>

    [Test]
    public static void CODECAPI_AVDecMmcssClassTest()
    {
        Assert.That(
            CODECAPI_AVDecMmcssClass,
            Is.EqualTo(
                new Guid(0xe0ad4828, 0xdf66, 0x4893, 0x9f, 0x33, 0x78, 0x8a, 0xa4, 0xec, 0x40, 0x82)
            )
        );
    }
}
