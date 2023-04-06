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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagRPCOLEMESSAGE")]
    public unsafe partial struct RPCOLEMessage
    {
        public RPCOLEMessage
        (
            void* reserved1 = null,
            uint? dataRepresentation = null,
            void* buffer = null,
            uint? cbBuffer = null,
            uint? iMethod = null,
            uint? rpcFlags = null
        ) : this()
        {
            if (reserved1 is not null)
            {
                Reserved1 = reserved1;
            }

            if (dataRepresentation is not null)
            {
                DataRepresentation = dataRepresentation.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer;
            }

            if (cbBuffer is not null)
            {
                CbBuffer = cbBuffer.Value;
            }

            if (iMethod is not null)
            {
                IMethod = iMethod.Value;
            }

            if (rpcFlags is not null)
            {
                RpcFlags = rpcFlags.Value;
            }
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "reserved1")]
        public void* Reserved1;

        [NativeName("Type", "RPCOLEDATAREP")]
        [NativeName("Type.Name", "RPCOLEDATAREP")]
        [NativeName("Name", "dataRepresentation")]
        public uint DataRepresentation;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "Buffer")]
        public void* Buffer;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cbBuffer")]
        public uint CbBuffer;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "iMethod")]
        public uint IMethod;
        
        [NativeName("Type", "void *[5]")]
        [NativeName("Type.Name", "void *[5]")]
        [NativeName("Name", "reserved2")]
        public Reserved2Buffer Reserved2;

        public struct Reserved2Buffer
        {
            public void* Element0;
            public void* Element1;
            public void* Element2;
            public void* Element3;
            public void* Element4;
            public ref void* this[int index]
            {
                get
                {
                    if (index > 4 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (void** ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "rpcFlags")]
        public uint RpcFlags;
    }
}
