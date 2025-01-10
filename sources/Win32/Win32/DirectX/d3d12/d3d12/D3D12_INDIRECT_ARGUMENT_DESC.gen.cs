// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_INDIRECT_ARGUMENT_DESC
{
    public D3D12_INDIRECT_ARGUMENT_TYPE Type;

    [NativeTypeName("__AnonymousRecord_d3d12_L4543_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._VertexBuffer_e__Struct VertexBuffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.VertexBuffer; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._Constant_e__Struct Constant
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Constant; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._ConstantBufferView_e__Struct ConstantBufferView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ConstantBufferView; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._ShaderResourceView_e__Struct ShaderResourceView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ShaderResourceView; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._UnorderedAccessView_e__Struct UnorderedAccessView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.UnorderedAccessView; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._IncrementingConstant_e__Struct IncrementingConstant
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.IncrementingConstant; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_d3d12_L4545_C9")]
        public _VertexBuffer_e__Struct VertexBuffer;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_d3d12_L4549_C9")]
        public _Constant_e__Struct Constant;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_d3d12_L4555_C9")]
        public _ConstantBufferView_e__Struct ConstantBufferView;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_d3d12_L4559_C9")]
        public _ShaderResourceView_e__Struct ShaderResourceView;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_d3d12_L4563_C9")]
        public _UnorderedAccessView_e__Struct UnorderedAccessView;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_d3d12_L4567_C9")]
        public _IncrementingConstant_e__Struct IncrementingConstant;

        public partial struct _VertexBuffer_e__Struct
        {
            public uint Slot;
        }

        public partial struct _Constant_e__Struct
        {
            public uint RootParameterIndex;
            public uint DestOffsetIn32BitValues;
            public uint Num32BitValuesToSet;
        }

        public partial struct _ConstantBufferView_e__Struct
        {
            public uint RootParameterIndex;
        }

        public partial struct _ShaderResourceView_e__Struct
        {
            public uint RootParameterIndex;
        }

        public partial struct _UnorderedAccessView_e__Struct
        {
            public uint RootParameterIndex;
        }

        public partial struct _IncrementingConstant_e__Struct
        {
            public uint RootParameterIndex;
            public uint DestOffsetIn32BitValues;
        }
    }
}
