// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_BARRIER_GROUP.xml' path='doc/member[@name="D3D12_BARRIER_GROUP"]/*' />
public unsafe partial struct D3D12_BARRIER_GROUP
{
    /// <include file='D3D12_BARRIER_GROUP.xml' path='doc/member[@name="D3D12_BARRIER_GROUP.Type"]/*' />
    public D3D12_BARRIER_TYPE Type;

    /// <include file='D3D12_BARRIER_GROUP.xml' path='doc/member[@name="D3D12_BARRIER_GROUP.NumBarriers"]/*' />
    [NativeTypeName("UINT32")]
    public uint NumBarriers;

    /// <include file='D3D12_BARRIER_GROUP.xml' path='doc/member[@name="D3D12_BARRIER_GROUP.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12_L21089_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pGlobalBarriers"]/*' />
    [UnscopedRef]
    public ref D3D12_GLOBAL_BARRIER* pGlobalBarriers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pGlobalBarriers;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pTextureBarriers"]/*' />
    [UnscopedRef]
    public ref D3D12_TEXTURE_BARRIER* pTextureBarriers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pTextureBarriers;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pBufferBarriers"]/*' />
    [UnscopedRef]
    public ref D3D12_BUFFER_BARRIER* pBufferBarriers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pBufferBarriers;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pGlobalBarriers"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_GLOBAL_BARRIER *")]
        public D3D12_GLOBAL_BARRIER* pGlobalBarriers;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pTextureBarriers"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_TEXTURE_BARRIER *")]
        public D3D12_TEXTURE_BARRIER* pTextureBarriers;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pBufferBarriers"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_BUFFER_BARRIER *")]
        public D3D12_BUFFER_BARRIER* pBufferBarriers;
    }
}
