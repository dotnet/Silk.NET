// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("19E8E0EF-236C-40F9-B38F-9B7DD65D1CCC")]
[NativeTypeName("struct IAppCaptureAlternateShortcutKeys : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureAlternateShortcutKeys
    : IAppCaptureAlternateShortcutKeys.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureAlternateShortcutKeys));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppCaptureAlternateShortcutKeys, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppCaptureAlternateShortcutKeys, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_ToggleGameBarKey(
        [NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKey, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ToggleGameBarKey(
        [NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKey*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ToggleGameBarKeyModifiers(
        [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKeyModifiers, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ToggleGameBarKeyModifiers(
        [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKeyModifiers*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_SaveHistoricalVideoKey(
        [NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKey, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SaveHistoricalVideoKey(
        [NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKey*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_SaveHistoricalVideoKeyModifiers(
        [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKeyModifiers, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_SaveHistoricalVideoKeyModifiers(
        [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKeyModifiers*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_ToggleRecordingKey(
        [NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKey, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ToggleRecordingKey(
        [NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKey*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_ToggleRecordingKeyModifiers(
        [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKeyModifiers, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_ToggleRecordingKeyModifiers(
        [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKeyModifiers*, int>)(
                (*lpVtbl)[17]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_TakeScreenshotKey(
        [NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKey, int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_TakeScreenshotKey(
        [NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKey*, int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_TakeScreenshotKeyModifiers(
        [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKeyModifiers, int>)(
                (*lpVtbl)[20]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_TakeScreenshotKeyModifiers(
        [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKeyModifiers*, int>)(
                (*lpVtbl)[21]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_ToggleRecordingIndicatorKey(
        [NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKey, int>)((*lpVtbl)[22])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ToggleRecordingIndicatorKey(
        [NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKey*, int>)((*lpVtbl)[23])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_ToggleRecordingIndicatorKeyModifiers(
        [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKeyModifiers, int>)(
                (*lpVtbl)[24]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_ToggleRecordingIndicatorKeyModifiers(
        [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")] VirtualKeyModifiers* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureAlternateShortcutKeys, VirtualKeyModifiers*, int>)(
                (*lpVtbl)[25]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_ToggleGameBarKey(
            [NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value
        );

        [VtblIndex(7)]
        HRESULT get_ToggleGameBarKey(
            [NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value
        );

        [VtblIndex(8)]
        HRESULT put_ToggleGameBarKeyModifiers(
            [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value
        );

        [VtblIndex(9)]
        HRESULT get_ToggleGameBarKeyModifiers(
            [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")]
                VirtualKeyModifiers* value
        );

        [VtblIndex(10)]
        HRESULT put_SaveHistoricalVideoKey(
            [NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value
        );

        [VtblIndex(11)]
        HRESULT get_SaveHistoricalVideoKey(
            [NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value
        );

        [VtblIndex(12)]
        HRESULT put_SaveHistoricalVideoKeyModifiers(
            [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value
        );

        [VtblIndex(13)]
        HRESULT get_SaveHistoricalVideoKeyModifiers(
            [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")]
                VirtualKeyModifiers* value
        );

        [VtblIndex(14)]
        HRESULT put_ToggleRecordingKey(
            [NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value
        );

        [VtblIndex(15)]
        HRESULT get_ToggleRecordingKey(
            [NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value
        );

        [VtblIndex(16)]
        HRESULT put_ToggleRecordingKeyModifiers(
            [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value
        );

        [VtblIndex(17)]
        HRESULT get_ToggleRecordingKeyModifiers(
            [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")]
                VirtualKeyModifiers* value
        );

        [VtblIndex(18)]
        HRESULT put_TakeScreenshotKey(
            [NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value
        );

        [VtblIndex(19)]
        HRESULT get_TakeScreenshotKey(
            [NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value
        );

        [VtblIndex(20)]
        HRESULT put_TakeScreenshotKeyModifiers(
            [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value
        );

        [VtblIndex(21)]
        HRESULT get_TakeScreenshotKeyModifiers(
            [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")]
                VirtualKeyModifiers* value
        );

        [VtblIndex(22)]
        HRESULT put_ToggleRecordingIndicatorKey(
            [NativeTypeName("ABI::Windows::System::VirtualKey")] VirtualKey value
        );

        [VtblIndex(23)]
        HRESULT get_ToggleRecordingIndicatorKey(
            [NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value
        );

        [VtblIndex(24)]
        HRESULT put_ToggleRecordingIndicatorKeyModifiers(
            [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers")] VirtualKeyModifiers value
        );

        [VtblIndex(25)]
        HRESULT get_ToggleRecordingIndicatorKeyModifiers(
            [NativeTypeName("ABI::Windows::System::VirtualKeyModifiers *")]
                VirtualKeyModifiers* value
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

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VirtualKey, int> put_ToggleGameBarKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VirtualKey*, int> get_ToggleGameBarKey;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VirtualKeyModifiers, int> put_ToggleGameBarKeyModifiers;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VirtualKeyModifiers*, int> get_ToggleGameBarKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VirtualKey, int> put_SaveHistoricalVideoKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VirtualKey*, int> get_SaveHistoricalVideoKey;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VirtualKeyModifiers,
            int> put_SaveHistoricalVideoKeyModifiers;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VirtualKeyModifiers*,
            int> get_SaveHistoricalVideoKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VirtualKey, int> put_ToggleRecordingKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VirtualKey*, int> get_ToggleRecordingKey;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VirtualKeyModifiers,
            int> put_ToggleRecordingKeyModifiers;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VirtualKeyModifiers*,
            int> get_ToggleRecordingKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VirtualKey, int> put_TakeScreenshotKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VirtualKey*, int> get_TakeScreenshotKey;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VirtualKeyModifiers, int> put_TakeScreenshotKeyModifiers;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VirtualKeyModifiers*,
            int> get_TakeScreenshotKeyModifiers;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VirtualKey, int> put_ToggleRecordingIndicatorKey;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VirtualKey*, int> get_ToggleRecordingIndicatorKey;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::VirtualKeyModifiers) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VirtualKeyModifiers,
            int> put_ToggleRecordingIndicatorKeyModifiers;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::VirtualKeyModifiers *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VirtualKeyModifiers*,
            int> get_ToggleRecordingIndicatorKeyModifiers;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppCaptureAlternateShortcutKeys"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppCaptureAlternateShortcutKeys(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppCaptureAlternateShortcutKeys"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppCaptureAlternateShortcutKeys(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAppCaptureAlternateShortcutKeys(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppCaptureAlternateShortcutKeys"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppCaptureAlternateShortcutKeys"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAppCaptureAlternateShortcutKeys value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppCaptureAlternateShortcutKeys"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppCaptureAlternateShortcutKeys(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppCaptureAlternateShortcutKeys(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppCaptureAlternateShortcutKeys"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppCaptureAlternateShortcutKeys"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppCaptureAlternateShortcutKeys value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
