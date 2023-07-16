// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFMediaEngineSrcElements.xml' path='doc/member[@name="IMFMediaEngineSrcElements"]/*'/>
[Guid("7A5E5354-B114-4C72-B991-3131D75032EA")]
[NativeTypeName("struct IMFMediaEngineSrcElements : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFMediaEngineSrcElements : IMFMediaEngineSrcElements.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineSrcElements));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements*, uint> )(lpVtbl[1]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements*, uint> )(lpVtbl[2]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineSrcElements.xml' path='doc/member[@name="IMFMediaEngineSrcElements.GetLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint GetLength()
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements*, uint> )(lpVtbl[3]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaEngineSrcElements.xml' path='doc/member[@name="IMFMediaEngineSrcElements.GetURL"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetURL([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pURL)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements*, uint, ushort**, int> )(lpVtbl[4]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this), index, pURL);
    }

    /// <include file='IMFMediaEngineSrcElements.xml' path='doc/member[@name="IMFMediaEngineSrcElements.GetType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetType([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pType)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements*, uint, ushort**, int> )(lpVtbl[5]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this), index, pType);
    }

    /// <include file='IMFMediaEngineSrcElements.xml' path='doc/member[@name="IMFMediaEngineSrcElements.GetMedia"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMedia([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pMedia)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements*, uint, ushort**, int> )(lpVtbl[6]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this), index, pMedia);
    }

    /// <include file='IMFMediaEngineSrcElements.xml' path='doc/member[@name="IMFMediaEngineSrcElements.AddElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddElement([NativeTypeName("BSTR")] ushort* pURL, [NativeTypeName("BSTR")] ushort* pType, [NativeTypeName("BSTR")] ushort* pMedia)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements*, ushort*, ushort*, ushort*, int> )(lpVtbl[7]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this), pURL, pType, pMedia);
    }

    /// <include file='IMFMediaEngineSrcElements.xml' path='doc/member[@name="IMFMediaEngineSrcElements.RemoveAllElements"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveAllElements()
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements*, int> )(lpVtbl[8]))((IMFMediaEngineSrcElements*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint GetLength();
        [VtblIndex(4)]
        HRESULT GetURL([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pURL);
        [VtblIndex(5)]
        HRESULT GetType([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pType);
        [VtblIndex(6)]
        HRESULT GetMedia([NativeTypeName("DWORD")] uint index, [NativeTypeName("BSTR *")] ushort** pMedia);
        [VtblIndex(7)]
        HRESULT AddElement([NativeTypeName("BSTR")] ushort* pURL, [NativeTypeName("BSTR")] ushort* pType, [NativeTypeName("BSTR")] ushort* pMedia);
        [VtblIndex(8)]
        HRESULT RemoveAllElements();
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
    }
}