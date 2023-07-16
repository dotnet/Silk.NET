// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT
{
    /// <include file='D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT.Parameters"]/*'/>
    public D3D11_AUTHENTICATED_CONFIGURE_INPUT Parameters;
    /// <include file='D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT.ProcessType"]/*'/>
    public D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE ProcessType;
    /// <include file='D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT.ProcessHandle"]/*'/>
    public HANDLE ProcessHandle;
    /// <include file='D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT.AllowAccess"]/*'/>
    public BOOL AllowAccess;
}