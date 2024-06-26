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
    [NativeName("Name", "tagELEMDESC")]
    public unsafe partial struct ElemDesc
    {
        public ElemDesc
        (
            TypeDesc? tdesc = null,
            ElemDescUnion? anonymous = null,
            IdlDesc? idldesc = null,
            ParamDesc? paramdesc = null
        ) : this()
        {
            if (tdesc is not null)
            {
                Tdesc = tdesc.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (idldesc is not null)
            {
                Idldesc = idldesc.Value;
            }

            if (paramdesc is not null)
            {
                Paramdesc = paramdesc.Value;
            }
        }


        [NativeName("Type", "TYPEDESC")]
        [NativeName("Type.Name", "TYPEDESC")]
        [NativeName("Name", "tdesc")]
        public TypeDesc Tdesc;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_oaidl_L733_C5")]
        [NativeName("Name", "anonymous1")]
        public ElemDescUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref IdlDesc Idldesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Idldesc;
        }
#else
        public IdlDesc Idldesc
        {
            get => Anonymous.Idldesc;
            set => Anonymous.Idldesc = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ParamDesc Paramdesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Paramdesc;
        }
#else
        public ParamDesc Paramdesc
        {
            get => Anonymous.Paramdesc;
            set => Anonymous.Paramdesc = value;
        }
#endif

    }
}
