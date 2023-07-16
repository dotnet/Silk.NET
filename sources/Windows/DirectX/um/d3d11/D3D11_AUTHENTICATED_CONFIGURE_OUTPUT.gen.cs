// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_AUTHENTICATED_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_OUTPUT"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_AUTHENTICATED_CONFIGURE_OUTPUT
{
    /// <include file='D3D11_AUTHENTICATED_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_OUTPUT.omac"]/*'/>
    public D3D11_OMAC omac;
    /// <include file='D3D11_AUTHENTICATED_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_OUTPUT.ConfigureType"]/*'/>
    public Guid ConfigureType;
    /// <include file='D3D11_AUTHENTICATED_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_OUTPUT.hChannel"]/*'/>
    public HANDLE hChannel;
    /// <include file='D3D11_AUTHENTICATED_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_OUTPUT.SequenceNumber"]/*'/>
    public uint SequenceNumber;
    /// <include file='D3D11_AUTHENTICATED_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_OUTPUT.ReturnCode"]/*'/>
    public HRESULT ReturnCode;
}