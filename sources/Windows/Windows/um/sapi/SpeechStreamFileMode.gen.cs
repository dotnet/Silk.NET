// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.SPFILEMODE;

namespace Silk.NET.Windows;
/// <include file='SpeechStreamFileMode.xml' path='doc/member[@name="SpeechStreamFileMode"]/*'/>
public enum SpeechStreamFileMode
{
    /// <include file='SpeechStreamFileMode.xml' path='doc/member[@name="SpeechStreamFileMode.SSFMOpenForRead"]/*'/>
    SSFMOpenForRead = SPFM_OPEN_READONLY,
    /// <include file='SpeechStreamFileMode.xml' path='doc/member[@name="SpeechStreamFileMode.SSFMOpenReadWrite"]/*'/>
    SSFMOpenReadWrite = SPFM_OPEN_READWRITE,
    /// <include file='SpeechStreamFileMode.xml' path='doc/member[@name="SpeechStreamFileMode.SSFMCreate"]/*'/>
    SSFMCreate = SPFM_CREATE,
    /// <include file='SpeechStreamFileMode.xml' path='doc/member[@name="SpeechStreamFileMode.SSFMCreateForWrite"]/*'/>
    SSFMCreateForWrite = SPFM_CREATE_ALWAYS,
}