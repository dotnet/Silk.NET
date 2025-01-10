// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.wallet.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("40E1E940-2606-4519-81CB-BFF1C60D1F79")]
[NativeTypeName("struct IWalletTransaction : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
)]
public unsafe partial struct IWalletTransaction : IWalletTransaction.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWalletTransaction));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWalletTransaction, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWalletTransaction, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWalletTransaction, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWalletTransaction, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWalletTransaction, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWalletTransaction, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_Description(HSTRING* value)
    {
        return ((delegate* unmanaged<IWalletTransaction, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_Description(HSTRING value)
    {
        return ((delegate* unmanaged<IWalletTransaction, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_DisplayAmount(HSTRING* value)
    {
        return ((delegate* unmanaged<IWalletTransaction, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_DisplayAmount(HSTRING value)
    {
        return ((delegate* unmanaged<IWalletTransaction, HSTRING, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete(
        "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_IgnoreTimeOfDay([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IWalletTransaction, byte*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete(
        "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_IgnoreTimeOfDay([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IWalletTransaction, byte, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete(
        "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_DisplayLocation(HSTRING* value)
    {
        return ((delegate* unmanaged<IWalletTransaction, HSTRING*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete(
        "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_DisplayLocation(HSTRING value)
    {
        return ((delegate* unmanaged<IWalletTransaction, HSTRING, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete(
        "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_TransactionDate(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return (
            (delegate* unmanaged<IWalletTransaction, IReference<DateTime>**, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete(
        "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_TransactionDate(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
        )]
            IReference<DateTime>* value
    )
    {
        return (
            (delegate* unmanaged<IWalletTransaction, IReference<DateTime>*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete(
        "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT get_IsLaunchable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IWalletTransaction, byte*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete(
        "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT put_IsLaunchable([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IWalletTransaction, byte, int>)((*lpVtbl)[17]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_Description(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_Description(HSTRING value);

        [VtblIndex(8)]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_DisplayAmount(HSTRING* value);

        [VtblIndex(9)]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_DisplayAmount(HSTRING value);

        [VtblIndex(10)]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_IgnoreTimeOfDay([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_IgnoreTimeOfDay([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_DisplayLocation(HSTRING* value);

        [VtblIndex(13)]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_DisplayLocation(HSTRING value);

        [VtblIndex(14)]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_TransactionDate(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(15)]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_TransactionDate(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *"
            )]
                IReference<DateTime>* value
        );

        [VtblIndex(16)]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT get_IsLaunchable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        HRESULT put_IsLaunchable([NativeTypeName("boolean")] byte value);
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
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Description;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Description;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayAmount;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DisplayAmount;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_IgnoreTimeOfDay;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte, int> put_IgnoreTimeOfDay;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayLocation;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DisplayLocation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_TransactionDate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>*, int> put_TransactionDate;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsLaunchable;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete(
            "IWalletTransaction is deprecated and might not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte, int> put_IsLaunchable;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWalletTransaction"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWalletTransaction(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWalletTransaction"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWalletTransaction(Silk.NET.WinRT.IInspectable value)
    {
        return new IWalletTransaction(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletTransaction"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletTransaction"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWalletTransaction value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWalletTransaction"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWalletTransaction(Silk.NET.Windows.IUnknown value)
    {
        return new IWalletTransaction(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWalletTransaction"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWalletTransaction"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWalletTransaction value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
