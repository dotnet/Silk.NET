// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6FF61E2E-2722-4240-A67C-F364849A17F3")]
[NativeTypeName("struct IPrintTaskRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintTaskRequest : IPrintTaskRequest.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintTaskRequest));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintTaskRequest, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPrintTaskRequest, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintTaskRequest, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPrintTaskRequest, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPrintTaskRequest, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPrintTaskRequest, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Deadline(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IPrintTaskRequest, WinRTDateTime*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreatePrintTask(
        HSTRING title,
        [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskSourceRequestedHandler *")]
            IPrintTaskSourceRequestedHandler handler,
        [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTask **")] IPrintTask* task
    )
    {
        return (
            (delegate* unmanaged<
                IPrintTaskRequest,
                HSTRING,
                IPrintTaskSourceRequestedHandler,
                IPrintTask*,
                int>)((*lpVtbl)[7])
        )(this, title, handler, task);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskRequestedDeferral **")]
            IPrintTaskRequestedDeferral* deferral
    )
    {
        return (
            (delegate* unmanaged<IPrintTaskRequest, IPrintTaskRequestedDeferral*, int>)(
                (*lpVtbl)[8]
            )
        )(this, deferral);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Deadline(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(7)]
        HRESULT CreatePrintTask(
            HSTRING title,
            [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskSourceRequestedHandler *")]
                IPrintTaskSourceRequestedHandler handler,
            [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTask **")] IPrintTask* task
        );

        [VtblIndex(8)]
        HRESULT GetDeferral(
            [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskRequestedDeferral **")]
                IPrintTaskRequestedDeferral* deferral
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_Deadline;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Graphics::Printing::IPrintTaskSourceRequestedHandler *, ABI::Windows::Graphics::Printing::IPrintTask **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IPrintTaskSourceRequestedHandler,
            IPrintTask*,
            int> CreatePrintTask;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::IPrintTaskRequestedDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPrintTaskRequestedDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintTaskRequest"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintTaskRequest(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintTaskRequest"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintTaskRequest(Silk.NET.WinRT.IInspectable value)
    {
        return new IPrintTaskRequest(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintTaskRequest"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintTaskRequest"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPrintTaskRequest value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintTaskRequest"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintTaskRequest(Silk.NET.Windows.IUnknown value)
    {
        return new IPrintTaskRequest(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintTaskRequest"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintTaskRequest"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrintTaskRequest value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
