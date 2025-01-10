// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_TRACE_REGISTER
{
    public D3D11_TRACE_REGISTER_TYPE RegType;

    [NativeTypeName("__AnonymousRecord_d3d11shadertracing_L234_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("UINT8")]
    public byte OperandIndex;

    [NativeTypeName("UINT8")]
    public byte Flags;

    [UnscopedRef]
    public ref ushort Index1D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Index1D; }
    }

    [UnscopedRef]
    public Span<ushort> Index2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.Index2D; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("UINT16")]
        public ushort Index1D;

        [FieldOffset(0)]
        [NativeTypeName("UINT16[2]")]
        public _Index2D_e__FixedBuffer Index2D;

        [InlineArray(2)]
        public partial struct _Index2D_e__FixedBuffer
        {
            public ushort e0;
        }
    }
}
