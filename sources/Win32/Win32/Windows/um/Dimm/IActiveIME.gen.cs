// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6FE20962-D077-11D0-8FE7-00AA006BCC59")]
[NativeTypeName("struct IActiveIME : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IActiveIME : IActiveIME.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IActiveIME));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IActiveIME, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IActiveIME, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IActiveIME, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Inquire(
        [NativeTypeName("DWORD")] uint dwSystemInfoFlags,
        IMEINFO* pIMEInfo,
        [NativeTypeName("LPWSTR")] ushort* szWndClass,
        [NativeTypeName("DWORD *")] uint* pdwPrivate
    )
    {
        return (
            (delegate* unmanaged<IActiveIME, uint, IMEINFO*, ushort*, uint*, int>)((*lpVtbl)[3])
        )(this, dwSystemInfoFlags, pIMEInfo, szWndClass, pdwPrivate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ConversionList(
        HIMC hIMC,
        [NativeTypeName("LPWSTR")] ushort* szSource,
        uint uFlag,
        uint uBufLen,
        CANDIDATELIST* pDest,
        uint* puCopied
    )
    {
        return (
            (delegate* unmanaged<
                IActiveIME,
                HIMC,
                ushort*,
                uint,
                uint,
                CANDIDATELIST*,
                uint*,
                int>)((*lpVtbl)[4])
        )(this, hIMC, szSource, uFlag, uBufLen, pDest, puCopied);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Configure(
        HKL hKL,
        HWND hWnd,
        [NativeTypeName("DWORD")] uint dwMode,
        REGISTERWORDW* pRegisterWord
    )
    {
        return (
            (delegate* unmanaged<IActiveIME, HKL, HWND, uint, REGISTERWORDW*, int>)((*lpVtbl)[5])
        )(this, hKL, hWnd, dwMode, pRegisterWord);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Destroy(uint uReserved)
    {
        return ((delegate* unmanaged<IActiveIME, uint, int>)((*lpVtbl)[6]))(this, uReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Escape(HIMC hIMC, uint uEscape, void* pData, LRESULT* plResult)
    {
        return ((delegate* unmanaged<IActiveIME, HIMC, uint, void*, LRESULT*, int>)((*lpVtbl)[7]))(
            this,
            hIMC,
            uEscape,
            pData,
            plResult
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetActiveContext(HIMC hIMC, BOOL fFlag)
    {
        return ((delegate* unmanaged<IActiveIME, HIMC, BOOL, int>)((*lpVtbl)[8]))(
            this,
            hIMC,
            fFlag
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ProcessKey(
        HIMC hIMC,
        uint uVirKey,
        [NativeTypeName("DWORD")] uint lParam,
        byte* pbKeyState
    )
    {
        return ((delegate* unmanaged<IActiveIME, HIMC, uint, uint, byte*, int>)((*lpVtbl)[9]))(
            this,
            hIMC,
            uVirKey,
            lParam,
            pbKeyState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Notify(
        HIMC hIMC,
        [NativeTypeName("DWORD")] uint dwAction,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("DWORD")] uint dwValue
    )
    {
        return ((delegate* unmanaged<IActiveIME, HIMC, uint, uint, uint, int>)((*lpVtbl)[10]))(
            this,
            hIMC,
            dwAction,
            dwIndex,
            dwValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Select(HIMC hIMC, BOOL fSelect)
    {
        return ((delegate* unmanaged<IActiveIME, HIMC, BOOL, int>)((*lpVtbl)[11]))(
            this,
            hIMC,
            fSelect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetCompositionString(
        HIMC hIMC,
        [NativeTypeName("DWORD")] uint dwIndex,
        void* pComp,
        [NativeTypeName("DWORD")] uint dwCompLen,
        void* pRead,
        [NativeTypeName("DWORD")] uint dwReadLen
    )
    {
        return (
            (delegate* unmanaged<IActiveIME, HIMC, uint, void*, uint, void*, uint, int>)(
                (*lpVtbl)[12]
            )
        )(this, hIMC, dwIndex, pComp, dwCompLen, pRead, dwReadLen);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ToAsciiEx(
        uint uVirKey,
        uint uScanCode,
        byte* pbKeyState,
        uint fuState,
        HIMC hIMC,
        [NativeTypeName("DWORD *")] uint* pdwTransBuf,
        uint* puSize
    )
    {
        return (
            (delegate* unmanaged<IActiveIME, uint, uint, byte*, uint, HIMC, uint*, uint*, int>)(
                (*lpVtbl)[13]
            )
        )(this, uVirKey, uScanCode, pbKeyState, fuState, hIMC, pdwTransBuf, puSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RegisterWord(
        [NativeTypeName("LPWSTR")] ushort* szReading,
        [NativeTypeName("DWORD")] uint dwStyle,
        [NativeTypeName("LPWSTR")] ushort* szString
    )
    {
        return ((delegate* unmanaged<IActiveIME, ushort*, uint, ushort*, int>)((*lpVtbl)[14]))(
            this,
            szReading,
            dwStyle,
            szString
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT UnregisterWord(
        [NativeTypeName("LPWSTR")] ushort* szReading,
        [NativeTypeName("DWORD")] uint dwStyle,
        [NativeTypeName("LPWSTR")] ushort* szString
    )
    {
        return ((delegate* unmanaged<IActiveIME, ushort*, uint, ushort*, int>)((*lpVtbl)[15]))(
            this,
            szReading,
            dwStyle,
            szString
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetRegisterWordStyle(uint nItem, STYLEBUFW* pStyleBuf, uint* puBufSize)
    {
        return ((delegate* unmanaged<IActiveIME, uint, STYLEBUFW*, uint*, int>)((*lpVtbl)[16]))(
            this,
            nItem,
            pStyleBuf,
            puBufSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT EnumRegisterWord(
        [NativeTypeName("LPWSTR")] ushort* szReading,
        [NativeTypeName("DWORD")] uint dwStyle,
        [NativeTypeName("LPWSTR")] ushort* szRegister,
        [NativeTypeName("LPVOID")] void* pData,
        IEnumRegisterWordW* ppEnum
    )
    {
        return (
            (delegate* unmanaged<
                IActiveIME,
                ushort*,
                uint,
                ushort*,
                void*,
                IEnumRegisterWordW*,
                int>)((*lpVtbl)[17])
        )(this, szReading, dwStyle, szRegister, pData, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetCodePageA(uint* uCodePage)
    {
        return ((delegate* unmanaged<IActiveIME, uint*, int>)((*lpVtbl)[18]))(this, uCodePage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetLangId([NativeTypeName("LANGID *")] ushort* plid)
    {
        return ((delegate* unmanaged<IActiveIME, ushort*, int>)((*lpVtbl)[19]))(this, plid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Inquire(
            [NativeTypeName("DWORD")] uint dwSystemInfoFlags,
            IMEINFO* pIMEInfo,
            [NativeTypeName("LPWSTR")] ushort* szWndClass,
            [NativeTypeName("DWORD *")] uint* pdwPrivate
        );

        [VtblIndex(4)]
        HRESULT ConversionList(
            HIMC hIMC,
            [NativeTypeName("LPWSTR")] ushort* szSource,
            uint uFlag,
            uint uBufLen,
            CANDIDATELIST* pDest,
            uint* puCopied
        );

        [VtblIndex(5)]
        HRESULT Configure(
            HKL hKL,
            HWND hWnd,
            [NativeTypeName("DWORD")] uint dwMode,
            REGISTERWORDW* pRegisterWord
        );

        [VtblIndex(6)]
        HRESULT Destroy(uint uReserved);

        [VtblIndex(7)]
        HRESULT Escape(HIMC hIMC, uint uEscape, void* pData, LRESULT* plResult);

        [VtblIndex(8)]
        HRESULT SetActiveContext(HIMC hIMC, BOOL fFlag);

        [VtblIndex(9)]
        HRESULT ProcessKey(
            HIMC hIMC,
            uint uVirKey,
            [NativeTypeName("DWORD")] uint lParam,
            byte* pbKeyState
        );

        [VtblIndex(10)]
        HRESULT Notify(
            HIMC hIMC,
            [NativeTypeName("DWORD")] uint dwAction,
            [NativeTypeName("DWORD")] uint dwIndex,
            [NativeTypeName("DWORD")] uint dwValue
        );

        [VtblIndex(11)]
        HRESULT Select(HIMC hIMC, BOOL fSelect);

        [VtblIndex(12)]
        HRESULT SetCompositionString(
            HIMC hIMC,
            [NativeTypeName("DWORD")] uint dwIndex,
            void* pComp,
            [NativeTypeName("DWORD")] uint dwCompLen,
            void* pRead,
            [NativeTypeName("DWORD")] uint dwReadLen
        );

        [VtblIndex(13)]
        HRESULT ToAsciiEx(
            uint uVirKey,
            uint uScanCode,
            byte* pbKeyState,
            uint fuState,
            HIMC hIMC,
            [NativeTypeName("DWORD *")] uint* pdwTransBuf,
            uint* puSize
        );

        [VtblIndex(14)]
        HRESULT RegisterWord(
            [NativeTypeName("LPWSTR")] ushort* szReading,
            [NativeTypeName("DWORD")] uint dwStyle,
            [NativeTypeName("LPWSTR")] ushort* szString
        );

        [VtblIndex(15)]
        HRESULT UnregisterWord(
            [NativeTypeName("LPWSTR")] ushort* szReading,
            [NativeTypeName("DWORD")] uint dwStyle,
            [NativeTypeName("LPWSTR")] ushort* szString
        );

        [VtblIndex(16)]
        HRESULT GetRegisterWordStyle(uint nItem, STYLEBUFW* pStyleBuf, uint* puBufSize);

        [VtblIndex(17)]
        HRESULT EnumRegisterWord(
            [NativeTypeName("LPWSTR")] ushort* szReading,
            [NativeTypeName("DWORD")] uint dwStyle,
            [NativeTypeName("LPWSTR")] ushort* szRegister,
            [NativeTypeName("LPVOID")] void* pData,
            IEnumRegisterWordW* ppEnum
        );

        [VtblIndex(18)]
        HRESULT GetCodePageA(uint* uCodePage);

        [VtblIndex(19)]
        HRESULT GetLangId([NativeTypeName("LANGID *")] ushort* plid);
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

        [NativeTypeName(
            "HRESULT (HIMC, LPWSTR, UINT, UINT, CANDIDATELIST *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HIMC,
            ushort*,
            uint,
            uint,
            CANDIDATELIST*,
            uint*,
            int> ConversionList;

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

        [NativeTypeName(
            "HRESULT (HIMC, DWORD, void *, DWORD, void *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HIMC,
            uint,
            void*,
            uint,
            void*,
            uint,
            int> SetCompositionString;

        [NativeTypeName(
            "HRESULT (UINT, UINT, BYTE *, UINT, HIMC, DWORD *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            byte*,
            uint,
            HIMC,
            uint*,
            uint*,
            int> ToAsciiEx;

        [NativeTypeName("HRESULT (LPWSTR, DWORD, LPWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort*, int> RegisterWord;

        [NativeTypeName("HRESULT (LPWSTR, DWORD, LPWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort*, int> UnregisterWord;

        [NativeTypeName("HRESULT (UINT, STYLEBUFW *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, STYLEBUFW*, uint*, int> GetRegisterWordStyle;

        [NativeTypeName(
            "HRESULT (LPWSTR, DWORD, LPWSTR, LPVOID, IEnumRegisterWordW **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            ushort*,
            void*,
            IEnumRegisterWordW*,
            int> EnumRegisterWord;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCodePageA;

        [NativeTypeName("HRESULT (LANGID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetLangId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IActiveIME"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IActiveIME(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IActiveIME"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IActiveIME(Silk.NET.Windows.IUnknown value)
    {
        return new IActiveIME(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IActiveIME"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IActiveIME"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IActiveIME value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
