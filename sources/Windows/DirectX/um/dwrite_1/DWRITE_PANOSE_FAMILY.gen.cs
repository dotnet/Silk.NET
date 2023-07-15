// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_PANOSE_FAMILY.xml' path='doc/member[@name="DWRITE_PANOSE_FAMILY"]/*'/>
public enum DWRITE_PANOSE_FAMILY
{
    /// <include file='DWRITE_PANOSE_FAMILY.xml' path='doc/member[@name="DWRITE_PANOSE_FAMILY.DWRITE_PANOSE_FAMILY_ANY"]/*'/>
    DWRITE_PANOSE_FAMILY_ANY = 0,
    /// <include file='DWRITE_PANOSE_FAMILY.xml' path='doc/member[@name="DWRITE_PANOSE_FAMILY.DWRITE_PANOSE_FAMILY_NO_FIT"]/*'/>
    DWRITE_PANOSE_FAMILY_NO_FIT = 1,
    /// <include file='DWRITE_PANOSE_FAMILY.xml' path='doc/member[@name="DWRITE_PANOSE_FAMILY.DWRITE_PANOSE_FAMILY_TEXT_DISPLAY"]/*'/>
    DWRITE_PANOSE_FAMILY_TEXT_DISPLAY = 2,
    /// <include file='DWRITE_PANOSE_FAMILY.xml' path='doc/member[@name="DWRITE_PANOSE_FAMILY.DWRITE_PANOSE_FAMILY_SCRIPT"]/*'/>
    DWRITE_PANOSE_FAMILY_SCRIPT = 3,
    /// <include file='DWRITE_PANOSE_FAMILY.xml' path='doc/member[@name="DWRITE_PANOSE_FAMILY.DWRITE_PANOSE_FAMILY_DECORATIVE"]/*'/>
    DWRITE_PANOSE_FAMILY_DECORATIVE = 4,
    /// <include file='DWRITE_PANOSE_FAMILY.xml' path='doc/member[@name="DWRITE_PANOSE_FAMILY.DWRITE_PANOSE_FAMILY_SYMBOL"]/*'/>
    DWRITE_PANOSE_FAMILY_SYMBOL = 5,
    /// <include file='DWRITE_PANOSE_FAMILY.xml' path='doc/member[@name="DWRITE_PANOSE_FAMILY.DWRITE_PANOSE_FAMILY_PICTORIAL"]/*'/>
    DWRITE_PANOSE_FAMILY_PICTORIAL = DWRITE_PANOSE_FAMILY_SYMBOL,
}