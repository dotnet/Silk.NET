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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrNegotiateLoaderInfo")]
    public unsafe partial struct NegotiateLoaderInfo
    {
        public NegotiateLoaderInfo
        (
            LoaderInterfaceStructs? structType = null,
            uint? structVersion = null,
            nuint? structSize = null,
            uint? minInterfaceVersion = null,
            uint? maxInterfaceVersion = null,
            ulong? minApiVersion = null,
            ulong? maxApiVersion = null
        ) : this()
        {
            if (structType is not null)
            {
                StructType = structType.Value;
            }

            if (structVersion is not null)
            {
                StructVersion = structVersion.Value;
            }

            if (structSize is not null)
            {
                StructSize = structSize.Value;
            }

            if (minInterfaceVersion is not null)
            {
                MinInterfaceVersion = minInterfaceVersion.Value;
            }

            if (maxInterfaceVersion is not null)
            {
                MaxInterfaceVersion = maxInterfaceVersion.Value;
            }

            if (minApiVersion is not null)
            {
                MinApiVersion = minApiVersion.Value;
            }

            if (maxApiVersion is not null)
            {
                MaxApiVersion = maxApiVersion.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrLoaderInterfaceStructs")]
        [NativeName("Type.Name", "XrLoaderInterfaceStructs")]
        [NativeName("Name", "structType")]
        public LoaderInterfaceStructs StructType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "structVersion")]
        public uint StructVersion;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "structSize")]
        public nuint StructSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minInterfaceVersion")]
        public uint MinInterfaceVersion;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxInterfaceVersion")]
        public uint MaxInterfaceVersion;
/// <summary></summary>
        [NativeName("Type", "XrVersion")]
        [NativeName("Type.Name", "XrVersion")]
        [NativeName("Name", "minApiVersion")]
        public ulong MinApiVersion;
/// <summary></summary>
        [NativeName("Type", "XrVersion")]
        [NativeName("Type.Name", "XrVersion")]
        [NativeName("Name", "maxApiVersion")]
        public ulong MaxApiVersion;
    }
}
