// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DISPID_SpeechLexiconProns.xml' path='doc/member[@name="DISPID_SpeechLexiconProns"]/*'/>
public enum DISPID_SpeechLexiconProns
{
    /// <include file='DISPID_SpeechLexiconProns.xml' path='doc/member[@name="DISPID_SpeechLexiconProns.DISPID_SLPsCount"]/*'/>
    DISPID_SLPsCount = 1,
    /// <include file='DISPID_SpeechLexiconProns.xml' path='doc/member[@name="DISPID_SpeechLexiconProns.DISPID_SLPsItem"]/*'/>
    DISPID_SLPsItem = (0),
    /// <include file='DISPID_SpeechLexiconProns.xml' path='doc/member[@name="DISPID_SpeechLexiconProns.DISPID_SLPs_NewEnum"]/*'/>
    DISPID_SLPs_NewEnum = (-4),
}