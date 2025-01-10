// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5B24EF84-D895-5FEA-9153-1AC49AED9BA9")]
[NativeTypeName("struct ILauncherStatics5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILauncherStatics5 : ILauncherStatics5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILauncherStatics5));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILauncherStatics5, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ILauncherStatics5, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILauncherStatics5, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ILauncherStatics5, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ILauncherStatics5, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ILauncherStatics5, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LaunchFolderPathAsync(
        HSTRING path,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<ILauncherStatics5, HSTRING, IAsyncOperation<byte>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, path, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LaunchFolderPathWithOptionsAsync(
        HSTRING path,
        [NativeTypeName("ABI::Windows::System::IFolderLauncherOptions *")]
            IFolderLauncherOptions options,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics5,
                HSTRING,
                IFolderLauncherOptions,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[7])
        )(this, path, options, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LaunchFolderPathForUserAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        HSTRING path,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<ILauncherStatics5, IUser, HSTRING, IAsyncOperation<byte>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, user, path, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LaunchFolderPathWithOptionsForUserAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        HSTRING path,
        [NativeTypeName("ABI::Windows::System::IFolderLauncherOptions *")]
            IFolderLauncherOptions options,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics5,
                IUser,
                HSTRING,
                IFolderLauncherOptions,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[9])
        )(this, user, path, options, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT LaunchFolderPathAsync(
            HSTRING path,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(7)]
        HRESULT LaunchFolderPathWithOptionsAsync(
            HSTRING path,
            [NativeTypeName("ABI::Windows::System::IFolderLauncherOptions *")]
                IFolderLauncherOptions options,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(8)]
        HRESULT LaunchFolderPathForUserAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            HSTRING path,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(9)]
        HRESULT LaunchFolderPathWithOptionsForUserAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            HSTRING path,
            [NativeTypeName("ABI::Windows::System::IFolderLauncherOptions *")]
                IFolderLauncherOptions options,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<byte>**,
            int> LaunchFolderPathAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::System::IFolderLauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IFolderLauncherOptions,
            IAsyncOperation<byte>**,
            int> LaunchFolderPathWithOptionsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            HSTRING,
            IAsyncOperation<byte>**,
            int> LaunchFolderPathForUserAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::System::IFolderLauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            HSTRING,
            IFolderLauncherOptions,
            IAsyncOperation<byte>**,
            int> LaunchFolderPathWithOptionsForUserAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILauncherStatics5"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILauncherStatics5(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ILauncherStatics5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ILauncherStatics5(Silk.NET.WinRT.IInspectable value)
    {
        return new ILauncherStatics5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILauncherStatics5"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ILauncherStatics5"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ILauncherStatics5 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILauncherStatics5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILauncherStatics5(Silk.NET.Windows.IUnknown value)
    {
        return new ILauncherStatics5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILauncherStatics5"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILauncherStatics5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ILauncherStatics5 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
