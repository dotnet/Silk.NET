// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IActiveIME2.xml' path='doc/member[@name="IActiveIME2"]/*'/>
[Guid("E1C4BF0E-2D53-11D2-93E1-0060B067B86E")]
[NativeTypeName("struct IActiveIME2 : IActiveIME")]
[NativeInheritance("IActiveIME")]
public unsafe partial struct IActiveIME2 : IActiveIME2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActiveIME2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActiveIME2*, Guid*, void**, int> )(lpVtbl[0]))((IActiveIME2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IActiveIME2*, uint> )(lpVtbl[1]))((IActiveIME2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActiveIME2*, uint> )(lpVtbl[2]))((IActiveIME2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IActiveIME.Inquire"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Inquire([NativeTypeName("DWORD")] uint dwSystemInfoFlags, IMEINFO* pIMEInfo, [NativeTypeName("LPWSTR")] ushort* szWndClass, [NativeTypeName("DWORD *")] uint* pdwPrivate)
    {
        return ((delegate* unmanaged<IActiveIME2*, uint, IMEINFO*, ushort*, uint*, int> )(lpVtbl[3]))((IActiveIME2*)Unsafe.AsPointer(ref this), dwSystemInfoFlags, pIMEInfo, szWndClass, pdwPrivate);
    }

    /// <inheritdoc cref = "IActiveIME.ConversionList"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ConversionList(HIMC hIMC, [NativeTypeName("LPWSTR")] ushort* szSource, uint uFlag, uint uBufLen, CANDIDATELIST* pDest, uint* puCopied)
    {
        return ((delegate* unmanaged<IActiveIME2*, HIMC, ushort*, uint, uint, CANDIDATELIST*, uint*, int> )(lpVtbl[4]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, szSource, uFlag, uBufLen, pDest, puCopied);
    }

    /// <inheritdoc cref = "IActiveIME.Configure"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Configure(HKL hKL, HWND hWnd, [NativeTypeName("DWORD")] uint dwMode, REGISTERWORDW* pRegisterWord)
    {
        return ((delegate* unmanaged<IActiveIME2*, HKL, HWND, uint, REGISTERWORDW*, int> )(lpVtbl[5]))((IActiveIME2*)Unsafe.AsPointer(ref this), hKL, hWnd, dwMode, pRegisterWord);
    }

    /// <inheritdoc cref = "IActiveIME.Destroy"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Destroy(uint uReserved)
    {
        return ((delegate* unmanaged<IActiveIME2*, uint, int> )(lpVtbl[6]))((IActiveIME2*)Unsafe.AsPointer(ref this), uReserved);
    }

    /// <inheritdoc cref = "IActiveIME.Escape"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Escape(HIMC hIMC, uint uEscape, void* pData, LRESULT* plResult)
    {
        return ((delegate* unmanaged<IActiveIME2*, HIMC, uint, void*, LRESULT*, int> )(lpVtbl[7]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, uEscape, pData, plResult);
    }

    /// <inheritdoc cref = "IActiveIME.SetActiveContext"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetActiveContext(HIMC hIMC, BOOL fFlag)
    {
        return ((delegate* unmanaged<IActiveIME2*, HIMC, BOOL, int> )(lpVtbl[8]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, fFlag);
    }

    /// <inheritdoc cref = "IActiveIME.ProcessKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ProcessKey(HIMC hIMC, uint uVirKey, [NativeTypeName("DWORD")] uint lParam, byte* pbKeyState)
    {
        return ((delegate* unmanaged<IActiveIME2*, HIMC, uint, uint, byte*, int> )(lpVtbl[9]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, uVirKey, lParam, pbKeyState);
    }

    /// <inheritdoc cref = "IActiveIME.Notify"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Notify(HIMC hIMC, [NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD")] uint dwValue)
    {
        return ((delegate* unmanaged<IActiveIME2*, HIMC, uint, uint, uint, int> )(lpVtbl[10]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, dwAction, dwIndex, dwValue);
    }

    /// <inheritdoc cref = "IActiveIME.Select"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Select(HIMC hIMC, BOOL fSelect)
    {
        return ((delegate* unmanaged<IActiveIME2*, HIMC, BOOL, int> )(lpVtbl[11]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, fSelect);
    }

    /// <inheritdoc cref = "IActiveIME.SetCompositionString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetCompositionString(HIMC hIMC, [NativeTypeName("DWORD")] uint dwIndex, void* pComp, [NativeTypeName("DWORD")] uint dwCompLen, void* pRead, [NativeTypeName("DWORD")] uint dwReadLen)
    {
        return ((delegate* unmanaged<IActiveIME2*, HIMC, uint, void*, uint, void*, uint, int> )(lpVtbl[12]))((IActiveIME2*)Unsafe.AsPointer(ref this), hIMC, dwIndex, pComp, dwCompLen, pRead, dwReadLen);
    }

    /// <inheritdoc cref = "IActiveIME.ToAsciiEx"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ToAsciiEx(uint uVirKey, uint uScanCode, byte* pbKeyState, uint fuState, HIMC hIMC, [NativeTypeName("DWORD *")] uint* pdwTransBuf, uint* puSize)
    {
        return ((delegate* unmanaged<IActiveIME2*, uint, uint, byte*, uint, HIMC, uint*, uint*, int> )(lpVtbl[13]))((IActiveIME2*)Unsafe.AsPointer(ref this), uVirKey, uScanCode, pbKeyState, fuState, hIMC, pdwTransBuf, puSize);
    }

    /// <inheritdoc cref = "IActiveIME.RegisterWord"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RegisterWord([NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szString)
    {
        return ((delegate* unmanaged<IActiveIME2*, ushort*, uint, ushort*, int> )(lpVtbl[14]))((IActiveIME2*)Unsafe.AsPointer(ref this), szReading, dwStyle, szString);
    }

    /// <inheritdoc cref = "IActiveIME.UnregisterWord"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT UnregisterWord([NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szString)
    {
        return ((delegate* unmanaged<IActiveIME2*, ushort*, uint, ushort*, int> )(lpVtbl[15]))((IActiveIME2*)Unsafe.AsPointer(ref this), szReading, dwStyle, szString);
    }

    /// <inheritdoc cref = "IActiveIME.GetRegisterWordStyle"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetRegisterWordStyle(uint nItem, STYLEBUFW* pStyleBuf, uint* puBufSize)
    {
        return ((delegate* unmanaged<IActiveIME2*, uint, STYLEBUFW*, uint*, int> )(lpVtbl[16]))((IActiveIME2*)Unsafe.AsPointer(ref this), nItem, pStyleBuf, puBufSize);
    }

    /// <inheritdoc cref = "IActiveIME.EnumRegisterWord"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT EnumRegisterWord([NativeTypeName("LPWSTR")] ushort* szReading, [NativeTypeName("DWORD")] uint dwStyle, [NativeTypeName("LPWSTR")] ushort* szRegister, [NativeTypeName("LPVOID")] void* pData, IEnumRegisterWordW** ppEnum)
    {
        return ((delegate* unmanaged<IActiveIME2*, ushort*, uint, ushort*, void*, IEnumRegisterWordW**, int> )(lpVtbl[17]))((IActiveIME2*)Unsafe.AsPointer(ref this), szReading, dwStyle, szRegister, pData, ppEnum);
    }

    /// <inheritdoc cref = "IActiveIME.GetCodePageA"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetCodePageA(uint* uCodePage)
    {
        return ((delegate* unmanaged<IActiveIME2*, uint*, int> )(lpVtbl[18]))((IActiveIME2*)Unsafe.AsPointer(ref this), uCodePage);
    }

    /// <inheritdoc cref = "IActiveIME.GetLangId"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetLangId([NativeTypeName("LANGID *")] ushort* plid)
    {
        return ((delegate* unmanaged<IActiveIME2*, ushort*, int> )(lpVtbl[19]))((IActiveIME2*)Unsafe.AsPointer(ref this), plid);
    }

    /// <include file='IActiveIME2.xml' path='doc/member[@name="IActiveIME2.Sleep"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT Sleep()
    {
        return ((delegate* unmanaged<IActiveIME2*, int> )(lpVtbl[20]))((IActiveIME2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IActiveIME2.xml' path='doc/member[@name="IActiveIME2.Unsleep"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT Unsleep(BOOL fDead)
    {
        return ((delegate* unmanaged<IActiveIME2*, BOOL, int> )(lpVtbl[21]))((IActiveIME2*)Unsafe.AsPointer(ref this), fDead);
    }

    public interface Interface : IActiveIME.Interface
    {
        [VtblIndex(20)]
        HRESULT Sleep();
        [VtblIndex(21)]
        HRESULT Unsleep(BOOL fDead);
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
        [NativeTypeName("HRESULT (DWORD, IMEINFO *, LPWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMEINFO*, ushort*, uint*, int> Inquire;
        [NativeTypeName("HRESULT (HIMC, LPWSTR, UINT, UINT, CANDIDATELIST *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, ushort*, uint, uint, CANDIDATELIST*, uint*, int> ConversionList;
        [NativeTypeName("HRESULT (HKL, HWND, DWORD, REGISTERWORDW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HKL, HWND, uint, REGISTERWORDW*, int> Configure;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Destroy;
        [NativeTypeName("HRESULT (HIMC, UINT, void *, LRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, void*, LRESULT*, int> Escape;
        [NativeTypeName("HRESULT (HIMC, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, BOOL, int> SetActiveContext;
        [NativeTypeName("HRESULT (HIMC, UINT, DWORD, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, uint, byte*, int> ProcessKey;
        [NativeTypeName("HRESULT (HIMC, DWORD, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, uint, uint, int> Notify;
        [NativeTypeName("HRESULT (HIMC, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, BOOL, int> Select;
        [NativeTypeName("HRESULT (HIMC, DWORD, void *, DWORD, void *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HIMC, uint, void*, uint, void*, uint, int> SetCompositionString;
        [NativeTypeName("HRESULT (UINT, UINT, BYTE *, UINT, HIMC, DWORD *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint, HIMC, uint*, uint*, int> ToAsciiEx;
        [NativeTypeName("HRESULT (LPWSTR, DWORD, LPWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort*, int> RegisterWord;
        [NativeTypeName("HRESULT (LPWSTR, DWORD, LPWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort*, int> UnregisterWord;
        [NativeTypeName("HRESULT (UINT, STYLEBUFW *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, STYLEBUFW*, uint*, int> GetRegisterWordStyle;
        [NativeTypeName("HRESULT (LPWSTR, DWORD, LPWSTR, LPVOID, IEnumRegisterWordW **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort*, void*, IEnumRegisterWordW**, int> EnumRegisterWord;
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCodePageA;
        [NativeTypeName("HRESULT (LANGID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetLangId;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Sleep;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Unsleep;
    }
}