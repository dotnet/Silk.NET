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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEVINFO_VCACHE")]
    public unsafe partial struct DevinfoVcache
    {
        public DevinfoVcache
        (
            int? pattern = null,
            int? optMethod = null,
            int? cacheSize = null,
            int? magicNumber = null
        ) : this()
        {
            if (pattern is not null)
            {
                Pattern = pattern.Value;
            }

            if (optMethod is not null)
            {
                OptMethod = optMethod.Value;
            }

            if (cacheSize is not null)
            {
                CacheSize = cacheSize.Value;
            }

            if (magicNumber is not null)
            {
                MagicNumber = magicNumber.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Pattern")]
        public int Pattern;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "OptMethod")]
        public int OptMethod;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "CacheSize")]
        public int CacheSize;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MagicNumber")]
        public int MagicNumber;
    }
}
