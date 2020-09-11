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
    [NativeName("Name", "_D3DLIGHT9")]
    public unsafe partial struct Light9
    {
        public Light9
        (
            Lighttype type = default,
            Colorvalue diffuse = default,
            Colorvalue specular = default,
            Colorvalue ambient = default,
            Vector position = default,
            Vector direction = default,
            float range = default,
            float falloff = default,
            float attenuation0 = default,
            float attenuation1 = default,
            float attenuation2 = default,
            float theta = default,
            float phi = default
        )
        {
            Type = type;
            Diffuse = diffuse;
            Specular = specular;
            Ambient = ambient;
            Position = position;
            Direction = direction;
            Range = range;
            Falloff = falloff;
            Attenuation0 = attenuation0;
            Attenuation1 = attenuation1;
            Attenuation2 = attenuation2;
            Theta = theta;
            Phi = phi;
        }


        [NativeName("Type", "D3DLIGHTTYPE")]
        [NativeName("Type.Name", "D3DLIGHTTYPE")]
        [NativeName("Name", "Type")]
        public Lighttype Type;

        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Diffuse")]
        public Colorvalue Diffuse;

        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Specular")]
        public Colorvalue Specular;

        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Ambient")]
        public Colorvalue Ambient;

        [NativeName("Type", "D3DVECTOR")]
        [NativeName("Type.Name", "D3DVECTOR")]
        [NativeName("Name", "Position")]
        public Vector Position;

        [NativeName("Type", "D3DVECTOR")]
        [NativeName("Type.Name", "D3DVECTOR")]
        [NativeName("Name", "Direction")]
        public Vector Direction;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Range")]
        public float Range;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Falloff")]
        public float Falloff;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Attenuation0")]
        public float Attenuation0;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Attenuation1")]
        public float Attenuation1;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Attenuation2")]
        public float Attenuation2;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Theta")]
        public float Theta;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Phi")]
        public float Phi;
    }
}
