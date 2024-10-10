// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_UNORDERED_ACCESS_VIEW_DESC.xml' path='doc/member[@name="D3D12_UNORDERED_ACCESS_VIEW_DESC"]/*'/>
public partial struct D3D12_UNORDERED_ACCESS_VIEW_DESC
{
    /// <include file='D3D12_UNORDERED_ACCESS_VIEW_DESC.xml' path='doc/member[@name="D3D12_UNORDERED_ACCESS_VIEW_DESC.Format"]/*'/>

    public DXGI_FORMAT Format;

    /// <include file='D3D12_UNORDERED_ACCESS_VIEW_DESC.xml' path='doc/member[@name="D3D12_UNORDERED_ACCESS_VIEW_DESC.ViewDimension"]/*'/>

    public D3D12_UAV_DIMENSION ViewDimension;

    /// <include file='D3D12_UNORDERED_ACCESS_VIEW_DESC.xml' path='doc/member[@name="D3D12_UNORDERED_ACCESS_VIEW_DESC.Anonymous"]/*'/>

    [NativeTypeName("__AnonymousRecord_d3d12_L3468_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Buffer"]/*'/>

    [UnscopedRef]
    public ref D3D12_BUFFER_UAV Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Buffer; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1D"]/*'/>

    [UnscopedRef]
    public ref D3D12_TEX1D_UAV Texture1D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture1D; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1DArray"]/*'/>

    [UnscopedRef]
    public ref D3D12_TEX1D_ARRAY_UAV Texture1DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture1DArray; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*'/>

    [UnscopedRef]
    public ref D3D12_TEX2D_UAV Texture2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2D; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DArray"]/*'/>

    [UnscopedRef]
    public ref D3D12_TEX2D_ARRAY_UAV Texture2DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2DArray; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMS"]/*'/>

    [UnscopedRef]
    public ref D3D12_TEX2DMS_UAV Texture2DMS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2DMS; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMSArray"]/*'/>

    [UnscopedRef]
    public ref D3D12_TEX2DMS_ARRAY_UAV Texture2DMSArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture2DMSArray; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture3D"]/*'/>

    [UnscopedRef]
    public ref D3D12_TEX3D_UAV Texture3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Texture3D; }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Buffer"]/*'/>

        [FieldOffset(0)]
        public D3D12_BUFFER_UAV Buffer;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1D"]/*'/>

        [FieldOffset(0)]
        public D3D12_TEX1D_UAV Texture1D;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1DArray"]/*'/>

        [FieldOffset(0)]
        public D3D12_TEX1D_ARRAY_UAV Texture1DArray;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*'/>

        [FieldOffset(0)]
        public D3D12_TEX2D_UAV Texture2D;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DArray"]/*'/>

        [FieldOffset(0)]
        public D3D12_TEX2D_ARRAY_UAV Texture2DArray;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMS"]/*'/>

        [FieldOffset(0)]
        public D3D12_TEX2DMS_UAV Texture2DMS;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DMSArray"]/*'/>

        [FieldOffset(0)]
        public D3D12_TEX2DMS_ARRAY_UAV Texture2DMSArray;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture3D"]/*'/>

        [FieldOffset(0)]
        public D3D12_TEX3D_UAV Texture3D;
    }
}
