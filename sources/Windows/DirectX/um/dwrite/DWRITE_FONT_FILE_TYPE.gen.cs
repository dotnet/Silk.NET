// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_FONT_FILE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_FILE_TYPE"]/*'/>
public enum DWRITE_FONT_FILE_TYPE
{
    /// <include file='DWRITE_FONT_FILE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_FILE_TYPE.DWRITE_FONT_FILE_TYPE_UNKNOWN"]/*'/>
    DWRITE_FONT_FILE_TYPE_UNKNOWN,
    /// <include file='DWRITE_FONT_FILE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_FILE_TYPE.DWRITE_FONT_FILE_TYPE_CFF"]/*'/>
    DWRITE_FONT_FILE_TYPE_CFF,
    /// <include file='DWRITE_FONT_FILE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_FILE_TYPE.DWRITE_FONT_FILE_TYPE_TRUETYPE"]/*'/>
    DWRITE_FONT_FILE_TYPE_TRUETYPE,
    /// <include file='DWRITE_FONT_FILE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_FILE_TYPE.DWRITE_FONT_FILE_TYPE_OPENTYPE_COLLECTION"]/*'/>
    DWRITE_FONT_FILE_TYPE_OPENTYPE_COLLECTION,
    /// <include file='DWRITE_FONT_FILE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_FILE_TYPE.DWRITE_FONT_FILE_TYPE_TYPE1_PFM"]/*'/>
    DWRITE_FONT_FILE_TYPE_TYPE1_PFM,
    /// <include file='DWRITE_FONT_FILE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_FILE_TYPE.DWRITE_FONT_FILE_TYPE_TYPE1_PFB"]/*'/>
    DWRITE_FONT_FILE_TYPE_TYPE1_PFB,
    /// <include file='DWRITE_FONT_FILE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_FILE_TYPE.DWRITE_FONT_FILE_TYPE_VECTOR"]/*'/>
    DWRITE_FONT_FILE_TYPE_VECTOR,
    /// <include file='DWRITE_FONT_FILE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_FILE_TYPE.DWRITE_FONT_FILE_TYPE_BITMAP"]/*'/>
    DWRITE_FONT_FILE_TYPE_BITMAP,
    /// <include file='DWRITE_FONT_FILE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_FILE_TYPE.DWRITE_FONT_FILE_TYPE_TRUETYPE_COLLECTION"]/*'/>
    DWRITE_FONT_FILE_TYPE_TRUETYPE_COLLECTION = DWRITE_FONT_FILE_TYPE_OPENTYPE_COLLECTION,
}