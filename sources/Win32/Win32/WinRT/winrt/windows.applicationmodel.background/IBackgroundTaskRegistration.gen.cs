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

[Guid("10654CC2-A26E-43BF-8C12-1FB40DBFBFA0")]
[NativeTypeName("struct IBackgroundTaskRegistration : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTaskRegistration
    : IBackgroundTaskRegistration.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTaskRegistration));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBackgroundTaskRegistration, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBackgroundTaskRegistration, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundTaskRegistration, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTaskRegistration, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBackgroundTaskRegistration, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBackgroundTaskRegistration, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TaskId(Guid* value)
    {
        return ((delegate* unmanaged<IBackgroundTaskRegistration, Guid*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IBackgroundTaskRegistration, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_Progress(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Background::IBackgroundTaskProgressEventHandler *"
        )]
            IBackgroundTaskProgressEventHandler handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundTaskRegistration,
                IBackgroundTaskProgressEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_Progress(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<IBackgroundTaskRegistration, EventRegistrationToken, int>)(
                (*lpVtbl)[9]
            )
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_Completed(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Background::IBackgroundTaskCompletedEventHandler *"
        )]
            IBackgroundTaskCompletedEventHandler handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundTaskRegistration,
                IBackgroundTaskCompletedEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_Completed(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<IBackgroundTaskRegistration, EventRegistrationToken, int>)(
                (*lpVtbl)[11]
            )
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Unregister([NativeTypeName("boolean")] byte cancelTask)
    {
        return ((delegate* unmanaged<IBackgroundTaskRegistration, byte, int>)((*lpVtbl)[12]))(
            this,
            cancelTask
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TaskId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(8)]
        HRESULT add_Progress(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Background::IBackgroundTaskProgressEventHandler *"
            )]
                IBackgroundTaskProgressEventHandler handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(9)]
        HRESULT remove_Progress(EventRegistrationToken cookie);

        [VtblIndex(10)]
        HRESULT add_Completed(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Background::IBackgroundTaskCompletedEventHandler *"
            )]
                IBackgroundTaskCompletedEventHandler handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(11)]
        HRESULT remove_Completed(EventRegistrationToken cookie);

        [VtblIndex(12)]
        HRESULT Unregister([NativeTypeName("boolean")] byte cancelTask);
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
        public delegate* unmanaged<TSelf*, Guid*, int> get_TaskId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskProgressEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBackgroundTaskProgressEventHandler,
            EventRegistrationToken*,
            int> add_Progress;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Progress;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Background::IBackgroundTaskCompletedEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBackgroundTaskCompletedEventHandler,
            EventRegistrationToken*,
            int> add_Completed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Completed;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> Unregister;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundTaskRegistration"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundTaskRegistration(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundTaskRegistration"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundTaskRegistration(Silk.NET.WinRT.IInspectable value)
    {
        return new IBackgroundTaskRegistration(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTaskRegistration"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTaskRegistration"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBackgroundTaskRegistration value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundTaskRegistration"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundTaskRegistration(Silk.NET.Windows.IUnknown value)
    {
        return new IBackgroundTaskRegistration(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTaskRegistration"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTaskRegistration"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBackgroundTaskRegistration value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
