// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFAudioPolicy.xml' path='doc/member[@name="IMFAudioPolicy"]/*'/>
[Guid("A0638C2B-6465-4395-9AE7-A321A9FD2856")]
[NativeTypeName("struct IMFAudioPolicy : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFAudioPolicy : IMFAudioPolicy.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFAudioPolicy));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFAudioPolicy*, Guid*, void**, int> )(lpVtbl[0]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFAudioPolicy*, uint> )(lpVtbl[1]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFAudioPolicy*, uint> )(lpVtbl[2]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFAudioPolicy.xml' path='doc/member[@name="IMFAudioPolicy.SetGroupingParam"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetGroupingParam([NativeTypeName("const GUID &")] Guid* rguidClass)
    {
        return ((delegate* unmanaged<IMFAudioPolicy*, Guid*, int> )(lpVtbl[3]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), rguidClass);
    }

    /// <include file='IMFAudioPolicy.xml' path='doc/member[@name="IMFAudioPolicy.GetGroupingParam"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGroupingParam(Guid* pguidClass)
    {
        return ((delegate* unmanaged<IMFAudioPolicy*, Guid*, int> )(lpVtbl[4]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pguidClass);
    }

    /// <include file='IMFAudioPolicy.xml' path='doc/member[@name="IMFAudioPolicy.SetDisplayName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDisplayName([NativeTypeName("LPCWSTR")] ushort* pszName)
    {
        return ((delegate* unmanaged<IMFAudioPolicy*, ushort*, int> )(lpVtbl[5]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pszName);
    }

    /// <include file='IMFAudioPolicy.xml' path='doc/member[@name="IMFAudioPolicy.GetDisplayName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pszName)
    {
        return ((delegate* unmanaged<IMFAudioPolicy*, ushort**, int> )(lpVtbl[6]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pszName);
    }

    /// <include file='IMFAudioPolicy.xml' path='doc/member[@name="IMFAudioPolicy.SetIconPath"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetIconPath([NativeTypeName("LPCWSTR")] ushort* pszPath)
    {
        return ((delegate* unmanaged<IMFAudioPolicy*, ushort*, int> )(lpVtbl[7]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pszPath);
    }

    /// <include file='IMFAudioPolicy.xml' path='doc/member[@name="IMFAudioPolicy.GetIconPath"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetIconPath([NativeTypeName("LPWSTR *")] ushort** pszPath)
    {
        return ((delegate* unmanaged<IMFAudioPolicy*, ushort**, int> )(lpVtbl[8]))((IMFAudioPolicy*)Unsafe.AsPointer(ref this), pszPath);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetGroupingParam([NativeTypeName("const GUID &")] Guid* rguidClass);
        [VtblIndex(4)]
        HRESULT GetGroupingParam(Guid* pguidClass);
        [VtblIndex(5)]
        HRESULT SetDisplayName([NativeTypeName("LPCWSTR")] ushort* pszName);
        [VtblIndex(6)]
        HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pszName);
        [VtblIndex(7)]
        HRESULT SetIconPath([NativeTypeName("LPCWSTR")] ushort* pszPath);
        [VtblIndex(8)]
        HRESULT GetIconPath([NativeTypeName("LPWSTR *")] ushort** pszPath);
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
        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetGroupingParam;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGroupingParam;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDisplayName;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetIconPath;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetIconPath;
    }
}