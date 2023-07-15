// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHlinkTarget.xml' path='doc/member[@name="IHlinkTarget"]/*'/>
[Guid("79EAC9C4-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IHlinkTarget : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHlinkTarget : IHlinkTarget.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHlinkTarget));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHlinkTarget*, Guid*, void**, int> )(lpVtbl[0]))((IHlinkTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHlinkTarget*, uint> )(lpVtbl[1]))((IHlinkTarget*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHlinkTarget*, uint> )(lpVtbl[2]))((IHlinkTarget*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHlinkTarget.xml' path='doc/member[@name="IHlinkTarget.SetBrowseContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBrowseContext(IHlinkBrowseContext* pihlbc)
    {
        return ((delegate* unmanaged<IHlinkTarget*, IHlinkBrowseContext*, int> )(lpVtbl[3]))((IHlinkTarget*)Unsafe.AsPointer(ref this), pihlbc);
    }

    /// <include file='IHlinkTarget.xml' path='doc/member[@name="IHlinkTarget.GetBrowseContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBrowseContext(IHlinkBrowseContext** ppihlbc)
    {
        return ((delegate* unmanaged<IHlinkTarget*, IHlinkBrowseContext**, int> )(lpVtbl[4]))((IHlinkTarget*)Unsafe.AsPointer(ref this), ppihlbc);
    }

    /// <include file='IHlinkTarget.xml' path='doc/member[@name="IHlinkTarget.Navigate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Navigate([NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("LPCWSTR")] ushort* pwzJumpLocation)
    {
        return ((delegate* unmanaged<IHlinkTarget*, uint, ushort*, int> )(lpVtbl[5]))((IHlinkTarget*)Unsafe.AsPointer(ref this), grfHLNF, pwzJumpLocation);
    }

    /// <include file='IHlinkTarget.xml' path='doc/member[@name="IHlinkTarget.GetMoniker"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMoniker([NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("DWORD")] uint dwAssign, IMoniker** ppimkLocation)
    {
        return ((delegate* unmanaged<IHlinkTarget*, ushort*, uint, IMoniker**, int> )(lpVtbl[6]))((IHlinkTarget*)Unsafe.AsPointer(ref this), pwzLocation, dwAssign, ppimkLocation);
    }

    /// <include file='IHlinkTarget.xml' path='doc/member[@name="IHlinkTarget.GetFriendlyName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFriendlyName([NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPWSTR *")] ushort** ppwzFriendlyName)
    {
        return ((delegate* unmanaged<IHlinkTarget*, ushort*, ushort**, int> )(lpVtbl[7]))((IHlinkTarget*)Unsafe.AsPointer(ref this), pwzLocation, ppwzFriendlyName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetBrowseContext(IHlinkBrowseContext* pihlbc);
        [VtblIndex(4)]
        HRESULT GetBrowseContext(IHlinkBrowseContext** ppihlbc);
        [VtblIndex(5)]
        HRESULT Navigate([NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("LPCWSTR")] ushort* pwzJumpLocation);
        [VtblIndex(6)]
        HRESULT GetMoniker([NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("DWORD")] uint dwAssign, IMoniker** ppimkLocation);
        [VtblIndex(7)]
        HRESULT GetFriendlyName([NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPWSTR *")] ushort** ppwzFriendlyName);
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
        [NativeTypeName("HRESULT (IHlinkBrowseContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHlinkBrowseContext*, int> SetBrowseContext;
        [NativeTypeName("HRESULT (IHlinkBrowseContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHlinkBrowseContext**, int> GetBrowseContext;
        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> Navigate;
        [NativeTypeName("HRESULT (LPCWSTR, DWORD, IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, IMoniker**, int> GetMoniker;
        [NativeTypeName("HRESULT (LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> GetFriendlyName;
    }
}