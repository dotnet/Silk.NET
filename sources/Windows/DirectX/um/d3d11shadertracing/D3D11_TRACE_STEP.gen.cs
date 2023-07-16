// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_TRACE_STEP.xml' path='doc/member[@name="D3D11_TRACE_STEP"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_TRACE_STEP
{
    /// <include file='D3D11_TRACE_STEP.xml' path='doc/member[@name="D3D11_TRACE_STEP.ID"]/*'/>
    public uint ID;
    /// <include file='D3D11_TRACE_STEP.xml' path='doc/member[@name="D3D11_TRACE_STEP.InstructionActive"]/*'/>
    public BOOL InstructionActive;
    /// <include file='D3D11_TRACE_STEP.xml' path='doc/member[@name="D3D11_TRACE_STEP.NumRegistersWritten"]/*'/>
    [NativeTypeName("UINT8")]
    public byte NumRegistersWritten;
    /// <include file='D3D11_TRACE_STEP.xml' path='doc/member[@name="D3D11_TRACE_STEP.NumRegistersRead"]/*'/>
    [NativeTypeName("UINT8")]
    public byte NumRegistersRead;
    /// <include file='D3D11_TRACE_STEP.xml' path='doc/member[@name="D3D11_TRACE_STEP.MiscOperations"]/*'/>
    [NativeTypeName("D3D11_TRACE_MISC_OPERATIONS_MASK")]
    public ushort MiscOperations;
    /// <include file='D3D11_TRACE_STEP.xml' path='doc/member[@name="D3D11_TRACE_STEP.OpcodeType"]/*'/>
    public uint OpcodeType;
    /// <include file='D3D11_TRACE_STEP.xml' path='doc/member[@name="D3D11_TRACE_STEP.CurrentGlobalCycle"]/*'/>
    [NativeTypeName("UINT64")]
    public ulong CurrentGlobalCycle;
}