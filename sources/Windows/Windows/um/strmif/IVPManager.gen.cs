// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IVPManager.xml' path='doc/member[@name="IVPManager"]/*'/>
[Guid("AAC18C18-E186-46D2-825D-A1F8DC8E395A")]
[NativeTypeName("struct IVPManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVPManager : IVPManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVPManager));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVPManager*, Guid*, void**, int> )(lpVtbl[0]))((IVPManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVPManager*, uint> )(lpVtbl[1]))((IVPManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVPManager*, uint> )(lpVtbl[2]))((IVPManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVPManager.xml' path='doc/member[@name="IVPManager.SetVideoPortIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetVideoPortIndex([NativeTypeName("DWORD")] uint dwVideoPortIndex)
    {
        return ((delegate* unmanaged<IVPManager*, uint, int> )(lpVtbl[3]))((IVPManager*)Unsafe.AsPointer(ref this), dwVideoPortIndex);
    }

    /// <include file='IVPManager.xml' path='doc/member[@name="IVPManager.GetVideoPortIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetVideoPortIndex([NativeTypeName("DWORD *")] uint* pdwVideoPortIndex)
    {
        return ((delegate* unmanaged<IVPManager*, uint*, int> )(lpVtbl[4]))((IVPManager*)Unsafe.AsPointer(ref this), pdwVideoPortIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetVideoPortIndex([NativeTypeName("DWORD")] uint dwVideoPortIndex);
        [VtblIndex(4)]
        HRESULT GetVideoPortIndex([NativeTypeName("DWORD *")] uint* pdwVideoPortIndex);
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
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetVideoPortIndex;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetVideoPortIndex;
    }
}