// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFShutdown.xml' path='doc/member[@name="IMFShutdown"]/*'/>
[Guid("97EC2EA4-0E42-4937-97AC-9D6D328824E1")]
[NativeTypeName("struct IMFShutdown : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFShutdown : IMFShutdown.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFShutdown));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFShutdown*, Guid*, void**, int> )(lpVtbl[0]))((IMFShutdown*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFShutdown*, uint> )(lpVtbl[1]))((IMFShutdown*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFShutdown*, uint> )(lpVtbl[2]))((IMFShutdown*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFShutdown.xml' path='doc/member[@name="IMFShutdown.Shutdown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFShutdown*, int> )(lpVtbl[3]))((IMFShutdown*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFShutdown.xml' path='doc/member[@name="IMFShutdown.GetShutdownStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetShutdownStatus(MFSHUTDOWN_STATUS* pStatus)
    {
        return ((delegate* unmanaged<IMFShutdown*, MFSHUTDOWN_STATUS*, int> )(lpVtbl[4]))((IMFShutdown*)Unsafe.AsPointer(ref this), pStatus);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Shutdown();
        [VtblIndex(4)]
        HRESULT GetShutdownStatus(MFSHUTDOWN_STATUS* pStatus);
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
        public delegate* unmanaged<TSelf*, int> Shutdown;
        [NativeTypeName("HRESULT (MFSHUTDOWN_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFSHUTDOWN_STATUS*, int> GetShutdownStatus;
    }
}