// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFMediaEngineSrcElementsEx.xml' path='doc/member[@name="IMFMediaEngineSrcElementsEx"]/*' />
[Guid("654A6BB3-E1A3-424A-9908-53A43A0DFDA0")]
[NativeTypeName("struct IMFMediaEngineSrcElementsEx : IMFMediaEngineSrcElements")]
[NativeInheritance("IMFMediaEngineSrcElements")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFMediaEngineSrcElementsEx : IMFMediaEngineSrcElementsEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineSrcElementsEx));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElementsEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElementsEx*, uint>)(lpVtbl[1]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElementsEx*, uint>)(lpVtbl[2]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngineSrcElements.GetLength" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint GetLength()
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElementsEx*, uint>)(lpVtbl[3]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFMediaEngineSrcElements.GetURL" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetURL([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pURL)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElementsEx*, uint, ushort**, int>)(lpVtbl[4]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), index, pURL);
    }

    /// <inheritdoc cref="IMFMediaEngineSrcElements.GetType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetType([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pType)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElementsEx*, uint, ushort**, int>)(lpVtbl[5]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), index, pType);
    }

    /// <inheritdoc cref="IMFMediaEngineSrcElements.GetMedia" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMedia([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pMedia)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElementsEx*, uint, ushort**, int>)(lpVtbl[6]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), index, pMedia);
    }

    /// <inheritdoc cref="IMFMediaEngineSrcElements.AddElement" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddElement([NativeTypeName("BSTR")] ushort* pURL, [NativeTypeName("BSTR")] ushort* pType, [NativeTypeName("BSTR")] ushort* pMedia)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElementsEx*, ushort*, ushort*, ushort*, int>)(lpVtbl[7]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), pURL, pType, pMedia);
    }

    /// <inheritdoc cref="IMFMediaEngineSrcElements.RemoveAllElements" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveAllElements()
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElementsEx*, int>)(lpVtbl[8]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineSrcElementsEx.xml' path='doc/member[@name="IMFMediaEngineSrcElementsEx.AddElementEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddElementEx([NativeTypeName("BSTR")] ushort* pURL, [NativeTypeName("BSTR")] ushort* pType, [NativeTypeName("BSTR")] ushort* pMedia, [NativeTypeName("BSTR")] ushort* keySystem)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElementsEx*, ushort*, ushort*, ushort*, ushort*, int>)(lpVtbl[9]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), pURL, pType, pMedia, keySystem);
    }

    /// <include file='IMFMediaEngineSrcElementsEx.xml' path='doc/member[@name="IMFMediaEngineSrcElementsEx.GetKeySystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetKeySystem([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pType)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElementsEx*, uint, ushort**, int>)(lpVtbl[10]))((IMFMediaEngineSrcElementsEx*)Unsafe.AsPointer(ref this), index, pType);
    }

    public interface Interface : IMFMediaEngineSrcElements.Interface
    {
        [VtblIndex(9)]
        HRESULT AddElementEx([NativeTypeName("BSTR")] ushort* pURL, [NativeTypeName("BSTR")] ushort* pType, [NativeTypeName("BSTR")] ushort* pMedia, [NativeTypeName("BSTR")] ushort* keySystem);

        [VtblIndex(10)]
        HRESULT GetKeySystem([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pType);
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

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetLength;

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetURL;

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, uint, ushort**, int> GetType;

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetMedia;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> AddElement;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllElements;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, ushort*, int> AddElementEx;

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetKeySystem;
    }
}
