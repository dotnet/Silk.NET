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
    [NativeName("Name", "__AnonymousRecord_oaidl_L480_C9")]
    public unsafe partial struct VariantUnionUnion
    {
        public VariantUnionUnion
        (
            ushort? vt = null,
            ushort? wReserved1 = null,
            ushort? wReserved2 = null,
            ushort? wReserved3 = null,
            VariantUnionUnionUnion? anonymous = null,
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
            void* pvRecord = null,
            Silk.NET.Core.Native.IUnknown* pRecInfo = null
        ) : this()
        {
            if (vt is not null)
            {
                Vt = vt.Value;
            }

            if (wReserved1 is not null)
            {
                WReserved1 = wReserved1.Value;
            }

            if (wReserved2 is not null)
            {
                WReserved2 = wReserved2.Value;
            }

            if (wReserved3 is not null)
            {
                WReserved3 = wReserved3.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

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

            if (pvRecord is not null)
            {
                PvRecord = pvRecord;
            }

            if (pRecInfo is not null)
            {
                PRecInfo = pRecInfo;
            }
        }


        [NativeName("Type", "VARTYPE")]
        [NativeName("Type.Name", "VARTYPE")]
        [NativeName("Name", "vt")]
        public ushort Vt;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wReserved1")]
        public ushort WReserved1;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wReserved2")]
        public ushort WReserved2;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wReserved3")]
        public ushort WReserved3;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_oaidl_L486_C13")]
        [NativeName("Name", "anonymous1")]
        public VariantUnionUnionUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref long LlVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].LlVal;
        }
#else
        public long LlVal
        {
            get => Anonymous.LlVal;
            set => Anonymous.LlVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref int LVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].LVal;
        }
#else
        public int LVal
        {
            get => Anonymous.LVal;
            set => Anonymous.LVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte BVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].BVal;
        }
#else
        public byte BVal
        {
            get => Anonymous.BVal;
            set => Anonymous.BVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref short IVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].IVal;
        }
#else
        public short IVal
        {
            get => Anonymous.IVal;
            set => Anonymous.IVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref float FltVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].FltVal;
        }
#else
        public float FltVal
        {
            get => Anonymous.FltVal;
            set => Anonymous.FltVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref double DblVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].DblVal;
        }
#else
        public double DblVal
        {
            get => Anonymous.DblVal;
            set => Anonymous.DblVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref short BoolVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].BoolVal;
        }
#else
        public short BoolVal
        {
            get => Anonymous.BoolVal;
            set => Anonymous.BoolVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref short OBSOLETEVARIANTBOOL
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].OBSOLETEVARIANTBOOL;
        }
#else
        public short OBSOLETEVARIANTBOOL
        {
            get => Anonymous.OBSOLETEVARIANTBOOL;
            set => Anonymous.OBSOLETEVARIANTBOOL = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref int Scode
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Scode;
        }
#else
        public int Scode
        {
            get => Anonymous.Scode;
            set => Anonymous.Scode = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TagDecimal CyVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].CyVal;
        }
#else
        public TagDecimal CyVal
        {
            get => Anonymous.CyVal;
            set => Anonymous.CyVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref double Date
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Date;
        }
#else
        public double Date
        {
            get => Anonymous.Date;
            set => Anonymous.Date = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref char* BstrVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].BstrVal;
        }
#else
        public char* BstrVal
        {
            get => Anonymous.BstrVal;
            set => Anonymous.BstrVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Silk.NET.Core.Native.IUnknown* PunkVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PunkVal;
        }
#else
        public Silk.NET.Core.Native.IUnknown* PunkVal
        {
            get => Anonymous.PunkVal;
            set => Anonymous.PunkVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Silk.NET.Core.Native.IUnknown* PdispVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PdispVal;
        }
#else
        public Silk.NET.Core.Native.IUnknown* PdispVal
        {
            get => Anonymous.PdispVal;
            set => Anonymous.PdispVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref SafeArray* Parray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Parray;
        }
#else
        public SafeArray* Parray
        {
            get => Anonymous.Parray;
            set => Anonymous.Parray = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte* PbVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PbVal;
        }
#else
        public byte* PbVal
        {
            get => Anonymous.PbVal;
            set => Anonymous.PbVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref short* PiVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PiVal;
        }
#else
        public short* PiVal
        {
            get => Anonymous.PiVal;
            set => Anonymous.PiVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref int* PlVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PlVal;
        }
#else
        public int* PlVal
        {
            get => Anonymous.PlVal;
            set => Anonymous.PlVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref long* PllVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PllVal;
        }
