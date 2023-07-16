// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPID_SpeechLexiconWords.xml' path='doc/member[@name="DISPID_SpeechLexiconWords"]/*'/>
public enum DISPID_SpeechLexiconWords
{
    /// <include file='DISPID_SpeechLexiconWords.xml' path='doc/member[@name="DISPID_SpeechLexiconWords.DISPID_SLWsCount"]/*'/>
    DISPID_SLWsCount = 1,
    /// <include file='DISPID_SpeechLexiconWords.xml' path='doc/member[@name="DISPID_SpeechLexiconWords.DISPID_SLWsItem"]/*'/>
    DISPID_SLWsItem = (0),
    /// <include file='DISPID_SpeechLexiconWords.xml' path='doc/member[@name="DISPID_SpeechLexiconWords.DISPID_SLWs_NewEnum"]/*'/>
    DISPID_SLWs_NewEnum = (-4),
}