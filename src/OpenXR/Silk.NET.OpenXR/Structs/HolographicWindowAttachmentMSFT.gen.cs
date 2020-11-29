// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHolographicWindowAttachmentMSFT")]
    public unsafe partial struct HolographicWindowAttachmentMSFT
    {
        public HolographicWindowAttachmentMSFT
        (
            StructureType? type = StructureType.TypeHolographicWindowAttachmentMsft,
            void* next = null,
            Silk.NET.Core.Native.IUnknown* holographicSpace = null,
            Silk.NET.Core.Native.IUnknown* coreWindow = null
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

            if (holographicSpace is not null)
            {
                HolographicSpace = holographicSpace;
            }

            if (coreWindow is not null)
            {
                CoreWindow = coreWindow;
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
        [NativeName("Type", "IUnknown*")]
        [NativeName("Type.Name", "IUnknown")]
        [NativeName("Name", "holographicSpace")]
        public Silk.NET.Core.Native.IUnknown* HolographicSpace;
/// <summary></summary>
        [NativeName("Type", "IUnknown*")]
        [NativeName("Type.Name", "IUnknown")]
        [NativeName("Name", "coreWindow")]
        public Silk.NET.Core.Native.IUnknown* CoreWindow;
    }
}
