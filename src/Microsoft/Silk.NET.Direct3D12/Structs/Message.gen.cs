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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MESSAGE")]
    public unsafe partial struct Message
    {
        public Message
        (
            MessageCategory? category = null,
            MessageSeverity? severity = null,
            MessageID? iD = null,
            byte* pDescription = null,
            uint? descriptionByteLength = null
        ) : this()
        {
            if (category is not null)
            {
                Category = category.Value;
            }

            if (severity is not null)
            {
                Severity = severity.Value;
            }

            if (iD is not null)
            {
                ID = iD.Value;
            }

            if (pDescription is not null)
            {
                PDescription = pDescription;
            }

            if (descriptionByteLength is not null)
            {
                DescriptionByteLength = descriptionByteLength.Value;
            }
        }


        [NativeName("Type", "D3D12_MESSAGE_CATEGORY")]
        [NativeName("Type.Name", "D3D12_MESSAGE_CATEGORY")]
        [NativeName("Name", "Category")]
        public MessageCategory Category;

        [NativeName("Type", "D3D12_MESSAGE_SEVERITY")]
        [NativeName("Type.Name", "D3D12_MESSAGE_SEVERITY")]
        [NativeName("Name", "Severity")]
        public MessageSeverity Severity;

        [NativeName("Type", "D3D12_MESSAGE_ID")]
        [NativeName("Type.Name", "D3D12_MESSAGE_ID")]
        [NativeName("Name", "ID")]
        public MessageID ID;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "pDescription")]
        public byte* PDescription;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "DescriptionByteLength")]
        public uint DescriptionByteLength;
    }
}
