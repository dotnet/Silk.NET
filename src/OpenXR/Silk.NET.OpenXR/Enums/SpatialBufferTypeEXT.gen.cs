// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialBufferTypeEXT")]
    public enum SpatialBufferTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"UnknownExt\"")]
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_UNKNOWN_EXT")]
        SpatialBufferTypeUnknownExt = 0,
        [Obsolete("Deprecated in favour of \"StringExt\"")]
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_STRING_EXT")]
        SpatialBufferTypeStringExt = 1,
        [Obsolete("Deprecated in favour of \"Uint8Ext\"")]
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_UINT8_EXT")]
        SpatialBufferTypeUint8Ext = 2,
        [Obsolete("Deprecated in favour of \"Uint16Ext\"")]
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_UINT16_EXT")]
        SpatialBufferTypeUint16Ext = 3,
        [Obsolete("Deprecated in favour of \"Uint32Ext\"")]
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_UINT32_EXT")]
        SpatialBufferTypeUint32Ext = 4,
        [Obsolete("Deprecated in favour of \"FloatExt\"")]
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_FLOAT_EXT")]
        SpatialBufferTypeFloatExt = 5,
        [Obsolete("Deprecated in favour of \"Vector2fExt\"")]
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_VECTOR2F_EXT")]
        SpatialBufferTypeVector2fExt = 6,
        [Obsolete("Deprecated in favour of \"Vector3fExt\"")]
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_VECTOR3F_EXT")]
        SpatialBufferTypeVector3fExt = 7,
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_UNKNOWN_EXT")]
        UnknownExt = 0,
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_STRING_EXT")]
        StringExt = 1,
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_UINT8_EXT")]
        Uint8Ext = 2,
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_UINT16_EXT")]
        Uint16Ext = 3,
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_UINT32_EXT")]
        Uint32Ext = 4,
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_FLOAT_EXT")]
        FloatExt = 5,
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_VECTOR2F_EXT")]
        Vector2fExt = 6,
        [NativeName("Name", "XR_SPATIAL_BUFFER_TYPE_VECTOR3F_EXT")]
        Vector3fExt = 7,
    }
}
