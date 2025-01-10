// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C4CBB4F5-13DD-5C8E-8B96-336FC30C629B")]
[NativeTypeName("struct IStorageProviderKnownFolderSyncRequestedHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStorageProviderKnownFolderSyncRequestedHandler
    : IStorageProviderKnownFolderSyncRequestedHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IStorageProviderKnownFolderSyncRequestedHandler)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IStorageProviderKnownFolderSyncRequestedHandler,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderSyncRequestedHandler, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderSyncRequestedHandler, uint>)(
                (*lpVtbl)[2]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke(
        [NativeTypeName(
            "ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncRequestArgs *"
        )]
            IStorageProviderKnownFolderSyncRequestArgs args
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderKnownFolderSyncRequestedHandler,
                IStorageProviderKnownFolderSyncRequestArgs,
                int>)((*lpVtbl)[3])
        )(this, args);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke(
            [NativeTypeName(
                "ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncRequestArgs *"
            )]
                IStorageProviderKnownFolderSyncRequestArgs args
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
            "HRESULT (ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncRequestArgs *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageProviderKnownFolderSyncRequestArgs, int> Invoke;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageProviderKnownFolderSyncRequestedHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageProviderKnownFolderSyncRequestedHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageProviderKnownFolderSyncRequestedHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageProviderKnownFolderSyncRequestedHandler(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IStorageProviderKnownFolderSyncRequestedHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderKnownFolderSyncRequestedHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderKnownFolderSyncRequestedHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IStorageProviderKnownFolderSyncRequestedHandler value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
