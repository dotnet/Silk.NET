// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISpatialAudioObjectForHrtf.xml' path='doc/member[@name="ISpatialAudioObjectForHrtf"]/*'/>
[Guid("D7436ADE-1978-4E14-ABA0-555BD8EB83B4")]
[NativeTypeName("struct ISpatialAudioObjectForHrtf : ISpatialAudioObjectBase")]
[NativeInheritance("ISpatialAudioObjectBase")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioObjectForHrtf : ISpatialAudioObjectForHrtf.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioObjectForHrtf));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, Guid*, void**, int> )(lpVtbl[0]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, uint> )(lpVtbl[1]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, uint> )(lpVtbl[2]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISpatialAudioObjectBase.GetBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, byte**, uint*, int> )(lpVtbl[3]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), buffer, bufferLength);
    }

    /// <inheritdoc cref = "ISpatialAudioObjectBase.SetEndOfStream"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, uint, int> )(lpVtbl[4]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), frameCount);
    }

    /// <inheritdoc cref = "ISpatialAudioObjectBase.IsActive"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsActive(BOOL* isActive)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, BOOL*, int> )(lpVtbl[5]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), isActive);
    }

    /// <inheritdoc cref = "ISpatialAudioObjectBase.GetAudioObjectType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAudioObjectType(AudioObjectType* audioObjectType)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, AudioObjectType*, int> )(lpVtbl[6]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), audioObjectType);
    }

    /// <include file='ISpatialAudioObjectForHrtf.xml' path='doc/member[@name="ISpatialAudioObjectForHrtf.SetPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetPosition(float x, float y, float z)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, float, float, float, int> )(lpVtbl[7]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), x, y, z);
    }

    /// <include file='ISpatialAudioObjectForHrtf.xml' path='doc/member[@name="ISpatialAudioObjectForHrtf.SetGain"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetGain(float gain)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, float, int> )(lpVtbl[8]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), gain);
    }

    /// <include file='ISpatialAudioObjectForHrtf.xml' path='doc/member[@name="ISpatialAudioObjectForHrtf.SetOrientation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetOrientation([NativeTypeName("const SpatialAudioHrtfOrientation *")] float** orientation)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, float**, int> )(lpVtbl[9]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), orientation);
    }

    /// <include file='ISpatialAudioObjectForHrtf.xml' path='doc/member[@name="ISpatialAudioObjectForHrtf.SetEnvironment"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetEnvironment(SpatialAudioHrtfEnvironmentType environment)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, SpatialAudioHrtfEnvironmentType, int> )(lpVtbl[10]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), environment);
    }

    /// <include file='ISpatialAudioObjectForHrtf.xml' path='doc/member[@name="ISpatialAudioObjectForHrtf.SetDistanceDecay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetDistanceDecay(SpatialAudioHrtfDistanceDecay* distanceDecay)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, SpatialAudioHrtfDistanceDecay*, int> )(lpVtbl[11]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), distanceDecay);
    }

    /// <include file='ISpatialAudioObjectForHrtf.xml' path='doc/member[@name="ISpatialAudioObjectForHrtf.SetDirectivity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetDirectivity(SpatialAudioHrtfDirectivityUnion* directivity)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForHrtf*, SpatialAudioHrtfDirectivityUnion*, int> )(lpVtbl[12]))((ISpatialAudioObjectForHrtf*)Unsafe.AsPointer(ref this), directivity);
    }

    public interface Interface : ISpatialAudioObjectBase.Interface
    {
        [VtblIndex(7)]
        HRESULT SetPosition(float x, float y, float z);
        [VtblIndex(8)]
        HRESULT SetGain(float gain);
        [VtblIndex(9)]
        HRESULT SetOrientation([NativeTypeName("const SpatialAudioHrtfOrientation *")] float** orientation);
        [VtblIndex(10)]
        HRESULT SetEnvironment(SpatialAudioHrtfEnvironmentType environment);
        [VtblIndex(11)]
        HRESULT SetDistanceDecay(SpatialAudioHrtfDistanceDecay* distanceDecay);
        [VtblIndex(12)]
        HRESULT SetDirectivity(SpatialAudioHrtfDirectivityUnion* directivity);
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
        public delegate* unmanaged<TSelf*, float, int> SetGain;
        [NativeTypeName("HRESULT (const SpatialAudioHrtfOrientation *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float**, int> SetOrientation;
        [NativeTypeName("HRESULT (SpatialAudioHrtfEnvironmentType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpatialAudioHrtfEnvironmentType, int> SetEnvironment;
        [NativeTypeName("HRESULT (SpatialAudioHrtfDistanceDecay *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpatialAudioHrtfDistanceDecay*, int> SetDistanceDecay;
        [NativeTypeName("HRESULT (SpatialAudioHrtfDirectivityUnion *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpatialAudioHrtfDirectivityUnion*, int> SetDirectivity;
    }
}