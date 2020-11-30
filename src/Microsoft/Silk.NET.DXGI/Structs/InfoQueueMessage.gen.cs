// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_INFO_QUEUE_MESSAGE")]
    public unsafe partial struct InfoQueueMessage
    {
        public InfoQueueMessage
        (
            Guid? producer = null,
            InfoQueueMessageCategory? category = null,
            InfoQueueMessageSeverity? severity = null,
            int? iD = null,
            byte* pDescription = null,
            uint? descriptionByteLength = null
        ) : this()
        {
            if (producer is not null)
            {
                Producer = producer.Value;
            }

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


        [NativeName("Type", "DXGI_DEBUG_ID")]
        [NativeName("Type.Name", "DXGI_DEBUG_ID")]
        [NativeName("Name", "Producer")]
        public Guid Producer;

        [NativeName("Type", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY")]
        [NativeName("Type.Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY")]
        [NativeName("Name", "Category")]
        public InfoQueueMessageCategory Category;

        [NativeName("Type", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY")]
        [NativeName("Type.Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY")]
        [NativeName("Name", "Severity")]
        public InfoQueueMessageSeverity Severity;

        [NativeName("Type", "DXGI_INFO_QUEUE_MESSAGE_ID")]
        [NativeName("Type.Name", "DXGI_INFO_QUEUE_MESSAGE_ID")]
        [NativeName("Name", "ID")]
        public int ID;

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
