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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSRTDataNV")]
    public unsafe partial struct SRTDataNV
    {
        public SRTDataNV
        (
            float? sx = null,
            float? a = null,
            float? b = null,
            float? pvx = null,
            float? sy = null,
            float? c = null,
            float? pvy = null,
            float? sz = null,
            float? pvz = null,
            float? qx = null,
            float? qy = null,
            float? qz = null,
            float? qw = null,
            float? tx = null,
            float? ty = null,
            float? tz = null
        ) : this()
        {
            if (sx is not null)
            {
                Sx = sx.Value;
            }

            if (a is not null)
            {
                A = a.Value;
            }

            if (b is not null)
            {
                B = b.Value;
            }

            if (pvx is not null)
            {
                Pvx = pvx.Value;
            }

            if (sy is not null)
            {
                Sy = sy.Value;
            }

            if (c is not null)
            {
                C = c.Value;
            }

            if (pvy is not null)
            {
                Pvy = pvy.Value;
            }

            if (sz is not null)
            {
                Sz = sz.Value;
            }

            if (pvz is not null)
            {
                Pvz = pvz.Value;
            }

            if (qx is not null)
            {
                Qx = qx.Value;
            }

            if (qy is not null)
            {
                Qy = qy.Value;
            }

            if (qz is not null)
            {
                Qz = qz.Value;
            }

            if (qw is not null)
            {
                Qw = qw.Value;
            }

            if (tx is not null)
            {
                Tx = tx.Value;
            }

            if (ty is not null)
            {
                Ty = ty.Value;
            }

            if (tz is not null)
            {
                Tz = tz.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "sx")]
        public float Sx;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "a")]
        public float A;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "b")]
        public float B;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pvx")]
        public float Pvx;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "sy")]
        public float Sy;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "c")]
        public float C;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pvy")]
        public float Pvy;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "sz")]
        public float Sz;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pvz")]
        public float Pvz;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "qx")]
        public float Qx;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "qy")]
        public float Qy;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "qz")]
        public float Qz;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "qw")]
        public float Qw;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "tx")]
        public float Tx;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "ty")]
        public float Ty;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "tz")]
        public float Tz;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
