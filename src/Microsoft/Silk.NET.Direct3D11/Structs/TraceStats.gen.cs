// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            ShaderTraceDesc traceDesc = default,
            byte numInvocationsInStamp = default,
            byte targetStampIndex = default,
            uint numTraceSteps = default,
            ushort numTemps = default,
            ushort maxIndexableTempIndex = default,
            ushort immediateConstantBufferSize = default,
            int pSOutputsDepth = default,
            int pSOutputsMask = default,
            TraceGSInputPrimitive gSInputPrimitive = default,
            int gSInputsPrimitiveID = default
        )
        {
            TraceDesc = traceDesc;
            NumInvocationsInStamp = numInvocationsInStamp;
            TargetStampIndex = targetStampIndex;
            NumTraceSteps = numTraceSteps;
            NumTemps = numTemps;
            MaxIndexableTempIndex = maxIndexableTempIndex;
            ImmediateConstantBufferSize = immediateConstantBufferSize;
            PSOutputsDepth = pSOutputsDepth;
            PSOutputsMask = pSOutputsMask;
            GSInputPrimitive = gSInputPrimitive;
            GSInputsPrimitiveID = gSInputsPrimitiveID;
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
        [NativeName("Type", "D3D11_TRACE_COMPONENT_MASK [32]")]
        [NativeName("Type.Name", "D3D11_TRACE_COMPONENT_MASK [32]")]
        [NativeName("Name", "InputMask")]
        public fixed byte InputMask[32];
        [NativeName("Type", "D3D11_TRACE_COMPONENT_MASK [32]")]
        [NativeName("Type.Name", "D3D11_TRACE_COMPONENT_MASK [32]")]
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
        [NativeName("Type", "UINT16 [4096]")]
        [NativeName("Type.Name", "UINT16 [4096]")]
        [NativeName("Name", "IndexableTempSize")]
        public fixed ushort IndexableTempSize[4096];

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "ImmediateConstantBufferSize")]
        public ushort ImmediateConstantBufferSize;
        [NativeName("Type", "UINT [4][2]")]
        [NativeName("Type.Name", "UINT [4][2]")]
        [NativeName("Name", "PixelPosition")]
        public fixed uint PixelPosition[8];
        [NativeName("Type", "UINT64 [4]")]
        [NativeName("Type.Name", "UINT64 [4]")]
        [NativeName("Name", "PixelCoverageMask")]
        public fixed ulong PixelCoverageMask[4];
        [NativeName("Type", "UINT64 [4]")]
        [NativeName("Type.Name", "UINT64 [4]")]
        [NativeName("Name", "PixelDiscardedMask")]
        public fixed ulong PixelDiscardedMask[4];
        [NativeName("Type", "UINT64 [4]")]
        [NativeName("Type.Name", "UINT64 [4]")]
        [NativeName("Name", "PixelCoverageMaskAfterShader")]
        public fixed ulong PixelCoverageMaskAfterShader[4];
        [NativeName("Type", "UINT64 [4]")]
        [NativeName("Type.Name", "UINT64 [4]")]
        [NativeName("Name", "PixelCoverageMaskAfterA2CSampleMask")]
        public fixed ulong PixelCoverageMaskAfterA2CSampleMask[4];
        [NativeName("Type", "UINT64 [4]")]
        [NativeName("Type.Name", "UINT64 [4]")]
        [NativeName("Name", "PixelCoverageMaskAfterA2CSampleMaskDepth")]
        public fixed ulong PixelCoverageMaskAfterA2CSampleMaskDepth[4];
        [NativeName("Type", "UINT64 [4]")]
        [NativeName("Type.Name", "UINT64 [4]")]
        [NativeName("Name", "PixelCoverageMaskAfterA2CSampleMaskDepthStencil")]
        public fixed ulong PixelCoverageMaskAfterA2CSampleMaskDepthStencil[4];

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PSOutputsDepth")]
        public int PSOutputsDepth;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PSOutputsMask")]
        public int PSOutputsMask;

        [NativeName("Type", "D3D11_TRACE_GS_INPUT_PRIMITIVE")]
        [NativeName("Type.Name", "D3D11_TRACE_GS_INPUT_PRIMITIVE")]
        [NativeName("Name", "GSInputPrimitive")]
        public TraceGSInputPrimitive GSInputPrimitive;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "GSInputsPrimitiveID")]
        public int GSInputsPrimitiveID;
        [NativeName("Type", "D3D11_TRACE_COMPONENT_MASK [32]")]
        [NativeName("Type.Name", "D3D11_TRACE_COMPONENT_MASK [32]")]
        [NativeName("Name", "HSOutputPatchConstantMask")]
        public fixed byte HSOutputPatchConstantMask[32];
        [NativeName("Type", "D3D11_TRACE_COMPONENT_MASK [32]")]
        [NativeName("Type.Name", "D3D11_TRACE_COMPONENT_MASK [32]")]
        [NativeName("Name", "DSInputPatchConstantMask")]
        public fixed byte DSInputPatchConstantMask[32];
    }
}
