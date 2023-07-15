// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT"]/*'/>
public enum DWRITE_PANOSE_WEIGHT
{
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_ANY"]/*'/>
    DWRITE_PANOSE_WEIGHT_ANY = 0,
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_NO_FIT"]/*'/>
    DWRITE_PANOSE_WEIGHT_NO_FIT = 1,
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_VERY_LIGHT"]/*'/>
    DWRITE_PANOSE_WEIGHT_VERY_LIGHT = 2,
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_LIGHT"]/*'/>
    DWRITE_PANOSE_WEIGHT_LIGHT = 3,
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_THIN"]/*'/>
    DWRITE_PANOSE_WEIGHT_THIN = 4,
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_BOOK"]/*'/>
    DWRITE_PANOSE_WEIGHT_BOOK = 5,
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_MEDIUM"]/*'/>
    DWRITE_PANOSE_WEIGHT_MEDIUM = 6,
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_DEMI"]/*'/>
    DWRITE_PANOSE_WEIGHT_DEMI = 7,
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_BOLD"]/*'/>
    DWRITE_PANOSE_WEIGHT_BOLD = 8,
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_HEAVY"]/*'/>
    DWRITE_PANOSE_WEIGHT_HEAVY = 9,
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_BLACK"]/*'/>
    DWRITE_PANOSE_WEIGHT_BLACK = 10,
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_EXTRA_BLACK"]/*'/>
    DWRITE_PANOSE_WEIGHT_EXTRA_BLACK = 11,
    /// <include file='DWRITE_PANOSE_WEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_WEIGHT.DWRITE_PANOSE_WEIGHT_NORD"]/*'/>
    DWRITE_PANOSE_WEIGHT_NORD = DWRITE_PANOSE_WEIGHT_EXTRA_BLACK,
}