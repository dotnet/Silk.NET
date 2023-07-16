// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAMClockSlave.xml' path='doc/member[@name="IAMClockSlave"]/*'/>
[Guid("9FD52741-176D-4B36-8F51-CA8F933223BE")]
[NativeTypeName("struct IAMClockSlave : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMClockSlave : IAMClockSlave.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMClockSlave));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMClockSlave*, Guid*, void**, int> )(lpVtbl[0]))((IAMClockSlave*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMClockSlave*, uint> )(lpVtbl[1]))((IAMClockSlave*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMClockSlave*, uint> )(lpVtbl[2]))((IAMClockSlave*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMClockSlave.xml' path='doc/member[@name="IAMClockSlave.SetErrorTolerance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetErrorTolerance([NativeTypeName("DWORD")] uint dwTolerance)
    {
        return ((delegate* unmanaged<IAMClockSlave*, uint, int> )(lpVtbl[3]))((IAMClockSlave*)Unsafe.AsPointer(ref this), dwTolerance);
    }

    /// <include file='IAMClockSlave.xml' path='doc/member[@name="IAMClockSlave.GetErrorTolerance"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetErrorTolerance([NativeTypeName("DWORD *")] uint* pdwTolerance)
    {
        return ((delegate* unmanaged<IAMClockSlave*, uint*, int> )(lpVtbl[4]))((IAMClockSlave*)Unsafe.AsPointer(ref this), pdwTolerance);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetErrorTolerance([NativeTypeName("DWORD")] uint dwTolerance);
        [VtblIndex(4)]
        HRESULT GetErrorTolerance([NativeTypeName("DWORD *")] uint* pdwTolerance);
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
        public delegate* unmanaged<TSelf*, uint, int> SetErrorTolerance;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetErrorTolerance;
    }
}