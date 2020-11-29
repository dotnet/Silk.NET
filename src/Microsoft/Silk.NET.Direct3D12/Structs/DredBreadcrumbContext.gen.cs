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
    [NativeName("Name", "D3D12_DRED_BREADCRUMB_CONTEXT")]
    public unsafe partial struct DredBreadcrumbContext
    {
        public DredBreadcrumbContext
        (
            uint? breadcrumbIndex = null,
            char* pContextString = null
        ) : this()
        {
            if (breadcrumbIndex is not null)
            {
                BreadcrumbIndex = breadcrumbIndex.Value;
            }

            if (pContextString is not null)
            {
                PContextString = pContextString;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BreadcrumbIndex")]
        public uint BreadcrumbIndex;

        [NativeName("Type", "const wchar_t *")]
        [NativeName("Type.Name", "const wchar_t *")]
        [NativeName("Name", "pContextString")]
        public char* PContextString;
    }
}
