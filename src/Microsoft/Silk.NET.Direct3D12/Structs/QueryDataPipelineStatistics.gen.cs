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
    [NativeName("Name", "D3D12_QUERY_DATA_PIPELINE_STATISTICS")]
    public unsafe partial struct QueryDataPipelineStatistics
    {
        public QueryDataPipelineStatistics
        (
            ulong? iAVertices = null,
            ulong? iAPrimitives = null,
            ulong? vSInvocations = null,
            ulong? gSInvocations = null,
            ulong? gSPrimitives = null,
            ulong? cInvocations = null,
            ulong? cPrimitives = null,
            ulong? pSInvocations = null,
            ulong? hSInvocations = null,
            ulong? dSInvocations = null,
            ulong? cSInvocations = null
        ) : this()
        {
            if (iAVertices is not null)
            {
                IAVertices = iAVertices.Value;
            }

            if (iAPrimitives is not null)
            {
                IAPrimitives = iAPrimitives.Value;
            }

            if (vSInvocations is not null)
            {
                VSInvocations = vSInvocations.Value;
            }

            if (gSInvocations is not null)
            {
                GSInvocations = gSInvocations.Value;
            }

            if (gSPrimitives is not null)
            {
                GSPrimitives = gSPrimitives.Value;
            }

            if (cInvocations is not null)
            {
                CInvocations = cInvocations.Value;
            }

            if (cPrimitives is not null)
            {
                CPrimitives = cPrimitives.Value;
            }

            if (pSInvocations is not null)
            {
                PSInvocations = pSInvocations.Value;
            }

            if (hSInvocations is not null)
            {
                HSInvocations = hSInvocations.Value;
            }

            if (dSInvocations is not null)
            {
                DSInvocations = dSInvocations.Value;
            }

            if (cSInvocations is not null)
            {
                CSInvocations = cSInvocations.Value;
            }
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
