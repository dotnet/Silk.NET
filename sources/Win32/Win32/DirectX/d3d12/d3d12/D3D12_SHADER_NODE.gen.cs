// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_SHADER_NODE
{
    [NativeTypeName("LPCWSTR")]
    public ushort* Shader;
    public D3D12_NODE_OVERRIDES_TYPE OverridesType;

    [NativeTypeName("__AnonymousRecord_d3d12_L14422_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref D3D12_BROADCASTING_LAUNCH_OVERRIDES* pBroadcastingLaunchOverrides
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pBroadcastingLaunchOverrides; }
    }

    [UnscopedRef]
    public ref D3D12_COALESCING_LAUNCH_OVERRIDES* pCoalescingLaunchOverrides
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pCoalescingLaunchOverrides; }
    }

    [UnscopedRef]
    public ref D3D12_THREAD_LAUNCH_OVERRIDES* pThreadLaunchOverrides
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pThreadLaunchOverrides; }
    }

    [UnscopedRef]
    public ref D3D12_COMMON_COMPUTE_NODE_OVERRIDES* pCommonComputeNodeOverrides
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pCommonComputeNodeOverrides; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_BROADCASTING_LAUNCH_OVERRIDES *")]
        public D3D12_BROADCASTING_LAUNCH_OVERRIDES* pBroadcastingLaunchOverrides;

        [FieldOffset(0)]
        [NativeTypeName("const D3D12_COALESCING_LAUNCH_OVERRIDES *")]
        public D3D12_COALESCING_LAUNCH_OVERRIDES* pCoalescingLaunchOverrides;

        [FieldOffset(0)]
        [NativeTypeName("const D3D12_THREAD_LAUNCH_OVERRIDES *")]
        public D3D12_THREAD_LAUNCH_OVERRIDES* pThreadLaunchOverrides;

        [FieldOffset(0)]
        [NativeTypeName("const D3D12_COMMON_COMPUTE_NODE_OVERRIDES *")]
        public D3D12_COMMON_COMPUTE_NODE_OVERRIDES* pCommonComputeNodeOverrides;
    }
}
