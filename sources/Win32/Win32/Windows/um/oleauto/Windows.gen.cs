// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.VARENUM;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("oleaut32", ExactSpelling = true)]
    [return: NativeTypeName("BSTR")]
    public static extern ushort* SysAllocString([NativeTypeName("const OLECHAR *")] ushort* psz);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern int SysReAllocString(
        [NativeTypeName("BSTR *")] ushort** pbstr,
        [NativeTypeName("const OLECHAR *")] ushort* psz
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    [return: NativeTypeName("BSTR")]
    public static extern ushort* SysAllocStringLen(
        [NativeTypeName("const OLECHAR *")] ushort* strIn,
        uint ui
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern int SysReAllocStringLen(
        [NativeTypeName("BSTR *")] ushort** pbstr,
        [NativeTypeName("const OLECHAR *")] ushort* psz,
        [NativeTypeName("unsigned int")] uint len
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SysAddRefString([NativeTypeName("BSTR")] ushort* bstrString);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern void SysReleaseString([NativeTypeName("BSTR")] ushort* bstrString);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern void SysFreeString([NativeTypeName("BSTR")] ushort* bstrString);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern uint SysStringLen([NativeTypeName("BSTR")] ushort* pbstr);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern uint SysStringByteLen([NativeTypeName("BSTR")] ushort* bstr);

    [DllImport("oleaut32", ExactSpelling = true)]
    [return: NativeTypeName("BSTR")]
    public static extern ushort* SysAllocStringByteLen(
        [NativeTypeName("LPCSTR")] sbyte* psz,
        uint len
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern int DosDateTimeToVariantTime(
        ushort wDosDate,
        ushort wDosTime,
        double* pvtime
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern int VariantTimeToDosDateTime(
        double vtime,
        ushort* pwDosDate,
        ushort* pwDosTime
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern int SystemTimeToVariantTime(
        [NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpSystemTime,
        double* pvtime
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern int VariantTimeToSystemTime(
        double vtime,
        [NativeTypeName("LPSYSTEMTIME")] SYSTEMTIME* lpSystemTime
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayAllocDescriptor(uint cDims, SAFEARRAY** ppsaOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayAllocDescriptorEx(
        [NativeTypeName("VARTYPE")] ushort vt,
        uint cDims,
        SAFEARRAY** ppsaOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayAllocData(SAFEARRAY* psa);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern SAFEARRAY* SafeArrayCreate(
        [NativeTypeName("VARTYPE")] ushort vt,
        uint cDims,
        SAFEARRAYBOUND* rgsabound
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern SAFEARRAY* SafeArrayCreateEx(
        [NativeTypeName("VARTYPE")] ushort vt,
        uint cDims,
        SAFEARRAYBOUND* rgsabound,
        [NativeTypeName("PVOID")] void* pvExtra
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayCopyData(SAFEARRAY* psaSource, SAFEARRAY* psaTarget);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern void SafeArrayReleaseDescriptor(SAFEARRAY* psa);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayDestroyDescriptor(SAFEARRAY* psa);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern void SafeArrayReleaseData([NativeTypeName("PVOID")] void* pData);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayDestroyData(SAFEARRAY* psa);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayAddRef(
        SAFEARRAY* psa,
        [NativeTypeName("PVOID *")] void** ppDataToRelease
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayDestroy(SAFEARRAY* psa);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayRedim(SAFEARRAY* psa, SAFEARRAYBOUND* psaboundNew);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern uint SafeArrayGetDim(SAFEARRAY* psa);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern uint SafeArrayGetElemsize(SAFEARRAY* psa);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayGetUBound(
        SAFEARRAY* psa,
        uint nDim,
        [NativeTypeName("LONG *")] int* plUbound
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayGetLBound(
        SAFEARRAY* psa,
        uint nDim,
        [NativeTypeName("LONG *")] int* plLbound
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayLock(SAFEARRAY* psa);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayUnlock(SAFEARRAY* psa);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayAccessData(SAFEARRAY* psa, void** ppvData);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayUnaccessData(SAFEARRAY* psa);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayGetElement(
        SAFEARRAY* psa,
        [NativeTypeName("LONG *")] int* rgIndices,
        void* pv
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayPutElement(
        SAFEARRAY* psa,
        [NativeTypeName("LONG *")] int* rgIndices,
        void* pv
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayCopy(SAFEARRAY* psa, SAFEARRAY** ppsaOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayPtrOfIndex(
        SAFEARRAY* psa,
        [NativeTypeName("LONG *")] int* rgIndices,
        void** ppvData
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArraySetRecordInfo(SAFEARRAY* psa, IRecordInfo prinfo);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayGetRecordInfo(SAFEARRAY* psa, IRecordInfo* prinfo);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArraySetIID(
        SAFEARRAY* psa,
        [NativeTypeName("const GUID &")] Guid* guid
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayGetIID(SAFEARRAY* psa, Guid* pguid);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SafeArrayGetVartype(
        SAFEARRAY* psa,
        [NativeTypeName("VARTYPE *")] ushort* pvt
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern SAFEARRAY* SafeArrayCreateVector(
        [NativeTypeName("VARTYPE")] ushort vt,
        [NativeTypeName("LONG")] int lLbound,
        [NativeTypeName("ULONG")] uint cElements
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern SAFEARRAY* SafeArrayCreateVectorEx(
        [NativeTypeName("VARTYPE")] ushort vt,
        [NativeTypeName("LONG")] int lLbound,
        [NativeTypeName("ULONG")] uint cElements,
        [NativeTypeName("PVOID")] void* pvExtra
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern void VariantInit([NativeTypeName("VARIANTARG *")] VARIANT* pvarg);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VariantClear([NativeTypeName("VARIANTARG *")] VARIANT* pvarg);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VariantCopy(
        [NativeTypeName("VARIANTARG *")] VARIANT* pvargDest,
        [NativeTypeName("const VARIANTARG *")] VARIANT* pvargSrc
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VariantCopyInd(
        VARIANT* pvarDest,
        [NativeTypeName("const VARIANTARG *")] VARIANT* pvargSrc
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VariantChangeType(
        [NativeTypeName("VARIANTARG *")] VARIANT* pvargDest,
        [NativeTypeName("const VARIANTARG *")] VARIANT* pvarSrc,
        ushort wFlags,
        [NativeTypeName("VARTYPE")] ushort vt
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VariantChangeTypeEx(
        [NativeTypeName("VARIANTARG *")] VARIANT* pvargDest,
        [NativeTypeName("const VARIANTARG *")] VARIANT* pvarSrc,
        [NativeTypeName("LCID")] uint lcid,
        ushort wFlags,
        [NativeTypeName("VARTYPE")] ushort vt
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VectorFromBstr(
        [NativeTypeName("BSTR")] ushort* bstr,
        SAFEARRAY** ppsa
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT BstrFromVector(
        SAFEARRAY* psa,
        [NativeTypeName("BSTR *")] ushort** pbstr
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromI2(short sIn, byte* pbOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromI4([NativeTypeName("LONG")] int lIn, byte* pbOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromI8([NativeTypeName("LONG64")] long i64In, byte* pbOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromR4(float fltIn, byte* pbOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromR8(double dblIn, byte* pbOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromCy(CY cyIn, byte* pbOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromDate(
        [NativeTypeName("DATE")] double dateIn,
        byte* pbOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        byte* pbOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        byte* pbOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        byte* pbOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromI1([NativeTypeName("CHAR")] sbyte cIn, byte* pbOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromUI2(ushort uiIn, byte* pbOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromUI4([NativeTypeName("ULONG")] uint ulIn, byte* pbOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromUI8(
        [NativeTypeName("ULONG64")] ulong ui64In,
        byte* pbOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI1FromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        byte* pbOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromUI1(byte bIn, short* psOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromI4([NativeTypeName("LONG")] int lIn, short* psOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromI8([NativeTypeName("LONG64")] long i64In, short* psOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromR4(float fltIn, short* psOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromR8(double dblIn, short* psOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromCy(CY cyIn, short* psOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromDate(
        [NativeTypeName("DATE")] double dateIn,
        short* psOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        short* psOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        short* psOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        short* psOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromI1([NativeTypeName("CHAR")] sbyte cIn, short* psOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromUI2(ushort uiIn, short* psOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromUI4([NativeTypeName("ULONG")] uint ulIn, short* psOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromUI8(
        [NativeTypeName("ULONG64")] ulong ui64In,
        short* psOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI2FromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        short* psOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromUI1(byte bIn, [NativeTypeName("LONG *")] int* plOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromI2(short sIn, [NativeTypeName("LONG *")] int* plOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromR4(float fltIn, [NativeTypeName("LONG *")] int* plOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromR8(double dblIn, [NativeTypeName("LONG *")] int* plOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromCy(CY cyIn, [NativeTypeName("LONG *")] int* plOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromDate(
        [NativeTypeName("DATE")] double dateIn,
        [NativeTypeName("LONG *")] int* plOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("LONG *")] int* plOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("LONG *")] int* plOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        [NativeTypeName("LONG *")] int* plOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromI1(
        [NativeTypeName("CHAR")] sbyte cIn,
        [NativeTypeName("LONG *")] int* plOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromUI2(ushort uiIn, [NativeTypeName("LONG *")] int* plOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromUI4(
        [NativeTypeName("ULONG")] uint ulIn,
        [NativeTypeName("LONG *")] int* plOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI4FromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        [NativeTypeName("LONG *")] int* plOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromUI1(byte bIn, [NativeTypeName("LONG64 *")] long* pi64Out);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromI2(short sIn, [NativeTypeName("LONG64 *")] long* pi64Out);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromR4(
        float fltIn,
        [NativeTypeName("LONG64 *")] long* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromR8(
        double dblIn,
        [NativeTypeName("LONG64 *")] long* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromCy(CY cyIn, [NativeTypeName("LONG64 *")] long* pi64Out);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromDate(
        [NativeTypeName("DATE")] double dateIn,
        [NativeTypeName("LONG64 *")] long* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("LONG64 *")] long* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("LONG64 *")] long* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        [NativeTypeName("LONG64 *")] long* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromI1(
        [NativeTypeName("CHAR")] sbyte cIn,
        [NativeTypeName("LONG64 *")] long* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromUI2(
        ushort uiIn,
        [NativeTypeName("LONG64 *")] long* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromUI4(
        [NativeTypeName("ULONG")] uint ulIn,
        [NativeTypeName("LONG64 *")] long* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromUI8(
        [NativeTypeName("ULONG64")] ulong ui64In,
        [NativeTypeName("LONG64 *")] long* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI8FromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        [NativeTypeName("LONG64 *")] long* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromUI1(byte bIn, float* pfltOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromI2(short sIn, float* pfltOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromI4([NativeTypeName("LONG")] int lIn, float* pfltOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromI8([NativeTypeName("LONG64")] long i64In, float* pfltOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromR8(double dblIn, float* pfltOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromCy(CY cyIn, float* pfltOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromDate(
        [NativeTypeName("DATE")] double dateIn,
        float* pfltOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        float* pfltOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        float* pfltOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        float* pfltOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromI1([NativeTypeName("CHAR")] sbyte cIn, float* pfltOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromUI2(ushort uiIn, float* pfltOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromUI4([NativeTypeName("ULONG")] uint ulIn, float* pfltOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromUI8(
        [NativeTypeName("ULONG64")] ulong ui64In,
        float* pfltOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4FromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        float* pfltOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromUI1(byte bIn, double* pdblOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromI2(short sIn, double* pdblOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromI4([NativeTypeName("LONG")] int lIn, double* pdblOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromI8(
        [NativeTypeName("LONG64")] long i64In,
        double* pdblOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromR4(float fltIn, double* pdblOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromCy(CY cyIn, double* pdblOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromDate(
        [NativeTypeName("DATE")] double dateIn,
        double* pdblOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        double* pdblOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        double* pdblOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        double* pdblOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromI1([NativeTypeName("CHAR")] sbyte cIn, double* pdblOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromUI2(ushort uiIn, double* pdblOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromUI4([NativeTypeName("ULONG")] uint ulIn, double* pdblOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromUI8(
        [NativeTypeName("ULONG64")] ulong ui64In,
        double* pdblOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8FromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        double* pdblOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromUI1(
        byte bIn,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromI2(
        short sIn,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromI4(
        [NativeTypeName("LONG")] int lIn,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromI8(
        [NativeTypeName("LONG64")] long i64In,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromR4(
        float fltIn,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromR8(
        double dblIn,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromCy(
        CY cyIn,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromI1(
        [NativeTypeName("CHAR")] sbyte cIn,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromUI2(
        ushort uiIn,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromUI4(
        [NativeTypeName("ULONG")] uint ulIn,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromUI8(
        [NativeTypeName("ULONG64")] ulong ui64In,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromUI1(byte bIn, CY* pcyOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromI2(short sIn, CY* pcyOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromI4([NativeTypeName("LONG")] int lIn, CY* pcyOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromI8([NativeTypeName("LONG64")] long i64In, CY* pcyOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromR4(float fltIn, CY* pcyOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromR8(double dblIn, CY* pcyOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromDate([NativeTypeName("DATE")] double dateIn, CY* pcyOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        CY* pcyOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        CY* pcyOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        CY* pcyOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromI1([NativeTypeName("CHAR")] sbyte cIn, CY* pcyOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromUI2(ushort uiIn, CY* pcyOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromUI4([NativeTypeName("ULONG")] uint ulIn, CY* pcyOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromUI8([NativeTypeName("ULONG64")] ulong ui64In, CY* pcyOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        CY* pcyOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromUI1(
        byte bVal,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromI2(
        short iVal,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromI4(
        [NativeTypeName("LONG")] int lIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromI8(
        [NativeTypeName("LONG64")] long i64In,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromR4(
        float fltIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromR8(
        double dblIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromCy(
        CY cyIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromDate(
        [NativeTypeName("DATE")] double dateIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromI1(
        [NativeTypeName("CHAR")] sbyte cIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromUI2(
        ushort uiIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromUI4(
        [NativeTypeName("ULONG")] uint ulIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromUI8(
        [NativeTypeName("ULONG64")] ulong ui64In,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrFromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromUI1(
        byte bIn,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromI2(
        short sIn,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromI4(
        [NativeTypeName("LONG")] int lIn,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromI8(
        [NativeTypeName("LONG64")] long i64In,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromR4(
        float fltIn,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromR8(
        double dblIn,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromDate(
        [NativeTypeName("DATE")] double dateIn,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromCy(
        CY cyIn,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromI1(
        [NativeTypeName("CHAR")] sbyte cIn,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromUI2(
        ushort uiIn,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromUI4(
        [NativeTypeName("ULONG")] uint ulIn,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromUI8(
        [NativeTypeName("ULONG64")] ulong i64In,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBoolFromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        [NativeTypeName("VARIANT_BOOL *")] short* pboolOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromUI1(byte bIn, [NativeTypeName("CHAR *")] sbyte* pcOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromI2(short uiIn, [NativeTypeName("CHAR *")] sbyte* pcOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromI4(
        [NativeTypeName("LONG")] int lIn,
        [NativeTypeName("CHAR *")] sbyte* pcOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromI8(
        [NativeTypeName("LONG64")] long i64In,
        [NativeTypeName("CHAR *")] sbyte* pcOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromR4(float fltIn, [NativeTypeName("CHAR *")] sbyte* pcOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromR8(double dblIn, [NativeTypeName("CHAR *")] sbyte* pcOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromDate(
        [NativeTypeName("DATE")] double dateIn,
        [NativeTypeName("CHAR *")] sbyte* pcOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromCy(CY cyIn, [NativeTypeName("CHAR *")] sbyte* pcOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("CHAR *")] sbyte* pcOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("CHAR *")] sbyte* pcOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        [NativeTypeName("CHAR *")] sbyte* pcOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromUI2(ushort uiIn, [NativeTypeName("CHAR *")] sbyte* pcOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromUI4(
        [NativeTypeName("ULONG")] uint ulIn,
        [NativeTypeName("CHAR *")] sbyte* pcOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromUI8(
        [NativeTypeName("ULONG64")] ulong i64In,
        [NativeTypeName("CHAR *")] sbyte* pcOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarI1FromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        [NativeTypeName("CHAR *")] sbyte* pcOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromUI1(byte bIn, ushort* puiOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromI2(short uiIn, ushort* puiOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromI4([NativeTypeName("LONG")] int lIn, ushort* puiOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromI8(
        [NativeTypeName("LONG64")] long i64In,
        ushort* puiOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromR4(float fltIn, ushort* puiOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromR8(double dblIn, ushort* puiOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromDate(
        [NativeTypeName("DATE")] double dateIn,
        ushort* puiOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromCy(CY cyIn, ushort* puiOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        ushort* puiOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        ushort* puiOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        ushort* puiOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromI1([NativeTypeName("CHAR")] sbyte cIn, ushort* puiOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromUI4([NativeTypeName("ULONG")] uint ulIn, ushort* puiOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromUI8(
        [NativeTypeName("ULONG64")] ulong i64In,
        ushort* puiOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI2FromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        ushort* puiOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromUI1(byte bIn, [NativeTypeName("ULONG *")] uint* pulOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromI2(short uiIn, [NativeTypeName("ULONG *")] uint* pulOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromI4(
        [NativeTypeName("LONG")] int lIn,
        [NativeTypeName("ULONG *")] uint* pulOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromI8(
        [NativeTypeName("LONG64")] long i64In,
        [NativeTypeName("ULONG *")] uint* plOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromR4(
        float fltIn,
        [NativeTypeName("ULONG *")] uint* pulOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromR8(
        double dblIn,
        [NativeTypeName("ULONG *")] uint* pulOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromDate(
        [NativeTypeName("DATE")] double dateIn,
        [NativeTypeName("ULONG *")] uint* pulOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromCy(CY cyIn, [NativeTypeName("ULONG *")] uint* pulOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("ULONG *")] uint* pulOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG *")] uint* pulOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        [NativeTypeName("ULONG *")] uint* pulOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromI1(
        [NativeTypeName("CHAR")] sbyte cIn,
        [NativeTypeName("ULONG *")] uint* pulOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromUI2(
        ushort uiIn,
        [NativeTypeName("ULONG *")] uint* pulOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromUI8(
        [NativeTypeName("ULONG64")] ulong ui64In,
        [NativeTypeName("ULONG *")] uint* plOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI4FromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        [NativeTypeName("ULONG *")] uint* pulOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromUI1(
        byte bIn,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromI2(
        short sIn,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromI8(
        [NativeTypeName("LONG64")] long ui64In,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromR4(
        float fltIn,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromR8(
        double dblIn,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromCy(
        CY cyIn,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromDate(
        [NativeTypeName("DATE")] double dateIn,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromI1(
        [NativeTypeName("CHAR")] sbyte cIn,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromUI2(
        ushort uiIn,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromUI4(
        [NativeTypeName("ULONG")] uint ulIn,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUI8FromDec(
        [NativeTypeName("const DECIMAL *")] DECIMAL* pdecIn,
        [NativeTypeName("ULONG64 *")] ulong* pi64Out
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromUI1(byte bIn, DECIMAL* pdecOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromI2(short uiIn, DECIMAL* pdecOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromI4([NativeTypeName("LONG")] int lIn, DECIMAL* pdecOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromI8(
        [NativeTypeName("LONG64")] long i64In,
        DECIMAL* pdecOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromR4(float fltIn, DECIMAL* pdecOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromR8(double dblIn, DECIMAL* pdecOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromDate(
        [NativeTypeName("DATE")] double dateIn,
        DECIMAL* pdecOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromCy(CY cyIn, DECIMAL* pdecOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        DECIMAL* pdecOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromDisp(
        IDispatch pdispIn,
        [NativeTypeName("LCID")] uint lcid,
        DECIMAL* pdecOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromBool(
        [NativeTypeName("VARIANT_BOOL")] short boolIn,
        DECIMAL* pdecOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromI1([NativeTypeName("CHAR")] sbyte cIn, DECIMAL* pdecOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromUI2(ushort uiIn, DECIMAL* pdecOut);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromUI4(
        [NativeTypeName("ULONG")] uint ulIn,
        DECIMAL* pdecOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFromUI8(
        [NativeTypeName("ULONG64")] ulong ui64In,
        DECIMAL* pdecOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarParseNumFromStr(
        [NativeTypeName("LPCOLESTR")] ushort* strIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        NUMPARSE* pnumprs,
        byte* rgbDig
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarNumFromParseNum(
        NUMPARSE* pnumprs,
        byte* rgbDig,
        [NativeTypeName("ULONG")] uint dwVtBits,
        VARIANT* pvar
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarAdd(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarAnd(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCat(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDiv(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarEqv(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarIdiv(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarImp(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarMod(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarMul(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarOr(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarPow(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarSub(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarXor(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarAbs(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarIn,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarFix(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarIn,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarInt(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarIn,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarNeg(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarIn,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarNot(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarIn,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarRound(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarIn,
        int cDecimals,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCmp(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags
    );

    public static HRESULT VarCmp(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarLeft,
        [NativeTypeName("LPVARIANT")] VARIANT* pvarRight,
        [NativeTypeName("LCID")] uint lcid
    )
    {
        return VarCmp(pvarLeft, pvarRight, lcid, 0);
    }

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecAdd(
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecLeft,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecRight,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecDiv(
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecLeft,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecRight,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecMul(
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecLeft,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecRight,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecSub(
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecLeft,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecRight,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecAbs(
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecIn,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecFix(
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecIn,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecInt(
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecIn,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecNeg(
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecIn,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecRound(
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecIn,
        int cDecimals,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecCmp(
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecLeft,
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecRight
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDecCmpR8(
        [NativeTypeName("LPDECIMAL")] DECIMAL* pdecLeft,
        double dblRight
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyAdd(
        CY cyLeft,
        CY cyRight,
        [NativeTypeName("LPCY")] CY* pcyResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyMul(
        CY cyLeft,
        CY cyRight,
        [NativeTypeName("LPCY")] CY* pcyResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyMulI4(
        CY cyLeft,
        [NativeTypeName("LONG")] int lRight,
        [NativeTypeName("LPCY")] CY* pcyResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyMulI8(
        CY cyLeft,
        [NativeTypeName("LONG64")] long lRight,
        [NativeTypeName("LPCY")] CY* pcyResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCySub(
        CY cyLeft,
        CY cyRight,
        [NativeTypeName("LPCY")] CY* pcyResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyAbs(CY cyIn, [NativeTypeName("LPCY")] CY* pcyResult);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyFix(CY cyIn, [NativeTypeName("LPCY")] CY* pcyResult);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyInt(CY cyIn, [NativeTypeName("LPCY")] CY* pcyResult);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyNeg(CY cyIn, [NativeTypeName("LPCY")] CY* pcyResult);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyRound(
        CY cyIn,
        int cDecimals,
        [NativeTypeName("LPCY")] CY* pcyResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyCmp(CY cyLeft, CY cyRight);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarCyCmpR8(CY cyLeft, double dblRight);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrCat(
        [NativeTypeName("BSTR")] ushort* bstrLeft,
        [NativeTypeName("BSTR")] ushort* bstrRight,
        [NativeTypeName("LPBSTR")] ushort** pbstrResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarBstrCmp(
        [NativeTypeName("BSTR")] ushort* bstrLeft,
        [NativeTypeName("BSTR")] ushort* bstrRight,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8Pow(double dblLeft, double dblRight, double* pdblResult);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR4CmpR8(float fltLeft, double dblRight);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarR8Round(double dblIn, int cDecimals, double* pdblResult);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromUdate(
        UDATE* pudateIn,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarDateFromUdateEx(
        UDATE* pudateIn,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("DATE *")] double* pdateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarUdateFromDate(
        [NativeTypeName("DATE")] double dateIn,
        [NativeTypeName("ULONG")] uint dwFlags,
        UDATE* pudateOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT GetAltMonthNames(
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("LPOLESTR **")] ushort*** prgp
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarFormat(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarIn,
        [NativeTypeName("LPOLESTR")] ushort* pstrFormat,
        int iFirstDay,
        int iFirstWeek,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarFormatDateTime(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarIn,
        int iNamedFormat,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarFormatNumber(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarIn,
        int iNumDig,
        int iIncLead,
        int iUseParens,
        int iGroup,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarFormatPercent(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarIn,
        int iNumDig,
        int iIncLead,
        int iUseParens,
        int iGroup,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarFormatCurrency(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarIn,
        int iNumDig,
        int iIncLead,
        int iUseParens,
        int iGroup,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarWeekdayName(
        int iWeekday,
        int fAbbrev,
        int iFirstDay,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarMonthName(
        int iMonth,
        int fAbbrev,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarFormatFromTokens(
        [NativeTypeName("LPVARIANT")] VARIANT* pvarIn,
        [NativeTypeName("LPOLESTR")] ushort* pstrFormat,
        [NativeTypeName("LPBYTE")] byte* pbTokCur,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("BSTR *")] ushort** pbstrOut,
        [NativeTypeName("LCID")] uint lcid
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT VarTokenizeFormatString(
        [NativeTypeName("LPOLESTR")] ushort* pstrFormat,
        [NativeTypeName("LPBYTE")] byte* rgbTok,
        int cbTok,
        int iFirstDay,
        int iFirstWeek,
        [NativeTypeName("LCID")] uint lcid,
        int* pcbActual
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint LHashValOfNameSysA(
        SYSKIND syskind,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("LPCSTR")] sbyte* szName
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint LHashValOfNameSys(
        SYSKIND syskind,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("const OLECHAR *")] ushort* szName
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT LoadTypeLib(
        [NativeTypeName("LPCOLESTR")] ushort* szFile,
        ITypeLib* pptlib
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT LoadTypeLibEx(
        [NativeTypeName("LPCOLESTR")] ushort* szFile,
        REGKIND regkind,
        ITypeLib* pptlib
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT LoadRegTypeLib(
        [NativeTypeName("const GUID &")] Guid* rguid,
        [NativeTypeName("WORD")] ushort wVerMajor,
        [NativeTypeName("WORD")] ushort wVerMinor,
        [NativeTypeName("LCID")] uint lcid,
        ITypeLib* pptlib
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT QueryPathOfRegTypeLib(
        [NativeTypeName("const GUID &")] Guid* guid,
        ushort wMaj,
        ushort wMin,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("LPBSTR")] ushort** lpbstrPathName
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT RegisterTypeLib(
        ITypeLib ptlib,
        [NativeTypeName("LPCOLESTR")] ushort* szFullPath,
        [NativeTypeName("LPCOLESTR")] ushort* szHelpDir
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT UnRegisterTypeLib(
        [NativeTypeName("const GUID &")] Guid* libID,
        [NativeTypeName("WORD")] ushort wVerMajor,
        [NativeTypeName("WORD")] ushort wVerMinor,
        [NativeTypeName("LCID")] uint lcid,
        SYSKIND syskind
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT RegisterTypeLibForUser(
        ITypeLib ptlib,
        [NativeTypeName("OLECHAR *")] ushort* szFullPath,
        [NativeTypeName("OLECHAR *")] ushort* szHelpDir
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT UnRegisterTypeLibForUser(
        [NativeTypeName("const GUID &")] Guid* libID,
        [NativeTypeName("WORD")] ushort wMajorVerNum,
        [NativeTypeName("WORD")] ushort wMinorVerNum,
        [NativeTypeName("LCID")] uint lcid,
        SYSKIND syskind
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT CreateTypeLib(
        SYSKIND syskind,
        [NativeTypeName("LPCOLESTR")] ushort* szFile,
        ICreateTypeLib* ppctlib
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT CreateTypeLib2(
        SYSKIND syskind,
        [NativeTypeName("LPCOLESTR")] ushort* szFile,
        ICreateTypeLib2* ppctlib
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT DispGetParam(
        DISPPARAMS* pdispparams,
        uint position,
        [NativeTypeName("VARTYPE")] ushort vtTarg,
        VARIANT* pvarResult,
        uint* puArgErr
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT DispGetIDsOfNames(
        ITypeInfo ptinfo,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("DISPID *")] int* rgdispid
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT DispInvoke(
        void* _this,
        ITypeInfo ptinfo,
        [NativeTypeName("DISPID")] int dispidMember,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pparams,
        VARIANT* pvarResult,
        EXCEPINFO* pexcepinfo,
        uint* puArgErr
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT CreateDispTypeInfo(
        INTERFACEDATA* pidata,
        [NativeTypeName("LCID")] uint lcid,
        ITypeInfo* pptinfo
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT CreateStdDispatch(
        IUnknown punkOuter,
        void* pvThis,
        ITypeInfo ptinfo,
        IUnknown* ppunkStdDisp
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT DispCallFunc(
        void* pvInstance,
        [NativeTypeName("ULONG_PTR")] nuint oVft,
        CALLCONV cc,
        [NativeTypeName("VARTYPE")] ushort vtReturn,
        uint cActuals,
        [NativeTypeName("VARTYPE *")] ushort* prgvt,
        [NativeTypeName("VARIANTARG **")] VARIANT** prgpvarg,
        VARIANT* pvargResult
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT RegisterActiveObject(
        IUnknown punk,
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD *")] uint* pdwRegister
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT RevokeActiveObject(
        [NativeTypeName("DWORD")] uint dwRegister,
        void* pvReserved
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT GetActiveObject(
        [NativeTypeName("const IID &")] Guid* rclsid,
        void* pvReserved,
        IUnknown* ppunk
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT SetErrorInfo(
        [NativeTypeName("ULONG")] uint dwReserved,
        IErrorInfo perrinfo
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT GetErrorInfo(
        [NativeTypeName("ULONG")] uint dwReserved,
        IErrorInfo* pperrinfo
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT CreateErrorInfo(ICreateErrorInfo* pperrinfo);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT GetRecordInfoFromTypeInfo(
        ITypeInfo pTypeInfo,
        IRecordInfo* ppRecInfo
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern HRESULT GetRecordInfoFromGuids(
        [NativeTypeName("const GUID &")] Guid* rGuidTypeLib,
        [NativeTypeName("ULONG")] uint uVerMajor,
        [NativeTypeName("ULONG")] uint uVerMinor,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("const GUID &")] Guid* rGuidTypeInfo,
        IRecordInfo* ppRecInfo
    );

    [DllImport("oleaut32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint OaBuildVersion();

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern void ClearCustData([NativeTypeName("LPCUSTDATA")] CUSTDATA* pCustData);

    [DllImport("oleaut32", ExactSpelling = true)]
    public static extern void OaEnablePerUserTLibRegistration();

    [NativeTypeName("#define STDOLE_MAJORVERNUM 0x1")]
    public const int STDOLE_MAJORVERNUM = 0x1;

    [NativeTypeName("#define STDOLE_MINORVERNUM 0x0")]
    public const int STDOLE_MINORVERNUM = 0x0;

    [NativeTypeName("#define STDOLE_LCID 0x0000")]
    public const int STDOLE_LCID = 0x0000;

    [NativeTypeName("#define STDOLE2_MAJORVERNUM 0x2")]
    public const int STDOLE2_MAJORVERNUM = 0x2;

    [NativeTypeName("#define STDOLE2_MINORVERNUM 0x0")]
    public const int STDOLE2_MINORVERNUM = 0x0;

    [NativeTypeName("#define STDOLE2_LCID 0x0000")]
    public const int STDOLE2_LCID = 0x0000;

    [NativeTypeName("#define VARIANT_NOVALUEPROP 0x01")]
    public const int VARIANT_NOVALUEPROP = 0x01;

    [NativeTypeName("#define VARIANT_ALPHABOOL 0x02")]
    public const int VARIANT_ALPHABOOL = 0x02;

    [NativeTypeName("#define VARIANT_NOUSEROVERRIDE 0x04")]
    public const int VARIANT_NOUSEROVERRIDE = 0x04;

    [NativeTypeName("#define VARIANT_CALENDAR_HIJRI 0x08")]
    public const int VARIANT_CALENDAR_HIJRI = 0x08;

    [NativeTypeName("#define VARIANT_LOCALBOOL 0x10")]
    public const int VARIANT_LOCALBOOL = 0x10;

    [NativeTypeName("#define VARIANT_CALENDAR_THAI 0x20")]
    public const int VARIANT_CALENDAR_THAI = 0x20;

    [NativeTypeName("#define VARIANT_CALENDAR_GREGORIAN 0x40")]
    public const int VARIANT_CALENDAR_GREGORIAN = 0x40;

    [NativeTypeName("#define VARIANT_USE_NLS 0x80")]
    public const int VARIANT_USE_NLS = 0x80;

    [NativeTypeName("#define VAR_TIMEVALUEONLY ((DWORD)0x00000001)")]
    public const uint VAR_TIMEVALUEONLY = ((uint)(0x00000001));

    [NativeTypeName("#define VAR_DATEVALUEONLY ((DWORD)0x00000002)")]
    public const uint VAR_DATEVALUEONLY = ((uint)(0x00000002));

    [NativeTypeName("#define VAR_VALIDDATE ((DWORD)0x00000004)")]
    public const uint VAR_VALIDDATE = ((uint)(0x00000004));

    [NativeTypeName("#define VAR_CALENDAR_HIJRI ((DWORD)0x00000008)")]
    public const uint VAR_CALENDAR_HIJRI = ((uint)(0x00000008));

    [NativeTypeName("#define VAR_LOCALBOOL ((DWORD)0x00000010)")]
    public const uint VAR_LOCALBOOL = ((uint)(0x00000010));

    [NativeTypeName("#define VAR_FORMAT_NOSUBSTITUTE ((DWORD)0x00000020)")]
    public const uint VAR_FORMAT_NOSUBSTITUTE = ((uint)(0x00000020));

    [NativeTypeName("#define VAR_FOURDIGITYEARS ((DWORD)0x00000040)")]
    public const uint VAR_FOURDIGITYEARS = ((uint)(0x00000040));

    [NativeTypeName("#define VAR_CALENDAR_THAI ((DWORD)0x00000080)")]
    public const uint VAR_CALENDAR_THAI = ((uint)(0x00000080));

    [NativeTypeName("#define VAR_CALENDAR_GREGORIAN ((DWORD)0x00000100)")]
    public const uint VAR_CALENDAR_GREGORIAN = ((uint)(0x00000100));

    [NativeTypeName("#define VTDATEGRE_MAX 2958465")]
    public const int VTDATEGRE_MAX = 2958465;

    [NativeTypeName("#define VTDATEGRE_MIN -657434")]
    public const int VTDATEGRE_MIN = -657434;

    [NativeTypeName("#define VarUI1FromInt VarUI1FromI4")]
    public static delegate* <int, byte*, HRESULT> VarUI1FromInt => &VarUI1FromI4;

    [NativeTypeName("#define VarUI1FromUint VarUI1FromUI4")]
    public static delegate* <uint, byte*, HRESULT> VarUI1FromUint => &VarUI1FromUI4;

    [NativeTypeName("#define VarI2FromInt VarI2FromI4")]
    public static delegate* <int, short*, HRESULT> VarI2FromInt => &VarI2FromI4;

    [NativeTypeName("#define VarI2FromUint VarI2FromUI4")]
    public static delegate* <uint, short*, HRESULT> VarI2FromUint => &VarI2FromUI4;

    [NativeTypeName("#define VarI4FromUint VarI4FromUI4")]
    public static delegate* <uint, int*, HRESULT> VarI4FromUint => &VarI4FromUI4;

    [NativeTypeName("#define VarI8FromUint VarI8FromUI4")]
    public static delegate* <uint, long*, HRESULT> VarI8FromUint => &VarI8FromUI4;

    [NativeTypeName("#define VarR4FromInt VarR4FromI4")]
    public static delegate* <int, float*, HRESULT> VarR4FromInt => &VarR4FromI4;

    [NativeTypeName("#define VarR4FromUint VarR4FromUI4")]
    public static delegate* <uint, float*, HRESULT> VarR4FromUint => &VarR4FromUI4;

    [NativeTypeName("#define VarR8FromInt VarR8FromI4")]
    public static delegate* <int, double*, HRESULT> VarR8FromInt => &VarR8FromI4;

    [NativeTypeName("#define VarR8FromUint VarR8FromUI4")]
    public static delegate* <uint, double*, HRESULT> VarR8FromUint => &VarR8FromUI4;

    [NativeTypeName("#define VarDateFromInt VarDateFromI4")]
    public static delegate* <int, double*, HRESULT> VarDateFromInt => &VarDateFromI4;

    [NativeTypeName("#define VarDateFromUint VarDateFromUI4")]
    public static delegate* <uint, double*, HRESULT> VarDateFromUint => &VarDateFromUI4;

    [NativeTypeName("#define VarCyFromInt VarCyFromI4")]
    public static delegate* <int, CY*, HRESULT> VarCyFromInt => &VarCyFromI4;

    [NativeTypeName("#define VarCyFromUint VarCyFromUI4")]
    public static delegate* <uint, CY*, HRESULT> VarCyFromUint => &VarCyFromUI4;

    [NativeTypeName("#define VarBstrFromInt VarBstrFromI4")]
    public static delegate* <int, uint, uint, ushort**, HRESULT> VarBstrFromInt => &VarBstrFromI4;

    [NativeTypeName("#define VarBstrFromUint VarBstrFromUI4")]
    public static delegate* <uint, uint, uint, ushort**, HRESULT> VarBstrFromUint =>
        &VarBstrFromUI4;

    [NativeTypeName("#define VarBoolFromInt VarBoolFromI4")]
    public static delegate* <int, short*, HRESULT> VarBoolFromInt => &VarBoolFromI4;

    [NativeTypeName("#define VarBoolFromUint VarBoolFromUI4")]
    public static delegate* <uint, short*, HRESULT> VarBoolFromUint => &VarBoolFromUI4;

    [NativeTypeName("#define VarI1FromInt VarI1FromI4")]
    public static delegate* <int, sbyte*, HRESULT> VarI1FromInt => &VarI1FromI4;

    [NativeTypeName("#define VarI1FromUint VarI1FromUI4")]
    public static delegate* <uint, sbyte*, HRESULT> VarI1FromUint => &VarI1FromUI4;

    [NativeTypeName("#define VarUI2FromInt VarUI2FromI4")]
    public static delegate* <int, ushort*, HRESULT> VarUI2FromInt => &VarUI2FromI4;

    [NativeTypeName("#define VarUI2FromUint VarUI2FromUI4")]
    public static delegate* <uint, ushort*, HRESULT> VarUI2FromUint => &VarUI2FromUI4;

    [NativeTypeName("#define VarUI4FromInt VarUI4FromI4")]
    public static delegate* <int, uint*, HRESULT> VarUI4FromInt => &VarUI4FromI4;

    [NativeTypeName("#define VarDecFromInt VarDecFromI4")]
    public static delegate* <int, DECIMAL*, HRESULT> VarDecFromInt => &VarDecFromI4;

    [NativeTypeName("#define VarDecFromUint VarDecFromUI4")]
    public static delegate* <uint, DECIMAL*, HRESULT> VarDecFromUint => &VarDecFromUI4;

    [NativeTypeName("#define VarIntFromUI1 VarI4FromUI1")]
    public static delegate* <byte, int*, HRESULT> VarIntFromUI1 => &VarI4FromUI1;

    [NativeTypeName("#define VarIntFromI2 VarI4FromI2")]
    public static delegate* <short, int*, HRESULT> VarIntFromI2 => &VarI4FromI2;

    [NativeTypeName("#define VarIntFromI8 VarI4FromI8")]
    public static delegate* <long, int*, HRESULT> VarIntFromI8 => &VarI4FromI8;

    [NativeTypeName("#define VarIntFromR4 VarI4FromR4")]
    public static delegate* <float, int*, HRESULT> VarIntFromR4 => &VarI4FromR4;

    [NativeTypeName("#define VarIntFromR8 VarI4FromR8")]
    public static delegate* <double, int*, HRESULT> VarIntFromR8 => &VarI4FromR8;

    [NativeTypeName("#define VarIntFromDate VarI4FromDate")]
    public static delegate* <double, int*, HRESULT> VarIntFromDate => &VarI4FromDate;

    [NativeTypeName("#define VarIntFromCy VarI4FromCy")]
    public static delegate* <CY, int*, HRESULT> VarIntFromCy => &VarI4FromCy;

    [NativeTypeName("#define VarIntFromStr VarI4FromStr")]
    public static delegate* <ushort*, uint, uint, int*, HRESULT> VarIntFromStr => &VarI4FromStr;

    [NativeTypeName("#define VarIntFromDisp VarI4FromDisp")]
    public static delegate* <IDispatch, uint, int*, HRESULT> VarIntFromDisp => &VarI4FromDisp;

    [NativeTypeName("#define VarIntFromBool VarI4FromBool")]
    public static delegate* <short, int*, HRESULT> VarIntFromBool => &VarI4FromBool;

    [NativeTypeName("#define VarIntFromI1 VarI4FromI1")]
    public static delegate* <sbyte, int*, HRESULT> VarIntFromI1 => &VarI4FromI1;

    [NativeTypeName("#define VarIntFromUI2 VarI4FromUI2")]
    public static delegate* <ushort, int*, HRESULT> VarIntFromUI2 => &VarI4FromUI2;

    [NativeTypeName("#define VarIntFromUI4 VarI4FromUI4")]
    public static delegate* <uint, int*, HRESULT> VarIntFromUI4 => &VarI4FromUI4;

    [NativeTypeName("#define VarIntFromUI8 VarI4FromUI8")]
    public static delegate* <ulong, int*, HRESULT> VarIntFromUI8 => &VarI4FromUI8;

    [NativeTypeName("#define VarIntFromDec VarI4FromDec")]
    public static delegate* <DECIMAL*, int*, HRESULT> VarIntFromDec => &VarI4FromDec;

    [NativeTypeName("#define VarIntFromUint VarI4FromUI4")]
    public static delegate* <uint, int*, HRESULT> VarIntFromUint => &VarI4FromUI4;

    [NativeTypeName("#define VarUintFromUI1 VarUI4FromUI1")]
    public static delegate* <byte, uint*, HRESULT> VarUintFromUI1 => &VarUI4FromUI1;

    [NativeTypeName("#define VarUintFromI2 VarUI4FromI2")]
    public static delegate* <short, uint*, HRESULT> VarUintFromI2 => &VarUI4FromI2;

    [NativeTypeName("#define VarUintFromI4 VarUI4FromI4")]
    public static delegate* <int, uint*, HRESULT> VarUintFromI4 => &VarUI4FromI4;

    [NativeTypeName("#define VarUintFromI8 VarUI4FromI8")]
    public static delegate* <long, uint*, HRESULT> VarUintFromI8 => &VarUI4FromI8;

    [NativeTypeName("#define VarUintFromR4 VarUI4FromR4")]
    public static delegate* <float, uint*, HRESULT> VarUintFromR4 => &VarUI4FromR4;

    [NativeTypeName("#define VarUintFromR8 VarUI4FromR8")]
    public static delegate* <double, uint*, HRESULT> VarUintFromR8 => &VarUI4FromR8;

    [NativeTypeName("#define VarUintFromDate VarUI4FromDate")]
    public static delegate* <double, uint*, HRESULT> VarUintFromDate => &VarUI4FromDate;

    [NativeTypeName("#define VarUintFromCy VarUI4FromCy")]
    public static delegate* <CY, uint*, HRESULT> VarUintFromCy => &VarUI4FromCy;

    [NativeTypeName("#define VarUintFromStr VarUI4FromStr")]
    public static delegate* <ushort*, uint, uint, uint*, HRESULT> VarUintFromStr => &VarUI4FromStr;

    [NativeTypeName("#define VarUintFromDisp VarUI4FromDisp")]
    public static delegate* <IDispatch, uint, uint*, HRESULT> VarUintFromDisp => &VarUI4FromDisp;

    [NativeTypeName("#define VarUintFromBool VarUI4FromBool")]
    public static delegate* <short, uint*, HRESULT> VarUintFromBool => &VarUI4FromBool;

    [NativeTypeName("#define VarUintFromI1 VarUI4FromI1")]
    public static delegate* <sbyte, uint*, HRESULT> VarUintFromI1 => &VarUI4FromI1;

    [NativeTypeName("#define VarUintFromUI2 VarUI4FromUI2")]
    public static delegate* <ushort, uint*, HRESULT> VarUintFromUI2 => &VarUI4FromUI2;

    [NativeTypeName("#define VarUintFromUI8 VarUI4FromUI8")]
    public static delegate* <ulong, uint*, HRESULT> VarUintFromUI8 => &VarUI4FromUI8;

    [NativeTypeName("#define VarUintFromDec VarUI4FromDec")]
    public static delegate* <DECIMAL*, uint*, HRESULT> VarUintFromDec => &VarUI4FromDec;

    [NativeTypeName("#define VarUintFromInt VarUI4FromI4")]
    public static delegate* <int, uint*, HRESULT> VarUintFromInt => &VarUI4FromI4;

    [NativeTypeName("#define VT_HARDTYPE VT_RESERVED")]
    public const VARENUM VT_HARDTYPE = VT_RESERVED;

    [NativeTypeName("#define MEMBERID_NIL DISPID_UNKNOWN")]
    public const int MEMBERID_NIL = (-1);

    [NativeTypeName("#define DISPATCH_METHOD 0x1")]
    public const int DISPATCH_METHOD = 0x1;

    [NativeTypeName("#define DISPATCH_PROPERTYGET 0x2")]
    public const int DISPATCH_PROPERTYGET = 0x2;

    [NativeTypeName("#define DISPATCH_PROPERTYPUT 0x4")]
    public const int DISPATCH_PROPERTYPUT = 0x4;

    [NativeTypeName("#define DISPATCH_PROPERTYPUTREF 0x8")]
    public const int DISPATCH_PROPERTYPUTREF = 0x8;

    [NativeTypeName("#define MASK_TO_RESET_TLB_BITS ~(LOAD_TLB_AS_32BIT | LOAD_TLB_AS_64BIT)")]
    public const int MASK_TO_RESET_TLB_BITS = ~(0x20 | 0x40);

    [NativeTypeName("#define ACTIVEOBJECT_STRONG 0x0")]
    public const int ACTIVEOBJECT_STRONG = 0x0;

    [NativeTypeName("#define ACTIVEOBJECT_WEAK 0x1")]
    public const int ACTIVEOBJECT_WEAK = 0x1;
}
