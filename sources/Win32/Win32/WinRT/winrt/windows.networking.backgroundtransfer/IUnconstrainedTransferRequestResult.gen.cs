// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("4C24B81F-D944-4112-A98E-6A69522B7EBB")]
[NativeTypeName("struct IUnconstrainedTransferRequestResult : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "IUnconstrainedTransferRequestResult is deprecated and may not work on all platforms. For more info, see MSDN."
)]
public unsafe partial struct IUnconstrainedTransferRequestResult
    : IUnconstrainedTransferRequestResult.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUnconstrainedTransferRequestResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IUnconstrainedTransferRequestResult, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUnconstrainedTransferRequestResult, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUnconstrainedTransferRequestResult, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IUnconstrainedTransferRequestResult, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IUnconstrainedTransferRequestResult, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IUnconstrainedTransferRequestResult, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "IsUnconstrained is deprecated and may not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_IsUnconstrained([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<IUnconstrainedTransferRequestResult, byte*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "IsUnconstrained is deprecated and may not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_IsUnconstrained([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "IsUnconstrained is deprecated and may not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsUnconstrained;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUnconstrainedTransferRequestResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUnconstrainedTransferRequestResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUnconstrainedTransferRequestResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUnconstrainedTransferRequestResult(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IUnconstrainedTransferRequestResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUnconstrainedTransferRequestResult"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUnconstrainedTransferRequestResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IUnconstrainedTransferRequestResult value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUnconstrainedTransferRequestResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUnconstrainedTransferRequestResult(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IUnconstrainedTransferRequestResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUnconstrainedTransferRequestResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUnconstrainedTransferRequestResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IUnconstrainedTransferRequestResult value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
