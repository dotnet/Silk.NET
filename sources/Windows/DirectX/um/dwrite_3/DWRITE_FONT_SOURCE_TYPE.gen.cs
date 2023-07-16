// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_FONT_SOURCE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_SOURCE_TYPE"]/*'/>
public enum DWRITE_FONT_SOURCE_TYPE
{
    /// <include file='DWRITE_FONT_SOURCE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_SOURCE_TYPE.DWRITE_FONT_SOURCE_TYPE_UNKNOWN"]/*'/>
    DWRITE_FONT_SOURCE_TYPE_UNKNOWN,
    /// <include file='DWRITE_FONT_SOURCE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_SOURCE_TYPE.DWRITE_FONT_SOURCE_TYPE_PER_MACHINE"]/*'/>
    DWRITE_FONT_SOURCE_TYPE_PER_MACHINE,
    /// <include file='DWRITE_FONT_SOURCE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_SOURCE_TYPE.DWRITE_FONT_SOURCE_TYPE_PER_USER"]/*'/>
    DWRITE_FONT_SOURCE_TYPE_PER_USER,
    /// <include file='DWRITE_FONT_SOURCE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_SOURCE_TYPE.DWRITE_FONT_SOURCE_TYPE_APPX_PACKAGE"]/*'/>
    DWRITE_FONT_SOURCE_TYPE_APPX_PACKAGE,
    /// <include file='DWRITE_FONT_SOURCE_TYPE.xml' path='doc/member[@name="DWRITE_FONT_SOURCE_TYPE.DWRITE_FONT_SOURCE_TYPE_REMOTE_FONT_PROVIDER"]/*'/>
    DWRITE_FONT_SOURCE_TYPE_REMOTE_FONT_PROVIDER,
}