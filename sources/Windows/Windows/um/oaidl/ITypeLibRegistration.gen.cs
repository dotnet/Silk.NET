// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITypeLibRegistration.xml' path='doc/member[@name="ITypeLibRegistration"]/*'/>
[Guid("76A3E735-02DF-4A12-98EB-043AD3600AF3")]
[NativeTypeName("struct ITypeLibRegistration : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITypeLibRegistration : ITypeLibRegistration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITypeLibRegistration));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITypeLibRegistration*, Guid*, void**, int> )(lpVtbl[0]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITypeLibRegistration*, uint> )(lpVtbl[1]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITypeLibRegistration*, uint> )(lpVtbl[2]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITypeLibRegistration.xml' path='doc/member[@name="ITypeLibRegistration.GetGuid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetGuid(Guid* pGuid)
    {
        return ((delegate* unmanaged<ITypeLibRegistration*, Guid*, int> )(lpVtbl[3]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pGuid);
    }

    /// <include file='ITypeLibRegistration.xml' path='doc/member[@name="ITypeLibRegistration.GetVersion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetVersion([NativeTypeName("BSTR *")] ushort** pVersion)
    {
        return ((delegate* unmanaged<ITypeLibRegistration*, ushort**, int> )(lpVtbl[4]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pVersion);
    }

    /// <include file='ITypeLibRegistration.xml' path='doc/member[@name="ITypeLibRegistration.GetLcid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLcid([NativeTypeName("LCID *")] uint* pLcid)
    {
        return ((delegate* unmanaged<ITypeLibRegistration*, uint*, int> )(lpVtbl[5]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pLcid);
    }

    /// <include file='ITypeLibRegistration.xml' path='doc/member[@name="ITypeLibRegistration.GetWin32Path"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetWin32Path([NativeTypeName("BSTR *")] ushort** pWin32Path)
    {
        return ((delegate* unmanaged<ITypeLibRegistration*, ushort**, int> )(lpVtbl[6]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pWin32Path);
    }

    /// <include file='ITypeLibRegistration.xml' path='doc/member[@name="ITypeLibRegistration.GetWin64Path"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetWin64Path([NativeTypeName("BSTR *")] ushort** pWin64Path)
    {
        return ((delegate* unmanaged<ITypeLibRegistration*, ushort**, int> )(lpVtbl[7]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pWin64Path);
    }

    /// <include file='ITypeLibRegistration.xml' path='doc/member[@name="ITypeLibRegistration.GetDisplayName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pDisplayName)
    {
        return ((delegate* unmanaged<ITypeLibRegistration*, ushort**, int> )(lpVtbl[8]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pDisplayName);
    }

    /// <include file='ITypeLibRegistration.xml' path='doc/member[@name="ITypeLibRegistration.GetFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFlags([NativeTypeName("DWORD *")] uint* pFlags)
    {
        return ((delegate* unmanaged<ITypeLibRegistration*, uint*, int> )(lpVtbl[9]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pFlags);
    }

    /// <include file='ITypeLibRegistration.xml' path='doc/member[@name="ITypeLibRegistration.GetHelpDir"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetHelpDir([NativeTypeName("BSTR *")] ushort** pHelpDir)
    {
        return ((delegate* unmanaged<ITypeLibRegistration*, ushort**, int> )(lpVtbl[10]))((ITypeLibRegistration*)Unsafe.AsPointer(ref this), pHelpDir);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetGuid(Guid* pGuid);
        [VtblIndex(4)]
        HRESULT GetVersion([NativeTypeName("BSTR *")] ushort** pVersion);
        [VtblIndex(5)]
        HRESULT GetLcid([NativeTypeName("LCID *")] uint* pLcid);
        [VtblIndex(6)]
        HRESULT GetWin32Path([NativeTypeName("BSTR *")] ushort** pWin32Path);
        [VtblIndex(7)]
        HRESULT GetWin64Path([NativeTypeName("BSTR *")] ushort** pWin64Path);
        [VtblIndex(8)]
        HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pDisplayName);
        [VtblIndex(9)]
        HRESULT GetFlags([NativeTypeName("DWORD *")] uint* pFlags);
        [VtblIndex(10)]
        HRESULT GetHelpDir([NativeTypeName("BSTR *")] ushort** pHelpDir);
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
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGuid;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetVersion;
        [NativeTypeName("HRESULT (LCID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLcid;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetWin32Path;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetWin64Path;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetFlags;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetHelpDir;
    }
}