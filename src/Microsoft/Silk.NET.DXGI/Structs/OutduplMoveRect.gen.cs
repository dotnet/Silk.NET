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
    [NativeName("Name", "DXGI_OUTDUPL_MOVE_RECT")]
    public unsafe partial struct OutduplMoveRect
    {
        public OutduplMoveRect
        (
            Silk.NET.Core.Native.TagPoint? sourcePoint = null,
            Silk.NET.Core.Native.TagRect? destinationRect = null
        ) : this()
        {
            if (sourcePoint is not null)
            {
                SourcePoint = sourcePoint.Value;
            }

            if (destinationRect is not null)
            {
                DestinationRect = destinationRect.Value;
            }
        }


        [NativeName("Type", "POINT")]
        [NativeName("Type.Name", "POINT")]
        [NativeName("Name", "SourcePoint")]
        public Silk.NET.Core.Native.TagPoint SourcePoint;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "DestinationRect")]
        public Silk.NET.Core.Native.TagRect DestinationRect;
    }
}
