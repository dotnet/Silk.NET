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
    [NativeName("Name", "_D3D11_SHADER_VARIABLE_DESC")]
    public unsafe partial struct ShaderVariableDesc
    {
        public ShaderVariableDesc
        (
            byte* name = default,
            uint startOffset = default,
            uint size = default,
            uint uFlags = default,
            void* defaultValue = default,
            uint startTexture = default,
            uint textureSize = default,
            uint startSampler = default,
            uint samplerSize = default
        )
        {
            Name = name;
            StartOffset = startOffset;
            Size = size;
            UFlags = uFlags;
            DefaultValue = defaultValue;
            StartTexture = startTexture;
            TextureSize = textureSize;
            StartSampler = startSampler;
            SamplerSize = samplerSize;
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
