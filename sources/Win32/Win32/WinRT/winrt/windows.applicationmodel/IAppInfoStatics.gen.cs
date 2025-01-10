// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("CF1F782A-E48B-4F0C-9B0B-79C3F8957DD7")]
[NativeTypeName("struct IAppInfoStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppInfoStatics : IAppInfoStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppInfoStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppInfoStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppInfoStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppInfoStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppInfoStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppInfoStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppInfoStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Current(
        [NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo* value
    )
    {
        return ((delegate* unmanaged<IAppInfoStatics, IAppInfo*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFromAppUserModelId(
        HSTRING appUserModelId,
        [NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo* result
    )
    {
        return ((delegate* unmanaged<IAppInfoStatics, HSTRING, IAppInfo*, int>)((*lpVtbl)[7]))(
            this,
            appUserModelId,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFromAppUserModelIdForUser(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        HSTRING appUserModelId,
        [NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo* result
    )
    {
        return (
            (delegate* unmanaged<IAppInfoStatics, IUser, HSTRING, IAppInfo*, int>)((*lpVtbl)[8])
        )(this, user, appUserModelId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Current(
            [NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo* value
        );

        [VtblIndex(7)]
        HRESULT GetFromAppUserModelId(
            HSTRING appUserModelId,
            [NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo* result
        );

        [VtblIndex(8)]
        HRESULT GetFromAppUserModelIdForUser(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            HSTRING appUserModelId,
            [NativeTypeName("ABI::Windows::ApplicationModel::IAppInfo **")] IAppInfo* result
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
            "HRESULT (ABI::Windows::ApplicationModel::IAppInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppInfo*, int> get_Current;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::IAppInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAppInfo*, int> GetFromAppUserModelId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::ApplicationModel::IAppInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            HSTRING,
            IAppInfo*,
            int> GetFromAppUserModelIdForUser;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppInfoStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppInfoStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppInfoStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppInfoStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppInfoStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppInfoStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppInfoStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppInfoStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppInfoStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppInfoStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IAppInfoStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppInfoStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppInfoStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppInfoStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
