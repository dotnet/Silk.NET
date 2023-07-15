// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_UNICODE_RANGE.xml' path='doc/member[@name="DWRITE_UNICODE_RANGE"]/*'/>
public partial struct DWRITE_UNICODE_RANGE
{
    /// <include file='DWRITE_UNICODE_RANGE.xml' path='doc/member[@name="DWRITE_UNICODE_RANGE.first"]/*'/>
    [NativeTypeName("UINT32")]
    public uint first;
    /// <include file='DWRITE_UNICODE_RANGE.xml' path='doc/member[@name="DWRITE_UNICODE_RANGE.last"]/*'/>
    [NativeTypeName("UINT32")]
    public uint last;
}