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

[Guid("01B29DEF-E062-48A1-8B0C-F2C7A9CA56C0")]
[NativeTypeName("struct IUserDataPathsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataPathsStatics : IUserDataPathsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataPathsStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserDataPathsStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUserDataPathsStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserDataPathsStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IUserDataPathsStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUserDataPathsStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUserDataPathsStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForUser(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        [NativeTypeName("ABI::Windows::Storage::IUserDataPaths **")] IUserDataPaths* result
    )
    {
        return (
            (delegate* unmanaged<IUserDataPathsStatics, IUser, IUserDataPaths*, int>)((*lpVtbl)[6])
        )(this, user, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefault(
        [NativeTypeName("ABI::Windows::Storage::IUserDataPaths **")] IUserDataPaths* result
    )
    {
        return ((delegate* unmanaged<IUserDataPathsStatics, IUserDataPaths*, int>)((*lpVtbl)[7]))(
            this,
            result
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForUser(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            [NativeTypeName("ABI::Windows::Storage::IUserDataPaths **")] IUserDataPaths* result
        );

        [VtblIndex(7)]
        HRESULT GetDefault(
            [NativeTypeName("ABI::Windows::Storage::IUserDataPaths **")] IUserDataPaths* result
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
            "HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Storage::IUserDataPaths **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUser, IUserDataPaths*, int> GetForUser;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IUserDataPaths **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUserDataPaths*, int> GetDefault;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUserDataPathsStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUserDataPathsStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUserDataPathsStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUserDataPathsStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IUserDataPathsStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataPathsStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataPathsStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IUserDataPathsStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUserDataPathsStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUserDataPathsStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IUserDataPathsStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataPathsStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataPathsStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUserDataPathsStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
