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
    [NativeName("Name", "XrViewLocateInfo")]
    public unsafe partial struct ViewLocateInfo
    {
        public ViewLocateInfo
        (
            StructureType? type = StructureType.TypeViewLocateInfo,
            void* next = null,
            ViewConfigurationType? viewConfigurationType = null,
            long? displayTime = null,
            Space? space = null
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

            if (viewConfigurationType is not null)
            {
                ViewConfigurationType = viewConfigurationType.Value;
            }

            if (displayTime is not null)
            {
                DisplayTime = displayTime.Value;
            }

            if (space is not null)
            {
                Space = space.Value;
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
        [NativeName("Type", "XrViewConfigurationType")]
        [NativeName("Type.Name", "XrViewConfigurationType")]
        [NativeName("Name", "viewConfigurationType")]
        public ViewConfigurationType ViewConfigurationType;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "displayTime")]
        public long DisplayTime;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
    }
}
