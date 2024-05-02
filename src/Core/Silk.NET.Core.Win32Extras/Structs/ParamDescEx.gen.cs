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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagPARAMDESCEX")]
    public unsafe partial struct ParamDescEx
    {
        public ParamDescEx
        (
            uint? cBytes = null,
            Variant? varDefaultValue = null
        ) : this()
        {
            if (cBytes is not null)
            {
                CBytes = cBytes.Value;
            }

            if (varDefaultValue is not null)
            {
                VarDefaultValue = varDefaultValue.Value;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cBytes")]
        public uint CBytes;

        [NativeName("Type", "VARIANTARG")]
        [NativeName("Type.Name", "VARIANTARG")]
        [NativeName("Name", "varDefaultValue")]
        public Variant VarDefaultValue;
    }
}
