// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D10_RENDER_TARGET_VIEW_DESC
{
    public DXGI_FORMAT Format;
    public D3D10_RTV_DIMENSION ViewDimension;

    [NativeTypeName("__AnonymousRecord_d3d10_L3128_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref D3D10_BUFFER_RTV Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Buffer; }
    }

    [UnscopedRef]
    public ref D3D10_TEX1D_RTV Texture1D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture1D; }
    }

    [UnscopedRef]
    public ref D3D10_TEX1D_ARRAY_RTV Texture1DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture1DArray; }
    }

    [UnscopedRef]
    public ref D3D10_TEX2D_RTV Texture2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2D; }
    }

    [UnscopedRef]
    public ref D3D10_TEX2D_ARRAY_RTV Texture2DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2DArray; }
    }

    [UnscopedRef]
    public ref D3D10_TEX2DMS_RTV Texture2DMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2DMS; }
    }

    [UnscopedRef]
    public ref D3D10_TEX2DMS_ARRAY_RTV Texture2DMSArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2DMSArray; }
    }

    [UnscopedRef]
    public ref D3D10_TEX3D_RTV Texture3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture3D; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D10_BUFFER_RTV Buffer;

        [FieldOffset(0)]
        public D3D10_TEX1D_RTV Texture1D;

        [FieldOffset(0)]
        public D3D10_TEX1D_ARRAY_RTV Texture1DArray;

        [FieldOffset(0)]
        public D3D10_TEX2D_RTV Texture2D;

        [FieldOffset(0)]
        public D3D10_TEX2D_ARRAY_RTV Texture2DArray;

        [FieldOffset(0)]
        public D3D10_TEX2DMS_RTV Texture2DMS;

        [FieldOffset(0)]
        public D3D10_TEX2DMS_ARRAY_RTV Texture2DMSArray;

        [FieldOffset(0)]
        public D3D10_TEX3D_RTV Texture3D;
    }
}
