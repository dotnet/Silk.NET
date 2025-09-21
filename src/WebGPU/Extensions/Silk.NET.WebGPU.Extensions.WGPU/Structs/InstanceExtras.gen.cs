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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUInstanceExtras")]
    public unsafe partial struct InstanceExtras
    {
        public InstanceExtras
        (
            ChainedStruct? chain = null,
            ulong? backends = null,
            ulong? flags = null,
            Dx12Compiler? dx12ShaderCompiler = null,
            Gles3MinorVersion? gles3MinorVersion = null,
            GLFenceBehaviour? glFenceBehaviour = null,
            StringView? dxilPath = null,
            StringView? dxcPath = null,
            DxcMaxShaderModel? dxcMaxShaderModel = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (backends is not null)
            {
                Backends = backends.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (dx12ShaderCompiler is not null)
            {
                Dx12ShaderCompiler = dx12ShaderCompiler.Value;
            }

            if (gles3MinorVersion is not null)
            {
                Gles3MinorVersion = gles3MinorVersion.Value;
            }

            if (glFenceBehaviour is not null)
            {
                GlFenceBehaviour = glFenceBehaviour.Value;
            }

            if (dxilPath is not null)
            {
                DxilPath = dxilPath.Value;
            }

            if (dxcPath is not null)
            {
                DxcPath = dxcPath.Value;
            }

            if (dxcMaxShaderModel is not null)
            {
                DxcMaxShaderModel = dxcMaxShaderModel.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUInstanceBackend")]
        [NativeName("Type.Name", "WGPUInstanceBackend")]
        [NativeName("Name", "backends")]
        public ulong Backends;

        [NativeName("Type", "WGPUInstanceFlag")]
        [NativeName("Type.Name", "WGPUInstanceFlag")]
        [NativeName("Name", "flags")]
        public ulong Flags;

        [NativeName("Type", "WGPUDx12Compiler")]
        [NativeName("Type.Name", "WGPUDx12Compiler")]
        [NativeName("Name", "dx12ShaderCompiler")]
        public Dx12Compiler Dx12ShaderCompiler;

        [NativeName("Type", "WGPUGles3MinorVersion")]
        [NativeName("Type.Name", "WGPUGles3MinorVersion")]
        [NativeName("Name", "gles3MinorVersion")]
        public Gles3MinorVersion Gles3MinorVersion;

        [NativeName("Type", "WGPUGLFenceBehaviour")]
        [NativeName("Type.Name", "WGPUGLFenceBehaviour")]
        [NativeName("Name", "glFenceBehaviour")]
        public GLFenceBehaviour GlFenceBehaviour;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "dxilPath")]
        public StringView DxilPath;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "dxcPath")]
        public StringView DxcPath;

        [NativeName("Type", "WGPUDxcMaxShaderModel")]
        [NativeName("Type.Name", "WGPUDxcMaxShaderModel")]
        [NativeName("Name", "dxcMaxShaderModel")]
        public DxcMaxShaderModel DxcMaxShaderModel;
    }
}
