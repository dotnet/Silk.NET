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
    [NativeName("Name", "D3D12_HIT_GROUP_DESC")]
    public unsafe partial struct HitGroupDesc
    {
        public HitGroupDesc
        (
            char* hitGroupExport = default,
            HitGroupType type = default,
            char* anyHitShaderImport = default,
            char* closestHitShaderImport = default,
            char* intersectionShaderImport = default
        )
        {
            HitGroupExport = hitGroupExport;
            Type = type;
            AnyHitShaderImport = anyHitShaderImport;
            ClosestHitShaderImport = closestHitShaderImport;
            IntersectionShaderImport = intersectionShaderImport;
        }


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "HitGroupExport")]
        public char* HitGroupExport;

        [NativeName("Type", "D3D12_HIT_GROUP_TYPE")]
        [NativeName("Type.Name", "D3D12_HIT_GROUP_TYPE")]
        [NativeName("Name", "Type")]
        public HitGroupType Type;

        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "AnyHitShaderImport")]
        public char* AnyHitShaderImport;

        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "ClosestHitShaderImport")]
        public char* ClosestHitShaderImport;

        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "IntersectionShaderImport")]
        public char* IntersectionShaderImport;
    }
}
