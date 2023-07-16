// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_GLYPH_RUN_DESCRIPTION.xml' path='doc/member[@name="DWRITE_GLYPH_RUN_DESCRIPTION"]/*'/>
public unsafe partial struct DWRITE_GLYPH_RUN_DESCRIPTION
{
    /// <include file='DWRITE_GLYPH_RUN_DESCRIPTION.xml' path='doc/member[@name="DWRITE_GLYPH_RUN_DESCRIPTION.localeName"]/*'/>
    [NativeTypeName("const WCHAR *")]
    public ushort* localeName;
    /// <include file='DWRITE_GLYPH_RUN_DESCRIPTION.xml' path='doc/member[@name="DWRITE_GLYPH_RUN_DESCRIPTION.@string"]/*'/>
    [NativeTypeName("const WCHAR *")]
    public ushort* @string;
    /// <include file='DWRITE_GLYPH_RUN_DESCRIPTION.xml' path='doc/member[@name="DWRITE_GLYPH_RUN_DESCRIPTION.stringLength"]/*'/>
    [NativeTypeName("UINT32")]
    public uint stringLength;
    /// <include file='DWRITE_GLYPH_RUN_DESCRIPTION.xml' path='doc/member[@name="DWRITE_GLYPH_RUN_DESCRIPTION.clusterMap"]/*'/>
    [NativeTypeName("const UINT16 *")]
    public ushort* clusterMap;
    /// <include file='DWRITE_GLYPH_RUN_DESCRIPTION.xml' path='doc/member[@name="DWRITE_GLYPH_RUN_DESCRIPTION.textPosition"]/*'/>
    [NativeTypeName("UINT32")]
    public uint textPosition;
}