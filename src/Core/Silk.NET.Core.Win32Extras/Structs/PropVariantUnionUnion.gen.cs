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
    [NativeName("Name", "__AnonymousRecord_propidlbase_L305_C1")]
    public unsafe partial struct PropVariantUnionUnion
    {
        public PropVariantUnionUnion
        (
            ushort? vt = null,
            ushort? wReserved1 = null,
            ushort? wReserved2 = null,
            ushort? wReserved3 = null,
            PropVariantUnionUnionUnion? anonymous = null,
            byte? cVal = null,
            byte? bVal = null,
            short? iVal = null,
            ushort? uiVal = null,
            int? lVal = null,
            uint? ulVal = null,
            int? intVal = null,
            uint? uintVal = null,
            long? hVal = null,
            ulong? uhVal = null,
            float? fltVal = null,
            double? dblVal = null,
            short? boolVal = null,
            short? oBSOLETEVARIANTBOOL = null,
            int? scode = null,
            CY? cyVal = null,
            double? date = null,
            Silk.NET.Core.Win32Extras.Filetime? filetime = null,
            Guid* puuid = null,
            ClipData* pclipdata = null,
            char* bstrVal = null,
            BSTRBlob? bstrblobVal = null,
            Blob? blob = null,
            byte* pszVal = null,
            char* pwszVal = null,
            Silk.NET.Core.Native.IUnknown* punkVal = null,
            IDispatch* pdispVal = null,
            Silk.NET.Core.Win32Extras.IStream* pStream = null,
            IStorage* pStorage = null,
            VersionedStream* pVersionedStream = null,
            SafeArray* parray = null,
            CAC? cac = null,
            CAUB? caub = null,
            CAI? cai = null,
            CAUI? caui = null,
            CAL? cal = null,
            CAUL? caul = null,
            CAH? cah = null,
            CAUH? cauh = null,
            CAFLT? caflt = null,
            CADBL? cadbl = null,
            CABool? cabool = null,
            CASCode? cascode = null,
            CACY? cacy = null,
            CADate? cadate = null,
            CAFileTime? cafiletime = null,
            CACLSID? cauuid = null,
            CAClipData? caclipdata = null,
            CABSTR? cabstr = null,
            CABSTRBlob? cabstrblob = null,
            CALPSTR? calpstr = null,
            CALPWSTR? calpwstr = null,
            CAPropVariant? capropvar = null,
            byte* pcVal = null,
            byte* pbVal = null,
            short* piVal = null,
            ushort* puiVal = null,
            int* plVal = null,
            uint* pulVal = null,
            int* pintVal = null,
            uint* puintVal = null,
            float* pfltVal = null,
            double* pdblVal = null,
            short* pboolVal = null,
            TagDecimal* pdecVal = null,
            int* pscode = null,
            CY* pcyVal = null,
            double* pdate = null,
            char** pbstrVal = null,
            Silk.NET.Core.Native.IUnknown** ppunkVal = null,
            IDispatch** ppdispVal = null,
            SafeArray** pparray = null,
            PropVariant* pvarVal = null
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

            if (cVal is not null)
            {
                CVal = cVal.Value;
            }

            if (bVal is not null)
            {
                BVal = bVal.Value;
            }

            if (iVal is not null)
            {
                IVal = iVal.Value;
            }

            if (uiVal is not null)
            {
                UiVal = uiVal.Value;
            }

            if (lVal is not null)
            {
                LVal = lVal.Value;
            }

            if (ulVal is not null)
            {
                UlVal = ulVal.Value;
            }

            if (intVal is not null)
            {
                IntVal = intVal.Value;
            }

            if (uintVal is not null)
            {
                UintVal = uintVal.Value;
            }

            if (hVal is not null)
            {
                HVal = hVal.Value;
            }

            if (uhVal is not null)
            {
                UhVal = uhVal.Value;
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

            if (filetime is not null)
            {
                Filetime = filetime.Value;
            }

            if (puuid is not null)
            {
                Puuid = puuid;
            }

            if (pclipdata is not null)
            {
                Pclipdata = pclipdata;
            }

            if (bstrVal is not null)
            {
                BstrVal = bstrVal;
            }

            if (bstrblobVal is not null)
            {
                BstrblobVal = bstrblobVal.Value;
            }

            if (blob is not null)
            {
                Blob = blob.Value;
            }

            if (pszVal is not null)
            {
                PszVal = pszVal;
            }

            if (pwszVal is not null)
            {
                PwszVal = pwszVal;
            }

            if (punkVal is not null)
            {
                PunkVal = punkVal;
            }

            if (pdispVal is not null)
            {
                PdispVal = pdispVal;
            }

            if (pStream is not null)
            {
                PStream = pStream;
            }

            if (pStorage is not null)
            {
                PStorage = pStorage;
            }

            if (pVersionedStream is not null)
            {
                PVersionedStream = pVersionedStream;
            }

            if (parray is not null)
            {
                Parray = parray;
            }

            if (cac is not null)
            {
                Cac = cac.Value;
            }

            if (caub is not null)
            {
                Caub = caub.Value;
            }

            if (cai is not null)
            {
                Cai = cai.Value;
            }

            if (caui is not null)
            {
                Caui = caui.Value;
            }

            if (cal is not null)
            {
                Cal = cal.Value;
            }

            if (caul is not null)
            {
                Caul = caul.Value;
            }

            if (cah is not null)
            {
                Cah = cah.Value;
            }

            if (cauh is not null)
            {
                Cauh = cauh.Value;
            }

            if (caflt is not null)
            {
                Caflt = caflt.Value;
            }

            if (cadbl is not null)
            {
                Cadbl = cadbl.Value;
            }

            if (cabool is not null)
            {
                Cabool = cabool.Value;
            }

            if (cascode is not null)
            {
                Cascode = cascode.Value;
            }

            if (cacy is not null)
            {
                Cacy = cacy.Value;
            }

            if (cadate is not null)
            {
                Cadate = cadate.Value;
            }

            if (cafiletime is not null)
            {
                Cafiletime = cafiletime.Value;
            }

            if (cauuid is not null)
            {
                Cauuid = cauuid.Value;
            }

            if (caclipdata is not null)
            {
                Caclipdata = caclipdata.Value;
            }

            if (cabstr is not null)
            {
                Cabstr = cabstr.Value;
            }

            if (cabstrblob is not null)
            {
                Cabstrblob = cabstrblob.Value;
            }

            if (calpstr is not null)
            {
                Calpstr = calpstr.Value;
            }

            if (calpwstr is not null)
            {
                Calpwstr = calpwstr.Value;
            }

            if (capropvar is not null)
            {
                Capropvar = capropvar.Value;
            }

            if (pcVal is not null)
            {
                PcVal = pcVal;
            }

            if (pbVal is not null)
            {
                PbVal = pbVal;
            }

            if (piVal is not null)
            {
                PiVal = piVal;
            }

            if (puiVal is not null)
            {
                PuiVal = puiVal;
            }

            if (plVal is not null)
            {
                PlVal = plVal;
            }

            if (pulVal is not null)
            {
                PulVal = pulVal;
            }

            if (pintVal is not null)
            {
                PintVal = pintVal;
            }

            if (puintVal is not null)
            {
                PuintVal = puintVal;
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

            if (pdecVal is not null)
            {
                PdecVal = pdecVal;
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
        }


        [NativeName("Type", "VARTYPE")]
        [NativeName("Type.Name", "VARTYPE")]
        [NativeName("Name", "vt")]
        public ushort Vt;

        [NativeName("Type", "PROPVAR_PAD1")]
        [NativeName("Type.Name", "PROPVAR_PAD1")]
        [NativeName("Name", "wReserved1")]
        public ushort WReserved1;

        [NativeName("Type", "PROPVAR_PAD2")]
        [NativeName("Type.Name", "PROPVAR_PAD2")]
        [NativeName("Name", "wReserved2")]
        public ushort WReserved2;

        [NativeName("Type", "PROPVAR_PAD3")]
        [NativeName("Type.Name", "PROPVAR_PAD3")]
        [NativeName("Name", "wReserved3")]
        public ushort WReserved3;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_propidlbase_L311_C43")]
        [NativeName("Name", "anonymous1")]
        public PropVariantUnionUnionUnion Anonymous;
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
        public ref long HVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].HVal;
        }
#else
        public long HVal
        {
            get => Anonymous.HVal;
            set => Anonymous.HVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong UhVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].UhVal;
        }
#else
        public ulong UhVal
        {
            get => Anonymous.UhVal;
            set => Anonymous.UhVal = value;
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
        public ref CY CyVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].CyVal;
        }
