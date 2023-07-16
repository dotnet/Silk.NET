// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFPMPHostApp.xml' path='doc/member[@name="IMFPMPHostApp"]/*'/>
[Guid("84D2054A-3AA1-4728-A3B0-440A418CF49C")]
[NativeTypeName("struct IMFPMPHostApp : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFPMPHostApp : IMFPMPHostApp.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFPMPHostApp));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFPMPHostApp*, Guid*, void**, int> )(lpVtbl[0]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFPMPHostApp*, uint> )(lpVtbl[1]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFPMPHostApp*, uint> )(lpVtbl[2]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFPMPHostApp.xml' path='doc/member[@name="IMFPMPHostApp.LockProcess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LockProcess()
    {
        return ((delegate* unmanaged<IMFPMPHostApp*, int> )(lpVtbl[3]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFPMPHostApp.xml' path='doc/member[@name="IMFPMPHostApp.UnlockProcess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnlockProcess()
    {
        return ((delegate* unmanaged<IMFPMPHostApp*, int> )(lpVtbl[4]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFPMPHostApp.xml' path='doc/member[@name="IMFPMPHostApp.ActivateClassById"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ActivateClassById([NativeTypeName("LPCWSTR")] ushort* id, IStream* pStream, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IMFPMPHostApp*, ushort*, IStream*, Guid*, void**, int> )(lpVtbl[5]))((IMFPMPHostApp*)Unsafe.AsPointer(ref this), id, pStream, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LockProcess();
        [VtblIndex(4)]
        HRESULT UnlockProcess();
        [VtblIndex(5)]
        HRESULT ActivateClassById([NativeTypeName("LPCWSTR")] ushort* id, IStream* pStream, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LockProcess;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockProcess;
        [NativeTypeName("HRESULT (LPCWSTR, IStream *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IStream*, Guid*, void**, int> ActivateClassById;
    }
}