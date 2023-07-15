// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_RT_FORMAT_ARRAY.xml' path='doc/member[@name="D3D12_RT_FORMAT_ARRAY"]/*'/>
public partial struct D3D12_RT_FORMAT_ARRAY
{
    /// <include file='D3D12_RT_FORMAT_ARRAY.xml' path='doc/member[@name="D3D12_RT_FORMAT_ARRAY.RTFormats"]/*'/>
    [NativeTypeName("DXGI_FORMAT[8]")]
    public _RTFormats_e__FixedBuffer RTFormats;
    /// <include file='D3D12_RT_FORMAT_ARRAY.xml' path='doc/member[@name="D3D12_RT_FORMAT_ARRAY.NumRenderTargets"]/*'/>
    public uint NumRenderTargets;
    /// <include file='_RTFormats_e__FixedBuffer.xml' path='doc/member[@name="_RTFormats_e__FixedBuffer"]/*'/>
    public partial struct _RTFormats_e__FixedBuffer
    {
        public DXGI_FORMAT e0;
        public DXGI_FORMAT e1;
        public DXGI_FORMAT e2;
        public DXGI_FORMAT e3;
        public DXGI_FORMAT e4;
        public DXGI_FORMAT e5;
        public DXGI_FORMAT e6;
        public DXGI_FORMAT e7;
        [UnscopedRef]
        public ref DXGI_FORMAT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<DXGI_FORMAT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
    }
}