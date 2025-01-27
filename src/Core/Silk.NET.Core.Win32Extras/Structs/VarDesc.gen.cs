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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "tagVARDESC")]
    public unsafe partial struct VarDesc
    {
        public VarDesc
        (
            int? memid = null,
            char* lpstrSchema = null,
            VarDescUnion? anonymous = null,
            ElemDesc? elemdescVar = null,
            ushort? wVarFlags = null,
            VarKind? varkind = null,
            uint? oInst = null,
            Variant* lpvarValue = null
        ) : this()
        {
            if (memid is not null)
            {
                Memid = memid.Value;
            }

            if (lpstrSchema is not null)
            {
                LpstrSchema = lpstrSchema;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (elemdescVar is not null)
            {
                ElemdescVar = elemdescVar.Value;
            }

            if (wVarFlags is not null)
            {
                WVarFlags = wVarFlags.Value;
            }

            if (varkind is not null)
            {
                Varkind = varkind.Value;
            }

            if (oInst is not null)
            {
                OInst = oInst.Value;
            }

            if (lpvarValue is not null)
            {
                LpvarValue = lpvarValue;
            }
        }


        [NativeName("Type", "MEMBERID")]
        [NativeName("Type.Name", "MEMBERID")]
        [NativeName("Name", "memid")]
        public int Memid;

        [NativeName("Type", "LPOLESTR")]
        [NativeName("Type.Name", "LPOLESTR")]
        [NativeName("Name", "lpstrSchema")]
        public char* LpstrSchema;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_oaidl_L880_C36")]
        [NativeName("Name", "anonymous1")]
        public VarDescUnion Anonymous;

        [NativeName("Type", "ELEMDESC")]
        [NativeName("Type.Name", "ELEMDESC")]
        [NativeName("Name", "elemdescVar")]
        public ElemDesc ElemdescVar;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wVarFlags")]
        public ushort WVarFlags;

        [NativeName("Type", "VARKIND")]
        [NativeName("Type.Name", "VARKIND")]
        [NativeName("Name", "varkind")]
        public VarKind Varkind;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint OInst
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].OInst;
        }
#else
        public uint OInst
        {
            get => Anonymous.OInst;
            set => Anonymous.OInst = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Variant* LpvarValue
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].LpvarValue;
        }
#else
        public Variant* LpvarValue
        {
            get => Anonymous.LpvarValue;
            set => Anonymous.LpvarValue = value;
        }
#endif

    }
}
