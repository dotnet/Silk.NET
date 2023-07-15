// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfspatialaudio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFSpatialAudioObjectBuffer.xml' path='doc/member[@name="IMFSpatialAudioObjectBuffer"]/*'/>
[Guid("D396EC8C-605E-4249-978D-72AD1C312872")]
[NativeTypeName("struct IMFSpatialAudioObjectBuffer : IMFMediaBuffer")]
[NativeInheritance("IMFMediaBuffer")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFSpatialAudioObjectBuffer : IMFSpatialAudioObjectBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSpatialAudioObjectBuffer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, Guid*, void**, int> )(lpVtbl[0]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint> )(lpVtbl[1]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint> )(lpVtbl[2]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFMediaBuffer.Lock"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Lock(byte** ppbBuffer, [NativeTypeName("DWORD *")] uint* pcbMaxLength, [NativeTypeName("DWORD *")] uint* pcbCurrentLength)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, byte**, uint*, uint*, int> )(lpVtbl[3]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), ppbBuffer, pcbMaxLength, pcbCurrentLength);
    }

    /// <inheritdoc cref = "IMFMediaBuffer.Unlock"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unlock()
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, int> )(lpVtbl[4]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFMediaBuffer.GetCurrentLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentLength([NativeTypeName("DWORD *")] uint* pcbCurrentLength)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint*, int> )(lpVtbl[5]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), pcbCurrentLength);
    }

    /// <inheritdoc cref = "IMFMediaBuffer.SetCurrentLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCurrentLength([NativeTypeName("DWORD")] uint cbCurrentLength)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint, int> )(lpVtbl[6]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), cbCurrentLength);
    }

    /// <inheritdoc cref = "IMFMediaBuffer.GetMaxLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint*, int> )(lpVtbl[7]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), pcbMaxLength);
    }

    /// <include file='IMFSpatialAudioObjectBuffer.xml' path='doc/member[@name="IMFSpatialAudioObjectBuffer.SetID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetID([NativeTypeName("UINT32")] uint u32ID)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint, int> )(lpVtbl[8]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), u32ID);
    }

    /// <include file='IMFSpatialAudioObjectBuffer.xml' path='doc/member[@name="IMFSpatialAudioObjectBuffer.GetID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetID([NativeTypeName("UINT32 *")] uint* pu32ID)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, uint*, int> )(lpVtbl[9]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), pu32ID);
    }

    /// <include file='IMFSpatialAudioObjectBuffer.xml' path='doc/member[@name="IMFSpatialAudioObjectBuffer.SetType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetType(AudioObjectType type)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, AudioObjectType, int> )(lpVtbl[10]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), type);
    }

    /// <include file='IMFSpatialAudioObjectBuffer.xml' path='doc/member[@name="IMFSpatialAudioObjectBuffer.GetType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetType(AudioObjectType* pType)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, AudioObjectType*, int> )(lpVtbl[11]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), pType);
    }

    /// <include file='IMFSpatialAudioObjectBuffer.xml' path='doc/member[@name="IMFSpatialAudioObjectBuffer.GetMetadataItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMetadataItems(ISpatialAudioMetadataItems** ppMetadataItems)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer*, ISpatialAudioMetadataItems**, int> )(lpVtbl[12]))((IMFSpatialAudioObjectBuffer*)Unsafe.AsPointer(ref this), ppMetadataItems);
    }

    public interface Interface : IMFMediaBuffer.Interface
    {
        [VtblIndex(8)]
        HRESULT SetID([NativeTypeName("UINT32")] uint u32ID);
        [VtblIndex(9)]
        HRESULT GetID([NativeTypeName("UINT32 *")] uint* pu32ID);
        [VtblIndex(10)]
        HRESULT SetType(AudioObjectType type);
        [VtblIndex(11)]
        HRESULT GetType(AudioObjectType* pType);
        [VtblIndex(12)]
        HRESULT GetMetadataItems(ISpatialAudioMetadataItems** ppMetadataItems);
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
        [NativeTypeName("HRESULT (BYTE **, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, uint*, int> Lock;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unlock;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentLength;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetCurrentLength;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaxLength;
        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetID;
        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetID;
        [NativeTypeName("HRESULT (AudioObjectType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioObjectType, int> SetType;
        [NativeTypeName("HRESULT (AudioObjectType *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, AudioObjectType*, int> GetType;
        [NativeTypeName("HRESULT (ISpatialAudioMetadataItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpatialAudioMetadataItems**, int> GetMetadataItems;
    }
}