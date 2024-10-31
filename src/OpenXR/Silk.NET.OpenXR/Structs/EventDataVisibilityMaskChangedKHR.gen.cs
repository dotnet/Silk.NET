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
    [NativeName("Name", "XrEventDataVisibilityMaskChangedKHR")]
    public unsafe partial struct EventDataVisibilityMaskChangedKHR
    {
        public EventDataVisibilityMaskChangedKHR
        (
            StructureType? type = StructureType.TypeEventDataVisibilityMaskChangedKhr,
            void* next = null,
            Session? session = null,
            ViewConfigurationType? viewConfigurationType = null,
            uint? viewIndex = null
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

            if (session is not null)
            {
                Session = session.Value;
            }

            if (viewConfigurationType is not null)
            {
                ViewConfigurationType = viewConfigurationType.Value;
            }

            if (viewIndex is not null)
            {
                ViewIndex = viewIndex.Value;
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
        [NativeName("Type", "XrSession")]
        [NativeName("Type.Name", "XrSession")]
        [NativeName("Name", "session")]
        public Session Session;
/// <summary></summary>
        [NativeName("Type", "XrViewConfigurationType")]
        [NativeName("Type.Name", "XrViewConfigurationType")]
        [NativeName("Name", "viewConfigurationType")]
        public ViewConfigurationType ViewConfigurationType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewIndex")]
        public uint ViewIndex;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
