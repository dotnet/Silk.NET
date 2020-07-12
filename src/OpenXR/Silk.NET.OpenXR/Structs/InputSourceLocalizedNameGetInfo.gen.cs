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
    public unsafe struct InputSourceLocalizedNameGetInfo
    {
        public InputSourceLocalizedNameGetInfo
        (
            StructureType type = StructureType.TypeInputSourceLocalizedNameGetInfo,
            void* next = default,
            ulong sourcePath = default,
            InputSourceLocalizedNameFlags whichComponents = default
        )
        {
           Type = type;
           Next = next;
           SourcePath = sourcePath;
           WhichComponents = whichComponents;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public ulong SourcePath;
/// <summary></summary>
        public InputSourceLocalizedNameFlags WhichComponents;
    }
}
