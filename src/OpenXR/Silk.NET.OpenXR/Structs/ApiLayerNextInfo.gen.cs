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
    [NativeName("Name", "XrApiLayerNextInfo")]
    public unsafe partial struct ApiLayerNextInfo
    {
        public ApiLayerNextInfo
        (
            LoaderInterfaceStructs? structType = null,
            uint? structVersion = null,
            nuint? structSize = null,
            PfnGetInstanceProcAddr? nextGetInstanceProcAddr = null,
            PfnCreateApiLayerInstance? nextCreateApiLayerInstance = null,
            ApiLayerNextInfo* next = null
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

            if (nextGetInstanceProcAddr is not null)
            {
                NextGetInstanceProcAddr = nextGetInstanceProcAddr.Value;
            }

            if (nextCreateApiLayerInstance is not null)
            {
                NextCreateApiLayerInstance = nextCreateApiLayerInstance.Value;
            }

            if (next is not null)
            {
                Next = next;
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
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "layerName")]
        public fixed byte LayerName[256];
/// <summary></summary>
        [NativeName("Type", "PFN_xrGetInstanceProcAddr")]
        [NativeName("Type.Name", "PFN_xrGetInstanceProcAddr")]
        [NativeName("Name", "nextGetInstanceProcAddr")]
        public PfnGetInstanceProcAddr NextGetInstanceProcAddr;
/// <summary></summary>
        [NativeName("Type", "PFN_xrCreateApiLayerInstance")]
        [NativeName("Type.Name", "PFN_xrCreateApiLayerInstance")]
        [NativeName("Name", "nextCreateApiLayerInstance")]
        public PfnCreateApiLayerInstance NextCreateApiLayerInstance;
/// <summary></summary>
        [NativeName("Type", "XrApiLayerNextInfo*")]
        [NativeName("Type.Name", "XrApiLayerNextInfo")]
        [NativeName("Name", "next")]
        public ApiLayerNextInfo* Next;
    }
}
