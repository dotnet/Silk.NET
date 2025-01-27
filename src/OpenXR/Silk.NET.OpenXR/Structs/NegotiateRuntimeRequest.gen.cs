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
    [NativeName("Name", "XrNegotiateRuntimeRequest")]
    public unsafe partial struct NegotiateRuntimeRequest
    {
        public NegotiateRuntimeRequest
        (
            LoaderInterfaceStructs? structType = null,
            uint? structVersion = null,
            nuint? structSize = null,
            uint? runtimeInterfaceVersion = null,
            ulong? runtimeApiVersion = null,
            PfnGetInstanceProcAddr? getInstanceProcAddr = null
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

            if (runtimeInterfaceVersion is not null)
            {
                RuntimeInterfaceVersion = runtimeInterfaceVersion.Value;
            }

            if (runtimeApiVersion is not null)
            {
                RuntimeApiVersion = runtimeApiVersion.Value;
            }

            if (getInstanceProcAddr is not null)
            {
                GetInstanceProcAddr = getInstanceProcAddr.Value;
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
        [NativeName("Name", "runtimeInterfaceVersion")]
        public uint RuntimeInterfaceVersion;
/// <summary></summary>
        [NativeName("Type", "XrVersion")]
        [NativeName("Type.Name", "XrVersion")]
        [NativeName("Name", "runtimeApiVersion")]
        public ulong RuntimeApiVersion;
/// <summary></summary>
        [NativeName("Type", "PFN_xrGetInstanceProcAddr")]
        [NativeName("Type.Name", "PFN_xrGetInstanceProcAddr")]
        [NativeName("Name", "getInstanceProcAddr")]
        public PfnGetInstanceProcAddr GetInstanceProcAddr;
    }
}
