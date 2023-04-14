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

namespace Silk.NET.SPIRVReflect
{
    [NativeName("Name", "SpvReflectShaderModule")]
    public unsafe partial struct ReflectShaderModule
    {
        public ReflectShaderModule
        (
            ReflectGenerator? generator = null,
            byte* entryPointName = null,
            uint? entryPointId = null,
            uint? entryPointCount = null,
            ReflectEntryPoint* entryPoints = null,
            Silk.NET.SPIRV.SourceLanguage? sourceLanguage = null,
            uint? sourceLanguageVersion = null,
            byte* sourceFile = null,
            byte* sourceSource = null,
            uint? capabilityCount = null,
            ReflectCapability* capabilities = null,
            Silk.NET.SPIRV.ExecutionModel? spirvExecutionModel = null,
            ReflectShaderStageFlagBits? shaderStage = null,
            uint? descriptorBindingCount = null,
            ReflectDescriptorBinding* descriptorBindings = null,
            uint? descriptorSetCount = null,
            uint? inputVariableCount = null,
            ReflectInterfaceVariable** inputVariables = null,
            uint? outputVariableCount = null,
            ReflectInterfaceVariable** outputVariables = null,
            uint? interfaceVariableCount = null,
            ReflectInterfaceVariable* interfaceVariables = null,
            uint? pushConstantBlockCount = null,
            ReflectBlockVariable* pushConstantBlocks = null,
            Internal* @internal = null
        ) : this()
        {
            if (generator is not null)
            {
                Generator = generator.Value;
            }

            if (entryPointName is not null)
            {
                EntryPointName = entryPointName;
            }

            if (entryPointId is not null)
            {
                EntryPointId = entryPointId.Value;
            }

            if (entryPointCount is not null)
            {
                EntryPointCount = entryPointCount.Value;
            }

            if (entryPoints is not null)
            {
                EntryPoints = entryPoints;
            }

            if (sourceLanguage is not null)
            {
                SourceLanguage = sourceLanguage.Value;
            }

            if (sourceLanguageVersion is not null)
            {
                SourceLanguageVersion = sourceLanguageVersion.Value;
            }

            if (sourceFile is not null)
            {
                SourceFile = sourceFile;
            }

            if (sourceSource is not null)
            {
                SourceSource = sourceSource;
            }

            if (capabilityCount is not null)
            {
                CapabilityCount = capabilityCount.Value;
            }

            if (capabilities is not null)
            {
                Capabilities = capabilities;
            }

            if (spirvExecutionModel is not null)
            {
                SpirvExecutionModel = spirvExecutionModel.Value;
            }

            if (shaderStage is not null)
            {
                ShaderStage = shaderStage.Value;
            }

            if (descriptorBindingCount is not null)
            {
                DescriptorBindingCount = descriptorBindingCount.Value;
            }

            if (descriptorBindings is not null)
            {
                DescriptorBindings = descriptorBindings;
            }

            if (descriptorSetCount is not null)
            {
                DescriptorSetCount = descriptorSetCount.Value;
            }

            if (inputVariableCount is not null)
            {
                InputVariableCount = inputVariableCount.Value;
            }

            if (inputVariables is not null)
            {
                InputVariables = inputVariables;
            }

            if (outputVariableCount is not null)
            {
                OutputVariableCount = outputVariableCount.Value;
            }

            if (outputVariables is not null)
            {
                OutputVariables = outputVariables;
            }

            if (interfaceVariableCount is not null)
            {
                InterfaceVariableCount = interfaceVariableCount.Value;
            }

            if (interfaceVariables is not null)
            {
                InterfaceVariables = interfaceVariables;
            }

            if (pushConstantBlockCount is not null)
            {
                PushConstantBlockCount = pushConstantBlockCount.Value;
            }

            if (pushConstantBlocks is not null)
            {
                PushConstantBlocks = pushConstantBlocks;
            }

            if (@internal is not null)
            {
                Internal = @internal;
            }
        }


