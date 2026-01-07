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

namespace Silk.NET.Core.Native
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "D3D_SHADER_CACHE_APPLICATION_DESC")]
    public unsafe partial struct D3DShaderCacheApplicationDesc
    {
        public D3DShaderCacheApplicationDesc
        (
            char* pExeFilename = null,
            char* pName = null,
            D3DVersionNumber? version = null,
            char* pEngineName = null,
            D3DVersionNumber? engineVersion = null
        ) : this()
        {
            if (pExeFilename is not null)
            {
                PExeFilename = pExeFilename;
            }

            if (pName is not null)
            {
                PName = pName;
            }

            if (version is not null)
            {
                Version = version.Value;
            }

            if (pEngineName is not null)
            {
                PEngineName = pEngineName;
            }

            if (engineVersion is not null)
            {
                EngineVersion = engineVersion.Value;
            }
        }


        [NativeName("Type", "const wchar_t *")]
        [NativeName("Type.Name", "const wchar_t *")]
        [NativeName("Name", "pExeFilename")]
        public char* PExeFilename;

        [NativeName("Type", "const wchar_t *")]
        [NativeName("Type.Name", "const wchar_t *")]
        [NativeName("Name", "pName")]
        public char* PName;

        [NativeName("Type", "D3D_VERSION_NUMBER")]
        [NativeName("Type.Name", "D3D_VERSION_NUMBER")]
        [NativeName("Name", "Version")]
        public D3DVersionNumber Version;

        [NativeName("Type", "const wchar_t *")]
        [NativeName("Type.Name", "const wchar_t *")]
        [NativeName("Name", "pEngineName")]
        public char* PEngineName;

        [NativeName("Type", "D3D_VERSION_NUMBER")]
        [NativeName("Type.Name", "D3D_VERSION_NUMBER")]
        [NativeName("Name", "EngineVersion")]
        public D3DVersionNumber EngineVersion;
    }
}
