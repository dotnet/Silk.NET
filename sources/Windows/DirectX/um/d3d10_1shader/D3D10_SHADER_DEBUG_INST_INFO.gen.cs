// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='D3D10_SHADER_DEBUG_INST_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INST_INFO"]/*'/>
public partial struct D3D10_SHADER_DEBUG_INST_INFO
{
    /// <include file='D3D10_SHADER_DEBUG_INST_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INST_INFO.Id"]/*'/>
    public uint Id;
    /// <include file='D3D10_SHADER_DEBUG_INST_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INST_INFO.Opcode"]/*'/>
    public uint Opcode;
    /// <include file='D3D10_SHADER_DEBUG_INST_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INST_INFO.uOutputs"]/*'/>
    public uint uOutputs;
    /// <include file='D3D10_SHADER_DEBUG_INST_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INST_INFO.pOutputs"]/*'/>
    [NativeTypeName("D3D10_SHADER_DEBUG_OUTPUTREG_INFO[2]")]
    public _pOutputs_e__FixedBuffer pOutputs;
    /// <include file='D3D10_SHADER_DEBUG_INST_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INST_INFO.TokenId"]/*'/>
    public uint TokenId;
    /// <include file='D3D10_SHADER_DEBUG_INST_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INST_INFO.NestingLevel"]/*'/>
    public uint NestingLevel;
    /// <include file='D3D10_SHADER_DEBUG_INST_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INST_INFO.Scopes"]/*'/>
    public uint Scopes;
    /// <include file='D3D10_SHADER_DEBUG_INST_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INST_INFO.ScopeInfo"]/*'/>
    public uint ScopeInfo;
    /// <include file='D3D10_SHADER_DEBUG_INST_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INST_INFO.AccessedVars"]/*'/>
    public uint AccessedVars;
    /// <include file='D3D10_SHADER_DEBUG_INST_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INST_INFO.AccessedVarsInfo"]/*'/>
    public uint AccessedVarsInfo;
    /// <include file='_pOutputs_e__FixedBuffer.xml' path='doc/member[@name="_pOutputs_e__FixedBuffer"]/*'/>
    public partial struct _pOutputs_e__FixedBuffer
    {
        public D3D10_SHADER_DEBUG_OUTPUTREG_INFO e0;
        public D3D10_SHADER_DEBUG_OUTPUTREG_INFO e1;
        [UnscopedRef]
        public ref D3D10_SHADER_DEBUG_OUTPUTREG_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<D3D10_SHADER_DEBUG_OUTPUTREG_INFO> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }
}