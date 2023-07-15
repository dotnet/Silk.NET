// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFSensorProfileCollection.xml' path='doc/member[@name="IMFSensorProfileCollection"]/*'/>
[Guid("C95EA55B-0187-48BE-9353-8D2507662351")]
[NativeTypeName("struct IMFSensorProfileCollection : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.17134.0")]
public unsafe partial struct IMFSensorProfileCollection : IMFSensorProfileCollection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSensorProfileCollection));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSensorProfileCollection*, Guid*, void**, int> )(lpVtbl[0]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSensorProfileCollection*, uint> )(lpVtbl[1]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSensorProfileCollection*, uint> )(lpVtbl[2]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSensorProfileCollection.xml' path='doc/member[@name="IMFSensorProfileCollection.GetProfileCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint GetProfileCount()
    {
        return ((delegate* unmanaged<IMFSensorProfileCollection*, uint> )(lpVtbl[3]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSensorProfileCollection.xml' path='doc/member[@name="IMFSensorProfileCollection.GetProfile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProfile([NativeTypeName("DWORD")] uint Index, IMFSensorProfile** ppProfile)
    {
        return ((delegate* unmanaged<IMFSensorProfileCollection*, uint, IMFSensorProfile**, int> )(lpVtbl[4]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this), Index, ppProfile);
    }

    /// <include file='IMFSensorProfileCollection.xml' path='doc/member[@name="IMFSensorProfileCollection.AddProfile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddProfile(IMFSensorProfile* pProfile)
    {
        return ((delegate* unmanaged<IMFSensorProfileCollection*, IMFSensorProfile*, int> )(lpVtbl[5]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this), pProfile);
    }

    /// <include file='IMFSensorProfileCollection.xml' path='doc/member[@name="IMFSensorProfileCollection.FindProfile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindProfile(SENSORPROFILEID* ProfileId, IMFSensorProfile** ppProfile)
    {
        return ((delegate* unmanaged<IMFSensorProfileCollection*, SENSORPROFILEID*, IMFSensorProfile**, int> )(lpVtbl[6]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this), ProfileId, ppProfile);
    }

    /// <include file='IMFSensorProfileCollection.xml' path='doc/member[@name="IMFSensorProfileCollection.RemoveProfileByIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void RemoveProfileByIndex([NativeTypeName("DWORD")] uint Index)
    {
        ((delegate* unmanaged<IMFSensorProfileCollection*, uint, void> )(lpVtbl[7]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this), Index);
    }

    /// <include file='IMFSensorProfileCollection.xml' path='doc/member[@name="IMFSensorProfileCollection.RemoveProfile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void RemoveProfile(SENSORPROFILEID* ProfileId)
    {
        ((delegate* unmanaged<IMFSensorProfileCollection*, SENSORPROFILEID*, void> )(lpVtbl[8]))((IMFSensorProfileCollection*)Unsafe.AsPointer(ref this), ProfileId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint GetProfileCount();
        [VtblIndex(4)]
        HRESULT GetProfile([NativeTypeName("DWORD")] uint Index, IMFSensorProfile** ppProfile);
        [VtblIndex(5)]
        HRESULT AddProfile(IMFSensorProfile* pProfile);
        [VtblIndex(6)]
        HRESULT FindProfile(SENSORPROFILEID* ProfileId, IMFSensorProfile** ppProfile);
        [VtblIndex(7)]
        void RemoveProfileByIndex([NativeTypeName("DWORD")] uint Index);
        [VtblIndex(8)]
        void RemoveProfile(SENSORPROFILEID* ProfileId);
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
        public delegate* unmanaged<TSelf*, uint> GetProfileCount;
        [NativeTypeName("HRESULT (DWORD, IMFSensorProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFSensorProfile**, int> GetProfile;
        [NativeTypeName("HRESULT (IMFSensorProfile *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSensorProfile*, int> AddProfile;
        [NativeTypeName("HRESULT (SENSORPROFILEID *, IMFSensorProfile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SENSORPROFILEID*, IMFSensorProfile**, int> FindProfile;
        [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void> RemoveProfileByIndex;
        [NativeTypeName("void (SENSORPROFILEID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SENSORPROFILEID*, void> RemoveProfile;
    }
}