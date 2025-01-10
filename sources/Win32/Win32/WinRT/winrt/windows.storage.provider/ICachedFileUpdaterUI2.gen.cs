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

[Guid("8856A21C-8699-4340-9F49-F7CAD7FE8991")]
[NativeTypeName("struct ICachedFileUpdaterUI2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICachedFileUpdaterUI2 : ICachedFileUpdaterUI2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICachedFileUpdaterUI2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICachedFileUpdaterUI2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICachedFileUpdaterUI2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UpdateRequest(
        [NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequest **")]
            IFileUpdateRequest* value
    )
    {
        return (
            (delegate* unmanaged<ICachedFileUpdaterUI2, IFileUpdateRequest*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequestDeferral **")]
            IFileUpdateRequestDeferral* value
    )
    {
        return (
            (delegate* unmanaged<ICachedFileUpdaterUI2, IFileUpdateRequestDeferral*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UpdateRequest(
            [NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequest **")]
                IFileUpdateRequest* value
        );

        [VtblIndex(7)]
        HRESULT GetDeferral(
            [NativeTypeName("ABI::Windows::Storage::Provider::IFileUpdateRequestDeferral **")]
                IFileUpdateRequestDeferral* value
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
            "HRESULT (ABI::Windows::Storage::Provider::IFileUpdateRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFileUpdateRequest*, int> get_UpdateRequest;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::IFileUpdateRequestDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFileUpdateRequestDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICachedFileUpdaterUI2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICachedFileUpdaterUI2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICachedFileUpdaterUI2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICachedFileUpdaterUI2(Silk.NET.WinRT.IInspectable value)
    {
        return new ICachedFileUpdaterUI2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICachedFileUpdaterUI2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICachedFileUpdaterUI2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICachedFileUpdaterUI2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICachedFileUpdaterUI2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICachedFileUpdaterUI2(Silk.NET.Windows.IUnknown value)
    {
        return new ICachedFileUpdaterUI2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICachedFileUpdaterUI2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICachedFileUpdaterUI2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICachedFileUpdaterUI2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
