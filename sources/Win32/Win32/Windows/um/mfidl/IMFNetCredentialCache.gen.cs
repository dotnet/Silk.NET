// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5B87EF6C-7ED8-434F-BA0E-184FAC1628D1")]
[NativeTypeName("struct IMFNetCredentialCache : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFNetCredentialCache : IMFNetCredentialCache.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFNetCredentialCache));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFNetCredentialCache, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFNetCredentialCache, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFNetCredentialCache, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCredential(
        [NativeTypeName("LPCWSTR")] ushort* pszUrl,
        [NativeTypeName("LPCWSTR")] ushort* pszRealm,
        [NativeTypeName("DWORD")] uint dwAuthenticationFlags,
        IMFNetCredential* ppCred,
        [NativeTypeName("DWORD *")] uint* pdwRequirementsFlags
    )
    {
        return (
            (delegate* unmanaged<
                IMFNetCredentialCache,
                ushort*,
                ushort*,
                uint,
                IMFNetCredential*,
                uint*,
                int>)((*lpVtbl)[3])
        )(this, pszUrl, pszRealm, dwAuthenticationFlags, ppCred, pdwRequirementsFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetGood(IMFNetCredential pCred, BOOL fGood)
    {
        return (
            (delegate* unmanaged<IMFNetCredentialCache, IMFNetCredential, BOOL, int>)((*lpVtbl)[4])
        )(this, pCred, fGood);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetUserOptions(
        IMFNetCredential pCred,
        [NativeTypeName("DWORD")] uint dwOptionsFlags
    )
    {
        return (
            (delegate* unmanaged<IMFNetCredentialCache, IMFNetCredential, uint, int>)((*lpVtbl)[5])
        )(this, pCred, dwOptionsFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCredential(
            [NativeTypeName("LPCWSTR")] ushort* pszUrl,
            [NativeTypeName("LPCWSTR")] ushort* pszRealm,
            [NativeTypeName("DWORD")] uint dwAuthenticationFlags,
            IMFNetCredential* ppCred,
            [NativeTypeName("DWORD *")] uint* pdwRequirementsFlags
        );

        [VtblIndex(4)]
        HRESULT SetGood(IMFNetCredential pCred, BOOL fGood);

        [VtblIndex(5)]
        HRESULT SetUserOptions(
            IMFNetCredential pCred,
            [NativeTypeName("DWORD")] uint dwOptionsFlags
        );
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

        [NativeTypeName(
            "HRESULT (LPCWSTR, LPCWSTR, DWORD, IMFNetCredential **, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            uint,
            IMFNetCredential*,
            uint*,
            int> GetCredential;

        [NativeTypeName("HRESULT (IMFNetCredential *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFNetCredential, BOOL, int> SetGood;

        [NativeTypeName("HRESULT (IMFNetCredential *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFNetCredential, uint, int> SetUserOptions;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFNetCredentialCache"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFNetCredentialCache(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFNetCredentialCache"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFNetCredentialCache(Silk.NET.Windows.IUnknown value)
    {
        return new IMFNetCredentialCache(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFNetCredentialCache"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFNetCredentialCache"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFNetCredentialCache value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
