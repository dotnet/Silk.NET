// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGEHLP_SF_TYPE.xml' path='doc/member[@name="IMAGEHLP_SF_TYPE"]/*'/>
public enum IMAGEHLP_SF_TYPE
{
    /// <include file='IMAGEHLP_SF_TYPE.xml' path='doc/member[@name="IMAGEHLP_SF_TYPE.sfImage"]/*'/>
    sfImage = 0,
    /// <include file='IMAGEHLP_SF_TYPE.xml' path='doc/member[@name="IMAGEHLP_SF_TYPE.sfDbg"]/*'/>
    sfDbg,
    /// <include file='IMAGEHLP_SF_TYPE.xml' path='doc/member[@name="IMAGEHLP_SF_TYPE.sfPdb"]/*'/>
    sfPdb,
    /// <include file='IMAGEHLP_SF_TYPE.xml' path='doc/member[@name="IMAGEHLP_SF_TYPE.sfMpd"]/*'/>
    sfMpd,
    /// <include file='IMAGEHLP_SF_TYPE.xml' path='doc/member[@name="IMAGEHLP_SF_TYPE.sfMax"]/*'/>
    sfMax,
}