// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfDisplayAttributeInfo.xml' path='doc/member[@name="ITfDisplayAttributeInfo"]/*' />
[Guid("70528852-2F26-4AEA-8C96-215150578932")]
[NativeTypeName("struct ITfDisplayAttributeInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfDisplayAttributeInfo : ITfDisplayAttributeInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfDisplayAttributeInfo));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo*, Guid*, void**, int>)(lpVtbl[0]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo*, uint>)(lpVtbl[1]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo*, uint>)(lpVtbl[2]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfDisplayAttributeInfo.xml' path='doc/member[@name="ITfDisplayAttributeInfo.GetGUID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetGUID(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo*, Guid*, int>)(lpVtbl[3]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), pguid);
    }

    /// <include file='ITfDisplayAttributeInfo.xml' path='doc/member[@name="ITfDisplayAttributeInfo.GetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDesc)
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo*, ushort**, int>)(lpVtbl[4]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), pbstrDesc);
    }

    /// <include file='ITfDisplayAttributeInfo.xml' path='doc/member[@name="ITfDisplayAttributeInfo.GetAttributeInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAttributeInfo(TF_DISPLAYATTRIBUTE* pda)
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo*, TF_DISPLAYATTRIBUTE*, int>)(lpVtbl[5]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), pda);
    }

    /// <include file='ITfDisplayAttributeInfo.xml' path='doc/member[@name="ITfDisplayAttributeInfo.SetAttributeInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAttributeInfo([NativeTypeName("const TF_DISPLAYATTRIBUTE *")] TF_DISPLAYATTRIBUTE* pda)
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo*, TF_DISPLAYATTRIBUTE*, int>)(lpVtbl[6]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this), pda);
    }

    /// <include file='ITfDisplayAttributeInfo.xml' path='doc/member[@name="ITfDisplayAttributeInfo.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<ITfDisplayAttributeInfo*, int>)(lpVtbl[7]))((ITfDisplayAttributeInfo*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetGUID(Guid* pguid);

        [VtblIndex(4)]
        HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDesc);

        [VtblIndex(5)]
        HRESULT GetAttributeInfo(TF_DISPLAYATTRIBUTE* pda);

        [VtblIndex(6)]
        HRESULT SetAttributeInfo([NativeTypeName("const TF_DISPLAYATTRIBUTE *")] TF_DISPLAYATTRIBUTE* pda);

        [VtblIndex(7)]
        HRESULT Reset();
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGUID;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (TF_DISPLAYATTRIBUTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TF_DISPLAYATTRIBUTE*, int> GetAttributeInfo;

        [NativeTypeName("HRESULT (const TF_DISPLAYATTRIBUTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TF_DISPLAYATTRIBUTE*, int> SetAttributeInfo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
    }
}
