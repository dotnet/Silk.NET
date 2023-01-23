// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TRACE_STATS")]
    public unsafe partial struct TraceStats
    {
        public TraceStats
        (
            ShaderTraceDesc? traceDesc = null,
            byte? numInvocationsInStamp = null,
            byte? targetStampIndex = null,
            uint? numTraceSteps = null,
            ushort? numTemps = null,
            ushort? maxIndexableTempIndex = null,
            ushort? immediateConstantBufferSize = null,
            Silk.NET.Core.Bool32? pSOutputsDepth = null,
            Silk.NET.Core.Bool32? pSOutputsMask = null,
            TraceGSInputPrimitive? gSInputPrimitive = null,
            Silk.NET.Core.Bool32? gSInputsPrimitiveID = null
        ) : this()
        {
            if (traceDesc is not null)
            {
                TraceDesc = traceDesc.Value;
            }

            if (numInvocationsInStamp is not null)
            {
                NumInvocationsInStamp = numInvocationsInStamp.Value;
            }

            if (targetStampIndex is not null)
            {
                TargetStampIndex = targetStampIndex.Value;
            }

            if (numTraceSteps is not null)
            {
                NumTraceSteps = numTraceSteps.Value;
            }

            if (numTemps is not null)
            {
                NumTemps = numTemps.Value;
            }

            if (maxIndexableTempIndex is not null)
            {
                MaxIndexableTempIndex = maxIndexableTempIndex.Value;
            }

            if (immediateConstantBufferSize is not null)
            {
                ImmediateConstantBufferSize = immediateConstantBufferSize.Value;
            }

            if (pSOutputsDepth is not null)
            {
                PSOutputsDepth = pSOutputsDepth.Value;
            }

            if (pSOutputsMask is not null)
            {
                PSOutputsMask = pSOutputsMask.Value;
            }

            if (gSInputPrimitive is not null)
            {
                GSInputPrimitive = gSInputPrimitive.Value;
            }

            if (gSInputsPrimitiveID is not null)
            {
                GSInputsPrimitiveID = gSInputsPrimitiveID.Value;
            }
        }


        [NativeName("Type", "D3D11_SHADER_TRACE_DESC")]
        [NativeName("Type.Name", "D3D11_SHADER_TRACE_DESC")]
        [NativeName("Name", "TraceDesc")]
        public ShaderTraceDesc TraceDesc;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "NumInvocationsInStamp")]
        public byte NumInvocationsInStamp;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "TargetStampIndex")]
        public byte TargetStampIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumTraceSteps")]
        public uint NumTraceSteps;
        [NativeName("Type", "D3D11_TRACE_COMPONENT_MASK[32]")]
        [NativeName("Type.Name", "D3D11_TRACE_COMPONENT_MASK[32]")]
        [NativeName("Name", "InputMask")]
        public fixed byte InputMask[32];
        [NativeName("Type", "D3D11_TRACE_COMPONENT_MASK[32]")]
        [NativeName("Type.Name", "D3D11_TRACE_COMPONENT_MASK[32]")]
        [NativeName("Name", "OutputMask")]
        public fixed byte OutputMask[32];

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "NumTemps")]
        public ushort NumTemps;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "MaxIndexableTempIndex")]
        public ushort MaxIndexableTempIndex;
        [NativeName("Type", "UINT16[4096]")]
        [NativeName("Type.Name", "UINT16[4096]")]
        [NativeName("Name", "IndexableTempSize")]
        public fixed ushort IndexableTempSize[4096];

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "ImmediateConstantBufferSize")]
        public ushort ImmediateConstantBufferSize;
        [NativeName("Type", "UINT[4][2]")]
        [NativeName("Type.Name", "UINT[4][2]")]
        [NativeName("Name", "PixelPosition")]
        public fixed uint PixelPosition[8];
        [NativeName("Type", "UINT64[4]")]
        [NativeName("Type.Name", "UINT64[4]")]
        [NativeName("Name", "PixelCoverageMask")]
        public fixed ulong PixelCoverageMask[4];
        [NativeName("Type", "UINT64[4]")]
        [NativeName("Type.Name", "UINT64[4]")]
        [NativeName("Name", "PixelDiscardedMask")]
        public fixed ulong PixelDiscardedMask[4];
        [NativeName("Type", "UINT64[4]")]
        [NativeName("Type.Name", "UINT64[4]")]
        [NativeName("Name", "PixelCoverageMaskAfterShader")]
        public fixed ulong PixelCoverageMaskAfterShader[4];
        [NativeName("Type", "UINT64[4]")]
        [NativeName("Type.Name", "UINT64[4]")]
        [NativeName("Name", "PixelCoverageMaskAfterA2CSampleMask")]
        public fixed ulong PixelCoverageMaskAfterA2CSampleMask[4];
        [NativeName("Type", "UINT64[4]")]
        [NativeName("Type.Name", "UINT64[4]")]
        [NativeName("Name", "PixelCoverageMaskAfterA2CSampleMaskDepth")]
        public fixed ulong PixelCoverageMaskAfterA2CSampleMaskDepth[4];
        [NativeName("Type", "UINT64[4]")]
        [NativeName("Type.Name", "UINT64[4]")]
        [NativeName("Name", "PixelCoverageMaskAfterA2CSampleMaskDepthStencil")]
        public fixed ulong PixelCoverageMaskAfterA2CSampleMaskDepthStencil[4];

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PSOutputsDepth")]
        public Silk.NET.Core.Bool32 PSOutputsDepth;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PSOutputsMask")]
        public Silk.NET.Core.Bool32 PSOutputsMask;

        [NativeName("Type", "D3D11_TRACE_GS_INPUT_PRIMITIVE")]
        [NativeName("Type.Name", "D3D11_TRACE_GS_INPUT_PRIMITIVE")]
        [NativeName("Name", "GSInputPrimitive")]
        public TraceGSInputPrimitive GSInputPrimitive;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "GSInputsPrimitiveID")]
        public Silk.NET.Core.Bool32 GSInputsPrimitiveID;
        [NativeName("Type", "D3D11_TRACE_COMPONENT_MASK[32]")]
        [NativeName("Type.Name", "D3D11_TRACE_COMPONENT_MASK[32]")]
        [NativeName("Name", "HSOutputPatchConstantMask")]
        public fixed byte HSOutputPatchConstantMask[32];
        [NativeName("Type", "D3D11_TRACE_COMPONENT_MASK[32]")]
        [NativeName("Type.Name", "D3D11_TRACE_COMPONENT_MASK[32]")]
        [NativeName("Name", "DSInputPatchConstantMask")]
        public fixed byte DSInputPatchConstantMask[32];
    }
}
