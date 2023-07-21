// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFMediaSourceExtension.xml' path='doc/member[@name="IMFMediaSourceExtension"]/*' />
[Guid("E467B94E-A713-4562-A802-816A42E9008A")]
[NativeTypeName("struct IMFMediaSourceExtension : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFMediaSourceExtension : IMFMediaSourceExtension.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaSourceExtension));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, uint>)(lpVtbl[1]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, uint>)(lpVtbl[2]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaSourceExtension.xml' path='doc/member[@name="IMFMediaSourceExtension.GetSourceBuffers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IMFSourceBufferList* GetSourceBuffers()
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, IMFSourceBufferList*>)(lpVtbl[3]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaSourceExtension.xml' path='doc/member[@name="IMFMediaSourceExtension.GetActiveSourceBuffers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public IMFSourceBufferList* GetActiveSourceBuffers()
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, IMFSourceBufferList*>)(lpVtbl[4]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaSourceExtension.xml' path='doc/member[@name="IMFMediaSourceExtension.GetReadyState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public MF_MSE_READY GetReadyState()
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, MF_MSE_READY>)(lpVtbl[5]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaSourceExtension.xml' path='doc/member[@name="IMFMediaSourceExtension.GetDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public double GetDuration()
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, double>)(lpVtbl[6]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaSourceExtension.xml' path='doc/member[@name="IMFMediaSourceExtension.SetDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDuration(double duration)
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, double, int>)(lpVtbl[7]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), duration);
    }

    /// <include file='IMFMediaSourceExtension.xml' path='doc/member[@name="IMFMediaSourceExtension.AddSourceBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddSourceBuffer([NativeTypeName("BSTR")] ushort* type, IMFSourceBufferNotify* pNotify, IMFSourceBuffer** ppSourceBuffer)
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, ushort*, IMFSourceBufferNotify*, IMFSourceBuffer**, int>)(lpVtbl[8]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), type, pNotify, ppSourceBuffer);
    }

    /// <include file='IMFMediaSourceExtension.xml' path='doc/member[@name="IMFMediaSourceExtension.RemoveSourceBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveSourceBuffer(IMFSourceBuffer* pSourceBuffer)
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, IMFSourceBuffer*, int>)(lpVtbl[9]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), pSourceBuffer);
    }

    /// <include file='IMFMediaSourceExtension.xml' path='doc/member[@name="IMFMediaSourceExtension.SetEndOfStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetEndOfStream(MF_MSE_ERROR error)
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, MF_MSE_ERROR, int>)(lpVtbl[10]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), error);
    }

    /// <include file='IMFMediaSourceExtension.xml' path='doc/member[@name="IMFMediaSourceExtension.IsTypeSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public BOOL IsTypeSupported([NativeTypeName("BSTR")] ushort* type)
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, ushort*, int>)(lpVtbl[11]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), type);
    }

    /// <include file='IMFMediaSourceExtension.xml' path='doc/member[@name="IMFMediaSourceExtension.GetSourceBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public IMFSourceBuffer* GetSourceBuffer([NativeTypeName("DWORD")] uint dwStreamIndex)
    {
        return ((delegate* unmanaged<IMFMediaSourceExtension*, uint, IMFSourceBuffer*>)(lpVtbl[12]))((IMFMediaSourceExtension*)Unsafe.AsPointer(ref this), dwStreamIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        IMFSourceBufferList* GetSourceBuffers();

        [VtblIndex(4)]
        IMFSourceBufferList* GetActiveSourceBuffers();

        [VtblIndex(5)]
        MF_MSE_READY GetReadyState();

        [VtblIndex(6)]
        double GetDuration();

        [VtblIndex(7)]
        HRESULT SetDuration(double duration);

        [VtblIndex(8)]
        HRESULT AddSourceBuffer([NativeTypeName("BSTR")] ushort* type, IMFSourceBufferNotify* pNotify, IMFSourceBuffer** ppSourceBuffer);

        [VtblIndex(9)]
        HRESULT RemoveSourceBuffer(IMFSourceBuffer* pSourceBuffer);

        [VtblIndex(10)]
        HRESULT SetEndOfStream(MF_MSE_ERROR error);

        [VtblIndex(11)]
        BOOL IsTypeSupported([NativeTypeName("BSTR")] ushort* type);

        [VtblIndex(12)]
        IMFSourceBuffer* GetSourceBuffer([NativeTypeName("DWORD")] uint dwStreamIndex);
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

        [NativeTypeName("IMFSourceBufferList *() __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSourceBufferList*> GetSourceBuffers;

        [NativeTypeName("IMFSourceBufferList *() __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSourceBufferList*> GetActiveSourceBuffers;

        [NativeTypeName("MF_MSE_READY () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_MSE_READY> GetReadyState;

        [NativeTypeName("double () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double> GetDuration;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetDuration;

        [NativeTypeName("HRESULT (BSTR, IMFSourceBufferNotify *, IMFSourceBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IMFSourceBufferNotify*, IMFSourceBuffer**, int> AddSourceBuffer;

        [NativeTypeName("HRESULT (IMFSourceBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSourceBuffer*, int> RemoveSourceBuffer;

        [NativeTypeName("HRESULT (MF_MSE_ERROR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_MSE_ERROR, int> SetEndOfStream;

        [NativeTypeName("BOOL (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> IsTypeSupported;

        [NativeTypeName("IMFSourceBuffer *(DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFSourceBuffer*> GetSourceBuffer;
    }
}
