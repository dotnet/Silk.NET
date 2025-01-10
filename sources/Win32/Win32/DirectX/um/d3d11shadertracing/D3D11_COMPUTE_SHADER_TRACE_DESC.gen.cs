// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_COMPUTE_SHADER_TRACE_DESC
{
    [NativeTypeName("UINT64")]
    public ulong Invocation;

    [NativeTypeName("UINT[3]")]
    public _ThreadIDInGroup_e__FixedBuffer ThreadIDInGroup;

    [NativeTypeName("UINT[3]")]
    public _ThreadGroupID_e__FixedBuffer ThreadGroupID;

    [InlineArray(3)]
    public partial struct _ThreadIDInGroup_e__FixedBuffer
    {
        public uint e0;
    }

    [InlineArray(3)]
    public partial struct _ThreadGroupID_e__FixedBuffer
    {
        public uint e0;
    }
}
