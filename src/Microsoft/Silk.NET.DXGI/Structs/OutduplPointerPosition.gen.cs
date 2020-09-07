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
    [NativeName("Name", "DXGI_OUTDUPL_POINTER_POSITION")]
    public unsafe partial struct OutduplPointerPosition
    {
        public OutduplPointerPosition
        (
            Silk.NET.Core.Runtime.Windows.TagPoint position = default,
            int visible = default
        )
        {
            Position = position;
            Visible = visible;
        }


        [NativeName("Type", "POINT")]
        [NativeName("Type.Name", "POINT")]
        [NativeName("Name", "Position")]
        public Silk.NET.Core.Runtime.Windows.TagPoint Position;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Visible")]
        public int Visible;
    }
}
