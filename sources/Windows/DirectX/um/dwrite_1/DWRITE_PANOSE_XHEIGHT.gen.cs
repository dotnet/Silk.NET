// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_PANOSE_XHEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_XHEIGHT"]/*'/>
public enum DWRITE_PANOSE_XHEIGHT
{
    /// <include file='DWRITE_PANOSE_XHEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_XHEIGHT.DWRITE_PANOSE_XHEIGHT_ANY"]/*'/>
    DWRITE_PANOSE_XHEIGHT_ANY = 0,
    /// <include file='DWRITE_PANOSE_XHEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_XHEIGHT.DWRITE_PANOSE_XHEIGHT_NO_FIT"]/*'/>
    DWRITE_PANOSE_XHEIGHT_NO_FIT = 1,
    /// <include file='DWRITE_PANOSE_XHEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_XHEIGHT.DWRITE_PANOSE_XHEIGHT_CONSTANT_SMALL"]/*'/>
    DWRITE_PANOSE_XHEIGHT_CONSTANT_SMALL = 2,
    /// <include file='DWRITE_PANOSE_XHEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_XHEIGHT.DWRITE_PANOSE_XHEIGHT_CONSTANT_STANDARD"]/*'/>
    DWRITE_PANOSE_XHEIGHT_CONSTANT_STANDARD = 3,
    /// <include file='DWRITE_PANOSE_XHEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_XHEIGHT.DWRITE_PANOSE_XHEIGHT_CONSTANT_LARGE"]/*'/>
    DWRITE_PANOSE_XHEIGHT_CONSTANT_LARGE = 4,
    /// <include file='DWRITE_PANOSE_XHEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_XHEIGHT.DWRITE_PANOSE_XHEIGHT_DUCKING_SMALL"]/*'/>
    DWRITE_PANOSE_XHEIGHT_DUCKING_SMALL = 5,
    /// <include file='DWRITE_PANOSE_XHEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_XHEIGHT.DWRITE_PANOSE_XHEIGHT_DUCKING_STANDARD"]/*'/>
    DWRITE_PANOSE_XHEIGHT_DUCKING_STANDARD = 6,
    /// <include file='DWRITE_PANOSE_XHEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_XHEIGHT.DWRITE_PANOSE_XHEIGHT_DUCKING_LARGE"]/*'/>
    DWRITE_PANOSE_XHEIGHT_DUCKING_LARGE = 7,
    /// <include file='DWRITE_PANOSE_XHEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_XHEIGHT.DWRITE_PANOSE_XHEIGHT_CONSTANT_STD"]/*'/>
    DWRITE_PANOSE_XHEIGHT_CONSTANT_STD = DWRITE_PANOSE_XHEIGHT_CONSTANT_STANDARD,
    /// <include file='DWRITE_PANOSE_XHEIGHT.xml' path='doc/member[@name="DWRITE_PANOSE_XHEIGHT.DWRITE_PANOSE_XHEIGHT_DUCKING_STD"]/*'/>
    DWRITE_PANOSE_XHEIGHT_DUCKING_STD = DWRITE_PANOSE_XHEIGHT_DUCKING_STANDARD,
}