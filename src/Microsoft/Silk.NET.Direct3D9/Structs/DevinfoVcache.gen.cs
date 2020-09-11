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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DDEVINFO_VCACHE")]
    public unsafe partial struct DevinfoVcache
    {
        public DevinfoVcache
        (
            uint pattern = default,
            uint optMethod = default,
            uint cacheSize = default,
            uint magicNumber = default
        )
        {
            Pattern = pattern;
            OptMethod = optMethod;
            CacheSize = cacheSize;
            MagicNumber = magicNumber;
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Pattern")]
        public uint Pattern;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "OptMethod")]
        public uint OptMethod;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "CacheSize")]
        public uint CacheSize;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MagicNumber")]
        public uint MagicNumber;
    }
}
