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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_INFO_QUEUE_FILTER_DESC")]
    public unsafe partial struct InfoQueueFilterDesc
    {
        public InfoQueueFilterDesc
        (
            uint? numCategories = null,
            MessageCategory* pCategoryList = null,
            uint? numSeverities = null,
            MessageSeverity* pSeverityList = null,
            uint? numIDs = null,
            MessageID* pIDList = null
        ) : this()
        {
            if (numCategories is not null)
            {
                NumCategories = numCategories.Value;
            }

            if (pCategoryList is not null)
            {
                PCategoryList = pCategoryList;
            }

            if (numSeverities is not null)
            {
                NumSeverities = numSeverities.Value;
            }

            if (pSeverityList is not null)
            {
                PSeverityList = pSeverityList;
            }

            if (numIDs is not null)
            {
                NumIDs = numIDs.Value;
            }

            if (pIDList is not null)
            {
                PIDList = pIDList;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumCategories")]
        public uint NumCategories;

        [NativeName("Type", "D3D12_MESSAGE_CATEGORY *")]
        [NativeName("Type.Name", "D3D12_MESSAGE_CATEGORY *")]
        [NativeName("Name", "pCategoryList")]
        public MessageCategory* PCategoryList;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumSeverities")]
        public uint NumSeverities;

        [NativeName("Type", "D3D12_MESSAGE_SEVERITY *")]
        [NativeName("Type.Name", "D3D12_MESSAGE_SEVERITY *")]
        [NativeName("Name", "pSeverityList")]
        public MessageSeverity* PSeverityList;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumIDs")]
        public uint NumIDs;

        [NativeName("Type", "D3D12_MESSAGE_ID *")]
        [NativeName("Type.Name", "D3D12_MESSAGE_ID *")]
        [NativeName("Name", "pIDList")]
        public MessageID* PIDList;
    }
}
