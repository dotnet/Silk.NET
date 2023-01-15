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
    [NativeName("Name", "_D3D12_FUNCTION_DESC")]
    public unsafe partial struct FunctionDesc
    {
        public FunctionDesc
        (
            uint? version = null,
            byte* creator = null,
            uint? flags = null,
            uint? constantBuffers = null,
            uint? boundResources = null,
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
            uint? movInstructionCount = null,
            uint? movcInstructionCount = null,
            uint? conversionInstructionCount = null,
            uint? bitwiseInstructionCount = null,
            Silk.NET.Core.Native.D3DFeatureLevel? minFeatureLevel = null,
            ulong? requiredFeatureFlags = null,
            byte* name = null,
            int? functionParameterCount = null,
            Silk.NET.Core.Bool32? hasReturn = null,
            Silk.NET.Core.Bool32? has10Level9VertexShader = null,
            Silk.NET.Core.Bool32? has10Level9PixelShader = null
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

            if (movInstructionCount is not null)
            {
                MovInstructionCount = movInstructionCount.Value;
            }

            if (movcInstructionCount is not null)
            {
                MovcInstructionCount = movcInstructionCount.Value;
            }

            if (conversionInstructionCount is not null)
            {
                ConversionInstructionCount = conversionInstructionCount.Value;
            }

            if (bitwiseInstructionCount is not null)
            {
                BitwiseInstructionCount = bitwiseInstructionCount.Value;
            }

            if (minFeatureLevel is not null)
            {
                MinFeatureLevel = minFeatureLevel.Value;
            }

            if (requiredFeatureFlags is not null)
            {
                RequiredFeatureFlags = requiredFeatureFlags.Value;
            }

            if (name is not null)
            {
                Name = name;
            }

            if (functionParameterCount is not null)
            {
                FunctionParameterCount = functionParameterCount.Value;
            }

            if (hasReturn is not null)
            {
                HasReturn = hasReturn.Value;
            }

            if (has10Level9VertexShader is not null)
            {
                Has10Level9VertexShader = has10Level9VertexShader.Value;
            }

            if (has10Level9PixelShader is not null)
            {
                Has10Level9PixelShader = has10Level9PixelShader.Value;
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
        [NativeName("Name", "MovInstructionCount")]
        public uint MovInstructionCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MovcInstructionCount")]
        public uint MovcInstructionCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConversionInstructionCount")]
        public uint ConversionInstructionCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BitwiseInstructionCount")]
        public uint BitwiseInstructionCount;

        [NativeName("Type", "D3D_FEATURE_LEVEL")]
        [NativeName("Type.Name", "D3D_FEATURE_LEVEL")]
        [NativeName("Name", "MinFeatureLevel")]
        public Silk.NET.Core.Native.D3DFeatureLevel MinFeatureLevel;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "RequiredFeatureFlags")]
        public ulong RequiredFeatureFlags;

        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "Name")]
        public byte* Name;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "FunctionParameterCount")]
        public int FunctionParameterCount;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "HasReturn")]
        public Silk.NET.Core.Bool32 HasReturn;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Has10Level9VertexShader")]
        public Silk.NET.Core.Bool32 Has10Level9VertexShader;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Has10Level9PixelShader")]
        public Silk.NET.Core.Bool32 Has10Level9PixelShader;
    }
}
