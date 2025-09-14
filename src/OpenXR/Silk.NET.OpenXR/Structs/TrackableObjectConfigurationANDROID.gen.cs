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
    [NativeName("Name", "XrTrackableObjectConfigurationANDROID")]
    public unsafe partial struct TrackableObjectConfigurationANDROID
    {
        public TrackableObjectConfigurationANDROID
        (
            StructureType? type = StructureType.TypeTrackableObjectConfigurationAndroid,
            void* next = null,
            uint? labelCount = null,
            ObjectLabelANDROID* activeLabels = null
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

            if (labelCount is not null)
            {
                LabelCount = labelCount.Value;
            }

            if (activeLabels is not null)
            {
                ActiveLabels = activeLabels;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "labelCount")]
        public uint LabelCount;
/// <summary></summary>
        [NativeName("Type", "XrObjectLabelANDROID*")]
        [NativeName("Type.Name", "XrObjectLabelANDROID")]
        [NativeName("Name", "activeLabels")]
        public ObjectLabelANDROID* ActiveLabels;
    }
}
