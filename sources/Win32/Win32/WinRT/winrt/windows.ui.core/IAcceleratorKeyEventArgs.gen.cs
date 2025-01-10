// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FF1C4C4A-9287-470B-836E-9086E3126ADE")]
[NativeTypeName("struct IAcceleratorKeyEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAcceleratorKeyEventArgs
    : IAcceleratorKeyEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAcceleratorKeyEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAcceleratorKeyEventArgs, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAcceleratorKeyEventArgs, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAcceleratorKeyEventArgs, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAcceleratorKeyEventArgs, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAcceleratorKeyEventArgs, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAcceleratorKeyEventArgs, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_EventType(
        [NativeTypeName("ABI::Windows::UI::Core::CoreAcceleratorKeyEventType *")]
            CoreAcceleratorKeyEventType* value
    )
    {
        return (
            (delegate* unmanaged<IAcceleratorKeyEventArgs, CoreAcceleratorKeyEventType*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VirtualKey(
        [NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value
    )
    {
        return ((delegate* unmanaged<IAcceleratorKeyEventArgs, VirtualKey*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KeyStatus(
        [NativeTypeName("ABI::Windows::UI::Core::CorePhysicalKeyStatus *")]
            CorePhysicalKeyStatus* value
    )
    {
        return (
            (delegate* unmanaged<IAcceleratorKeyEventArgs, CorePhysicalKeyStatus*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_EventType(
            [NativeTypeName("ABI::Windows::UI::Core::CoreAcceleratorKeyEventType *")]
                CoreAcceleratorKeyEventType* value
        );

        [VtblIndex(7)]
        HRESULT get_VirtualKey(
            [NativeTypeName("ABI::Windows::System::VirtualKey *")] VirtualKey* value
        );

        [VtblIndex(8)]
        HRESULT get_KeyStatus(
            [NativeTypeName("ABI::Windows::UI::Core::CorePhysicalKeyStatus *")]
                CorePhysicalKeyStatus* value
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Core::CoreAcceleratorKeyEventType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreAcceleratorKeyEventType*, int> get_EventType;

        [NativeTypeName("HRESULT (ABI::Windows::System::VirtualKey *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VirtualKey*, int> get_VirtualKey;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Core::CorePhysicalKeyStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CorePhysicalKeyStatus*, int> get_KeyStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAcceleratorKeyEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAcceleratorKeyEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAcceleratorKeyEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAcceleratorKeyEventArgs(Silk.NET.WinRT.IInspectable value)
    {
        return new IAcceleratorKeyEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAcceleratorKeyEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAcceleratorKeyEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAcceleratorKeyEventArgs value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAcceleratorKeyEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAcceleratorKeyEventArgs(Silk.NET.Windows.IUnknown value)
    {
        return new IAcceleratorKeyEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAcceleratorKeyEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAcceleratorKeyEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAcceleratorKeyEventArgs value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