        [NativeName("Type", "SpvReflectGenerator")]
        [NativeName("Type.Name", "SpvReflectGenerator")]
        [NativeName("Name", "generator")]
        public ReflectGenerator Generator;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "entry_point_name")]
        public byte* EntryPointName;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "entry_point_id")]
        public uint EntryPointId;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "entry_point_count")]
        public uint EntryPointCount;

        [NativeName("Type", "SpvReflectEntryPoint *")]
        [NativeName("Type.Name", "SpvReflectEntryPoint *")]
        [NativeName("Name", "entry_points")]
        public ReflectEntryPoint* EntryPoints;

        [NativeName("Type", "SpvSourceLanguage")]
        [NativeName("Type.Name", "SpvSourceLanguage")]
        [NativeName("Name", "source_language")]
        public Silk.NET.SPIRV.SourceLanguage SourceLanguage;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "source_language_version")]
        public uint SourceLanguageVersion;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "source_file")]
        public byte* SourceFile;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "source_source")]
        public byte* SourceSource;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "capability_count")]
        public uint CapabilityCount;

        [NativeName("Type", "SpvReflectCapability *")]
        [NativeName("Type.Name", "SpvReflectCapability *")]
        [NativeName("Name", "capabilities")]
        public ReflectCapability* Capabilities;

        [NativeName("Type", "SpvExecutionModel")]
        [NativeName("Type.Name", "SpvExecutionModel")]
        [NativeName("Name", "spirv_execution_model")]
        public Silk.NET.SPIRV.ExecutionModel SpirvExecutionModel;

        [NativeName("Type", "SpvReflectShaderStageFlagBits")]
        [NativeName("Type.Name", "SpvReflectShaderStageFlagBits")]
        [NativeName("Name", "shader_stage")]
        public ReflectShaderStageFlagBits ShaderStage;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptor_binding_count")]
        public uint DescriptorBindingCount;

        [NativeName("Type", "SpvReflectDescriptorBinding *")]
        [NativeName("Type.Name", "SpvReflectDescriptorBinding *")]
        [NativeName("Name", "descriptor_bindings")]
        public ReflectDescriptorBinding* DescriptorBindings;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "descriptor_set_count")]
        public uint DescriptorSetCount;
        
        [NativeName("Type", "SpvReflectDescriptorSet[64]")]
        [NativeName("Type.Name", "SpvReflectDescriptorSet[64]")]
        [NativeName("Name", "descriptor_sets")]
        public DescriptorSetsBuffer DescriptorSets;

        public struct DescriptorSetsBuffer
        {
            public ReflectDescriptorSet Element0;
            public ReflectDescriptorSet Element1;
            public ReflectDescriptorSet Element2;
            public ReflectDescriptorSet Element3;
            public ReflectDescriptorSet Element4;
            public ReflectDescriptorSet Element5;
            public ReflectDescriptorSet Element6;
            public ReflectDescriptorSet Element7;
            public ReflectDescriptorSet Element8;
            public ReflectDescriptorSet Element9;
            public ReflectDescriptorSet Element10;
            public ReflectDescriptorSet Element11;
            public ReflectDescriptorSet Element12;
            public ReflectDescriptorSet Element13;
            public ReflectDescriptorSet Element14;
            public ReflectDescriptorSet Element15;
            public ReflectDescriptorSet Element16;
            public ReflectDescriptorSet Element17;
            public ReflectDescriptorSet Element18;
            public ReflectDescriptorSet Element19;
            public ReflectDescriptorSet Element20;
            public ReflectDescriptorSet Element21;
            public ReflectDescriptorSet Element22;
            public ReflectDescriptorSet Element23;
            public ReflectDescriptorSet Element24;
            public ReflectDescriptorSet Element25;
            public ReflectDescriptorSet Element26;
            public ReflectDescriptorSet Element27;
            public ReflectDescriptorSet Element28;
            public ReflectDescriptorSet Element29;
            public ReflectDescriptorSet Element30;
            public ReflectDescriptorSet Element31;
            public ReflectDescriptorSet Element32;
            public ReflectDescriptorSet Element33;
            public ReflectDescriptorSet Element34;
            public ReflectDescriptorSet Element35;
            public ReflectDescriptorSet Element36;
            public ReflectDescriptorSet Element37;
            public ReflectDescriptorSet Element38;
            public ReflectDescriptorSet Element39;
            public ReflectDescriptorSet Element40;
            public ReflectDescriptorSet Element41;
            public ReflectDescriptorSet Element42;
            public ReflectDescriptorSet Element43;
            public ReflectDescriptorSet Element44;
            public ReflectDescriptorSet Element45;
            public ReflectDescriptorSet Element46;
            public ReflectDescriptorSet Element47;
            public ReflectDescriptorSet Element48;
            public ReflectDescriptorSet Element49;
            public ReflectDescriptorSet Element50;
            public ReflectDescriptorSet Element51;
            public ReflectDescriptorSet Element52;
            public ReflectDescriptorSet Element53;
            public ReflectDescriptorSet Element54;
            public ReflectDescriptorSet Element55;
            public ReflectDescriptorSet Element56;
            public ReflectDescriptorSet Element57;
            public ReflectDescriptorSet Element58;
            public ReflectDescriptorSet Element59;
            public ReflectDescriptorSet Element60;
            public ReflectDescriptorSet Element61;
            public ReflectDescriptorSet Element62;
            public ReflectDescriptorSet Element63;
            public ref ReflectDescriptorSet this[int index]
            {
                get
                {
                    if (index > 63 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (ReflectDescriptorSet* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<ReflectDescriptorSet> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 64);
#endif
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "input_variable_count")]
        public uint InputVariableCount;

        [NativeName("Type", "SpvReflectInterfaceVariable **")]
        [NativeName("Type.Name", "SpvReflectInterfaceVariable **")]
        [NativeName("Name", "input_variables")]
        public ReflectInterfaceVariable** InputVariables;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "output_variable_count")]
        public uint OutputVariableCount;

        [NativeName("Type", "SpvReflectInterfaceVariable **")]
        [NativeName("Type.Name", "SpvReflectInterfaceVariable **")]
        [NativeName("Name", "output_variables")]
        public ReflectInterfaceVariable** OutputVariables;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "interface_variable_count")]
        public uint InterfaceVariableCount;

        [NativeName("Type", "SpvReflectInterfaceVariable *")]
        [NativeName("Type.Name", "SpvReflectInterfaceVariable *")]
        [NativeName("Name", "interface_variables")]
        public ReflectInterfaceVariable* InterfaceVariables;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "push_constant_block_count")]
        public uint PushConstantBlockCount;

        [NativeName("Type", "SpvReflectBlockVariable *")]
        [NativeName("Type.Name", "SpvReflectBlockVariable *")]
        [NativeName("Name", "push_constant_blocks")]
        public ReflectBlockVariable* PushConstantBlocks;

        [NativeName("Type", "struct Internal *")]
        [NativeName("Type.Name", "struct Internal *")]
        [NativeName("Name", "_internal")]
        public Internal* Internal;
    }
}
