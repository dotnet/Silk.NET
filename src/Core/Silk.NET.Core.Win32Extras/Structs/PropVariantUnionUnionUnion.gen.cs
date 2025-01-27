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
    [NativeName("Name", "__AnonymousRecord_propidlbase_L311_C43")]
    public unsafe partial struct PropVariantUnionUnionUnion
    {
        public PropVariantUnionUnionUnion
        (
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


        [FieldOffset(0)]
        [NativeName("Type", "CHAR")]
        [NativeName("Type.Name", "CHAR")]
        [NativeName("Name", "cVal")]
        public byte CVal;

        [FieldOffset(0)]
        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "bVal")]
        public byte BVal;

        [FieldOffset(0)]
        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "iVal")]
        public short IVal;

        [FieldOffset(0)]
        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "uiVal")]
        public ushort UiVal;

        [FieldOffset(0)]
        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "lVal")]
        public int LVal;

        [FieldOffset(0)]
        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ulVal")]
        public uint UlVal;

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
        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "hVal")]
        public long HVal;

        [FieldOffset(0)]
        [NativeName("Type", "ULARGE_INTEGER")]
        [NativeName("Type.Name", "ULARGE_INTEGER")]
        [NativeName("Name", "uhVal")]
        public ulong UhVal;

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
        public CY CyVal;

        [FieldOffset(0)]
        [NativeName("Type", "DATE")]
        [NativeName("Type.Name", "DATE")]
        [NativeName("Name", "date")]
        public double Date;

        [FieldOffset(0)]
        [NativeName("Type", "FILETIME")]
        [NativeName("Type.Name", "FILETIME")]
        [NativeName("Name", "filetime")]
        public Silk.NET.Core.Win32Extras.Filetime Filetime;

        [FieldOffset(0)]
        [NativeName("Type", "CLSID *")]
        [NativeName("Type.Name", "CLSID *")]
        [NativeName("Name", "puuid")]
        public Guid* Puuid;

        [FieldOffset(0)]
        [NativeName("Type", "CLIPDATA *")]
        [NativeName("Type.Name", "CLIPDATA *")]
        [NativeName("Name", "pclipdata")]
        public ClipData* Pclipdata;

        [FieldOffset(0)]
        [NativeName("Type", "BSTR")]
        [NativeName("Type.Name", "BSTR")]
        [NativeName("Name", "bstrVal")]
        public char* BstrVal;

        [FieldOffset(0)]
        [NativeName("Type", "BSTRBLOB")]
        [NativeName("Type.Name", "BSTRBLOB")]
        [NativeName("Name", "bstrblobVal")]
        public BSTRBlob BstrblobVal;

        [FieldOffset(0)]
        [NativeName("Type", "BLOB")]
        [NativeName("Type.Name", "BLOB")]
        [NativeName("Name", "blob")]
        public Blob Blob;

        [FieldOffset(0)]
        [NativeName("Type", "LPSTR")]
        [NativeName("Type.Name", "LPSTR")]
        [NativeName("Name", "pszVal")]
        public byte* PszVal;

        [FieldOffset(0)]
        [NativeName("Type", "LPWSTR")]
        [NativeName("Type.Name", "LPWSTR")]
        [NativeName("Name", "pwszVal")]
        public char* PwszVal;

        [FieldOffset(0)]
        [NativeName("Type", "IUnknown *")]
        [NativeName("Type.Name", "IUnknown *")]
        [NativeName("Name", "punkVal")]
        public Silk.NET.Core.Native.IUnknown* PunkVal;

        [FieldOffset(0)]
        [NativeName("Type", "IDispatch *")]
        [NativeName("Type.Name", "IDispatch *")]
        [NativeName("Name", "pdispVal")]
        public IDispatch* PdispVal;

        [FieldOffset(0)]
        [NativeName("Type", "IStream *")]
        [NativeName("Type.Name", "IStream *")]
        [NativeName("Name", "pStream")]
        public Silk.NET.Core.Win32Extras.IStream* PStream;

        [FieldOffset(0)]
        [NativeName("Type", "IStorage *")]
        [NativeName("Type.Name", "IStorage *")]
        [NativeName("Name", "pStorage")]
        public IStorage* PStorage;

        [FieldOffset(0)]
        [NativeName("Type", "LPVERSIONEDSTREAM")]
        [NativeName("Type.Name", "LPVERSIONEDSTREAM")]
        [NativeName("Name", "pVersionedStream")]
        public VersionedStream* PVersionedStream;

        [FieldOffset(0)]
        [NativeName("Type", "LPSAFEARRAY")]
        [NativeName("Type.Name", "LPSAFEARRAY")]
        [NativeName("Name", "parray")]
        public SafeArray* Parray;

        [FieldOffset(0)]
        [NativeName("Type", "CAC")]
        [NativeName("Type.Name", "CAC")]
        [NativeName("Name", "cac")]
        public CAC Cac;

        [FieldOffset(0)]
        [NativeName("Type", "CAUB")]
        [NativeName("Type.Name", "CAUB")]
        [NativeName("Name", "caub")]
        public CAUB Caub;

        [FieldOffset(0)]
        [NativeName("Type", "CAI")]
        [NativeName("Type.Name", "CAI")]
        [NativeName("Name", "cai")]
        public CAI Cai;

        [FieldOffset(0)]
        [NativeName("Type", "CAUI")]
        [NativeName("Type.Name", "CAUI")]
        [NativeName("Name", "caui")]
        public CAUI Caui;

        [FieldOffset(0)]
        [NativeName("Type", "CAL")]
        [NativeName("Type.Name", "CAL")]
        [NativeName("Name", "cal")]
        public CAL Cal;

        [FieldOffset(0)]
        [NativeName("Type", "CAUL")]
        [NativeName("Type.Name", "CAUL")]
        [NativeName("Name", "caul")]
        public CAUL Caul;

        [FieldOffset(0)]
        [NativeName("Type", "CAH")]
        [NativeName("Type.Name", "CAH")]
        [NativeName("Name", "cah")]
        public CAH Cah;

        [FieldOffset(0)]
        [NativeName("Type", "CAUH")]
        [NativeName("Type.Name", "CAUH")]
        [NativeName("Name", "cauh")]
        public CAUH Cauh;

        [FieldOffset(0)]
        [NativeName("Type", "CAFLT")]
        [NativeName("Type.Name", "CAFLT")]
        [NativeName("Name", "caflt")]
        public CAFLT Caflt;

        [FieldOffset(0)]
        [NativeName("Type", "CADBL")]
        [NativeName("Type.Name", "CADBL")]
        [NativeName("Name", "cadbl")]
        public CADBL Cadbl;

        [FieldOffset(0)]
        [NativeName("Type", "CABOOL")]
        [NativeName("Type.Name", "CABOOL")]
        [NativeName("Name", "cabool")]
        public CABool Cabool;

        [FieldOffset(0)]
        [NativeName("Type", "CASCODE")]
        [NativeName("Type.Name", "CASCODE")]
        [NativeName("Name", "cascode")]
        public CASCode Cascode;

        [FieldOffset(0)]
        [NativeName("Type", "CACY")]
        [NativeName("Type.Name", "CACY")]
        [NativeName("Name", "cacy")]
        public CACY Cacy;

        [FieldOffset(0)]
        [NativeName("Type", "CADATE")]
        [NativeName("Type.Name", "CADATE")]
        [NativeName("Name", "cadate")]
        public CADate Cadate;

        [FieldOffset(0)]
        [NativeName("Type", "CAFILETIME")]
        [NativeName("Type.Name", "CAFILETIME")]
        [NativeName("Name", "cafiletime")]
        public CAFileTime Cafiletime;

        [FieldOffset(0)]
        [NativeName("Type", "CACLSID")]
        [NativeName("Type.Name", "CACLSID")]
        [NativeName("Name", "cauuid")]
        public CACLSID Cauuid;

        [FieldOffset(0)]
        [NativeName("Type", "CACLIPDATA")]
        [NativeName("Type.Name", "CACLIPDATA")]
        [NativeName("Name", "caclipdata")]
        public CAClipData Caclipdata;

        [FieldOffset(0)]
        [NativeName("Type", "CABSTR")]
        [NativeName("Type.Name", "CABSTR")]
        [NativeName("Name", "cabstr")]
        public CABSTR Cabstr;

        [FieldOffset(0)]
        [NativeName("Type", "CABSTRBLOB")]
        [NativeName("Type.Name", "CABSTRBLOB")]
        [NativeName("Name", "cabstrblob")]
        public CABSTRBlob Cabstrblob;

        [FieldOffset(0)]
        [NativeName("Type", "CALPSTR")]
        [NativeName("Type.Name", "CALPSTR")]
        [NativeName("Name", "calpstr")]
        public CALPSTR Calpstr;

        [FieldOffset(0)]
        [NativeName("Type", "CALPWSTR")]
        [NativeName("Type.Name", "CALPWSTR")]
        [NativeName("Name", "calpwstr")]
        public CALPWSTR Calpwstr;

        [FieldOffset(0)]
        [NativeName("Type", "CAPROPVARIANT")]
        [NativeName("Type.Name", "CAPROPVARIANT")]
        [NativeName("Name", "capropvar")]
        public CAPropVariant Capropvar;

        [FieldOffset(0)]
        [NativeName("Type", "CHAR *")]
        [NativeName("Type.Name", "CHAR *")]
        [NativeName("Name", "pcVal")]
        public byte* PcVal;

        [FieldOffset(0)]
        [NativeName("Type", "UCHAR *")]
        [NativeName("Type.Name", "UCHAR *")]
        [NativeName("Name", "pbVal")]
        public byte* PbVal;

        [FieldOffset(0)]
        [NativeName("Type", "SHORT *")]
        [NativeName("Type.Name", "SHORT *")]
        [NativeName("Name", "piVal")]
        public short* PiVal;

        [FieldOffset(0)]
        [NativeName("Type", "USHORT *")]
        [NativeName("Type.Name", "USHORT *")]
        [NativeName("Name", "puiVal")]
        public ushort* PuiVal;

        [FieldOffset(0)]
        [NativeName("Type", "LONG *")]
        [NativeName("Type.Name", "LONG *")]
        [NativeName("Name", "plVal")]
        public int* PlVal;

        [FieldOffset(0)]
        [NativeName("Type", "ULONG *")]
        [NativeName("Type.Name", "ULONG *")]
        [NativeName("Name", "pulVal")]
        public uint* PulVal;

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
        [NativeName("Type", "DECIMAL *")]
        [NativeName("Type.Name", "DECIMAL *")]
        [NativeName("Name", "pdecVal")]
        public TagDecimal* PdecVal;

        [FieldOffset(0)]
        [NativeName("Type", "SCODE *")]
        [NativeName("Type.Name", "SCODE *")]
        [NativeName("Name", "pscode")]
        public int* Pscode;

        [FieldOffset(0)]
        [NativeName("Type", "CY *")]
        [NativeName("Type.Name", "CY *")]
        [NativeName("Name", "pcyVal")]
        public CY* PcyVal;

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
        [NativeName("Type", "IDispatch **")]
        [NativeName("Type.Name", "IDispatch **")]
        [NativeName("Name", "ppdispVal")]
        public IDispatch** PpdispVal;

        [FieldOffset(0)]
        [NativeName("Type", "LPSAFEARRAY *")]
        [NativeName("Type.Name", "LPSAFEARRAY *")]
        [NativeName("Name", "pparray")]
        public SafeArray** Pparray;

        [FieldOffset(0)]
        [NativeName("Type", "PROPVARIANT *")]
        [NativeName("Type.Name", "PROPVARIANT *")]
        [NativeName("Name", "pvarVal")]
        public PropVariant* PvarVal;
    }
}
