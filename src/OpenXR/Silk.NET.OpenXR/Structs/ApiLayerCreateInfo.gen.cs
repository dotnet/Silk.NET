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
    [NativeName("Name", "XrApiLayerCreateInfo")]
    public unsafe partial struct ApiLayerCreateInfo
    {
        public ApiLayerCreateInfo
        (
            LoaderInterfaceStructs? structType = null,
            uint? structVersion = null,
            nuint? structSize = null,
            void* loaderInstance = null,
            ApiLayerNextInfo* nextInfo = null
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

            if (loaderInstance is not null)
            {
                LoaderInstance = loaderInstance;
            }

            if (nextInfo is not null)
            {
                NextInfo = nextInfo;
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
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "loaderInstance")]
        public void* LoaderInstance;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "settings_file_location")]
        public fixed byte SettingsFileLocation[512];
/// <summary></summary>
        [NativeName("Type", "XrApiLayerNextInfo*")]
        [NativeName("Type.Name", "XrApiLayerNextInfo")]
        [NativeName("Name", "nextInfo")]
        public ApiLayerNextInfo* NextInfo;
    }
}
