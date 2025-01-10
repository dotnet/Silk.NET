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

[Guid("9FC90920-7BCF-4888-A81E-102D7034D7CE")]
[NativeTypeName("struct ICachedFileUpdaterStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICachedFileUpdaterStatics
    : ICachedFileUpdaterStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICachedFileUpdaterStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICachedFileUpdaterStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICachedFileUpdaterStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICachedFileUpdaterStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICachedFileUpdaterStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICachedFileUpdaterStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICachedFileUpdaterStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetUpdateInformation(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        HSTRING contentId,
        [NativeTypeName("ABI::Windows::Storage::Provider::ReadActivationMode")]
            ReadActivationMode readMode,
        [NativeTypeName("ABI::Windows::Storage::Provider::WriteActivationMode")]
            WriteActivationMode writeMode,
        [NativeTypeName("ABI::Windows::Storage::Provider::CachedFileOptions")]
            CachedFileOptions options
    )
    {
        return (
            (delegate* unmanaged<
                ICachedFileUpdaterStatics,
                IStorageFile,
                HSTRING,
                ReadActivationMode,
                WriteActivationMode,
                CachedFileOptions,
                int>)((*lpVtbl)[6])
        )(this, file, contentId, readMode, writeMode, options);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetUpdateInformation(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            HSTRING contentId,
            [NativeTypeName("ABI::Windows::Storage::Provider::ReadActivationMode")]
                ReadActivationMode readMode,
            [NativeTypeName("ABI::Windows::Storage::Provider::WriteActivationMode")]
                WriteActivationMode writeMode,
            [NativeTypeName("ABI::Windows::Storage::Provider::CachedFileOptions")]
                CachedFileOptions options
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
            "HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Storage::Provider::ReadActivationMode, ABI::Windows::Storage::Provider::WriteActivationMode, ABI::Windows::Storage::Provider::CachedFileOptions) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            HSTRING,
            ReadActivationMode,
            WriteActivationMode,
            CachedFileOptions,
            int> SetUpdateInformation;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICachedFileUpdaterStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICachedFileUpdaterStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICachedFileUpdaterStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICachedFileUpdaterStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new ICachedFileUpdaterStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICachedFileUpdaterStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICachedFileUpdaterStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICachedFileUpdaterStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICachedFileUpdaterStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICachedFileUpdaterStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ICachedFileUpdaterStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICachedFileUpdaterStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICachedFileUpdaterStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICachedFileUpdaterStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
