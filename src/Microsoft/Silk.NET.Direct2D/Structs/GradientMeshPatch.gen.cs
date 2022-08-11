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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_GRADIENT_MESH_PATCH")]
    public unsafe partial struct GradientMeshPatch
    {
        public GradientMeshPatch
        (
            Silk.NET.Maths.Vector2D<float>? point00 = null,
            Silk.NET.Maths.Vector2D<float>? point01 = null,
            Silk.NET.Maths.Vector2D<float>? point02 = null,
            Silk.NET.Maths.Vector2D<float>? point03 = null,
            Silk.NET.Maths.Vector2D<float>? point10 = null,
            Silk.NET.Maths.Vector2D<float>? point11 = null,
            Silk.NET.Maths.Vector2D<float>? point12 = null,
            Silk.NET.Maths.Vector2D<float>? point13 = null,
            Silk.NET.Maths.Vector2D<float>? point20 = null,
            Silk.NET.Maths.Vector2D<float>? point21 = null,
            Silk.NET.Maths.Vector2D<float>? point22 = null,
            Silk.NET.Maths.Vector2D<float>? point23 = null,
            Silk.NET.Maths.Vector2D<float>? point30 = null,
            Silk.NET.Maths.Vector2D<float>? point31 = null,
            Silk.NET.Maths.Vector2D<float>? point32 = null,
            Silk.NET.Maths.Vector2D<float>? point33 = null,
            Silk.NET.DXGI.D3Dcolorvalue? color00 = null,
            Silk.NET.DXGI.D3Dcolorvalue? color03 = null,
            Silk.NET.DXGI.D3Dcolorvalue? color30 = null,
            Silk.NET.DXGI.D3Dcolorvalue? color33 = null,
            PatchEdgeMode? topEdgeMode = null,
            PatchEdgeMode? leftEdgeMode = null,
            PatchEdgeMode? bottomEdgeMode = null,
            PatchEdgeMode? rightEdgeMode = null
        ) : this()
        {
            if (point00 is not null)
            {
                Point00 = point00.Value;
            }

            if (point01 is not null)
            {
                Point01 = point01.Value;
            }

            if (point02 is not null)
            {
                Point02 = point02.Value;
            }

            if (point03 is not null)
            {
                Point03 = point03.Value;
            }

            if (point10 is not null)
            {
                Point10 = point10.Value;
            }

            if (point11 is not null)
            {
                Point11 = point11.Value;
            }

            if (point12 is not null)
            {
                Point12 = point12.Value;
            }

            if (point13 is not null)
            {
                Point13 = point13.Value;
            }

            if (point20 is not null)
            {
                Point20 = point20.Value;
            }

            if (point21 is not null)
            {
                Point21 = point21.Value;
            }

            if (point22 is not null)
            {
                Point22 = point22.Value;
            }

            if (point23 is not null)
            {
                Point23 = point23.Value;
            }

            if (point30 is not null)
            {
                Point30 = point30.Value;
            }

            if (point31 is not null)
            {
                Point31 = point31.Value;
            }

            if (point32 is not null)
            {
                Point32 = point32.Value;
            }

            if (point33 is not null)
            {
                Point33 = point33.Value;
            }

            if (color00 is not null)
            {
                Color00 = color00.Value;
            }

            if (color03 is not null)
            {
                Color03 = color03.Value;
            }

            if (color30 is not null)
            {
                Color30 = color30.Value;
            }

            if (color33 is not null)
            {
                Color33 = color33.Value;
            }

            if (topEdgeMode is not null)
            {
                TopEdgeMode = topEdgeMode.Value;
            }

            if (leftEdgeMode is not null)
            {
                LeftEdgeMode = leftEdgeMode.Value;
            }

            if (bottomEdgeMode is not null)
            {
                BottomEdgeMode = bottomEdgeMode.Value;
            }

            if (rightEdgeMode is not null)
            {
                RightEdgeMode = rightEdgeMode.Value;
            }
        }


        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point00")]
        public Silk.NET.Maths.Vector2D<float> Point00;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point01")]
        public Silk.NET.Maths.Vector2D<float> Point01;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point02")]
        public Silk.NET.Maths.Vector2D<float> Point02;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point03")]
        public Silk.NET.Maths.Vector2D<float> Point03;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point10")]
        public Silk.NET.Maths.Vector2D<float> Point10;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point11")]
        public Silk.NET.Maths.Vector2D<float> Point11;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point12")]
        public Silk.NET.Maths.Vector2D<float> Point12;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point13")]
        public Silk.NET.Maths.Vector2D<float> Point13;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point20")]
        public Silk.NET.Maths.Vector2D<float> Point20;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point21")]
        public Silk.NET.Maths.Vector2D<float> Point21;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point22")]
        public Silk.NET.Maths.Vector2D<float> Point22;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point23")]
        public Silk.NET.Maths.Vector2D<float> Point23;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point30")]
        public Silk.NET.Maths.Vector2D<float> Point30;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point31")]
        public Silk.NET.Maths.Vector2D<float> Point31;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point32")]
        public Silk.NET.Maths.Vector2D<float> Point32;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "point33")]
        public Silk.NET.Maths.Vector2D<float> Point33;

        [NativeName("Type", "D2D1_COLOR_F")]
        [NativeName("Type.Name", "D2D1_COLOR_F")]
        [NativeName("Name", "color00")]
        public Silk.NET.DXGI.D3Dcolorvalue Color00;

        [NativeName("Type", "D2D1_COLOR_F")]
        [NativeName("Type.Name", "D2D1_COLOR_F")]
        [NativeName("Name", "color03")]
        public Silk.NET.DXGI.D3Dcolorvalue Color03;

        [NativeName("Type", "D2D1_COLOR_F")]
        [NativeName("Type.Name", "D2D1_COLOR_F")]
        [NativeName("Name", "color30")]
        public Silk.NET.DXGI.D3Dcolorvalue Color30;

        [NativeName("Type", "D2D1_COLOR_F")]
        [NativeName("Type.Name", "D2D1_COLOR_F")]
        [NativeName("Name", "color33")]
        public Silk.NET.DXGI.D3Dcolorvalue Color33;

        [NativeName("Type", "D2D1_PATCH_EDGE_MODE")]
        [NativeName("Type.Name", "D2D1_PATCH_EDGE_MODE")]
        [NativeName("Name", "topEdgeMode")]
        public PatchEdgeMode TopEdgeMode;

        [NativeName("Type", "D2D1_PATCH_EDGE_MODE")]
        [NativeName("Type.Name", "D2D1_PATCH_EDGE_MODE")]
        [NativeName("Name", "leftEdgeMode")]
        public PatchEdgeMode LeftEdgeMode;

        [NativeName("Type", "D2D1_PATCH_EDGE_MODE")]
        [NativeName("Type.Name", "D2D1_PATCH_EDGE_MODE")]
        [NativeName("Name", "bottomEdgeMode")]
        public PatchEdgeMode BottomEdgeMode;

        [NativeName("Type", "D2D1_PATCH_EDGE_MODE")]
        [NativeName("Type.Name", "D2D1_PATCH_EDGE_MODE")]
        [NativeName("Name", "rightEdgeMode")]
        public PatchEdgeMode RightEdgeMode;
    }
}
