// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_TEXT_RANGE.xml' path='doc/member[@name="DWRITE_TEXT_RANGE"]/*'/>
public partial struct DWRITE_TEXT_RANGE
{
    /// <include file='DWRITE_TEXT_RANGE.xml' path='doc/member[@name="DWRITE_TEXT_RANGE.startPosition"]/*'/>
    [NativeTypeName("UINT32")]
    public uint startPosition;
    /// <include file='DWRITE_TEXT_RANGE.xml' path='doc/member[@name="DWRITE_TEXT_RANGE.length"]/*'/>
    [NativeTypeName("UINT32")]
    public uint length;
}