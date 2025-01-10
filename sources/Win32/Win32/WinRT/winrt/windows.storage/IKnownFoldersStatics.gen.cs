// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5A2A7520-4802-452D-9AD9-4351ADA7EC35")]
[NativeTypeName("struct IKnownFoldersStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IKnownFoldersStatics : IKnownFoldersStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKnownFoldersStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKnownFoldersStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IKnownFoldersStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKnownFoldersStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IKnownFoldersStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IKnownFoldersStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IKnownFoldersStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MusicLibrary(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IKnownFoldersStatics, IStorageFolder*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PicturesLibrary(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IKnownFoldersStatics, IStorageFolder*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VideosLibrary(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IKnownFoldersStatics, IStorageFolder*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DocumentsLibrary(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IKnownFoldersStatics, IStorageFolder*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_HomeGroup(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IKnownFoldersStatics, IStorageFolder*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_RemovableDevices(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IKnownFoldersStatics, IStorageFolder*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MediaServerDevices(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IKnownFoldersStatics, IStorageFolder*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MusicLibrary(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(7)]
        HRESULT get_PicturesLibrary(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(8)]
        HRESULT get_VideosLibrary(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(9)]
        HRESULT get_DocumentsLibrary(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(10)]
        HRESULT get_HomeGroup(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(11)]
        HRESULT get_RemovableDevices(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(12)]
        HRESULT get_MediaServerDevices(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_MusicLibrary;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_PicturesLibrary;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_VideosLibrary;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_DocumentsLibrary;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_HomeGroup;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_RemovableDevices;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_MediaServerDevices;
    }

    /// <summary>Initializes a new instance of the <see cref = "IKnownFoldersStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IKnownFoldersStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IKnownFoldersStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IKnownFoldersStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IKnownFoldersStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKnownFoldersStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IKnownFoldersStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IKnownFoldersStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IKnownFoldersStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IKnownFoldersStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IKnownFoldersStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IKnownFoldersStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IKnownFoldersStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IKnownFoldersStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
