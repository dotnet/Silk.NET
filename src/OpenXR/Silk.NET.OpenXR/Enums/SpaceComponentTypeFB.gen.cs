// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpaceComponentTypeFB")]
    public enum SpaceComponentTypeFB : int
    {
        [Obsolete("Deprecated in favour of \"LocatableFB\"")]
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_LOCATABLE_FB")]
        SpaceComponentTypeLocatableFB = 0,
        [Obsolete("Deprecated in favour of \"StorableFB\"")]
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_STORABLE_FB")]
        SpaceComponentTypeStorableFB = 1,
        [Obsolete("Deprecated in favour of \"SharableFB\"")]
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_SHARABLE_FB")]
        SpaceComponentTypeSharableFB = 2,
        [Obsolete("Deprecated in favour of \"Bounded2DFB\"")]
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_BOUNDED_2D_FB")]
        SpaceComponentTypeBounded2DFB = 3,
        [Obsolete("Deprecated in favour of \"Bounded3DFB\"")]
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_BOUNDED_3D_FB")]
        SpaceComponentTypeBounded3DFB = 4,
        [Obsolete("Deprecated in favour of \"SemanticLabelsFB\"")]
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_SEMANTIC_LABELS_FB")]
        SpaceComponentTypeSemanticLabelsFB = 5,
        [Obsolete("Deprecated in favour of \"RoomLayoutFB\"")]
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_ROOM_LAYOUT_FB")]
        SpaceComponentTypeRoomLayoutFB = 6,
        [Obsolete("Deprecated in favour of \"SpaceContainerFB\"")]
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_SPACE_CONTAINER_FB")]
        SpaceComponentTypeSpaceContainerFB = 7,
        [Obsolete("Deprecated in favour of \"TriangleMeshMeta\"")]
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_TRIANGLE_MESH_META")]
        SpaceComponentTypeTriangleMeshMeta = 1000269000,
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_LOCATABLE_FB")]
        LocatableFB = 0,
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_STORABLE_FB")]
        StorableFB = 1,
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_SHARABLE_FB")]
        SharableFB = 2,
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_BOUNDED_2D_FB")]
        Bounded2DFB = 3,
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_BOUNDED_3D_FB")]
        Bounded3DFB = 4,
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_SEMANTIC_LABELS_FB")]
        SemanticLabelsFB = 5,
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_ROOM_LAYOUT_FB")]
        RoomLayoutFB = 6,
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_SPACE_CONTAINER_FB")]
        SpaceContainerFB = 7,
        [NativeName("Name", "XR_SPACE_COMPONENT_TYPE_TRIANGLE_MESH_META")]
        TriangleMeshMeta = 1000269000,
    }
}
