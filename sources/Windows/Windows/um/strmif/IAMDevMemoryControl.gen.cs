// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAMDevMemoryControl.xml' path='doc/member[@name="IAMDevMemoryControl"]/*'/>
[Guid("C6545BF1-E76B-11D0-BD52-00A0C911CE86")]
[NativeTypeName("struct IAMDevMemoryControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMDevMemoryControl : IAMDevMemoryControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMDevMemoryControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMDevMemoryControl*, Guid*, void**, int> )(lpVtbl[0]))((IAMDevMemoryControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMDevMemoryControl*, uint> )(lpVtbl[1]))((IAMDevMemoryControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMDevMemoryControl*, uint> )(lpVtbl[2]))((IAMDevMemoryControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMDevMemoryControl.xml' path='doc/member[@name="IAMDevMemoryControl.QueryWriteSync"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryWriteSync()
    {
        return ((delegate* unmanaged<IAMDevMemoryControl*, int> )(lpVtbl[3]))((IAMDevMemoryControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMDevMemoryControl.xml' path='doc/member[@name="IAMDevMemoryControl.WriteSync"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WriteSync()
    {
        return ((delegate* unmanaged<IAMDevMemoryControl*, int> )(lpVtbl[4]))((IAMDevMemoryControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMDevMemoryControl.xml' path='doc/member[@name="IAMDevMemoryControl.GetDevId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDevId([NativeTypeName("DWORD *")] uint* pdwDevId)
    {
        return ((delegate* unmanaged<IAMDevMemoryControl*, uint*, int> )(lpVtbl[5]))((IAMDevMemoryControl*)Unsafe.AsPointer(ref this), pdwDevId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryWriteSync();
        [VtblIndex(4)]
        HRESULT WriteSync();
        [VtblIndex(5)]
        HRESULT GetDevId([NativeTypeName("DWORD *")] uint* pdwDevId);
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> QueryWriteSync;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> WriteSync;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDevId;
    }
}