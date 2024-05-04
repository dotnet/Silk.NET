// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrLoaderInterfaceStructs")]
    public enum LoaderInterfaceStructs : int
    {
        [Obsolete("Deprecated in favour of \"Unintialized\"")]
        [NativeName("Name", "XR_LOADER_INTERFACE_STRUCT_UNINTIALIZED")]
        LoaderInterfaceStructUnintialized = 0,
        [Obsolete("Deprecated in favour of \"LoaderInfo\"")]
        [NativeName("Name", "XR_LOADER_INTERFACE_STRUCT_LOADER_INFO")]
        LoaderInterfaceStructLoaderInfo = 1,
        [Obsolete("Deprecated in favour of \"ApiLayerRequest\"")]
        [NativeName("Name", "XR_LOADER_INTERFACE_STRUCT_API_LAYER_REQUEST")]
        LoaderInterfaceStructApiLayerRequest = 2,
        [Obsolete("Deprecated in favour of \"RuntimeRequest\"")]
        [NativeName("Name", "XR_LOADER_INTERFACE_STRUCT_RUNTIME_REQUEST")]
        LoaderInterfaceStructRuntimeRequest = 3,
        [Obsolete("Deprecated in favour of \"ApiLayerCreateInfo\"")]
        [NativeName("Name", "XR_LOADER_INTERFACE_STRUCT_API_LAYER_CREATE_INFO")]
        LoaderInterfaceStructApiLayerCreateInfo = 4,
        [Obsolete("Deprecated in favour of \"ApiLayerNextInfo\"")]
        [NativeName("Name", "XR_LOADER_INTERFACE_STRUCT_API_LAYER_NEXT_INFO")]
        LoaderInterfaceStructApiLayerNextInfo = 5,
        [NativeName("Name", "XR_LOADER_INTERFACE_STRUCT_UNINTIALIZED")]
        Unintialized = 0,
        [NativeName("Name", "XR_LOADER_INTERFACE_STRUCT_LOADER_INFO")]
        LoaderInfo = 1,
        [NativeName("Name", "XR_LOADER_INTERFACE_STRUCT_API_LAYER_REQUEST")]
        ApiLayerRequest = 2,
        [NativeName("Name", "XR_LOADER_INTERFACE_STRUCT_RUNTIME_REQUEST")]
        RuntimeRequest = 3,
        [NativeName("Name", "XR_LOADER_INTERFACE_STRUCT_API_LAYER_CREATE_INFO")]
        ApiLayerCreateInfo = 4,
        [NativeName("Name", "XR_LOADER_INTERFACE_STRUCT_API_LAYER_NEXT_INFO")]
        ApiLayerNextInfo = 5,
    }
}
