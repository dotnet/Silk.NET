// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.SPLEXICONTYPE;

namespace TerraFX.Interop.Windows;
/// <include file='SpeechLexiconType.xml' path='doc/member[@name="SpeechLexiconType"]/*'/>
public enum SpeechLexiconType
{
    /// <include file='SpeechLexiconType.xml' path='doc/member[@name="SpeechLexiconType.SLTUser"]/*'/>
    SLTUser = eLEXTYPE_USER,
    /// <include file='SpeechLexiconType.xml' path='doc/member[@name="SpeechLexiconType.SLTApp"]/*'/>
    SLTApp = eLEXTYPE_APP,
}