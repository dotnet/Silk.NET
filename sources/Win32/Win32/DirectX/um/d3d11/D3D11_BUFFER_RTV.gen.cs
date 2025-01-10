// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D11_BUFFER_RTV
{
    [NativeTypeName("__AnonymousRecord_d3d11_L3858_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("__AnonymousRecord_d3d11_L3863_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [UnscopedRef]
    public ref uint FirstElement
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.FirstElement; }
    }

    [UnscopedRef]
    public ref uint ElementOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.ElementOffset; }
    }

    [UnscopedRef]
    public ref uint NumElements
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.NumElements; }
    }

    [UnscopedRef]
    public ref uint ElementWidth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.ElementWidth; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public uint FirstElement;

        [FieldOffset(0)]
        public uint ElementOffset;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public uint NumElements;

        [FieldOffset(0)]
        public uint ElementWidth;
    }
}
