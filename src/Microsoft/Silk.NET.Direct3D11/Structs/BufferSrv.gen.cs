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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_BUFFER_SRV")]
    public unsafe partial struct BufferSrv
    {
        public BufferSrv
        (
            BufferSrvUnion1? anonymous1 = null,
            BufferSrvUnion2? anonymous2 = null,
            uint? firstElement = null,
            uint? elementOffset = null,
            uint? numElements = null,
            uint? elementWidth = null
        ) : this()
        {
            if (anonymous1 is not null)
            {
                Anonymous1 = anonymous1.Value;
            }

            if (anonymous2 is not null)
            {
                Anonymous2 = anonymous2.Value;
            }

            if (firstElement is not null)
            {
                FirstElement = firstElement.Value;
            }

            if (elementOffset is not null)
            {
                ElementOffset = elementOffset.Value;
            }

            if (numElements is not null)
            {
                NumElements = numElements.Value;
            }

            if (elementWidth is not null)
            {
                ElementWidth = elementWidth.Value;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_L3293_C5")]
        [NativeName("Name", "anonymous1")]
        public BufferSrvUnion1 Anonymous1;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_L3298_C5")]
        [NativeName("Name", "anonymous2")]
        public BufferSrvUnion2 Anonymous2;
        public uint FirstElement
        {
            get => Anonymous1.FirstElement;
            set => Anonymous1.FirstElement = value;
        }

        public uint ElementOffset
        {
            get => Anonymous1.ElementOffset;
            set => Anonymous1.ElementOffset = value;
        }

        public uint NumElements
        {
            get => Anonymous2.NumElements;
            set => Anonymous2.NumElements = value;
        }

        public uint ElementWidth
        {
            get => Anonymous2.ElementWidth;
            set => Anonymous2.ElementWidth = value;
        }

    }
}
