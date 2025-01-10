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

[Guid("33AB66E7-2D0E-448B-A6A0-C13C3836D09C")]
[NativeTypeName("struct IProcessLauncherStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProcessLauncherStatics
    : IProcessLauncherStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProcessLauncherStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProcessLauncherStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IProcessLauncherStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProcessLauncherStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IProcessLauncherStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IProcessLauncherStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IProcessLauncherStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RunToCompletionAsync(
        HSTRING fileName,
        HSTRING args,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOperationResult
    )
    {
        return (
            (delegate* unmanaged<
                IProcessLauncherStatics,
                HSTRING,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, fileName, args, asyncOperationResult);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RunToCompletionAsyncWithOptions(
        HSTRING fileName,
        HSTRING args,
        [NativeTypeName("ABI::Windows::System::IProcessLauncherOptions *")]
            IProcessLauncherOptions options,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **"
        )]
            IAsyncOperation<IntPtr>** asyncOperationResult
    )
    {
        return (
            (delegate* unmanaged<
                IProcessLauncherStatics,
                HSTRING,
                HSTRING,
                IProcessLauncherOptions,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, fileName, args, options, asyncOperationResult);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RunToCompletionAsync(
            HSTRING fileName,
            HSTRING args,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOperationResult
        );

        [VtblIndex(7)]
        HRESULT RunToCompletionAsyncWithOptions(
            HSTRING fileName,
            HSTRING args,
            [NativeTypeName("ABI::Windows::System::IProcessLauncherOptions *")]
                IProcessLauncherOptions options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **"
            )]
                IAsyncOperation<IntPtr>** asyncOperationResult
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
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> RunToCompletionAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::System::IProcessLauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CProcessLauncherResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IProcessLauncherOptions,
            IAsyncOperation<IntPtr>**,
            int> RunToCompletionAsyncWithOptions;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProcessLauncherStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProcessLauncherStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProcessLauncherStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProcessLauncherStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IProcessLauncherStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProcessLauncherStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProcessLauncherStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IProcessLauncherStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProcessLauncherStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProcessLauncherStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IProcessLauncherStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProcessLauncherStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProcessLauncherStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProcessLauncherStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
