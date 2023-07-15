// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS.xml' path='doc/member[@name="D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS"]/*'/>
public unsafe partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS
{
    /// <include file='D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS.xml' path='doc/member[@name="D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS.Type"]/*'/>
    public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE Type;
    /// <include file='D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS.xml' path='doc/member[@name="D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS.Flags"]/*'/>
    public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BUILD_FLAGS Flags;
    /// <include file='D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS.xml' path='doc/member[@name="D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS.NumDescs"]/*'/>
    public uint NumDescs;
    /// <include file='D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS.xml' path='doc/member[@name="D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS.DescsLayout"]/*'/>
    public D3D12_ELEMENTS_LAYOUT DescsLayout;
    /// <include file='D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS.xml' path='doc/member[@name="D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_d3d12_L13833_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.InstanceDescs"]/*'/>
    [UnscopedRef]
    public ref ulong InstanceDescs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.InstanceDescs;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pGeometryDescs"]/*'/>
    [UnscopedRef]
    public ref D3D12_RAYTRACING_GEOMETRY_DESC* pGeometryDescs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pGeometryDescs;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ppGeometryDescs"]/*'/>
    [UnscopedRef]
    public ref D3D12_RAYTRACING_GEOMETRY_DESC** ppGeometryDescs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ppGeometryDescs;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.InstanceDescs"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
        public ulong InstanceDescs;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pGeometryDescs"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_RAYTRACING_GEOMETRY_DESC *")]
        public D3D12_RAYTRACING_GEOMETRY_DESC* pGeometryDescs;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ppGeometryDescs"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("const D3D12_RAYTRACING_GEOMETRY_DESC *const *")]
        public D3D12_RAYTRACING_GEOMETRY_DESC** ppGeometryDescs;
    }
}