// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EDC17559-DD5D-4846-8EEF-8BECBA5A4ABF")]
[NativeTypeName("struct IInternetZoneManagerEx2 : IInternetZoneManagerEx")]
[NativeInheritance("IInternetZoneManagerEx")]
public unsafe partial struct IInternetZoneManagerEx2
    : IInternetZoneManagerEx2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetZoneManagerEx2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInternetZoneManagerEx2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetZoneAttributes(
        [NativeTypeName("DWORD")] uint dwZone,
        ZONEATTRIBUTES* pZoneAttributes
    )
    {
        return (
            (delegate* unmanaged<IInternetZoneManagerEx2, uint, ZONEATTRIBUTES*, int>)((*lpVtbl)[3])
        )(this, dwZone, pZoneAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetZoneAttributes(
        [NativeTypeName("DWORD")] uint dwZone,
        ZONEATTRIBUTES* pZoneAttributes
    )
    {
        return (
            (delegate* unmanaged<IInternetZoneManagerEx2, uint, ZONEATTRIBUTES*, int>)((*lpVtbl)[4])
        )(this, dwZone, pZoneAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetZoneCustomPolicy(
        [NativeTypeName("DWORD")] uint dwZone,
        [NativeTypeName("const GUID &")] Guid* guidKey,
        byte** ppPolicy,
        [NativeTypeName("DWORD *")] uint* pcbPolicy,
        URLZONEREG urlZoneReg
    )
    {
        return (
            (delegate* unmanaged<
                IInternetZoneManagerEx2,
                uint,
                Guid*,
                byte**,
                uint*,
                URLZONEREG,
                int>)((*lpVtbl)[5])
        )(this, dwZone, guidKey, ppPolicy, pcbPolicy, urlZoneReg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetZoneCustomPolicy(
        [NativeTypeName("DWORD")] uint dwZone,
        [NativeTypeName("const GUID &")] Guid* guidKey,
        byte* pPolicy,
        [NativeTypeName("DWORD")] uint cbPolicy,
        URLZONEREG urlZoneReg
    )
    {
        return (
            (delegate* unmanaged<
                IInternetZoneManagerEx2,
                uint,
                Guid*,
                byte*,
                uint,
                URLZONEREG,
                int>)((*lpVtbl)[6])
        )(this, dwZone, guidKey, pPolicy, cbPolicy, urlZoneReg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetZoneActionPolicy(
        [NativeTypeName("DWORD")] uint dwZone,
        [NativeTypeName("DWORD")] uint dwAction,
        byte* pPolicy,
        [NativeTypeName("DWORD")] uint cbPolicy,
        URLZONEREG urlZoneReg
    )
    {
        return (
            (delegate* unmanaged<
                IInternetZoneManagerEx2,
                uint,
                uint,
                byte*,
                uint,
                URLZONEREG,
                int>)((*lpVtbl)[7])
        )(this, dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetZoneActionPolicy(
        [NativeTypeName("DWORD")] uint dwZone,
        [NativeTypeName("DWORD")] uint dwAction,
        byte* pPolicy,
        [NativeTypeName("DWORD")] uint cbPolicy,
        URLZONEREG urlZoneReg
    )
    {
        return (
            (delegate* unmanaged<
                IInternetZoneManagerEx2,
                uint,
                uint,
                byte*,
                uint,
                URLZONEREG,
                int>)((*lpVtbl)[8])
        )(this, dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PromptAction(
        [NativeTypeName("DWORD")] uint dwAction,
        HWND hwndParent,
        [NativeTypeName("LPCWSTR")] ushort* pwszUrl,
        [NativeTypeName("LPCWSTR")] ushort* pwszText,
        [NativeTypeName("DWORD")] uint dwPromptFlags
    )
    {
        return (
            (delegate* unmanaged<IInternetZoneManagerEx2, uint, HWND, ushort*, ushort*, uint, int>)(
                (*lpVtbl)[9]
            )
        )(this, dwAction, hwndParent, pwszUrl, pwszText, dwPromptFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LogAction(
        [NativeTypeName("DWORD")] uint dwAction,
        [NativeTypeName("LPCWSTR")] ushort* pwszUrl,
        [NativeTypeName("LPCWSTR")] ushort* pwszText,
        [NativeTypeName("DWORD")] uint dwLogFlags
    )
    {
        return (
            (delegate* unmanaged<IInternetZoneManagerEx2, uint, ushort*, ushort*, uint, int>)(
                (*lpVtbl)[10]
            )
        )(this, dwAction, pwszUrl, pwszText, dwLogFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateZoneEnumerator(
        [NativeTypeName("DWORD *")] uint* pdwEnum,
        [NativeTypeName("DWORD *")] uint* pdwCount,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<IInternetZoneManagerEx2, uint*, uint*, uint, int>)((*lpVtbl)[11])
        )(this, pdwEnum, pdwCount, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetZoneAt(
        [NativeTypeName("DWORD")] uint dwEnum,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("DWORD *")] uint* pdwZone
    )
    {
        return (
            (delegate* unmanaged<IInternetZoneManagerEx2, uint, uint, uint*, int>)((*lpVtbl)[12])
        )(this, dwEnum, dwIndex, pdwZone);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DestroyZoneEnumerator([NativeTypeName("DWORD")] uint dwEnum)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx2, uint, int>)((*lpVtbl)[13]))(
            this,
            dwEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CopyTemplatePoliciesToZone(
        [NativeTypeName("DWORD")] uint dwTemplate,
        [NativeTypeName("DWORD")] uint dwZone,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<IInternetZoneManagerEx2, uint, uint, uint, int>)((*lpVtbl)[14])
        )(this, dwTemplate, dwZone, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetZoneActionPolicyEx(
        [NativeTypeName("DWORD")] uint dwZone,
        [NativeTypeName("DWORD")] uint dwAction,
        byte* pPolicy,
        [NativeTypeName("DWORD")] uint cbPolicy,
        URLZONEREG urlZoneReg,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<
                IInternetZoneManagerEx2,
                uint,
                uint,
                byte*,
                uint,
                URLZONEREG,
                uint,
                int>)((*lpVtbl)[15])
        )(this, dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetZoneActionPolicyEx(
        [NativeTypeName("DWORD")] uint dwZone,
        [NativeTypeName("DWORD")] uint dwAction,
        byte* pPolicy,
        [NativeTypeName("DWORD")] uint cbPolicy,
        URLZONEREG urlZoneReg,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<
                IInternetZoneManagerEx2,
                uint,
                uint,
                byte*,
                uint,
                URLZONEREG,
                uint,
                int>)((*lpVtbl)[16])
        )(this, dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetZoneAttributesEx(
        [NativeTypeName("DWORD")] uint dwZone,
        ZONEATTRIBUTES* pZoneAttributes,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<IInternetZoneManagerEx2, uint, ZONEATTRIBUTES*, uint, int>)(
                (*lpVtbl)[17]
            )
        )(this, dwZone, pZoneAttributes, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetZoneSecurityState(
        [NativeTypeName("DWORD")] uint dwZoneIndex,
        BOOL fRespectPolicy,
        [NativeTypeName("LPDWORD")] uint* pdwState,
        BOOL* pfPolicyEncountered
    )
    {
        return (
            (delegate* unmanaged<IInternetZoneManagerEx2, uint, BOOL, uint*, BOOL*, int>)(
                (*lpVtbl)[18]
            )
        )(this, dwZoneIndex, fRespectPolicy, pdwState, pfPolicyEncountered);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetIESecurityState(
        BOOL fRespectPolicy,
        [NativeTypeName("LPDWORD")] uint* pdwState,
        BOOL* pfPolicyEncountered,
        BOOL fNoCache
    )
    {
        return (
            (delegate* unmanaged<IInternetZoneManagerEx2, BOOL, uint*, BOOL*, BOOL, int>)(
                (*lpVtbl)[19]
            )
        )(this, fRespectPolicy, pdwState, pfPolicyEncountered, fNoCache);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT FixUnsecureSettings()
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx2, int>)((*lpVtbl)[20]))(this);
    }

    public interface Interface : IInternetZoneManagerEx.Interface
    {
        [VtblIndex(17)]
        HRESULT GetZoneAttributesEx(
            [NativeTypeName("DWORD")] uint dwZone,
            ZONEATTRIBUTES* pZoneAttributes,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(18)]
        HRESULT GetZoneSecurityState(
            [NativeTypeName("DWORD")] uint dwZoneIndex,
            BOOL fRespectPolicy,
            [NativeTypeName("LPDWORD")] uint* pdwState,
            BOOL* pfPolicyEncountered
        );

        [VtblIndex(19)]
        HRESULT GetIESecurityState(
            BOOL fRespectPolicy,
            [NativeTypeName("LPDWORD")] uint* pdwState,
            BOOL* pfPolicyEncountered,
            BOOL fNoCache
        );

        [VtblIndex(20)]
        HRESULT FixUnsecureSettings();
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

        [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ZONEATTRIBUTES*, int> GetZoneAttributes;

        [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ZONEATTRIBUTES*, int> SetZoneAttributes;

        [NativeTypeName(
            "HRESULT (DWORD, const GUID &, BYTE **, DWORD *, URLZONEREG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            Guid*,
            byte**,
            uint*,
            URLZONEREG,
            int> GetZoneCustomPolicy;

        [NativeTypeName(
            "HRESULT (DWORD, const GUID &, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            Guid*,
            byte*,
            uint,
            URLZONEREG,
            int> SetZoneCustomPolicy;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            byte*,
            uint,
            URLZONEREG,
            int> GetZoneActionPolicy;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            byte*,
            uint,
            URLZONEREG,
            int> SetZoneActionPolicy;

        [NativeTypeName("HRESULT (DWORD, HWND, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HWND, ushort*, ushort*, uint, int> PromptAction;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, ushort*, uint, int> LogAction;

        [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, uint, int> CreateZoneEnumerator;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint*, int> GetZoneAt;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DestroyZoneEnumerator;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> CopyTemplatePoliciesToZone;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            byte*,
            uint,
            URLZONEREG,
            uint,
            int> GetZoneActionPolicyEx;

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            byte*,
            uint,
            URLZONEREG,
            uint,
            int> SetZoneActionPolicyEx;

        [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ZONEATTRIBUTES*, uint, int> GetZoneAttributesEx;

        [NativeTypeName("HRESULT (DWORD, BOOL, LPDWORD, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, uint*, BOOL*, int> GetZoneSecurityState;

        [NativeTypeName("HRESULT (BOOL, LPDWORD, BOOL *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, uint*, BOOL*, BOOL, int> GetIESecurityState;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FixUnsecureSettings;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInternetZoneManagerEx2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInternetZoneManagerEx2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IInternetZoneManagerEx"/> to <see cref = "IInternetZoneManagerEx2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IInternetZoneManagerEx"/> instance to be converted </param>
    public static explicit operator IInternetZoneManagerEx2(
        Silk.NET.Windows.IInternetZoneManagerEx value
    )
    {
        return new IInternetZoneManagerEx2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetZoneManagerEx2"/> to <see cref = "Silk.NET.Windows.IInternetZoneManagerEx"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetZoneManagerEx2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IInternetZoneManagerEx(
        IInternetZoneManagerEx2 value
    )
    {
        return new Silk.NET.Windows.IInternetZoneManagerEx(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IInternetZoneManager"/> to <see cref = "IInternetZoneManagerEx2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IInternetZoneManager"/> instance to be converted </param>
    public static explicit operator IInternetZoneManagerEx2(
        Silk.NET.Windows.IInternetZoneManager value
    )
    {
        return new IInternetZoneManagerEx2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetZoneManagerEx2"/> to <see cref = "Silk.NET.Windows.IInternetZoneManager"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetZoneManagerEx2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IInternetZoneManager(
        IInternetZoneManagerEx2 value
    )
    {
        return new Silk.NET.Windows.IInternetZoneManager(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInternetZoneManagerEx2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInternetZoneManagerEx2(Silk.NET.Windows.IUnknown value)
    {
        return new IInternetZoneManagerEx2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetZoneManagerEx2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetZoneManagerEx2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInternetZoneManagerEx2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
