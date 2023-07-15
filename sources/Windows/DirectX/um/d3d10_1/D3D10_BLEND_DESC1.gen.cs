// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_BLEND_DESC1.xml' path='doc/member[@name="D3D10_BLEND_DESC1"]/*'/>
public partial struct D3D10_BLEND_DESC1
{
    /// <include file='D3D10_BLEND_DESC1.xml' path='doc/member[@name="D3D10_BLEND_DESC1.AlphaToCoverageEnable"]/*'/>
    public BOOL AlphaToCoverageEnable;
    /// <include file='D3D10_BLEND_DESC1.xml' path='doc/member[@name="D3D10_BLEND_DESC1.IndependentBlendEnable"]/*'/>
    public BOOL IndependentBlendEnable;
    /// <include file='D3D10_BLEND_DESC1.xml' path='doc/member[@name="D3D10_BLEND_DESC1.RenderTarget"]/*'/>
    [NativeTypeName("D3D10_RENDER_TARGET_BLEND_DESC1[8]")]
    public _RenderTarget_e__FixedBuffer RenderTarget;
    /// <include file='_RenderTarget_e__FixedBuffer.xml' path='doc/member[@name="_RenderTarget_e__FixedBuffer"]/*'/>
    public partial struct _RenderTarget_e__FixedBuffer
    {
        public D3D10_RENDER_TARGET_BLEND_DESC1 e0;
        public D3D10_RENDER_TARGET_BLEND_DESC1 e1;
        public D3D10_RENDER_TARGET_BLEND_DESC1 e2;
        public D3D10_RENDER_TARGET_BLEND_DESC1 e3;
        public D3D10_RENDER_TARGET_BLEND_DESC1 e4;
        public D3D10_RENDER_TARGET_BLEND_DESC1 e5;
        public D3D10_RENDER_TARGET_BLEND_DESC1 e6;
        public D3D10_RENDER_TARGET_BLEND_DESC1 e7;
        [UnscopedRef]
        public ref D3D10_RENDER_TARGET_BLEND_DESC1 this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<D3D10_RENDER_TARGET_BLEND_DESC1> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
    }
}