// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "Windows"/> class.</summary>
public static unsafe partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_MaxDecodeFrameSize"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_MaxDecodeFrameSizeTest()
    {
        Assert.That(MFSampleExtension_MaxDecodeFrameSize, Is.EqualTo(new Guid(0xd3cc654f, 0xf9f3, 0x4a13, 0x88, 0x9f, 0xf0, 0x4e, 0xb2, 0xb5, 0xb9, 0x57)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_AccumulatedNonRefPicPercent"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_AccumulatedNonRefPicPercentTest()
    {
        Assert.That(MFSampleExtension_AccumulatedNonRefPicPercent, Is.EqualTo(new Guid(0x79ea74df, 0xa740, 0x445b, 0xbc, 0x98, 0xc9, 0xed, 0x1f, 0x26, 0xe, 0xee)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_ProtectionScheme"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_ProtectionSchemeTest()
    {
        Assert.That(MFSampleExtension_Encryption_ProtectionScheme, Is.EqualTo(new Guid(0xd054d096, 0x28bb, 0x45da, 0x87, 0xec, 0x74, 0xf3, 0x51, 0x87, 0x14, 0x6)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_CryptByteBlock"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_CryptByteBlockTest()
    {
        Assert.That(MFSampleExtension_Encryption_CryptByteBlock, Is.EqualTo(new Guid(0x9d84289b, 0xc7f, 0x4713, 0xab, 0x95, 0x10, 0x8a, 0xb4, 0x2a, 0xd8, 0x1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_SkipByteBlock"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_SkipByteBlockTest()
    {
        Assert.That(MFSampleExtension_Encryption_SkipByteBlock, Is.EqualTo(new Guid(0xd550548, 0x8317, 0x4ab1, 0x84, 0x5f, 0xd0, 0x63, 0x6, 0xe2, 0x93, 0xe3)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_SubSample_Mapping"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_SubSample_MappingTest()
    {
        Assert.That(MFSampleExtension_Encryption_SubSample_Mapping, Is.EqualTo(new Guid(0x8444F27A, 0x69A1, 0x48DA, 0xBD, 0x08, 0x11, 0xCE, 0xF3, 0x68, 0x30, 0xD2)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_ClearSliceHeaderData"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_ClearSliceHeaderDataTest()
    {
        Assert.That(MFSampleExtension_Encryption_ClearSliceHeaderData, Is.EqualTo(new Guid(0x5509a4f4, 0x320d, 0x4e6c, 0x8d, 0x1a, 0x94, 0xc6, 0x6d, 0xd2, 0xc, 0xb0)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_HardwareProtection_KeyInfoID"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_HardwareProtection_KeyInfoIDTest()
    {
        Assert.That(MFSampleExtension_Encryption_HardwareProtection_KeyInfoID, Is.EqualTo(new Guid(0x8cbfcceb, 0x94a5, 0x4de1, 0x82, 0x31, 0xa8, 0x5e, 0x47, 0xcf, 0x81, 0xe7)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_HardwareProtection_KeyInfo"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_HardwareProtection_KeyInfoTest()
    {
        Assert.That(MFSampleExtension_Encryption_HardwareProtection_KeyInfo, Is.EqualTo(new Guid(0xb2372080, 0x455b, 0x4dd7, 0x99, 0x89, 0x1a, 0x95, 0x57, 0x84, 0xb7, 0x54)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_HardwareProtection_VideoDecryptorContext"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_HardwareProtection_VideoDecryptorContextTest()
    {
        Assert.That(MFSampleExtension_Encryption_HardwareProtection_VideoDecryptorContext, Is.EqualTo(new Guid(0x693470c8, 0xe837, 0x47a0, 0x88, 0xcb, 0x53, 0x5b, 0x90, 0x5e, 0x35, 0x82)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_Opaque_Data"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_Opaque_DataTest()
    {
        Assert.That(MFSampleExtension_Encryption_Opaque_Data, Is.EqualTo(new Guid(0x224d77e5, 0x1391, 0x4ffb, 0x9f, 0x41, 0xb4, 0x32, 0xf6, 0x8c, 0x61, 0x1d)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_NALULengthInfo"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_NALULengthInfoTest()
    {
        Assert.That(MFSampleExtension_NALULengthInfo, Is.EqualTo(new Guid(0x19124E7C, 0xAD4B, 0x465F, 0xBB, 0x18, 0x20, 0x18, 0x62, 0x87, 0xB6, 0xAF)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_ResumeVideoOutput"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_ResumeVideoOutputTest()
    {
        Assert.That(MFSampleExtension_Encryption_ResumeVideoOutput, Is.EqualTo(new Guid(0xa435aba5, 0xafde, 0x4cf5, 0xbc, 0x1c, 0xf6, 0xac, 0xaf, 0x13, 0x94, 0x9d)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_NALUTypes"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_NALUTypesTest()
    {
        Assert.That(MFSampleExtension_Encryption_NALUTypes, Is.EqualTo(new Guid(0xb0f067c7, 0x714c, 0x416c, 0x8d, 0x59, 0x5f, 0x4d, 0xdf, 0x89, 0x13, 0xb6)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_SPSPPSData"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_SPSPPSDataTest()
    {
        Assert.That(MFSampleExtension_Encryption_SPSPPSData, Is.EqualTo(new Guid(0xaede0fa2, 0xe0c, 0x453c, 0xb7, 0xf3, 0xde, 0x86, 0x93, 0x36, 0x4d, 0x11)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_SEIData"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_SEIDataTest()
    {
        Assert.That(MFSampleExtension_Encryption_SEIData, Is.EqualTo(new Guid(0x3cf0e972, 0x4542, 0x4687, 0x99, 0x99, 0x58, 0x5f, 0x56, 0x5f, 0xba, 0x7d)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_HardwareProtection"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_HardwareProtectionTest()
    {
        Assert.That(MFSampleExtension_Encryption_HardwareProtection, Is.EqualTo(new Guid(0x9a2b2d2b, 0x8270, 0x43e3, 0x84, 0x48, 0x99, 0x4f, 0x42, 0x6e, 0x88, 0x86)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_CleanPoint"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_CleanPointTest()
    {
        Assert.That(MFSampleExtension_CleanPoint, Is.EqualTo(new Guid(0x9cdf01d8, 0xa0f0, 0x43ba, 0xb0, 0x77, 0xea, 0xa0, 0x6c, 0xbd, 0x72, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Discontinuity"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_DiscontinuityTest()
    {
        Assert.That(MFSampleExtension_Discontinuity, Is.EqualTo(new Guid(0x9cdf01d9, 0xa0f0, 0x43ba, 0xb0, 0x77, 0xea, 0xa0, 0x6c, 0xbd, 0x72, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Token"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_TokenTest()
    {
        Assert.That(MFSampleExtension_Token, Is.EqualTo(new Guid(0x8294da66, 0xf328, 0x4805, 0xb5, 0x51, 0x00, 0xde, 0xb4, 0xc5, 0x7a, 0x61)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_ClosedCaption_CEA708"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_ClosedCaption_CEA708Test()
    {
        Assert.That(MFSampleExtension_ClosedCaption_CEA708, Is.EqualTo(new Guid(0x26f09068, 0xe744, 0x47dc, 0xaa, 0x03, 0xdb, 0xf2, 0x04, 0x03, 0xbd, 0xe6)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_DecodeTimestamp"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_DecodeTimestampTest()
    {
        Assert.That(MFSampleExtension_DecodeTimestamp, Is.EqualTo(new Guid(0x73a954d4, 0x9e2, 0x4861, 0xbe, 0xfc, 0x94, 0xbd, 0x97, 0xc0, 0x8e, 0x6e)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_VideoEncodeQP"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_VideoEncodeQPTest()
    {
        Assert.That(MFSampleExtension_VideoEncodeQP, Is.EqualTo(new Guid(0xb2efe478, 0xf979, 0x4c66, 0xb9, 0x5e, 0xee, 0x2b, 0x82, 0xc8, 0x2f, 0x36)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_VideoEncodePictureType"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_VideoEncodePictureTypeTest()
    {
        Assert.That(MFSampleExtension_VideoEncodePictureType, Is.EqualTo(new Guid(0x973704e6, 0xcd14, 0x483c, 0x8f, 0x20, 0xc9, 0xfc, 0x9, 0x28, 0xba, 0xd5)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_FrameCorruption"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_FrameCorruptionTest()
    {
        Assert.That(MFSampleExtension_FrameCorruption, Is.EqualTo(new Guid(0xb4dd4a8c, 0xbeb, 0x44c4, 0x8b, 0x75, 0xb0, 0x2b, 0x91, 0x3b, 0x4, 0xf0)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_DirtyRects"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_DirtyRectsTest()
    {
        Assert.That(MFSampleExtension_DirtyRects, Is.EqualTo(new Guid(0x9ba70225, 0xb342, 0x4e97, 0x91, 0x26, 0x0b, 0x56, 0x6a, 0xb7, 0xea, 0x7e)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_MoveRegions"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_MoveRegionsTest()
    {
        Assert.That(MFSampleExtension_MoveRegions, Is.EqualTo(new Guid(0xe2a6c693, 0x3a8b, 0x4b8d, 0x95, 0xd0, 0xf6, 0x02, 0x81, 0xa1, 0x2f, 0xb7)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_HDCP_OptionalHeader"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_HDCP_OptionalHeaderTest()
    {
        Assert.That(MFSampleExtension_HDCP_OptionalHeader, Is.EqualTo(new Guid(0x9a2e7390, 0x121f, 0x455f, 0x83, 0x76, 0xc9, 0x74, 0x28, 0xe0, 0xb5, 0x40)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_HDCP_FrameCounter"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_HDCP_FrameCounterTest()
    {
        Assert.That(MFSampleExtension_HDCP_FrameCounter, Is.EqualTo(new Guid(0x9d389c60, 0xf507, 0x4aa6, 0xa4, 0xa, 0x71, 0x2, 0x7a, 0x2, 0xf3, 0xde)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_HDCP_StreamID"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_HDCP_StreamIDTest()
    {
        Assert.That(MFSampleExtension_HDCP_StreamID, Is.EqualTo(new Guid(0x177e5d74, 0xc370, 0x4a7a, 0x95, 0xa2, 0x36, 0x83, 0x3c, 0x01, 0xd0, 0xaf)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Timestamp"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_TimestampTest()
    {
        Assert.That(MFSampleExtension_Timestamp, Is.EqualTo(new Guid(0x1e436999, 0x69be, 0x4c7a, 0x93, 0x69, 0x70, 0x06, 0x8c, 0x02, 0x60, 0xcb)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_RepeatFrame"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_RepeatFrameTest()
    {
        Assert.That(MFSampleExtension_RepeatFrame, Is.EqualTo(new Guid(0x88be738f, 0x711, 0x4f42, 0xb4, 0x58, 0x34, 0x4a, 0xed, 0x42, 0xec, 0x2f)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_DescrambleData"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_DescrambleDataTest()
    {
        Assert.That(MFSampleExtension_DescrambleData, Is.EqualTo(new Guid(0x43483be6, 0x4903, 0x4314, 0xb0, 0x32, 0x29, 0x51, 0x36, 0x59, 0x36, 0xfc)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_SampleKeyID"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_SampleKeyIDTest()
    {
        Assert.That(MFSampleExtension_SampleKeyID, Is.EqualTo(new Guid(0x9ed713c8, 0x9b87, 0x4b26, 0x82, 0x97, 0xa9, 0x3b, 0x0c, 0x5a, 0x8a, 0xcc)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_GenKeyFunc"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_GenKeyFuncTest()
    {
        Assert.That(MFSampleExtension_GenKeyFunc, Is.EqualTo(new Guid(0x441ca1ee, 0x6b1f, 0x4501, 0x90, 0x3a, 0xde, 0x87, 0xdf, 0x42, 0xf6, 0xed)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_GenKeyCtx"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_GenKeyCtxTest()
    {
        Assert.That(MFSampleExtension_GenKeyCtx, Is.EqualTo(new Guid(0x188120cb, 0xd7da, 0x4b59, 0x9b, 0x3e, 0x92, 0x52, 0xfd, 0x37, 0x30, 0x1c)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_PacketCrossOffsets"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_PacketCrossOffsetsTest()
    {
        Assert.That(MFSampleExtension_PacketCrossOffsets, Is.EqualTo(new Guid(0x2789671d, 0x389f, 0x40bb, 0x90, 0xd9, 0xc2, 0x82, 0xf7, 0x7f, 0x9a, 0xbd)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_SampleID"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_SampleIDTest()
    {
        Assert.That(MFSampleExtension_Encryption_SampleID, Is.EqualTo(new Guid(0x6698b84e, 0x0afa, 0x4330, 0xae, 0xb2, 0x1c, 0x0a, 0x98, 0xd7, 0xa4, 0x4d)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_KeyID"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_KeyIDTest()
    {
        Assert.That(MFSampleExtension_Encryption_KeyID, Is.EqualTo(new Guid(0x76376591, 0x795f, 0x4da1, 0x86, 0xed, 0x9d, 0x46, 0xec, 0xa1, 0x09, 0xa9)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Content_KeyID"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Content_KeyIDTest()
    {
        Assert.That(MFSampleExtension_Content_KeyID, Is.EqualTo(new Guid(0xc6c7f5b0, 0xacca, 0x415b, 0x87, 0xd9, 0x10, 0x44, 0x14, 0x69, 0xef, 0xc6)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Encryption_SubSampleMappingSplit"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Encryption_SubSampleMappingSplitTest()
    {
        Assert.That(MFSampleExtension_Encryption_SubSampleMappingSplit, Is.EqualTo(new Guid(0xfe0254b9, 0x2aa5, 0x4edc, 0x99, 0xf7, 0x17, 0xe8, 0x9d, 0xbf, 0x91, 0x74)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Interlaced"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_InterlacedTest()
    {
        Assert.That(MFSampleExtension_Interlaced, Is.EqualTo(new Guid(0xb1d5830a, 0xdeb8, 0x40e3, 0x90, 0xfa, 0x38, 0x99, 0x43, 0x71, 0x64, 0x61)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_BottomFieldFirst"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_BottomFieldFirstTest()
    {
        Assert.That(MFSampleExtension_BottomFieldFirst, Is.EqualTo(new Guid(0x941ce0a3, 0x6ae3, 0x4dda, 0x9a, 0x08, 0xa6, 0x42, 0x98, 0x34, 0x06, 0x17)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_RepeatFirstField"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_RepeatFirstFieldTest()
    {
        Assert.That(MFSampleExtension_RepeatFirstField, Is.EqualTo(new Guid(0x304d257c, 0x7493, 0x4fbd, 0xb1, 0x49, 0x92, 0x28, 0xde, 0x8d, 0x9a, 0x99)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_SingleField"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_SingleFieldTest()
    {
        Assert.That(MFSampleExtension_SingleField, Is.EqualTo(new Guid(0x9d85f816, 0x658b, 0x455a, 0xbd, 0xe0, 0x9f, 0xa7, 0xe1, 0x5a, 0xb8, 0xf9)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_DerivedFromTopField"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_DerivedFromTopFieldTest()
    {
        Assert.That(MFSampleExtension_DerivedFromTopField, Is.EqualTo(new Guid(0x6852465a, 0xae1c, 0x4553, 0x8e, 0x9b, 0xc3, 0x42, 0x0f, 0xcb, 0x16, 0x37)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_MeanAbsoluteDifference"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_MeanAbsoluteDifferenceTest()
    {
        Assert.That(MFSampleExtension_MeanAbsoluteDifference, Is.EqualTo(new Guid(0x1cdbde11, 0x08b4, 0x4311, 0xa6, 0xdd, 0x0f, 0x9f, 0x37, 0x19, 0x07, 0xaa)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_LongTermReferenceFrameInfo"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_LongTermReferenceFrameInfoTest()
    {
        Assert.That(MFSampleExtension_LongTermReferenceFrameInfo, Is.EqualTo(new Guid(0x9154733f, 0xe1bd, 0x41bf, 0x81, 0xd3, 0xfc, 0xd9, 0x18, 0xf7, 0x13, 0x32)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_ROIRectangle"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_ROIRectangleTest()
    {
        Assert.That(MFSampleExtension_ROIRectangle, Is.EqualTo(new Guid(0x3414a438, 0x4998, 0x4d2c, 0xbe, 0x82, 0xbe, 0x3c, 0xa0, 0xb2, 0x4d, 0x43)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_LastSlice"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_LastSliceTest()
    {
        Assert.That(MFSampleExtension_LastSlice, Is.EqualTo(new Guid(0x2b5d5457, 0x5547, 0x4f07, 0xb8, 0xc8, 0xb4, 0xa3, 0xa9, 0xa1, 0xda, 0xac)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_FeatureMap"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_FeatureMapTest()
    {
        Assert.That(MFSampleExtension_FeatureMap, Is.EqualTo(new Guid(0xa032d165, 0x46fc, 0x400a, 0xb4, 0x49, 0x49, 0xde, 0x53, 0xe6, 0x2a, 0x6e)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_ChromaOnly"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_ChromaOnlyTest()
    {
        Assert.That(MFSampleExtension_ChromaOnly, Is.EqualTo(new Guid(0x1eb9179c, 0xa01f, 0x4845, 0x8c, 0x04, 0x0e, 0x65, 0xa2, 0x6e, 0xb0, 0x4f)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_PhotoThumbnail"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_PhotoThumbnailTest()
    {
        Assert.That(MFSampleExtension_PhotoThumbnail, Is.EqualTo(new Guid(0x74BBC85C, 0xC8BB, 0x42DC, 0xB5, 0x86, 0xDA, 0x17, 0xFF, 0xD3, 0x5D, 0xCC)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_PhotoThumbnailMediaType"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_PhotoThumbnailMediaTypeTest()
    {
        Assert.That(MFSampleExtension_PhotoThumbnailMediaType, Is.EqualTo(new Guid(0x61AD5420, 0xEBF8, 0x4143, 0x89, 0xAF, 0x6B, 0xF2, 0x5F, 0x67, 0x2D, 0xEF)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_CaptureMetadata"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_CaptureMetadataTest()
    {
        Assert.That(MFSampleExtension_CaptureMetadata, Is.EqualTo(new Guid(0x2EBE23A8, 0xFAF5, 0x444A, 0xA6, 0xA2, 0xEB, 0x81, 0x08, 0x80, 0xAB, 0x5D)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_MDLCacheCookie"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_MDLCacheCookieTest()
    {
        Assert.That(MFSampleExtension_MDLCacheCookie, Is.EqualTo(new Guid(0x5F002AF9, 0xD8F9, 0x41A3, 0xB6, 0xC3, 0xA2, 0xAD, 0x43, 0xF6, 0x47, 0xAD)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Depth_MinReliableDepth"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Depth_MinReliableDepthTest()
    {
        Assert.That(MFSampleExtension_Depth_MinReliableDepth, Is.EqualTo(new Guid(0x5f8582b2, 0xe36b, 0x47c8, 0x9b, 0x87, 0xfe, 0xe1, 0xca, 0x72, 0xc5, 0xb0)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_Depth_MaxReliableDepth"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_Depth_MaxReliableDepthTest()
    {
        Assert.That(MFSampleExtension_Depth_MaxReliableDepth, Is.EqualTo(new Guid(0xe45545d1, 0x1f0f, 0x4a32, 0xa8, 0xa7, 0x61, 0x1, 0xa2, 0x4e, 0xa8, 0xbe)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMPEG4Format_Base"/> property is correct.</summary>
    [Test]
    public static void MFMPEG4Format_BaseTest()
    {
        Assert.That(MFMPEG4Format_Base, Is.EqualTo(new Guid(0x00000000, 0x767a, 0x494d, 0xb4, 0x78, 0xf2, 0x9d, 0x25, 0xdc, 0x90, 0x37)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSubtitleFormat_XML"/> property is correct.</summary>
    [Test]
    public static void MFSubtitleFormat_XMLTest()
    {
        Assert.That(MFSubtitleFormat_XML, Is.EqualTo(new Guid(0x2006f94f, 0x29ca, 0x4195, 0xb8, 0xdb, 0x00, 0xde, 0xd8, 0xff, 0x0c, 0x97)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSubtitleFormat_TTML"/> property is correct.</summary>
    [Test]
    public static void MFSubtitleFormat_TTMLTest()
    {
        Assert.That(MFSubtitleFormat_TTML, Is.EqualTo(new Guid(0x73e73992, 0x9a10, 0x4356, 0x95, 0x57, 0x71, 0x94, 0xe9, 0x1e, 0x3e, 0x54)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSubtitleFormat_ATSC"/> property is correct.</summary>
    [Test]
    public static void MFSubtitleFormat_ATSCTest()
    {
        Assert.That(MFSubtitleFormat_ATSC, Is.EqualTo(new Guid(0x7fa7faa3, 0xfeae, 0x4e16, 0xae, 0xdf, 0x36, 0xb9, 0xac, 0xfb, 0xb0, 0x99)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSubtitleFormat_WebVTT"/> property is correct.</summary>
    [Test]
    public static void MFSubtitleFormat_WebVTTTest()
    {
        Assert.That(MFSubtitleFormat_WebVTT, Is.EqualTo(new Guid(0xc886d215, 0xf485, 0x40bb, 0x8d, 0xb6, 0xfa, 0xdb, 0xc6, 0x19, 0xa4, 0x5d)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSubtitleFormat_SRT"/> property is correct.</summary>
    [Test]
    public static void MFSubtitleFormat_SRTTest()
    {
        Assert.That(MFSubtitleFormat_SRT, Is.EqualTo(new Guid(0x5e467f2e, 0x77ca, 0x4ca5, 0x83, 0x91, 0xd1, 0x42, 0xed, 0x4b, 0x76, 0xc8)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSubtitleFormat_SSA"/> property is correct.</summary>
    [Test]
    public static void MFSubtitleFormat_SSATest()
    {
        Assert.That(MFSubtitleFormat_SSA, Is.EqualTo(new Guid(0x57176a1b, 0x1a9e, 0x4eea, 0xab, 0xef, 0xc6, 0x17, 0x60, 0x19, 0x8a, 0xc4)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSubtitleFormat_CustomUserData"/> property is correct.</summary>
    [Test]
    public static void MFSubtitleFormat_CustomUserDataTest()
    {
        Assert.That(MFSubtitleFormat_CustomUserData, Is.EqualTo(new Guid(0x1bb3d849, 0x6614, 0x4d80, 0x88, 0x82, 0xed, 0x24, 0xaa, 0x82, 0xda, 0x92)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSubtitleFormat_PGS"/> property is correct.</summary>
    [Test]
    public static void MFSubtitleFormat_PGSTest()
    {
        Assert.That(MFSubtitleFormat_PGS, Is.EqualTo(new Guid(0x71f40e4a, 0x1278, 0x4442, 0xb3, 0x0d, 0x39, 0xdd, 0x1d, 0x77, 0x22, 0xbc)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSubtitleFormat_VobSub"/> property is correct.</summary>
    [Test]
    public static void MFSubtitleFormat_VobSubTest()
    {
        Assert.That(MFSubtitleFormat_VobSub, Is.EqualTo(new Guid(0x6b8e40f4, 0x8d2c, 0x4ced, 0xad, 0x91, 0x59, 0x60, 0xe4, 0x5b, 0x44, 0x33)));
    }

    /// <summary>Validates that the value of the <see cref = "MFBinaryFormat_Base"/> property is correct.</summary>
    [Test]
    public static void MFBinaryFormat_BaseTest()
    {
        Assert.That(MFBinaryFormat_Base, Is.EqualTo(new Guid(0x00000000, 0xbf10, 0x48b4, 0xbc, 0x18, 0x59, 0x3d, 0xc1, 0xdb, 0x95, 0xf)));
    }

    /// <summary>Validates that the value of the <see cref = "MFBinaryFormat_GPMD"/> property is correct.</summary>
    [Test]
    public static void MFBinaryFormat_GPMDTest()
    {
        Assert.That(MFBinaryFormat_GPMD, Is.EqualTo(new Guid(0x67706D64, 0xbf10, 0x48b4, 0xbc, 0x18, 0x59, 0x3d, 0xc1, 0xdb, 0x95, 0xf)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_3DVideo"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_3DVideoTest()
    {
        Assert.That(MFSampleExtension_3DVideo, Is.EqualTo(new Guid(0xf86f97a4, 0xdd54, 0x4e2e, 0x9a, 0x5e, 0x55, 0xfc, 0x2d, 0x74, 0xa0, 0x05)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_3DVideo_SampleFormat"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_3DVideo_SampleFormatTest()
    {
        Assert.That(MFSampleExtension_3DVideo_SampleFormat, Is.EqualTo(new Guid(0x8671772, 0xe36f, 0x4cff, 0x97, 0xb3, 0xd7, 0x2e, 0x20, 0x98, 0x7a, 0x48)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_MULTIPLEXED_MANAGER"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_MULTIPLEXED_MANAGERTest()
    {
        Assert.That(MFSampleExtension_MULTIPLEXED_MANAGER, Is.EqualTo(new Guid(0x8dcdee79, 0x6b5a, 0x4c45, 0x8d, 0xb9, 0x20, 0xb3, 0x95, 0xf0, 0x2f, 0xcf)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_ForwardedDecodeUnits"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_ForwardedDecodeUnitsTest()
    {
        Assert.That(MFSampleExtension_ForwardedDecodeUnits, Is.EqualTo(new Guid(0x424c754c, 0x97c8, 0x48d6, 0x87, 0x77, 0xfc, 0x41, 0xf7, 0xb6, 0x8, 0x79)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_TargetGlobalLuminance"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_TargetGlobalLuminanceTest()
    {
        Assert.That(MFSampleExtension_TargetGlobalLuminance, Is.EqualTo(new Guid(0x3f60ef36, 0x31ef, 0x4daf, 0x83, 0x60, 0x94, 0x3, 0x97, 0xe4, 0x1e, 0xf3)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_ForwardedDecodeUnitType"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_ForwardedDecodeUnitTypeTest()
    {
        Assert.That(MFSampleExtension_ForwardedDecodeUnitType, Is.EqualTo(new Guid(0x89e57c7, 0x47d3, 0x4a26, 0xbf, 0x9c, 0x4b, 0x64, 0xfa, 0xfb, 0x5d, 0x1e)));
    }

    /// <summary>Validates that the value of the <see cref = "MFStreamExtension_CameraExtrinsics"/> property is correct.</summary>
    [Test]
    public static void MFStreamExtension_CameraExtrinsicsTest()
    {
        Assert.That(MFStreamExtension_CameraExtrinsics, Is.EqualTo(new Guid(0x686196d0, 0x13e2, 0x41d9, 0x96, 0x38, 0xef, 0x3, 0x2c, 0x27, 0x2a, 0x52)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_CameraExtrinsics"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_CameraExtrinsicsTest()
    {
        Assert.That(MFSampleExtension_CameraExtrinsics, Is.EqualTo(new Guid(0x6b761658, 0xb7ec, 0x4c3b, 0x82, 0x25, 0x86, 0x23, 0xca, 0xbe, 0xc3, 0x1d)));
    }

    /// <summary>Validates that the value of the <see cref = "MFStreamExtension_PinholeCameraIntrinsics"/> property is correct.</summary>
    [Test]
    public static void MFStreamExtension_PinholeCameraIntrinsicsTest()
    {
        Assert.That(MFStreamExtension_PinholeCameraIntrinsics, Is.EqualTo(new Guid(0xdbac0455, 0xec8, 0x4aef, 0x9c, 0x32, 0x7a, 0x3e, 0xe3, 0x45, 0x6f, 0x53)));
    }

    /// <summary>Validates that the value of the <see cref = "MFSampleExtension_PinholeCameraIntrinsics"/> property is correct.</summary>
    [Test]
    public static void MFSampleExtension_PinholeCameraIntrinsicsTest()
    {
        Assert.That(MFSampleExtension_PinholeCameraIntrinsics, Is.EqualTo(new Guid(0x4ee3b6c5, 0x6a15, 0x4e72, 0x97, 0x61, 0x70, 0xc1, 0xdb, 0x8b, 0x9f, 0xe3)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_Default"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_DefaultTest()
    {
        Assert.That(MFMediaType_Default, Is.EqualTo(new Guid(0x81A412E6, 0x8103, 0x4B06, 0x85, 0x7F, 0x18, 0x62, 0x78, 0x10, 0x24, 0xAC)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_Audio"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_AudioTest()
    {
        Assert.That(MFMediaType_Audio, Is.EqualTo(new Guid(0x73647561, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_Video"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_VideoTest()
    {
        Assert.That(MFMediaType_Video, Is.EqualTo(new Guid(0x73646976, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_Protected"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_ProtectedTest()
    {
        Assert.That(MFMediaType_Protected, Is.EqualTo(new Guid(0x7b4b6fe6, 0x9d04, 0x4494, 0xbe, 0x14, 0x7e, 0x0b, 0xd0, 0x76, 0xc8, 0xe4)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_SAMI"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_SAMITest()
    {
        Assert.That(MFMediaType_SAMI, Is.EqualTo(new Guid(0xe69669a0, 0x3dcd, 0x40cb, 0x9e, 0x2e, 0x37, 0x08, 0x38, 0x7c, 0x06, 0x16)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_Script"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_ScriptTest()
    {
        Assert.That(MFMediaType_Script, Is.EqualTo(new Guid(0x72178C22, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_Image"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_ImageTest()
    {
        Assert.That(MFMediaType_Image, Is.EqualTo(new Guid(0x72178C23, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_HTML"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_HTMLTest()
    {
        Assert.That(MFMediaType_HTML, Is.EqualTo(new Guid(0x72178C24, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_Binary"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_BinaryTest()
    {
        Assert.That(MFMediaType_Binary, Is.EqualTo(new Guid(0x72178C25, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_FileTransfer"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_FileTransferTest()
    {
        Assert.That(MFMediaType_FileTransfer, Is.EqualTo(new Guid(0x72178C26, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_Stream"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_StreamTest()
    {
        Assert.That(MFMediaType_Stream, Is.EqualTo(new Guid(0xe436eb83, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_MultiplexedFrames"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_MultiplexedFramesTest()
    {
        Assert.That(MFMediaType_MultiplexedFrames, Is.EqualTo(new Guid(0x6ea542b0, 0x281f, 0x4231, 0xa4, 0x64, 0xfe, 0x2f, 0x50, 0x22, 0x50, 0x1c)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_Subtitle"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_SubtitleTest()
    {
        Assert.That(MFMediaType_Subtitle, Is.EqualTo(new Guid(0xa6d13581, 0xed50, 0x4e65, 0xae, 0x08, 0x26, 0x06, 0x55, 0x76, 0xaa, 0xcc)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_Perception"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_PerceptionTest()
    {
        Assert.That(MFMediaType_Perception, Is.EqualTo(new Guid(0x597ff6f9, 0x6ea2, 0x4670, 0x85, 0xb4, 0xea, 0x84, 0x7, 0x3f, 0xe9, 0x40)));
    }

    /// <summary>Validates that the value of the <see cref = "MFImageFormat_JPEG"/> property is correct.</summary>
    [Test]
    public static void MFImageFormat_JPEGTest()
    {
        Assert.That(MFImageFormat_JPEG, Is.EqualTo(new Guid(0x19e4a5aa, 0x5662, 0x4fc5, 0xa0, 0xc0, 0x17, 0x58, 0x02, 0x8e, 0x10, 0x57)));
    }

    /// <summary>Validates that the value of the <see cref = "MFImageFormat_RGB32"/> property is correct.</summary>
    [Test]
    public static void MFImageFormat_RGB32Test()
    {
        Assert.That(MFImageFormat_RGB32, Is.EqualTo(new Guid(0x00000016, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)));
    }

    /// <summary>Validates that the value of the <see cref = "MFStreamFormat_MPEG2Transport"/> property is correct.</summary>
    [Test]
    public static void MFStreamFormat_MPEG2TransportTest()
    {
        Assert.That(MFStreamFormat_MPEG2Transport, Is.EqualTo(new Guid(0xe06d8023, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea)));
    }

    /// <summary>Validates that the value of the <see cref = "MFStreamFormat_MPEG2Program"/> property is correct.</summary>
    [Test]
    public static void MFStreamFormat_MPEG2ProgramTest()
    {
        Assert.That(MFStreamFormat_MPEG2Program, Is.EqualTo(new Guid(0x263067d1, 0xd330, 0x45dc, 0xb6, 0x69, 0x34, 0xd9, 0x86, 0xe4, 0xe3, 0xe1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFMediaType_Metadata"/> property is correct.</summary>
    [Test]
    public static void MFMediaType_MetadataTest()
    {
        Assert.That(MFMediaType_Metadata, Is.EqualTo(new Guid(0x2c8fa20c, 0x82bb, 0x4782, 0x90, 0xa0, 0x98, 0xa2, 0xa5, 0xbd, 0x8e, 0xf8)));
    }
}