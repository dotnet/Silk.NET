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

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_REQUEST")]
    public unsafe partial struct Request
    {
        public Request
        (
            RequestOptions? options = null,
            Source? source = null,
            Destination? destination = null,
            uint? uncompressedSize = null,
            ulong? cancellationTag = null,
            byte* name = null
        ) : this()
        {
            if (options is not null)
            {
                Options = options.Value;
            }

            if (source is not null)
            {
                Source = source.Value;
            }

            if (destination is not null)
            {
                Destination = destination.Value;
            }

            if (uncompressedSize is not null)
            {
                UncompressedSize = uncompressedSize.Value;
            }

            if (cancellationTag is not null)
            {
                CancellationTag = cancellationTag.Value;
            }

            if (name is not null)
            {
                Name = name;
            }
        }


        [NativeName("Type", "DSTORAGE_REQUEST_OPTIONS")]
        [NativeName("Type.Name", "DSTORAGE_REQUEST_OPTIONS")]
        [NativeName("Name", "Options")]
        public RequestOptions Options;

        [NativeName("Type", "DSTORAGE_SOURCE")]
        [NativeName("Type.Name", "DSTORAGE_SOURCE")]
        [NativeName("Name", "Source")]
        public Source Source;

        [NativeName("Type", "DSTORAGE_DESTINATION")]
        [NativeName("Type.Name", "DSTORAGE_DESTINATION")]
        [NativeName("Name", "Destination")]
        public Destination Destination;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "UncompressedSize")]
        public uint UncompressedSize;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CancellationTag")]
        public ulong CancellationTag;

        [NativeName("Type", "const CHAR *")]
        [NativeName("Type.Name", "const CHAR *")]
        [NativeName("Name", "Name")]
        public byte* Name;
    }
}
