// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFAsyncCallbackLogging.xml' path='doc/member[@name="IMFAsyncCallbackLogging"]/*' />
[Guid("C7A4DCA1-F5F0-47B6-B92B-BF0106D25791")]
[NativeTypeName("struct IMFAsyncCallbackLogging : IMFAsyncCallback")]
[NativeInheritance("IMFAsyncCallback")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFAsyncCallbackLogging : IMFAsyncCallbackLogging.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFAsyncCallbackLogging));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging*, Guid*, void**, int>)(lpVtbl[0]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging*, uint>)(lpVtbl[1]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging*, uint>)(lpVtbl[2]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFAsyncCallback.GetParameters" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetParameters([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD *")] uint* pdwQueue)
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging*, uint*, uint*, int>)(lpVtbl[3]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this), pdwFlags, pdwQueue);
    }

    /// <inheritdoc cref="IMFAsyncCallback.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Invoke(IMFAsyncResult* pAsyncResult)
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this), pAsyncResult);
    }

    /// <include file='IMFAsyncCallbackLogging.xml' path='doc/member[@name="IMFAsyncCallbackLogging.GetObjectPointer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void* GetObjectPointer()
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging*, void*>)(lpVtbl[5]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFAsyncCallbackLogging.xml' path='doc/member[@name="IMFAsyncCallbackLogging.GetObjectTag"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("DWORD")]
    public uint GetObjectTag()
    {
        return ((delegate* unmanaged<IMFAsyncCallbackLogging*, uint>)(lpVtbl[6]))((IMFAsyncCallbackLogging*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IMFAsyncCallback.Interface
    {
        [VtblIndex(5)]
        void* GetObjectPointer();

        [VtblIndex(6)]
        [return: NativeTypeName("DWORD")]
        uint GetObjectTag();
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

        [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetParameters;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, int> Invoke;

        [NativeTypeName("void *() __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetObjectPointer;

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetObjectTag;
    }
}
