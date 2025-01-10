// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("998681FB-1AB6-4B7F-BE4A-9A0645224C04")]
[NativeTypeName("struct ICoreApplication2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreApplication2 : ICoreApplication2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreApplication2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoreApplication2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICoreApplication2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreApplication2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICoreApplication2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICoreApplication2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICoreApplication2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_BackgroundActivated(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CActivation__CBackgroundActivatedEventArgs_t *"
        )]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICoreApplication2,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_BackgroundActivated(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ICoreApplication2, EventRegistrationToken, int>)((*lpVtbl)[7])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_LeavingBackground(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CLeavingBackgroundEventArgs_t *"
        )]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICoreApplication2,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_LeavingBackground(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ICoreApplication2, EventRegistrationToken, int>)((*lpVtbl)[9])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_EnteredBackground(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CEnteredBackgroundEventArgs_t *"
        )]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICoreApplication2,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_EnteredBackground(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ICoreApplication2, EventRegistrationToken, int>)((*lpVtbl)[11])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EnablePrelaunch([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICoreApplication2, byte, int>)((*lpVtbl)[12]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_BackgroundActivated(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CActivation__CBackgroundActivatedEventArgs_t *"
            )]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_BackgroundActivated(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_LeavingBackground(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CLeavingBackgroundEventArgs_t *"
            )]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(9)]
        HRESULT remove_LeavingBackground(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT add_EnteredBackground(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CEnteredBackgroundEventArgs_t *"
            )]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_EnteredBackground(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT EnablePrelaunch([NativeTypeName("boolean")] byte value);
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
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CActivation__CBackgroundActivatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_BackgroundActivated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_BackgroundActivated;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CLeavingBackgroundEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_LeavingBackground;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_LeavingBackground;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CEnteredBackgroundEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_EnteredBackground;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_EnteredBackground;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> EnablePrelaunch;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreApplication2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreApplication2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreApplication2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreApplication2(Silk.NET.WinRT.IInspectable value)
    {
        return new ICoreApplication2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreApplication2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreApplication2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICoreApplication2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreApplication2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreApplication2(Silk.NET.Windows.IUnknown value)
    {
        return new ICoreApplication2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreApplication2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreApplication2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICoreApplication2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
