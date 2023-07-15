// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechPhraseReplacements.xml' path='doc/member[@name="DISPID_SpeechPhraseReplacements"]/*'/>
public enum DISPID_SpeechPhraseReplacements
{
    /// <include file='DISPID_SpeechPhraseReplacements.xml' path='doc/member[@name="DISPID_SpeechPhraseReplacements.DISPID_SPRsCount"]/*'/>
    DISPID_SPRsCount = 1,
    /// <include file='DISPID_SpeechPhraseReplacements.xml' path='doc/member[@name="DISPID_SpeechPhraseReplacements.DISPID_SPRsItem"]/*'/>
    DISPID_SPRsItem = (0),
    /// <include file='DISPID_SpeechPhraseReplacements.xml' path='doc/member[@name="DISPID_SpeechPhraseReplacements.DISPID_SPRs_NewEnum"]/*'/>
    DISPID_SPRs_NewEnum = (-4),
}