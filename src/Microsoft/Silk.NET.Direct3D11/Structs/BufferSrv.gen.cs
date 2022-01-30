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
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_L3396_C5")]
        [NativeName("Name", "anonymous1")]
        public BufferSrvUnion1 Anonymous1;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11_L3401_C5")]
        [NativeName("Name", "anonymous2")]
        public BufferSrvUnion2 Anonymous2;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint FirstElement
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].FirstElement;
        }
#else
        public uint FirstElement
        {
            get => Anonymous1.FirstElement;
            set => Anonymous1.FirstElement = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint ElementOffset
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].ElementOffset;
        }
#else
        public uint ElementOffset
        {
            get => Anonymous1.ElementOffset;
            set => Anonymous1.ElementOffset = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint NumElements
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].NumElements;
        }
#else
        public uint NumElements
        {
            get => Anonymous2.NumElements;
            set => Anonymous2.NumElements = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint ElementWidth
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].ElementWidth;
        }
#else
        public uint ElementWidth
        {
            get => Anonymous2.ElementWidth;
            set => Anonymous2.ElementWidth = value;
        }
#endif

    }
}
