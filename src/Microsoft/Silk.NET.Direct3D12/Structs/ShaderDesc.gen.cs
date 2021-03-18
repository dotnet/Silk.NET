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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "_D3D12_SHADER_DESC")]
    public unsafe partial struct ShaderDesc
    {
        public ShaderDesc
        (
            uint? version = null,
            byte* creator = null,
            uint? flags = null,
            uint? constantBuffers = null,
            uint? boundResources = null,
            uint? inputParameters = null,
            uint? outputParameters = null,
            uint? instructionCount = null,
            uint? tempRegisterCount = null,
            uint? tempArrayCount = null,
            uint? defCount = null,
            uint? dclCount = null,
            uint? textureNormalInstructions = null,
            uint? textureLoadInstructions = null,
            uint? textureCompInstructions = null,
            uint? textureBiasInstructions = null,
            uint? textureGradientInstructions = null,
            uint? floatInstructionCount = null,
            uint? intInstructionCount = null,
            uint? uintInstructionCount = null,
            uint? staticFlowControlCount = null,
            uint? dynamicFlowControlCount = null,
            uint? macroInstructionCount = null,
            uint? arrayInstructionCount = null,
            uint? cutInstructionCount = null,
            uint? emitInstructionCount = null,
            Silk.NET.Core.Native.D3DPrimitiveTopology? gSOutputTopology = null,
            uint? gSMaxOutputVertexCount = null,
            Silk.NET.Core.Native.D3DPrimitive? inputPrimitive = null,
            uint? patchConstantParameters = null,
            uint? cGSInstanceCount = null,
            uint? cControlPoints = null,
            Silk.NET.Core.Native.D3DTessellatorOutputPrimitive? hSOutputPrimitive = null,
            Silk.NET.Core.Native.D3DTessellatorPartitioning? hSPartitioning = null,
            Silk.NET.Core.Native.D3DTessellatorDomain? tessellatorDomain = null,
            uint? cBarrierInstructions = null,
            uint? cInterlockedInstructions = null,
            uint? cTextureStoreInstructions = null
        ) : this()
        {
            if (version is not null)
            {
                Version = version.Value;
            }

            if (creator is not null)
            {
                Creator = creator;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (constantBuffers is not null)
            {
                ConstantBuffers = constantBuffers.Value;
            }

            if (boundResources is not null)
            {
                BoundResources = boundResources.Value;
            }

            if (inputParameters is not null)
            {
                InputParameters = inputParameters.Value;
            }

            if (outputParameters is not null)
            {
                OutputParameters = outputParameters.Value;
            }

            if (instructionCount is not null)
            {
                InstructionCount = instructionCount.Value;
            }

            if (tempRegisterCount is not null)
            {
                TempRegisterCount = tempRegisterCount.Value;
            }

            if (tempArrayCount is not null)
            {
                TempArrayCount = tempArrayCount.Value;
            }

            if (defCount is not null)
            {
                DefCount = defCount.Value;
            }

            if (dclCount is not null)
            {
                DclCount = dclCount.Value;
            }

            if (textureNormalInstructions is not null)
            {
                TextureNormalInstructions = textureNormalInstructions.Value;
            }

            if (textureLoadInstructions is not null)
            {
                TextureLoadInstructions = textureLoadInstructions.Value;
            }

            if (textureCompInstructions is not null)
            {
                TextureCompInstructions = textureCompInstructions.Value;
            }

            if (textureBiasInstructions is not null)
            {
                TextureBiasInstructions = textureBiasInstructions.Value;
            }

            if (textureGradientInstructions is not null)
            {
                TextureGradientInstructions = textureGradientInstructions.Value;
            }

            if (floatInstructionCount is not null)
            {
                FloatInstructionCount = floatInstructionCount.Value;
            }

            if (intInstructionCount is not null)
            {
                IntInstructionCount = intInstructionCount.Value;
            }

            if (uintInstructionCount is not null)
            {
                UintInstructionCount = uintInstructionCount.Value;
            }

            if (staticFlowControlCount is not null)
            {
                StaticFlowControlCount = staticFlowControlCount.Value;
            }

            if (dynamicFlowControlCount is not null)
            {
                DynamicFlowControlCount = dynamicFlowControlCount.Value;
            }

            if (macroInstructionCount is not null)
            {
                MacroInstructionCount = macroInstructionCount.Value;
            }

            if (arrayInstructionCount is not null)
            {
                ArrayInstructionCount = arrayInstructionCount.Value;
            }

            if (cutInstructionCount is not null)
            {
                CutInstructionCount = cutInstructionCount.Value;
            }

            if (emitInstructionCount is not null)
            {
                EmitInstructionCount = emitInstructionCount.Value;
            }

            if (gSOutputTopology is not null)
            {
                GSOutputTopology = gSOutputTopology.Value;
            }

            if (gSMaxOutputVertexCount is not null)
            {
                GSMaxOutputVertexCount = gSMaxOutputVertexCount.Value;
            }

            if (inputPrimitive is not null)
            {
                InputPrimitive = inputPrimitive.Value;
            }

            if (patchConstantParameters is not null)
            {
                PatchConstantParameters = patchConstantParameters.Value;
            }

            if (cGSInstanceCount is not null)
            {
                CGSInstanceCount = cGSInstanceCount.Value;
            }

            if (cControlPoints is not null)
            {
                CControlPoints = cControlPoints.Value;
            }

            if (hSOutputPrimitive is not null)
            {
                HSOutputPrimitive = hSOutputPrimitive.Value;
            }

            if (hSPartitioning is not null)
            {
                HSPartitioning = hSPartitioning.Value;
            }

            if (tessellatorDomain is not null)
            {
                TessellatorDomain = tessellatorDomain.Value;
            }

            if (cBarrierInstructions is not null)
            {
                CBarrierInstructions = cBarrierInstructions.Value;
            }

            if (cInterlockedInstructions is not null)
            {
                CInterlockedInstructions = cInterlockedInstructions.Value;
            }

            if (cTextureStoreInstructions is not null)
            {
                CTextureStoreInstructions = cTextureStoreInstructions.Value;
            }
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
