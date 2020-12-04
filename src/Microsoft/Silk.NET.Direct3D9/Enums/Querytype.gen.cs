// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DQUERYTYPE")]
    public enum Querytype
    {
        [NativeName("Name", "D3DQUERYTYPE_VCACHE")]
        QuerytypeVcache = 0x4,
        [NativeName("Name", "D3DQUERYTYPE_RESOURCEMANAGER")]
        QuerytypeResourcemanager = 0x5,
        [NativeName("Name", "D3DQUERYTYPE_VERTEXSTATS")]
        QuerytypeVertexstats = 0x6,
        [NativeName("Name", "D3DQUERYTYPE_EVENT")]
        QuerytypeEvent = 0x8,
        [NativeName("Name", "D3DQUERYTYPE_OCCLUSION")]
        QuerytypeOcclusion = 0x9,
        [NativeName("Name", "D3DQUERYTYPE_TIMESTAMP")]
        QuerytypeTimestamp = 0xA,
        [NativeName("Name", "D3DQUERYTYPE_TIMESTAMPDISJOINT")]
        QuerytypeTimestampdisjoint = 0xB,
        [NativeName("Name", "D3DQUERYTYPE_TIMESTAMPFREQ")]
        QuerytypeTimestampfreq = 0xC,
        [NativeName("Name", "D3DQUERYTYPE_PIPELINETIMINGS")]
        QuerytypePipelinetimings = 0xD,
        [NativeName("Name", "D3DQUERYTYPE_INTERFACETIMINGS")]
        QuerytypeInterfacetimings = 0xE,
        [NativeName("Name", "D3DQUERYTYPE_VERTEXTIMINGS")]
        QuerytypeVertextimings = 0xF,
        [NativeName("Name", "D3DQUERYTYPE_PIXELTIMINGS")]
        QuerytypePixeltimings = 0x10,
        [NativeName("Name", "D3DQUERYTYPE_BANDWIDTHTIMINGS")]
        QuerytypeBandwidthtimings = 0x11,
        [NativeName("Name", "D3DQUERYTYPE_CACHEUTILIZATION")]
        QuerytypeCacheutilization = 0x12,
        [NativeName("Name", "D3DQUERYTYPE_MEMORYPRESSURE")]
        QuerytypeMemorypressure = 0x13,
    }
}
