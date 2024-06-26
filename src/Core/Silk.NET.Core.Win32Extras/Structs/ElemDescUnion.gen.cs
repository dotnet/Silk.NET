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
    [NativeName("Name", "__AnonymousRecord_oaidl_L733_C5")]
    public unsafe partial struct ElemDescUnion
    {
        public ElemDescUnion
        (
            IdlDesc? idldesc = null,
            ParamDesc? paramdesc = null
        ) : this()
        {
            if (idldesc is not null)
            {
                Idldesc = idldesc.Value;
            }

            if (paramdesc is not null)
            {
                Paramdesc = paramdesc.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "IDLDESC")]
        [NativeName("Type.Name", "IDLDESC")]
        [NativeName("Name", "idldesc")]
        public IdlDesc Idldesc;

        [FieldOffset(0)]
        [NativeName("Type", "PARAMDESC")]
        [NativeName("Type.Name", "PARAMDESC")]
        [NativeName("Name", "paramdesc")]
        public ParamDesc Paramdesc;
    }
}
