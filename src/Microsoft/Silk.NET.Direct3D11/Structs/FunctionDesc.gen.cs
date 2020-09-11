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
    [NativeName("Name", "_D3D11_FUNCTION_DESC")]
    public unsafe partial struct FunctionDesc
    {
        public FunctionDesc
        (
            uint version = default,
            byte* creator = default,
            uint flags = default,
            uint constantBuffers = default,
            uint boundResources = default,
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
            uint movInstructionCount = default,
            uint movcInstructionCount = default,
            uint conversionInstructionCount = default,
            uint bitwiseInstructionCount = default,
            Silk.NET.Core.Native.D3DFeatureLevel minFeatureLevel = default,
            ulong requiredFeatureFlags = default,
            byte* name = default,
            int functionParameterCount = default,
            int hasReturn = default,
            int has10Level9VertexShader = default,
            int has10Level9PixelShader = default
        )
        {
            Version = version;
            Creator = creator;
            Flags = flags;
            ConstantBuffers = constantBuffers;
            BoundResources = boundResources;
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
            MovInstructionCount = movInstructionCount;
            MovcInstructionCount = movcInstructionCount;
            ConversionInstructionCount = conversionInstructionCount;
            BitwiseInstructionCount = bitwiseInstructionCount;
            MinFeatureLevel = minFeatureLevel;
            RequiredFeatureFlags = requiredFeatureFlags;
            Name = name;
            FunctionParameterCount = functionParameterCount;
            HasReturn = hasReturn;
            Has10Level9VertexShader = has10Level9VertexShader;
            Has10Level9PixelShader = has10Level9PixelShader;
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
        public int HasReturn;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Has10Level9VertexShader")]
        public int Has10Level9VertexShader;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Has10Level9PixelShader")]
        public int Has10Level9PixelShader;
    }
}
