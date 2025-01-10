// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.MFT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MFT"/> class.</summary>
public static partial class MFTTests
{
    /// <summary>Validates that the value of the <see cref = "MFT_END_STREAMING_AWARE"/> property is correct.</summary>

    [Test]
    public static void MFT_END_STREAMING_AWARETest()
    {
        Assert.That(
            MFT_END_STREAMING_AWARE,
            Is.EqualTo(
                new Guid(0x70fbc845, 0xb07e, 0x4089, 0xb0, 0x64, 0x39, 0x9d, 0xc6, 0x11, 0xf, 0x29)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_AUDIO_DECODER_AUDIO_ENDPOINT_ID"/> property is correct.</summary>

    [Test]
    public static void MFT_AUDIO_DECODER_AUDIO_ENDPOINT_IDTest()
    {
        Assert.That(
            MFT_AUDIO_DECODER_AUDIO_ENDPOINT_ID,
            Is.EqualTo(
                new Guid(0xc7ccdd6e, 0x5398, 0x4695, 0x8b, 0xe7, 0x51, 0xb3, 0xe9, 0x51, 0x11, 0xbd)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_AUDIO_DECODER_SPATIAL_METADATA_CLIENT"/> property is correct.</summary>

    [Test]
    public static void MFT_AUDIO_DECODER_SPATIAL_METADATA_CLIENTTest()
    {
        Assert.That(
            MFT_AUDIO_DECODER_SPATIAL_METADATA_CLIENT,
            Is.EqualTo(
                new Guid(0x5987df4, 0x1270, 0x4999, 0x92, 0x5f, 0x8e, 0x93, 0x9a, 0x7c, 0xa, 0xf7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_AUDIO_DECODER_AUDIO_ENDPOINT_FORMFACTOR"/> property is correct.</summary>

    [Test]
    public static void MFT_AUDIO_DECODER_AUDIO_ENDPOINT_FORMFACTORTest()
    {
        Assert.That(
            MFT_AUDIO_DECODER_AUDIO_ENDPOINT_FORMFACTOR,
            Is.EqualTo(
                new Guid(0x8d574310, 0x909a, 0x433a, 0xac, 0xe7, 0xee, 0xe7, 0x47, 0x19, 0xf9, 0x01)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_AUDIO_DECODER_AUDIO_ENDPOINT_IS_DIGITAL_STEREO_ONLY"/> property is correct.</summary>

    [Test]
    public static void MFT_AUDIO_DECODER_AUDIO_ENDPOINT_IS_DIGITAL_STEREO_ONLYTest()
    {
        Assert.That(
            MFT_AUDIO_DECODER_AUDIO_ENDPOINT_IS_DIGITAL_STEREO_ONLY,
            Is.EqualTo(
                new Guid(0x26e5a90d, 0x4ad1, 0x4f8c, 0xb8, 0xaf, 0xad, 0xf1, 0x4d, 0x21, 0x78, 0xf1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_SUPPORT_3DVIDEO"/> property is correct.</summary>

    [Test]
    public static void MFT_SUPPORT_3DVIDEOTest()
    {
        Assert.That(
            MFT_SUPPORT_3DVIDEO,
            Is.EqualTo(
                new Guid(0x93f81b1, 0x4f2e, 0x4631, 0x81, 0x68, 0x79, 0x34, 0x3, 0x2a, 0x1, 0xd3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_DECODER_EXPOSE_OUTPUT_TYPES_IN_NATIVE_ORDER"/> property is correct.</summary>

    [Test]
    public static void MFT_DECODER_EXPOSE_OUTPUT_TYPES_IN_NATIVE_ORDERTest()
    {
        Assert.That(
            MFT_DECODER_EXPOSE_OUTPUT_TYPES_IN_NATIVE_ORDER,
            Is.EqualTo(
                new Guid(0xef80833f, 0xf8fa, 0x44d9, 0x80, 0xd8, 0x41, 0xed, 0x62, 0x32, 0x67, 0xc)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_DECODER_QUALITY_MANAGEMENT_CUSTOM_CONTROL"/> property is correct.</summary>

    [Test]
    public static void MFT_DECODER_QUALITY_MANAGEMENT_CUSTOM_CONTROLTest()
    {
        Assert.That(
            MFT_DECODER_QUALITY_MANAGEMENT_CUSTOM_CONTROL,
            Is.EqualTo(
                new Guid(0xa24e30d7, 0xde25, 0x4558, 0xbb, 0xfb, 0x71, 0x7, 0xa, 0x2d, 0x33, 0x2e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_DECODER_QUALITY_MANAGEMENT_RECOVERY_WITHOUT_ARTIFACTS"/> property is correct.</summary>

    [Test]
    public static void MFT_DECODER_QUALITY_MANAGEMENT_RECOVERY_WITHOUT_ARTIFACTSTest()
    {
        Assert.That(
            MFT_DECODER_QUALITY_MANAGEMENT_RECOVERY_WITHOUT_ARTIFACTS,
            Is.EqualTo(
                new Guid(0xd8980deb, 0xa48, 0x425f, 0x86, 0x23, 0x61, 0x1d, 0xb4, 0x1d, 0x38, 0x10)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_DECODER_OPERATING_POINT"/> property is correct.</summary>

    [Test]
    public static void MFT_DECODER_OPERATING_POINTTest()
    {
        Assert.That(
            MFT_DECODER_OPERATING_POINT,
            Is.EqualTo(
                new Guid(0xa1230334, 0x55d4, 0x4d97, 0x82, 0xa7, 0x26, 0xd3, 0xe6, 0x45, 0x67, 0x25)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_DECODER_AUTOMATIC_SOFTWARE_FALLBACK"/> property is correct.</summary>

    [Test]
    public static void MFT_DECODER_AUTOMATIC_SOFTWARE_FALLBACKTest()
    {
        Assert.That(
            MFT_DECODER_AUTOMATIC_SOFTWARE_FALLBACK,
            Is.EqualTo(
                new Guid(0x41f34f53, 0x1bf6, 0x49ed, 0xb9, 0x5d, 0x2, 0xd2, 0xa1, 0xd7, 0x11, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_REMUX_MARK_I_PICTURE_AS_CLEAN_POINT"/> property is correct.</summary>

    [Test]
    public static void MFT_REMUX_MARK_I_PICTURE_AS_CLEAN_POINTTest()
    {
        Assert.That(
            MFT_REMUX_MARK_I_PICTURE_AS_CLEAN_POINT,
            Is.EqualTo(
                new Guid(0x364e8f85, 0x3f2e, 0x436c, 0xb2, 0xa2, 0x44, 0x40, 0xa0, 0x12, 0xa9, 0xe8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_DECODER_FINAL_VIDEO_RESOLUTION_HINT"/> property is correct.</summary>

    [Test]
    public static void MFT_DECODER_FINAL_VIDEO_RESOLUTION_HINTTest()
    {
        Assert.That(
            MFT_DECODER_FINAL_VIDEO_RESOLUTION_HINT,
            Is.EqualTo(
                new Guid(0xdc2f8496, 0x15c4, 0x407a, 0xb6, 0xf0, 0x1b, 0x66, 0xab, 0x5f, 0xbf, 0x53)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_ENCODER_SUPPORTS_CONFIG_EVENT"/> property is correct.</summary>

    [Test]
    public static void MFT_ENCODER_SUPPORTS_CONFIG_EVENTTest()
    {
        Assert.That(
            MFT_ENCODER_SUPPORTS_CONFIG_EVENT,
            Is.EqualTo(
                new Guid(0x86a355ae, 0x3a77, 0x4ec4, 0x9f, 0x31, 0x1, 0x14, 0x9a, 0x4e, 0x92, 0xde)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_ENUM_HARDWARE_VENDOR_ID_Attribute"/> property is correct.</summary>

    [Test]
    public static void MFT_ENUM_HARDWARE_VENDOR_ID_AttributeTest()
    {
        Assert.That(
            MFT_ENUM_HARDWARE_VENDOR_ID_Attribute,
            Is.EqualTo(
                new Guid(0x3aecb0cc, 0x35b, 0x4bcc, 0x81, 0x85, 0x2b, 0x8d, 0x55, 0x1e, 0xf3, 0xaf)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_TRANSFORM_CLSID_Attribute"/> property is correct.</summary>

    [Test]
    public static void MFT_TRANSFORM_CLSID_AttributeTest()
    {
        Assert.That(
            MFT_TRANSFORM_CLSID_Attribute,
            Is.EqualTo(
                new Guid(0x6821c42b, 0x65a4, 0x4e82, 0x99, 0xbc, 0x9a, 0x88, 0x20, 0x5e, 0xcd, 0xc)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_INPUT_TYPES_Attributes"/> property is correct.</summary>

    [Test]
    public static void MFT_INPUT_TYPES_AttributesTest()
    {
        Assert.That(
            MFT_INPUT_TYPES_Attributes,
            Is.EqualTo(
                new Guid(0x4276c9b1, 0x759d, 0x4bf3, 0x9c, 0xd0, 0xd, 0x72, 0x3d, 0x13, 0x8f, 0x96)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_OUTPUT_TYPES_Attributes"/> property is correct.</summary>

    [Test]
    public static void MFT_OUTPUT_TYPES_AttributesTest()
    {
        Assert.That(
            MFT_OUTPUT_TYPES_Attributes,
            Is.EqualTo(
                new Guid(0x8eae8cf3, 0xa44f, 0x4306, 0xba, 0x5c, 0xbf, 0x5d, 0xda, 0x24, 0x28, 0x18)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_ENUM_HARDWARE_URL_Attribute"/> property is correct.</summary>

    [Test]
    public static void MFT_ENUM_HARDWARE_URL_AttributeTest()
    {
        Assert.That(
            MFT_ENUM_HARDWARE_URL_Attribute,
            Is.EqualTo(
                new Guid(0x2fb866ac, 0xb078, 0x4942, 0xab, 0x6c, 0x0, 0x3d, 0x5, 0xcd, 0xa6, 0x74)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_FRIENDLY_NAME_Attribute"/> property is correct.</summary>

    [Test]
    public static void MFT_FRIENDLY_NAME_AttributeTest()
    {
        Assert.That(
            MFT_FRIENDLY_NAME_Attribute,
            Is.EqualTo(
                new Guid(0x314ffbae, 0x5b41, 0x4c95, 0x9c, 0x19, 0x4e, 0x7d, 0x58, 0x6f, 0xac, 0xe3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CONNECTED_STREAM_ATTRIBUTE"/> property is correct.</summary>

    [Test]
    public static void MFT_CONNECTED_STREAM_ATTRIBUTETest()
    {
        Assert.That(
            MFT_CONNECTED_STREAM_ATTRIBUTE,
            Is.EqualTo(
                new Guid(0x71eeb820, 0xa59f, 0x4de2, 0xbc, 0xec, 0x38, 0xdb, 0x1d, 0xd6, 0x11, 0xa4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CONNECTED_TO_HW_STREAM"/> property is correct.</summary>

    [Test]
    public static void MFT_CONNECTED_TO_HW_STREAMTest()
    {
        Assert.That(
            MFT_CONNECTED_TO_HW_STREAM,
            Is.EqualTo(
                new Guid(0x34e6e728, 0x6d6, 0x4491, 0xa5, 0x53, 0x47, 0x95, 0x65, 0xd, 0xb9, 0x12)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_PREFERRED_OUTPUTTYPE_Attribute"/> property is correct.</summary>

    [Test]
    public static void MFT_PREFERRED_OUTPUTTYPE_AttributeTest()
    {
        Assert.That(
            MFT_PREFERRED_OUTPUTTYPE_Attribute,
            Is.EqualTo(
                new Guid(0x7e700499, 0x396a, 0x49ee, 0xb1, 0xb4, 0xf6, 0x28, 0x2, 0x1e, 0x8c, 0x9d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_PROCESS_LOCAL_Attribute"/> property is correct.</summary>

    [Test]
    public static void MFT_PROCESS_LOCAL_AttributeTest()
    {
        Assert.That(
            MFT_PROCESS_LOCAL_Attribute,
            Is.EqualTo(
                new Guid(0x543186e4, 0x4649, 0x4e65, 0xb5, 0x88, 0x4a, 0xa3, 0x52, 0xaf, 0xf3, 0x79)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_PREFERRED_ENCODER_PROFILE"/> property is correct.</summary>

    [Test]
    public static void MFT_PREFERRED_ENCODER_PROFILETest()
    {
        Assert.That(
            MFT_PREFERRED_ENCODER_PROFILE,
            Is.EqualTo(
                new Guid(0x53004909, 0x1ef5, 0x46d7, 0xa1, 0x8e, 0x5a, 0x75, 0xf8, 0xb5, 0x90, 0x5f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_HW_TIMESTAMP_WITH_QPC_Attribute"/> property is correct.</summary>

    [Test]
    public static void MFT_HW_TIMESTAMP_WITH_QPC_AttributeTest()
    {
        Assert.That(
            MFT_HW_TIMESTAMP_WITH_QPC_Attribute,
            Is.EqualTo(
                new Guid(0x8d030fb8, 0xcc43, 0x4258, 0xa2, 0x2e, 0x92, 0x10, 0xbe, 0xf8, 0x9b, 0xe4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_FIELDOFUSE_UNLOCK_Attribute"/> property is correct.</summary>

    [Test]
    public static void MFT_FIELDOFUSE_UNLOCK_AttributeTest()
    {
        Assert.That(
            MFT_FIELDOFUSE_UNLOCK_Attribute,
            Is.EqualTo(
                new Guid(0x8ec2e9fd, 0x9148, 0x410d, 0x83, 0x1e, 0x70, 0x24, 0x39, 0x46, 0x1a, 0x8e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_CODEC_MERIT_Attribute"/> property is correct.</summary>

    [Test]
    public static void MFT_CODEC_MERIT_AttributeTest()
    {
        Assert.That(
            MFT_CODEC_MERIT_Attribute,
            Is.EqualTo(
                new Guid(0x88a7cb15, 0x7b07, 0x4a34, 0x91, 0x28, 0xe6, 0x4c, 0x67, 0x3, 0xc4, 0xd3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_ENUM_TRANSCODE_ONLY_ATTRIBUTE"/> property is correct.</summary>

    [Test]
    public static void MFT_ENUM_TRANSCODE_ONLY_ATTRIBUTETest()
    {
        Assert.That(
            MFT_ENUM_TRANSCODE_ONLY_ATTRIBUTE,
            Is.EqualTo(
                new Guid(0x111ea8cd, 0xb62a, 0x4bdb, 0x89, 0xf6, 0x67, 0xff, 0xcd, 0xc2, 0x45, 0x8b)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_AUDIO_DECODER_DEGRADATION_INFO_ATTRIBUTE"/> property is correct.</summary>

    [Test]
    public static void MFT_AUDIO_DECODER_DEGRADATION_INFO_ATTRIBUTETest()
    {
        Assert.That(
            MFT_AUDIO_DECODER_DEGRADATION_INFO_ATTRIBUTE,
            Is.EqualTo(
                new Guid(0x6c3386ad, 0xec20, 0x430d, 0xb2, 0xa5, 0x50, 0x5c, 0x71, 0x78, 0xd9, 0xc4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_POLICY_SET_AWARE"/> property is correct.</summary>

    [Test]
    public static void MFT_POLICY_SET_AWARETest()
    {
        Assert.That(
            MFT_POLICY_SET_AWARE,
            Is.EqualTo(
                new Guid(0x5a633b19, 0xcc39, 0x4fa8, 0x8c, 0xa5, 0x59, 0x98, 0x1b, 0x7a, 0x0, 0x18)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFT_USING_HARDWARE_DRM"/> property is correct.</summary>

    [Test]
    public static void MFT_USING_HARDWARE_DRMTest()
    {
        Assert.That(
            MFT_USING_HARDWARE_DRM,
            Is.EqualTo(
                new Guid(0x34faa77d, 0xd79e, 0x4957, 0xb8, 0xce, 0x36, 0x2b, 0x26, 0x84, 0x99, 0x6c)
            )
        );
    }
}
