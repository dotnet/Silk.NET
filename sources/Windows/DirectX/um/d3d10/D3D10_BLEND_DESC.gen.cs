// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_BLEND_DESC.xml' path='doc/member[@name="D3D10_BLEND_DESC"]/*'/>
public unsafe partial struct D3D10_BLEND_DESC
{
    /// <include file='D3D10_BLEND_DESC.xml' path='doc/member[@name="D3D10_BLEND_DESC.AlphaToCoverageEnable"]/*'/>
    public BOOL AlphaToCoverageEnable;
    /// <include file='D3D10_BLEND_DESC.xml' path='doc/member[@name="D3D10_BLEND_DESC.BlendEnable"]/*'/>
    [NativeTypeName("BOOL[8]")]
    public _BlendEnable_e__FixedBuffer BlendEnable;
    /// <include file='D3D10_BLEND_DESC.xml' path='doc/member[@name="D3D10_BLEND_DESC.SrcBlend"]/*'/>
    public D3D10_BLEND SrcBlend;
    /// <include file='D3D10_BLEND_DESC.xml' path='doc/member[@name="D3D10_BLEND_DESC.DestBlend"]/*'/>
    public D3D10_BLEND DestBlend;
    /// <include file='D3D10_BLEND_DESC.xml' path='doc/member[@name="D3D10_BLEND_DESC.BlendOp"]/*'/>
    public D3D10_BLEND_OP BlendOp;
    /// <include file='D3D10_BLEND_DESC.xml' path='doc/member[@name="D3D10_BLEND_DESC.SrcBlendAlpha"]/*'/>
    public D3D10_BLEND SrcBlendAlpha;
    /// <include file='D3D10_BLEND_DESC.xml' path='doc/member[@name="D3D10_BLEND_DESC.DestBlendAlpha"]/*'/>
    public D3D10_BLEND DestBlendAlpha;
    /// <include file='D3D10_BLEND_DESC.xml' path='doc/member[@name="D3D10_BLEND_DESC.BlendOpAlpha"]/*'/>
    public D3D10_BLEND_OP BlendOpAlpha;
    /// <include file='D3D10_BLEND_DESC.xml' path='doc/member[@name="D3D10_BLEND_DESC.RenderTargetWriteMask"]/*'/>
    [NativeTypeName("UINT8[8]")]
    public fixed byte RenderTargetWriteMask[8];
    /// <include file='_BlendEnable_e__FixedBuffer.xml' path='doc/member[@name="_BlendEnable_e__FixedBuffer"]/*'/>
    public partial struct _BlendEnable_e__FixedBuffer
    {
        public BOOL e0;
        public BOOL e1;
        public BOOL e2;
        public BOOL e3;
        public BOOL e4;
        public BOOL e5;
        public BOOL e6;
        public BOOL e7;
        [UnscopedRef]
        public ref BOOL this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<BOOL> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
    }
}