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
    [NativeName("Name", "_D3DMATERIAL9")]
    public unsafe partial struct Material9
    {
        public Material9
        (
            Colorvalue diffuse = default,
            Colorvalue ambient = default,
            Colorvalue specular = default,
            Colorvalue emissive = default,
            float power = default
        )
        {
            Diffuse = diffuse;
            Ambient = ambient;
            Specular = specular;
            Emissive = emissive;
            Power = power;
        }


        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Diffuse")]
        public Colorvalue Diffuse;

        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Ambient")]
        public Colorvalue Ambient;

        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Specular")]
        public Colorvalue Specular;

        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Emissive")]
        public Colorvalue Emissive;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Power")]
        public float Power;
    }
}
