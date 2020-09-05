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
    [NativeName("Name", "D3D11_CLASS_INSTANCE_DESC")]
    public unsafe partial struct ClassInstanceDesc
    {
        public ClassInstanceDesc
        (
            uint instanceId = default,
            uint instanceIndex = default,
            uint typeId = default,
            uint constantBuffer = default,
            uint baseConstantBufferOffset = default,
            uint baseTexture = default,
            uint baseSampler = default,
            int created = default
        )
        {
            InstanceId = instanceId;
            InstanceIndex = instanceIndex;
            TypeId = typeId;
            ConstantBuffer = constantBuffer;
            BaseConstantBufferOffset = baseConstantBufferOffset;
            BaseTexture = baseTexture;
            BaseSampler = baseSampler;
            Created = created;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InstanceId")]
        public uint InstanceId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InstanceIndex")]
        public uint InstanceIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TypeId")]
        public uint TypeId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConstantBuffer")]
        public uint ConstantBuffer;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BaseConstantBufferOffset")]
        public uint BaseConstantBufferOffset;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BaseTexture")]
        public uint BaseTexture;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BaseSampler")]
        public uint BaseSampler;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Created")]
        public int Created;
    }
}