#else
        public CY CyVal
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
        public ref Silk.NET.Core.Win32Extras.Filetime Filetime
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Filetime;
        }
#else
        public Silk.NET.Core.Win32Extras.Filetime Filetime
        {
            get => Anonymous.Filetime;
            set => Anonymous.Filetime = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Guid* Puuid
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Puuid;
        }
#else
        public Guid* Puuid
        {
            get => Anonymous.Puuid;
            set => Anonymous.Puuid = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ClipData* Pclipdata
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Pclipdata;
        }
#else
        public ClipData* Pclipdata
        {
            get => Anonymous.Pclipdata;
            set => Anonymous.Pclipdata = value;
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
        public ref BSTRBlob BstrblobVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].BstrblobVal;
        }
#else
        public BSTRBlob BstrblobVal
        {
            get => Anonymous.BstrblobVal;
            set => Anonymous.BstrblobVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Blob Blob
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Blob;
        }
#else
        public Blob Blob
        {
            get => Anonymous.Blob;
            set => Anonymous.Blob = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte* PszVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PszVal;
        }
#else
        public byte* PszVal
        {
            get => Anonymous.PszVal;
            set => Anonymous.PszVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref char* PwszVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PwszVal;
        }
#else
        public char* PwszVal
        {
            get => Anonymous.PwszVal;
            set => Anonymous.PwszVal = value;
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
        public ref IDispatch* PdispVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PdispVal;
        }
