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
    [NativeName("Name", "tagFUNCDESC")]
    public unsafe partial struct FuncDesc
    {
        public FuncDesc
        (
            int? memid = null,
            int* lprgscode = null,
            ElemDesc* lprgelemdescParam = null,
            FuncKind? funckind = null,
            InvokeKind? invkind = null,
            CallConv? callconv = null,
            short? cParams = null,
            short? cParamsOpt = null,
            short? oVft = null,
            short? cScodes = null,
            ElemDesc? elemdescFunc = null,
            ushort? wFuncFlags = null
        ) : this()
        {
            if (memid is not null)
            {
                Memid = memid.Value;
            }

            if (lprgscode is not null)
            {
                Lprgscode = lprgscode;
            }

            if (lprgelemdescParam is not null)
            {
                LprgelemdescParam = lprgelemdescParam;
            }

            if (funckind is not null)
            {
                Funckind = funckind.Value;
            }

            if (invkind is not null)
            {
                Invkind = invkind.Value;
            }

            if (callconv is not null)
            {
                Callconv = callconv.Value;
            }

            if (cParams is not null)
            {
                CParams = cParams.Value;
            }

            if (cParamsOpt is not null)
            {
                CParamsOpt = cParamsOpt.Value;
            }

            if (oVft is not null)
            {
                OVft = oVft.Value;
            }

            if (cScodes is not null)
            {
                CScodes = cScodes.Value;
            }

            if (elemdescFunc is not null)
            {
                ElemdescFunc = elemdescFunc.Value;
            }

            if (wFuncFlags is not null)
            {
                WFuncFlags = wFuncFlags.Value;
            }
        }


        [NativeName("Type", "MEMBERID")]
        [NativeName("Type.Name", "MEMBERID")]
        [NativeName("Name", "memid")]
        public int Memid;

        [NativeName("Type", "SCODE *")]
        [NativeName("Type.Name", "SCODE *")]
        [NativeName("Name", "lprgscode")]
        public int* Lprgscode;

        [NativeName("Type", "ELEMDESC *")]
        [NativeName("Type.Name", "ELEMDESC *")]
        [NativeName("Name", "lprgelemdescParam")]
        public ElemDesc* LprgelemdescParam;

        [NativeName("Type", "FUNCKIND")]
        [NativeName("Type.Name", "FUNCKIND")]
        [NativeName("Name", "funckind")]
        public FuncKind Funckind;

        [NativeName("Type", "INVOKEKIND")]
        [NativeName("Type.Name", "INVOKEKIND")]
        [NativeName("Name", "invkind")]
        public InvokeKind Invkind;

        [NativeName("Type", "CALLCONV")]
        [NativeName("Type.Name", "CALLCONV")]
        [NativeName("Name", "callconv")]
        public CallConv Callconv;

        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "cParams")]
        public short CParams;

        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "cParamsOpt")]
        public short CParamsOpt;

        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "oVft")]
        public short OVft;

        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "cScodes")]
        public short CScodes;

        [NativeName("Type", "ELEMDESC")]
        [NativeName("Type.Name", "ELEMDESC")]
        [NativeName("Name", "elemdescFunc")]
        public ElemDesc ElemdescFunc;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wFuncFlags")]
        public ushort WFuncFlags;
    }
}
