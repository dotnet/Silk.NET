// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrTrackableTypeANDROID")]
    public enum TrackableTypeANDROID : int
    {
        [Obsolete("Deprecated in favour of \"NotValidAndroid\"")]
        [NativeName("Name", "XR_TRACKABLE_TYPE_NOT_VALID_ANDROID")]
        TrackableTypeNotValidAndroid = 0,
        [Obsolete("Deprecated in favour of \"PlaneAndroid\"")]
        [NativeName("Name", "XR_TRACKABLE_TYPE_PLANE_ANDROID")]
        TrackableTypePlaneAndroid = 1,
        [Obsolete("Deprecated in favour of \"DepthAndroid\"")]
        [NativeName("Name", "XR_TRACKABLE_TYPE_DEPTH_ANDROID")]
        TrackableTypeDepthAndroid = 1000463000,
        [Obsolete("Deprecated in favour of \"ObjectAndroid\"")]
        [NativeName("Name", "XR_TRACKABLE_TYPE_OBJECT_ANDROID")]
        TrackableTypeObjectAndroid = 1000466000,
        [Obsolete("Deprecated in favour of \"MarkerAndroid\"")]
        [NativeName("Name", "XR_TRACKABLE_TYPE_MARKER_ANDROID")]
        TrackableTypeMarkerAndroid = 1000707000,
        [NativeName("Name", "XR_TRACKABLE_TYPE_NOT_VALID_ANDROID")]
        NotValidAndroid = 0,
        [NativeName("Name", "XR_TRACKABLE_TYPE_PLANE_ANDROID")]
        PlaneAndroid = 1,
        [NativeName("Name", "XR_TRACKABLE_TYPE_DEPTH_ANDROID")]
        DepthAndroid = 1000463000,
        [NativeName("Name", "XR_TRACKABLE_TYPE_OBJECT_ANDROID")]
        ObjectAndroid = 1000466000,
        [NativeName("Name", "XR_TRACKABLE_TYPE_MARKER_ANDROID")]
        MarkerAndroid = 1000707000,
    }
}
