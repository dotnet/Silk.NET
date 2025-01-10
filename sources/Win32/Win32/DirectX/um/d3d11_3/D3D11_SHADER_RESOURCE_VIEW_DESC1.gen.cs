// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D11_SHADER_RESOURCE_VIEW_DESC1
{
    public DXGI_FORMAT Format;

    [NativeTypeName("D3D11_SRV_DIMENSION")]
    public D3D_SRV_DIMENSION ViewDimension;

    [NativeTypeName("__AnonymousRecord_d3d11_3_L928_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref D3D11_BUFFER_SRV Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Buffer; }
    }

    [UnscopedRef]
    public ref D3D11_TEX1D_SRV Texture1D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture1D; }
    }

    [UnscopedRef]
    public ref D3D11_TEX1D_ARRAY_SRV Texture1DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture1DArray; }
    }

    [UnscopedRef]
    public ref D3D11_TEX2D_SRV1 Texture2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2D; }
    }

    [UnscopedRef]
    public ref D3D11_TEX2D_ARRAY_SRV1 Texture2DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2DArray; }
    }

    [UnscopedRef]
    public ref D3D11_TEX2DMS_SRV Texture2DMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2DMS; }
    }

    [UnscopedRef]
    public ref D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2DMSArray; }
    }

    [UnscopedRef]
    public ref D3D11_TEX3D_SRV Texture3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture3D; }
    }

    [UnscopedRef]
    public ref D3D11_TEXCUBE_SRV TextureCube
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.TextureCube; }
    }

    [UnscopedRef]
    public ref D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.TextureCubeArray; }
    }

    [UnscopedRef]
    public ref D3D11_BUFFEREX_SRV BufferEx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.BufferEx; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D11_BUFFER_SRV Buffer;

        [FieldOffset(0)]
        public D3D11_TEX1D_SRV Texture1D;

        [FieldOffset(0)]
        public D3D11_TEX1D_ARRAY_SRV Texture1DArray;

        [FieldOffset(0)]
        public D3D11_TEX2D_SRV1 Texture2D;

        [FieldOffset(0)]
        public D3D11_TEX2D_ARRAY_SRV1 Texture2DArray;

        [FieldOffset(0)]
        public D3D11_TEX2DMS_SRV Texture2DMS;

        [FieldOffset(0)]
        public D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray;

        [FieldOffset(0)]
        public D3D11_TEX3D_SRV Texture3D;

        [FieldOffset(0)]
        public D3D11_TEXCUBE_SRV TextureCube;

        [FieldOffset(0)]
        public D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray;

        [FieldOffset(0)]
        public D3D11_BUFFEREX_SRV BufferEx;
    }
}