#else
        public IDispatch* PdispVal
        {
            get => Anonymous.PdispVal;
            set => Anonymous.PdispVal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Silk.NET.Core.Win32Extras.IStream* PStream
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PStream;
        }
#else
        public Silk.NET.Core.Win32Extras.IStream* PStream
        {
            get => Anonymous.PStream;
            set => Anonymous.PStream = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref IStorage* PStorage
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PStorage;
        }
#else
        public IStorage* PStorage
        {
            get => Anonymous.PStorage;
            set => Anonymous.PStorage = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VersionedStream* PVersionedStream
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PVersionedStream;
        }
#else
        public VersionedStream* PVersionedStream
        {
            get => Anonymous.PVersionedStream;
            set => Anonymous.PVersionedStream = value;
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
        public ref CAC Cac
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cac;
        }
#else
        public CAC Cac
        {
            get => Anonymous.Cac;
            set => Anonymous.Cac = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CAUB Caub
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Caub;
        }
#else
        public CAUB Caub
        {
            get => Anonymous.Caub;
            set => Anonymous.Caub = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CAI Cai
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cai;
        }
#else
        public CAI Cai
        {
            get => Anonymous.Cai;
            set => Anonymous.Cai = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CAUI Caui
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Caui;
        }
#else
        public CAUI Caui
        {
            get => Anonymous.Caui;
            set => Anonymous.Caui = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CAL Cal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cal;
        }
#else
        public CAL Cal
        {
            get => Anonymous.Cal;
            set => Anonymous.Cal = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CAUL Caul
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Caul;
        }
#else
        public CAUL Caul
        {
            get => Anonymous.Caul;
            set => Anonymous.Caul = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CAH Cah
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cah;
        }
#else
        public CAH Cah
        {
            get => Anonymous.Cah;
            set => Anonymous.Cah = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CAUH Cauh
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cauh;
        }
#else
        public CAUH Cauh
        {
            get => Anonymous.Cauh;
            set => Anonymous.Cauh = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CAFLT Caflt
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Caflt;
        }
#else
        public CAFLT Caflt
        {
            get => Anonymous.Caflt;
            set => Anonymous.Caflt = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CADBL Cadbl
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cadbl;
        }
#else
        public CADBL Cadbl
        {
            get => Anonymous.Cadbl;
            set => Anonymous.Cadbl = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CABool Cabool
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cabool;
        }
#else
        public CABool Cabool
        {
            get => Anonymous.Cabool;
            set => Anonymous.Cabool = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CASCode Cascode
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cascode;
        }
#else
        public CASCode Cascode
        {
            get => Anonymous.Cascode;
            set => Anonymous.Cascode = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CACY Cacy
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cacy;
        }
#else
        public CACY Cacy
        {
            get => Anonymous.Cacy;
            set => Anonymous.Cacy = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CADate Cadate
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cadate;
        }
#else
        public CADate Cadate
        {
            get => Anonymous.Cadate;
            set => Anonymous.Cadate = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CAFileTime Cafiletime
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cafiletime;
        }
#else
        public CAFileTime Cafiletime
        {
            get => Anonymous.Cafiletime;
            set => Anonymous.Cafiletime = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CACLSID Cauuid
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cauuid;
        }
#else
        public CACLSID Cauuid
        {
            get => Anonymous.Cauuid;
            set => Anonymous.Cauuid = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CAClipData Caclipdata
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Caclipdata;
        }
#else
        public CAClipData Caclipdata
        {
            get => Anonymous.Caclipdata;
            set => Anonymous.Caclipdata = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CABSTR Cabstr
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cabstr;
        }
#else
        public CABSTR Cabstr
        {
            get => Anonymous.Cabstr;
            set => Anonymous.Cabstr = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CABSTRBlob Cabstrblob
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Cabstrblob;
        }
#else
        public CABSTRBlob Cabstrblob
        {
            get => Anonymous.Cabstrblob;
            set => Anonymous.Cabstrblob = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CALPSTR Calpstr
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Calpstr;
        }
#else
        public CALPSTR Calpstr
        {
            get => Anonymous.Calpstr;
            set => Anonymous.Calpstr = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CALPWSTR Calpwstr
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Calpwstr;
        }
#else
        public CALPWSTR Calpwstr
        {
            get => Anonymous.Calpwstr;
            set => Anonymous.Calpwstr = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref CAPropVariant Capropvar
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Capropvar;
        }
#else
        public CAPropVariant Capropvar
        {
            get => Anonymous.Capropvar;
            set => Anonymous.Capropvar = value;
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
        public ref CY* PcyVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PcyVal;
        }
#else
        public CY* PcyVal
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
        public ref IDispatch** PpdispVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PpdispVal;
        }
#else
        public IDispatch** PpdispVal
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
        public ref PropVariant* PvarVal
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PvarVal;
        }
#else
        public PropVariant* PvarVal
        {
            get => Anonymous.PvarVal;
            set => Anonymous.PvarVal = value;
        }
#endif

    }
}