#else
        public long* PllVal
        {
            get => Anonymous.PllVal;
            set => Anonymous.PllVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref float* PfltVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PfltVal;
        }
#else
        public float* PfltVal
        {
            get => Anonymous.PfltVal;
            set => Anonymous.PfltVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref double* PdblVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PdblVal;
        }
#else
        public double* PdblVal
        {
            get => Anonymous.PdblVal;
            set => Anonymous.PdblVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref short* PboolVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PboolVal;
        }
#else
        public short* PboolVal
        {
            get => Anonymous.PboolVal;
            set => Anonymous.PboolVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref short* OBSOLETEVARIANTPBOOL
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].OBSOLETEVARIANTPBOOL;
        }
#else
        public short* OBSOLETEVARIANTPBOOL
        {
            get => Anonymous.OBSOLETEVARIANTPBOOL;
            set => Anonymous.OBSOLETEVARIANTPBOOL = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref int* Pscode
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Pscode;
        }
#else
        public int* Pscode
        {
            get => Anonymous.Pscode;
            set => Anonymous.Pscode = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TagDecimal* PcyVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PcyVal;
        }
#else
        public TagDecimal* PcyVal
        {
            get => Anonymous.PcyVal;
            set => Anonymous.PcyVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref double* Pdate
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Pdate;
        }
#else
        public double* Pdate
        {
            get => Anonymous.Pdate;
            set => Anonymous.Pdate = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref char** PbstrVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PbstrVal;
        }
#else
        public char** PbstrVal
        {
            get => Anonymous.PbstrVal;
            set => Anonymous.PbstrVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Silk.NET.Core.Native.IUnknown** PpunkVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PpunkVal;
        }
#else
        public Silk.NET.Core.Native.IUnknown** PpunkVal
        {
            get => Anonymous.PpunkVal;
            set => Anonymous.PpunkVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Silk.NET.Core.Native.IUnknown** PpdispVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PpdispVal;
        }
#else
        public Silk.NET.Core.Native.IUnknown** PpdispVal
        {
            get => Anonymous.PpdispVal;
            set => Anonymous.PpdispVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref SafeArray** Pparray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Pparray;
        }
#else
        public SafeArray** Pparray
        {
            get => Anonymous.Pparray;
            set => Anonymous.Pparray = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Variant* PvarVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PvarVal;
        }
#else
        public Variant* PvarVal
        {
            get => Anonymous.PvarVal;
            set => Anonymous.PvarVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref void* Byref
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Byref;
        }
#else
        public void* Byref
        {
            get => Anonymous.Byref;
            set => Anonymous.Byref = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte CVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].CVal;
        }
#else
        public byte CVal
        {
            get => Anonymous.CVal;
            set => Anonymous.CVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ushort UiVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].UiVal;
        }
#else
        public ushort UiVal
        {
            get => Anonymous.UiVal;
            set => Anonymous.UiVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint UlVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].UlVal;
        }
#else
        public uint UlVal
        {
            get => Anonymous.UlVal;
            set => Anonymous.UlVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong UllVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].UllVal;
        }
#else
        public ulong UllVal
        {
            get => Anonymous.UllVal;
            set => Anonymous.UllVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref int IntVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].IntVal;
        }
#else
        public int IntVal
        {
            get => Anonymous.IntVal;
            set => Anonymous.IntVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint UintVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].UintVal;
        }
#else
        public uint UintVal
        {
            get => Anonymous.UintVal;
            set => Anonymous.UintVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TagDecimal* PdecVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PdecVal;
        }
#else
        public TagDecimal* PdecVal
        {
            get => Anonymous.PdecVal;
            set => Anonymous.PdecVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte* PcVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PcVal;
        }
#else
        public byte* PcVal
        {
            get => Anonymous.PcVal;
            set => Anonymous.PcVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ushort* PuiVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PuiVal;
        }
#else
        public ushort* PuiVal
        {
            get => Anonymous.PuiVal;
            set => Anonymous.PuiVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint* PulVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PulVal;
        }
#else
        public uint* PulVal
        {
            get => Anonymous.PulVal;
            set => Anonymous.PulVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong* PullVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PullVal;
        }
#else
        public ulong* PullVal
        {
            get => Anonymous.PullVal;
            set => Anonymous.PullVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref int* PintVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PintVal;
        }
#else
        public int* PintVal
        {
            get => Anonymous.PintVal;
            set => Anonymous.PintVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint* PuintVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PuintVal;
        }
#else
        public uint* PuintVal
        {
            get => Anonymous.PuintVal;
            set => Anonymous.PuintVal = value;
        }
#endif

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
