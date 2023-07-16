// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.STREAM_SEEK;

namespace Silk.NET.Windows;
/// <include file='SpeechStreamSeekPositionType.xml' path='doc/member[@name="SpeechStreamSeekPositionType"]/*'/>
public enum SpeechStreamSeekPositionType
{
    /// <include file='SpeechStreamSeekPositionType.xml' path='doc/member[@name="SpeechStreamSeekPositionType.SSSPTRelativeToStart"]/*'/>
    SSSPTRelativeToStart = STREAM_SEEK_SET,
    /// <include file='SpeechStreamSeekPositionType.xml' path='doc/member[@name="SpeechStreamSeekPositionType.SSSPTRelativeToCurrentPosition"]/*'/>
    SSSPTRelativeToCurrentPosition = STREAM_SEEK_CUR,
    /// <include file='SpeechStreamSeekPositionType.xml' path='doc/member[@name="SpeechStreamSeekPositionType.SSSPTRelativeToEnd"]/*'/>
    SSSPTRelativeToEnd = STREAM_SEEK_END,
}