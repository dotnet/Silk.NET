// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DQUERYTYPE")]
    public enum Querytype : int
    {
        [Obsolete("Deprecated in favour of \"Vcache\"")]
        [NativeName("Name", "D3DQUERYTYPE_VCACHE")]
        QuerytypeVcache = 0x4,
        [Obsolete("Deprecated in favour of \"Resourcemanager\"")]
        [NativeName("Name", "D3DQUERYTYPE_RESOURCEMANAGER")]
        QuerytypeResourcemanager = 0x5,
        [Obsolete("Deprecated in favour of \"Vertexstats\"")]
        [NativeName("Name", "D3DQUERYTYPE_VERTEXSTATS")]
        QuerytypeVertexstats = 0x6,
        [Obsolete("Deprecated in favour of \"Event\"")]
        [NativeName("Name", "D3DQUERYTYPE_EVENT")]
        QuerytypeEvent = 0x8,
        [Obsolete("Deprecated in favour of \"Occlusion\"")]
        [NativeName("Name", "D3DQUERYTYPE_OCCLUSION")]
        QuerytypeOcclusion = 0x9,
        [Obsolete("Deprecated in favour of \"Timestamp\"")]
        [NativeName("Name", "D3DQUERYTYPE_TIMESTAMP")]
        QuerytypeTimestamp = 0xA,
        [Obsolete("Deprecated in favour of \"Timestampdisjoint\"")]
        [NativeName("Name", "D3DQUERYTYPE_TIMESTAMPDISJOINT")]
        QuerytypeTimestampdisjoint = 0xB,
        [Obsolete("Deprecated in favour of \"Timestampfreq\"")]
        [NativeName("Name", "D3DQUERYTYPE_TIMESTAMPFREQ")]
        QuerytypeTimestampfreq = 0xC,
        [Obsolete("Deprecated in favour of \"Pipelinetimings\"")]
        [NativeName("Name", "D3DQUERYTYPE_PIPELINETIMINGS")]
        QuerytypePipelinetimings = 0xD,
        [Obsolete("Deprecated in favour of \"Interfacetimings\"")]
        [NativeName("Name", "D3DQUERYTYPE_INTERFACETIMINGS")]
        QuerytypeInterfacetimings = 0xE,
        [Obsolete("Deprecated in favour of \"Vertextimings\"")]
        [NativeName("Name", "D3DQUERYTYPE_VERTEXTIMINGS")]
        QuerytypeVertextimings = 0xF,
        [Obsolete("Deprecated in favour of \"Pixeltimings\"")]
        [NativeName("Name", "D3DQUERYTYPE_PIXELTIMINGS")]
        QuerytypePixeltimings = 0x10,
        [Obsolete("Deprecated in favour of \"Bandwidthtimings\"")]
        [NativeName("Name", "D3DQUERYTYPE_BANDWIDTHTIMINGS")]
        QuerytypeBandwidthtimings = 0x11,
        [Obsolete("Deprecated in favour of \"Cacheutilization\"")]
        [NativeName("Name", "D3DQUERYTYPE_CACHEUTILIZATION")]
        QuerytypeCacheutilization = 0x12,
        [Obsolete("Deprecated in favour of \"Memorypressure\"")]
        [NativeName("Name", "D3DQUERYTYPE_MEMORYPRESSURE")]
        QuerytypeMemorypressure = 0x13,
        [NativeName("Name", "D3DQUERYTYPE_VCACHE")]
        Vcache = 0x4,
        [NativeName("Name", "D3DQUERYTYPE_RESOURCEMANAGER")]
        Resourcemanager = 0x5,
        [NativeName("Name", "D3DQUERYTYPE_VERTEXSTATS")]
        Vertexstats = 0x6,
        [NativeName("Name", "D3DQUERYTYPE_EVENT")]
        Event = 0x8,
        [NativeName("Name", "D3DQUERYTYPE_OCCLUSION")]
        Occlusion = 0x9,
        [NativeName("Name", "D3DQUERYTYPE_TIMESTAMP")]
        Timestamp = 0xA,
        [NativeName("Name", "D3DQUERYTYPE_TIMESTAMPDISJOINT")]
        Timestampdisjoint = 0xB,
        [NativeName("Name", "D3DQUERYTYPE_TIMESTAMPFREQ")]
        Timestampfreq = 0xC,
        [NativeName("Name", "D3DQUERYTYPE_PIPELINETIMINGS")]
        Pipelinetimings = 0xD,
        [NativeName("Name", "D3DQUERYTYPE_INTERFACETIMINGS")]
        Interfacetimings = 0xE,
        [NativeName("Name", "D3DQUERYTYPE_VERTEXTIMINGS")]
        Vertextimings = 0xF,
        [NativeName("Name", "D3DQUERYTYPE_PIXELTIMINGS")]
        Pixeltimings = 0x10,
        [NativeName("Name", "D3DQUERYTYPE_BANDWIDTHTIMINGS")]
        Bandwidthtimings = 0x11,
        [NativeName("Name", "D3DQUERYTYPE_CACHEUTILIZATION")]
        Cacheutilization = 0x12,
        [NativeName("Name", "D3DQUERYTYPE_MEMORYPRESSURE")]
        Memorypressure = 0x13,
    }
}
