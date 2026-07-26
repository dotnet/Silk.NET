// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrTrackableMarkerDictionaryANDROID")]
    public enum TrackableMarkerDictionaryANDROID : int
    {
        [Obsolete("Deprecated in favour of \"Aruco4X450Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_4X4_50_ANDROID")]
        TrackableMarkerDictionaryAruco4X450Android = 0,
        [Obsolete("Deprecated in favour of \"Aruco4X4100Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_4X4_100_ANDROID")]
        TrackableMarkerDictionaryAruco4X4100Android = 1,
        [Obsolete("Deprecated in favour of \"Aruco4X4250Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_4X4_250_ANDROID")]
        TrackableMarkerDictionaryAruco4X4250Android = 2,
        [Obsolete("Deprecated in favour of \"Aruco4X41000Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_4X4_1000_ANDROID")]
        TrackableMarkerDictionaryAruco4X41000Android = 3,
        [Obsolete("Deprecated in favour of \"Aruco5X550Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_5X5_50_ANDROID")]
        TrackableMarkerDictionaryAruco5X550Android = 4,
        [Obsolete("Deprecated in favour of \"Aruco5X5100Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_5X5_100_ANDROID")]
        TrackableMarkerDictionaryAruco5X5100Android = 5,
        [Obsolete("Deprecated in favour of \"Aruco5X5250Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_5X5_250_ANDROID")]
        TrackableMarkerDictionaryAruco5X5250Android = 6,
        [Obsolete("Deprecated in favour of \"Aruco5X51000Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_5X5_1000_ANDROID")]
        TrackableMarkerDictionaryAruco5X51000Android = 7,
        [Obsolete("Deprecated in favour of \"Aruco6X650Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_6X6_50_ANDROID")]
        TrackableMarkerDictionaryAruco6X650Android = 8,
        [Obsolete("Deprecated in favour of \"Aruco6X6100Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_6X6_100_ANDROID")]
        TrackableMarkerDictionaryAruco6X6100Android = 9,
        [Obsolete("Deprecated in favour of \"Aruco6X6250Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_6X6_250_ANDROID")]
        TrackableMarkerDictionaryAruco6X6250Android = 10,
        [Obsolete("Deprecated in favour of \"Aruco6X61000Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_6X6_1000_ANDROID")]
        TrackableMarkerDictionaryAruco6X61000Android = 11,
        [Obsolete("Deprecated in favour of \"Aruco7X750Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_7X7_50_ANDROID")]
        TrackableMarkerDictionaryAruco7X750Android = 12,
        [Obsolete("Deprecated in favour of \"Aruco7X7100Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_7X7_100_ANDROID")]
        TrackableMarkerDictionaryAruco7X7100Android = 13,
        [Obsolete("Deprecated in favour of \"Aruco7X7250Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_7X7_250_ANDROID")]
        TrackableMarkerDictionaryAruco7X7250Android = 14,
        [Obsolete("Deprecated in favour of \"Aruco7X71000Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_7X7_1000_ANDROID")]
        TrackableMarkerDictionaryAruco7X71000Android = 15,
        [Obsolete("Deprecated in favour of \"Apriltag16H5Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_APRILTAG_16H5_ANDROID")]
        TrackableMarkerDictionaryApriltag16H5Android = 16,
        [Obsolete("Deprecated in favour of \"Apriltag25H9Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_APRILTAG_25H9_ANDROID")]
        TrackableMarkerDictionaryApriltag25H9Android = 17,
        [Obsolete("Deprecated in favour of \"Apriltag36H10Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_APRILTAG_36H10_ANDROID")]
        TrackableMarkerDictionaryApriltag36H10Android = 18,
        [Obsolete("Deprecated in favour of \"Apriltag36H11Android\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_APRILTAG_36H11_ANDROID")]
        TrackableMarkerDictionaryApriltag36H11Android = 19,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_4X4_50_ANDROID")]
        Aruco4X450Android = 0,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_4X4_100_ANDROID")]
        Aruco4X4100Android = 1,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_4X4_250_ANDROID")]
        Aruco4X4250Android = 2,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_4X4_1000_ANDROID")]
        Aruco4X41000Android = 3,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_5X5_50_ANDROID")]
        Aruco5X550Android = 4,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_5X5_100_ANDROID")]
        Aruco5X5100Android = 5,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_5X5_250_ANDROID")]
        Aruco5X5250Android = 6,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_5X5_1000_ANDROID")]
        Aruco5X51000Android = 7,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_6X6_50_ANDROID")]
        Aruco6X650Android = 8,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_6X6_100_ANDROID")]
        Aruco6X6100Android = 9,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_6X6_250_ANDROID")]
        Aruco6X6250Android = 10,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_6X6_1000_ANDROID")]
        Aruco6X61000Android = 11,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_7X7_50_ANDROID")]
        Aruco7X750Android = 12,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_7X7_100_ANDROID")]
        Aruco7X7100Android = 13,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_7X7_250_ANDROID")]
        Aruco7X7250Android = 14,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_7X7_1000_ANDROID")]
        Aruco7X71000Android = 15,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_APRILTAG_16H5_ANDROID")]
        Apriltag16H5Android = 16,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_APRILTAG_25H9_ANDROID")]
        Apriltag25H9Android = 17,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_APRILTAG_36H10_ANDROID")]
        Apriltag36H10Android = 18,
        [NativeName("Name", "XR_TRACKABLE_MARKER_DICTIONARY_APRILTAG_36H11_ANDROID")]
        Apriltag36H11Android = 19,
    }
}
