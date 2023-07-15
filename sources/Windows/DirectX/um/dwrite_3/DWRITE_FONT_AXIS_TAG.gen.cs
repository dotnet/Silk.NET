// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_FONT_AXIS_TAG.xml' path='doc/member[@name="DWRITE_FONT_AXIS_TAG"]/*'/>
[NativeTypeName("UINT32")]
public enum DWRITE_FONT_AXIS_TAG : uint
{
    /// <include file='DWRITE_FONT_AXIS_TAG.xml' path='doc/member[@name="DWRITE_FONT_AXIS_TAG.DWRITE_FONT_AXIS_TAG_WEIGHT"]/*'/>
    DWRITE_FONT_AXIS_TAG_WEIGHT = unchecked((uint)(DWRITE_FONT_AXIS_TAG)(((uint)((byte)('t')) << 24) | ((uint)((byte)('h')) << 16) | ((uint)((byte)('g')) << 8) | (uint)((byte)('w')))),
    /// <include file='DWRITE_FONT_AXIS_TAG.xml' path='doc/member[@name="DWRITE_FONT_AXIS_TAG.DWRITE_FONT_AXIS_TAG_WIDTH"]/*'/>
    DWRITE_FONT_AXIS_TAG_WIDTH = unchecked((uint)(DWRITE_FONT_AXIS_TAG)(((uint)((byte)('h')) << 24) | ((uint)((byte)('t')) << 16) | ((uint)((byte)('d')) << 8) | (uint)((byte)('w')))),
    /// <include file='DWRITE_FONT_AXIS_TAG.xml' path='doc/member[@name="DWRITE_FONT_AXIS_TAG.DWRITE_FONT_AXIS_TAG_SLANT"]/*'/>
    DWRITE_FONT_AXIS_TAG_SLANT = unchecked((uint)(DWRITE_FONT_AXIS_TAG)(((uint)((byte)('t')) << 24) | ((uint)((byte)('n')) << 16) | ((uint)((byte)('l')) << 8) | (uint)((byte)('s')))),
    /// <include file='DWRITE_FONT_AXIS_TAG.xml' path='doc/member[@name="DWRITE_FONT_AXIS_TAG.DWRITE_FONT_AXIS_TAG_OPTICAL_SIZE"]/*'/>
    DWRITE_FONT_AXIS_TAG_OPTICAL_SIZE = unchecked((uint)(DWRITE_FONT_AXIS_TAG)(((uint)((byte)('z')) << 24) | ((uint)((byte)('s')) << 16) | ((uint)((byte)('p')) << 8) | (uint)((byte)('o')))),
    /// <include file='DWRITE_FONT_AXIS_TAG.xml' path='doc/member[@name="DWRITE_FONT_AXIS_TAG.DWRITE_FONT_AXIS_TAG_ITALIC"]/*'/>
    DWRITE_FONT_AXIS_TAG_ITALIC = unchecked((uint)(DWRITE_FONT_AXIS_TAG)(((uint)((byte)('l')) << 24) | ((uint)((byte)('a')) << 16) | ((uint)((byte)('t')) << 8) | (uint)((byte)('i')))),
}