// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_COMPUTE_SHADER_TRACE_DESC.xml' path='doc/member[@name="D3D11_COMPUTE_SHADER_TRACE_DESC"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct D3D11_COMPUTE_SHADER_TRACE_DESC
{
    /// <include file='D3D11_COMPUTE_SHADER_TRACE_DESC.xml' path='doc/member[@name="D3D11_COMPUTE_SHADER_TRACE_DESC.Invocation"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong Invocation;
    /// <include file='D3D11_COMPUTE_SHADER_TRACE_DESC.xml' path='doc/member[@name="D3D11_COMPUTE_SHADER_TRACE_DESC.ThreadIDInGroup"]/*'/>
    [NativeTypeName("UINT[3]")]
    public fixed uint ThreadIDInGroup[3];
    /// <include file='D3D11_COMPUTE_SHADER_TRACE_DESC.xml' path='doc/member[@name="D3D11_COMPUTE_SHADER_TRACE_DESC.ThreadGroupID"]/*'/>
    [NativeTypeName("UINT[3]")]
    public fixed uint ThreadGroupID[3];
}