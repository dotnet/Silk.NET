// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_ROOT_PARAMETER1
{
    public D3D12_ROOT_PARAMETER_TYPE ParameterType;

    [NativeTypeName("__AnonymousRecord_d3d12_L4111_C5")]
    public _Anonymous_e__Union Anonymous;
    public D3D12_SHADER_VISIBILITY ShaderVisibility;

    [UnscopedRef]
    public ref D3D12_ROOT_DESCRIPTOR_TABLE1 DescriptorTable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.DescriptorTable; }
    }

    [UnscopedRef]
    public ref D3D12_ROOT_CONSTANTS Constants
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Constants; }
    }

    [UnscopedRef]
    public ref D3D12_ROOT_DESCRIPTOR1 Descriptor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Descriptor; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_ROOT_DESCRIPTOR_TABLE1 DescriptorTable;

        [FieldOffset(0)]
        public D3D12_ROOT_CONSTANTS Constants;

        [FieldOffset(0)]
        public D3D12_ROOT_DESCRIPTOR1 Descriptor;
    }
}
