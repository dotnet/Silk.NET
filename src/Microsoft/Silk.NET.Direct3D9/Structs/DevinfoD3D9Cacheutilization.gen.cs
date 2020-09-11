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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEVINFO_D3D9CACHEUTILIZATION")]
    public unsafe partial struct DevinfoD3D9Cacheutilization
    {
        public DevinfoD3D9Cacheutilization
        (
            float textureCacheHitRate = default,
            float postTransformVertexCacheHitRate = default
        )
        {
            TextureCacheHitRate = textureCacheHitRate;
            PostTransformVertexCacheHitRate = postTransformVertexCacheHitRate;
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "TextureCacheHitRate")]
        public float TextureCacheHitRate;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "PostTransformVertexCacheHitRate")]
        public float PostTransformVertexCacheHitRate;
    }
}
