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
    [NativeName("Name", "XrNegotiateApiLayerRequest")]
    public unsafe partial struct NegotiateApiLayerRequest
    {
        public NegotiateApiLayerRequest
        (
            LoaderInterfaceStructs? structType = null,
            uint? structVersion = null,
            nuint? structSize = null,
            uint? layerInterfaceVersion = null,
            ulong? layerApiVersion = null,
            PfnGetInstanceProcAddr? getInstanceProcAddr = null,
            PfnCreateApiLayerInstance? createApiLayerInstance = null
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

            if (layerInterfaceVersion is not null)
            {
                LayerInterfaceVersion = layerInterfaceVersion.Value;
            }

            if (layerApiVersion is not null)
            {
                LayerApiVersion = layerApiVersion.Value;
            }

            if (getInstanceProcAddr is not null)
            {
                GetInstanceProcAddr = getInstanceProcAddr.Value;
            }

            if (createApiLayerInstance is not null)
            {
                CreateApiLayerInstance = createApiLayerInstance.Value;
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
        [NativeName("Name", "layerInterfaceVersion")]
        public uint LayerInterfaceVersion;
/// <summary></summary>
        [NativeName("Type", "XrVersion")]
        [NativeName("Type.Name", "XrVersion")]
        [NativeName("Name", "layerApiVersion")]
        public ulong LayerApiVersion;
/// <summary></summary>
        [NativeName("Type", "PFN_xrGetInstanceProcAddr")]
        [NativeName("Type.Name", "PFN_xrGetInstanceProcAddr")]
        [NativeName("Name", "getInstanceProcAddr")]
        public PfnGetInstanceProcAddr GetInstanceProcAddr;
/// <summary></summary>
        [NativeName("Type", "PFN_xrCreateApiLayerInstance")]
        [NativeName("Type.Name", "PFN_xrCreateApiLayerInstance")]
        [NativeName("Name", "createApiLayerInstance")]
        public PfnCreateApiLayerInstance CreateApiLayerInstance;
    }
}
