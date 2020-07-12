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
    public unsafe struct SystemEyeGazeInteractionPropertiesEXT
    {
        public SystemEyeGazeInteractionPropertiesEXT
        (
            StructureType type = StructureType.TypeSystemEyeGazeInteractionPropertiesExt,
            void* next = default,
            uint supportsEyeGazeInteraction = default
        )
        {
           Type = type;
           Next = next;
           SupportsEyeGazeInteraction = supportsEyeGazeInteraction;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public uint SupportsEyeGazeInteraction;
    }
}
