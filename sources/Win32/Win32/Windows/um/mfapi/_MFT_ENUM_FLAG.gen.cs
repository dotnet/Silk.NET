// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum _MFT_ENUM_FLAG
{
    MFT_ENUM_FLAG_SYNCMFT = 0x00000001,
    MFT_ENUM_FLAG_ASYNCMFT = 0x00000002,
    MFT_ENUM_FLAG_HARDWARE = 0x00000004,
    MFT_ENUM_FLAG_FIELDOFUSE = 0x00000008,
    MFT_ENUM_FLAG_LOCALMFT = 0x00000010,
    MFT_ENUM_FLAG_TRANSCODE_ONLY = 0x00000020,
    MFT_ENUM_FLAG_SORTANDFILTER = 0x00000040,
    MFT_ENUM_FLAG_SORTANDFILTER_APPROVED_ONLY = 0x000000C0,
    MFT_ENUM_FLAG_SORTANDFILTER_WEB_ONLY = 0x00000140,
    MFT_ENUM_FLAG_SORTANDFILTER_WEB_ONLY_EDGEMODE = 0x00000240,
    MFT_ENUM_FLAG_UNTRUSTED_STOREMFT = 0x00000400,
    MFT_ENUM_FLAG_ALL = 0x0000003F,
}
