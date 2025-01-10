// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_TRACE_STATS
{
    public D3D11_SHADER_TRACE_DESC TraceDesc;

    [NativeTypeName("UINT8")]
    public byte NumInvocationsInStamp;

    [NativeTypeName("UINT8")]
    public byte TargetStampIndex;
    public uint NumTraceSteps;

    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK[32]")]
    public _InputMask_e__FixedBuffer InputMask;

    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK[32]")]
    public _OutputMask_e__FixedBuffer OutputMask;

    [NativeTypeName("UINT16")]
    public ushort NumTemps;

    [NativeTypeName("UINT16")]
    public ushort MaxIndexableTempIndex;

    [NativeTypeName("UINT16[4096]")]
    public _IndexableTempSize_e__FixedBuffer IndexableTempSize;

    [NativeTypeName("UINT16")]
    public ushort ImmediateConstantBufferSize;

    [NativeTypeName("UINT[4][2]")]
    public _PixelPosition_e__FixedBuffer PixelPosition;

    [NativeTypeName("UINT64[4]")]
    public _PixelCoverageMask_e__FixedBuffer PixelCoverageMask;

    [NativeTypeName("UINT64[4]")]
    public _PixelDiscardedMask_e__FixedBuffer PixelDiscardedMask;

    [NativeTypeName("UINT64[4]")]
    public _PixelCoverageMaskAfterShader_e__FixedBuffer PixelCoverageMaskAfterShader;

    [NativeTypeName("UINT64[4]")]
    public _PixelCoverageMaskAfterA2CSampleMask_e__FixedBuffer PixelCoverageMaskAfterA2CSampleMask;

    [NativeTypeName("UINT64[4]")]
    public _PixelCoverageMaskAfterA2CSampleMaskDepth_e__FixedBuffer PixelCoverageMaskAfterA2CSampleMaskDepth;

    [NativeTypeName("UINT64[4]")]
    public _PixelCoverageMaskAfterA2CSampleMaskDepthStencil_e__FixedBuffer PixelCoverageMaskAfterA2CSampleMaskDepthStencil;
    public BOOL PSOutputsDepth;
    public BOOL PSOutputsMask;
    public D3D11_TRACE_GS_INPUT_PRIMITIVE GSInputPrimitive;
    public BOOL GSInputsPrimitiveID;

    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK[32]")]
    public _HSOutputPatchConstantMask_e__FixedBuffer HSOutputPatchConstantMask;

    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK[32]")]
    public _DSInputPatchConstantMask_e__FixedBuffer DSInputPatchConstantMask;

    [InlineArray(32)]
    public partial struct _InputMask_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(32)]
    public partial struct _OutputMask_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(4096)]
    public partial struct _IndexableTempSize_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(4 * 2)]
    public partial struct _PixelPosition_e__FixedBuffer
    {
        public uint e0_0;
    }

    [InlineArray(4)]
    public partial struct _PixelCoverageMask_e__FixedBuffer
    {
        public ulong e0;
    }

    [InlineArray(4)]
    public partial struct _PixelDiscardedMask_e__FixedBuffer
    {
        public ulong e0;
    }

    [InlineArray(4)]
    public partial struct _PixelCoverageMaskAfterShader_e__FixedBuffer
    {
        public ulong e0;
    }

    [InlineArray(4)]
    public partial struct _PixelCoverageMaskAfterA2CSampleMask_e__FixedBuffer
    {
        public ulong e0;
    }

    [InlineArray(4)]
    public partial struct _PixelCoverageMaskAfterA2CSampleMaskDepth_e__FixedBuffer
    {
        public ulong e0;
    }

    [InlineArray(4)]
    public partial struct _PixelCoverageMaskAfterA2CSampleMaskDepthStencil_e__FixedBuffer
    {
        public ulong e0;
    }

    [InlineArray(32)]
    public partial struct _HSOutputPatchConstantMask_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(32)]
    public partial struct _DSInputPatchConstantMask_e__FixedBuffer
    {
        public byte e0;
    }
}
