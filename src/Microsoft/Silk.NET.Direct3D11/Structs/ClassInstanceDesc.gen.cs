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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_CLASS_INSTANCE_DESC")]
    public unsafe partial struct ClassInstanceDesc
    {
        public ClassInstanceDesc
        (
            uint? instanceId = null,
            uint? instanceIndex = null,
            uint? typeId = null,
            uint? constantBuffer = null,
            uint? baseConstantBufferOffset = null,
            uint? baseTexture = null,
            uint? baseSampler = null,
            Silk.NET.Core.Bool32? created = null
        ) : this()
        {
            if (instanceId is not null)
            {
                InstanceId = instanceId.Value;
            }

            if (instanceIndex is not null)
            {
                InstanceIndex = instanceIndex.Value;
            }

            if (typeId is not null)
            {
                TypeId = typeId.Value;
            }

            if (constantBuffer is not null)
            {
                ConstantBuffer = constantBuffer.Value;
            }

            if (baseConstantBufferOffset is not null)
            {
                BaseConstantBufferOffset = baseConstantBufferOffset.Value;
            }

            if (baseTexture is not null)
            {
                BaseTexture = baseTexture.Value;
            }

            if (baseSampler is not null)
            {
                BaseSampler = baseSampler.Value;
            }

            if (created is not null)
            {
                Created = created.Value;
            }
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
        public Silk.NET.Core.Bool32 Created;
    }
}
