// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct D3D11_TRACE_STATS
{
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.TraceDesc"]/*'/>
    public D3D11_SHADER_TRACE_DESC TraceDesc;
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.NumInvocationsInStamp"]/*'/>
    [NativeTypeName("UINT8")]
    public byte NumInvocationsInStamp;
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.TargetStampIndex"]/*'/>
    [NativeTypeName("UINT8")]
    public byte TargetStampIndex;
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.NumTraceSteps"]/*'/>
    public uint NumTraceSteps;
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.InputMask"]/*'/>
    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK[32]")]
    public fixed byte InputMask[32];
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.OutputMask"]/*'/>
    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK[32]")]
    public fixed byte OutputMask[32];
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.NumTemps"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort NumTemps;
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.MaxIndexableTempIndex"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort MaxIndexableTempIndex;
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.IndexableTempSize"]/*'/>
    [NativeTypeName("UINT16[4096]")]
    public fixed ushort IndexableTempSize[4096];
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.ImmediateConstantBufferSize"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort ImmediateConstantBufferSize;
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelPosition"]/*'/>
    [NativeTypeName("UINT[4][2]")]
    public fixed uint PixelPosition[4 * 2];
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelCoverageMask"]/*'/>
    [NativeTypeName("UINT64[4]")]
    public fixed ulong PixelCoverageMask[4];
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelDiscardedMask"]/*'/>
    [NativeTypeName("UINT64[4]")]
    public fixed ulong PixelDiscardedMask[4];
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelCoverageMaskAfterShader"]/*'/>
    [NativeTypeName("UINT64[4]")]
    public fixed ulong PixelCoverageMaskAfterShader[4];
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelCoverageMaskAfterA2CSampleMask"]/*'/>
    [NativeTypeName("UINT64[4]")]
    public fixed ulong PixelCoverageMaskAfterA2CSampleMask[4];
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelCoverageMaskAfterA2CSampleMaskDepth"]/*'/>
    [NativeTypeName("UINT64[4]")]
    public fixed ulong PixelCoverageMaskAfterA2CSampleMaskDepth[4];
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PixelCoverageMaskAfterA2CSampleMaskDepthStencil"]/*'/>
    [NativeTypeName("UINT64[4]")]
    public fixed ulong PixelCoverageMaskAfterA2CSampleMaskDepthStencil[4];
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PSOutputsDepth"]/*'/>
    public BOOL PSOutputsDepth;
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.PSOutputsMask"]/*'/>
    public BOOL PSOutputsMask;
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.GSInputPrimitive"]/*'/>
    public D3D11_TRACE_GS_INPUT_PRIMITIVE GSInputPrimitive;
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.GSInputsPrimitiveID"]/*'/>
    public BOOL GSInputsPrimitiveID;
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.HSOutputPatchConstantMask"]/*'/>
    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK[32]")]
    public fixed byte HSOutputPatchConstantMask[32];
    /// <include file='D3D11_TRACE_STATS.xml' path='doc/member[@name="D3D11_TRACE_STATS.DSInputPatchConstantMask"]/*'/>
    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK[32]")]
    public fixed byte DSInputPatchConstantMask[32];
}