// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5B87EF6B-7ED8-434F-BA0E-184FAC1628D1")]
[NativeTypeName("struct IMFNetCredentialManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFNetCredentialManager
    : IMFNetCredentialManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFNetCredentialManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFNetCredentialManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFNetCredentialManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFNetCredentialManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginGetCredentials(
        MFNetCredentialManagerGetParam* pParam,
        IMFAsyncCallback pCallback,
        IUnknown pState
    )
    {
        return (
            (delegate* unmanaged<
                IMFNetCredentialManager,
                MFNetCredentialManagerGetParam*,
                IMFAsyncCallback,
                IUnknown,
                int>)((*lpVtbl)[3])
        )(this, pParam, pCallback, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndGetCredentials(IMFAsyncResult pResult, IMFNetCredential* ppCred)
    {
        return (
            (delegate* unmanaged<IMFNetCredentialManager, IMFAsyncResult, IMFNetCredential*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pResult, ppCred);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetGood(IMFNetCredential pCred, BOOL fGood)
    {
        return (
            (delegate* unmanaged<IMFNetCredentialManager, IMFNetCredential, BOOL, int>)(
                (*lpVtbl)[5]
            )
        )(this, pCred, fGood);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginGetCredentials(
            MFNetCredentialManagerGetParam* pParam,
            IMFAsyncCallback pCallback,
            IUnknown pState
        );

        [VtblIndex(4)]
        HRESULT EndGetCredentials(IMFAsyncResult pResult, IMFNetCredential* ppCred);

        [VtblIndex(5)]
        HRESULT SetGood(IMFNetCredential pCred, BOOL fGood);
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
            "HRESULT (MFNetCredentialManagerGetParam *, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MFNetCredentialManagerGetParam*,
            IMFAsyncCallback,
            IUnknown,
            int> BeginGetCredentials;

        [NativeTypeName("HRESULT (IMFAsyncResult *, IMFNetCredential **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMFAsyncResult,
            IMFNetCredential*,
            int> EndGetCredentials;

        [NativeTypeName("HRESULT (IMFNetCredential *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFNetCredential, BOOL, int> SetGood;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFNetCredentialManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFNetCredentialManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFNetCredentialManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFNetCredentialManager(Silk.NET.Windows.IUnknown value)
    {
        return new IMFNetCredentialManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFNetCredentialManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFNetCredentialManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFNetCredentialManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
