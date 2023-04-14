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
    [NativeName("Name", "SpvReflectEntryPoint")]
    public unsafe partial struct ReflectEntryPoint
    {
        public ReflectEntryPoint
        (
            byte* name = null,
            uint? id = null,
            Silk.NET.SPIRV.ExecutionModel? spirvExecutionModel = null,
            ReflectShaderStageFlagBits? shaderStage = null,
            uint? inputVariableCount = null,
            ReflectInterfaceVariable** inputVariables = null,
            uint? outputVariableCount = null,
            ReflectInterfaceVariable** outputVariables = null,
            uint? interfaceVariableCount = null,
            ReflectInterfaceVariable* interfaceVariables = null,
            uint? descriptorSetCount = null,
            ReflectDescriptorSet* descriptorSets = null,
            uint? usedUniformCount = null,
            uint* usedUniforms = null,
            uint? usedPushConstantCount = null,
            uint* usedPushConstants = null,
            uint? executionModeCount = null,
            Silk.NET.SPIRV.ExecutionMode* executionModes = null,
            LocalSize? localSize = null,
            uint? invocations = null,
            uint? outputVertices = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name;
            }

            if (id is not null)
            {
                Id = id.Value;
            }

            if (spirvExecutionModel is not null)
            {
                SpirvExecutionModel = spirvExecutionModel.Value;
            }

            if (shaderStage is not null)
            {
                ShaderStage = shaderStage.Value;
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

            if (descriptorSetCount is not null)
            {
                DescriptorSetCount = descriptorSetCount.Value;
            }

            if (descriptorSets is not null)
            {
                DescriptorSets = descriptorSets;
            }

            if (usedUniformCount is not null)
            {
                UsedUniformCount = usedUniformCount.Value;
            }

            if (usedUniforms is not null)
            {
                UsedUniforms = usedUniforms;
            }

            if (usedPushConstantCount is not null)
            {
                UsedPushConstantCount = usedPushConstantCount.Value;
            }

            if (usedPushConstants is not null)
            {
                UsedPushConstants = usedPushConstants;
            }

            if (executionModeCount is not null)
            {
                ExecutionModeCount = executionModeCount.Value;
            }

            if (executionModes is not null)
            {
                ExecutionModes = executionModes;
            }

            if (localSize is not null)
            {
                LocalSize = localSize.Value;
            }

            if (invocations is not null)
            {
                Invocations = invocations.Value;
            }

            if (outputVertices is not null)
            {
                OutputVertices = outputVertices.Value;
            }
        }


        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "name")]
        public byte* Name;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "id")]
        public uint Id;

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
        [NativeName("Name", "descriptor_set_count")]
        public uint DescriptorSetCount;

        [NativeName("Type", "SpvReflectDescriptorSet *")]
        [NativeName("Type.Name", "SpvReflectDescriptorSet *")]
        [NativeName("Name", "descriptor_sets")]
        public ReflectDescriptorSet* DescriptorSets;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "used_uniform_count")]
        public uint UsedUniformCount;

        [NativeName("Type", "uint32_t *")]
        [NativeName("Type.Name", "uint32_t *")]
        [NativeName("Name", "used_uniforms")]
        public uint* UsedUniforms;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "used_push_constant_count")]
        public uint UsedPushConstantCount;

        [NativeName("Type", "uint32_t *")]
        [NativeName("Type.Name", "uint32_t *")]
        [NativeName("Name", "used_push_constants")]
        public uint* UsedPushConstants;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "execution_mode_count")]
        public uint ExecutionModeCount;

        [NativeName("Type", "SpvExecutionMode *")]
        [NativeName("Type.Name", "SpvExecutionMode *")]
        [NativeName("Name", "execution_modes")]
        public Silk.NET.SPIRV.ExecutionMode* ExecutionModes;

        [NativeName("Type", "struct LocalSize")]
        [NativeName("Type.Name", "struct LocalSize")]
        [NativeName("Name", "local_size")]
        public LocalSize LocalSize;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "invocations")]
        public uint Invocations;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "output_vertices")]
        public uint OutputVertices;
    }
}
