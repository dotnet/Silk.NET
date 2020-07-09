// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiMemoryInfo")]
    public unsafe struct MemoryInfo
    {
        public MemoryInfo
        (
            uint textures = default,
            uint materials = default,
            uint meshes = default,
            uint nodes = default,
            uint animations = default,
            uint cameras = default,
            uint lights = default,
            uint total = default
        )
        {
           Textures = textures;
           Materials = materials;
           Meshes = meshes;
           Nodes = nodes;
           Animations = animations;
           Cameras = cameras;
           Lights = lights;
           Total = total;
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
