// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPID_SpeechPhraseAlternates.xml' path='doc/member[@name="DISPID_SpeechPhraseAlternates"]/*'/>
public enum DISPID_SpeechPhraseAlternates
{
    /// <include file='DISPID_SpeechPhraseAlternates.xml' path='doc/member[@name="DISPID_SpeechPhraseAlternates.DISPID_SPAsCount"]/*'/>
    DISPID_SPAsCount = 1,
    /// <include file='DISPID_SpeechPhraseAlternates.xml' path='doc/member[@name="DISPID_SpeechPhraseAlternates.DISPID_SPAsItem"]/*'/>
    DISPID_SPAsItem = (0),
    /// <include file='DISPID_SpeechPhraseAlternates.xml' path='doc/member[@name="DISPID_SpeechPhraseAlternates.DISPID_SPAs_NewEnum"]/*'/>
    DISPID_SPAs_NewEnum = (-4),
}