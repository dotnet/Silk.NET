// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_UNORDERED_ACCESS_VIEW_DESC
{
    public DXGI_FORMAT Format;
    public D3D12_UAV_DIMENSION ViewDimension;

    [NativeTypeName("__AnonymousRecord_d3d12_L3708_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref D3D12_BUFFER_UAV Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Buffer; }
    }

    [UnscopedRef]
    public ref D3D12_TEX1D_UAV Texture1D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture1D; }
    }

    [UnscopedRef]
    public ref D3D12_TEX1D_ARRAY_UAV Texture1DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture1DArray; }
    }

    [UnscopedRef]
    public ref D3D12_TEX2D_UAV Texture2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2D; }
    }

    [UnscopedRef]
    public ref D3D12_TEX2D_ARRAY_UAV Texture2DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2DArray; }
    }

    [UnscopedRef]
    public ref D3D12_TEX2DMS_UAV Texture2DMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2DMS; }
    }

    [UnscopedRef]
    public ref D3D12_TEX2DMS_ARRAY_UAV Texture2DMSArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2DMSArray; }
    }

    [UnscopedRef]
    public ref D3D12_TEX3D_UAV Texture3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture3D; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public D3D12_BUFFER_UAV Buffer;

        [FieldOffset(0)]
        public D3D12_TEX1D_UAV Texture1D;

        [FieldOffset(0)]
        public D3D12_TEX1D_ARRAY_UAV Texture1DArray;

        [FieldOffset(0)]
        public D3D12_TEX2D_UAV Texture2D;

        [FieldOffset(0)]
        public D3D12_TEX2D_ARRAY_UAV Texture2DArray;

        [FieldOffset(0)]
        public D3D12_TEX2DMS_UAV Texture2DMS;

        [FieldOffset(0)]
        public D3D12_TEX2DMS_ARRAY_UAV Texture2DMSArray;

        [FieldOffset(0)]
        public D3D12_TEX3D_UAV Texture3D;
    }
}
