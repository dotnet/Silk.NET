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
    [NativeName("Name", "ExceptionInfo")]
    public unsafe partial struct ExceptionInfo
    {
        public ExceptionInfo
        (
            ushort? wCode = null,
            ushort? wReserved = null,
            char* bstrSource = null,
            char* bstrDescription = null,
            char* bstrHelpFile = null,
            uint? dwHelpContext = null,
            void* pvReserved = null,
            PfnExceptionInfovI? pfnDeferredFillIn = null,
            int? scode = null
        ) : this()
        {
            if (wCode is not null)
            {
                WCode = wCode.Value;
            }

            if (wReserved is not null)
            {
                WReserved = wReserved.Value;
            }

            if (bstrSource is not null)
            {
                BstrSource = bstrSource;
            }

            if (bstrDescription is not null)
            {
                BstrDescription = bstrDescription;
            }

            if (bstrHelpFile is not null)
            {
                BstrHelpFile = bstrHelpFile;
            }

            if (dwHelpContext is not null)
            {
                DwHelpContext = dwHelpContext.Value;
            }

            if (pvReserved is not null)
            {
                PvReserved = pvReserved;
            }

            if (pfnDeferredFillIn is not null)
            {
                PfnDeferredFillIn = pfnDeferredFillIn.Value;
            }

            if (scode is not null)
            {
                Scode = scode.Value;
            }
        }


        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wCode")]
        public ushort WCode;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wReserved")]
        public ushort WReserved;

        [NativeName("Type", "BSTR")]
        [NativeName("Type.Name", "BSTR")]
        [NativeName("Name", "bstrSource")]
        public char* BstrSource;

        [NativeName("Type", "BSTR")]
        [NativeName("Type.Name", "BSTR")]
        [NativeName("Name", "bstrDescription")]
        public char* BstrDescription;

        [NativeName("Type", "BSTR")]
        [NativeName("Type.Name", "BSTR")]
        [NativeName("Name", "bstrHelpFile")]
        public char* BstrHelpFile;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwHelpContext")]
        public uint DwHelpContext;

        [NativeName("Type", "PVOID")]
        [NativeName("Type.Name", "PVOID")]
        [NativeName("Name", "pvReserved")]
        public void* PvReserved;

        [NativeName("Type", "HRESULT (*)(struct ExceptionInfo *) __attribute__((stdcall))")]
        [NativeName("Type.Name", "HRESULT (*)(struct ExceptionInfo *) __attribute__((stdcall))")]
        [NativeName("Name", "pfnDeferredFillIn")]
        public PfnExceptionInfovI PfnDeferredFillIn;

        [NativeName("Type", "SCODE")]
        [NativeName("Type.Name", "SCODE")]
        [NativeName("Name", "scode")]
        public int Scode;
    }
}
