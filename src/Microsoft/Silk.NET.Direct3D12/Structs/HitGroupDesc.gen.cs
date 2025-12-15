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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "D3D12_HIT_GROUP_DESC")]
    public unsafe partial struct HitGroupDesc
    {
        public HitGroupDesc
        (
            char* hitGroupExport = null,
            HitGroupType? type = null,
            char* anyHitShaderImport = null,
            char* closestHitShaderImport = null,
            char* intersectionShaderImport = null
        ) : this()
        {
            if (hitGroupExport is not null)
            {
                HitGroupExport = hitGroupExport;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (anyHitShaderImport is not null)
            {
                AnyHitShaderImport = anyHitShaderImport;
            }

            if (closestHitShaderImport is not null)
            {
                ClosestHitShaderImport = closestHitShaderImport;
            }

            if (intersectionShaderImport is not null)
            {
                IntersectionShaderImport = intersectionShaderImport;
            }
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
