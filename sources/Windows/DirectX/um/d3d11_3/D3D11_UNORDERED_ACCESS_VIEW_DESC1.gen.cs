// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='D3D11_UNORDERED_ACCESS_VIEW_DESC1.xml' path='doc/member[@name="D3D11_UNORDERED_ACCESS_VIEW_DESC1"]/*'/>
public partial struct D3D11_UNORDERED_ACCESS_VIEW_DESC1
{
    /// <include file='D3D11_UNORDERED_ACCESS_VIEW_DESC1.xml' path='doc/member[@name="D3D11_UNORDERED_ACCESS_VIEW_DESC1.Format"]/*'/>
    public DXGI_FORMAT Format;
    /// <include file='D3D11_UNORDERED_ACCESS_VIEW_DESC1.xml' path='doc/member[@name="D3D11_UNORDERED_ACCESS_VIEW_DESC1.ViewDimension"]/*'/>
    public D3D11_UAV_DIMENSION ViewDimension;
    /// <include file='D3D11_UNORDERED_ACCESS_VIEW_DESC1.xml' path='doc/member[@name="D3D11_UNORDERED_ACCESS_VIEW_DESC1.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_d3d11_3_L1689_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Buffer"]/*'/>
    [UnscopedRef]
    public ref D3D11_BUFFER_UAV Buffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Buffer;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1D"]/*'/>
    [UnscopedRef]
    public ref D3D11_TEX1D_UAV Texture1D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture1D;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1DArray"]/*'/>
    [UnscopedRef]
    public ref D3D11_TEX1D_ARRAY_UAV Texture1DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture1DArray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*'/>
    [UnscopedRef]
    public ref D3D11_TEX2D_UAV1 Texture2D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture2D;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DArray"]/*'/>
    [UnscopedRef]
    public ref D3D11_TEX2D_ARRAY_UAV1 Texture2DArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture2DArray;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture3D"]/*'/>
    [UnscopedRef]
    public ref D3D11_TEX3D_UAV Texture3D
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Texture3D;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Buffer"]/*'/>
        [FieldOffset(0)]
        public D3D11_BUFFER_UAV Buffer;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1D"]/*'/>
        [FieldOffset(0)]
        public D3D11_TEX1D_UAV Texture1D;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture1DArray"]/*'/>
        [FieldOffset(0)]
        public D3D11_TEX1D_ARRAY_UAV Texture1DArray;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2D"]/*'/>
        [FieldOffset(0)]
        public D3D11_TEX2D_UAV1 Texture2D;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture2DArray"]/*'/>
        [FieldOffset(0)]
        public D3D11_TEX2D_ARRAY_UAV1 Texture2DArray;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Texture3D"]/*'/>
        [FieldOffset(0)]
        public D3D11_TEX3D_UAV Texture3D;
    }
}