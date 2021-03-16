// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "D3D12_ROOT_PARAMETER1")]
    public unsafe partial struct RootParameter1
    {
        public RootParameter1
        (
            RootParameterType? parameterType = null,
            RootParameter1Union? anonymous = null,
            ShaderVisibility? shaderVisibility = null,
            RootDescriptorTable1? descriptorTable = null,
            RootConstants? constants = null,
            RootDescriptor1? descriptor = null
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
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L3559_C5")]
        [NativeName("Name", "anonymous1")]
        public RootParameter1Union Anonymous;

        [NativeName("Type", "D3D12_SHADER_VISIBILITY")]
        [NativeName("Type.Name", "D3D12_SHADER_VISIBILITY")]
        [NativeName("Name", "ShaderVisibility")]
        public ShaderVisibility ShaderVisibility;
#if NETSTANDARD2_1
        public ref RootDescriptorTable1 DescriptorTable
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.DescriptorTable;
        }
#else
        public RootDescriptorTable1 DescriptorTable
        {
            get => Anonymous.DescriptorTable;
            set => Anonymous.DescriptorTable = value;
        }
#endif

#if NETSTANDARD2_1
        public ref RootConstants Constants
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Constants;
        }
#else
        public RootConstants Constants
        {
            get => Anonymous.Constants;
            set => Anonymous.Constants = value;
        }
#endif

#if NETSTANDARD2_1
        public ref RootDescriptor1 Descriptor
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.Descriptor;
        }
#else
        public RootDescriptor1 Descriptor
        {
            get => Anonymous.Descriptor;
            set => Anonymous.Descriptor = value;
        }
#endif

    }
}
