// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_STRIKETHROUGH.xml' path='doc/member[@name="DWRITE_STRIKETHROUGH"]/*'/>
public unsafe partial struct DWRITE_STRIKETHROUGH
{
    /// <include file='DWRITE_STRIKETHROUGH.xml' path='doc/member[@name="DWRITE_STRIKETHROUGH.width"]/*'/>
    public float width;
    /// <include file='DWRITE_STRIKETHROUGH.xml' path='doc/member[@name="DWRITE_STRIKETHROUGH.thickness"]/*'/>
    public float thickness;
    /// <include file='DWRITE_STRIKETHROUGH.xml' path='doc/member[@name="DWRITE_STRIKETHROUGH.offset"]/*'/>
    public float offset;
    /// <include file='DWRITE_STRIKETHROUGH.xml' path='doc/member[@name="DWRITE_STRIKETHROUGH.readingDirection"]/*'/>
    public DWRITE_READING_DIRECTION readingDirection;
    /// <include file='DWRITE_STRIKETHROUGH.xml' path='doc/member[@name="DWRITE_STRIKETHROUGH.flowDirection"]/*'/>
    public DWRITE_FLOW_DIRECTION flowDirection;
    /// <include file='DWRITE_STRIKETHROUGH.xml' path='doc/member[@name="DWRITE_STRIKETHROUGH.localeName"]/*'/>
    [NativeTypeName("const WCHAR *")]
    public ushort* localeName;
    /// <include file='DWRITE_STRIKETHROUGH.xml' path='doc/member[@name="DWRITE_STRIKETHROUGH.measuringMode"]/*'/>
    public DWRITE_MEASURING_MODE measuringMode;
}