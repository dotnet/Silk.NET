// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAMPushSource.xml' path='doc/member[@name="IAMPushSource"]/*'/>
[Guid("F185FE76-E64E-11D2-B76E-00C04FB6BD3D")]
[NativeTypeName("struct IAMPushSource : IAMLatency")]
[NativeInheritance("IAMLatency")]
public unsafe partial struct IAMPushSource : IAMPushSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMPushSource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMPushSource*, Guid*, void**, int> )(lpVtbl[0]))((IAMPushSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMPushSource*, uint> )(lpVtbl[1]))((IAMPushSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMPushSource*, uint> )(lpVtbl[2]))((IAMPushSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IAMLatency.GetLatency"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetLatency([NativeTypeName("REFERENCE_TIME *")] long* prtLatency)
    {
        return ((delegate* unmanaged<IAMPushSource*, long*, int> )(lpVtbl[3]))((IAMPushSource*)Unsafe.AsPointer(ref this), prtLatency);
    }

    /// <include file='IAMPushSource.xml' path='doc/member[@name="IAMPushSource.GetPushSourceFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPushSourceFlags([NativeTypeName("ULONG *")] uint* pFlags)
    {
        return ((delegate* unmanaged<IAMPushSource*, uint*, int> )(lpVtbl[4]))((IAMPushSource*)Unsafe.AsPointer(ref this), pFlags);
    }

    /// <include file='IAMPushSource.xml' path='doc/member[@name="IAMPushSource.SetPushSourceFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPushSourceFlags([NativeTypeName("ULONG")] uint Flags)
    {
        return ((delegate* unmanaged<IAMPushSource*, uint, int> )(lpVtbl[5]))((IAMPushSource*)Unsafe.AsPointer(ref this), Flags);
    }

    /// <include file='IAMPushSource.xml' path='doc/member[@name="IAMPushSource.SetStreamOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetStreamOffset([NativeTypeName("REFERENCE_TIME")] long rtOffset)
    {
        return ((delegate* unmanaged<IAMPushSource*, long, int> )(lpVtbl[6]))((IAMPushSource*)Unsafe.AsPointer(ref this), rtOffset);
    }

    /// <include file='IAMPushSource.xml' path='doc/member[@name="IAMPushSource.GetStreamOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetStreamOffset([NativeTypeName("REFERENCE_TIME *")] long* prtOffset)
    {
        return ((delegate* unmanaged<IAMPushSource*, long*, int> )(lpVtbl[7]))((IAMPushSource*)Unsafe.AsPointer(ref this), prtOffset);
    }

    /// <include file='IAMPushSource.xml' path='doc/member[@name="IAMPushSource.GetMaxStreamOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMaxStreamOffset([NativeTypeName("REFERENCE_TIME *")] long* prtMaxOffset)
    {
        return ((delegate* unmanaged<IAMPushSource*, long*, int> )(lpVtbl[8]))((IAMPushSource*)Unsafe.AsPointer(ref this), prtMaxOffset);
    }

    /// <include file='IAMPushSource.xml' path='doc/member[@name="IAMPushSource.SetMaxStreamOffset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetMaxStreamOffset([NativeTypeName("REFERENCE_TIME")] long rtMaxOffset)
    {
        return ((delegate* unmanaged<IAMPushSource*, long, int> )(lpVtbl[9]))((IAMPushSource*)Unsafe.AsPointer(ref this), rtMaxOffset);
    }

    public interface Interface : IAMLatency.Interface
    {
        [VtblIndex(4)]
        HRESULT GetPushSourceFlags([NativeTypeName("ULONG *")] uint* pFlags);
        [VtblIndex(5)]
        HRESULT SetPushSourceFlags([NativeTypeName("ULONG")] uint Flags);
        [VtblIndex(6)]
        HRESULT SetStreamOffset([NativeTypeName("REFERENCE_TIME")] long rtOffset);
        [VtblIndex(7)]
        HRESULT GetStreamOffset([NativeTypeName("REFERENCE_TIME *")] long* prtOffset);
        [VtblIndex(8)]
        HRESULT GetMaxStreamOffset([NativeTypeName("REFERENCE_TIME *")] long* prtMaxOffset);
        [VtblIndex(9)]
        HRESULT SetMaxStreamOffset([NativeTypeName("REFERENCE_TIME")] long rtMaxOffset);
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
        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetLatency;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetPushSourceFlags;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetPushSourceFlags;
        [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> SetStreamOffset;
        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetStreamOffset;
        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetMaxStreamOffset;
        [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> SetMaxStreamOffset;
    }
}