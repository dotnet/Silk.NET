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

[Guid("5C6C279C-D7CA-4779-9188-4057219CE64C")]
[NativeTypeName("struct IMemoryManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMemoryManagerStatics : IMemoryManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMemoryManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMemoryManagerStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMemoryManagerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMemoryManagerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMemoryManagerStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMemoryManagerStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMemoryManagerStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AppMemoryUsage([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IMemoryManagerStatics, ulong*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppMemoryUsageLimit([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IMemoryManagerStatics, ulong*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AppMemoryUsageLevel(
        [NativeTypeName("ABI::Windows::System::AppMemoryUsageLevel *")] AppMemoryUsageLevel* value
    )
    {
        return (
            (delegate* unmanaged<IMemoryManagerStatics, AppMemoryUsageLevel*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_AppMemoryUsageIncreased(
        [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMemoryManagerStatics,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_AppMemoryUsageIncreased(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMemoryManagerStatics, EventRegistrationToken, int>)((*lpVtbl)[10])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_AppMemoryUsageDecreased(
        [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMemoryManagerStatics,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_AppMemoryUsageDecreased(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMemoryManagerStatics, EventRegistrationToken, int>)((*lpVtbl)[12])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_AppMemoryUsageLimitChanging(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSystem__CAppMemoryUsageLimitChangingEventArgs_t *"
        )]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMemoryManagerStatics,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[13])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_AppMemoryUsageLimitChanging(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMemoryManagerStatics, EventRegistrationToken, int>)((*lpVtbl)[14])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AppMemoryUsage([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT get_AppMemoryUsageLimit([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(8)]
        HRESULT get_AppMemoryUsageLevel(
            [NativeTypeName("ABI::Windows::System::AppMemoryUsageLevel *")]
                AppMemoryUsageLevel* value
        );

        [VtblIndex(9)]
        HRESULT add_AppMemoryUsageIncreased(
            [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(10)]
        HRESULT remove_AppMemoryUsageIncreased(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT add_AppMemoryUsageDecreased(
            [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(12)]
        HRESULT remove_AppMemoryUsageDecreased(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT add_AppMemoryUsageLimitChanging(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSystem__CAppMemoryUsageLimitChangingEventArgs_t *"
            )]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(14)]
        HRESULT remove_AppMemoryUsageLimitChanging(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_AppMemoryUsage;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_AppMemoryUsageLimit;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::AppMemoryUsageLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppMemoryUsageLevel*, int> get_AppMemoryUsageLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_AppMemoryUsageIncreased;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_AppMemoryUsageIncreased;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_AppMemoryUsageDecreased;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_AppMemoryUsageDecreased;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSystem__CAppMemoryUsageLimitChangingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_AppMemoryUsageLimitChanging;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_AppMemoryUsageLimitChanging;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMemoryManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMemoryManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMemoryManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMemoryManagerStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IMemoryManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMemoryManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMemoryManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMemoryManagerStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMemoryManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMemoryManagerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IMemoryManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMemoryManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMemoryManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMemoryManagerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
