// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_INPUT_DESCRIPTION.xml' path='doc/member[@name="D2D1_INPUT_DESCRIPTION"]/*'/>
public partial struct D2D1_INPUT_DESCRIPTION
{
    /// <include file='D2D1_INPUT_DESCRIPTION.xml' path='doc/member[@name="D2D1_INPUT_DESCRIPTION.filter"]/*'/>
    public D2D1_FILTER filter;
    /// <include file='D2D1_INPUT_DESCRIPTION.xml' path='doc/member[@name="D2D1_INPUT_DESCRIPTION.levelOfDetailCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint levelOfDetailCount;
}