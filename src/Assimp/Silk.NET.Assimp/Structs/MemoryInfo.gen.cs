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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiMemoryInfo")]
    public unsafe partial struct MemoryInfo
    {
        public MemoryInfo
        (
            uint? textures = null,
            uint? materials = null,
            uint? meshes = null,
            uint? nodes = null,
            uint? animations = null,
            uint? cameras = null,
            uint? lights = null,
            uint? total = null
        ) : this()
        {
            if (textures is not null)
            {
                Textures = textures.Value;
            }

            if (materials is not null)
            {
                Materials = materials.Value;
            }

            if (meshes is not null)
            {
                Meshes = meshes.Value;
            }

            if (nodes is not null)
            {
                Nodes = nodes.Value;
            }

            if (animations is not null)
            {
                Animations = animations.Value;
            }

            if (cameras is not null)
            {
                Cameras = cameras.Value;
            }

            if (lights is not null)
            {
                Lights = lights.Value;
            }

            if (total is not null)
            {
                Total = total.Value;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "textures")]
        public uint Textures;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "materials")]
        public uint Materials;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "meshes")]
        public uint Meshes;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "nodes")]
        public uint Nodes;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "animations")]
        public uint Animations;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "cameras")]
        public uint Cameras;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "lights")]
        public uint Lights;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "total")]
        public uint Total;
    }
}
