// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.SPBOOKMARKOPTIONS;

namespace Silk.NET.Windows;
/// <include file='SpeechBookmarkOptions.xml' path='doc/member[@name="SpeechBookmarkOptions"]/*'/>
public enum SpeechBookmarkOptions
{
    /// <include file='SpeechBookmarkOptions.xml' path='doc/member[@name="SpeechBookmarkOptions.SBONone"]/*'/>
    SBONone = SPBO_NONE,
    /// <include file='SpeechBookmarkOptions.xml' path='doc/member[@name="SpeechBookmarkOptions.SBOPause"]/*'/>
    SBOPause = SPBO_PAUSE,
}