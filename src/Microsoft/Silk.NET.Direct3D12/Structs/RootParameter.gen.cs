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
    [NativeName("Name", "D3D12_ROOT_PARAMETER")]
    public unsafe partial struct RootParameter
    {
        public RootParameter
        (
            RootParameterType? parameterType = null,
            RootParameterUnion? anonymous = null,
            ShaderVisibility? shaderVisibility = null,
            RootDescriptorTable? descriptorTable = null,
            RootConstants? constants = null,
            RootDescriptor? descriptor = null
        ) : this()
        {
            if (parameterType is not null)
            {
                ParameterType = parameterType.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (shaderVisibility is not null)
            {
                ShaderVisibility = shaderVisibility.Value;
            }

            if (descriptorTable is not null)
            {
                DescriptorTable = descriptorTable.Value;
            }

            if (constants is not null)
            {
                Constants = constants.Value;
            }

            if (descriptor is not null)
            {
                Descriptor = descriptor.Value;
            }
        }


        [NativeName("Type", "D3D12_ROOT_PARAMETER_TYPE")]
        [NativeName("Type.Name", "D3D12_ROOT_PARAMETER_TYPE")]
        [NativeName("Name", "ParameterType")]
        public RootParameterType ParameterType;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L3965_C5")]
        [NativeName("Name", "anonymous1")]
        public RootParameterUnion Anonymous;

        [NativeName("Type", "D3D12_SHADER_VISIBILITY")]
        [NativeName("Type.Name", "D3D12_SHADER_VISIBILITY")]
        [NativeName("Name", "ShaderVisibility")]
        public ShaderVisibility ShaderVisibility;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RootDescriptorTable DescriptorTable
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].DescriptorTable;
        }
#else
        public RootDescriptorTable DescriptorTable
        {
            get => Anonymous.DescriptorTable;
            set => Anonymous.DescriptorTable = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RootConstants Constants
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Constants;
        }
#else
        public RootConstants Constants
        {
            get => Anonymous.Constants;
            set => Anonymous.Constants = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RootDescriptor Descriptor
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Descriptor;
        }
#else
        public RootDescriptor Descriptor
        {
            get => Anonymous.Descriptor;
            set => Anonymous.Descriptor = value;
        }
#endif

    }
}
