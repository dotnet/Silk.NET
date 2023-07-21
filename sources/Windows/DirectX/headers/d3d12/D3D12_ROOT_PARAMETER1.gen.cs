// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_ROOT_PARAMETER1.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER1"]/*' />
public partial struct D3D12_ROOT_PARAMETER1
{
    /// <include file='D3D12_ROOT_PARAMETER1.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER1.ParameterType"]/*' />
    public D3D12_ROOT_PARAMETER_TYPE ParameterType;

    /// <include file='D3D12_ROOT_PARAMETER1.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER1.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_d3d12_L3853_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='D3D12_ROOT_PARAMETER1.xml' path='doc/member[@name="D3D12_ROOT_PARAMETER1.ShaderVisibility"]/*' />
    public D3D12_SHADER_VISIBILITY ShaderVisibility;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DescriptorTable"]/*' />
    [UnscopedRef]
    public ref D3D12_ROOT_DESCRIPTOR_TABLE1 DescriptorTable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.DescriptorTable;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Constants"]/*' />
    [UnscopedRef]
    public ref D3D12_ROOT_CONSTANTS Constants
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Constants;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Descriptor"]/*' />
    [UnscopedRef]
    public ref D3D12_ROOT_DESCRIPTOR1 Descriptor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Descriptor;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.DescriptorTable"]/*' />
        [FieldOffset(0)]
        public D3D12_ROOT_DESCRIPTOR_TABLE1 DescriptorTable;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Constants"]/*' />
        [FieldOffset(0)]
        public D3D12_ROOT_CONSTANTS Constants;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Descriptor"]/*' />
        [FieldOffset(0)]
        public D3D12_ROOT_DESCRIPTOR1 Descriptor;
    }
}
