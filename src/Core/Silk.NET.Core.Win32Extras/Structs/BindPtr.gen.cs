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
    [NativeName("Name", "tagBINDPTR")]
    public unsafe partial struct BindPtr
    {
        public BindPtr
        (
            FuncDesc* lpfuncdesc = null,
            VarDesc* lpvardesc = null,
            ITypeComp* lptcomp = null
        ) : this()
        {
            if (lpfuncdesc is not null)
            {
                Lpfuncdesc = lpfuncdesc;
            }

            if (lpvardesc is not null)
            {
                Lpvardesc = lpvardesc;
            }

            if (lptcomp is not null)
            {
                Lptcomp = lptcomp;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "FUNCDESC *")]
        [NativeName("Type.Name", "FUNCDESC *")]
        [NativeName("Name", "lpfuncdesc")]
        public FuncDesc* Lpfuncdesc;

        [FieldOffset(0)]
        [NativeName("Type", "VARDESC *")]
        [NativeName("Type.Name", "VARDESC *")]
        [NativeName("Name", "lpvardesc")]
        public VarDesc* Lpvardesc;

        [FieldOffset(0)]
        [NativeName("Type", "ITypeComp *")]
        [NativeName("Type.Name", "ITypeComp *")]
        [NativeName("Name", "lptcomp")]
        public ITypeComp* Lptcomp;
    }
}
