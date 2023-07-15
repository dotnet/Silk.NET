// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_RESOURCE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER"]/*'/>
public partial struct D3D12_RESOURCE_BARRIER
{
    /// <include file='D3D12_RESOURCE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER.Type"]/*'/>
    public D3D12_RESOURCE_BARRIER_TYPE Type;
    /// <include file='D3D12_RESOURCE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER.Flags"]/*'/>
    public D3D12_RESOURCE_BARRIER_FLAGS Flags;
    /// <include file='D3D12_RESOURCE_BARRIER.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_d3d12_L3002_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Transition"]/*'/>
    [UnscopedRef]
    public ref D3D12_RESOURCE_TRANSITION_BARRIER Transition
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Transition;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Aliasing"]/*'/>
    [UnscopedRef]
    public ref D3D12_RESOURCE_ALIASING_BARRIER Aliasing
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Aliasing;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UAV"]/*'/>
    [UnscopedRef]
    public ref D3D12_RESOURCE_UAV_BARRIER UAV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.UAV;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Transition"]/*'/>
        [FieldOffset(0)]
        public D3D12_RESOURCE_TRANSITION_BARRIER Transition;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Aliasing"]/*'/>
        [FieldOffset(0)]
        public D3D12_RESOURCE_ALIASING_BARRIER Aliasing;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UAV"]/*'/>
        [FieldOffset(0)]
        public D3D12_RESOURCE_UAV_BARRIER UAV;
    }
}