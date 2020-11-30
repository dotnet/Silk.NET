// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DMATERIAL9")]
    public unsafe partial struct Material9
    {
        public Material9
        (
            Colorvalue? diffuse = null,
            Colorvalue? ambient = null,
            Colorvalue? specular = null,
            Colorvalue? emissive = null,
            float? power = null
        ) : this()
        {
            if (diffuse is not null)
            {
                Diffuse = diffuse.Value;
            }

            if (ambient is not null)
            {
                Ambient = ambient.Value;
            }

            if (specular is not null)
            {
                Specular = specular.Value;
            }

            if (emissive is not null)
            {
                Emissive = emissive.Value;
            }

            if (power is not null)
            {
                Power = power.Value;
            }
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
