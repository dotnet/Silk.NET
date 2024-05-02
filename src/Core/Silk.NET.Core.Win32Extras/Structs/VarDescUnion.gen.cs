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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_oaidl_L880_C36")]
    public unsafe partial struct VarDescUnion
    {
        public VarDescUnion
        (
            uint? oInst = null,
            Variant* lpvarValue = null
        ) : this()
        {
            if (oInst is not null)
            {
                OInst = oInst.Value;
            }

            if (lpvarValue is not null)
            {
                LpvarValue = lpvarValue;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "oInst")]
        public uint OInst;

        [FieldOffset(0)]
        [NativeName("Type", "VARIANT *")]
        [NativeName("Type.Name", "VARIANT *")]
        [NativeName("Name", "lpvarValue")]
        public Variant* LpvarValue;
    }
}
