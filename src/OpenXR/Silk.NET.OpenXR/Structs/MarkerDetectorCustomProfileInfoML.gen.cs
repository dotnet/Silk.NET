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
    [NativeName("Name", "XrMarkerDetectorCustomProfileInfoML")]
    public unsafe partial struct MarkerDetectorCustomProfileInfoML
    {
        public MarkerDetectorCustomProfileInfoML
        (
            StructureType? type = StructureType.TypeMarkerDetectorCustomProfileInfoML,
            void* next = null,
            MarkerDetectorFpsML? fpsHint = null,
            MarkerDetectorResolutionML? resolutionHint = null,
            MarkerDetectorCameraML? cameraHint = null,
            MarkerDetectorCornerRefineMethodML? cornerRefineMethod = null,
            uint? useEdgeRefinement = null,
            MarkerDetectorFullAnalysisIntervalML? fullAnalysisIntervalHint = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (fpsHint is not null)
            {
                FpsHint = fpsHint.Value;
            }

            if (resolutionHint is not null)
            {
                ResolutionHint = resolutionHint.Value;
            }

            if (cameraHint is not null)
            {
                CameraHint = cameraHint.Value;
            }

            if (cornerRefineMethod is not null)
            {
                CornerRefineMethod = cornerRefineMethod.Value;
            }

            if (useEdgeRefinement is not null)
            {
                UseEdgeRefinement = useEdgeRefinement.Value;
            }

            if (fullAnalysisIntervalHint is not null)
            {
                FullAnalysisIntervalHint = fullAnalysisIntervalHint.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrMarkerDetectorFpsML")]
        [NativeName("Type.Name", "XrMarkerDetectorFpsML")]
        [NativeName("Name", "fpsHint")]
        public MarkerDetectorFpsML FpsHint;
/// <summary></summary>
        [NativeName("Type", "XrMarkerDetectorResolutionML")]
        [NativeName("Type.Name", "XrMarkerDetectorResolutionML")]
        [NativeName("Name", "resolutionHint")]
        public MarkerDetectorResolutionML ResolutionHint;
/// <summary></summary>
        [NativeName("Type", "XrMarkerDetectorCameraML")]
        [NativeName("Type.Name", "XrMarkerDetectorCameraML")]
        [NativeName("Name", "cameraHint")]
        public MarkerDetectorCameraML CameraHint;
/// <summary></summary>
        [NativeName("Type", "XrMarkerDetectorCornerRefineMethodML")]
        [NativeName("Type.Name", "XrMarkerDetectorCornerRefineMethodML")]
        [NativeName("Name", "cornerRefineMethod")]
        public MarkerDetectorCornerRefineMethodML CornerRefineMethod;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "useEdgeRefinement")]
        public uint UseEdgeRefinement;
/// <summary></summary>
        [NativeName("Type", "XrMarkerDetectorFullAnalysisIntervalML")]
        [NativeName("Type.Name", "XrMarkerDetectorFullAnalysisIntervalML")]
        [NativeName("Name", "fullAnalysisIntervalHint")]
        public MarkerDetectorFullAnalysisIntervalML FullAnalysisIntervalHint;
    }
}
