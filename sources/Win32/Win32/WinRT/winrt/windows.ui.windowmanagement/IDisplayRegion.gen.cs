// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("DB50C3A2-4094-5F47-8CB1-EA01DDAFAA94")]
[NativeTypeName("struct IDisplayRegion : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDisplayRegion : IDisplayRegion.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDisplayRegion));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDisplayRegion, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDisplayRegion, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDisplayRegion, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDisplayRegion, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDisplayRegion, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDisplayRegion, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DisplayMonitorDeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged<IDisplayRegion, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IDisplayRegion, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_WorkAreaOffset(
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value
    )
    {
        return ((delegate* unmanaged<IDisplayRegion, Point*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_WorkAreaSize(
        [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value
    )
    {
        return ((delegate* unmanaged<IDisplayRegion, Size*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_WindowingEnvironment(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::IWindowingEnvironment **")]
            IWindowingEnvironment* value
    )
    {
        return ((delegate* unmanaged<IDisplayRegion, IWindowingEnvironment*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Changed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CDisplayRegion_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDisplayRegion,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Changed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IDisplayRegion, EventRegistrationToken, int>)((*lpVtbl)[12]))(
            this,
            token
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DisplayMonitorDeviceId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_WorkAreaOffset(
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value
        );

        [VtblIndex(9)]
        HRESULT get_WorkAreaSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(10)]
        HRESULT get_WindowingEnvironment(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::IWindowingEnvironment **")]
                IWindowingEnvironment* value
        );

        [VtblIndex(11)]
        HRESULT add_Changed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CDisplayRegion_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(12)]
        HRESULT remove_Changed(EventRegistrationToken token);
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayMonitorDeviceId;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsVisible;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Point*, int> get_WorkAreaOffset;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size*, int> get_WorkAreaSize;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::IWindowingEnvironment **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWindowingEnvironment*, int> get_WindowingEnvironment;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CDisplayRegion_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Changed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Changed;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDisplayRegion"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDisplayRegion(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDisplayRegion"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDisplayRegion(Silk.NET.WinRT.IInspectable value)
    {
        return new IDisplayRegion(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDisplayRegion"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDisplayRegion"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDisplayRegion value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDisplayRegion"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDisplayRegion(Silk.NET.Windows.IUnknown value)
    {
        return new IDisplayRegion(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDisplayRegion"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDisplayRegion"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDisplayRegion value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
