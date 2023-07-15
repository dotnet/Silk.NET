// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFSaveJob.xml' path='doc/member[@name="IMFSaveJob"]/*'/>
[Guid("E9931663-80BF-4C6E-98AF-5DCF58747D1F")]
[NativeTypeName("struct IMFSaveJob : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSaveJob : IMFSaveJob.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSaveJob));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSaveJob*, Guid*, void**, int> )(lpVtbl[0]))((IMFSaveJob*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSaveJob*, uint> )(lpVtbl[1]))((IMFSaveJob*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSaveJob*, uint> )(lpVtbl[2]))((IMFSaveJob*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSaveJob.xml' path='doc/member[@name="IMFSaveJob.BeginSave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginSave(IMFByteStream* pStream, IMFAsyncCallback* pCallback, IUnknown* pState)
    {
        return ((delegate* unmanaged<IMFSaveJob*, IMFByteStream*, IMFAsyncCallback*, IUnknown*, int> )(lpVtbl[3]))((IMFSaveJob*)Unsafe.AsPointer(ref this), pStream, pCallback, pState);
    }

    /// <include file='IMFSaveJob.xml' path='doc/member[@name="IMFSaveJob.EndSave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndSave(IMFAsyncResult* pResult)
    {
        return ((delegate* unmanaged<IMFSaveJob*, IMFAsyncResult*, int> )(lpVtbl[4]))((IMFSaveJob*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='IMFSaveJob.xml' path='doc/member[@name="IMFSaveJob.CancelSave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CancelSave()
    {
        return ((delegate* unmanaged<IMFSaveJob*, int> )(lpVtbl[5]))((IMFSaveJob*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSaveJob.xml' path='doc/member[@name="IMFSaveJob.GetProgress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetProgress([NativeTypeName("DWORD *")] uint* pdwPercentComplete)
    {
        return ((delegate* unmanaged<IMFSaveJob*, uint*, int> )(lpVtbl[6]))((IMFSaveJob*)Unsafe.AsPointer(ref this), pdwPercentComplete);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginSave(IMFByteStream* pStream, IMFAsyncCallback* pCallback, IUnknown* pState);
        [VtblIndex(4)]
        HRESULT EndSave(IMFAsyncResult* pResult);
        [VtblIndex(5)]
        HRESULT CancelSave();
        [VtblIndex(6)]
        HRESULT GetProgress([NativeTypeName("DWORD *")] uint* pdwPercentComplete);
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
        [NativeTypeName("HRESULT (IMFByteStream *, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFByteStream*, IMFAsyncCallback*, IUnknown*, int> BeginSave;
        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, int> EndSave;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CancelSave;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetProgress;
    }
}