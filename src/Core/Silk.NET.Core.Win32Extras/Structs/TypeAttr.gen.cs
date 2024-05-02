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
    [NativeName("Name", "tagTYPEATTR")]
    public unsafe partial struct TypeAttr
    {
        public TypeAttr
        (
            Guid? guid = null,
            uint? lcid = null,
            uint? dwReserved = null,
            int? memidConstructor = null,
            int? memidDestructor = null,
            char* lpstrSchema = null,
            uint? cbSizeInstance = null,
            TypeKind? typekind = null,
            ushort? cFuncs = null,
            ushort? cVars = null,
            ushort? cImplTypes = null,
            ushort? cbSizeVft = null,
            ushort? cbAlignment = null,
            ushort? wTypeFlags = null,
            ushort? wMajorVerNum = null,
            ushort? wMinorVerNum = null,
            TypeDesc? tdescAlias = null,
            IdlDesc? idldescType = null
        ) : this()
        {
            if (guid is not null)
            {
                Guid = guid.Value;
            }

            if (lcid is not null)
            {
                Lcid = lcid.Value;
            }

            if (dwReserved is not null)
            {
                DwReserved = dwReserved.Value;
            }

            if (memidConstructor is not null)
            {
                MemidConstructor = memidConstructor.Value;
            }

            if (memidDestructor is not null)
            {
                MemidDestructor = memidDestructor.Value;
            }

            if (lpstrSchema is not null)
            {
                LpstrSchema = lpstrSchema;
            }

            if (cbSizeInstance is not null)
            {
                CbSizeInstance = cbSizeInstance.Value;
            }

            if (typekind is not null)
            {
                Typekind = typekind.Value;
            }

            if (cFuncs is not null)
            {
                CFuncs = cFuncs.Value;
            }

            if (cVars is not null)
            {
                CVars = cVars.Value;
            }

            if (cImplTypes is not null)
            {
                CImplTypes = cImplTypes.Value;
            }

            if (cbSizeVft is not null)
            {
                CbSizeVft = cbSizeVft.Value;
            }

            if (cbAlignment is not null)
            {
                CbAlignment = cbAlignment.Value;
            }

            if (wTypeFlags is not null)
            {
                WTypeFlags = wTypeFlags.Value;
            }

            if (wMajorVerNum is not null)
            {
                WMajorVerNum = wMajorVerNum.Value;
            }

            if (wMinorVerNum is not null)
            {
                WMinorVerNum = wMinorVerNum.Value;
            }

            if (tdescAlias is not null)
            {
                TdescAlias = tdescAlias.Value;
            }

            if (idldescType is not null)
            {
                IdldescType = idldescType.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "guid")]
        public Guid Guid;

        [NativeName("Type", "LCID")]
        [NativeName("Type.Name", "LCID")]
        [NativeName("Name", "lcid")]
        public uint Lcid;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwReserved")]
        public uint DwReserved;

        [NativeName("Type", "MEMBERID")]
        [NativeName("Type.Name", "MEMBERID")]
        [NativeName("Name", "memidConstructor")]
        public int MemidConstructor;

        [NativeName("Type", "MEMBERID")]
        [NativeName("Type.Name", "MEMBERID")]
        [NativeName("Name", "memidDestructor")]
        public int MemidDestructor;

        [NativeName("Type", "LPOLESTR")]
        [NativeName("Type.Name", "LPOLESTR")]
        [NativeName("Name", "lpstrSchema")]
        public char* LpstrSchema;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "cbSizeInstance")]
        public uint CbSizeInstance;

        [NativeName("Type", "TYPEKIND")]
        [NativeName("Type.Name", "TYPEKIND")]
        [NativeName("Name", "typekind")]
        public TypeKind Typekind;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "cFuncs")]
        public ushort CFuncs;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "cVars")]
        public ushort CVars;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "cImplTypes")]
        public ushort CImplTypes;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "cbSizeVft")]
        public ushort CbSizeVft;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "cbAlignment")]
        public ushort CbAlignment;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wTypeFlags")]
        public ushort WTypeFlags;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wMajorVerNum")]
        public ushort WMajorVerNum;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wMinorVerNum")]
        public ushort WMinorVerNum;

        [NativeName("Type", "TYPEDESC")]
        [NativeName("Type.Name", "TYPEDESC")]
        [NativeName("Name", "tdescAlias")]
        public TypeDesc TdescAlias;

        [NativeName("Type", "IDLDESC")]
        [NativeName("Type.Name", "IDLDESC")]
        [NativeName("Name", "idldescType")]
        public IdlDesc IdldescType;
    }
}
