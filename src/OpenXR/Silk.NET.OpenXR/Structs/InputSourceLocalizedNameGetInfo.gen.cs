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
    [NativeName("Name", "XrInputSourceLocalizedNameGetInfo")]
    public unsafe partial struct InputSourceLocalizedNameGetInfo
    {
        public InputSourceLocalizedNameGetInfo
        (
            StructureType? type = StructureType.TypeInputSourceLocalizedNameGetInfo,
            void* next = null,
            ulong? sourcePath = null,
            InputSourceLocalizedNameFlags? whichComponents = null
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

            if (sourcePath is not null)
            {
                SourcePath = sourcePath.Value;
            }

            if (whichComponents is not null)
            {
                WhichComponents = whichComponents.Value;
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
        [NativeName("Type", "XrPath")]
        [NativeName("Type.Name", "XrPath")]
        [NativeName("Name", "sourcePath")]
        public ulong SourcePath;
/// <summary></summary>
        [NativeName("Type", "XrInputSourceLocalizedNameFlags")]
        [NativeName("Type.Name", "XrInputSourceLocalizedNameFlags")]
        [NativeName("Name", "whichComponents")]
        public InputSourceLocalizedNameFlags WhichComponents;
    }
}
