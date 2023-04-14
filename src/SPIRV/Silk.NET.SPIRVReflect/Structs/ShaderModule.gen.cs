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
    [NativeName("Name", "ShaderModule")]
    public unsafe partial struct ShaderModule
    {
        public ShaderModule
        (
            ReflectResult? mResult = null,
            ReflectShaderModule? mModule = null
        ) : this()
        {
            if (mResult is not null)
            {
                MResult = mResult.Value;
            }

            if (mModule is not null)
            {
                MModule = mModule.Value;
            }
        }


        [NativeName("Type", "SpvReflectResult")]
        [NativeName("Type.Name", "SpvReflectResult")]
        [NativeName("Name", "m_result")]
        public ReflectResult MResult;

        [NativeName("Type", "SpvReflectShaderModule")]
        [NativeName("Type.Name", "SpvReflectShaderModule")]
        [NativeName("Name", "m_module")]
        public ReflectShaderModule MModule;
    }
}
