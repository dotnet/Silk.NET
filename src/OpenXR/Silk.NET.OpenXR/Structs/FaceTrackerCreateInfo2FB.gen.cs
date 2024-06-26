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
    [NativeName("Name", "XrFaceTrackerCreateInfo2FB")]
    public unsafe partial struct FaceTrackerCreateInfo2FB
    {
        public FaceTrackerCreateInfo2FB
        (
            StructureType? type = StructureType.TypeFaceTrackerCreateInfo2FB,
            void* next = null,
            FaceExpressionSet2FB? faceExpressionSet = null,
            uint? requestedDataSourceCount = null,
            FaceTrackingDataSource2FB* requestedDataSources = null
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

            if (faceExpressionSet is not null)
            {
                FaceExpressionSet = faceExpressionSet.Value;
            }

            if (requestedDataSourceCount is not null)
            {
                RequestedDataSourceCount = requestedDataSourceCount.Value;
            }

            if (requestedDataSources is not null)
            {
                RequestedDataSources = requestedDataSources;
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
        [NativeName("Type", "XrFaceExpressionSet2FB")]
        [NativeName("Type.Name", "XrFaceExpressionSet2FB")]
        [NativeName("Name", "faceExpressionSet")]
        public FaceExpressionSet2FB FaceExpressionSet;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "requestedDataSourceCount")]
        public uint RequestedDataSourceCount;
/// <summary></summary>
        [NativeName("Type", "XrFaceTrackingDataSource2FB*")]
        [NativeName("Type.Name", "XrFaceTrackingDataSource2FB")]
        [NativeName("Name", "requestedDataSources")]
        public FaceTrackingDataSource2FB* RequestedDataSources;
    }
}
