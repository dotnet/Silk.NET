// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("28E3ED6A-E9E7-4A03-9F53-BDB16172699B")]
[NativeTypeName("struct IProtectedFileCreateResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectedFileCreateResult
    : IProtectedFileCreateResult.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectedFileCreateResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IProtectedFileCreateResult, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectedFileCreateResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectedFileCreateResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IProtectedFileCreateResult, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IProtectedFileCreateResult, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IProtectedFileCreateResult, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_File(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile* value
    )
    {
        return (
            (delegate* unmanaged<IProtectedFileCreateResult, IStorageFile*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Stream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")]
            IRandomAccessStream* value
    )
    {
        return (
            (delegate* unmanaged<IProtectedFileCreateResult, IRandomAccessStream*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ProtectionInfo(
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IFileProtectionInfo **")]
            IFileProtectionInfo* value
    )
    {
        return (
            (delegate* unmanaged<IProtectedFileCreateResult, IFileProtectionInfo*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_File(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile* value
        );

        [VtblIndex(7)]
        HRESULT get_Stream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")]
                IRandomAccessStream* value
        );

        [VtblIndex(8)]
        HRESULT get_ProtectionInfo(
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IFileProtectionInfo **")]
                IFileProtectionInfo* value
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
            "HRESULT (ABI::Windows::Storage::IStorageFile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFile*, int> get_File;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStream*, int> get_Stream;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::EnterpriseData::IFileProtectionInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFileProtectionInfo*, int> get_ProtectionInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProtectedFileCreateResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProtectedFileCreateResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProtectedFileCreateResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProtectedFileCreateResult(Silk.NET.WinRT.IInspectable value)
    {
        return new IProtectedFileCreateResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectedFileCreateResult"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectedFileCreateResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IProtectedFileCreateResult value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProtectedFileCreateResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProtectedFileCreateResult(Silk.NET.Windows.IUnknown value)
    {
        return new IProtectedFileCreateResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectedFileCreateResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectedFileCreateResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProtectedFileCreateResult value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
