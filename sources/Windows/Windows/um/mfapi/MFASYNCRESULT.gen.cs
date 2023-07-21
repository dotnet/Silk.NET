// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='MFASYNCRESULT.xml' path='doc/member[@name="MFASYNCRESULT"]/*' />
[Guid("00000000-0000-0000-0000-000000000000")]
[NativeTypeName("struct tagMFASYNCRESULT : IMFAsyncResult")]
[NativeInheritance("IMFAsyncResult")]
public unsafe partial struct MFASYNCRESULT : MFASYNCRESULT.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_tagMFASYNCRESULT));

    public void** lpVtbl;

    /// <include file='MFASYNCRESULT.xml' path='doc/member[@name="MFASYNCRESULT.overlapped"]/*' />
    public OVERLAPPED overlapped;

    /// <include file='MFASYNCRESULT.xml' path='doc/member[@name="MFASYNCRESULT.pCallback"]/*' />
    public IMFAsyncCallback* pCallback;

    /// <include file='MFASYNCRESULT.xml' path='doc/member[@name="MFASYNCRESULT.hrStatusResult"]/*' />
    public HRESULT hrStatusResult;

    /// <include file='MFASYNCRESULT.xml' path='doc/member[@name="MFASYNCRESULT.dwBytesTransferred"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBytesTransferred;

    /// <include file='MFASYNCRESULT.xml' path='doc/member[@name="MFASYNCRESULT.hEvent"]/*' />
    public HANDLE hEvent;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<MFASYNCRESULT*, Guid*, void**, int>)(lpVtbl[0]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<MFASYNCRESULT*, uint>)(lpVtbl[1]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<MFASYNCRESULT*, uint>)(lpVtbl[2]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFAsyncResult.GetState" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetState(IUnknown** ppunkState)
    {
        return ((delegate* unmanaged<MFASYNCRESULT*, IUnknown**, int>)(lpVtbl[3]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this), ppunkState);
    }

    /// <inheritdoc cref="IMFAsyncResult.GetStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStatus()
    {
        return ((delegate* unmanaged<MFASYNCRESULT*, int>)(lpVtbl[4]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFAsyncResult.SetStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStatus(HRESULT hrStatus)
    {
        return ((delegate* unmanaged<MFASYNCRESULT*, HRESULT, int>)(lpVtbl[5]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this), hrStatus);
    }

    /// <inheritdoc cref="IMFAsyncResult.GetObject" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetObject(IUnknown** ppObject)
    {
        return ((delegate* unmanaged<MFASYNCRESULT*, IUnknown**, int>)(lpVtbl[6]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this), ppObject);
    }

    /// <inheritdoc cref="IMFAsyncResult.GetStateNoAddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public IUnknown* GetStateNoAddRef()
    {
        return ((delegate* unmanaged<MFASYNCRESULT*, IUnknown*>)(lpVtbl[7]))((MFASYNCRESULT*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IMFAsyncResult.Interface
    {
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

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> GetState;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetStatus;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> SetStatus;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> GetObject;

        [NativeTypeName("IUnknown *() __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*> GetStateNoAddRef;
    }
}
