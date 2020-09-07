// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_INFO_QUEUE_FILTER_DESC")]
    public unsafe partial struct InfoQueueFilterDesc
    {
        public InfoQueueFilterDesc
        (
            uint numCategories = default,
            InfoQueueMessageCategory* pCategoryList = default,
            uint numSeverities = default,
            InfoQueueMessageSeverity* pSeverityList = default,
            uint numIDs = default,
            int* pIDList = default
        )
        {
            NumCategories = numCategories;
            PCategoryList = pCategoryList;
            NumSeverities = numSeverities;
            PSeverityList = pSeverityList;
            NumIDs = numIDs;
            PIDList = pIDList;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumCategories")]
        public uint NumCategories;

        [NativeName("Type", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY *")]
        [NativeName("Type.Name", "DXGI_INFO_QUEUE_MESSAGE_CATEGORY *")]
        [NativeName("Name", "pCategoryList")]
        public InfoQueueMessageCategory* PCategoryList;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumSeverities")]
        public uint NumSeverities;

        [NativeName("Type", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY *")]
        [NativeName("Type.Name", "DXGI_INFO_QUEUE_MESSAGE_SEVERITY *")]
        [NativeName("Name", "pSeverityList")]
        public InfoQueueMessageSeverity* PSeverityList;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumIDs")]
        public uint NumIDs;

        [NativeName("Type", "DXGI_INFO_QUEUE_MESSAGE_ID *")]
        [NativeName("Type.Name", "DXGI_INFO_QUEUE_MESSAGE_ID *")]
        [NativeName("Name", "pIDList")]
        public int* PIDList;
    }
}
