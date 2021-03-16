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
    [NativeName("Name", "_D3D12_SHADER_VARIABLE_DESC")]
    public unsafe partial struct ShaderVariableDesc
    {
        public ShaderVariableDesc
        (
            byte* name = null,
            uint? startOffset = null,
            uint? size = null,
            uint? uFlags = null,
            void* defaultValue = null,
            uint? startTexture = null,
            uint? textureSize = null,
            uint? startSampler = null,
            uint? samplerSize = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name;
            }

            if (startOffset is not null)
            {
                StartOffset = startOffset.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (uFlags is not null)
            {
                UFlags = uFlags.Value;
            }

            if (defaultValue is not null)
            {
                DefaultValue = defaultValue;
            }

            if (startTexture is not null)
            {
                StartTexture = startTexture.Value;
            }

            if (textureSize is not null)
            {
                TextureSize = textureSize.Value;
            }

            if (startSampler is not null)
            {
                StartSampler = startSampler.Value;
            }

            if (samplerSize is not null)
            {
                SamplerSize = samplerSize.Value;
            }
        }


        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "Name")]
        public byte* Name;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartOffset")]
        public uint StartOffset;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "uFlags")]
        public uint UFlags;

        [NativeName("Type", "LPVOID")]
        [NativeName("Type.Name", "LPVOID")]
        [NativeName("Name", "DefaultValue")]
        public void* DefaultValue;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartTexture")]
        public uint StartTexture;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TextureSize")]
        public uint TextureSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartSampler")]
        public uint StartSampler;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SamplerSize")]
        public uint SamplerSize;
    }
}
