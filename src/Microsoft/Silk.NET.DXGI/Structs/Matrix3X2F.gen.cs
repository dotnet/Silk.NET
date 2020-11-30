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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_MATRIX_3X2_F")]
    public unsafe partial struct Matrix3X2F
    {
        public Matrix3X2F
        (
            float? dXGI11 = null,
            float? dXGI12 = null,
            float? dXGI21 = null,
            float? dXGI22 = null,
            float? dXGI31 = null,
            float? dXGI32 = null
        ) : this()
        {
            if (dXGI11 is not null)
            {
                DXGI11 = dXGI11.Value;
            }

            if (dXGI12 is not null)
            {
                DXGI12 = dXGI12.Value;
            }

            if (dXGI21 is not null)
            {
                DXGI21 = dXGI21.Value;
            }

            if (dXGI22 is not null)
            {
                DXGI22 = dXGI22.Value;
            }

            if (dXGI31 is not null)
            {
                DXGI31 = dXGI31.Value;
            }

            if (dXGI32 is not null)
            {
                DXGI32 = dXGI32.Value;
            }
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
