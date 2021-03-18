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
    [NativeName("Name", "XrSystemProperties")]
    public unsafe partial struct SystemProperties
    {
        public SystemProperties
        (
            StructureType? type = StructureType.TypeSystemProperties,
            void* next = null,
            ulong? systemId = null,
            uint? vendorId = null,
            SystemGraphicsProperties? graphicsProperties = null,
            SystemTrackingProperties? trackingProperties = null
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

            if (systemId is not null)
            {
                SystemId = systemId.Value;
            }

            if (vendorId is not null)
            {
                VendorId = vendorId.Value;
            }

            if (graphicsProperties is not null)
            {
                GraphicsProperties = graphicsProperties.Value;
            }

            if (trackingProperties is not null)
            {
                TrackingProperties = trackingProperties.Value;
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
        [NativeName("Type", "XrSystemId")]
        [NativeName("Type.Name", "XrSystemId")]
        [NativeName("Name", "systemId")]
        public ulong SystemId;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vendorId")]
        public uint VendorId;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "systemName")]
        public fixed byte SystemName[256];
/// <summary></summary>
        [NativeName("Type", "XrSystemGraphicsProperties")]
        [NativeName("Type.Name", "XrSystemGraphicsProperties")]
        [NativeName("Name", "graphicsProperties")]
        public SystemGraphicsProperties GraphicsProperties;
/// <summary></summary>
        [NativeName("Type", "XrSystemTrackingProperties")]
        [NativeName("Type.Name", "XrSystemTrackingProperties")]
        [NativeName("Name", "trackingProperties")]
        public SystemTrackingProperties TrackingProperties;
    }
}
