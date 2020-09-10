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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_QUERY_DATA_PIPELINE_STATISTICS")]
    public unsafe partial struct QueryDataPipelineStatistics
    {
        public QueryDataPipelineStatistics
        (
            ulong iAVertices = default,
            ulong iAPrimitives = default,
            ulong vSInvocations = default,
            ulong gSInvocations = default,
            ulong gSPrimitives = default,
            ulong cInvocations = default,
            ulong cPrimitives = default,
            ulong pSInvocations = default,
            ulong hSInvocations = default,
            ulong dSInvocations = default,
            ulong cSInvocations = default
        )
        {
            IAVertices = iAVertices;
            IAPrimitives = iAPrimitives;
            VSInvocations = vSInvocations;
            GSInvocations = gSInvocations;
            GSPrimitives = gSPrimitives;
            CInvocations = cInvocations;
            CPrimitives = cPrimitives;
            PSInvocations = pSInvocations;
            HSInvocations = hSInvocations;
            DSInvocations = dSInvocations;
            CSInvocations = cSInvocations;
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "IAVertices")]
        public ulong IAVertices;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "IAPrimitives")]
        public ulong IAPrimitives;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "VSInvocations")]
        public ulong VSInvocations;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "GSInvocations")]
        public ulong GSInvocations;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "GSPrimitives")]
        public ulong GSPrimitives;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CInvocations")]
        public ulong CInvocations;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CPrimitives")]
        public ulong CPrimitives;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "PSInvocations")]
        public ulong PSInvocations;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "HSInvocations")]
        public ulong HSInvocations;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "DSInvocations")]
        public ulong DSInvocations;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CSInvocations")]
        public ulong CSInvocations;
    }
}
