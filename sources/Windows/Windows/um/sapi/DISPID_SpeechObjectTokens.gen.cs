// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechObjectTokens.xml' path='doc/member[@name="DISPID_SpeechObjectTokens"]/*'/>
public enum DISPID_SpeechObjectTokens
{
    /// <include file='DISPID_SpeechObjectTokens.xml' path='doc/member[@name="DISPID_SpeechObjectTokens.DISPID_SOTsCount"]/*'/>
    DISPID_SOTsCount = 1,
    /// <include file='DISPID_SpeechObjectTokens.xml' path='doc/member[@name="DISPID_SpeechObjectTokens.DISPID_SOTsItem"]/*'/>
    DISPID_SOTsItem = (0),
    /// <include file='DISPID_SpeechObjectTokens.xml' path='doc/member[@name="DISPID_SpeechObjectTokens.DISPID_SOTs_NewEnum"]/*'/>
    DISPID_SOTs_NewEnum = (-4),
}