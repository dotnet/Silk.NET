// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAudioAmbisonicsControl.xml' path='doc/member[@name="IAudioAmbisonicsControl"]/*'/>
[Guid("28724C91-DF35-4856-9F76-D6A26413F3DF")]
[NativeTypeName("struct IAudioAmbisonicsControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioAmbisonicsControl : IAudioAmbisonicsControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioAmbisonicsControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioAmbisonicsControl*, Guid*, void**, int> )(lpVtbl[0]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioAmbisonicsControl*, uint> )(lpVtbl[1]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioAmbisonicsControl*, uint> )(lpVtbl[2]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioAmbisonicsControl.xml' path='doc/member[@name="IAudioAmbisonicsControl.SetData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetData([NativeTypeName("const AMBISONICS_PARAMS *")] AMBISONICS_PARAMS* pAmbisonicsParams, [NativeTypeName("UINT32")] uint cbAmbisonicsParams)
    {
        return ((delegate* unmanaged<IAudioAmbisonicsControl*, AMBISONICS_PARAMS*, uint, int> )(lpVtbl[3]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), pAmbisonicsParams, cbAmbisonicsParams);
    }

    /// <include file='IAudioAmbisonicsControl.xml' path='doc/member[@name="IAudioAmbisonicsControl.SetHeadTracking"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetHeadTracking(BOOL bEnableHeadTracking)
    {
        return ((delegate* unmanaged<IAudioAmbisonicsControl*, BOOL, int> )(lpVtbl[4]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), bEnableHeadTracking);
    }

    /// <include file='IAudioAmbisonicsControl.xml' path='doc/member[@name="IAudioAmbisonicsControl.GetHeadTracking"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetHeadTracking(BOOL* pbEnableHeadTracking)
    {
        return ((delegate* unmanaged<IAudioAmbisonicsControl*, BOOL*, int> )(lpVtbl[5]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), pbEnableHeadTracking);
    }

    /// <include file='IAudioAmbisonicsControl.xml' path='doc/member[@name="IAudioAmbisonicsControl.SetRotation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetRotation(float X, float Y, float Z, float W)
    {
        return ((delegate* unmanaged<IAudioAmbisonicsControl*, float, float, float, float, int> )(lpVtbl[6]))((IAudioAmbisonicsControl*)Unsafe.AsPointer(ref this), X, Y, Z, W);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetData([NativeTypeName("const AMBISONICS_PARAMS *")] AMBISONICS_PARAMS* pAmbisonicsParams, [NativeTypeName("UINT32")] uint cbAmbisonicsParams);
        [VtblIndex(4)]
        HRESULT SetHeadTracking(BOOL bEnableHeadTracking);
        [VtblIndex(5)]
        HRESULT GetHeadTracking(BOOL* pbEnableHeadTracking);
        [VtblIndex(6)]
        HRESULT SetRotation(float X, float Y, float Z, float W);
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
        [NativeTypeName("HRESULT (const AMBISONICS_PARAMS *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AMBISONICS_PARAMS*, uint, int> SetData;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetHeadTracking;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHeadTracking;
        [NativeTypeName("HRESULT (float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, int> SetRotation;
    }
}