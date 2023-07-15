// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISurrogate.xml' path='doc/member[@name="ISurrogate"]/*'/>
[Guid("00000022-0000-0000-C000-000000000046")]
[NativeTypeName("struct ISurrogate : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISurrogate : ISurrogate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISurrogate));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISurrogate*, Guid*, void**, int> )(lpVtbl[0]))((ISurrogate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISurrogate*, uint> )(lpVtbl[1]))((ISurrogate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISurrogate*, uint> )(lpVtbl[2]))((ISurrogate*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISurrogate.xml' path='doc/member[@name="ISurrogate.LoadDllServer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LoadDllServer([NativeTypeName("const IID &")] Guid* Clsid)
    {
        return ((delegate* unmanaged<ISurrogate*, Guid*, int> )(lpVtbl[3]))((ISurrogate*)Unsafe.AsPointer(ref this), Clsid);
    }

    /// <include file='ISurrogate.xml' path='doc/member[@name="ISurrogate.FreeSurrogate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT FreeSurrogate()
    {
        return ((delegate* unmanaged<ISurrogate*, int> )(lpVtbl[4]))((ISurrogate*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LoadDllServer([NativeTypeName("const IID &")] Guid* Clsid);
        [VtblIndex(4)]
        HRESULT FreeSurrogate();
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
        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> LoadDllServer;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FreeSurrogate;
    }
}