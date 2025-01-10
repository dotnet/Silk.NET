// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("99EACBA7-E073-43B6-A896-55AFE48A0833")]
[NativeTypeName("struct IContactManagerInterop : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IContactManagerInterop : IContactManagerInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContactManagerInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContactManagerInterop, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContactManagerInterop, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContactManagerInterop, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShowContactCardForWindow(
        HWND appWindow,
        IUnknown contact,
        [NativeTypeName("const RECT *")] RECT* selection,
        FLYOUT_PLACEMENT preferredPlacement
    )
    {
        return (
            (delegate* unmanaged<
                IContactManagerInterop,
                HWND,
                IUnknown,
                RECT*,
                FLYOUT_PLACEMENT,
                int>)((*lpVtbl)[3])
        )(this, appWindow, contact, selection, preferredPlacement);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShowContactCardForWindow(
            HWND appWindow,
            IUnknown contact,
            [NativeTypeName("const RECT *")] RECT* selection,
            FLYOUT_PLACEMENT preferredPlacement
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

        [NativeTypeName(
            "HRESULT (HWND, IUnknown *, const RECT *, FLYOUT_PLACEMENT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            IUnknown,
            RECT*,
            FLYOUT_PLACEMENT,
            int> ShowContactCardForWindow;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContactManagerInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContactManagerInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContactManagerInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContactManagerInterop(Silk.NET.Windows.IUnknown value)
    {
        return new IContactManagerInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContactManagerInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContactManagerInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContactManagerInterop value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
