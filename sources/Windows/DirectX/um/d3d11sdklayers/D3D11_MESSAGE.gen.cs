// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='D3D11_MESSAGE.xml' path='doc/member[@name="D3D11_MESSAGE"]/*'/>
public unsafe partial struct D3D11_MESSAGE
{
    /// <include file='D3D11_MESSAGE.xml' path='doc/member[@name="D3D11_MESSAGE.Category"]/*'/>
    public D3D11_MESSAGE_CATEGORY Category;
    /// <include file='D3D11_MESSAGE.xml' path='doc/member[@name="D3D11_MESSAGE.Severity"]/*'/>
    public D3D11_MESSAGE_SEVERITY Severity;
    /// <include file='D3D11_MESSAGE.xml' path='doc/member[@name="D3D11_MESSAGE.ID"]/*'/>
    public D3D11_MESSAGE_ID ID;
    /// <include file='D3D11_MESSAGE.xml' path='doc/member[@name="D3D11_MESSAGE.pDescription"]/*'/>
    [NativeTypeName("const char *")]
    public sbyte* pDescription;
    /// <include file='D3D11_MESSAGE.xml' path='doc/member[@name="D3D11_MESSAGE.DescriptionByteLength"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint DescriptionByteLength;
}