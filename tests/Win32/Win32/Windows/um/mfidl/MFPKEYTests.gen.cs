// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.MFPKEY;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MFPKEY"/> class.</summary>
public static partial class MFPKEYTests
{
    /// <summary>Validates that the value of the <see cref = "MFPKEY_SourceOpenMonitor"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_SourceOpenMonitorTest()
    {
        Assert.That(
            MFPKEY_SourceOpenMonitor.fmtid,
            Is.EqualTo(
                new Guid(0x074d4637, 0xb5ae, 0x465d, 0xaf, 0x17, 0x1a, 0x53, 0x8d, 0x28, 0x59, 0xdd)
            )
        );
        Assert.That(MFPKEY_SourceOpenMonitor.pid, Is.EqualTo(0x02));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_ASFMediaSource_ApproxSeek"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_ASFMediaSource_ApproxSeekTest()
    {
        Assert.That(
            MFPKEY_ASFMediaSource_ApproxSeek.fmtid,
            Is.EqualTo(
                new Guid(0xb4cd270f, 0x244d, 0x4969, 0xbb, 0x92, 0x3f, 0x0f, 0xb8, 0x31, 0x6f, 0x10)
            )
        );
        Assert.That(MFPKEY_ASFMediaSource_ApproxSeek.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_ASFMediaSource_IterativeSeekIfNoIndex"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_ASFMediaSource_IterativeSeekIfNoIndexTest()
    {
        Assert.That(
            MFPKEY_ASFMediaSource_IterativeSeekIfNoIndex.fmtid,
            Is.EqualTo(
                new Guid(0x170b65dc, 0x4a4e, 0x407a, 0xac, 0x22, 0x57, 0x7f, 0x50, 0xe4, 0xa3, 0x7c)
            )
        );
        Assert.That(MFPKEY_ASFMediaSource_IterativeSeekIfNoIndex.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_ASFMediaSource_IterativeSeek_Max_Count"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_ASFMediaSource_IterativeSeek_Max_CountTest()
    {
        Assert.That(
            MFPKEY_ASFMediaSource_IterativeSeek_Max_Count.fmtid,
            Is.EqualTo(
                new Guid(0x170b65dc, 0x4a4e, 0x407a, 0xac, 0x22, 0x57, 0x7f, 0x50, 0xe4, 0xa3, 0x7c)
            )
        );
        Assert.That(MFPKEY_ASFMediaSource_IterativeSeek_Max_Count.pid, Is.EqualTo(0x02));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecondTest()
    {
        Assert.That(
            MFPKEY_ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond.fmtid,
            Is.EqualTo(
                new Guid(0x170b65dc, 0x4a4e, 0x407a, 0xac, 0x22, 0x57, 0x7f, 0x50, 0xe4, 0xa3, 0x7c)
            )
        );
        Assert.That(
            MFPKEY_ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond.pid,
            Is.EqualTo(0x03)
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_Content_DLNA_Profile_ID"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_Content_DLNA_Profile_IDTest()
    {
        Assert.That(
            MFPKEY_Content_DLNA_Profile_ID.fmtid,
            Is.EqualTo(
                new Guid(0xcfa31b45, 0x525d, 0x4998, 0xbb, 0x44, 0x3f, 0x7d, 0x81, 0x54, 0x2f, 0xa4)
            )
        );
        Assert.That(MFPKEY_Content_DLNA_Profile_ID.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_MediaSource_DisableReadAhead"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_MediaSource_DisableReadAheadTest()
    {
        Assert.That(
            MFPKEY_MediaSource_DisableReadAhead.fmtid,
            Is.EqualTo(
                new Guid(0x26366c14, 0xc5bf, 0x4c76, 0x88, 0x7b, 0x9f, 0x17, 0x54, 0xdb, 0x5f, 0x9)
            )
        );
        Assert.That(MFPKEY_MediaSource_DisableReadAhead.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_SBESourceMode"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_SBESourceModeTest()
    {
        Assert.That(
            MFPKEY_SBESourceMode.fmtid,
            Is.EqualTo(
                new Guid(0x3fae10bb, 0xf859, 0x4192, 0xb5, 0x62, 0x18, 0x68, 0xd3, 0xda, 0x3a, 0x02)
            )
        );
        Assert.That(MFPKEY_SBESourceMode.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_PMP_Creation_Callback"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_PMP_Creation_CallbackTest()
    {
        Assert.That(
            MFPKEY_PMP_Creation_Callback.fmtid,
            Is.EqualTo(
                new Guid(0x28bb4de2, 0x26a2, 0x4870, 0xb7, 0x20, 0xd2, 0x6b, 0xbe, 0xb1, 0x49, 0x42)
            )
        );
        Assert.That(MFPKEY_PMP_Creation_Callback.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_HTTP_ByteStream_Enable_Urlmon"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_HTTP_ByteStream_Enable_UrlmonTest()
    {
        Assert.That(
            MFPKEY_HTTP_ByteStream_Enable_Urlmon.fmtid,
            Is.EqualTo(
                new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92)
            )
        );
        Assert.That(MFPKEY_HTTP_ByteStream_Enable_Urlmon.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_HTTP_ByteStream_Urlmon_Bind_Flags"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_HTTP_ByteStream_Urlmon_Bind_FlagsTest()
    {
        Assert.That(
            MFPKEY_HTTP_ByteStream_Urlmon_Bind_Flags.fmtid,
            Is.EqualTo(
                new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92)
            )
        );
        Assert.That(MFPKEY_HTTP_ByteStream_Urlmon_Bind_Flags.pid, Is.EqualTo(0x02));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_HTTP_ByteStream_Urlmon_Security_Id"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_HTTP_ByteStream_Urlmon_Security_IdTest()
    {
        Assert.That(
            MFPKEY_HTTP_ByteStream_Urlmon_Security_Id.fmtid,
            Is.EqualTo(
                new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92)
            )
        );
        Assert.That(MFPKEY_HTTP_ByteStream_Urlmon_Security_Id.pid, Is.EqualTo(0x03));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_HTTP_ByteStream_Urlmon_Window"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_HTTP_ByteStream_Urlmon_WindowTest()
    {
        Assert.That(
            MFPKEY_HTTP_ByteStream_Urlmon_Window.fmtid,
            Is.EqualTo(
                new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92)
            )
        );
        Assert.That(MFPKEY_HTTP_ByteStream_Urlmon_Window.pid, Is.EqualTo(0x04));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_HTTP_ByteStream_Urlmon_Callback_QueryService"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_HTTP_ByteStream_Urlmon_Callback_QueryServiceTest()
    {
        Assert.That(
            MFPKEY_HTTP_ByteStream_Urlmon_Callback_QueryService.fmtid,
            Is.EqualTo(
                new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92)
            )
        );
        Assert.That(MFPKEY_HTTP_ByteStream_Urlmon_Callback_QueryService.pid, Is.EqualTo(0x05));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_MediaProtectionSystemId"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_MediaProtectionSystemIdTest()
    {
        Assert.That(
            MFPKEY_MediaProtectionSystemId.fmtid,
            Is.EqualTo(
                new Guid(0x636b271d, 0xddc7, 0x49e9, 0xa6, 0xc6, 0x47, 0x38, 0x59, 0x62, 0xe5, 0xbd)
            )
        );
        Assert.That(MFPKEY_MediaProtectionSystemId.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_MediaProtectionSystemContext"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_MediaProtectionSystemContextTest()
    {
        Assert.That(
            MFPKEY_MediaProtectionSystemContext.fmtid,
            Is.EqualTo(
                new Guid(0x636b271d, 0xddc7, 0x49e9, 0xa6, 0xc6, 0x47, 0x38, 0x59, 0x62, 0xe5, 0xbd)
            )
        );
        Assert.That(MFPKEY_MediaProtectionSystemContext.pid, Is.EqualTo(0x02));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_MediaProtectionSystemIdMapping"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_MediaProtectionSystemIdMappingTest()
    {
        Assert.That(
            MFPKEY_MediaProtectionSystemIdMapping.fmtid,
            Is.EqualTo(
                new Guid(0x636b271d, 0xddc7, 0x49e9, 0xa6, 0xc6, 0x47, 0x38, 0x59, 0x62, 0xe5, 0xbd)
            )
        );
        Assert.That(MFPKEY_MediaProtectionSystemIdMapping.pid, Is.EqualTo(0x03));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_MediaProtectionContainerGuid"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_MediaProtectionContainerGuidTest()
    {
        Assert.That(
            MFPKEY_MediaProtectionContainerGuid.fmtid,
            Is.EqualTo(
                new Guid(0x42af3d7c, 0xcf, 0x4a0f, 0x81, 0xf0, 0xad, 0xf5, 0x24, 0xa5, 0xa5, 0xb5)
            )
        );
        Assert.That(MFPKEY_MediaProtectionContainerGuid.pid, Is.EqualTo(0x1));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_MediaProtectionSystemContextsPerTrack"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_MediaProtectionSystemContextsPerTrackTest()
    {
        Assert.That(
            MFPKEY_MediaProtectionSystemContextsPerTrack.fmtid,
            Is.EqualTo(
                new Guid(0x4454b092, 0xd3da, 0x49b0, 0x84, 0x52, 0x68, 0x50, 0xc7, 0xdb, 0x76, 0x4d)
            )
        );
        Assert.That(MFPKEY_MediaProtectionSystemContextsPerTrack.pid, Is.EqualTo(0x03));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_HTTP_ByteStream_Download_Mode"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_HTTP_ByteStream_Download_ModeTest()
    {
        Assert.That(
            MFPKEY_HTTP_ByteStream_Download_Mode.fmtid,
            Is.EqualTo(
                new Guid(0x817f11b7, 0xa982, 0x46ec, 0xa4, 0x49, 0xef, 0x58, 0xae, 0xd5, 0x3c, 0xa8)
            )
        );
        Assert.That(MFPKEY_HTTP_ByteStream_Download_Mode.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_HTTP_ByteStream_Caching_Mode"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_HTTP_ByteStream_Caching_ModeTest()
    {
        Assert.That(
            MFPKEY_HTTP_ByteStream_Caching_Mode.fmtid,
            Is.EqualTo(
                new Guid(0x86a2403e, 0xc78b, 0x44d7, 0x8b, 0xc8, 0xff, 0x72, 0x58, 0x11, 0x75, 0x08)
            )
        );
        Assert.That(MFPKEY_HTTP_ByteStream_Caching_Mode.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MFPKEY_HTTP_ByteStream_Cache_Limit"/> property is correct.</summary>

    [Test]
    public static void MFPKEY_HTTP_ByteStream_Cache_LimitTest()
    {
        Assert.That(
            MFPKEY_HTTP_ByteStream_Cache_Limit.fmtid,
            Is.EqualTo(
                new Guid(0x86a2403e, 0xc78b, 0x44d7, 0x8b, 0xc8, 0xff, 0x72, 0x58, 0x11, 0x75, 0x08)
            )
        );
        Assert.That(MFPKEY_HTTP_ByteStream_Cache_Limit.pid, Is.EqualTo(0x02));
    }
}
