// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IInitializeSpy.xml' path='doc/member[@name="IInitializeSpy"]/*'/>
[Guid("00000034-0000-0000-C000-000000000046")]
[NativeTypeName("struct IInitializeSpy : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInitializeSpy : IInitializeSpy.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInitializeSpy));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInitializeSpy*, Guid*, void**, int> )(lpVtbl[0]))((IInitializeSpy*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInitializeSpy*, uint> )(lpVtbl[1]))((IInitializeSpy*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInitializeSpy*, uint> )(lpVtbl[2]))((IInitializeSpy*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInitializeSpy.xml' path='doc/member[@name="IInitializeSpy.PreInitialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT PreInitialize([NativeTypeName("DWORD")] uint dwCoInit, [NativeTypeName("DWORD")] uint dwCurThreadAptRefs)
    {
        return ((delegate* unmanaged<IInitializeSpy*, uint, uint, int> )(lpVtbl[3]))((IInitializeSpy*)Unsafe.AsPointer(ref this), dwCoInit, dwCurThreadAptRefs);
    }

    /// <include file='IInitializeSpy.xml' path='doc/member[@name="IInitializeSpy.PostInitialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PostInitialize(HRESULT hrCoInit, [NativeTypeName("DWORD")] uint dwCoInit, [NativeTypeName("DWORD")] uint dwNewThreadAptRefs)
    {
        return ((delegate* unmanaged<IInitializeSpy*, HRESULT, uint, uint, int> )(lpVtbl[4]))((IInitializeSpy*)Unsafe.AsPointer(ref this), hrCoInit, dwCoInit, dwNewThreadAptRefs);
    }

    /// <include file='IInitializeSpy.xml' path='doc/member[@name="IInitializeSpy.PreUninitialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT PreUninitialize([NativeTypeName("DWORD")] uint dwCurThreadAptRefs)
    {
        return ((delegate* unmanaged<IInitializeSpy*, uint, int> )(lpVtbl[5]))((IInitializeSpy*)Unsafe.AsPointer(ref this), dwCurThreadAptRefs);
    }

    /// <include file='IInitializeSpy.xml' path='doc/member[@name="IInitializeSpy.PostUninitialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PostUninitialize([NativeTypeName("DWORD")] uint dwNewThreadAptRefs)
    {
        return ((delegate* unmanaged<IInitializeSpy*, uint, int> )(lpVtbl[6]))((IInitializeSpy*)Unsafe.AsPointer(ref this), dwNewThreadAptRefs);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT PreInitialize([NativeTypeName("DWORD")] uint dwCoInit, [NativeTypeName("DWORD")] uint dwCurThreadAptRefs);
        [VtblIndex(4)]
        HRESULT PostInitialize(HRESULT hrCoInit, [NativeTypeName("DWORD")] uint dwCoInit, [NativeTypeName("DWORD")] uint dwNewThreadAptRefs);
        [VtblIndex(5)]
        HRESULT PreUninitialize([NativeTypeName("DWORD")] uint dwCurThreadAptRefs);
        [VtblIndex(6)]
        HRESULT PostUninitialize([NativeTypeName("DWORD")] uint dwNewThreadAptRefs);
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
        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> PreInitialize;
        [NativeTypeName("HRESULT (HRESULT, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, uint, uint, int> PostInitialize;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> PreUninitialize;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> PostUninitialize;
    }
}