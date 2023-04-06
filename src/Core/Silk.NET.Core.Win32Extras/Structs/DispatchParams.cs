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
    [NativeName("Name", "DispatchParams")]
    public unsafe partial struct DispatchParams
    {
        public DispatchParams
        (
            Variant* rgvarg = null,
            int* rgdispidNamedArgs = null,
            uint? cArgs = null,
            uint? cNamedArgs = null
        ) : this()
        {
            if (rgvarg is not null)
            {
                Rgvarg = rgvarg;
            }

            if (rgdispidNamedArgs is not null)
            {
                RgdispidNamedArgs = rgdispidNamedArgs;
            }

            if (cArgs is not null)
            {
                CArgs = cArgs.Value;
            }

            if (cNamedArgs is not null)
            {
                CNamedArgs = cNamedArgs.Value;
            }
        }


        [NativeName("Type", "VARIANTARG *")]
        [NativeName("Type.Name", "VARIANTARG *")]
        [NativeName("Name", "rgvarg")]
        public Variant* Rgvarg;

        [NativeName("Type", "DISPID *")]
        [NativeName("Type.Name", "DISPID *")]
        [NativeName("Name", "rgdispidNamedArgs")]
        public int* RgdispidNamedArgs;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cArgs")]
        public uint CArgs;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cNamedArgs")]
        public uint CNamedArgs;
    }
}
