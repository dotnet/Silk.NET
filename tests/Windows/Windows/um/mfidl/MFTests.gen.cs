// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.MF;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MF"/> class.</summary>
public static partial class MFTests
{
    /// <summary>Validates that the value of the <see cref = "MF_WVC1_PROG_SINGLE_SLICE_CONTENT"/> property is correct.</summary>
    [Test]
    public static void MF_WVC1_PROG_SINGLE_SLICE_CONTENTTest()
    {
        Assert.That(MF_WVC1_PROG_SINGLE_SLICE_CONTENT, Is.EqualTo(new Guid(0x67EC2559, 0x0F2F, 0x4420, 0xA4, 0xDD, 0x2F, 0x8E, 0xE7, 0xA5, 0x73, 0x8B)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PROGRESSIVE_CODING_CONTENT"/> property is correct.</summary>
    [Test]
    public static void MF_PROGRESSIVE_CODING_CONTENTTest()
    {
        Assert.That(MF_PROGRESSIVE_CODING_CONTENT, Is.EqualTo(new Guid(0x8F020EEA, 0x1508, 0x471F, 0x9D, 0xA6, 0x50, 0x7D, 0x7C, 0xFA, 0x40, 0xDB)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_NALU_LENGTH_SET"/> property is correct.</summary>
    [Test]
    public static void MF_NALU_LENGTH_SETTest()
    {
        Assert.That(MF_NALU_LENGTH_SET, Is.EqualTo(new Guid(0xA7911D53, 0x12A4, 0x4965, 0xAE, 0x70, 0x6E, 0xAD, 0xD6, 0xFF, 0x05, 0x51)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_NALU_LENGTH_INFORMATION"/> property is correct.</summary>
    [Test]
    public static void MF_NALU_LENGTH_INFORMATIONTest()
    {
        Assert.That(MF_NALU_LENGTH_INFORMATION, Is.EqualTo(new Guid(0x19124E7C, 0xAD4B, 0x465F, 0xBB, 0x18, 0x20, 0x18, 0x62, 0x87, 0xB6, 0xAF)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_USER_DATA_PAYLOAD"/> property is correct.</summary>
    [Test]
    public static void MF_USER_DATA_PAYLOADTest()
    {
        Assert.That(MF_USER_DATA_PAYLOAD, Is.EqualTo(new Guid(0xd1d4985d, 0xdc92, 0x457a, 0xb3, 0xa0, 0x65, 0x1a, 0x33, 0xa3, 0x10, 0x47)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_MPEG4SINK_SPSPPS_PASSTHROUGH"/> property is correct.</summary>
    [Test]
    public static void MF_MPEG4SINK_SPSPPS_PASSTHROUGHTest()
    {
        Assert.That(MF_MPEG4SINK_SPSPPS_PASSTHROUGH, Is.EqualTo(new Guid(0x5601a134, 0x2005, 0x4ad2, 0xb3, 0x7d, 0x22, 0xa6, 0xc5, 0x54, 0xde, 0xb2)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_MPEG4SINK_MOOV_BEFORE_MDAT"/> property is correct.</summary>
    [Test]
    public static void MF_MPEG4SINK_MOOV_BEFORE_MDATTest()
    {
        Assert.That(MF_MPEG4SINK_MOOV_BEFORE_MDAT, Is.EqualTo(new Guid(0xf672e3ac, 0xe1e6, 0x4f10, 0xb5, 0xec, 0x5f, 0x3b, 0x30, 0x82, 0x88, 0x16)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_MPEG4SINK_MINIMUM_PROPERTIES_SIZE"/> property is correct.</summary>
    [Test]
    public static void MF_MPEG4SINK_MINIMUM_PROPERTIES_SIZETest()
    {
        Assert.That(MF_MPEG4SINK_MINIMUM_PROPERTIES_SIZE, Is.EqualTo(new Guid(0xdca1ed52, 0x450e, 0x4a22, 0x8c, 0x62, 0x4e, 0xd4, 0x52, 0xf7, 0xa1, 0x87)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_MPEG4SINK_MIN_FRAGMENT_DURATION"/> property is correct.</summary>
    [Test]
    public static void MF_MPEG4SINK_MIN_FRAGMENT_DURATIONTest()
    {
        Assert.That(MF_MPEG4SINK_MIN_FRAGMENT_DURATION, Is.EqualTo(new Guid(0xa30b570c, 0x8efd, 0x45e8, 0x94, 0xfe, 0x27, 0xc8, 0x4b, 0x5b, 0xdf, 0xf6)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_MPEG4SINK_MAX_CODED_SEQUENCES_PER_FRAGMENT"/> property is correct.</summary>
    [Test]
    public static void MF_MPEG4SINK_MAX_CODED_SEQUENCES_PER_FRAGMENTTest()
    {
        Assert.That(MF_MPEG4SINK_MAX_CODED_SEQUENCES_PER_FRAGMENT, Is.EqualTo(new Guid(0xfc1b3bd6, 0x692d, 0x4ce5, 0x92, 0x99, 0x73, 0x8a, 0xa5, 0x46, 0x3e, 0x9a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SESSION_TOPOLOADER"/> property is correct.</summary>
    [Test]
    public static void MF_SESSION_TOPOLOADERTest()
    {
        Assert.That(MF_SESSION_TOPOLOADER, Is.EqualTo(new Guid(0x1e83d482, 0x1f1c, 0x4571, 0x84, 0x5, 0x88, 0xf4, 0xb2, 0x18, 0x1f, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SESSION_GLOBAL_TIME"/> property is correct.</summary>
    [Test]
    public static void MF_SESSION_GLOBAL_TIMETest()
    {
        Assert.That(MF_SESSION_GLOBAL_TIME, Is.EqualTo(new Guid(0x1e83d482, 0x1f1c, 0x4571, 0x84, 0x5, 0x88, 0xf4, 0xb2, 0x18, 0x1f, 0x72)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SESSION_QUALITY_MANAGER"/> property is correct.</summary>
    [Test]
    public static void MF_SESSION_QUALITY_MANAGERTest()
    {
        Assert.That(MF_SESSION_QUALITY_MANAGER, Is.EqualTo(new Guid(0x1e83d482, 0x1f1c, 0x4571, 0x84, 0x5, 0x88, 0xf4, 0xb2, 0x18, 0x1f, 0x73)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SESSION_CONTENT_PROTECTION_MANAGER"/> property is correct.</summary>
    [Test]
    public static void MF_SESSION_CONTENT_PROTECTION_MANAGERTest()
    {
        Assert.That(MF_SESSION_CONTENT_PROTECTION_MANAGER, Is.EqualTo(new Guid(0x1e83d482, 0x1f1c, 0x4571, 0x84, 0x5, 0x88, 0xf4, 0xb2, 0x18, 0x1f, 0x74)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SESSION_SERVER_CONTEXT"/> property is correct.</summary>
    [Test]
    public static void MF_SESSION_SERVER_CONTEXTTest()
    {
        Assert.That(MF_SESSION_SERVER_CONTEXT, Is.EqualTo(new Guid(0xafe5b291, 0x50fa, 0x46e8, 0xb9, 0xbe, 0xc, 0xc, 0x3c, 0xe4, 0xb3, 0xa5)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SESSION_REMOTE_SOURCE_MODE"/> property is correct.</summary>
    [Test]
    public static void MF_SESSION_REMOTE_SOURCE_MODETest()
    {
        Assert.That(MF_SESSION_REMOTE_SOURCE_MODE, Is.EqualTo(new Guid(0xf4033ef4, 0x9bb3, 0x4378, 0x94, 0x1f, 0x85, 0xa0, 0x85, 0x6b, 0xc2, 0x44)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SESSION_APPROX_EVENT_OCCURRENCE_TIME"/> property is correct.</summary>
    [Test]
    public static void MF_SESSION_APPROX_EVENT_OCCURRENCE_TIMETest()
    {
        Assert.That(MF_SESSION_APPROX_EVENT_OCCURRENCE_TIME, Is.EqualTo(new Guid(0x190e852f, 0x6238, 0x42d1, 0xb5, 0xaf, 0x69, 0xea, 0x33, 0x8e, 0xf8, 0x50)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PMP_SERVER_CONTEXT"/> property is correct.</summary>
    [Test]
    public static void MF_PMP_SERVER_CONTEXTTest()
    {
        Assert.That(MF_PMP_SERVER_CONTEXT, Is.EqualTo(new Guid(0x2f00c910, 0xd2cf, 0x4278, 0x8b, 0x6a, 0xd0, 0x77, 0xfa, 0xc3, 0xa2, 0x5f)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TIME_FORMAT_ENTRY_RELATIVE"/> property is correct.</summary>
    [Test]
    public static void MF_TIME_FORMAT_ENTRY_RELATIVETest()
    {
        Assert.That(MF_TIME_FORMAT_ENTRY_RELATIVE, Is.EqualTo(new Guid(0x4399f178, 0x46d3, 0x4504, 0xaf, 0xda, 0x20, 0xd3, 0x2e, 0x9b, 0xa3, 0x60)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_STREAM_SUPPORTS_HW_CONNECTION"/> property is correct.</summary>
    [Test]
    public static void MF_SOURCE_STREAM_SUPPORTS_HW_CONNECTIONTest()
    {
        Assert.That(MF_SOURCE_STREAM_SUPPORTS_HW_CONNECTION, Is.EqualTo(new Guid(0xa38253aa, 0x6314, 0x42fd, 0xa3, 0xce, 0xbb, 0x27, 0xb6, 0x85, 0x99, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_STREAM_SINK_SUPPORTS_HW_CONNECTION"/> property is correct.</summary>
    [Test]
    public static void MF_STREAM_SINK_SUPPORTS_HW_CONNECTIONTest()
    {
        Assert.That(MF_STREAM_SINK_SUPPORTS_HW_CONNECTION, Is.EqualTo(new Guid(0x9b465cbf, 0x597, 0x4f9e, 0x9f, 0x3c, 0xb9, 0x7e, 0xee, 0xf9, 0x3, 0x59)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_STREAM_SINK_SUPPORTS_ROTATION"/> property is correct.</summary>
    [Test]
    public static void MF_STREAM_SINK_SUPPORTS_ROTATIONTest()
    {
        Assert.That(MF_STREAM_SINK_SUPPORTS_ROTATION, Is.EqualTo(new Guid(0xb3e96280, 0xbd05, 0x41a5, 0x97, 0xad, 0x8a, 0x7f, 0xee, 0x24, 0xb9, 0x12)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SINK_VIDEO_PTS"/> property is correct.</summary>
    [Test]
    public static void MF_SINK_VIDEO_PTSTest()
    {
        Assert.That(MF_SINK_VIDEO_PTS, Is.EqualTo(new Guid(0x2162bde7, 0x421e, 0x4b90, 0x9b, 0x33, 0xe5, 0x8f, 0xbf, 0x1d, 0x58, 0xb6)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SINK_VIDEO_NATIVE_WIDTH"/> property is correct.</summary>
    [Test]
    public static void MF_SINK_VIDEO_NATIVE_WIDTHTest()
    {
        Assert.That(MF_SINK_VIDEO_NATIVE_WIDTH, Is.EqualTo(new Guid(0xe6d6a707, 0x1505, 0x4747, 0x9b, 0x10, 0x72, 0xd2, 0xd1, 0x58, 0xcb, 0x3a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SINK_VIDEO_NATIVE_HEIGHT"/> property is correct.</summary>
    [Test]
    public static void MF_SINK_VIDEO_NATIVE_HEIGHTTest()
    {
        Assert.That(MF_SINK_VIDEO_NATIVE_HEIGHT, Is.EqualTo(new Guid(0xf0ca6705, 0x490c, 0x43e8, 0x94, 0x1c, 0xc0, 0xb3, 0x20, 0x6b, 0x9a, 0x65)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SINK_VIDEO_DISPLAY_ASPECT_RATIO_NUMERATOR"/> property is correct.</summary>
    [Test]
    public static void MF_SINK_VIDEO_DISPLAY_ASPECT_RATIO_NUMERATORTest()
    {
        Assert.That(MF_SINK_VIDEO_DISPLAY_ASPECT_RATIO_NUMERATOR, Is.EqualTo(new Guid(0xd0f33b22, 0xb78a, 0x4879, 0xb4, 0x55, 0xf0, 0x3e, 0xf3, 0xfa, 0x82, 0xcd)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SINK_VIDEO_DISPLAY_ASPECT_RATIO_DENOMINATOR"/> property is correct.</summary>
    [Test]
    public static void MF_SINK_VIDEO_DISPLAY_ASPECT_RATIO_DENOMINATORTest()
    {
        Assert.That(MF_SINK_VIDEO_DISPLAY_ASPECT_RATIO_DENOMINATOR, Is.EqualTo(new Guid(0x6ea1eb97, 0x1fe0, 0x4f10, 0xa6, 0xe4, 0x1f, 0x4f, 0x66, 0x15, 0x64, 0xe0)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_BD_MVC_PLANE_OFFSET_METADATA"/> property is correct.</summary>
    [Test]
    public static void MF_BD_MVC_PLANE_OFFSET_METADATATest()
    {
        Assert.That(MF_BD_MVC_PLANE_OFFSET_METADATA, Is.EqualTo(new Guid(0x62a654e4, 0xb76c, 0x4901, 0x98, 0x23, 0x2c, 0xb6, 0x15, 0xd4, 0x73, 0x18)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_LUMA_KEY_ENABLE"/> property is correct.</summary>
    [Test]
    public static void MF_LUMA_KEY_ENABLETest()
    {
        Assert.That(MF_LUMA_KEY_ENABLE, Is.EqualTo(new Guid(0x7369820f, 0x76de, 0x43ca, 0x92, 0x84, 0x47, 0xb8, 0xf3, 0x7e, 0x06, 0x49)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_LUMA_KEY_LOWER"/> property is correct.</summary>
    [Test]
    public static void MF_LUMA_KEY_LOWERTest()
    {
        Assert.That(MF_LUMA_KEY_LOWER, Is.EqualTo(new Guid(0x93d7b8d5, 0x0b81, 0x4715, 0xae, 0xa0, 0x87, 0x25, 0x87, 0x16, 0x21, 0xe9)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_LUMA_KEY_UPPER"/> property is correct.</summary>
    [Test]
    public static void MF_LUMA_KEY_UPPERTest()
    {
        Assert.That(MF_LUMA_KEY_UPPER, Is.EqualTo(new Guid(0xd09f39bb, 0x4602, 0x4c31, 0xa7, 0x06, 0xa1, 0x21, 0x71, 0xa5, 0x11, 0x0a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_USER_EXTENDED_ATTRIBUTES"/> property is correct.</summary>
    [Test]
    public static void MF_USER_EXTENDED_ATTRIBUTESTest()
    {
        Assert.That(MF_USER_EXTENDED_ATTRIBUTES, Is.EqualTo(new Guid(0xc02abac6, 0xfeb2, 0x4541, 0x92, 0x2f, 0x92, 0x0b, 0x43, 0x70, 0x27, 0x22)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_INDEPENDENT_STILL_IMAGE"/> property is correct.</summary>
    [Test]
    public static void MF_INDEPENDENT_STILL_IMAGETest()
    {
        Assert.That(MF_INDEPENDENT_STILL_IMAGE, Is.EqualTo(new Guid(0xea12af41, 0x0710, 0x42c9, 0xa1, 0x27, 0xda, 0xa3, 0xe7, 0x84, 0x83, 0xa5)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_XVP_SAMPLE_LOCK_TIMEOUT"/> property is correct.</summary>
    [Test]
    public static void MF_XVP_SAMPLE_LOCK_TIMEOUTTest()
    {
        Assert.That(MF_XVP_SAMPLE_LOCK_TIMEOUT, Is.EqualTo(new Guid(0xaa4ddb29, 0x5134, 0x4363, 0xac, 0x72, 0x83, 0xec, 0x4b, 0xc1, 0x4, 0x26)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_PROJECTSTART"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_PROJECTSTARTTest()
    {
        Assert.That(MF_TOPOLOGY_PROJECTSTART, Is.EqualTo(new Guid(0x7ed3f802, 0x86bb, 0x4b3f, 0xb7, 0xe4, 0x7c, 0xb4, 0x3a, 0xfd, 0x4b, 0x80)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_PROJECTSTOP"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_PROJECTSTOPTest()
    {
        Assert.That(MF_TOPOLOGY_PROJECTSTOP, Is.EqualTo(new Guid(0x7ed3f803, 0x86bb, 0x4b3f, 0xb7, 0xe4, 0x7c, 0xb4, 0x3a, 0xfd, 0x4b, 0x80)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_NO_MARKIN_MARKOUT"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_NO_MARKIN_MARKOUTTest()
    {
        Assert.That(MF_TOPOLOGY_NO_MARKIN_MARKOUT, Is.EqualTo(new Guid(0x7ed3f804, 0x86bb, 0x4b3f, 0xb7, 0xe4, 0x7c, 0xb4, 0x3a, 0xfd, 0x4b, 0x80)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_DXVA_MODE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_DXVA_MODETest()
    {
        Assert.That(MF_TOPOLOGY_DXVA_MODE, Is.EqualTo(new Guid(0x1e8d34f6, 0xf5ab, 0x4e23, 0xbb, 0x88, 0x87, 0x4a, 0xa3, 0xa1, 0xa7, 0x4d)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_ENABLE_XVP_FOR_PLAYBACK"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_ENABLE_XVP_FOR_PLAYBACKTest()
    {
        Assert.That(MF_TOPOLOGY_ENABLE_XVP_FOR_PLAYBACK, Is.EqualTo(new Guid(0x1967731f, 0xcd78, 0x42fc, 0xb0, 0x26, 0x9, 0x92, 0xa5, 0x6e, 0x56, 0x93)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_STATIC_PLAYBACK_OPTIMIZATIONS"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_STATIC_PLAYBACK_OPTIMIZATIONSTest()
    {
        Assert.That(MF_TOPOLOGY_STATIC_PLAYBACK_OPTIMIZATIONS, Is.EqualTo(new Guid(0xb86cac42, 0x41a6, 0x4b79, 0x89, 0x7a, 0x1a, 0xb0, 0xe5, 0x2b, 0x4a, 0x1b)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_PLAYBACK_MAX_DIMS"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_PLAYBACK_MAX_DIMSTest()
    {
        Assert.That(MF_TOPOLOGY_PLAYBACK_MAX_DIMS, Is.EqualTo(new Guid(0x5715cf19, 0x5768, 0x44aa, 0xad, 0x6e, 0x87, 0x21, 0xf1, 0xb0, 0xf9, 0xbb)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_HARDWARE_MODE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_HARDWARE_MODETest()
    {
        Assert.That(MF_TOPOLOGY_HARDWARE_MODE, Is.EqualTo(new Guid(0xd2d362fd, 0x4e4f, 0x4191, 0xa5, 0x79, 0xc6, 0x18, 0xb6, 0x67, 0x6, 0xaf)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_PLAYBACK_FRAMERATE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_PLAYBACK_FRAMERATETest()
    {
        Assert.That(MF_TOPOLOGY_PLAYBACK_FRAMERATE, Is.EqualTo(new Guid(0xc164737a, 0xc2b1, 0x4553, 0x83, 0xbb, 0x5a, 0x52, 0x60, 0x72, 0x44, 0x8f)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_DYNAMIC_CHANGE_NOT_ALLOWED"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_DYNAMIC_CHANGE_NOT_ALLOWEDTest()
    {
        Assert.That(MF_TOPOLOGY_DYNAMIC_CHANGE_NOT_ALLOWED, Is.EqualTo(new Guid(0xd529950b, 0xd484, 0x4527, 0xa9, 0xcd, 0xb1, 0x90, 0x95, 0x32, 0xb5, 0xb0)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_ENUMERATE_SOURCE_TYPES"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_ENUMERATE_SOURCE_TYPESTest()
    {
        Assert.That(MF_TOPOLOGY_ENUMERATE_SOURCE_TYPES, Is.EqualTo(new Guid(0x6248c36d, 0x5d0b, 0x4f40, 0xa0, 0xbb, 0xb0, 0xb3, 0x05, 0xf7, 0x76, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_START_TIME_ON_PRESENTATION_SWITCH"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_START_TIME_ON_PRESENTATION_SWITCHTest()
    {
        Assert.That(MF_TOPOLOGY_START_TIME_ON_PRESENTATION_SWITCH, Is.EqualTo(new Guid(0xc8cc113f, 0x7951, 0x4548, 0xaa, 0xd6, 0x9e, 0xd6, 0x20, 0x2e, 0x62, 0xb3)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DISABLE_LOCALLY_REGISTERED_PLUGINS"/> property is correct.</summary>
    [Test]
    public static void MF_DISABLE_LOCALLY_REGISTERED_PLUGINSTest()
    {
        Assert.That(MF_DISABLE_LOCALLY_REGISTERED_PLUGINS, Is.EqualTo(new Guid(0x66b16da9, 0xadd4, 0x47e0, 0xa1, 0x6b, 0x5a, 0xf1, 0xfb, 0x48, 0x36, 0x34)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_LOCAL_PLUGIN_CONTROL_POLICY"/> property is correct.</summary>
    [Test]
    public static void MF_LOCAL_PLUGIN_CONTROL_POLICYTest()
    {
        Assert.That(MF_LOCAL_PLUGIN_CONTROL_POLICY, Is.EqualTo(new Guid(0xd91b0085, 0xc86d, 0x4f81, 0x88, 0x22, 0x8c, 0x68, 0xe1, 0xd7, 0xfa, 0x04)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_FLUSH"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_FLUSHTest()
    {
        Assert.That(MF_TOPONODE_FLUSH, Is.EqualTo(new Guid(0x494bbce8, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_DRAIN"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_DRAINTest()
    {
        Assert.That(MF_TOPONODE_DRAIN, Is.EqualTo(new Guid(0x494bbce9, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_D3DAWARE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_D3DAWARETest()
    {
        Assert.That(MF_TOPONODE_D3DAWARE, Is.EqualTo(new Guid(0x494bbced, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPOLOGY_RESOLUTION_STATUS"/> property is correct.</summary>
    [Test]
    public static void MF_TOPOLOGY_RESOLUTION_STATUSTest()
    {
        Assert.That(MF_TOPOLOGY_RESOLUTION_STATUS, Is.EqualTo(new Guid(0x494bbcde, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_ERRORCODE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_ERRORCODETest()
    {
        Assert.That(MF_TOPONODE_ERRORCODE, Is.EqualTo(new Guid(0x494bbcee, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_CONNECT_METHOD"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_CONNECT_METHODTest()
    {
        Assert.That(MF_TOPONODE_CONNECT_METHOD, Is.EqualTo(new Guid(0x494bbcf1, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_LOCKED"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_LOCKEDTest()
    {
        Assert.That(MF_TOPONODE_LOCKED, Is.EqualTo(new Guid(0x494bbcf7, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_WORKQUEUE_ID"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_WORKQUEUE_IDTest()
    {
        Assert.That(MF_TOPONODE_WORKQUEUE_ID, Is.EqualTo(new Guid(0x494bbcf8, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_WORKQUEUE_MMCSS_CLASS"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_WORKQUEUE_MMCSS_CLASSTest()
    {
        Assert.That(MF_TOPONODE_WORKQUEUE_MMCSS_CLASS, Is.EqualTo(new Guid(0x494bbcf9, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_DECRYPTOR"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_DECRYPTORTest()
    {
        Assert.That(MF_TOPONODE_DECRYPTOR, Is.EqualTo(new Guid(0x494bbcfa, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_DISCARDABLE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_DISCARDABLETest()
    {
        Assert.That(MF_TOPONODE_DISCARDABLE, Is.EqualTo(new Guid(0x494bbcfb, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_ERROR_MAJORTYPE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_ERROR_MAJORTYPETest()
    {
        Assert.That(MF_TOPONODE_ERROR_MAJORTYPE, Is.EqualTo(new Guid(0x494bbcfd, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_ERROR_SUBTYPE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_ERROR_SUBTYPETest()
    {
        Assert.That(MF_TOPONODE_ERROR_SUBTYPE, Is.EqualTo(new Guid(0x494bbcfe, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_WORKQUEUE_MMCSS_TASKID"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_WORKQUEUE_MMCSS_TASKIDTest()
    {
        Assert.That(MF_TOPONODE_WORKQUEUE_MMCSS_TASKID, Is.EqualTo(new Guid(0x494bbcff, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_WORKQUEUE_MMCSS_PRIORITY"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_WORKQUEUE_MMCSS_PRIORITYTest()
    {
        Assert.That(MF_TOPONODE_WORKQUEUE_MMCSS_PRIORITY, Is.EqualTo(new Guid(0x5001f840, 0x2816, 0x48f4, 0x93, 0x64, 0xad, 0x1e, 0xf6, 0x61, 0xa1, 0x23)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_WORKQUEUE_ITEM_PRIORITY"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_WORKQUEUE_ITEM_PRIORITYTest()
    {
        Assert.That(MF_TOPONODE_WORKQUEUE_ITEM_PRIORITY, Is.EqualTo(new Guid(0xa1ff99be, 0x5e97, 0x4a53, 0xb4, 0x94, 0x56, 0x8c, 0x64, 0x2c, 0x0f, 0xf3)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_MARKIN_HERE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_MARKIN_HERETest()
    {
        Assert.That(MF_TOPONODE_MARKIN_HERE, Is.EqualTo(new Guid(0x494bbd00, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_MARKOUT_HERE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_MARKOUT_HERETest()
    {
        Assert.That(MF_TOPONODE_MARKOUT_HERE, Is.EqualTo(new Guid(0x494bbd01, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_DECODER"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_DECODERTest()
    {
        Assert.That(MF_TOPONODE_DECODER, Is.EqualTo(new Guid(0x494bbd02, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_MEDIASTART"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_MEDIASTARTTest()
    {
        Assert.That(MF_TOPONODE_MEDIASTART, Is.EqualTo(new Guid(0x835c58ea, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_MEDIASTOP"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_MEDIASTOPTest()
    {
        Assert.That(MF_TOPONODE_MEDIASTOP, Is.EqualTo(new Guid(0x835c58eb, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_SOURCE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_SOURCETest()
    {
        Assert.That(MF_TOPONODE_SOURCE, Is.EqualTo(new Guid(0x835c58ec, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_PRESENTATION_DESCRIPTOR"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_PRESENTATION_DESCRIPTORTest()
    {
        Assert.That(MF_TOPONODE_PRESENTATION_DESCRIPTOR, Is.EqualTo(new Guid(0x835c58ed, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_STREAM_DESCRIPTOR"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_STREAM_DESCRIPTORTest()
    {
        Assert.That(MF_TOPONODE_STREAM_DESCRIPTOR, Is.EqualTo(new Guid(0x835c58ee, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_SEQUENCE_ELEMENTID"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_SEQUENCE_ELEMENTIDTest()
    {
        Assert.That(MF_TOPONODE_SEQUENCE_ELEMENTID, Is.EqualTo(new Guid(0x835c58ef, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_TRANSFORM_OBJECTID"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_TRANSFORM_OBJECTIDTest()
    {
        Assert.That(MF_TOPONODE_TRANSFORM_OBJECTID, Is.EqualTo(new Guid(0x88dcc0c9, 0x293e, 0x4e8b, 0x9a, 0xeb, 0xa, 0xd6, 0x4c, 0xc0, 0x16, 0xb0)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_STREAMID"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_STREAMIDTest()
    {
        Assert.That(MF_TOPONODE_STREAMID, Is.EqualTo(new Guid(0x14932f9b, 0x9087, 0x4bb4, 0x84, 0x12, 0x51, 0x67, 0x14, 0x5c, 0xbe, 0x04)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_NOSHUTDOWN_ON_REMOVE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_NOSHUTDOWN_ON_REMOVETest()
    {
        Assert.That(MF_TOPONODE_NOSHUTDOWN_ON_REMOVE, Is.EqualTo(new Guid(0x14932f9c, 0x9087, 0x4bb4, 0x84, 0x12, 0x51, 0x67, 0x14, 0x5c, 0xbe, 0x04)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_RATELESS"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_RATELESSTest()
    {
        Assert.That(MF_TOPONODE_RATELESS, Is.EqualTo(new Guid(0x14932f9d, 0x9087, 0x4bb4, 0x84, 0x12, 0x51, 0x67, 0x14, 0x5c, 0xbe, 0x04)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_DISABLE_PREROLL"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_DISABLE_PREROLLTest()
    {
        Assert.That(MF_TOPONODE_DISABLE_PREROLL, Is.EqualTo(new Guid(0x14932f9e, 0x9087, 0x4bb4, 0x84, 0x12, 0x51, 0x67, 0x14, 0x5c, 0xbe, 0x04)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_PRIMARYOUTPUT"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_PRIMARYOUTPUTTest()
    {
        Assert.That(MF_TOPONODE_PRIMARYOUTPUT, Is.EqualTo(new Guid(0x6304ef99, 0x16b2, 0x4ebe, 0x9d, 0x67, 0xe4, 0xc5, 0x39, 0xb3, 0xa2, 0x59)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_PMPHOST_CONTEXT"/> property is correct.</summary>
    [Test]
    public static void MF_PD_PMPHOST_CONTEXTTest()
    {
        Assert.That(MF_PD_PMPHOST_CONTEXT, Is.EqualTo(new Guid(0x6c990d31, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_APP_CONTEXT"/> property is correct.</summary>
    [Test]
    public static void MF_PD_APP_CONTEXTTest()
    {
        Assert.That(MF_PD_APP_CONTEXT, Is.EqualTo(new Guid(0x6c990d32, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_DURATION"/> property is correct.</summary>
    [Test]
    public static void MF_PD_DURATIONTest()
    {
        Assert.That(MF_PD_DURATION, Is.EqualTo(new Guid(0x6c990d33, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_TOTAL_FILE_SIZE"/> property is correct.</summary>
    [Test]
    public static void MF_PD_TOTAL_FILE_SIZETest()
    {
        Assert.That(MF_PD_TOTAL_FILE_SIZE, Is.EqualTo(new Guid(0x6c990d34, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_AUDIO_ENCODING_BITRATE"/> property is correct.</summary>
    [Test]
    public static void MF_PD_AUDIO_ENCODING_BITRATETest()
    {
        Assert.That(MF_PD_AUDIO_ENCODING_BITRATE, Is.EqualTo(new Guid(0x6c990d35, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_VIDEO_ENCODING_BITRATE"/> property is correct.</summary>
    [Test]
    public static void MF_PD_VIDEO_ENCODING_BITRATETest()
    {
        Assert.That(MF_PD_VIDEO_ENCODING_BITRATE, Is.EqualTo(new Guid(0x6c990d36, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_MIME_TYPE"/> property is correct.</summary>
    [Test]
    public static void MF_PD_MIME_TYPETest()
    {
        Assert.That(MF_PD_MIME_TYPE, Is.EqualTo(new Guid(0x6c990d37, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_LAST_MODIFIED_TIME"/> property is correct.</summary>
    [Test]
    public static void MF_PD_LAST_MODIFIED_TIMETest()
    {
        Assert.That(MF_PD_LAST_MODIFIED_TIME, Is.EqualTo(new Guid(0x6c990d38, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_PLAYBACK_ELEMENT_ID"/> property is correct.</summary>
    [Test]
    public static void MF_PD_PLAYBACK_ELEMENT_IDTest()
    {
        Assert.That(MF_PD_PLAYBACK_ELEMENT_ID, Is.EqualTo(new Guid(0x6c990d39, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_PREFERRED_LANGUAGE"/> property is correct.</summary>
    [Test]
    public static void MF_PD_PREFERRED_LANGUAGETest()
    {
        Assert.That(MF_PD_PREFERRED_LANGUAGE, Is.EqualTo(new Guid(0x6c990d3A, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_PLAYBACK_BOUNDARY_TIME"/> property is correct.</summary>
    [Test]
    public static void MF_PD_PLAYBACK_BOUNDARY_TIMETest()
    {
        Assert.That(MF_PD_PLAYBACK_BOUNDARY_TIME, Is.EqualTo(new Guid(0x6c990d3b, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_AUDIO_ISVARIABLEBITRATE"/> property is correct.</summary>
    [Test]
    public static void MF_PD_AUDIO_ISVARIABLEBITRATETest()
    {
        Assert.That(MF_PD_AUDIO_ISVARIABLEBITRATE, Is.EqualTo(new Guid(0x33026ee0, 0xe387, 0x4582, 0xae, 0x0a, 0x34, 0xa2, 0xad, 0x3b, 0xaa, 0x18)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_ADAPTIVE_STREAMING"/> property is correct.</summary>
    [Test]
    public static void MF_PD_ADAPTIVE_STREAMINGTest()
    {
        Assert.That(MF_PD_ADAPTIVE_STREAMING, Is.EqualTo(new Guid(0xEA0D5D97, 0x29F9, 0x488B, 0xAE, 0x6B, 0x7D, 0x6B, 0x41, 0x36, 0x11, 0x2B)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SD_LANGUAGE"/> property is correct.</summary>
    [Test]
    public static void MF_SD_LANGUAGETest()
    {
        Assert.That(MF_SD_LANGUAGE, Is.EqualTo(new Guid(0xaf2180, 0xbdc2, 0x423c, 0xab, 0xca, 0xf5, 0x3, 0x59, 0x3b, 0xc1, 0x21)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SD_PROTECTED"/> property is correct.</summary>
    [Test]
    public static void MF_SD_PROTECTEDTest()
    {
        Assert.That(MF_SD_PROTECTED, Is.EqualTo(new Guid(0xaf2181, 0xbdc2, 0x423c, 0xab, 0xca, 0xf5, 0x3, 0x59, 0x3b, 0xc1, 0x21)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SD_STREAM_NAME"/> property is correct.</summary>
    [Test]
    public static void MF_SD_STREAM_NAMETest()
    {
        Assert.That(MF_SD_STREAM_NAME, Is.EqualTo(new Guid(0x4f1b099d, 0xd314, 0x41e5, 0xa7, 0x81, 0x7f, 0xef, 0xaa, 0x4c, 0x50, 0x1f)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SD_MUTUALLY_EXCLUSIVE"/> property is correct.</summary>
    [Test]
    public static void MF_SD_MUTUALLY_EXCLUSIVETest()
    {
        Assert.That(MF_SD_MUTUALLY_EXCLUSIVE, Is.EqualTo(new Guid(0x23ef79c, 0x388d, 0x487f, 0xac, 0x17, 0x69, 0x6c, 0xd6, 0xe3, 0xc6, 0xf5)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_ACTIVATE_CUSTOM_VIDEO_MIXER_CLSID"/> property is correct.</summary>
    [Test]
    public static void MF_ACTIVATE_CUSTOM_VIDEO_MIXER_CLSIDTest()
    {
        Assert.That(MF_ACTIVATE_CUSTOM_VIDEO_MIXER_CLSID, Is.EqualTo(new Guid(0xba491360, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_ACTIVATE_CUSTOM_VIDEO_MIXER_ACTIVATE"/> property is correct.</summary>
    [Test]
    public static void MF_ACTIVATE_CUSTOM_VIDEO_MIXER_ACTIVATETest()
    {
        Assert.That(MF_ACTIVATE_CUSTOM_VIDEO_MIXER_ACTIVATE, Is.EqualTo(new Guid(0xba491361, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_ACTIVATE_CUSTOM_VIDEO_MIXER_FLAGS"/> property is correct.</summary>
    [Test]
    public static void MF_ACTIVATE_CUSTOM_VIDEO_MIXER_FLAGSTest()
    {
        Assert.That(MF_ACTIVATE_CUSTOM_VIDEO_MIXER_FLAGS, Is.EqualTo(new Guid(0xba491362, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_CLSID"/> property is correct.</summary>
    [Test]
    public static void MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_CLSIDTest()
    {
        Assert.That(MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_CLSID, Is.EqualTo(new Guid(0xba491364, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_ACTIVATE"/> property is correct.</summary>
    [Test]
    public static void MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_ACTIVATETest()
    {
        Assert.That(MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_ACTIVATE, Is.EqualTo(new Guid(0xba491365, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_FLAGS"/> property is correct.</summary>
    [Test]
    public static void MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_FLAGSTest()
    {
        Assert.That(MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_FLAGS, Is.EqualTo(new Guid(0xba491366, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_ACTIVATE_MFT_LOCKED"/> property is correct.</summary>
    [Test]
    public static void MF_ACTIVATE_MFT_LOCKEDTest()
    {
        Assert.That(MF_ACTIVATE_MFT_LOCKED, Is.EqualTo(new Guid(0xc1f6093c, 0x7f65, 0x4fbd, 0x9e, 0x39, 0x5f, 0xae, 0xc3, 0xc4, 0xfb, 0xd7)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_ACTIVATE_VIDEO_WINDOW"/> property is correct.</summary>
    [Test]
    public static void MF_ACTIVATE_VIDEO_WINDOWTest()
    {
        Assert.That(MF_ACTIVATE_VIDEO_WINDOW, Is.EqualTo(new Guid(0x9a2dbbdd, 0xf57e, 0x4162, 0x82, 0xb9, 0x68, 0x31, 0x37, 0x76, 0x82, 0xd3)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS"/> property is correct.</summary>
    [Test]
    public static void MF_AUDIO_RENDERER_ATTRIBUTE_FLAGSTest()
    {
        Assert.That(MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS, Is.EqualTo(new Guid(0xede4b5e0, 0xf805, 0x4d6c, 0x99, 0xb3, 0xdb, 0x01, 0xbf, 0x95, 0xdf, 0xab)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_AUDIO_RENDERER_ATTRIBUTE_SESSION_ID"/> property is correct.</summary>
    [Test]
    public static void MF_AUDIO_RENDERER_ATTRIBUTE_SESSION_IDTest()
    {
        Assert.That(MF_AUDIO_RENDERER_ATTRIBUTE_SESSION_ID, Is.EqualTo(new Guid(0xede4b5e3, 0xf805, 0x4d6c, 0x99, 0xb3, 0xdb, 0x01, 0xbf, 0x95, 0xdf, 0xab)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ID"/> property is correct.</summary>
    [Test]
    public static void MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_IDTest()
    {
        Assert.That(MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ID, Is.EqualTo(new Guid(0xb10aaec3, 0xef71, 0x4cc3, 0xb8, 0x73, 0x5, 0xa9, 0xa0, 0x8b, 0x9f, 0x8e)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ROLE"/> property is correct.</summary>
    [Test]
    public static void MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ROLETest()
    {
        Assert.That(MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ROLE, Is.EqualTo(new Guid(0x6ba644ff, 0x27c5, 0x4d02, 0x98, 0x87, 0xc2, 0x86, 0x19, 0xfd, 0xb9, 0x1b)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_AUDIO_RENDERER_ATTRIBUTE_STREAM_CATEGORY"/> property is correct.</summary>
    [Test]
    public static void MF_AUDIO_RENDERER_ATTRIBUTE_STREAM_CATEGORYTest()
    {
        Assert.That(MF_AUDIO_RENDERER_ATTRIBUTE_STREAM_CATEGORY, Is.EqualTo(new Guid(0xa9770471, 0x92ec, 0x4df4, 0x94, 0xfe, 0x81, 0xc3, 0x6f, 0xc, 0x3a, 0x7a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_METADATA_PROVIDER_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_METADATA_PROVIDER_SERVICETest()
    {
        Assert.That(MF_METADATA_PROVIDER_SERVICE, Is.EqualTo(new Guid(0xdb214084, 0x58a4, 0x4d2e, 0xb8, 0x4f, 0x6f, 0x75, 0x5b, 0x2f, 0x7a, 0xd)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PROPERTY_HANDLER_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_PROPERTY_HANDLER_SERVICETest()
    {
        Assert.That(MF_PROPERTY_HANDLER_SERVICE, Is.EqualTo(new Guid(0xa3face02, 0x32b8, 0x41dd, 0x90, 0xe7, 0x5f, 0xef, 0x7c, 0x89, 0x91, 0xb5)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_RATE_CONTROL_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_RATE_CONTROL_SERVICETest()
    {
        Assert.That(MF_RATE_CONTROL_SERVICE, Is.EqualTo(new Guid(0x866fa297, 0xb802, 0x4bf8, 0x9d, 0xc9, 0x5e, 0x3b, 0x6a, 0x9f, 0x53, 0xc9)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TIMECODE_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_TIMECODE_SERVICETest()
    {
        Assert.That(MF_TIMECODE_SERVICE, Is.EqualTo(new Guid(0xa0d502a7, 0x0eb3, 0x4885, 0xb1, 0xb9, 0x9f, 0xeb, 0x0d, 0x08, 0x34, 0x54)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SAMPLEGRABBERSINK_SAMPLE_TIME_OFFSET"/> property is correct.</summary>
    [Test]
    public static void MF_SAMPLEGRABBERSINK_SAMPLE_TIME_OFFSETTest()
    {
        Assert.That(MF_SAMPLEGRABBERSINK_SAMPLE_TIME_OFFSET, Is.EqualTo(new Guid(0x62e3d776, 0x8100, 0x4e03, 0xa6, 0xe8, 0xbd, 0x38, 0x57, 0xac, 0x9c, 0x47)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SAMPLEGRABBERSINK_IGNORE_CLOCK"/> property is correct.</summary>
    [Test]
    public static void MF_SAMPLEGRABBERSINK_IGNORE_CLOCKTest()
    {
        Assert.That(MF_SAMPLEGRABBERSINK_IGNORE_CLOCK, Is.EqualTo(new Guid(0x0efda2c0, 0x2b69, 0x4e2e, 0xab, 0x8d, 0x46, 0xdc, 0xbf, 0xf7, 0xd2, 0x5d)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_QUALITY_SERVICES"/> property is correct.</summary>
    [Test]
    public static void MF_QUALITY_SERVICESTest()
    {
        Assert.That(MF_QUALITY_SERVICES, Is.EqualTo(new Guid(0xb7e2be11, 0x2f96, 0x4640, 0xb5, 0x2c, 0x28, 0x23, 0x65, 0xbd, 0xf1, 0x6c)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_WORKQUEUE_SERVICES"/> property is correct.</summary>
    [Test]
    public static void MF_WORKQUEUE_SERVICESTest()
    {
        Assert.That(MF_WORKQUEUE_SERVICES, Is.EqualTo(new Guid(0x8e37d489, 0x41e0, 0x413a, 0x90, 0x68, 0x28, 0x7c, 0x88, 0x6d, 0x8d, 0xda)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_QUALITY_NOTIFY_PROCESSING_LATENCY"/> property is correct.</summary>
    [Test]
    public static void MF_QUALITY_NOTIFY_PROCESSING_LATENCYTest()
    {
        Assert.That(MF_QUALITY_NOTIFY_PROCESSING_LATENCY, Is.EqualTo(new Guid(0xf6b44af8, 0x604d, 0x46fe, 0xa9, 0x5d, 0x45, 0x47, 0x9b, 0x10, 0xc9, 0xbc)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_QUALITY_NOTIFY_SAMPLE_LAG"/> property is correct.</summary>
    [Test]
    public static void MF_QUALITY_NOTIFY_SAMPLE_LAGTest()
    {
        Assert.That(MF_QUALITY_NOTIFY_SAMPLE_LAG, Is.EqualTo(new Guid(0x30d15206, 0xed2a, 0x4760, 0xbe, 0x17, 0xeb, 0x4a, 0x9f, 0x12, 0x29, 0x5c)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TIME_FORMAT_SEGMENT_OFFSET"/> property is correct.</summary>
    [Test]
    public static void MF_TIME_FORMAT_SEGMENT_OFFSETTest()
    {
        Assert.That(MF_TIME_FORMAT_SEGMENT_OFFSET, Is.EqualTo(new Guid(0xc8b8be77, 0x869c, 0x431d, 0x81, 0x2e, 0x16, 0x96, 0x93, 0xf6, 0x5a, 0x39)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SOURCE_PRESENTATION_PROVIDER_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_SOURCE_PRESENTATION_PROVIDER_SERVICETest()
    {
        Assert.That(MF_SOURCE_PRESENTATION_PROVIDER_SERVICE, Is.EqualTo(new Guid(0xe002aadc, 0xf4af, 0x4ee5, 0x98, 0x47, 0x05, 0x3e, 0xdf, 0x84, 0x04, 0x26)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TOPONODE_ATTRIBUTE_EDITOR_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_TOPONODE_ATTRIBUTE_EDITOR_SERVICETest()
    {
        Assert.That(MF_TOPONODE_ATTRIBUTE_EDITOR_SERVICE, Is.EqualTo(new Guid(0x65656e1a, 0x077f, 0x4472, 0x83, 0xef, 0x31, 0x6f, 0x11, 0xd5, 0x08, 0x7a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_BYTESTREAMHANDLER_ACCEPTS_SHARE_WRITE"/> property is correct.</summary>
    [Test]
    public static void MF_BYTESTREAMHANDLER_ACCEPTS_SHARE_WRITETest()
    {
        Assert.That(MF_BYTESTREAMHANDLER_ACCEPTS_SHARE_WRITE, Is.EqualTo(new Guid(0xa6e1f733, 0x3001, 0x4915, 0x81, 0x50, 0x15, 0x58, 0xa2, 0x18, 0xe, 0xc8)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_BYTESTREAM_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_BYTESTREAM_SERVICETest()
    {
        Assert.That(MF_BYTESTREAM_SERVICE, Is.EqualTo(new Guid(0xab025e2b, 0x16d9, 0x4180, 0xa1, 0x27, 0xba, 0x6c, 0x70, 0x15, 0x61, 0x61)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_MEDIA_PROTECTION_MANAGER_PROPERTIES"/> property is correct.</summary>
    [Test]
    public static void MF_MEDIA_PROTECTION_MANAGER_PROPERTIESTest()
    {
        Assert.That(MF_MEDIA_PROTECTION_MANAGER_PROPERTIES, Is.EqualTo(new Guid(0x38BD81A9, 0xACEA, 0x4C73, 0x89, 0xB2, 0x55, 0x32, 0xC0, 0xAE, 0xCA, 0x79)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_POLICY_ID"/> property is correct.</summary>
    [Test]
    public static void MF_POLICY_IDTest()
    {
        Assert.That(MF_POLICY_ID, Is.EqualTo(new Guid(0xb160c24d, 0xc059, 0x48f1, 0xa9, 0x1, 0x9e, 0xe2, 0x98, 0xa9, 0xa8, 0xc3)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SampleProtectionSalt"/> property is correct.</summary>
    [Test]
    public static void MF_SampleProtectionSaltTest()
    {
        Assert.That(MF_SampleProtectionSalt, Is.EqualTo(new Guid(0x5403deee, 0xb9ee, 0x438f, 0xaa, 0x83, 0x38, 0x4, 0x99, 0x7e, 0x56, 0x9d)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_REMOTE_PROXY"/> property is correct.</summary>
    [Test]
    public static void MF_REMOTE_PROXYTest()
    {
        Assert.That(MF_REMOTE_PROXY, Is.EqualTo(new Guid(0x2f00c90e, 0xd2cf, 0x4278, 0x8b, 0x6a, 0xd0, 0x77, 0xfa, 0xc3, 0xa2, 0x5f)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SAMI_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_SAMI_SERVICETest()
    {
        Assert.That(MF_SAMI_SERVICE, Is.EqualTo(new Guid(0x49a89ae7, 0xb4d9, 0x4ef2, 0xaa, 0x5c, 0xf6, 0x5a, 0x3e, 0x5, 0xae, 0x4e)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_PD_SAMI_STYLELIST"/> property is correct.</summary>
    [Test]
    public static void MF_PD_SAMI_STYLELISTTest()
    {
        Assert.That(MF_PD_SAMI_STYLELIST, Is.EqualTo(new Guid(0xe0b73c7f, 0x486d, 0x484e, 0x98, 0x72, 0x4d, 0xe5, 0x19, 0x2a, 0x7b, 0xf8)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SD_SAMI_LANGUAGE"/> property is correct.</summary>
    [Test]
    public static void MF_SD_SAMI_LANGUAGETest()
    {
        Assert.That(MF_SD_SAMI_LANGUAGE, Is.EqualTo(new Guid(0x36fcb98a, 0x6cd0, 0x44cb, 0xac, 0xb9, 0xa8, 0xf5, 0x60, 0xd, 0xd0, 0xbb)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TRANSCODE_CONTAINERTYPE"/> property is correct.</summary>
    [Test]
    public static void MF_TRANSCODE_CONTAINERTYPETest()
    {
        Assert.That(MF_TRANSCODE_CONTAINERTYPE, Is.EqualTo(new Guid(0x150ff23f, 0x4abc, 0x478b, 0xac, 0x4f, 0xe1, 0x91, 0x6f, 0xba, 0x1c, 0xca)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TRANSCODE_SKIP_METADATA_TRANSFER"/> property is correct.</summary>
    [Test]
    public static void MF_TRANSCODE_SKIP_METADATA_TRANSFERTest()
    {
        Assert.That(MF_TRANSCODE_SKIP_METADATA_TRANSFER, Is.EqualTo(new Guid(0x4e4469ef, 0xb571, 0x4959, 0x8f, 0x83, 0x3d, 0xcf, 0xba, 0x33, 0xa3, 0x93)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TRANSCODE_TOPOLOGYMODE"/> property is correct.</summary>
    [Test]
    public static void MF_TRANSCODE_TOPOLOGYMODETest()
    {
        Assert.That(MF_TRANSCODE_TOPOLOGYMODE, Is.EqualTo(new Guid(0x3e3df610, 0x394a, 0x40b2, 0x9d, 0xea, 0x3b, 0xab, 0x65, 0xb, 0xeb, 0xf2)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TRANSCODE_ADJUST_PROFILE"/> property is correct.</summary>
    [Test]
    public static void MF_TRANSCODE_ADJUST_PROFILETest()
    {
        Assert.That(MF_TRANSCODE_ADJUST_PROFILE, Is.EqualTo(new Guid(0x9c37c21b, 0x60f, 0x487c, 0xa6, 0x90, 0x80, 0xd7, 0xf5, 0xd, 0x1c, 0x72)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TRANSCODE_ENCODINGPROFILE"/> property is correct.</summary>
    [Test]
    public static void MF_TRANSCODE_ENCODINGPROFILETest()
    {
        Assert.That(MF_TRANSCODE_ENCODINGPROFILE, Is.EqualTo(new Guid(0x6947787c, 0xf508, 0x4ea9, 0xb1, 0xe9, 0xa1, 0xfe, 0x3a, 0x49, 0xfb, 0xc9)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TRANSCODE_QUALITYVSSPEED"/> property is correct.</summary>
    [Test]
    public static void MF_TRANSCODE_QUALITYVSSPEEDTest()
    {
        Assert.That(MF_TRANSCODE_QUALITYVSSPEED, Is.EqualTo(new Guid(0x98332df8, 0x03cd, 0x476b, 0x89, 0xfa, 0x3f, 0x9e, 0x44, 0x2d, 0xec, 0x9f)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_TRANSCODE_DONOT_INSERT_ENCODER"/> property is correct.</summary>
    [Test]
    public static void MF_TRANSCODE_DONOT_INSERT_ENCODERTest()
    {
        Assert.That(MF_TRANSCODE_DONOT_INSERT_ENCODER, Is.EqualTo(new Guid(0xf45aa7ce, 0xab24, 0x4012, 0xa1, 0x1b, 0xdc, 0x82, 0x20, 0x20, 0x14, 0x10)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_VIDEO_PROCESSOR_ALGORITHM"/> property is correct.</summary>
    [Test]
    public static void MF_VIDEO_PROCESSOR_ALGORITHMTest()
    {
        Assert.That(MF_VIDEO_PROCESSOR_ALGORITHM, Is.EqualTo(new Guid(0x4a0a1e1f, 0x272c, 0x4fb6, 0x9e, 0xb1, 0xdb, 0x33, 0xc, 0xbc, 0x97, 0xca)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_XVP_DISABLE_FRC"/> property is correct.</summary>
    [Test]
    public static void MF_XVP_DISABLE_FRCTest()
    {
        Assert.That(MF_XVP_DISABLE_FRC, Is.EqualTo(new Guid(0x2c0afa19, 0x7a97, 0x4d5a, 0x9e, 0xe8, 0x16, 0xd4, 0xfc, 0x51, 0x8d, 0x8c)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_XVP_CALLER_ALLOCATES_OUTPUT"/> property is correct.</summary>
    [Test]
    public static void MF_XVP_CALLER_ALLOCATES_OUTPUTTest()
    {
        Assert.That(MF_XVP_CALLER_ALLOCATES_OUTPUT, Is.EqualTo(new Guid(0x4a2cabc, 0xcab, 0x40b1, 0xa1, 0xb9, 0x75, 0xbc, 0x36, 0x58, 0xf0, 0x0)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_LOCAL_MFT_REGISTRATION_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_LOCAL_MFT_REGISTRATION_SERVICETest()
    {
        Assert.That(MF_LOCAL_MFT_REGISTRATION_SERVICE, Is.EqualTo(new Guid(0xddf5cf9c, 0x4506, 0x45aa, 0xab, 0xf0, 0x6d, 0x5d, 0x94, 0xdd, 0x1b, 0x4a)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_WRAPPED_BUFFER_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_WRAPPED_BUFFER_SERVICETest()
    {
        Assert.That(MF_WRAPPED_BUFFER_SERVICE, Is.EqualTo(new Guid(0xab544072, 0xc269, 0x4ebc, 0xa5, 0x52, 0x1c, 0x3b, 0x32, 0xbe, 0xd5, 0xca)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_WRAPPED_SAMPLE_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_WRAPPED_SAMPLE_SERVICETest()
    {
        Assert.That(MF_WRAPPED_SAMPLE_SERVICE, Is.EqualTo(new Guid(0x31f52bf2, 0xd03e, 0x4048, 0x80, 0xd0, 0x9c, 0x10, 0x46, 0xd8, 0x7c, 0x61)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_WRAPPED_OBJECT"/> property is correct.</summary>
    [Test]
    public static void MF_WRAPPED_OBJECTTest()
    {
        Assert.That(MF_WRAPPED_OBJECT, Is.EqualTo(new Guid(0x2b182c4c, 0xd6ac, 0x49f4, 0x89, 0x15, 0xf7, 0x18, 0x87, 0xdb, 0x70, 0xcd)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPETest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE, Is.EqualTo(new Guid(0xc60ac5fe, 0x252a, 0x478f, 0xa0, 0xef, 0xbc, 0x8f, 0xa5, 0xf7, 0xca, 0xd3)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_HW_SOURCE"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_HW_SOURCETest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_HW_SOURCE, Is.EqualTo(new Guid(0xde7046ba, 0x54d6, 0x4487, 0xa2, 0xa4, 0xec, 0x7c, 0xd, 0x1b, 0xd1, 0x63)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_FRIENDLY_NAME"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_FRIENDLY_NAMETest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_FRIENDLY_NAME, Is.EqualTo(new Guid(0x60d0e559, 0x52f8, 0x4fa2, 0xbb, 0xce, 0xac, 0xdb, 0x34, 0xa8, 0xec, 0x1)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_MEDIA_TYPE"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_MEDIA_TYPETest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_MEDIA_TYPE, Is.EqualTo(new Guid(0x56a819ca, 0xc78, 0x4de4, 0xa0, 0xa7, 0x3d, 0xda, 0xba, 0xf, 0x24, 0xd4)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_CATEGORY"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_CATEGORYTest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_CATEGORY, Is.EqualTo(new Guid(0x77f0ae69, 0xc3bd, 0x4509, 0x94, 0x1d, 0x46, 0x7e, 0x4d, 0x24, 0x89, 0x9e)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_SYMBOLIC_LINK"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_SYMBOLIC_LINKTest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_SYMBOLIC_LINK, Is.EqualTo(new Guid(0x58f0aad8, 0x22bf, 0x4f8a, 0xbb, 0x3d, 0xd2, 0xc4, 0x97, 0x8c, 0x6e, 0x2f)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_SYMBOLIC_LINK"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_SYMBOLIC_LINKTest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_SYMBOLIC_LINK, Is.EqualTo(new Guid(0x98d24b5e, 0x5930, 0x4614, 0xb5, 0xa1, 0xf6, 0x0, 0xf9, 0x35, 0x5a, 0x78)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_MAX_BUFFERS"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_MAX_BUFFERSTest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_MAX_BUFFERS, Is.EqualTo(new Guid(0x7dd9b730, 0x4f2d, 0x41d5, 0x8f, 0x95, 0xc, 0xc9, 0xa9, 0x12, 0xba, 0x26)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ENDPOINT_ID"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ENDPOINT_IDTest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ENDPOINT_ID, Is.EqualTo(new Guid(0x30da9258, 0xfeb9, 0x47a7, 0xa4, 0x53, 0x76, 0x3a, 0x7a, 0x8e, 0x1c, 0x5f)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ROLE"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ROLETest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ROLE, Is.EqualTo(new Guid(0xbc9d118e, 0x8c67, 0x4a18, 0x85, 0xd4, 0x12, 0xd3, 0x0, 0x40, 0x5, 0x52)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_PROVIDER_DEVICE_ID"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_PROVIDER_DEVICE_IDTest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_PROVIDER_DEVICE_ID, Is.EqualTo(new Guid(0x36689d42, 0xa06c, 0x40ae, 0x84, 0xcf, 0xf5, 0xa0, 0x34, 0x6, 0x7c, 0xc4)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_XADDRESS"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_XADDRESSTest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_XADDRESS, Is.EqualTo(new Guid(0xbca0be52, 0xc327, 0x44c7, 0x9b, 0x7d, 0x7f, 0xa8, 0xd9, 0xb5, 0xbc, 0xda)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_STREAM_URL"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_STREAM_URLTest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_STREAM_URL, Is.EqualTo(new Guid(0x9d7b40d2, 0x3617, 0x4043, 0x93, 0xe3, 0x8d, 0x6d, 0xa9, 0xbb, 0x34, 0x92)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_USERNAME"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_USERNAMETest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_USERNAME, Is.EqualTo(new Guid(0x5d01add, 0x949f, 0x46eb, 0xbc, 0x8e, 0x8b, 0xd, 0x2b, 0x32, 0xd7, 0x9d)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_PASSWORD"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_PASSWORDTest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_PASSWORD, Is.EqualTo(new Guid(0xa0fd7e16, 0x42d9, 0x49df, 0x84, 0xc0, 0xe8, 0x2c, 0x5e, 0xab, 0x88, 0x74)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_GUID"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_GUIDTest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_GUID, Is.EqualTo(new Guid(0x14dd9a1c, 0x7cff, 0x41be, 0xb1, 0xb9, 0xba, 0x1a, 0xc6, 0xec, 0xb5, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUID"/> property is correct.</summary>
    [Test]
    public static void MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUIDTest()
    {
        Assert.That(MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUID, Is.EqualTo(new Guid(0x8ac3587a, 0x4ae7, 0x42d8, 0x99, 0xe0, 0x0a, 0x60, 0x13, 0xee, 0xf9, 0x0f)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_IMAGE_STREAM"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_IMAGE_STREAMTest()
    {
        Assert.That(MF_DEVICESTREAM_IMAGE_STREAM, Is.EqualTo(new Guid(0xa7ffb865, 0xe7b2, 0x43b0, 0x9f, 0x6f, 0x9a, 0xf2, 0xa0, 0xe5, 0xf, 0xc0)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_INDEPENDENT_IMAGE_STREAM"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_INDEPENDENT_IMAGE_STREAMTest()
    {
        Assert.That(MF_DEVICESTREAM_INDEPENDENT_IMAGE_STREAM, Is.EqualTo(new Guid(0x3eeec7e, 0xd605, 0x4576, 0x8b, 0x29, 0x65, 0x80, 0xb4, 0x90, 0xd7, 0xd3)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_STREAM_ID"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_STREAM_IDTest()
    {
        Assert.That(MF_DEVICESTREAM_STREAM_ID, Is.EqualTo(new Guid(0x11bd5120, 0xd124, 0x446b, 0x88, 0xe6, 0x17, 0x6, 0x2, 0x57, 0xff, 0xf9)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_STREAM_CATEGORY"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_STREAM_CATEGORYTest()
    {
        Assert.That(MF_DEVICESTREAM_STREAM_CATEGORY, Is.EqualTo(new Guid(0x2939e7b8, 0xa62e, 0x4579, 0xb6, 0x74, 0xd4, 0x7, 0x3d, 0xfa, 0xbb, 0xba)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_FRAMESERVER_SHARED"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_FRAMESERVER_SHAREDTest()
    {
        Assert.That(MF_DEVICESTREAM_FRAMESERVER_SHARED, Is.EqualTo(new Guid(0x1CB378E9, 0xB279, 0x41D4, 0xAF, 0x97, 0x34, 0xA2, 0x43, 0xE6, 0x83, 0x20)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_TRANSFORM_STREAM_ID"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_TRANSFORM_STREAM_IDTest()
    {
        Assert.That(MF_DEVICESTREAM_TRANSFORM_STREAM_ID, Is.EqualTo(new Guid(0xe63937b7, 0xdaaf, 0x4d49, 0x81, 0x5f, 0xd8, 0x26, 0xf8, 0xad, 0x31, 0xe7)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_EXTENSION_PLUGIN_CLSID"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_EXTENSION_PLUGIN_CLSIDTest()
    {
        Assert.That(MF_DEVICESTREAM_EXTENSION_PLUGIN_CLSID, Is.EqualTo(new Guid(0x048e6558, 0x60c4, 0x4173, 0xbd, 0x5b, 0x6a, 0x3c, 0xa2, 0x89, 0x6a, 0xee)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICEMFT_EXTENSION_PLUGIN_CLSID"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICEMFT_EXTENSION_PLUGIN_CLSIDTest()
    {
        Assert.That(MF_DEVICEMFT_EXTENSION_PLUGIN_CLSID, Is.EqualTo(new Guid(0x844dbae, 0x34fa, 0x48a0, 0xa7, 0x83, 0x8e, 0x69, 0x6f, 0xb1, 0xc9, 0xa8)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_EXTENSION_PLUGIN_CONNECTION_POINT"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_EXTENSION_PLUGIN_CONNECTION_POINTTest()
    {
        Assert.That(MF_DEVICESTREAM_EXTENSION_PLUGIN_CONNECTION_POINT, Is.EqualTo(new Guid(0x37f9375c, 0xe664, 0x4ea4, 0xaa, 0xe4, 0xcb, 0x6d, 0x1d, 0xac, 0xa1, 0xf4)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_TAKEPHOTO_TRIGGER"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_TAKEPHOTO_TRIGGERTest()
    {
        Assert.That(MF_DEVICESTREAM_TAKEPHOTO_TRIGGER, Is.EqualTo(new Guid(0x1d180e34, 0x538c, 0x4fbb, 0xa7, 0x5a, 0x85, 0x9a, 0xf7, 0xd2, 0x61, 0xa6)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_MAX_FRAME_BUFFERS"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_MAX_FRAME_BUFFERSTest()
    {
        Assert.That(MF_DEVICESTREAM_MAX_FRAME_BUFFERS, Is.EqualTo(new Guid(0x1684cebe, 0x3175, 0x4985, 0x88, 0x2c, 0x0e, 0xfd, 0x3e, 0x8a, 0xc1, 0x1e)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICEMFT_CONNECTED_FILTER_KSCONTROL"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICEMFT_CONNECTED_FILTER_KSCONTROLTest()
    {
        Assert.That(MF_DEVICEMFT_CONNECTED_FILTER_KSCONTROL, Is.EqualTo(new Guid(0x6a2c4fa6, 0xd179, 0x41cd, 0x95, 0x23, 0x82, 0x23, 0x71, 0xea, 0x40, 0xe5)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICEMFT_CONNECTED_PIN_KSCONTROL"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICEMFT_CONNECTED_PIN_KSCONTROLTest()
    {
        Assert.That(MF_DEVICEMFT_CONNECTED_PIN_KSCONTROL, Is.EqualTo(new Guid(0xe63310f7, 0xb244, 0x4ef8, 0x9a, 0x7d, 0x24, 0xc7, 0x4e, 0x32, 0xeb, 0xd0)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICE_THERMAL_STATE_CHANGED"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICE_THERMAL_STATE_CHANGEDTest()
    {
        Assert.That(MF_DEVICE_THERMAL_STATE_CHANGED, Is.EqualTo(new Guid(0x70ccd0af, 0xfc9f, 0x4deb, 0xa8, 0x75, 0x9f, 0xec, 0xd1, 0x6c, 0x5b, 0xd4)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_MEDIASOURCE_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_MEDIASOURCE_SERVICETest()
    {
        Assert.That(MF_MEDIASOURCE_SERVICE, Is.EqualTo(new Guid(0xf09992f7, 0x9fba, 0x4c4a, 0xa3, 0x7f, 0x8c, 0x47, 0xb4, 0xe1, 0xdf, 0xe7)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_ACCESS_CONTROLLED_MEDIASOURCE_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_ACCESS_CONTROLLED_MEDIASOURCE_SERVICETest()
    {
        Assert.That(MF_ACCESS_CONTROLLED_MEDIASOURCE_SERVICE, Is.EqualTo(new Guid(0x14a5031, 0x2f05, 0x4c6a, 0x9f, 0x9c, 0x7d, 0xd, 0xc4, 0xed, 0xa5, 0xf4)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CONTENT_DECRYPTOR_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_CONTENT_DECRYPTOR_SERVICETest()
    {
        Assert.That(MF_CONTENT_DECRYPTOR_SERVICE, Is.EqualTo(new Guid(0x68a72927, 0xfc7b, 0x44ee, 0x85, 0xf4, 0x7c, 0x51, 0xbd, 0x55, 0xa6, 0x59)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CONTENT_PROTECTION_DEVICE_SERVICE"/> property is correct.</summary>
    [Test]
    public static void MF_CONTENT_PROTECTION_DEVICE_SERVICETest()
    {
        Assert.That(MF_CONTENT_PROTECTION_DEVICE_SERVICE, Is.EqualTo(new Guid(0xff58436f, 0x76a0, 0x41fe, 0xb5, 0x66, 0x10, 0xcc, 0x53, 0x96, 0x2e, 0xdd)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SD_AUDIO_ENCODER_DELAY"/> property is correct.</summary>
    [Test]
    public static void MF_SD_AUDIO_ENCODER_DELAYTest()
    {
        Assert.That(MF_SD_AUDIO_ENCODER_DELAY, Is.EqualTo(new Guid(0x8e85422c, 0x73de, 0x403f, 0x9a, 0x35, 0x55, 0x0a, 0xd6, 0xe8, 0xb9, 0x51)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SD_AUDIO_ENCODER_PADDING"/> property is correct.</summary>
    [Test]
    public static void MF_SD_AUDIO_ENCODER_PADDINGTest()
    {
        Assert.That(MF_SD_AUDIO_ENCODER_PADDING, Is.EqualTo(new Guid(0x529c7f2c, 0xac4b, 0x4e3f, 0xbf, 0xc3, 0x09, 0x02, 0x19, 0x49, 0x82, 0xcb)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SD_MEDIASOURCE_STATUS"/> property is correct.</summary>
    [Test]
    public static void MF_SD_MEDIASOURCE_STATUSTest()
    {
        Assert.That(MF_SD_MEDIASOURCE_STATUS, Is.EqualTo(new Guid(0x1913678b, 0xfc0f, 0x44da, 0x8f, 0x43, 0x1b, 0xa3, 0xb5, 0x26, 0xf4, 0xae)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SD_VIDEO_SPHERICAL"/> property is correct.</summary>
    [Test]
    public static void MF_SD_VIDEO_SPHERICALTest()
    {
        Assert.That(MF_SD_VIDEO_SPHERICAL, Is.EqualTo(new Guid(0xa51da449, 0x3fdc, 0x478c, 0xbc, 0xb5, 0x30, 0xbe, 0x76, 0x59, 0x5f, 0x55)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SD_VIDEO_SPHERICAL_FORMAT"/> property is correct.</summary>
    [Test]
    public static void MF_SD_VIDEO_SPHERICAL_FORMATTest()
    {
        Assert.That(MF_SD_VIDEO_SPHERICAL_FORMAT, Is.EqualTo(new Guid(0x4a8fc407, 0x6ea1, 0x46c8, 0xb5, 0x67, 0x69, 0x71, 0xd4, 0xa1, 0x39, 0xc3)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_SD_VIDEO_SPHERICAL_INITIAL_VIEWDIRECTION"/> property is correct.</summary>
    [Test]
    public static void MF_SD_VIDEO_SPHERICAL_INITIAL_VIEWDIRECTIONTest()
    {
        Assert.That(MF_SD_VIDEO_SPHERICAL_INITIAL_VIEWDIRECTION, Is.EqualTo(new Guid(0x11d25a49, 0xbb62, 0x467f, 0x9d, 0xb1, 0xc1, 0x71, 0x65, 0x71, 0x6c, 0x49)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_MEDIASOURCE_EXPOSE_ALL_STREAMS"/> property is correct.</summary>
    [Test]
    public static void MF_MEDIASOURCE_EXPOSE_ALL_STREAMSTest()
    {
        Assert.That(MF_MEDIASOURCE_EXPOSE_ALL_STREAMS, Is.EqualTo(new Guid(0xe7f250b8, 0x8fd9, 0x4a09, 0xb6, 0xc1, 0x6a, 0x31, 0x5c, 0x7c, 0x72, 0xe)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_ST_MEDIASOURCE_COLLECTION"/> property is correct.</summary>
    [Test]
    public static void MF_ST_MEDIASOURCE_COLLECTIONTest()
    {
        Assert.That(MF_ST_MEDIASOURCE_COLLECTION, Is.EqualTo(new Guid(0x616DE972, 0x83AD, 0x4950, 0x81, 0x70, 0x63, 0x0D, 0x19, 0xCB, 0xE3, 0x07)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_FILTER_KSCONTROL"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_FILTER_KSCONTROLTest()
    {
        Assert.That(MF_DEVICESTREAM_FILTER_KSCONTROL, Is.EqualTo(new Guid(0x46783CCA, 0x3DF5, 0x4923, 0xA9, 0xEF, 0x36, 0xB7, 0x22, 0x3E, 0xDD, 0xE0)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_PIN_KSCONTROL"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_PIN_KSCONTROLTest()
    {
        Assert.That(MF_DEVICESTREAM_PIN_KSCONTROL, Is.EqualTo(new Guid(0xEF3EF9A7, 0x87F2, 0x48CA, 0xBE, 0x02, 0x67, 0x48, 0x78, 0x91, 0x8E, 0x98)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_SOURCE_ATTRIBUTES"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_SOURCE_ATTRIBUTESTest()
    {
        Assert.That(MF_DEVICESTREAM_SOURCE_ATTRIBUTES, Is.EqualTo(new Guid(0x2F8CB617, 0x361B, 0x434F, 0x85, 0xEA, 0x99, 0xA0, 0x3E, 0x1C, 0xE4, 0xE0)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_FRAMESERVER_HIDDEN"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_FRAMESERVER_HIDDENTest()
    {
        Assert.That(MF_DEVICESTREAM_FRAMESERVER_HIDDEN, Is.EqualTo(new Guid(0xF402567B, 0x4D91, 0x4179, 0x96, 0xD1, 0x74, 0xC8, 0x48, 0x0C, 0x20, 0x34)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_STF_VERSION_INFO"/> property is correct.</summary>
    [Test]
    public static void MF_STF_VERSION_INFOTest()
    {
        Assert.That(MF_STF_VERSION_INFO, Is.EqualTo(new Guid(0x6770BD39, 0xEF82, 0x44EE, 0xA4, 0x9B, 0x93, 0x4B, 0xEB, 0x24, 0xAE, 0xF7)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_STF_VERSION_DATE"/> property is correct.</summary>
    [Test]
    public static void MF_STF_VERSION_DATETest()
    {
        Assert.That(MF_STF_VERSION_DATE, Is.EqualTo(new Guid(0x31A165D5, 0xDF67, 0x4095, 0x8E, 0x44, 0x88, 0x68, 0xFC, 0x20, 0xDB, 0xFD)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_REQUIRED_CAPABILITIES"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_REQUIRED_CAPABILITIESTest()
    {
        Assert.That(MF_DEVICESTREAM_REQUIRED_CAPABILITIES, Is.EqualTo(new Guid(0x6D8B957E, 0x7CF6, 0x43F4, 0xAF, 0x56, 0x9C, 0x0E, 0x1E, 0x4F, 0xCB, 0xE1)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_REQUIRED_SDDL"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_REQUIRED_SDDLTest()
    {
        Assert.That(MF_DEVICESTREAM_REQUIRED_SDDL, Is.EqualTo(new Guid(0x331AE85D, 0xC0D3, 0x49BA, 0x83, 0xBA, 0x82, 0xA1, 0x2D, 0x63, 0xCD, 0xD6)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICEMFT_SENSORPROFILE_COLLECTION"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICEMFT_SENSORPROFILE_COLLECTIONTest()
    {
        Assert.That(MF_DEVICEMFT_SENSORPROFILE_COLLECTION, Is.EqualTo(new Guid(0x36EBDC44, 0xB12C, 0x441B, 0x89, 0xF4, 0x08, 0xB2, 0xF4, 0x1A, 0x9C, 0xFC)));
    }

    /// <summary>Validates that the value of the <see cref = "MF_DEVICESTREAM_SENSORSTREAM_ID"/> property is correct.</summary>
    [Test]
    public static void MF_DEVICESTREAM_SENSORSTREAM_IDTest()
    {
        Assert.That(MF_DEVICESTREAM_SENSORSTREAM_ID, Is.EqualTo(new Guid(0xE35B9FE4, 0x0659, 0x4CAD, 0xBB, 0x51, 0x33, 0x16, 0x0B, 0xE7, 0xE4, 0x13)));
    }
}