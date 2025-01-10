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

[Guid("B29806D1-8BE0-4962-8BB6-0D4C2E14D47A")]
[NativeTypeName("struct IStorageProviderUriSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderUriSource
    : IStorageProviderUriSource.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderUriSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageProviderUriSource, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStorageProviderUriSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageProviderUriSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStorageProviderUriSource, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStorageProviderUriSource, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStorageProviderUriSource, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPathForContentUri(
        HSTRING contentUri,
        [NativeTypeName(
            "ABI::Windows::Storage::Provider::IStorageProviderGetPathForContentUriResult *"
        )]
            IStorageProviderGetPathForContentUriResult result
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderUriSource,
                HSTRING,
                IStorageProviderGetPathForContentUriResult,
                int>)((*lpVtbl)[6])
        )(this, contentUri, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetContentInfoForPath(
        HSTRING path,
        [NativeTypeName(
            "ABI::Windows::Storage::Provider::IStorageProviderGetContentInfoForPathResult *"
        )]
            IStorageProviderGetContentInfoForPathResult result
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderUriSource,
                HSTRING,
                IStorageProviderGetContentInfoForPathResult,
                int>)((*lpVtbl)[7])
        )(this, path, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetPathForContentUri(
            HSTRING contentUri,
            [NativeTypeName(
                "ABI::Windows::Storage::Provider::IStorageProviderGetPathForContentUriResult *"
            )]
                IStorageProviderGetPathForContentUriResult result
        );

        [VtblIndex(7)]
        HRESULT GetContentInfoForPath(
            HSTRING path,
            [NativeTypeName(
                "ABI::Windows::Storage::Provider::IStorageProviderGetContentInfoForPathResult *"
            )]
                IStorageProviderGetContentInfoForPathResult result
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
            "HRESULT (HSTRING, ABI::Windows::Storage::Provider::IStorageProviderGetPathForContentUriResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IStorageProviderGetPathForContentUriResult,
            int> GetPathForContentUri;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::Provider::IStorageProviderGetContentInfoForPathResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IStorageProviderGetContentInfoForPathResult,
            int> GetContentInfoForPath;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageProviderUriSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageProviderUriSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageProviderUriSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageProviderUriSource(Silk.NET.WinRT.IInspectable value)
    {
        return new IStorageProviderUriSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderUriSource"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderUriSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStorageProviderUriSource value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageProviderUriSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageProviderUriSource(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageProviderUriSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderUriSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderUriSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageProviderUriSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
