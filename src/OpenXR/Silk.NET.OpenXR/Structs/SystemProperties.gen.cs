// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct SystemProperties
    {
        public SystemProperties
        (
            StructureType type = StructureType.TypeSystemProperties,
            void* next = default,
            ulong systemId = default,
            uint vendorId = default,
            SystemGraphicsProperties graphicsProperties = default,
            SystemTrackingProperties trackingProperties = default
        )
        {
           Type = type;
           Next = next;
           SystemId = systemId;
           VendorId = vendorId;
           GraphicsProperties = graphicsProperties;
           TrackingProperties = trackingProperties;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public ulong SystemId;
/// <summary></summary>
        public uint VendorId;
        /// <summary></summary>
       public fixed byte SystemName[256];
/// <summary></summary>
        public SystemGraphicsProperties GraphicsProperties;
/// <summary></summary>
        public SystemTrackingProperties TrackingProperties;
    }
}
