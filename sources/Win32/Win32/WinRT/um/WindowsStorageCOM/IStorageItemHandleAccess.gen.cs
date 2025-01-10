// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5CA296B2-2C25-4D22-B785-B885C8201E6A")]
[NativeTypeName("struct IStorageItemHandleAccess : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IStorageItemHandleAccess
    : IStorageItemHandleAccess.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageItemHandleAccess));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageItemHandleAccess, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStorageItemHandleAccess, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageItemHandleAccess, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Create(
        HANDLE_ACCESS_OPTIONS accessOptions,
        HANDLE_SHARING_OPTIONS sharingOptions,
        HANDLE_OPTIONS options,
        IOplockBreakingHandler oplockBreakingHandler,
        HANDLE* interopHandle
    )
    {
        return (
            (delegate* unmanaged<
                IStorageItemHandleAccess,
                HANDLE_ACCESS_OPTIONS,
                HANDLE_SHARING_OPTIONS,
                HANDLE_OPTIONS,
                IOplockBreakingHandler,
                HANDLE*,
                int>)((*lpVtbl)[3])
        )(this, accessOptions, sharingOptions, options, oplockBreakingHandler, interopHandle);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Create(
            HANDLE_ACCESS_OPTIONS accessOptions,
            HANDLE_SHARING_OPTIONS sharingOptions,
            HANDLE_OPTIONS options,
            IOplockBreakingHandler oplockBreakingHandler,
            HANDLE* interopHandle
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
            "HRESULT (HANDLE_ACCESS_OPTIONS, HANDLE_SHARING_OPTIONS, HANDLE_OPTIONS, IOplockBreakingHandler *, HANDLE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HANDLE_ACCESS_OPTIONS,
            HANDLE_SHARING_OPTIONS,
            HANDLE_OPTIONS,
            IOplockBreakingHandler,
            HANDLE*,
            int> Create;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageItemHandleAccess"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageItemHandleAccess(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageItemHandleAccess"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageItemHandleAccess(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageItemHandleAccess(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageItemHandleAccess"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageItemHandleAccess"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageItemHandleAccess value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
