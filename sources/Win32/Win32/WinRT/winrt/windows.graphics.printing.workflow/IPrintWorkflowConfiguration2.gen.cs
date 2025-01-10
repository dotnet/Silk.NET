// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("DE350A50-A6D4-5BE2-8B9A-09D3D39EA780")]
[NativeTypeName("struct IPrintWorkflowConfiguration2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowConfiguration2
    : IPrintWorkflowConfiguration2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowConfiguration2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowConfiguration2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintWorkflowConfiguration2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintWorkflowConfiguration2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowConfiguration2, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPrintWorkflowConfiguration2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowConfiguration2, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AbortPrintFlow(
        [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowJobAbortReason")]
            PrintWorkflowJobAbortReason reason
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowConfiguration2, PrintWorkflowJobAbortReason, int>)(
                (*lpVtbl)[6]
            )
        )(this, reason);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AbortPrintFlow(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowJobAbortReason"
            )]
                PrintWorkflowJobAbortReason reason
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
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowJobAbortReason) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PrintWorkflowJobAbortReason, int> AbortPrintFlow;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintWorkflowConfiguration2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintWorkflowConfiguration2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintWorkflowConfiguration2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowConfiguration2(Silk.NET.WinRT.IInspectable value)
    {
        return new IPrintWorkflowConfiguration2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowConfiguration2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowConfiguration2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPrintWorkflowConfiguration2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintWorkflowConfiguration2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowConfiguration2(Silk.NET.Windows.IUnknown value)
    {
        return new IPrintWorkflowConfiguration2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowConfiguration2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowConfiguration2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrintWorkflowConfiguration2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
