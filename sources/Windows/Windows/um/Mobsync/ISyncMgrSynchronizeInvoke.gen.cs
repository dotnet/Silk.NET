// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISyncMgrSynchronizeInvoke.xml' path='doc/member[@name="ISyncMgrSynchronizeInvoke"]/*'/>
[Guid("6295DF2C-35EE-11D1-8707-00C04FD93327")]
[NativeTypeName("struct ISyncMgrSynchronizeInvoke : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrSynchronizeInvoke : ISyncMgrSynchronizeInvoke.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrSynchronizeInvoke));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrSynchronizeInvoke*, Guid*, void**, int> )(lpVtbl[0]))((ISyncMgrSynchronizeInvoke*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrSynchronizeInvoke*, uint> )(lpVtbl[1]))((ISyncMgrSynchronizeInvoke*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrSynchronizeInvoke*, uint> )(lpVtbl[2]))((ISyncMgrSynchronizeInvoke*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrSynchronizeInvoke.xml' path='doc/member[@name="ISyncMgrSynchronizeInvoke.UpdateItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT UpdateItems([NativeTypeName("DWORD")] uint dwInvokeFlags, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("DWORD")] uint cbCookie, [NativeTypeName("const BYTE *")] byte* pCookie)
    {
        return ((delegate* unmanaged<ISyncMgrSynchronizeInvoke*, uint, Guid*, uint, byte*, int> )(lpVtbl[3]))((ISyncMgrSynchronizeInvoke*)Unsafe.AsPointer(ref this), dwInvokeFlags, clsid, cbCookie, pCookie);
    }

    /// <include file='ISyncMgrSynchronizeInvoke.xml' path='doc/member[@name="ISyncMgrSynchronizeInvoke.UpdateAll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UpdateAll()
    {
        return ((delegate* unmanaged<ISyncMgrSynchronizeInvoke*, int> )(lpVtbl[4]))((ISyncMgrSynchronizeInvoke*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT UpdateItems([NativeTypeName("DWORD")] uint dwInvokeFlags, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("DWORD")] uint cbCookie, [NativeTypeName("const BYTE *")] byte* pCookie);
        [VtblIndex(4)]
        HRESULT UpdateAll();
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
        [NativeTypeName("HRESULT (DWORD, const IID &, DWORD, const BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, uint, byte*, int> UpdateItems;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UpdateAll;
    }
}