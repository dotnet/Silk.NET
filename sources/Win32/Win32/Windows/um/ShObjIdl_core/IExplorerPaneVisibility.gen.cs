// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E07010EC-BC17-44C0-97B0-46C7C95B9EDC")]
[NativeTypeName("struct IExplorerPaneVisibility : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExplorerPaneVisibility
    : IExplorerPaneVisibility.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExplorerPaneVisibility));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExplorerPaneVisibility, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IExplorerPaneVisibility, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExplorerPaneVisibility, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPaneState(
        [NativeTypeName("const EXPLORERPANE &")] Guid* ep,
        [NativeTypeName("EXPLORERPANESTATE *")] uint* peps
    )
    {
        return ((delegate* unmanaged<IExplorerPaneVisibility, Guid*, uint*, int>)((*lpVtbl)[3]))(
            this,
            ep,
            peps
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPaneState(
            [NativeTypeName("const EXPLORERPANE &")] Guid* ep,
            [NativeTypeName("EXPLORERPANESTATE *")] uint* peps
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
            "HRESULT (const EXPLORERPANE &, EXPLORERPANESTATE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetPaneState;
    }

    /// <summary>Initializes a new instance of the <see cref = "IExplorerPaneVisibility"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IExplorerPaneVisibility(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IExplorerPaneVisibility"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IExplorerPaneVisibility(Silk.NET.Windows.IUnknown value)
    {
        return new IExplorerPaneVisibility(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IExplorerPaneVisibility"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IExplorerPaneVisibility"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IExplorerPaneVisibility value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
