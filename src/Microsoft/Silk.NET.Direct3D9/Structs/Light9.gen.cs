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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DLIGHT9")]
    public unsafe partial struct Light9
    {
        public Light9
        (
            Lighttype? type = null,
            Silk.NET.DXGI.D3Dcolorvalue? diffuse = null,
            Silk.NET.DXGI.D3Dcolorvalue? specular = null,
            Silk.NET.DXGI.D3Dcolorvalue? ambient = null,
            Vector? position = null,
            Vector? direction = null,
            float? range = null,
            float? falloff = null,
            float? attenuation0 = null,
            float? attenuation1 = null,
            float? attenuation2 = null,
            float? theta = null,
            float? phi = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (diffuse is not null)
            {
                Diffuse = diffuse.Value;
            }

            if (specular is not null)
            {
                Specular = specular.Value;
            }

            if (ambient is not null)
            {
                Ambient = ambient.Value;
            }

            if (position is not null)
            {
                Position = position.Value;
            }

            if (direction is not null)
            {
                Direction = direction.Value;
            }

            if (range is not null)
            {
                Range = range.Value;
            }

            if (falloff is not null)
            {
                Falloff = falloff.Value;
            }

            if (attenuation0 is not null)
            {
                Attenuation0 = attenuation0.Value;
            }

            if (attenuation1 is not null)
            {
                Attenuation1 = attenuation1.Value;
            }

            if (attenuation2 is not null)
            {
                Attenuation2 = attenuation2.Value;
            }

            if (theta is not null)
            {
                Theta = theta.Value;
            }

            if (phi is not null)
            {
                Phi = phi.Value;
            }
        }


        [NativeName("Type", "D3DLIGHTTYPE")]
        [NativeName("Type.Name", "D3DLIGHTTYPE")]
        [NativeName("Name", "Type")]
        public Lighttype Type;

        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Diffuse")]
        public Silk.NET.DXGI.D3Dcolorvalue Diffuse;

        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Specular")]
        public Silk.NET.DXGI.D3Dcolorvalue Specular;

        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Ambient")]
        public Silk.NET.DXGI.D3Dcolorvalue Ambient;

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
