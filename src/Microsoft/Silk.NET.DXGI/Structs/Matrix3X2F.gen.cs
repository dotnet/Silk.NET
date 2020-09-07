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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_MATRIX_3X2_F")]
    public unsafe partial struct Matrix3X2F
    {
        public Matrix3X2F
        (
            float dXGI11 = default,
            float dXGI12 = default,
            float dXGI21 = default,
            float dXGI22 = default,
            float dXGI31 = default,
            float dXGI32 = default
        )
        {
            DXGI11 = dXGI11;
            DXGI12 = dXGI12;
            DXGI21 = dXGI21;
            DXGI22 = dXGI22;
            DXGI31 = dXGI31;
            DXGI32 = dXGI32;
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "_11")]
        public float DXGI11;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "_12")]
        public float DXGI12;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "_21")]
        public float DXGI21;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "_22")]
        public float DXGI22;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "_31")]
        public float DXGI31;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "_32")]
        public float DXGI32;
    }
}
