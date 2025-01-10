// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12_BARRIER_GROUP
{
    public D3D12_BARRIER_TYPE Type;

    [NativeTypeName("UINT32")]
    public uint NumBarriers;

    [NativeTypeName("__AnonymousRecord_d3d12_L22079_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref D3D12_GLOBAL_BARRIER* pGlobalBarriers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pGlobalBarriers; }
    }

    [UnscopedRef]
    public ref D3D12_TEXTURE_BARRIER* pTextureBarriers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pTextureBarriers; }
    }

    [UnscopedRef]
    public ref D3D12_BUFFER_BARRIER* pBufferBarriers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pBufferBarriers; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_GLOBAL_BARRIER *")]
        public D3D12_GLOBAL_BARRIER* pGlobalBarriers;

        [FieldOffset(0)]
        [NativeTypeName("const D3D12_TEXTURE_BARRIER *")]
        public D3D12_TEXTURE_BARRIER* pTextureBarriers;

        [FieldOffset(0)]
        [NativeTypeName("const D3D12_BUFFER_BARRIER *")]
        public D3D12_BUFFER_BARRIER* pBufferBarriers;
    }
}
