// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum MF_SOURCE_READER_FLAG
{
    MF_SOURCE_READERF_ERROR = 0x1,
    MF_SOURCE_READERF_ENDOFSTREAM = 0x2,
    MF_SOURCE_READERF_NEWSTREAM = 0x4,
    MF_SOURCE_READERF_NATIVEMEDIATYPECHANGED = 0x10,
    MF_SOURCE_READERF_CURRENTMEDIATYPECHANGED = 0x20,
    MF_SOURCE_READERF_STREAMTICK = 0x100,
    MF_SOURCE_READERF_ALLEFFECTSREMOVED = 0x200,
}
