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

[Guid("226C537B-1E76-4D9E-A760-33DB29922F18")]
[NativeTypeName("struct IFrameworkInputPaneHandler : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IFrameworkInputPaneHandler
    : IFrameworkInputPaneHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameworkInputPaneHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IFrameworkInputPaneHandler, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFrameworkInputPaneHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFrameworkInputPaneHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Showing(RECT* prcInputPaneScreenLocation, BOOL fEnsureFocusedElementInView)
    {
        return ((delegate* unmanaged<IFrameworkInputPaneHandler, RECT*, BOOL, int>)((*lpVtbl)[3]))(
            this,
            prcInputPaneScreenLocation,
            fEnsureFocusedElementInView
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Hiding(BOOL fEnsureFocusedElementInView)
    {
        return ((delegate* unmanaged<IFrameworkInputPaneHandler, BOOL, int>)((*lpVtbl)[4]))(
            this,
            fEnsureFocusedElementInView
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Showing(RECT* prcInputPaneScreenLocation, BOOL fEnsureFocusedElementInView);

        [VtblIndex(4)]
        HRESULT Hiding(BOOL fEnsureFocusedElementInView);
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

        [NativeTypeName("HRESULT (RECT *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, BOOL, int> Showing;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Hiding;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFrameworkInputPaneHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFrameworkInputPaneHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFrameworkInputPaneHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFrameworkInputPaneHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IFrameworkInputPaneHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFrameworkInputPaneHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFrameworkInputPaneHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFrameworkInputPaneHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
