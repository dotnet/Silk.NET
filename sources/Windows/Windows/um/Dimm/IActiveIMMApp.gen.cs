// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp"]/*'/>
[Guid("08C0E040-62D1-11D1-9326-0060B067B86E")]
[NativeTypeName("struct IActiveIMMApp : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IActiveIMMApp : IActiveIMMApp.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActiveIMMApp));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, Guid*, void**, int> )(lpVtbl[0]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IActiveIMMApp*, uint> )(lpVtbl[1]))((IActiveIMMApp*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActiveIMMApp*, uint> )(lpVtbl[2]))((IActiveIMMApp*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.AssociateContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AssociateContext(HWND hWnd, HIMC hIME, HIMC* phPrev)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HWND, HIMC, HIMC*, int> )(lpVtbl[3]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, hIME, phPrev);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.ConfigureIMEA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ConfigureIMEA(HKL hKL, HWND hWnd, [NativeTypeName("DWORD")] uint dwMode, REGISTERWORDA* pData)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, HWND, uint, REGISTERWORDA*, int> )(lpVtbl[4]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, hWnd, dwMode, pData);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.ConfigureIMEW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ConfigureIMEW(HKL hKL, HWND hWnd, [NativeTypeName("DWORD")] uint dwMode, REGISTERWORDW* pData)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, HWND, uint, REGISTERWORDW*, int> )(lpVtbl[5]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, hWnd, dwMode, pData);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.CreateContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateContext(HIMC* phIMC)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC*, int> )(lpVtbl[6]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), phIMC);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.DestroyContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DestroyContext(HIMC hIME)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, int> )(lpVtbl[7]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIME);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.EnumRegisterWordA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnumRegisterWordA(HKL hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szRegister, [NativeTypeName("LPVOID")] void* pData, IEnumRegisterWordA** pEnum)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, sbyte*, uint, sbyte*, void*, IEnumRegisterWordA**, int> )(lpVtbl[8]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister, pData, pEnum);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.EnumRegisterWordW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnumRegisterWordW(HKL hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szRegister, [NativeTypeName("LPVOID")] void* pData, IEnumRegisterWordW** pEnum)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, ushort*, uint, ushort*, void*, IEnumRegisterWordW**, int> )(lpVtbl[9]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister, pData, pEnum);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.EscapeA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EscapeA(HKL hKL, HIMC hIMC, uint uEscape, [NativeTypeName("LPVOID")] void* pData, LRESULT* plResult)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, HIMC, uint, void*, LRESULT*, int> )(lpVtbl[10]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, hIMC, uEscape, pData, plResult);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.EscapeW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EscapeW(HKL hKL, HIMC hIMC, uint uEscape, [NativeTypeName("LPVOID")] void* pData, LRESULT* plResult)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, HIMC, uint, void*, LRESULT*, int> )(lpVtbl[11]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, hIMC, uEscape, pData, plResult);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetCandidateListA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCandidateListA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, uint uBufLen, CANDIDATELIST* pCandList, uint* puCopied)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, uint, CANDIDATELIST*, uint*, int> )(lpVtbl[12]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, uBufLen, pCandList, puCopied);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetCandidateListW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCandidateListW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, uint uBufLen, CANDIDATELIST* pCandList, uint* puCopied)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, uint, CANDIDATELIST*, uint*, int> )(lpVtbl[13]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, uBufLen, pCandList, puCopied);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetCandidateListCountA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCandidateListCountA(HIMC hIMC, [NativeTypeName("DWORD *")] uint* pdwListSize, [NativeTypeName("DWORD *")] uint* pdwBufLen)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint*, uint*, int> )(lpVtbl[14]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pdwListSize, pdwBufLen);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetCandidateListCountW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetCandidateListCountW(HIMC hIMC, [NativeTypeName("DWORD *")] uint* pdwListSize, [NativeTypeName("DWORD *")] uint* pdwBufLen)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint*, uint*, int> )(lpVtbl[15]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pdwListSize, pdwBufLen);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetCandidateWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetCandidateWindow(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, CANDIDATEFORM* pCandidate)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, CANDIDATEFORM*, int> )(lpVtbl[16]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pCandidate);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetCompositionFontA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetCompositionFontA(HIMC hIMC, LOGFONTA* plf)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, LOGFONTA*, int> )(lpVtbl[17]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, plf);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetCompositionFontW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetCompositionFontW(HIMC hIMC, LOGFONTW* plf)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, LOGFONTW*, int> )(lpVtbl[18]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, plf);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetCompositionStringA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetCompositionStringA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LONG *")] int* plCopied, [NativeTypeName("LPVOID")] void* pBuf)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, uint, int*, void*, int> )(lpVtbl[19]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, plCopied, pBuf);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetCompositionStringW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetCompositionStringW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LONG *")] int* plCopied, [NativeTypeName("LPVOID")] void* pBuf)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, uint, int*, void*, int> )(lpVtbl[20]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, plCopied, pBuf);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetCompositionWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetCompositionWindow(HIMC hIMC, COMPOSITIONFORM* pCompForm)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, COMPOSITIONFORM*, int> )(lpVtbl[21]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pCompForm);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetContext(HWND hWnd, HIMC* phIMC)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HWND, HIMC*, int> )(lpVtbl[22]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, phIMC);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetConversionListA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetConversionListA(HKL hKL, HIMC hIMC, [NativeTypeName("LPSTR")] sbyte* pSrc, uint uBufLen, uint uFlag, CANDIDATELIST* pDst, uint* puCopied)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, HIMC, sbyte*, uint, uint, CANDIDATELIST*, uint*, int> )(lpVtbl[23]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, hIMC, pSrc, uBufLen, uFlag, pDst, puCopied);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetConversionListW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetConversionListW(HKL hKL, HIMC hIMC, [NativeTypeName("LPWSTR")] ushort* pSrc, uint uBufLen, uint uFlag, CANDIDATELIST* pDst, uint* puCopied)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, HIMC, ushort*, uint, uint, CANDIDATELIST*, uint*, int> )(lpVtbl[24]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, hIMC, pSrc, uBufLen, uFlag, pDst, puCopied);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetConversionStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetConversionStatus(HIMC hIMC, [NativeTypeName("DWORD *")] uint* pfdwConversion, [NativeTypeName("DWORD *")] uint* pfdwSentence)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint*, uint*, int> )(lpVtbl[25]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pfdwConversion, pfdwSentence);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetDefaultIMEWnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetDefaultIMEWnd(HWND hWnd, HWND* phDefWnd)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HWND, HWND*, int> )(lpVtbl[26]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, phDefWnd);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetDescriptionA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetDescriptionA(HKL hKL, uint uBufLen, [NativeTypeName("LPSTR")] sbyte* szDescription, uint* puCopied)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, uint, sbyte*, uint*, int> )(lpVtbl[27]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, uBufLen, szDescription, puCopied);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetDescriptionW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetDescriptionW(HKL hKL, uint uBufLen, [NativeTypeName("LPWSTR")] ushort* szDescription, uint* puCopied)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, uint, ushort*, uint*, int> )(lpVtbl[28]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, uBufLen, szDescription, puCopied);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetGuideLineA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetGuideLineA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LPSTR")] sbyte* pBuf, [NativeTypeName("DWORD *")] uint* pdwResult)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, uint, sbyte*, uint*, int> )(lpVtbl[29]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, pBuf, pdwResult);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetGuideLineW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetGuideLineW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LPWSTR")] ushort* pBuf, [NativeTypeName("DWORD *")] uint* pdwResult)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, uint, ushort*, uint*, int> )(lpVtbl[30]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, dwBufLen, pBuf, pdwResult);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetIMEFileNameA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetIMEFileNameA(HKL hKL, uint uBufLen, [NativeTypeName("LPSTR")] sbyte* szFileName, uint* puCopied)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, uint, sbyte*, uint*, int> )(lpVtbl[31]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, uBufLen, szFileName, puCopied);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetIMEFileNameW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetIMEFileNameW(HKL hKL, uint uBufLen, [NativeTypeName("LPWSTR")] ushort* szFileName, uint* puCopied)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, uint, ushort*, uint*, int> )(lpVtbl[32]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, uBufLen, szFileName, puCopied);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetOpenStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetOpenStatus(HIMC hIMC)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, int> )(lpVtbl[33]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetProperty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetProperty(HKL hKL, [NativeTypeName("DWORD")] uint fdwIndex, [NativeTypeName("DWORD *")] uint* pdwProperty)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, uint, uint*, int> )(lpVtbl[34]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, fdwIndex, pdwProperty);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetRegisterWordStyleA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetRegisterWordStyleA(HKL hKL, uint nItem, STYLEBUFA* pStyleBuf, uint* puCopied)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, uint, STYLEBUFA*, uint*, int> )(lpVtbl[35]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, nItem, pStyleBuf, puCopied);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetRegisterWordStyleW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetRegisterWordStyleW(HKL hKL, uint nItem, STYLEBUFW* pStyleBuf, uint* puCopied)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, uint, STYLEBUFW*, uint*, int> )(lpVtbl[36]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, nItem, pStyleBuf, puCopied);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetStatusWindowPos"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT GetStatusWindowPos(HIMC hIMC, POINT* pptPos)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, POINT*, int> )(lpVtbl[37]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pptPos);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetVirtualKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT GetVirtualKey(HWND hWnd, uint* puVirtualKey)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HWND, uint*, int> )(lpVtbl[38]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, puVirtualKey);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.InstallIMEA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT InstallIMEA([NativeTypeName("LPSTR")] sbyte* szIMEFileName, [NativeTypeName("LPSTR")] sbyte* szLayoutText, HKL* phKL)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, sbyte*, sbyte*, HKL*, int> )(lpVtbl[39]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), szIMEFileName, szLayoutText, phKL);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.InstallIMEW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT InstallIMEW([NativeTypeName("LPWSTR")] ushort* szIMEFileName, [NativeTypeName("LPWSTR")] ushort* szLayoutText, HKL* phKL)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, ushort*, ushort*, HKL*, int> )(lpVtbl[40]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), szIMEFileName, szLayoutText, phKL);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.IsIME"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT IsIME(HKL hKL)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, int> )(lpVtbl[41]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.IsUIMessageA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT IsUIMessageA(HWND hWndIME, uint msg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HWND, uint, WPARAM, LPARAM, int> )(lpVtbl[42]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWndIME, msg, wParam, lParam);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.IsUIMessageW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT IsUIMessageW(HWND hWndIME, uint msg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HWND, uint, WPARAM, LPARAM, int> )(lpVtbl[43]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWndIME, msg, wParam, lParam);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.NotifyIME"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT NotifyIME(HIMC hIMC, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwValue)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, uint, uint, int> )(lpVtbl[44]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwAction, dwIndex, dwValue);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.RegisterWordA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT RegisterWordA(HKL hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szRegister)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, sbyte*, uint, sbyte*, int> )(lpVtbl[45]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.RegisterWordW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT RegisterWordW(HKL hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szRegister)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, ushort*, uint, ushort*, int> )(lpVtbl[46]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szRegister);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.ReleaseContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT ReleaseContext(HWND hWnd, HIMC hIMC)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HWND, HIMC, int> )(lpVtbl[47]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, hIMC);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.SetCandidateWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT SetCandidateWindow(HIMC hIMC, CANDIDATEFORM* pCandidate)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, CANDIDATEFORM*, int> )(lpVtbl[48]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pCandidate);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.SetCompositionFontA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT SetCompositionFontA(HIMC hIMC, LOGFONTA* plf)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, LOGFONTA*, int> )(lpVtbl[49]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, plf);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.SetCompositionFontW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT SetCompositionFontW(HIMC hIMC, LOGFONTW* plf)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, LOGFONTW*, int> )(lpVtbl[50]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, plf);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.SetCompositionStringA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT SetCompositionStringA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* pComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* pRead, [NativeTypeName("DWORD")] uint dwReadLen)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, void*, uint, void*, uint, int> )(lpVtbl[51]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pComp, dwCompLen, pRead, dwReadLen);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.SetCompositionStringW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT SetCompositionStringW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* pComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* pRead, [NativeTypeName("DWORD")] uint dwReadLen)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, void*, uint, void*, uint, int> )(lpVtbl[52]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pComp, dwCompLen, pRead, dwReadLen);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.SetCompositionWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT SetCompositionWindow(HIMC hIMC, COMPOSITIONFORM* pCompForm)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, COMPOSITIONFORM*, int> )(lpVtbl[53]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pCompForm);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.SetConversionStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT SetConversionStatus(HIMC hIMC, [NativeTypeName("DWORD")] uint fdwConversion, [NativeTypeName("DWORD")] uint fdwSentence)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, uint, int> )(lpVtbl[54]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, fdwConversion, fdwSentence);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.SetOpenStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT SetOpenStatus(HIMC hIMC, BOOL fOpen)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, BOOL, int> )(lpVtbl[55]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, fOpen);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.SetStatusWindowPos"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT SetStatusWindowPos(HIMC hIMC, POINT* pptPos)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, POINT*, int> )(lpVtbl[56]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, pptPos);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.SimulateHotKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT SimulateHotKey(HWND hWnd, [NativeTypeName("DWORD")] uint dwHotKeyID)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HWND, uint, int> )(lpVtbl[57]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, dwHotKeyID);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.UnregisterWordA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT UnregisterWordA(HKL hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szUnregister)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, sbyte*, uint, sbyte*, int> )(lpVtbl[58]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szUnregister);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.UnregisterWordW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT UnregisterWordW(HKL hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szUnregister)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, ushort*, uint, ushort*, int> )(lpVtbl[59]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, szReading, dwStyle, szUnregister);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.Activate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT Activate(BOOL fRestoreLayout)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, BOOL, int> )(lpVtbl[60]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), fRestoreLayout);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.Deactivate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT Deactivate()
    {
        return ((delegate* unmanaged<IActiveIMMApp*, int> )(lpVtbl[61]))((IActiveIMMApp*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.OnDefWindowProc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT OnDefWindowProc(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam, LRESULT* plResult)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HWND, uint, WPARAM, LPARAM, LRESULT*, int> )(lpVtbl[62]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, Msg, wParam, lParam, plResult);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.FilterClientWindows"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT FilterClientWindows([NativeTypeName("ATOM *")] ushort* aaClassList, uint uSize)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, ushort*, uint, int> )(lpVtbl[63]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), aaClassList, uSize);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetCodePageA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT GetCodePageA(HKL hKL, uint* uCodePage)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, uint*, int> )(lpVtbl[64]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, uCodePage);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetLangId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT GetLangId(HKL hKL, [NativeTypeName("LANGID *")] ushort* plid)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HKL, ushort*, int> )(lpVtbl[65]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hKL, plid);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.AssociateContextEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT AssociateContextEx(HWND hWnd, HIMC hIMC, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HWND, HIMC, uint, int> )(lpVtbl[66]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hWnd, hIMC, dwFlags);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.DisableIME"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT DisableIME([NativeTypeName("DWORD")] uint idThread)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, uint, int> )(lpVtbl[67]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), idThread);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetImeMenuItemsA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT GetImeMenuItemsA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwType, IMEMENUITEMINFOA* pImeParentMenu, IMEMENUITEMINFOA* pImeMenu, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD *")] uint* pdwResult)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, uint, IMEMENUITEMINFOA*, IMEMENUITEMINFOA*, uint, uint*, int> )(lpVtbl[68]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwFlags, dwType, pImeParentMenu, pImeMenu, dwSize, pdwResult);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.GetImeMenuItemsW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT GetImeMenuItemsW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwType, IMEMENUITEMINFOW* pImeParentMenu, IMEMENUITEMINFOW* pImeMenu, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD *")] uint* pdwResult)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, HIMC, uint, uint, IMEMENUITEMINFOW*, IMEMENUITEMINFOW*, uint, uint*, int> )(lpVtbl[69]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), hIMC, dwFlags, dwType, pImeParentMenu, pImeMenu, dwSize, pdwResult);
    }

    /// <include file='IActiveIMMApp.xml' path='doc/member[@name="IActiveIMMApp.EnumInputContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT EnumInputContext([NativeTypeName("DWORD")] uint idThread, IEnumInputContext** ppEnum)
    {
        return ((delegate* unmanaged<IActiveIMMApp*, uint, IEnumInputContext**, int> )(lpVtbl[70]))((IActiveIMMApp*)Unsafe.AsPointer(ref this), idThread, ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AssociateContext(HWND hWnd, HIMC hIME, HIMC* phPrev);
        [VtblIndex(4)]
        HRESULT ConfigureIMEA(HKL hKL, HWND hWnd, [NativeTypeName("DWORD")] uint dwMode, REGISTERWORDA* pData);
        [VtblIndex(5)]
        HRESULT ConfigureIMEW(HKL hKL, HWND hWnd, [NativeTypeName("DWORD")] uint dwMode, REGISTERWORDW* pData);
        [VtblIndex(6)]
        HRESULT CreateContext(HIMC* phIMC);
        [VtblIndex(7)]
        HRESULT DestroyContext(HIMC hIME);
        [VtblIndex(8)]
        HRESULT EnumRegisterWordA(HKL hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szRegister, [NativeTypeName("LPVOID")] void* pData, IEnumRegisterWordA** pEnum);
        [VtblIndex(9)]
        HRESULT EnumRegisterWordW(HKL hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szRegister, [NativeTypeName("LPVOID")] void* pData, IEnumRegisterWordW** pEnum);
        [VtblIndex(10)]
        HRESULT EscapeA(HKL hKL, HIMC hIMC, uint uEscape, [NativeTypeName("LPVOID")] void* pData, LRESULT* plResult);
        [VtblIndex(11)]
        HRESULT EscapeW(HKL hKL, HIMC hIMC, uint uEscape, [NativeTypeName("LPVOID")] void* pData, LRESULT* plResult);
        [VtblIndex(12)]
        HRESULT GetCandidateListA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, uint uBufLen, CANDIDATELIST* pCandList, uint* puCopied);
        [VtblIndex(13)]
        HRESULT GetCandidateListW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, uint uBufLen, CANDIDATELIST* pCandList, uint* puCopied);
        [VtblIndex(14)]
        HRESULT GetCandidateListCountA(HIMC hIMC, [NativeTypeName("DWORD *")] uint* pdwListSize, [NativeTypeName("DWORD *")] uint* pdwBufLen);
        [VtblIndex(15)]
        HRESULT GetCandidateListCountW(HIMC hIMC, [NativeTypeName("DWORD *")] uint* pdwListSize, [NativeTypeName("DWORD *")] uint* pdwBufLen);
        [VtblIndex(16)]
        HRESULT GetCandidateWindow(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, CANDIDATEFORM* pCandidate);
        [VtblIndex(17)]
        HRESULT GetCompositionFontA(HIMC hIMC, LOGFONTA* plf);
        [VtblIndex(18)]
        HRESULT GetCompositionFontW(HIMC hIMC, LOGFONTW* plf);
        [VtblIndex(19)]
        HRESULT GetCompositionStringA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LONG *")] int* plCopied, [NativeTypeName("LPVOID")] void* pBuf);
        [VtblIndex(20)]
        HRESULT GetCompositionStringW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LONG *")] int* plCopied, [NativeTypeName("LPVOID")] void* pBuf);
        [VtblIndex(21)]
        HRESULT GetCompositionWindow(HIMC hIMC, COMPOSITIONFORM* pCompForm);
        [VtblIndex(22)]
        HRESULT GetContext(HWND hWnd, HIMC* phIMC);
        [VtblIndex(23)]
        HRESULT GetConversionListA(HKL hKL, HIMC hIMC, [NativeTypeName("LPSTR")] sbyte* pSrc, uint uBufLen, uint uFlag, CANDIDATELIST* pDst, uint* puCopied);
        [VtblIndex(24)]
        HRESULT GetConversionListW(HKL hKL, HIMC hIMC, [NativeTypeName("LPWSTR")] ushort* pSrc, uint uBufLen, uint uFlag, CANDIDATELIST* pDst, uint* puCopied);
        [VtblIndex(25)]
        HRESULT GetConversionStatus(HIMC hIMC, [NativeTypeName("DWORD *")] uint* pfdwConversion, [NativeTypeName("DWORD *")] uint* pfdwSentence);
        [VtblIndex(26)]
        HRESULT GetDefaultIMEWnd(HWND hWnd, HWND* phDefWnd);
        [VtblIndex(27)]
        HRESULT GetDescriptionA(HKL hKL, uint uBufLen, [NativeTypeName("LPSTR")] sbyte* szDescription, uint* puCopied);
        [VtblIndex(28)]
        HRESULT GetDescriptionW(HKL hKL, uint uBufLen, [NativeTypeName("LPWSTR")] ushort* szDescription, uint* puCopied);
        [VtblIndex(29)]
        HRESULT GetGuideLineA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LPSTR")] sbyte* pBuf, [NativeTypeName("DWORD *")] uint* pdwResult);
        [VtblIndex(30)]
        HRESULT GetGuideLineW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwBufLen, [NativeTypeName("LPWSTR")] ushort* pBuf, [NativeTypeName("DWORD *")] uint* pdwResult);
        [VtblIndex(31)]
        HRESULT GetIMEFileNameA(HKL hKL, uint uBufLen, [NativeTypeName("LPSTR")] sbyte* szFileName, uint* puCopied);
        [VtblIndex(32)]
        HRESULT GetIMEFileNameW(HKL hKL, uint uBufLen, [NativeTypeName("LPWSTR")] ushort* szFileName, uint* puCopied);
        [VtblIndex(33)]
        HRESULT GetOpenStatus(HIMC hIMC);
        [VtblIndex(34)]
        HRESULT GetProperty(HKL hKL, [NativeTypeName("DWORD")] uint fdwIndex, [NativeTypeName("DWORD *")] uint* pdwProperty);
        [VtblIndex(35)]
        HRESULT GetRegisterWordStyleA(HKL hKL, uint nItem, STYLEBUFA* pStyleBuf, uint* puCopied);
        [VtblIndex(36)]
        HRESULT GetRegisterWordStyleW(HKL hKL, uint nItem, STYLEBUFW* pStyleBuf, uint* puCopied);
        [VtblIndex(37)]
        HRESULT GetStatusWindowPos(HIMC hIMC, POINT* pptPos);
        [VtblIndex(38)]
        HRESULT GetVirtualKey(HWND hWnd, uint* puVirtualKey);
        [VtblIndex(39)]
        HRESULT InstallIMEA([NativeTypeName("LPSTR")] sbyte* szIMEFileName, [NativeTypeName("LPSTR")] sbyte* szLayoutText, HKL* phKL);
        [VtblIndex(40)]
        HRESULT InstallIMEW([NativeTypeName("LPWSTR")] ushort* szIMEFileName, [NativeTypeName("LPWSTR")] ushort* szLayoutText, HKL* phKL);
        [VtblIndex(41)]
        HRESULT IsIME(HKL hKL);
        [VtblIndex(42)]
        HRESULT IsUIMessageA(HWND hWndIME, uint msg, WPARAM wParam, LPARAM lParam);
        [VtblIndex(43)]
        HRESULT IsUIMessageW(HWND hWndIME, uint msg, WPARAM wParam, LPARAM lParam);
        [VtblIndex(44)]
        HRESULT NotifyIME(HIMC hIMC, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwValue);
        [VtblIndex(45)]
        HRESULT RegisterWordA(HKL hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szRegister);
        [VtblIndex(46)]
        HRESULT RegisterWordW(HKL hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szRegister);
        [VtblIndex(47)]
        HRESULT ReleaseContext(HWND hWnd, HIMC hIMC);
        [VtblIndex(48)]
        HRESULT SetCandidateWindow(HIMC hIMC, CANDIDATEFORM* pCandidate);
        [VtblIndex(49)]
        HRESULT SetCompositionFontA(HIMC hIMC, LOGFONTA* plf);
        [VtblIndex(50)]
        HRESULT SetCompositionFontW(HIMC hIMC, LOGFONTW* plf);
        [VtblIndex(51)]
        HRESULT SetCompositionStringA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* pComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* pRead, [NativeTypeName("DWORD")] uint dwReadLen);
        [VtblIndex(52)]
        HRESULT SetCompositionStringW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPVOID")] void* pComp, [NativeTypeName("DWORD")] uint dwCompLen, [NativeTypeName("LPVOID")] void* pRead, [NativeTypeName("DWORD")] uint dwReadLen);
        [VtblIndex(53)]
        HRESULT SetCompositionWindow(HIMC hIMC, COMPOSITIONFORM* pCompForm);
        [VtblIndex(54)]
        HRESULT SetConversionStatus(HIMC hIMC, [NativeTypeName("DWORD")] uint fdwConversion, [NativeTypeName("DWORD")] uint fdwSentence);
        [VtblIndex(55)]
        HRESULT SetOpenStatus(HIMC hIMC, BOOL fOpen);
        [VtblIndex(56)]
        HRESULT SetStatusWindowPos(HIMC hIMC, POINT* pptPos);
        [VtblIndex(57)]
        HRESULT SimulateHotKey(HWND hWnd, [NativeTypeName("DWORD")] uint dwHotKeyID);
        [VtblIndex(58)]
        HRESULT UnregisterWordA(HKL hKL, [NativeTypeName("LPSTR")] sbyte* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPSTR")] sbyte* szUnregister);
        [VtblIndex(59)]
        HRESULT UnregisterWordW(HKL hKL, [NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szUnregister);
        [VtblIndex(60)]
        HRESULT Activate(BOOL fRestoreLayout);
        [VtblIndex(61)]
        HRESULT Deactivate();
        [VtblIndex(62)]
        HRESULT OnDefWindowProc(HWND hWnd, uint Msg, WPARAM wParam, LPARAM lParam, LRESULT* plResult);
        [VtblIndex(63)]
        HRESULT FilterClientWindows([NativeTypeName("ATOM *")] ushort* aaClassList, uint uSize);
        [VtblIndex(64)]
        HRESULT GetCodePageA(HKL hKL, uint* uCodePage);
        [VtblIndex(65)]
        HRESULT GetLangId(HKL hKL, [NativeTypeName("LANGID *")] ushort* plid);
        [VtblIndex(66)]
        HRESULT AssociateContextEx(HWND hWnd, HIMC hIMC, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(67)]
        HRESULT DisableIME([NativeTypeName("DWORD")] uint idThread);
        [VtblIndex(68)]
        HRESULT GetImeMenuItemsA(HIMC hIMC, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwType, IMEMENUITEMINFOA* pImeParentMenu, IMEMENUITEMINFOA* pImeMenu, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD *")] uint* pdwResult);
        [VtblIndex(69)]
        HRESULT GetImeMenuItemsW(HIMC hIMC, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwType, IMEMENUITEMINFOW* pImeParentMenu, IMEMENUITEMINFOW* pImeMenu, [NativeTypeName("DWORD")] uint dwSize, [NativeTypeName("DWORD *")] uint* pdwResult);
        [VtblIndex(70)]
        HRESULT EnumInputContext([NativeTypeName("DWORD")] uint idThread, IEnumInputContext** ppEnum);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT (HWND, HIMC, HIMC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HIMC, HIMC*, int> AssociateContext;
        [NativeTypeName("HRESULT (HKL, HWND, DWORD, REGISTERWORDA *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, HWND, uint, REGISTERWORDA*, int> ConfigureIMEA;
        [NativeTypeName("HRESULT (HKL, HWND, DWORD, REGISTERWORDW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, HWND, uint, REGISTERWORDW*, int> ConfigureIMEW;
        [NativeTypeName("HRESULT (HIMC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC*, int> CreateContext;
        [NativeTypeName("HRESULT (HIMC) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, int> DestroyContext;
        [NativeTypeName("HRESULT (HKL, LPSTR, DWORD, LPSTR, LPVOID, IEnumRegisterWordA **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, sbyte*, uint, sbyte*, void*, IEnumRegisterWordA**, int> EnumRegisterWordA;
        [NativeTypeName("HRESULT (HKL, LPWSTR, DWORD, LPWSTR, LPVOID, IEnumRegisterWordW **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, ushort*, uint, ushort*, void*, IEnumRegisterWordW**, int> EnumRegisterWordW;
        [NativeTypeName("HRESULT (HKL, HIMC, UINT, LPVOID, LRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, HIMC, uint, void*, LRESULT*, int> EscapeA;
        [NativeTypeName("HRESULT (HKL, HIMC, UINT, LPVOID, LRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, HIMC, uint, void*, LRESULT*, int> EscapeW;
        [NativeTypeName("HRESULT (HIMC, DWORD, UINT, CANDIDATELIST *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, uint, CANDIDATELIST*, uint*, int> GetCandidateListA;
        [NativeTypeName("HRESULT (HIMC, DWORD, UINT, CANDIDATELIST *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, uint, CANDIDATELIST*, uint*, int> GetCandidateListW;
        [NativeTypeName("HRESULT (HIMC, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint*, uint*, int> GetCandidateListCountA;
        [NativeTypeName("HRESULT (HIMC, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint*, uint*, int> GetCandidateListCountW;
        [NativeTypeName("HRESULT (HIMC, DWORD, CANDIDATEFORM *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, CANDIDATEFORM*, int> GetCandidateWindow;
        [NativeTypeName("HRESULT (HIMC, LOGFONTA *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, LOGFONTA*, int> GetCompositionFontA;
        [NativeTypeName("HRESULT (HIMC, LOGFONTW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, LOGFONTW*, int> GetCompositionFontW;
        [NativeTypeName("HRESULT (HIMC, DWORD, DWORD, LONG *, LPVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, uint, int*, void*, int> GetCompositionStringA;
        [NativeTypeName("HRESULT (HIMC, DWORD, DWORD, LONG *, LPVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, uint, int*, void*, int> GetCompositionStringW;
        [NativeTypeName("HRESULT (HIMC, COMPOSITIONFORM *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, COMPOSITIONFORM*, int> GetCompositionWindow;
        [NativeTypeName("HRESULT (HWND, HIMC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HIMC*, int> GetContext;
        [NativeTypeName("HRESULT (HKL, HIMC, LPSTR, UINT, UINT, CANDIDATELIST *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, HIMC, sbyte*, uint, uint, CANDIDATELIST*, uint*, int> GetConversionListA;
        [NativeTypeName("HRESULT (HKL, HIMC, LPWSTR, UINT, UINT, CANDIDATELIST *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, HIMC, ushort*, uint, uint, CANDIDATELIST*, uint*, int> GetConversionListW;
        [NativeTypeName("HRESULT (HIMC, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint*, uint*, int> GetConversionStatus;
        [NativeTypeName("HRESULT (HWND, HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HWND*, int> GetDefaultIMEWnd;
        [NativeTypeName("HRESULT (HKL, UINT, LPSTR, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, uint, sbyte*, uint*, int> GetDescriptionA;
        [NativeTypeName("HRESULT (HKL, UINT, LPWSTR, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, uint, ushort*, uint*, int> GetDescriptionW;
        [NativeTypeName("HRESULT (HIMC, DWORD, DWORD, LPSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, uint, sbyte*, uint*, int> GetGuideLineA;
        [NativeTypeName("HRESULT (HIMC, DWORD, DWORD, LPWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, uint, ushort*, uint*, int> GetGuideLineW;
        [NativeTypeName("HRESULT (HKL, UINT, LPSTR, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, uint, sbyte*, uint*, int> GetIMEFileNameA;
        [NativeTypeName("HRESULT (HKL, UINT, LPWSTR, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, uint, ushort*, uint*, int> GetIMEFileNameW;
        [NativeTypeName("HRESULT (HIMC) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, int> GetOpenStatus;
        [NativeTypeName("HRESULT (HKL, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, uint, uint*, int> GetProperty;
        [NativeTypeName("HRESULT (HKL, UINT, STYLEBUFA *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, uint, STYLEBUFA*, uint*, int> GetRegisterWordStyleA;
        [NativeTypeName("HRESULT (HKL, UINT, STYLEBUFW *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, uint, STYLEBUFW*, uint*, int> GetRegisterWordStyleW;
        [NativeTypeName("HRESULT (HIMC, POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, POINT*, int> GetStatusWindowPos;
        [NativeTypeName("HRESULT (HWND, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint*, int> GetVirtualKey;
        [NativeTypeName("HRESULT (LPSTR, LPSTR, HKL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, sbyte*, HKL*, int> InstallIMEA;
        [NativeTypeName("HRESULT (LPWSTR, LPWSTR, HKL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, HKL*, int> InstallIMEW;
        [NativeTypeName("HRESULT (HKL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, int> IsIME;
        [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, WPARAM, LPARAM, int> IsUIMessageA;
        [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, WPARAM, LPARAM, int> IsUIMessageW;
        [NativeTypeName("HRESULT (HIMC, DWORD, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, uint, uint, int> NotifyIME;
        [NativeTypeName("HRESULT (HKL, LPSTR, DWORD, LPSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, sbyte*, uint, sbyte*, int> RegisterWordA;
        [NativeTypeName("HRESULT (HKL, LPWSTR, DWORD, LPWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, ushort*, uint, ushort*, int> RegisterWordW;
        [NativeTypeName("HRESULT (HWND, HIMC) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HIMC, int> ReleaseContext;
        [NativeTypeName("HRESULT (HIMC, CANDIDATEFORM *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, CANDIDATEFORM*, int> SetCandidateWindow;
        [NativeTypeName("HRESULT (HIMC, LOGFONTA *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, LOGFONTA*, int> SetCompositionFontA;
        [NativeTypeName("HRESULT (HIMC, LOGFONTW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, LOGFONTW*, int> SetCompositionFontW;
        [NativeTypeName("HRESULT (HIMC, DWORD, LPVOID, DWORD, LPVOID, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, void*, uint, void*, uint, int> SetCompositionStringA;
        [NativeTypeName("HRESULT (HIMC, DWORD, LPVOID, DWORD, LPVOID, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, void*, uint, void*, uint, int> SetCompositionStringW;
        [NativeTypeName("HRESULT (HIMC, COMPOSITIONFORM *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, COMPOSITIONFORM*, int> SetCompositionWindow;
        [NativeTypeName("HRESULT (HIMC, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, uint, int> SetConversionStatus;
        [NativeTypeName("HRESULT (HIMC, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, BOOL, int> SetOpenStatus;
        [NativeTypeName("HRESULT (HIMC, POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, POINT*, int> SetStatusWindowPos;
        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> SimulateHotKey;
        [NativeTypeName("HRESULT (HKL, LPSTR, DWORD, LPSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, sbyte*, uint, sbyte*, int> UnregisterWordA;
        [NativeTypeName("HRESULT (HKL, LPWSTR, DWORD, LPWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, ushort*, uint, ushort*, int> UnregisterWordW;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Activate;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Deactivate;
        [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM, LRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, WPARAM, LPARAM, LRESULT*, int> OnDefWindowProc;
        [NativeTypeName("HRESULT (ATOM *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> FilterClientWindows;
        [NativeTypeName("HRESULT (HKL, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, uint*, int> GetCodePageA;
        [NativeTypeName("HRESULT (HKL, LANGID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, ushort*, int> GetLangId;
        [NativeTypeName("HRESULT (HWND, HIMC, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HIMC, uint, int> AssociateContextEx;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DisableIME;
        [NativeTypeName("HRESULT (HIMC, DWORD, DWORD, IMEMENUITEMINFOA *, IMEMENUITEMINFOA *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, uint, IMEMENUITEMINFOA*, IMEMENUITEMINFOA*, uint, uint*, int> GetImeMenuItemsA;
        [NativeTypeName("HRESULT (HIMC, DWORD, DWORD, IMEMENUITEMINFOW *, IMEMENUITEMINFOW *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, uint, IMEMENUITEMINFOW*, IMEMENUITEMINFOW*, uint, uint*, int> GetImeMenuItemsW;
        [NativeTypeName("HRESULT (DWORD, IEnumInputContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IEnumInputContext**, int> EnumInputContext;
    }
}