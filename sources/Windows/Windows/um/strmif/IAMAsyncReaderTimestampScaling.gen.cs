// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAMAsyncReaderTimestampScaling.xml' path='doc/member[@name="IAMAsyncReaderTimestampScaling"]/*'/>
[Guid("CF7B26FC-9A00-485B-8147-3E789D5E8F67")]
[NativeTypeName("struct IAMAsyncReaderTimestampScaling : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMAsyncReaderTimestampScaling : IAMAsyncReaderTimestampScaling.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMAsyncReaderTimestampScaling));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, Guid*, void**, int> )(lpVtbl[0]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, uint> )(lpVtbl[1]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, uint> )(lpVtbl[2]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMAsyncReaderTimestampScaling.xml' path='doc/member[@name="IAMAsyncReaderTimestampScaling.GetTimestampMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTimestampMode(BOOL* pfRaw)
    {
        return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, BOOL*, int> )(lpVtbl[3]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this), pfRaw);
    }

    /// <include file='IAMAsyncReaderTimestampScaling.xml' path='doc/member[@name="IAMAsyncReaderTimestampScaling.SetTimestampMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTimestampMode(BOOL fRaw)
    {
        return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, BOOL, int> )(lpVtbl[4]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this), fRaw);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTimestampMode(BOOL* pfRaw);
        [VtblIndex(4)]
        HRESULT SetTimestampMode(BOOL fRaw);
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
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetTimestampMode;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetTimestampMode;
    }
}