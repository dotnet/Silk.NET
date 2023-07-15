// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpatialAudioObject.xml' path='doc/member[@name="ISpatialAudioObject"]/*'/>
[Guid("DDE28967-521B-46E5-8F00-BD6F2BC8AB1D")]
[NativeTypeName("struct ISpatialAudioObject : ISpatialAudioObjectBase")]
[NativeInheritance("ISpatialAudioObjectBase")]
public unsafe partial struct ISpatialAudioObject : ISpatialAudioObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioObject));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioObject*, Guid*, void**, int> )(lpVtbl[0]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioObject*, uint> )(lpVtbl[1]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioObject*, uint> )(lpVtbl[2]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISpatialAudioObjectBase.GetBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
    {
        return ((delegate* unmanaged<ISpatialAudioObject*, byte**, uint*, int> )(lpVtbl[3]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), buffer, bufferLength);
    }

    /// <inheritdoc cref = "ISpatialAudioObjectBase.SetEndOfStream"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
    {
        return ((delegate* unmanaged<ISpatialAudioObject*, uint, int> )(lpVtbl[4]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), frameCount);
    }

    /// <inheritdoc cref = "ISpatialAudioObjectBase.IsActive"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsActive(BOOL* isActive)
    {
        return ((delegate* unmanaged<ISpatialAudioObject*, BOOL*, int> )(lpVtbl[5]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), isActive);
    }

    /// <inheritdoc cref = "ISpatialAudioObjectBase.GetAudioObjectType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAudioObjectType(AudioObjectType* audioObjectType)
    {
        return ((delegate* unmanaged<ISpatialAudioObject*, AudioObjectType*, int> )(lpVtbl[6]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), audioObjectType);
    }

    /// <include file='ISpatialAudioObject.xml' path='doc/member[@name="ISpatialAudioObject.SetPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPosition(float x, float y, float z)
    {
        return ((delegate* unmanaged<ISpatialAudioObject*, float, float, float, int> )(lpVtbl[7]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), x, y, z);
    }

    /// <include file='ISpatialAudioObject.xml' path='doc/member[@name="ISpatialAudioObject.SetVolume"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetVolume(float volume)
    {
        return ((delegate* unmanaged<ISpatialAudioObject*, float, int> )(lpVtbl[8]))((ISpatialAudioObject*)Unsafe.AsPointer(ref this), volume);
    }

    public interface Interface : ISpatialAudioObjectBase.Interface
    {
        [VtblIndex(7)]
        HRESULT SetPosition(float x, float y, float z);
        [VtblIndex(8)]
        HRESULT SetVolume(float volume);
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
        [NativeTypeName("HRESULT (BYTE **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetBuffer;
        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetEndOfStream;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsActive;
        [NativeTypeName("HRESULT (AudioObjectType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioObjectType*, int> GetAudioObjectType;
        [NativeTypeName("HRESULT (float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, int> SetPosition;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetVolume;
    }
}