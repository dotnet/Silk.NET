// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='MF_SOURCE_READER_FLAG.xml' path='doc/member[@name="MF_SOURCE_READER_FLAG"]/*'/>
[Flags]
public enum MF_SOURCE_READER_FLAG
{
    /// <include file='MF_SOURCE_READER_FLAG.xml' path='doc/member[@name="MF_SOURCE_READER_FLAG.MF_SOURCE_READERF_ERROR"]/*'/>
    MF_SOURCE_READERF_ERROR = 0x1,
    /// <include file='MF_SOURCE_READER_FLAG.xml' path='doc/member[@name="MF_SOURCE_READER_FLAG.MF_SOURCE_READERF_ENDOFSTREAM"]/*'/>
    MF_SOURCE_READERF_ENDOFSTREAM = 0x2,
    /// <include file='MF_SOURCE_READER_FLAG.xml' path='doc/member[@name="MF_SOURCE_READER_FLAG.MF_SOURCE_READERF_NEWSTREAM"]/*'/>
    MF_SOURCE_READERF_NEWSTREAM = 0x4,
    /// <include file='MF_SOURCE_READER_FLAG.xml' path='doc/member[@name="MF_SOURCE_READER_FLAG.MF_SOURCE_READERF_NATIVEMEDIATYPECHANGED"]/*'/>
    MF_SOURCE_READERF_NATIVEMEDIATYPECHANGED = 0x10,
    /// <include file='MF_SOURCE_READER_FLAG.xml' path='doc/member[@name="MF_SOURCE_READER_FLAG.MF_SOURCE_READERF_CURRENTMEDIATYPECHANGED"]/*'/>
    MF_SOURCE_READERF_CURRENTMEDIATYPECHANGED = 0x20,
    /// <include file='MF_SOURCE_READER_FLAG.xml' path='doc/member[@name="MF_SOURCE_READER_FLAG.MF_SOURCE_READERF_STREAMTICK"]/*'/>
    MF_SOURCE_READERF_STREAMTICK = 0x100,
    /// <include file='MF_SOURCE_READER_FLAG.xml' path='doc/member[@name="MF_SOURCE_READER_FLAG.MF_SOURCE_READERF_ALLEFFECTSREMOVED"]/*'/>
    MF_SOURCE_READERF_ALLEFFECTSREMOVED = 0x200,
}