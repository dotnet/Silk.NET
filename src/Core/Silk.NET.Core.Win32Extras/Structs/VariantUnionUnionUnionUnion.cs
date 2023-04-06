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
    [NativeName("Name", "__AnonymousRecord_oaidl_L533_C17")]
    public unsafe partial struct VariantUnionUnionUnionUnion
    {
        public VariantUnionUnionUnionUnion
        (
            void* pvRecord = null,
            Silk.NET.Core.Native.IUnknown* pRecInfo = null
        ) : this()
        {
            if (pvRecord is not null)
            {
                PvRecord = pvRecord;
            }

            if (pRecInfo is not null)
            {
                PRecInfo = pRecInfo;
            }
        }


        [NativeName("Type", "PVOID")]
        [NativeName("Type.Name", "PVOID")]
        [NativeName("Name", "pvRecord")]
        public void* PvRecord;

        [NativeName("Type", "Silk.NET.Core.Native.IUnknown *")]
        [NativeName("Type.Name", "Silk.NET.Core.Native.IUnknown *")]
        [NativeName("Name", "pRecInfo")]
        public Silk.NET.Core.Native.IUnknown* PRecInfo;
    }
}
