// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPID_SpeechPhraseProperties.xml' path='doc/member[@name="DISPID_SpeechPhraseProperties"]/*'/>
public enum DISPID_SpeechPhraseProperties
{
    /// <include file='DISPID_SpeechPhraseProperties.xml' path='doc/member[@name="DISPID_SpeechPhraseProperties.DISPID_SPPsCount"]/*'/>
    DISPID_SPPsCount = 1,
    /// <include file='DISPID_SpeechPhraseProperties.xml' path='doc/member[@name="DISPID_SpeechPhraseProperties.DISPID_SPPsItem"]/*'/>
    DISPID_SPPsItem = (0),
    /// <include file='DISPID_SpeechPhraseProperties.xml' path='doc/member[@name="DISPID_SpeechPhraseProperties.DISPID_SPPs_NewEnum"]/*'/>
    DISPID_SPPs_NewEnum = (-4),
}