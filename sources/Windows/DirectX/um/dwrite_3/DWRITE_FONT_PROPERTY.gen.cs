// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_FONT_PROPERTY.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY"]/*'/>
public unsafe partial struct DWRITE_FONT_PROPERTY
{
    /// <include file='DWRITE_FONT_PROPERTY.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY.propertyId"]/*'/>
    public DWRITE_FONT_PROPERTY_ID propertyId;
    /// <include file='DWRITE_FONT_PROPERTY.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY.propertyValue"]/*'/>
    [NativeTypeName("const WCHAR *")]
    public ushort* propertyValue;
    /// <include file='DWRITE_FONT_PROPERTY.xml' path='doc/member[@name="DWRITE_FONT_PROPERTY.localeName"]/*'/>
    [NativeTypeName("const WCHAR *")]
    public ushort* localeName;
}