// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IExplorerCommandState.xml' path='doc/member[@name="IExplorerCommandState"]/*'/>
[Guid("BDDACB60-7657-47AE-8445-D23E1ACF82AE")]
[NativeTypeName("struct IExplorerCommandState : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExplorerCommandState : IExplorerCommandState.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExplorerCommandState));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExplorerCommandState*, Guid*, void**, int> )(lpVtbl[0]))((IExplorerCommandState*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IExplorerCommandState*, uint> )(lpVtbl[1]))((IExplorerCommandState*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExplorerCommandState*, uint> )(lpVtbl[2]))((IExplorerCommandState*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IExplorerCommandState.xml' path='doc/member[@name="IExplorerCommandState.GetState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetState(IShellItemArray* psiItemArray, BOOL fOkToBeSlow, [NativeTypeName("EXPCMDSTATE *")] uint* pCmdState)
    {
        return ((delegate* unmanaged<IExplorerCommandState*, IShellItemArray*, BOOL, uint*, int> )(lpVtbl[3]))((IExplorerCommandState*)Unsafe.AsPointer(ref this), psiItemArray, fOkToBeSlow, pCmdState);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetState(IShellItemArray* psiItemArray, BOOL fOkToBeSlow, [NativeTypeName("EXPCMDSTATE *")] uint* pCmdState);
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
        [NativeTypeName("HRESULT (IShellItemArray *, BOOL, EXPCMDSTATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItemArray*, BOOL, uint*, int> GetState;
    }
}