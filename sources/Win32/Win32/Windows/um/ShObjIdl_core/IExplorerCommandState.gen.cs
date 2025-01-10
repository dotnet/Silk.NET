// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BDDACB60-7657-47AE-8445-D23E1ACF82AE")]
[NativeTypeName("struct IExplorerCommandState : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExplorerCommandState : IExplorerCommandState.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExplorerCommandState));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExplorerCommandState, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IExplorerCommandState, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExplorerCommandState, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetState(
        IShellItemArray psiItemArray,
        BOOL fOkToBeSlow,
        [NativeTypeName("EXPCMDSTATE *")] uint* pCmdState
    )
    {
        return (
            (delegate* unmanaged<IExplorerCommandState, IShellItemArray, BOOL, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, psiItemArray, fOkToBeSlow, pCmdState);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetState(
            IShellItemArray psiItemArray,
            BOOL fOkToBeSlow,
            [NativeTypeName("EXPCMDSTATE *")] uint* pCmdState
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
            "HRESULT (IShellItemArray *, BOOL, EXPCMDSTATE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellItemArray, BOOL, uint*, int> GetState;
    }

    /// <summary>Initializes a new instance of the <see cref = "IExplorerCommandState"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IExplorerCommandState(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IExplorerCommandState"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IExplorerCommandState(Silk.NET.Windows.IUnknown value)
    {
        return new IExplorerCommandState(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IExplorerCommandState"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IExplorerCommandState"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IExplorerCommandState value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
