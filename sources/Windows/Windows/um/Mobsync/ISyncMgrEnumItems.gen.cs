// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISyncMgrEnumItems.xml' path='doc/member[@name="ISyncMgrEnumItems"]/*'/>
[Guid("6295DF2A-35EE-11D1-8707-00C04FD93327")]
[NativeTypeName("struct ISyncMgrEnumItems : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrEnumItems : ISyncMgrEnumItems.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrEnumItems));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrEnumItems*, Guid*, void**, int> )(lpVtbl[0]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrEnumItems*, uint> )(lpVtbl[1]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrEnumItems*, uint> )(lpVtbl[2]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrEnumItems.xml' path='doc/member[@name="ISyncMgrEnumItems.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, SYNCMGRITEM* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<ISyncMgrEnumItems*, uint, SYNCMGRITEM*, uint*, int> )(lpVtbl[3]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='ISyncMgrEnumItems.xml' path='doc/member[@name="ISyncMgrEnumItems.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<ISyncMgrEnumItems*, uint, int> )(lpVtbl[4]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='ISyncMgrEnumItems.xml' path='doc/member[@name="ISyncMgrEnumItems.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<ISyncMgrEnumItems*, int> )(lpVtbl[5]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISyncMgrEnumItems.xml' path='doc/member[@name="ISyncMgrEnumItems.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(ISyncMgrEnumItems** ppenum)
    {
        return ((delegate* unmanaged<ISyncMgrEnumItems*, ISyncMgrEnumItems**, int> )(lpVtbl[6]))((ISyncMgrEnumItems*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, SYNCMGRITEM* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);
        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Clone(ISyncMgrEnumItems** ppenum);
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
        [NativeTypeName("HRESULT (ULONG, SYNCMGRITEM *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SYNCMGRITEM*, uint*, int> Next;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (ISyncMgrEnumItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISyncMgrEnumItems**, int> Clone;
    }
}