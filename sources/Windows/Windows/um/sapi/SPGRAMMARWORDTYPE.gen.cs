// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPGRAMMARWORDTYPE.xml' path='doc/member[@name="SPGRAMMARWORDTYPE"]/*'/>
public enum SPGRAMMARWORDTYPE
{
    /// <include file='SPGRAMMARWORDTYPE.xml' path='doc/member[@name="SPGRAMMARWORDTYPE.SPWT_DISPLAY"]/*'/>
    SPWT_DISPLAY = 0,
    /// <include file='SPGRAMMARWORDTYPE.xml' path='doc/member[@name="SPGRAMMARWORDTYPE.SPWT_LEXICAL"]/*'/>
    SPWT_LEXICAL = (SPWT_DISPLAY + 1),
    /// <include file='SPGRAMMARWORDTYPE.xml' path='doc/member[@name="SPGRAMMARWORDTYPE.SPWT_PRONUNCIATION"]/*'/>
    SPWT_PRONUNCIATION = (SPWT_LEXICAL + 1),
    /// <include file='SPGRAMMARWORDTYPE.xml' path='doc/member[@name="SPGRAMMARWORDTYPE.SPWT_LEXICAL_NO_SPECIAL_CHARS"]/*'/>
    SPWT_LEXICAL_NO_SPECIAL_CHARS = (SPWT_PRONUNCIATION + 1),
}