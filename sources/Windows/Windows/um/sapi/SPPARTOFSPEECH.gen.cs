// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPPARTOFSPEECH.xml' path='doc/member[@name="SPPARTOFSPEECH"]/*'/>
public enum SPPARTOFSPEECH
{
    /// <include file='SPPARTOFSPEECH.xml' path='doc/member[@name="SPPARTOFSPEECH.SPPS_NotOverriden"]/*'/>
    SPPS_NotOverriden = -1,
    /// <include file='SPPARTOFSPEECH.xml' path='doc/member[@name="SPPARTOFSPEECH.SPPS_Unknown"]/*'/>
    SPPS_Unknown = 0,
    /// <include file='SPPARTOFSPEECH.xml' path='doc/member[@name="SPPARTOFSPEECH.SPPS_Noun"]/*'/>
    SPPS_Noun = 0x1000,
    /// <include file='SPPARTOFSPEECH.xml' path='doc/member[@name="SPPARTOFSPEECH.SPPS_Verb"]/*'/>
    SPPS_Verb = 0x2000,
    /// <include file='SPPARTOFSPEECH.xml' path='doc/member[@name="SPPARTOFSPEECH.SPPS_Modifier"]/*'/>
    SPPS_Modifier = 0x3000,
    /// <include file='SPPARTOFSPEECH.xml' path='doc/member[@name="SPPARTOFSPEECH.SPPS_Function"]/*'/>
    SPPS_Function = 0x4000,
    /// <include file='SPPARTOFSPEECH.xml' path='doc/member[@name="SPPARTOFSPEECH.SPPS_Interjection"]/*'/>
    SPPS_Interjection = 0x5000,
    /// <include file='SPPARTOFSPEECH.xml' path='doc/member[@name="SPPARTOFSPEECH.SPPS_Noncontent"]/*'/>
    SPPS_Noncontent = 0x6000,
    /// <include file='SPPARTOFSPEECH.xml' path='doc/member[@name="SPPARTOFSPEECH.SPPS_LMA"]/*'/>
    SPPS_LMA = 0x7000,
    /// <include file='SPPARTOFSPEECH.xml' path='doc/member[@name="SPPARTOFSPEECH.SPPS_SuppressWord"]/*'/>
    SPPS_SuppressWord = 0xf000,
}