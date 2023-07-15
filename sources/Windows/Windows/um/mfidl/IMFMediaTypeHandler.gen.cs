// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFMediaTypeHandler.xml' path='doc/member[@name="IMFMediaTypeHandler"]/*'/>
[Guid("E93DCF6C-4B07-4E1E-8123-AA16ED6EADF5")]
[NativeTypeName("struct IMFMediaTypeHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaTypeHandler : IMFMediaTypeHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaTypeHandler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler*, uint> )(lpVtbl[1]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler*, uint> )(lpVtbl[2]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaTypeHandler.xml' path='doc/member[@name="IMFMediaTypeHandler.IsMediaTypeSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsMediaTypeSupported(IMFMediaType* pMediaType, IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler*, IMFMediaType*, IMFMediaType**, int> )(lpVtbl[3]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), pMediaType, ppMediaType);
    }

    /// <include file='IMFMediaTypeHandler.xml' path='doc/member[@name="IMFMediaTypeHandler.GetMediaTypeCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMediaTypeCount([NativeTypeName("DWORD *")] uint* pdwTypeCount)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler*, uint*, int> )(lpVtbl[4]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), pdwTypeCount);
    }

    /// <include file='IMFMediaTypeHandler.xml' path='doc/member[@name="IMFMediaTypeHandler.GetMediaTypeByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMediaTypeByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFMediaType** ppType)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler*, uint, IMFMediaType**, int> )(lpVtbl[5]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), dwIndex, ppType);
    }

    /// <include file='IMFMediaTypeHandler.xml' path='doc/member[@name="IMFMediaTypeHandler.SetCurrentMediaType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCurrentMediaType(IMFMediaType* pMediaType)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler*, IMFMediaType*, int> )(lpVtbl[6]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), pMediaType);
    }

    /// <include file='IMFMediaTypeHandler.xml' path='doc/member[@name="IMFMediaTypeHandler.GetCurrentMediaType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentMediaType(IMFMediaType** ppMediaType)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler*, IMFMediaType**, int> )(lpVtbl[7]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), ppMediaType);
    }

    /// <include file='IMFMediaTypeHandler.xml' path='doc/member[@name="IMFMediaTypeHandler.GetMajorType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMajorType(Guid* pguidMajorType)
    {
        return ((delegate* unmanaged<IMFMediaTypeHandler*, Guid*, int> )(lpVtbl[8]))((IMFMediaTypeHandler*)Unsafe.AsPointer(ref this), pguidMajorType);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsMediaTypeSupported(IMFMediaType* pMediaType, IMFMediaType** ppMediaType);
        [VtblIndex(4)]
        HRESULT GetMediaTypeCount([NativeTypeName("DWORD *")] uint* pdwTypeCount);
        [VtblIndex(5)]
        HRESULT GetMediaTypeByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFMediaType** ppType);
        [VtblIndex(6)]
        HRESULT SetCurrentMediaType(IMFMediaType* pMediaType);
        [VtblIndex(7)]
        HRESULT GetCurrentMediaType(IMFMediaType** ppMediaType);
        [VtblIndex(8)]
        HRESULT GetMajorType(Guid* pguidMajorType);
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
        [NativeTypeName("HRESULT (IMFMediaType *, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaType*, IMFMediaType**, int> IsMediaTypeSupported;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMediaTypeCount;
        [NativeTypeName("HRESULT (DWORD, IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFMediaType**, int> GetMediaTypeByIndex;
        [NativeTypeName("HRESULT (IMFMediaType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaType*, int> SetCurrentMediaType;
        [NativeTypeName("HRESULT (IMFMediaType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaType**, int> GetCurrentMediaType;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetMajorType;
    }
}