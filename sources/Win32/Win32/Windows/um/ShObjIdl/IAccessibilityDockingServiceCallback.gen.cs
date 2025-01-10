// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("157733FD-A592-42E5-B594-248468C5A81B")]
[NativeTypeName("struct IAccessibilityDockingServiceCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAccessibilityDockingServiceCallback
    : IAccessibilityDockingServiceCallback.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccessibilityDockingServiceCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAccessibilityDockingServiceCallback, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAccessibilityDockingServiceCallback, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAccessibilityDockingServiceCallback, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Undocked(UNDOCK_REASON undockReason)
    {
        return (
            (delegate* unmanaged<IAccessibilityDockingServiceCallback, UNDOCK_REASON, int>)(
                (*lpVtbl)[3]
            )
        )(this, undockReason);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Undocked(UNDOCK_REASON undockReason);
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

        [NativeTypeName("HRESULT (UNDOCK_REASON) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, UNDOCK_REASON, int> Undocked;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAccessibilityDockingServiceCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAccessibilityDockingServiceCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAccessibilityDockingServiceCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAccessibilityDockingServiceCallback(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAccessibilityDockingServiceCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAccessibilityDockingServiceCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAccessibilityDockingServiceCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAccessibilityDockingServiceCallback value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
