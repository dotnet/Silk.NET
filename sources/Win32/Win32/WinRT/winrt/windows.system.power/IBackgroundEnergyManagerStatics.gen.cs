// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.power.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B3161D95-1180-4376-96E1-4095568147CE")]
[NativeTypeName("struct IBackgroundEnergyManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
public unsafe partial struct IBackgroundEnergyManagerStatics
    : IBackgroundEnergyManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundEnergyManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBackgroundEnergyManagerStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBackgroundEnergyManagerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundEnergyManagerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBackgroundEnergyManagerStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IBackgroundEnergyManagerStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBackgroundEnergyManagerStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_LowUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBackgroundEnergyManagerStatics, uint*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_NearMaxAcceptableUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBackgroundEnergyManagerStatics, uint*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_MaxAcceptableUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBackgroundEnergyManagerStatics, uint*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_ExcessiveUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBackgroundEnergyManagerStatics, uint*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_NearTerminationUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBackgroundEnergyManagerStatics, uint*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_TerminationUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBackgroundEnergyManagerStatics, uint*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_RecentEnergyUsage([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBackgroundEnergyManagerStatics, uint*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_RecentEnergyUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBackgroundEnergyManagerStatics, uint*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT add_RecentEnergyUsageIncreased(
        [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundEnergyManagerStatics,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[14])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT remove_RecentEnergyUsageIncreased(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IBackgroundEnergyManagerStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[15]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT add_RecentEnergyUsageReturnedToLow(
        [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundEnergyManagerStatics,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[16])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT remove_RecentEnergyUsageReturnedToLow(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IBackgroundEnergyManagerStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[17]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_LowUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_NearMaxAcceptableUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_MaxAcceptableUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_ExcessiveUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_NearTerminationUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_TerminationUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_RecentEnergyUsage([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_RecentEnergyUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT add_RecentEnergyUsageIncreased(
            [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(15)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT remove_RecentEnergyUsageIncreased(EventRegistrationToken token);

        [VtblIndex(16)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT add_RecentEnergyUsageReturnedToLow(
            [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(17)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT remove_RecentEnergyUsageReturnedToLow(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, uint*, int> get_LowUsageLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, uint*, int> get_NearMaxAcceptableUsageLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, uint*, int> get_MaxAcceptableUsageLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ExcessiveUsageLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, uint*, int> get_NearTerminationUsageLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, uint*, int> get_TerminationUsageLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, uint*, int> get_RecentEnergyUsage;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged<TSelf*, uint*, int> get_RecentEnergyUsageLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_RecentEnergyUsageIncreased;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_RecentEnergyUsageIncreased;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_RecentEnergyUsageReturnedToLow;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_RecentEnergyUsageReturnedToLow;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundEnergyManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundEnergyManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundEnergyManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundEnergyManagerStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBackgroundEnergyManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundEnergyManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundEnergyManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBackgroundEnergyManagerStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundEnergyManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundEnergyManagerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IBackgroundEnergyManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundEnergyManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundEnergyManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBackgroundEnergyManagerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
