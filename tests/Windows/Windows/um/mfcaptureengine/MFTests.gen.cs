// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.MF;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MF"/> class.</summary>
public static partial class MFTests
{
    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_INITIALIZED"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_INITIALIZEDTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_INITIALIZED, Is.EqualTo(new Guid(0x219992bc, 0xcf92, 0x4531, 0xa1, 0xae, 0x96, 0xe1, 0xe8, 0x86, 0xc8, 0xf1)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_PREVIEW_STARTED"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_PREVIEW_STARTEDTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_PREVIEW_STARTED, Is.EqualTo(new Guid(0xa416df21, 0xf9d3, 0x4a74, 0x99, 0x1b, 0xb8, 0x17, 0x29, 0x89, 0x52, 0xc4)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_PREVIEW_STOPPED"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_PREVIEW_STOPPEDTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_PREVIEW_STOPPED, Is.EqualTo(new Guid(0x13d5143c, 0x1edd, 0x4e50, 0xa2, 0xef, 0x35, 0x0a, 0x47, 0x67, 0x80, 0x60)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_RECORD_STARTED"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_RECORD_STARTEDTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_RECORD_STARTED, Is.EqualTo(new Guid(0xac2b027b, 0xddf9, 0x48a0, 0x89, 0xbe, 0x38, 0xab, 0x35, 0xef, 0x45, 0xc0)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_RECORD_STOPPED"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_RECORD_STOPPEDTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_RECORD_STOPPED, Is.EqualTo(new Guid(0x55e5200a, 0xf98f, 0x4c0d, 0xa9, 0xec, 0x9e, 0xb2, 0x5e, 0xd3, 0xd7, 0x73)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_PHOTO_TAKEN"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_PHOTO_TAKENTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_PHOTO_TAKEN, Is.EqualTo(new Guid(0x3c50c445, 0x7304, 0x48eb, 0x86, 0x5d, 0xbb, 0xa1, 0x9b, 0xa3, 0xaf, 0x5c)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_SOURCE_CURRENT_DEVICE_MEDIA_TYPE_SET"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_SOURCE_CURRENT_DEVICE_MEDIA_TYPE_SETTest()
    {
        Assert.That(MF_CAPTURE_SOURCE_CURRENT_DEVICE_MEDIA_TYPE_SET, Is.EqualTo(new Guid(0xe7e75e4c, 0x039c, 0x4410, 0x81, 0x5b, 0x87, 0x41, 0x30, 0x7b, 0x63, 0xaa)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_ERROR"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_ERRORTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_ERROR, Is.EqualTo(new Guid(0x46b89fc6, 0x33cc, 0x4399, 0x9d, 0xad, 0x78, 0x4d, 0xe7, 0x7d, 0x58, 0x7c)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_EFFECT_ADDED"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_EFFECT_ADDEDTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_EFFECT_ADDED, Is.EqualTo(new Guid(0xaa8dc7b5, 0xa048, 0x4e13, 0x8e, 0xbe, 0xf2, 0x3c, 0x46, 0xc8, 0x30, 0xc1)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_EFFECT_REMOVED"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_EFFECT_REMOVEDTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_EFFECT_REMOVED, Is.EqualTo(new Guid(0xc6e8db07, 0xfb09, 0x4a48, 0x89, 0xc6, 0xbf, 0x92, 0xa0, 0x42, 0x22, 0xc9)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_ALL_EFFECTS_REMOVED"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_ALL_EFFECTS_REMOVEDTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_ALL_EFFECTS_REMOVED, Is.EqualTo(new Guid(0xfded7521, 0x8ed8, 0x431a, 0xa9, 0x6b, 0xf3, 0xe2, 0x56, 0x5e, 0x98, 0x1c)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_SINK_PREPARED"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_SINK_PREPAREDTest()
    {
        Assert.That(MF_CAPTURE_SINK_PREPARED, Is.EqualTo(new Guid(0x7BFCE257, 0x12B1, 0x4409, 0x8C, 0x34, 0xD4, 0x45, 0xDA, 0xAB, 0x75, 0x78)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_OUTPUT_MEDIA_TYPE_SET"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_OUTPUT_MEDIA_TYPE_SETTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_OUTPUT_MEDIA_TYPE_SET, Is.EqualTo(new Guid(0xcaaad994, 0x83ec, 0x45e9, 0xa3, 0x0a, 0x1f, 0x20, 0xaa, 0xdb, 0x98, 0x31)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_CAMERA_STREAM_BLOCKED"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_CAMERA_STREAM_BLOCKEDTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_CAMERA_STREAM_BLOCKED, Is.EqualTo(new Guid(0xA4209417, 0x8D39, 0x46F3, 0xB7, 0x59, 0x59, 0x12, 0x52, 0x8F, 0x42, 0x07)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_CAMERA_STREAM_UNBLOCKED"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_CAMERA_STREAM_UNBLOCKEDTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_CAMERA_STREAM_UNBLOCKED, Is.EqualTo(new Guid(0x9BE9EEF0, 0xCDAF, 0x4717, 0x85, 0x64, 0x83, 0x4A, 0xAE, 0x66, 0x41, 0x5C)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_D3D_MANAGER"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_D3D_MANAGERTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_D3D_MANAGER, Is.EqualTo(new Guid(0x76e25e7b, 0xd595, 0x4283, 0x96, 0x2c, 0xc5, 0x94, 0xaf, 0xd7, 0x8d, 0xdf)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_RECORD_SINK_VIDEO_MAX_UNPROCESSED_SAMPLES"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_RECORD_SINK_VIDEO_MAX_UNPROCESSED_SAMPLESTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_RECORD_SINK_VIDEO_MAX_UNPROCESSED_SAMPLES, Is.EqualTo(new Guid(0xb467f705, 0x7913, 0x4894, 0x9d, 0x42, 0xa2, 0x15, 0xfe, 0xa2, 0x3d, 0xa9)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_RECORD_SINK_AUDIO_MAX_UNPROCESSED_SAMPLES"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_RECORD_SINK_AUDIO_MAX_UNPROCESSED_SAMPLESTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_RECORD_SINK_AUDIO_MAX_UNPROCESSED_SAMPLES, Is.EqualTo(new Guid(0x1cddb141, 0xa7f4, 0x4d58, 0x98, 0x96, 0x4d, 0x15, 0xa5, 0x3c, 0x4e, 0xfe)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_RECORD_SINK_VIDEO_MAX_PROCESSED_SAMPLES"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_RECORD_SINK_VIDEO_MAX_PROCESSED_SAMPLESTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_RECORD_SINK_VIDEO_MAX_PROCESSED_SAMPLES, Is.EqualTo(new Guid(0xe7b4a49e, 0x382c, 0x4aef, 0xa9, 0x46, 0xae, 0xd5, 0x49, 0xb, 0x71, 0x11)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_RECORD_SINK_AUDIO_MAX_PROCESSED_SAMPLES"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_RECORD_SINK_AUDIO_MAX_PROCESSED_SAMPLESTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_RECORD_SINK_AUDIO_MAX_PROCESSED_SAMPLES, Is.EqualTo(new Guid(0x9896e12a, 0xf707, 0x4500, 0xb6, 0xbd, 0xdb, 0x8e, 0xb8, 0x10, 0xb5, 0xf)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_USE_AUDIO_DEVICE_ONLY"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_USE_AUDIO_DEVICE_ONLYTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_USE_AUDIO_DEVICE_ONLY, Is.EqualTo(new Guid(0x1c8077da, 0x8466, 0x4dc4, 0x8b, 0x8e, 0x27, 0x6b, 0x3f, 0x85, 0x92, 0x3b)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_USE_VIDEO_DEVICE_ONLY"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_USE_VIDEO_DEVICE_ONLYTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_USE_VIDEO_DEVICE_ONLY, Is.EqualTo(new Guid(0x7e025171, 0xcf32, 0x4f2e, 0x8f, 0x19, 0x41, 0x5, 0x77, 0xb7, 0x3a, 0x66)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_DISABLE_HARDWARE_TRANSFORMS"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_DISABLE_HARDWARE_TRANSFORMSTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_DISABLE_HARDWARE_TRANSFORMS, Is.EqualTo(new Guid(0xb7c42a6b, 0x3207, 0x4495, 0xb4, 0xe7, 0x81, 0xf9, 0xc3, 0x5d, 0x59, 0x91)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_DISABLE_DXVA"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_DISABLE_DXVATest()
    {
        Assert.That(MF_CAPTURE_ENGINE_DISABLE_DXVA, Is.EqualTo(new Guid(0xf9818862, 0x179d, 0x433f, 0xa3, 0x2f, 0x74, 0xcb, 0xcf, 0x74, 0x46, 0x6d)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_MEDIASOURCE_CONFIG"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_MEDIASOURCE_CONFIGTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_MEDIASOURCE_CONFIG, Is.EqualTo(new Guid(0xbc6989d2, 0x0fc1, 0x46e1, 0xa7, 0x4f, 0xef, 0xd3, 0x6b, 0xc7, 0x88, 0xde)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_DECODER_MFT_FIELDOFUSE_UNLOCK_Attribute"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_DECODER_MFT_FIELDOFUSE_UNLOCK_AttributeTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_DECODER_MFT_FIELDOFUSE_UNLOCK_Attribute, Is.EqualTo(new Guid(0x2b8ad2e8, 0x7acb, 0x4321, 0xa6, 0x06, 0x32, 0x5c, 0x42, 0x49, 0xf4, 0xfc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_ENCODER_MFT_FIELDOFUSE_UNLOCK_Attribute"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_ENCODER_MFT_FIELDOFUSE_UNLOCK_AttributeTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_ENCODER_MFT_FIELDOFUSE_UNLOCK_Attribute, Is.EqualTo(new Guid(0x54c63a00, 0x78d5, 0x422f, 0xaa, 0x3e, 0x5e, 0x99, 0xac, 0x64, 0x92, 0x69)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_ENABLE_CAMERA_STREAMSTATE_NOTIFICATION"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_ENABLE_CAMERA_STREAMSTATE_NOTIFICATIONTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_ENABLE_CAMERA_STREAMSTATE_NOTIFICATION, Is.EqualTo(new Guid(0x4C808E9D, 0xAAED, 0x4713, 0x90, 0xFB, 0xCB, 0x24, 0x06, 0x4A, 0xB8, 0xDA)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_MEDIA_CATEGORY"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_MEDIA_CATEGORYTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_MEDIA_CATEGORY, Is.EqualTo(new Guid(0x8e3f5bd5, 0xdbbf, 0x42f0, 0x85, 0x42, 0xd0, 0x7a, 0x39, 0x71, 0x76, 0x2a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_AUDIO_PROCESSING"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_AUDIO_PROCESSINGTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_AUDIO_PROCESSING, Is.EqualTo(new Guid(0x10f1be5e, 0x7e11, 0x410b, 0x97, 0x3d, 0xf4, 0xb6, 0x10, 0x90, 0x0, 0xfe)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_EVENT_GENERATOR_GUID"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_EVENT_GENERATOR_GUIDTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_EVENT_GENERATOR_GUID, Is.EqualTo(new Guid(0xabfa8ad5, 0xfc6d, 0x4911, 0x87, 0xe0, 0x96, 0x19, 0x45, 0xf8, 0xf7, 0xce)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_EVENT_STREAM_INDEX"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_EVENT_STREAM_INDEXTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_EVENT_STREAM_INDEX, Is.EqualTo(new Guid(0x82697f44, 0xb1cf, 0x42eb, 0x97, 0x53, 0xf8, 0x6d, 0x64, 0x9c, 0x88, 0x65)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_SELECTEDCAMERAPROFILE"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_SELECTEDCAMERAPROFILETest()
    {
        Assert.That(MF_CAPTURE_ENGINE_SELECTEDCAMERAPROFILE, Is.EqualTo(new Guid(0x03160B7E, 0x1C6F, 0x4DB2, 0xAD, 0x56, 0xA7, 0xC4, 0x30, 0xF8, 0x23, 0x92)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CAPTURE_ENGINE_SELECTEDCAMERAPROFILE_INDEX"/> property is correct.</summary>
    [Test]
    public static void MF_CAPTURE_ENGINE_SELECTEDCAMERAPROFILE_INDEXTest()
    {
        Assert.That(MF_CAPTURE_ENGINE_SELECTEDCAMERAPROFILE_INDEX, Is.EqualTo(new Guid(0x3CE88613, 0x2214, 0x46C3, 0xB4, 0x17, 0x82, 0xF8, 0xA3, 0x13, 0xC9, 0xC3)));
    }
}