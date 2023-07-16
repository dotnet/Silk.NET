// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO"]/*'/>
public unsafe partial struct D3D10_SHADER_DEBUG_OUTPUTREG_INFO
{
    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.OutputRegisterSet"]/*'/>
    public D3D10_SHADER_DEBUG_REGTYPE OutputRegisterSet;
    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.OutputReg"]/*'/>
    public uint OutputReg;
    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.TempArrayReg"]/*'/>
    public uint TempArrayReg;
    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.OutputComponents"]/*'/>
    [NativeTypeName("UINT[4]")]
    public fixed uint OutputComponents[4];
    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.OutputVars"]/*'/>
    [NativeTypeName("D3D10_SHADER_DEBUG_OUTPUTVAR[4]")]
    public _OutputVars_e__FixedBuffer OutputVars;
    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.IndexReg"]/*'/>
    public uint IndexReg;
    /// <include file='D3D10_SHADER_DEBUG_OUTPUTREG_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_OUTPUTREG_INFO.IndexComp"]/*'/>
    public uint IndexComp;
    /// <include file='_OutputVars_e__FixedBuffer.xml' path='doc/member[@name="_OutputVars_e__FixedBuffer"]/*'/>
    public partial struct _OutputVars_e__FixedBuffer
    {
        public D3D10_SHADER_DEBUG_OUTPUTVAR e0;
        public D3D10_SHADER_DEBUG_OUTPUTVAR e1;
        public D3D10_SHADER_DEBUG_OUTPUTVAR e2;
        public D3D10_SHADER_DEBUG_OUTPUTVAR e3;
        [UnscopedRef]
        public ref D3D10_SHADER_DEBUG_OUTPUTVAR this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<D3D10_SHADER_DEBUG_OUTPUTVAR> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 4);
    }
}