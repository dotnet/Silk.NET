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

[Guid("D8C3E3E4-6459-4540-85EB-AAA1C8903677")]
[NativeTypeName("struct IBackgroundTransferGroup : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTransferGroup
    : IBackgroundTransferGroup.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTransferGroup));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBackgroundTransferGroup, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBackgroundTransferGroup, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundTransferGroup, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBackgroundTransferGroup, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBackgroundTransferGroup, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBackgroundTransferGroup, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IBackgroundTransferGroup, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_TransferBehavior(
        [NativeTypeName(
            "ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferBehavior *"
        )]
            BackgroundTransferBehavior* value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferGroup, BackgroundTransferBehavior*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_TransferBehavior(
        [NativeTypeName("ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferBehavior")]
            BackgroundTransferBehavior value
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTransferGroup, BackgroundTransferBehavior, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_TransferBehavior(
            [NativeTypeName(
                "ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferBehavior *"
            )]
                BackgroundTransferBehavior* value
        );

        [VtblIndex(8)]
        HRESULT put_TransferBehavior(
            [NativeTypeName(
                "ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferBehavior"
            )]
                BackgroundTransferBehavior value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferBehavior *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BackgroundTransferBehavior*, int> get_TransferBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::BackgroundTransfer::BackgroundTransferBehavior) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BackgroundTransferBehavior, int> put_TransferBehavior;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundTransferGroup"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundTransferGroup(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundTransferGroup"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundTransferGroup(Silk.NET.WinRT.IInspectable value)
    {
        return new IBackgroundTransferGroup(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTransferGroup"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTransferGroup"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBackgroundTransferGroup value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundTransferGroup"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundTransferGroup(Silk.NET.Windows.IUnknown value)
    {
        return new IBackgroundTransferGroup(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTransferGroup"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTransferGroup"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBackgroundTransferGroup value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
