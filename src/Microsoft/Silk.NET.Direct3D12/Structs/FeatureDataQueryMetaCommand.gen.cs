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
    [NativeName("Name", "D3D12_FEATURE_DATA_QUERY_META_COMMAND")]
    public unsafe partial struct FeatureDataQueryMetaCommand
    {
        public FeatureDataQueryMetaCommand
        (
            Guid? commandId = null,
            uint? nodeMask = null,
            void* pQueryInputData = null,
            nuint? queryInputDataSizeInBytes = null,
            void* pQueryOutputData = null,
            nuint? queryOutputDataSizeInBytes = null
        ) : this()
        {
            if (commandId is not null)
            {
                CommandId = commandId.Value;
            }

            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }

            if (pQueryInputData is not null)
            {
                PQueryInputData = pQueryInputData;
            }

            if (queryInputDataSizeInBytes is not null)
            {
                QueryInputDataSizeInBytes = queryInputDataSizeInBytes.Value;
            }

            if (pQueryOutputData is not null)
            {
                PQueryOutputData = pQueryOutputData;
            }

            if (queryOutputDataSizeInBytes is not null)
            {
                QueryOutputDataSizeInBytes = queryOutputDataSizeInBytes.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "CommandId")]
        public Guid CommandId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;

        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "pQueryInputData")]
        public void* PQueryInputData;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "QueryInputDataSizeInBytes")]
        public nuint QueryInputDataSizeInBytes;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pQueryOutputData")]
        public void* PQueryOutputData;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "QueryOutputDataSizeInBytes")]
        public nuint QueryOutputDataSizeInBytes;
    }
}
