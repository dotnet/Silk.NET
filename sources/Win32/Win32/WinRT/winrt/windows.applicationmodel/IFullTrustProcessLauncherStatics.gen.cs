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

[Guid("D784837F-1100-3C6B-A455-F6262CC331B6")]
[NativeTypeName("struct IFullTrustProcessLauncherStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFullTrustProcessLauncherStatics
    : IFullTrustProcessLauncherStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFullTrustProcessLauncherStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IFullTrustProcessLauncherStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFullTrustProcessLauncherStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFullTrustProcessLauncherStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IFullTrustProcessLauncherStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IFullTrustProcessLauncherStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IFullTrustProcessLauncherStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LaunchFullTrustProcessForCurrentAppAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return (
            (delegate* unmanaged<IFullTrustProcessLauncherStatics, IAsyncAction*, int>)(
                (*lpVtbl)[6]
            )
        )(this, asyncAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LaunchFullTrustProcessForCurrentAppWithParametersAsync(
        HSTRING parameterGroupId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return (
            (delegate* unmanaged<IFullTrustProcessLauncherStatics, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[7]
            )
        )(this, parameterGroupId, asyncAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LaunchFullTrustProcessForAppAsync(
        HSTRING fullTrustPackageRelativeAppId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return (
            (delegate* unmanaged<IFullTrustProcessLauncherStatics, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[8]
            )
        )(this, fullTrustPackageRelativeAppId, asyncAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LaunchFullTrustProcessForAppWithParametersAsync(
        HSTRING fullTrustPackageRelativeAppId,
        HSTRING parameterGroupId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
    )
    {
        return (
            (delegate* unmanaged<
                IFullTrustProcessLauncherStatics,
                HSTRING,
                HSTRING,
                IAsyncAction*,
                int>)((*lpVtbl)[9])
        )(this, fullTrustPackageRelativeAppId, parameterGroupId, asyncAction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT LaunchFullTrustProcessForCurrentAppAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );

        [VtblIndex(7)]
        HRESULT LaunchFullTrustProcessForCurrentAppWithParametersAsync(
            HSTRING parameterGroupId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );

        [VtblIndex(8)]
        HRESULT LaunchFullTrustProcessForAppAsync(
            HSTRING fullTrustPackageRelativeAppId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
        );

        [VtblIndex(9)]
        HRESULT LaunchFullTrustProcessForAppWithParametersAsync(
            HSTRING fullTrustPackageRelativeAppId,
            HSTRING parameterGroupId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncAction
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
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncAction*,
            int> LaunchFullTrustProcessForCurrentAppAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncAction*,
            int> LaunchFullTrustProcessForCurrentAppWithParametersAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncAction*,
            int> LaunchFullTrustProcessForAppAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IAsyncAction*,
            int> LaunchFullTrustProcessForAppWithParametersAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFullTrustProcessLauncherStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFullTrustProcessLauncherStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFullTrustProcessLauncherStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFullTrustProcessLauncherStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IFullTrustProcessLauncherStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFullTrustProcessLauncherStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFullTrustProcessLauncherStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IFullTrustProcessLauncherStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFullTrustProcessLauncherStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFullTrustProcessLauncherStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IFullTrustProcessLauncherStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFullTrustProcessLauncherStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFullTrustProcessLauncherStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IFullTrustProcessLauncherStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
