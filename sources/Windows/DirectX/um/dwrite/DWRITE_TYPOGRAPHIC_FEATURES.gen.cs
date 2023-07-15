// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_TYPOGRAPHIC_FEATURES.xml' path='doc/member[@name="DWRITE_TYPOGRAPHIC_FEATURES"]/*'/>
public unsafe partial struct DWRITE_TYPOGRAPHIC_FEATURES
{
    /// <include file='DWRITE_TYPOGRAPHIC_FEATURES.xml' path='doc/member[@name="DWRITE_TYPOGRAPHIC_FEATURES.features"]/*'/>
    public DWRITE_FONT_FEATURE* features;
    /// <include file='DWRITE_TYPOGRAPHIC_FEATURES.xml' path='doc/member[@name="DWRITE_TYPOGRAPHIC_FEATURES.featureCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint featureCount;
}