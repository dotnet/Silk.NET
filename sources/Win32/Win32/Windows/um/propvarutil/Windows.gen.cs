// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propvarutil.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromResource(
        HINSTANCE hinst,
        uint id,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromBuffer(
        [NativeTypeName("const void *")] void* pv,
        uint cb,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromCLSID(
        [NativeTypeName("const IID &")] Guid* clsid,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromGUIDAsString(
        [NativeTypeName("const GUID &")] Guid* guid,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromFileTime(
        [NativeTypeName("const FILETIME *")] FILETIME* pftIn,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromPropVariantVectorElem(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        [NativeTypeName("ULONG")] uint iElem,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantVectorFromPropVariant(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarSingle,
        PROPVARIANT* ppropvarVector
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromStrRet(
        STRRET* pstrret,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromBooleanVector(
        [NativeTypeName("const BOOL *")] BOOL* prgf,
        [NativeTypeName("ULONG")] uint cElems,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromInt16Vector(
        [NativeTypeName("const SHORT *")] short* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromUInt16Vector(
        [NativeTypeName("const USHORT *")] ushort* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromInt32Vector(
        [NativeTypeName("const LONG *")] int* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromUInt32Vector(
        [NativeTypeName("const ULONG *")] uint* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromInt64Vector(
        [NativeTypeName("const LONGLONG *")] long* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromUInt64Vector(
        [NativeTypeName("const ULONGLONG *")] ulong* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromDoubleVector(
        [NativeTypeName("const DOUBLE *")] double* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromFileTimeVector(
        [NativeTypeName("const FILETIME *")] FILETIME* prgft,
        [NativeTypeName("ULONG")] uint cElems,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromStringVector(
        [NativeTypeName("PCWSTR *")] ushort** prgsz,
        [NativeTypeName("ULONG")] uint cElems,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitPropVariantFromStringAsVector(
        [NativeTypeName("PCWSTR")] ushort* psz,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern BOOL PropVariantToBooleanWithDefault(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        BOOL fDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern short PropVariantToInt16WithDefault(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        short iDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern ushort PropVariantToUInt16WithDefault(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        ushort uiDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int PropVariantToInt32WithDefault(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        [NativeTypeName("LONG")] int lDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint PropVariantToUInt32WithDefault(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        [NativeTypeName("ULONG")] uint ulDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("LONGLONG")]
    public static extern long PropVariantToInt64WithDefault(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        [NativeTypeName("LONGLONG")] long llDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("ULONGLONG")]
    public static extern ulong PropVariantToUInt64WithDefault(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        [NativeTypeName("ULONGLONG")] ulong ullDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern double PropVariantToDoubleWithDefault(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        double dblDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("PCWSTR")]
    public static extern ushort* PropVariantToStringWithDefault(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        [NativeTypeName("LPCWSTR")] ushort* pszDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToBoolean(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        BOOL* pfRet
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt16(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        short* piRet
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt16(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        ushort* puiRet
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt64(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        [NativeTypeName("LONGLONG *")] long* pllRet
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt64(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        [NativeTypeName("ULONGLONG *")] ulong* pullRet
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToDouble(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        double* pdblRet
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToBuffer(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        void* pv,
        uint cb
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToString(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("PWSTR")] ushort* psz,
        uint cch
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToGUID(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        Guid* pguid
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToStringAlloc(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("PWSTR *")] ushort** ppszOut
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToBSTR(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToStrRet(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        STRRET* pstrret
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToFileTime(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("PSTIME_FLAGS")] int pstfOut,
        FILETIME* pftOut
    );

    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint PropVariantGetElementCount(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToBooleanVector(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        BOOL* prgf,
        [NativeTypeName("ULONG")] uint crgf,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt16Vector(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        short* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt16Vector(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        ushort* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt32Vector(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("LONG *")] int* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt32Vector(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONG *")] uint* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt64Vector(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("LONGLONG *")] long* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt64Vector(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONGLONG *")] ulong* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToDoubleVector(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        double* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToFileTimeVector(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        FILETIME* prgft,
        [NativeTypeName("ULONG")] uint crgft,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToStringVector(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("PWSTR *")] ushort** prgsz,
        [NativeTypeName("ULONG")] uint crgsz,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToBooleanVectorAlloc(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        BOOL** pprgf,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt16VectorAlloc(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        short** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt16VectorAlloc(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        ushort** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt32VectorAlloc(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("LONG **")] int** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt32VectorAlloc(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONG **")] uint** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToInt64VectorAlloc(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("LONGLONG **")] long** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToUInt64VectorAlloc(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONGLONG **")] ulong** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToDoubleVectorAlloc(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        double** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToFileTimeVectorAlloc(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        FILETIME** pprgft,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToStringVectorAlloc(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("PWSTR **")] ushort*** pprgsz,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetBooleanElem(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONG")] uint iElem,
        BOOL* pfVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetInt16Elem(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONG")] uint iElem,
        short* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetUInt16Elem(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONG")] uint iElem,
        ushort* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetInt32Elem(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONG")] uint iElem,
        [NativeTypeName("LONG *")] int* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetUInt32Elem(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONG")] uint iElem,
        [NativeTypeName("ULONG *")] uint* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetInt64Elem(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONG")] uint iElem,
        [NativeTypeName("LONGLONG *")] long* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetUInt64Elem(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONG")] uint iElem,
        [NativeTypeName("ULONGLONG *")] ulong* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetDoubleElem(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONG")] uint iElem,
        double* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetFileTimeElem(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONG")] uint iElem,
        FILETIME* pftVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantGetStringElem(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("ULONG")] uint iElem,
        [NativeTypeName("PWSTR *")] ushort** ppszVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern void ClearPropVariantArray(PROPVARIANT* rgPropVar, uint cVars);

    [DllImport("propsys", ExactSpelling = true)]
    public static extern int PropVariantCompareEx(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar1,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar2,
        PROPVAR_COMPARE_UNIT unit,
        [NativeTypeName("PROPVAR_COMPARE_FLAGS")] int flags
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantChangeType(
        PROPVARIANT* ppropvarDest,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarSrc,
        [NativeTypeName("PROPVAR_CHANGE_FLAGS")] int flags,
        [NativeTypeName("VARTYPE")] ushort vt
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PropVariantToVariant(
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pPropVar,
        VARIANT* pVar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToPropVariant(
        [NativeTypeName("const VARIANT *")] VARIANT* pVar,
        PROPVARIANT* pPropVar
    );

    [DllImport("propsys.dll", ExactSpelling = true)]
    public static extern HRESULT StgSerializePropVariant(
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* ppropvar,
        SERIALIZEDPROPERTYVALUE** ppProp,
        [NativeTypeName("ULONG *")] uint* pcb
    );

    [DllImport("propsys.dll", ExactSpelling = true)]
    public static extern HRESULT StgDeserializePropVariant(
        [NativeTypeName("const SERIALIZEDPROPERTYVALUE *")] SERIALIZEDPROPERTYVALUE* pprop,
        [NativeTypeName("ULONG")] uint cbMax,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromResource(HINSTANCE hinst, uint id, VARIANT* pvar);

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromBuffer(
        [NativeTypeName("const void *")] void* pv,
        uint cb,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromGUIDAsString(
        [NativeTypeName("const GUID &")] Guid* guid,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromFileTime(
        [NativeTypeName("const FILETIME *")] FILETIME* pft,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromFileTimeArray(
        [NativeTypeName("const FILETIME *")] FILETIME* prgft,
        [NativeTypeName("ULONG")] uint cElems,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromStrRet(
        STRRET* pstrret,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromVariantArrayElem(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("ULONG")] uint iElem,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromBooleanArray(
        [NativeTypeName("const BOOL *")] BOOL* prgf,
        [NativeTypeName("ULONG")] uint cElems,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromInt16Array(
        [NativeTypeName("const SHORT *")] short* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromUInt16Array(
        [NativeTypeName("const USHORT *")] ushort* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromInt32Array(
        [NativeTypeName("const LONG *")] int* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromUInt32Array(
        [NativeTypeName("const ULONG *")] uint* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromInt64Array(
        [NativeTypeName("const LONGLONG *")] long* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromUInt64Array(
        [NativeTypeName("const ULONGLONG *")] ulong* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromDoubleArray(
        [NativeTypeName("const DOUBLE *")] double* prgn,
        [NativeTypeName("ULONG")] uint cElems,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT InitVariantFromStringArray(
        [NativeTypeName("PCWSTR *")] ushort** prgsz,
        [NativeTypeName("ULONG")] uint cElems,
        VARIANT* pvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern BOOL VariantToBooleanWithDefault(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        BOOL fDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern short VariantToInt16WithDefault(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        short iDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern ushort VariantToUInt16WithDefault(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        ushort uiDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int VariantToInt32WithDefault(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("LONG")] int lDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint VariantToUInt32WithDefault(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("ULONG")] uint ulDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("LONGLONG")]
    public static extern long VariantToInt64WithDefault(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("LONGLONG")] long llDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("ULONGLONG")]
    public static extern ulong VariantToUInt64WithDefault(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("ULONGLONG")] ulong ullDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern double VariantToDoubleWithDefault(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        double dblDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("PCWSTR")]
    public static extern ushort* VariantToStringWithDefault(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("LPCWSTR")] ushort* pszDefault
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToBoolean(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        BOOL* pfRet
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt16(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        short* piRet
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt16(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        ushort* puiRet
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt64(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("LONGLONG *")] long* pllRet
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt64(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("ULONGLONG *")] ulong* pullRet
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToDouble(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        double* pdblRet
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToBuffer(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        void* pv,
        uint cb
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToGUID(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        Guid* pguid
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToString(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("PWSTR")] ushort* pszBuf,
        uint cchBuf
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToStringAlloc(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("PWSTR *")] ushort** ppszBuf
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToDosDateTime(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("WORD *")] ushort* pwDate,
        [NativeTypeName("WORD *")] ushort* pwTime
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToStrRet(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        STRRET* pstrret
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToFileTime(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn,
        [NativeTypeName("PSTIME_FLAGS")] int stfOut,
        FILETIME* pftOut
    );

    [DllImport("propsys", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint VariantGetElementCount(
        [NativeTypeName("const VARIANT &")] VARIANT* varIn
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToBooleanArray(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        BOOL* prgf,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt16Array(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        short* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt16Array(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        ushort* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt32Array(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("LONG *")] int* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt32Array(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONG *")] uint* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt64Array(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("LONGLONG *")] long* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt64Array(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONGLONG *")] ulong* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToDoubleArray(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        double* prgn,
        [NativeTypeName("ULONG")] uint crgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToStringArray(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("PWSTR *")] ushort** prgsz,
        [NativeTypeName("ULONG")] uint crgsz,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToBooleanArrayAlloc(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        BOOL** pprgf,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt16ArrayAlloc(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        short** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt16ArrayAlloc(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        ushort** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt32ArrayAlloc(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("LONG **")] int** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt32ArrayAlloc(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONG **")] uint** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToInt64ArrayAlloc(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("LONGLONG **")] long** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToUInt64ArrayAlloc(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONGLONG **")] ulong** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToDoubleArrayAlloc(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        double** pprgn,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantToStringArrayAlloc(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("PWSTR **")] ushort*** pprgsz,
        [NativeTypeName("ULONG *")] uint* pcElem
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetBooleanElem(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONG")] uint iElem,
        BOOL* pfVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetInt16Elem(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONG")] uint iElem,
        short* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetUInt16Elem(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONG")] uint iElem,
        ushort* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetInt32Elem(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONG")] uint iElem,
        [NativeTypeName("LONG *")] int* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetUInt32Elem(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONG")] uint iElem,
        [NativeTypeName("ULONG *")] uint* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetInt64Elem(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONG")] uint iElem,
        [NativeTypeName("LONGLONG *")] long* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetUInt64Elem(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONG")] uint iElem,
        [NativeTypeName("ULONGLONG *")] ulong* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetDoubleElem(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONG")] uint iElem,
        double* pnVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT VariantGetStringElem(
        [NativeTypeName("const VARIANT &")] VARIANT* var,
        [NativeTypeName("ULONG")] uint iElem,
        [NativeTypeName("PWSTR *")] ushort** ppszVal
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern void ClearVariantArray(VARIANT* pvars, uint cvars);

    [DllImport("propsys", ExactSpelling = true)]
    public static extern int VariantCompare(
        [NativeTypeName("const VARIANT &")] VARIANT* var1,
        [NativeTypeName("const VARIANT &")] VARIANT* var2
    );
}
