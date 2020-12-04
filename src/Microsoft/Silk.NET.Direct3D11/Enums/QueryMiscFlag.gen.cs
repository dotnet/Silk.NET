// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_QUERY_MISC_FLAG")]
    public enum QueryMiscFlag
    {
        [NativeName("Name", "D3D11_QUERY_MISC_PREDICATEHINT")]
        QueryMiscPredicatehint = 0x1,
    }
}
