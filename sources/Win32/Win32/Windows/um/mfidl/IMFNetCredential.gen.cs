// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5B87EF6A-7ED8-434F-BA0E-184FAC1628D1")]
[NativeTypeName("struct IMFNetCredential : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFNetCredential : IMFNetCredential.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFNetCredential));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFNetCredential, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFNetCredential, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFNetCredential, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetUser(
        byte* pbData,
        [NativeTypeName("DWORD")] uint cbData,
        BOOL fDataIsEncrypted
    )
    {
        return ((delegate* unmanaged<IMFNetCredential, byte*, uint, BOOL, int>)((*lpVtbl)[3]))(
            this,
            pbData,
            cbData,
            fDataIsEncrypted
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPassword(
        byte* pbData,
        [NativeTypeName("DWORD")] uint cbData,
        BOOL fDataIsEncrypted
    )
    {
        return ((delegate* unmanaged<IMFNetCredential, byte*, uint, BOOL, int>)((*lpVtbl)[4]))(
            this,
            pbData,
            cbData,
            fDataIsEncrypted
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetUser(
        byte* pbData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        BOOL fEncryptData
    )
    {
        return ((delegate* unmanaged<IMFNetCredential, byte*, uint*, BOOL, int>)((*lpVtbl)[5]))(
            this,
            pbData,
            pcbData,
            fEncryptData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPassword(
        byte* pbData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        BOOL fEncryptData
    )
    {
        return ((delegate* unmanaged<IMFNetCredential, byte*, uint*, BOOL, int>)((*lpVtbl)[6]))(
            this,
            pbData,
            pcbData,
            fEncryptData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LoggedOnUser(BOOL* pfLoggedOnUser)
    {
        return ((delegate* unmanaged<IMFNetCredential, BOOL*, int>)((*lpVtbl)[7]))(
            this,
            pfLoggedOnUser
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetUser(byte* pbData, [NativeTypeName("DWORD")] uint cbData, BOOL fDataIsEncrypted);

        [VtblIndex(4)]
        HRESULT SetPassword(
            byte* pbData,
            [NativeTypeName("DWORD")] uint cbData,
            BOOL fDataIsEncrypted
        );

        [VtblIndex(5)]
        HRESULT GetUser(byte* pbData, [NativeTypeName("DWORD *")] uint* pcbData, BOOL fEncryptData);

        [VtblIndex(6)]
        HRESULT GetPassword(
            byte* pbData,
            [NativeTypeName("DWORD *")] uint* pcbData,
            BOOL fEncryptData
        );

        [VtblIndex(7)]
        HRESULT LoggedOnUser(BOOL* pfLoggedOnUser);
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

        [NativeTypeName("HRESULT (BYTE *, DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, BOOL, int> SetUser;

        [NativeTypeName("HRESULT (BYTE *, DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, BOOL, int> SetPassword;

        [NativeTypeName("HRESULT (BYTE *, DWORD *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint*, BOOL, int> GetUser;

        [NativeTypeName("HRESULT (BYTE *, DWORD *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint*, BOOL, int> GetPassword;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> LoggedOnUser;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFNetCredential"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFNetCredential(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFNetCredential"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFNetCredential(Silk.NET.Windows.IUnknown value)
    {
        return new IMFNetCredential(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFNetCredential"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFNetCredential"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFNetCredential value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
