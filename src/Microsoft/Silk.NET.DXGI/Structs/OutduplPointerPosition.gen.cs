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
    [NativeName("Name", "DXGI_OUTDUPL_POINTER_POSITION")]
    public unsafe partial struct OutduplPointerPosition
    {
        public OutduplPointerPosition
        (
            Silk.NET.Maths.Vector2D<int>? position = null,
            int? visible = null
        ) : this()
        {
            if (position is not null)
            {
                Position = position.Value;
            }

            if (visible is not null)
            {
                Visible = visible.Value;
            }
        }


        [NativeName("Type", "POINT")]
        [NativeName("Type.Name", "POINT")]
        [NativeName("Name", "Position")]
        public Silk.NET.Maths.Vector2D<int> Position;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Visible")]
        public int Visible;
    }
}
