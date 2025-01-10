// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/StorageProvider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("162C6FB5-44D3-435B-903D-E613FA093FB5")]
[NativeTypeName("struct IStorageProviderHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStorageProviderHandler
    : IStorageProviderHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageProviderHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStorageProviderHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageProviderHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPropertyHandlerFromPath(
        [NativeTypeName("LPCWSTR")] ushort* path,
        IStorageProviderPropertyHandler* propertyHandler
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderHandler,
                ushort*,
                IStorageProviderPropertyHandler*,
                int>)((*lpVtbl)[3])
        )(this, path, propertyHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyHandlerFromUri(
        [NativeTypeName("LPCWSTR")] ushort* uri,
        IStorageProviderPropertyHandler* propertyHandler
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderHandler,
                ushort*,
                IStorageProviderPropertyHandler*,
                int>)((*lpVtbl)[4])
        )(this, uri, propertyHandler);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPropertyHandlerFromFileId(
        [NativeTypeName("LPCWSTR")] ushort* fileId,
        IStorageProviderPropertyHandler* propertyHandler
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderHandler,
                ushort*,
                IStorageProviderPropertyHandler*,
                int>)((*lpVtbl)[5])
        )(this, fileId, propertyHandler);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPropertyHandlerFromPath(
            [NativeTypeName("LPCWSTR")] ushort* path,
            IStorageProviderPropertyHandler* propertyHandler
        );

        [VtblIndex(4)]
        HRESULT GetPropertyHandlerFromUri(
            [NativeTypeName("LPCWSTR")] ushort* uri,
            IStorageProviderPropertyHandler* propertyHandler
        );

        [VtblIndex(5)]
        HRESULT GetPropertyHandlerFromFileId(
            [NativeTypeName("LPCWSTR")] ushort* fileId,
            IStorageProviderPropertyHandler* propertyHandler
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
            "HRESULT (LPCWSTR, IStorageProviderPropertyHandler **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IStorageProviderPropertyHandler*,
            int> GetPropertyHandlerFromPath;

        [NativeTypeName(
            "HRESULT (LPCWSTR, IStorageProviderPropertyHandler **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IStorageProviderPropertyHandler*,
            int> GetPropertyHandlerFromUri;

        [NativeTypeName(
            "HRESULT (LPCWSTR, IStorageProviderPropertyHandler **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IStorageProviderPropertyHandler*,
            int> GetPropertyHandlerFromFileId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageProviderHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageProviderHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageProviderHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageProviderHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageProviderHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageProviderHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
