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
    [NativeName("Name", "_D3DMATERIAL9")]
    public unsafe partial struct Material9
    {
        public Material9
        (
            Silk.NET.DXGI.D3Dcolorvalue? diffuse = null,
            Silk.NET.DXGI.D3Dcolorvalue? ambient = null,
            Silk.NET.DXGI.D3Dcolorvalue? specular = null,
            Silk.NET.DXGI.D3Dcolorvalue? emissive = null,
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
        public Silk.NET.DXGI.D3Dcolorvalue Diffuse;

        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Ambient")]
        public Silk.NET.DXGI.D3Dcolorvalue Ambient;

        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Specular")]
        public Silk.NET.DXGI.D3Dcolorvalue Specular;

        [NativeName("Type", "D3DCOLORVALUE")]
        [NativeName("Type.Name", "D3DCOLORVALUE")]
        [NativeName("Name", "Emissive")]
        public Silk.NET.DXGI.D3Dcolorvalue Emissive;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "Power")]
        public float Power;
    }
}
