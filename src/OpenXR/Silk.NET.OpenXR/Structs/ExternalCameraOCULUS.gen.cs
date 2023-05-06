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
    [NativeName("Name", "XrExternalCameraOCULUS")]
    public unsafe partial struct ExternalCameraOCULUS
    {
        public ExternalCameraOCULUS
        (
            StructureType? type = StructureType.TypeExternalCameraOculus,
            void* next = null,
            ExternalCameraIntrinsicsOCULUS? intrinsics = null,
            ExternalCameraExtrinsicsOCULUS? extrinsics = null
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

            if (intrinsics is not null)
            {
                Intrinsics = intrinsics.Value;
            }

            if (extrinsics is not null)
            {
                Extrinsics = extrinsics.Value;
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
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "name")]
        public fixed byte Name[32];
/// <summary></summary>
        [NativeName("Type", "XrExternalCameraIntrinsicsOCULUS")]
        [NativeName("Type.Name", "XrExternalCameraIntrinsicsOCULUS")]
        [NativeName("Name", "intrinsics")]
        public ExternalCameraIntrinsicsOCULUS Intrinsics;
/// <summary></summary>
        [NativeName("Type", "XrExternalCameraExtrinsicsOCULUS")]
        [NativeName("Type.Name", "XrExternalCameraExtrinsicsOCULUS")]
        [NativeName("Name", "extrinsics")]
        public ExternalCameraExtrinsicsOCULUS Extrinsics;
    }
}
