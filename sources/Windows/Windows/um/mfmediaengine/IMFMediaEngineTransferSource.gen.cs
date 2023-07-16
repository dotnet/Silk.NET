// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFMediaEngineTransferSource.xml' path='doc/member[@name="IMFMediaEngineTransferSource"]/*'/>
[Guid("24230452-FE54-40CC-94F3-FCC394C340D6")]
[NativeTypeName("struct IMFMediaEngineTransferSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaEngineTransferSource : IMFMediaEngineTransferSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineTransferSource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineTransferSource*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaEngineTransferSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineTransferSource*, uint> )(lpVtbl[1]))((IMFMediaEngineTransferSource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineTransferSource*, uint> )(lpVtbl[2]))((IMFMediaEngineTransferSource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineTransferSource.xml' path='doc/member[@name="IMFMediaEngineTransferSource.TransferSourceToMediaEngine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT TransferSourceToMediaEngine(IMFMediaEngine* destination)
    {
        return ((delegate* unmanaged<IMFMediaEngineTransferSource*, IMFMediaEngine*, int> )(lpVtbl[3]))((IMFMediaEngineTransferSource*)Unsafe.AsPointer(ref this), destination);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT TransferSourceToMediaEngine(IMFMediaEngine* destination);
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
        [NativeTypeName("HRESULT (IMFMediaEngine *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaEngine*, int> TransferSourceToMediaEngine;
    }
}