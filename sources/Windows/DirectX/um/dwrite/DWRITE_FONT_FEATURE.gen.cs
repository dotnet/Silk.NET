// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_FONT_FEATURE.xml' path='doc/member[@name="DWRITE_FONT_FEATURE"]/*'/>
public partial struct DWRITE_FONT_FEATURE
{
    /// <include file='DWRITE_FONT_FEATURE.xml' path='doc/member[@name="DWRITE_FONT_FEATURE.nameTag"]/*'/>
    public DWRITE_FONT_FEATURE_TAG nameTag;
    /// <include file='DWRITE_FONT_FEATURE.xml' path='doc/member[@name="DWRITE_FONT_FEATURE.parameter"]/*'/>
    [NativeTypeName("UINT32")]
    public uint parameter;
}