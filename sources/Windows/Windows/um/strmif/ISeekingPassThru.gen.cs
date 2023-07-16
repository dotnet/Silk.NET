// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISeekingPassThru.xml' path='doc/member[@name="ISeekingPassThru"]/*'/>
[Guid("36B73883-C2C8-11CF-8B46-00805F6CEF60")]
[NativeTypeName("struct ISeekingPassThru : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISeekingPassThru : ISeekingPassThru.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISeekingPassThru));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISeekingPassThru*, Guid*, void**, int> )(lpVtbl[0]))((ISeekingPassThru*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISeekingPassThru*, uint> )(lpVtbl[1]))((ISeekingPassThru*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISeekingPassThru*, uint> )(lpVtbl[2]))((ISeekingPassThru*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISeekingPassThru.xml' path='doc/member[@name="ISeekingPassThru.Init"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Init(BOOL bSupportRendering, IPin* pPin)
    {
        return ((delegate* unmanaged<ISeekingPassThru*, BOOL, IPin*, int> )(lpVtbl[3]))((ISeekingPassThru*)Unsafe.AsPointer(ref this), bSupportRendering, pPin);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Init(BOOL bSupportRendering, IPin* pPin);
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
        [NativeTypeName("HRESULT (BOOL, IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, IPin*, int> Init;
    }
}