// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("865BDA7A-21D8-4573-8F32-928A1B0641F6")]
[NativeTypeName("struct IBackgroundTaskInstance : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTaskInstance
    : IBackgroundTaskInstance.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTaskInstance));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBackgroundTaskInstance, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBackgroundTaskInstance, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundTaskInstance, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBackgroundTaskInstance, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBackgroundTaskInstance, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBackgroundTaskInstance, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InstanceId(Guid* value)
    {
        return ((delegate* unmanaged<IBackgroundTaskInstance, Guid*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Task(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **"
        )]
            IBackgroundTaskRegistration* task
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTaskInstance, IBackgroundTaskRegistration*, int>)(
                (*lpVtbl)[7]
            )
        )(this, task);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Progress([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBackgroundTaskInstance, uint*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Progress([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IBackgroundTaskInstance, uint, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_TriggerDetails(IInspectable* triggerDetails)
    {
        return ((delegate* unmanaged<IBackgroundTaskInstance, IInspectable*, int>)((*lpVtbl)[10]))(
            this,
            triggerDetails
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Canceled(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Background::IBackgroundTaskCanceledEventHandler *"
        )]
            IBackgroundTaskCanceledEventHandler cancelHandler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundTaskInstance,
                IBackgroundTaskCanceledEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, cancelHandler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Canceled(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<IBackgroundTaskInstance, EventRegistrationToken, int>)(
                (*lpVtbl)[12]
            )
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_SuspendedCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBackgroundTaskInstance, uint*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTaskDeferral **")]
            IBackgroundTaskDeferral* deferral
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTaskInstance, IBackgroundTaskDeferral*, int>)(
                (*lpVtbl)[14]
            )
        )(this, deferral);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InstanceId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_Task(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **"
            )]
                IBackgroundTaskRegistration* task
        );

        [VtblIndex(8)]
        HRESULT get_Progress([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT put_Progress([NativeTypeName("UINT32")] uint value);

        [VtblIndex(10)]
        HRESULT get_TriggerDetails(IInspectable* triggerDetails);

        [VtblIndex(11)]
        HRESULT add_Canceled(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Background::IBackgroundTaskCanceledEventHandler *"
            )]
                IBackgroundTaskCanceledEventHandler cancelHandler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(12)]
        HRESULT remove_Canceled(EventRegistrationToken cookie);

        [VtblIndex(13)]
        HRESULT get_SuspendedCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT GetDeferral(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Background::IBackgroundTaskDeferral **"
            )]
                IBackgroundTaskDeferral* deferral
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_InstanceId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistration **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBackgroundTaskRegistration*, int> get_Task;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Progress;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_Progress;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable*, int> get_TriggerDetails;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskCanceledEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBackgroundTaskCanceledEventHandler,
            EventRegistrationToken*,
            int> add_Canceled;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Canceled;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_SuspendedCount;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBackgroundTaskDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundTaskInstance"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundTaskInstance(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundTaskInstance"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundTaskInstance(Silk.NET.WinRT.IInspectable value)
    {
        return new IBackgroundTaskInstance(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTaskInstance"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTaskInstance"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBackgroundTaskInstance value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundTaskInstance"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundTaskInstance(Silk.NET.Windows.IUnknown value)
    {
        return new IBackgroundTaskInstance(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTaskInstance"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTaskInstance"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBackgroundTaskInstance value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
