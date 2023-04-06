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
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    [NativeName("Name", "__AnonymousRecord_oaidl_L486_C13")]
    public unsafe partial struct VariantUnionUnionUnion
    {
        public VariantUnionUnionUnion
        (
            long? llVal = null,
            int? lVal = null,
            byte? bVal = null,
            short? iVal = null,
            float? fltVal = null,
            double? dblVal = null,
            short? boolVal = null,
            short? oBSOLETEVARIANTBOOL = null,
            int? scode = null,
            TagDecimal? cyVal = null,
            double? date = null,
            char* bstrVal = null,
            Silk.NET.Core.Native.IUnknown* punkVal = null,
            Silk.NET.Core.Native.IUnknown* pdispVal = null,
            SafeArray* parray = null,
            byte* pbVal = null,
            short* piVal = null,
            int* plVal = null,
            long* pllVal = null,
            float* pfltVal = null,
            double* pdblVal = null,
            short* pboolVal = null,
            short* oBSOLETEVARIANTPBOOL = null,
            int* pscode = null,
            TagDecimal* pcyVal = null,
            double* pdate = null,
            char** pbstrVal = null,
            Silk.NET.Core.Native.IUnknown** ppunkVal = null,
            Silk.NET.Core.Native.IUnknown** ppdispVal = null,
            SafeArray** pparray = null,
            Variant* pvarVal = null,
            void* byref = null,
            byte? cVal = null,
            ushort? uiVal = null,
            uint? ulVal = null,
            ulong? ullVal = null,
            int? intVal = null,
            uint? uintVal = null,
            TagDecimal* pdecVal = null,
            byte* pcVal = null,
            ushort* puiVal = null,
            uint* pulVal = null,
            ulong* pullVal = null,
            int* pintVal = null,
            uint* puintVal = null,
            VariantUnionUnionUnionUnion? anonymous = null,
            void* pvRecord = null,
            Silk.NET.Core.Native.IUnknown* pRecInfo = null
        ) : this()
        {
            if (llVal is not null)
            {
                LlVal = llVal.Value;
            }

            if (lVal is not null)
            {
                LVal = lVal.Value;
            }

            if (bVal is not null)
            {
                BVal = bVal.Value;
            }

            if (iVal is not null)
            {
                IVal = iVal.Value;
            }

            if (fltVal is not null)
            {
                FltVal = fltVal.Value;
            }

            if (dblVal is not null)
            {
                DblVal = dblVal.Value;
            }

            if (boolVal is not null)
            {
                BoolVal = boolVal.Value;
            }

            if (oBSOLETEVARIANTBOOL is not null)
            {
                OBSOLETEVARIANTBOOL = oBSOLETEVARIANTBOOL.Value;
            }

            if (scode is not null)
            {
                Scode = scode.Value;
            }

            if (cyVal is not null)
            {
                CyVal = cyVal.Value;
            }

            if (date is not null)
            {
                Date = date.Value;
            }

            if (bstrVal is not null)
            {
                BstrVal = bstrVal;
            }

            if (punkVal is not null)
            {
                PunkVal = punkVal;
            }

            if (pdispVal is not null)
            {
                PdispVal = pdispVal;
            }

            if (parray is not null)
            {
                Parray = parray;
            }

            if (pbVal is not null)
            {
                PbVal = pbVal;
            }

            if (piVal is not null)
            {
                PiVal = piVal;
            }

            if (plVal is not null)
            {
                PlVal = plVal;
            }

            if (pllVal is not null)
            {
                PllVal = pllVal;
            }

            if (pfltVal is not null)
            {
                PfltVal = pfltVal;
            }

            if (pdblVal is not null)
            {
                PdblVal = pdblVal;
            }

            if (pboolVal is not null)
            {
                PboolVal = pboolVal;
            }

            if (oBSOLETEVARIANTPBOOL is not null)
            {
                OBSOLETEVARIANTPBOOL = oBSOLETEVARIANTPBOOL;
            }

            if (pscode is not null)
            {
                Pscode = pscode;
            }

            if (pcyVal is not null)
            {
                PcyVal = pcyVal;
            }

            if (pdate is not null)
            {
                Pdate = pdate;
            }

            if (pbstrVal is not null)
            {
                PbstrVal = pbstrVal;
            }

            if (ppunkVal is not null)
            {
                PpunkVal = ppunkVal;
            }

            if (ppdispVal is not null)
            {
                PpdispVal = ppdispVal;
            }

            if (pparray is not null)
            {
                Pparray = pparray;
            }

            if (pvarVal is not null)
            {
                PvarVal = pvarVal;
            }

            if (byref is not null)
            {
                Byref = byref;
            }

            if (cVal is not null)
            {
                CVal = cVal.Value;
            }

            if (uiVal is not null)
            {
                UiVal = uiVal.Value;
            }

            if (ulVal is not null)
            {
                UlVal = ulVal.Value;
            }

            if (ullVal is not null)
            {
                UllVal = ullVal.Value;
            }

            if (intVal is not null)
            {
                IntVal = intVal.Value;
            }

            if (uintVal is not null)
            {
                UintVal = uintVal.Value;
            }

            if (pdecVal is not null)
            {
                PdecVal = pdecVal;
            }

            if (pcVal is not null)
            {
                PcVal = pcVal;
            }

            if (puiVal is not null)
            {
                PuiVal = puiVal;
            }

            if (pulVal is not null)
            {
                PulVal = pulVal;
            }

            if (pullVal is not null)
            {
                PullVal = pullVal;
            }

            if (pintVal is not null)
            {
                PintVal = pintVal;
            }

            if (puintVal is not null)
            {
                PuintVal = puintVal;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (pvRecord is not null)
            {
                PvRecord = pvRecord;
            }

            if (pRecInfo is not null)
            {
                PRecInfo = pRecInfo;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "LONGLONG")]
        [NativeName("Type.Name", "LONGLONG")]
        [NativeName("Name", "llVal")]
        public long LlVal;

        [FieldOffset(0)]
        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "lVal")]
        public int LVal;

        [FieldOffset(0)]
        [NativeName("Type", "BYTE")]
        [NativeName("Type.Name", "BYTE")]
        [NativeName("Name", "bVal")]
        public byte BVal;

        [FieldOffset(0)]
        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "iVal")]
        public short IVal;

        [FieldOffset(0)]
        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "fltVal")]
        public float FltVal;

        [FieldOffset(0)]
        [NativeName("Type", "DOUBLE")]
        [NativeName("Type.Name", "DOUBLE")]
        [NativeName("Name", "dblVal")]
        public double DblVal;

        [FieldOffset(0)]
        [NativeName("Type", "VARIANT_BOOL")]
        [NativeName("Type.Name", "VARIANT_BOOL")]
        [NativeName("Name", "boolVal")]
        public short BoolVal;

        [FieldOffset(0)]
        [NativeName("Type", "VARIANT_BOOL")]
        [NativeName("Type.Name", "VARIANT_BOOL")]
        [NativeName("Name", "__OBSOLETE__VARIANT_BOOL")]
        public short OBSOLETEVARIANTBOOL;

        [FieldOffset(0)]
        [NativeName("Type", "SCODE")]
        [NativeName("Type.Name", "SCODE")]
        [NativeName("Name", "scode")]
        public int Scode;

        [FieldOffset(0)]
        [NativeName("Type", "CY")]
        [NativeName("Type.Name", "CY")]
        [NativeName("Name", "cyVal")]
        public TagDecimal CyVal;

        [FieldOffset(0)]
        [NativeName("Type", "DATE")]
        [NativeName("Type.Name", "DATE")]
        [NativeName("Name", "date")]
        public double Date;

        [FieldOffset(0)]
        [NativeName("Type", "BSTR")]
        [NativeName("Type.Name", "BSTR")]
        [NativeName("Name", "bstrVal")]
        public char* BstrVal;

        [FieldOffset(0)]
        [NativeName("Type", "IUnknown *")]
        [NativeName("Type.Name", "IUnknown *")]
        [NativeName("Name", "punkVal")]
        public Silk.NET.Core.Native.IUnknown* PunkVal;

        [FieldOffset(0)]
        [NativeName("Type", "Silk.NET.Core.Native.IUnknown *")]
        [NativeName("Type.Name", "Silk.NET.Core.Native.IUnknown *")]
        [NativeName("Name", "pdispVal")]
        public Silk.NET.Core.Native.IUnknown* PdispVal;

        [FieldOffset(0)]
        [NativeName("Type", "SAFEARRAY *")]
        [NativeName("Type.Name", "SAFEARRAY *")]
        [NativeName("Name", "parray")]
        public SafeArray* Parray;

        [FieldOffset(0)]
        [NativeName("Type", "BYTE *")]
        [NativeName("Type.Name", "BYTE *")]
        [NativeName("Name", "pbVal")]
        public byte* PbVal;

        [FieldOffset(0)]
        [NativeName("Type", "SHORT *")]
        [NativeName("Type.Name", "SHORT *")]
        [NativeName("Name", "piVal")]
        public short* PiVal;

        [FieldOffset(0)]
        [NativeName("Type", "LONG *")]
        [NativeName("Type.Name", "LONG *")]
        [NativeName("Name", "plVal")]
        public int* PlVal;

        [FieldOffset(0)]
        [NativeName("Type", "LONGLONG *")]
        [NativeName("Type.Name", "LONGLONG *")]
        [NativeName("Name", "pllVal")]
        public long* PllVal;

        [FieldOffset(0)]
        [NativeName("Type", "FLOAT *")]
        [NativeName("Type.Name", "FLOAT *")]
        [NativeName("Name", "pfltVal")]
        public float* PfltVal;

        [FieldOffset(0)]
        [NativeName("Type", "DOUBLE *")]
        [NativeName("Type.Name", "DOUBLE *")]
        [NativeName("Name", "pdblVal")]
        public double* PdblVal;

        [FieldOffset(0)]
        [NativeName("Type", "VARIANT_BOOL *")]
        [NativeName("Type.Name", "VARIANT_BOOL *")]
        [NativeName("Name", "pboolVal")]
        public short* PboolVal;

        [FieldOffset(0)]
        [NativeName("Type", "VARIANT_BOOL *")]
        [NativeName("Type.Name", "VARIANT_BOOL *")]
        [NativeName("Name", "__OBSOLETE__VARIANT_PBOOL")]
        public short* OBSOLETEVARIANTPBOOL;

        [FieldOffset(0)]
        [NativeName("Type", "SCODE *")]
        [NativeName("Type.Name", "SCODE *")]
        [NativeName("Name", "pscode")]
        public int* Pscode;

        [FieldOffset(0)]
        [NativeName("Type", "CY *")]
        [NativeName("Type.Name", "CY *")]
        [NativeName("Name", "pcyVal")]
        public TagDecimal* PcyVal;

        [FieldOffset(0)]
        [NativeName("Type", "DATE *")]
        [NativeName("Type.Name", "DATE *")]
        [NativeName("Name", "pdate")]
        public double* Pdate;

        [FieldOffset(0)]
        [NativeName("Type", "BSTR *")]
        [NativeName("Type.Name", "BSTR *")]
        [NativeName("Name", "pbstrVal")]
        public char** PbstrVal;

        [FieldOffset(0)]
        [NativeName("Type", "IUnknown **")]
        [NativeName("Type.Name", "IUnknown **")]
        [NativeName("Name", "ppunkVal")]
        public Silk.NET.Core.Native.IUnknown** PpunkVal;

        [FieldOffset(0)]
        [NativeName("Type", "Silk.NET.Core.Native.IUnknown **")]
        [NativeName("Type.Name", "Silk.NET.Core.Native.IUnknown **")]
        [NativeName("Name", "ppdispVal")]
        public Silk.NET.Core.Native.IUnknown** PpdispVal;

        [FieldOffset(0)]
        [NativeName("Type", "SAFEARRAY **")]
        [NativeName("Type.Name", "SAFEARRAY **")]
        [NativeName("Name", "pparray")]
        public SafeArray** Pparray;

        [FieldOffset(0)]
        [NativeName("Type", "VARIANT *")]
        [NativeName("Type.Name", "VARIANT *")]
        [NativeName("Name", "pvarVal")]
        public Variant* PvarVal;

        [FieldOffset(0)]
        [NativeName("Type", "PVOID")]
        [NativeName("Type.Name", "PVOID")]
        [NativeName("Name", "byref")]
        public void* Byref;

        [FieldOffset(0)]
        [NativeName("Type", "CHAR")]
        [NativeName("Type.Name", "CHAR")]
        [NativeName("Name", "cVal")]
        public byte CVal;

        [FieldOffset(0)]
        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "uiVal")]
        public ushort UiVal;

        [FieldOffset(0)]
        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ulVal")]
        public uint UlVal;

        [FieldOffset(0)]
        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "ullVal")]
        public ulong UllVal;

        [FieldOffset(0)]
        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "intVal")]
        public int IntVal;

        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "uintVal")]
        public uint UintVal;

        [FieldOffset(0)]
        [NativeName("Type", "DECIMAL *")]
        [NativeName("Type.Name", "DECIMAL *")]
        [NativeName("Name", "pdecVal")]
        public TagDecimal* PdecVal;

        [FieldOffset(0)]
        [NativeName("Type", "CHAR *")]
        [NativeName("Type.Name", "CHAR *")]
        [NativeName("Name", "pcVal")]
        public byte* PcVal;

        [FieldOffset(0)]
        [NativeName("Type", "USHORT *")]
        [NativeName("Type.Name", "USHORT *")]
        [NativeName("Name", "puiVal")]
        public ushort* PuiVal;

        [FieldOffset(0)]
        [NativeName("Type", "ULONG *")]
        [NativeName("Type.Name", "ULONG *")]
        [NativeName("Name", "pulVal")]
        public uint* PulVal;

        [FieldOffset(0)]
        [NativeName("Type", "ULONGLONG *")]
        [NativeName("Type.Name", "ULONGLONG *")]
        [NativeName("Name", "pullVal")]
        public ulong* PullVal;

        [FieldOffset(0)]
        [NativeName("Type", "INT *")]
        [NativeName("Type.Name", "INT *")]
        [NativeName("Name", "pintVal")]
        public int* PintVal;

        [FieldOffset(0)]
        [NativeName("Type", "UINT *")]
        [NativeName("Type.Name", "UINT *")]
        [NativeName("Name", "puintVal")]
        public uint* PuintVal;

        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_oaidl_L533_C17")]
        [NativeName("Name", "anonymous1")]
        public VariantUnionUnionUnionUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref void* PvRecord
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PvRecord;
        }
#else
        public void* PvRecord
        {
            get => Anonymous.PvRecord;
            set => Anonymous.PvRecord = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Silk.NET.Core.Native.IUnknown* PRecInfo
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PRecInfo;
        }
#else
        public Silk.NET.Core.Native.IUnknown* PRecInfo
        {
            get => Anonymous.PRecInfo;
            set => Anonymous.PRecInfo = value;
        }
#endif

    }
}
