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

[Guid("40C82536-C1FE-4D93-A792-1E736BC70837")]
[NativeTypeName("struct IFileUpdateRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileUpdateRequest : IFileUpdateRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileUpdateRequest));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileUpdateRequest, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileUpdateRequest, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileUpdateRequest, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFileUpdateRequest, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFileUpdateRequest, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFileUpdateRequest, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContentId(HSTRING* value)
    {
        return ((delegate* unmanaged<IFileUpdateRequest, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_File(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile* value
    )
    {
        return ((delegate* unmanaged<IFileUpdateRequest, IStorageFile*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Status(
        [NativeTypeName("ABI::Windows::Storage::Provider::FileUpdateStatus *")]
            FileUpdateStatus* value
    )
    {
        return ((delegate* unmanaged<IFileUpdateRequest, FileUpdateStatus*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Status(
        [NativeTypeName("ABI::Windows::Storage::Provider::FileUpdateStatus")] FileUpdateStatus value
    )
    {
        return ((delegate* unmanaged<IFileUpdateRequest, FileUpdateStatus, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequestDeferral **")]
            IFileUpdateRequestDeferral* value
    )
    {
        return (
            (delegate* unmanaged<IFileUpdateRequest, IFileUpdateRequestDeferral*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UpdateLocalFile(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile value
    )
    {
        return ((delegate* unmanaged<IFileUpdateRequest, IStorageFile, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContentId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_File(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile* value
        );

        [VtblIndex(8)]
        HRESULT get_Status(
            [NativeTypeName("ABI::Windows::Storage::Provider::FileUpdateStatus *")]
                FileUpdateStatus* value
        );

        [VtblIndex(9)]
        HRESULT put_Status(
            [NativeTypeName("ABI::Windows::Storage::Provider::FileUpdateStatus")]
                FileUpdateStatus value
        );

        [VtblIndex(10)]
        HRESULT GetDeferral(
            [NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequestDeferral **")]
                IFileUpdateRequestDeferral* value
        );

        [VtblIndex(11)]
        HRESULT UpdateLocalFile(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ContentId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFile*, int> get_File;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::FileUpdateStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FileUpdateStatus*, int> get_Status;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::FileUpdateStatus) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FileUpdateStatus, int> put_Status;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::IFileUpdateRequestDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFileUpdateRequestDeferral*, int> GetDeferral;

        [NativeTypeName("HRESULT (ABI::Windows::Storage::IStorageFile *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStorageFile, int> UpdateLocalFile;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileUpdateRequest"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileUpdateRequest(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFileUpdateRequest"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFileUpdateRequest(Silk.NET.WinRT.IInspectable value)
    {
        return new IFileUpdateRequest(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileUpdateRequest"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFileUpdateRequest"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFileUpdateRequest value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileUpdateRequest"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileUpdateRequest(Silk.NET.Windows.IUnknown value)
    {
        return new IFileUpdateRequest(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileUpdateRequest"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileUpdateRequest"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileUpdateRequest value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
