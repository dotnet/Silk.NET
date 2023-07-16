// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDirectManipulationCompositor.xml' path='doc/member[@name="IDirectManipulationCompositor"]/*'/>
[Guid("537A0825-0387-4EFA-B62F-71EB1F085A7E")]
[NativeTypeName("struct IDirectManipulationCompositor : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDirectManipulationCompositor : IDirectManipulationCompositor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationCompositor));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor*, Guid*, void**, int> )(lpVtbl[0]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor*, uint> )(lpVtbl[1]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor*, uint> )(lpVtbl[2]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectManipulationCompositor.xml' path='doc/member[@name="IDirectManipulationCompositor.AddContent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddContent(IDirectManipulationContent* content, IUnknown* device, IUnknown* parentVisual, IUnknown* childVisual)
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor*, IDirectManipulationContent*, IUnknown*, IUnknown*, IUnknown*, int> )(lpVtbl[3]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this), content, device, parentVisual, childVisual);
    }

    /// <include file='IDirectManipulationCompositor.xml' path='doc/member[@name="IDirectManipulationCompositor.RemoveContent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveContent(IDirectManipulationContent* content)
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor*, IDirectManipulationContent*, int> )(lpVtbl[4]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this), content);
    }

    /// <include file='IDirectManipulationCompositor.xml' path='doc/member[@name="IDirectManipulationCompositor.SetUpdateManager"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetUpdateManager(IDirectManipulationUpdateManager* updateManager)
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor*, IDirectManipulationUpdateManager*, int> )(lpVtbl[5]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this), updateManager);
    }

    /// <include file='IDirectManipulationCompositor.xml' path='doc/member[@name="IDirectManipulationCompositor.Flush"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor*, int> )(lpVtbl[6]))((IDirectManipulationCompositor*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddContent(IDirectManipulationContent* content, IUnknown* device, IUnknown* parentVisual, IUnknown* childVisual);
        [VtblIndex(4)]
        HRESULT RemoveContent(IDirectManipulationContent* content);
        [VtblIndex(5)]
        HRESULT SetUpdateManager(IDirectManipulationUpdateManager* updateManager);
        [VtblIndex(6)]
        HRESULT Flush();
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
        [NativeTypeName("HRESULT (IDirectManipulationContent *, IUnknown *, IUnknown *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationContent*, IUnknown*, IUnknown*, IUnknown*, int> AddContent;
        [NativeTypeName("HRESULT (IDirectManipulationContent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationContent*, int> RemoveContent;
        [NativeTypeName("HRESULT (IDirectManipulationUpdateManager *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationUpdateManager*, int> SetUpdateManager;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Flush;
    }
}