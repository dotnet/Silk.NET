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
    [NativeName("Name", "_D3D11_SHADER_DESC")]
    public unsafe partial struct ShaderDesc
    {
        public ShaderDesc
        (
            uint version = default,
            byte* creator = default,
            uint flags = default,
            uint constantBuffers = default,
            uint boundResources = default,
            uint inputParameters = default,
            uint outputParameters = default,
            uint instructionCount = default,
            uint tempRegisterCount = default,
            uint tempArrayCount = default,
            uint defCount = default,
            uint dclCount = default,
            uint textureNormalInstructions = default,
            uint textureLoadInstructions = default,
            uint textureCompInstructions = default,
            uint textureBiasInstructions = default,
            uint textureGradientInstructions = default,
            uint floatInstructionCount = default,
            uint intInstructionCount = default,
            uint uintInstructionCount = default,
            uint staticFlowControlCount = default,
            uint dynamicFlowControlCount = default,
            uint macroInstructionCount = default,
            uint arrayInstructionCount = default,
            uint cutInstructionCount = default,
            uint emitInstructionCount = default,
            Silk.NET.Core.Native.D3DPrimitiveTopology gSOutputTopology = default,
            uint gSMaxOutputVertexCount = default,
            Silk.NET.Core.Native.D3DPrimitive inputPrimitive = default,
            uint patchConstantParameters = default,
            uint cGSInstanceCount = default,
            uint cControlPoints = default,
            Silk.NET.Core.Native.D3DTessellatorOutputPrimitive hSOutputPrimitive = default,
            Silk.NET.Core.Native.D3DTessellatorPartitioning hSPartitioning = default,
            Silk.NET.Core.Native.D3DTessellatorDomain tessellatorDomain = default,
            uint cBarrierInstructions = default,
            uint cInterlockedInstructions = default,
            uint cTextureStoreInstructions = default
        )
        {
            Version = version;
            Creator = creator;
            Flags = flags;
            ConstantBuffers = constantBuffers;
            BoundResources = boundResources;
            InputParameters = inputParameters;
            OutputParameters = outputParameters;
            InstructionCount = instructionCount;
            TempRegisterCount = tempRegisterCount;
            TempArrayCount = tempArrayCount;
            DefCount = defCount;
            DclCount = dclCount;
            TextureNormalInstructions = textureNormalInstructions;
            TextureLoadInstructions = textureLoadInstructions;
            TextureCompInstructions = textureCompInstructions;
            TextureBiasInstructions = textureBiasInstructions;
            TextureGradientInstructions = textureGradientInstructions;
            FloatInstructionCount = floatInstructionCount;
            IntInstructionCount = intInstructionCount;
            UintInstructionCount = uintInstructionCount;
            StaticFlowControlCount = staticFlowControlCount;
            DynamicFlowControlCount = dynamicFlowControlCount;
            MacroInstructionCount = macroInstructionCount;
            ArrayInstructionCount = arrayInstructionCount;
            CutInstructionCount = cutInstructionCount;
            EmitInstructionCount = emitInstructionCount;
            GSOutputTopology = gSOutputTopology;
            GSMaxOutputVertexCount = gSMaxOutputVertexCount;
            InputPrimitive = inputPrimitive;
            PatchConstantParameters = patchConstantParameters;
            CGSInstanceCount = cGSInstanceCount;
            CControlPoints = cControlPoints;
            HSOutputPrimitive = hSOutputPrimitive;
            HSPartitioning = hSPartitioning;
            TessellatorDomain = tessellatorDomain;
            CBarrierInstructions = cBarrierInstructions;
            CInterlockedInstructions = cInterlockedInstructions;
            CTextureStoreInstructions = cTextureStoreInstructions;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Version")]
        public uint Version;

        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "Creator")]
        public byte* Creator;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Flags")]
        public uint Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConstantBuffers")]
        public uint ConstantBuffers;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BoundResources")]
        public uint BoundResources;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputParameters")]
        public uint InputParameters;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputParameters")]
        public uint OutputParameters;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InstructionCount")]
        public uint InstructionCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TempRegisterCount")]
        public uint TempRegisterCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TempArrayCount")]
        public uint TempArrayCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DefCount")]
        public uint DefCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DclCount")]
        public uint DclCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TextureNormalInstructions")]
        public uint TextureNormalInstructions;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TextureLoadInstructions")]
        public uint TextureLoadInstructions;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TextureCompInstructions")]
        public uint TextureCompInstructions;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TextureBiasInstructions")]
        public uint TextureBiasInstructions;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TextureGradientInstructions")]
        public uint TextureGradientInstructions;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FloatInstructionCount")]
        public uint FloatInstructionCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "IntInstructionCount")]
        public uint IntInstructionCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "UintInstructionCount")]
        public uint UintInstructionCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StaticFlowControlCount")]
        public uint StaticFlowControlCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DynamicFlowControlCount")]
        public uint DynamicFlowControlCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MacroInstructionCount")]
        public uint MacroInstructionCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ArrayInstructionCount")]
        public uint ArrayInstructionCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CutInstructionCount")]
        public uint CutInstructionCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "EmitInstructionCount")]
        public uint EmitInstructionCount;

        [NativeName("Type", "D3D_PRIMITIVE_TOPOLOGY")]
        [NativeName("Type.Name", "D3D_PRIMITIVE_TOPOLOGY")]
        [NativeName("Name", "GSOutputTopology")]
        public Silk.NET.Core.Native.D3DPrimitiveTopology GSOutputTopology;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "GSMaxOutputVertexCount")]
        public uint GSMaxOutputVertexCount;

        [NativeName("Type", "D3D_PRIMITIVE")]
        [NativeName("Type.Name", "D3D_PRIMITIVE")]
        [NativeName("Name", "InputPrimitive")]
        public Silk.NET.Core.Native.D3DPrimitive InputPrimitive;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PatchConstantParameters")]
        public uint PatchConstantParameters;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cGSInstanceCount")]
        public uint CGSInstanceCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cControlPoints")]
        public uint CControlPoints;

        [NativeName("Type", "D3D_TESSELLATOR_OUTPUT_PRIMITIVE")]
        [NativeName("Type.Name", "D3D_TESSELLATOR_OUTPUT_PRIMITIVE")]
        [NativeName("Name", "HSOutputPrimitive")]
        public Silk.NET.Core.Native.D3DTessellatorOutputPrimitive HSOutputPrimitive;

        [NativeName("Type", "D3D_TESSELLATOR_PARTITIONING")]
        [NativeName("Type.Name", "D3D_TESSELLATOR_PARTITIONING")]
        [NativeName("Name", "HSPartitioning")]
        public Silk.NET.Core.Native.D3DTessellatorPartitioning HSPartitioning;

        [NativeName("Type", "D3D_TESSELLATOR_DOMAIN")]
        [NativeName("Type.Name", "D3D_TESSELLATOR_DOMAIN")]
        [NativeName("Name", "TessellatorDomain")]
        public Silk.NET.Core.Native.D3DTessellatorDomain TessellatorDomain;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cBarrierInstructions")]
        public uint CBarrierInstructions;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cInterlockedInstructions")]
        public uint CInterlockedInstructions;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cTextureStoreInstructions")]
        public uint CTextureStoreInstructions;
    }
}
