// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_BLEND_DESC.xml' path='doc/member[@name="D3D12_BLEND_DESC"]/*'/>
public partial struct D3D12_BLEND_DESC
{
    /// <include file='D3D12_BLEND_DESC.xml' path='doc/member[@name="D3D12_BLEND_DESC.AlphaToCoverageEnable"]/*'/>
    public BOOL AlphaToCoverageEnable;
    /// <include file='D3D12_BLEND_DESC.xml' path='doc/member[@name="D3D12_BLEND_DESC.IndependentBlendEnable"]/*'/>
    public BOOL IndependentBlendEnable;
    /// <include file='D3D12_BLEND_DESC.xml' path='doc/member[@name="D3D12_BLEND_DESC.RenderTarget"]/*'/>
    [NativeTypeName("D3D12_RENDER_TARGET_BLEND_DESC[8]")]
    public _RenderTarget_e__FixedBuffer RenderTarget;
    /// <include file='_RenderTarget_e__FixedBuffer.xml' path='doc/member[@name="_RenderTarget_e__FixedBuffer"]/*'/>
    public partial struct _RenderTarget_e__FixedBuffer
    {
        public D3D12_RENDER_TARGET_BLEND_DESC e0;
        public D3D12_RENDER_TARGET_BLEND_DESC e1;
        public D3D12_RENDER_TARGET_BLEND_DESC e2;
        public D3D12_RENDER_TARGET_BLEND_DESC e3;
        public D3D12_RENDER_TARGET_BLEND_DESC e4;
        public D3D12_RENDER_TARGET_BLEND_DESC e5;
        public D3D12_RENDER_TARGET_BLEND_DESC e6;
        public D3D12_RENDER_TARGET_BLEND_DESC e7;
        [UnscopedRef]
        public ref D3D12_RENDER_TARGET_BLEND_DESC this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<D3D12_RENDER_TARGET_BLEND_DESC> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
    }
}