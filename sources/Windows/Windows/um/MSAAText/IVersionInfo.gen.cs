// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IVersionInfo.xml' path='doc/member[@name="IVersionInfo"]/*'/>
[Guid("401518EC-DB00-4611-9B29-2A0E4B9AFA85")]
[NativeTypeName("struct IVersionInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVersionInfo : IVersionInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVersionInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVersionInfo*, Guid*, void**, int> )(lpVtbl[0]))((IVersionInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVersionInfo*, uint> )(lpVtbl[1]))((IVersionInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVersionInfo*, uint> )(lpVtbl[2]))((IVersionInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVersionInfo.xml' path='doc/member[@name="IVersionInfo.GetSubcomponentCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSubcomponentCount([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("ULONG *")] uint* ulCount)
    {
        return ((delegate* unmanaged<IVersionInfo*, uint, uint*, int> )(lpVtbl[3]))((IVersionInfo*)Unsafe.AsPointer(ref this), ulSub, ulCount);
    }

    /// <include file='IVersionInfo.xml' path='doc/member[@name="IVersionInfo.GetImplementationID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetImplementationID([NativeTypeName("ULONG")] uint ulSub, Guid* implid)
    {
        return ((delegate* unmanaged<IVersionInfo*, uint, Guid*, int> )(lpVtbl[4]))((IVersionInfo*)Unsafe.AsPointer(ref this), ulSub, implid);
    }

    /// <include file='IVersionInfo.xml' path='doc/member[@name="IVersionInfo.GetBuildVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBuildVersion([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("DWORD *")] uint* pdwMajor, [NativeTypeName("DWORD *")] uint* pdwMinor)
    {
        return ((delegate* unmanaged<IVersionInfo*, uint, uint*, uint*, int> )(lpVtbl[5]))((IVersionInfo*)Unsafe.AsPointer(ref this), ulSub, pdwMajor, pdwMinor);
    }

    /// <include file='IVersionInfo.xml' path='doc/member[@name="IVersionInfo.GetComponentDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetComponentDescription([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("BSTR *")] ushort** pImplStr)
    {
        return ((delegate* unmanaged<IVersionInfo*, uint, ushort**, int> )(lpVtbl[6]))((IVersionInfo*)Unsafe.AsPointer(ref this), ulSub, pImplStr);
    }

    /// <include file='IVersionInfo.xml' path='doc/member[@name="IVersionInfo.GetInstanceDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetInstanceDescription([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("BSTR *")] ushort** pImplStr)
    {
        return ((delegate* unmanaged<IVersionInfo*, uint, ushort**, int> )(lpVtbl[7]))((IVersionInfo*)Unsafe.AsPointer(ref this), ulSub, pImplStr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSubcomponentCount([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("ULONG *")] uint* ulCount);
        [VtblIndex(4)]
        HRESULT GetImplementationID([NativeTypeName("ULONG")] uint ulSub, Guid* implid);
        [VtblIndex(5)]
        HRESULT GetBuildVersion([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("DWORD *")] uint* pdwMajor, [NativeTypeName("DWORD *")] uint* pdwMinor);
        [VtblIndex(6)]
        HRESULT GetComponentDescription([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("BSTR *")] ushort** pImplStr);
        [VtblIndex(7)]
        HRESULT GetInstanceDescription([NativeTypeName("ULONG")] uint ulSub, [NativeTypeName("BSTR *")] ushort** pImplStr);
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
        [NativeTypeName("HRESULT (ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetSubcomponentCount;
        [NativeTypeName("HRESULT (ULONG, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> GetImplementationID;
        [NativeTypeName("HRESULT (ULONG, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint*, int> GetBuildVersion;
        [NativeTypeName("HRESULT (ULONG, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetComponentDescription;
        [NativeTypeName("HRESULT (ULONG, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetInstanceDescription;
    }
}