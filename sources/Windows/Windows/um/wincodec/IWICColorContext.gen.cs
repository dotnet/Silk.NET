// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWICColorContext.xml' path='doc/member[@name="IWICColorContext"]/*' />
[Guid("3C613A02-34B2-44EA-9A7C-45AEA9C6FD6D")]
[NativeTypeName("struct IWICColorContext : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICColorContext : IWICColorContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICColorContext));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICColorContext*, Guid*, void**, int>)(lpVtbl[0]))((IWICColorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICColorContext*, uint>)(lpVtbl[1]))((IWICColorContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICColorContext*, uint>)(lpVtbl[2]))((IWICColorContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICColorContext.xml' path='doc/member[@name="IWICColorContext.InitializeFromFilename"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InitializeFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename)
    {
        return ((delegate* unmanaged<IWICColorContext*, ushort*, int>)(lpVtbl[3]))((IWICColorContext*)Unsafe.AsPointer(ref this), wzFilename);
    }

    /// <include file='IWICColorContext.xml' path='doc/member[@name="IWICColorContext.InitializeFromMemory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitializeFromMemory([NativeTypeName("const BYTE *")] byte* pbBuffer, uint cbBufferSize)
    {
        return ((delegate* unmanaged<IWICColorContext*, byte*, uint, int>)(lpVtbl[4]))((IWICColorContext*)Unsafe.AsPointer(ref this), pbBuffer, cbBufferSize);
    }

    /// <include file='IWICColorContext.xml' path='doc/member[@name="IWICColorContext.InitializeFromExifColorSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InitializeFromExifColorSpace(uint value)
    {
        return ((delegate* unmanaged<IWICColorContext*, uint, int>)(lpVtbl[5]))((IWICColorContext*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWICColorContext.xml' path='doc/member[@name="IWICColorContext.GetType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetType(WICColorContextType* pType)
    {
        return ((delegate* unmanaged<IWICColorContext*, WICColorContextType*, int>)(lpVtbl[6]))((IWICColorContext*)Unsafe.AsPointer(ref this), pType);
    }

    /// <include file='IWICColorContext.xml' path='doc/member[@name="IWICColorContext.GetProfileBytes"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetProfileBytes(uint cbBuffer, byte* pbBuffer, uint* pcbActual)
    {
        return ((delegate* unmanaged<IWICColorContext*, uint, byte*, uint*, int>)(lpVtbl[7]))((IWICColorContext*)Unsafe.AsPointer(ref this), cbBuffer, pbBuffer, pcbActual);
    }

    /// <include file='IWICColorContext.xml' path='doc/member[@name="IWICColorContext.GetExifColorSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetExifColorSpace(uint* pValue)
    {
        return ((delegate* unmanaged<IWICColorContext*, uint*, int>)(lpVtbl[8]))((IWICColorContext*)Unsafe.AsPointer(ref this), pValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InitializeFromFilename([NativeTypeName("LPCWSTR")] ushort* wzFilename);

        [VtblIndex(4)]
        HRESULT InitializeFromMemory([NativeTypeName("const BYTE *")] byte* pbBuffer, uint cbBufferSize);

        [VtblIndex(5)]
        HRESULT InitializeFromExifColorSpace(uint value);

        [VtblIndex(6)]
        HRESULT GetType(WICColorContextType* pType);

        [VtblIndex(7)]
        HRESULT GetProfileBytes(uint cbBuffer, byte* pbBuffer, uint* pcbActual);

        [VtblIndex(8)]
        HRESULT GetExifColorSpace(uint* pValue);
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> InitializeFromFilename;

        [NativeTypeName("HRESULT (const BYTE *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> InitializeFromMemory;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> InitializeFromExifColorSpace;

        [NativeTypeName("HRESULT (WICColorContextType *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, WICColorContextType*, int> GetType;

        [NativeTypeName("HRESULT (UINT, BYTE *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, uint*, int> GetProfileBytes;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetExifColorSpace;
    }
}
