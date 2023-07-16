// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxBlockMapFilesEnumerator.xml' path='doc/member[@name="IAppxBlockMapFilesEnumerator"]/*'/>
[Guid("02B856A2-4262-4070-BACB-1A8CBBC42305")]
[NativeTypeName("struct IAppxBlockMapFilesEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxBlockMapFilesEnumerator : IAppxBlockMapFilesEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBlockMapFilesEnumerator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBlockMapFilesEnumerator*, Guid*, void**, int> )(lpVtbl[0]))((IAppxBlockMapFilesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBlockMapFilesEnumerator*, uint> )(lpVtbl[1]))((IAppxBlockMapFilesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBlockMapFilesEnumerator*, uint> )(lpVtbl[2]))((IAppxBlockMapFilesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBlockMapFilesEnumerator.xml' path='doc/member[@name="IAppxBlockMapFilesEnumerator.GetCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxBlockMapFile** file)
    {
        return ((delegate* unmanaged<IAppxBlockMapFilesEnumerator*, IAppxBlockMapFile**, int> )(lpVtbl[3]))((IAppxBlockMapFilesEnumerator*)Unsafe.AsPointer(ref this), file);
    }

    /// <include file='IAppxBlockMapFilesEnumerator.xml' path='doc/member[@name="IAppxBlockMapFilesEnumerator.GetHasCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxBlockMapFilesEnumerator*, BOOL*, int> )(lpVtbl[4]))((IAppxBlockMapFilesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxBlockMapFilesEnumerator.xml' path='doc/member[@name="IAppxBlockMapFilesEnumerator.MoveNext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxBlockMapFilesEnumerator*, BOOL*, int> )(lpVtbl[5]))((IAppxBlockMapFilesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxBlockMapFile** file);
        [VtblIndex(4)]
        HRESULT GetHasCurrent(BOOL* hasCurrent);
        [VtblIndex(5)]
        HRESULT MoveNext(BOOL* hasCurrent);
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
        [NativeTypeName("HRESULT (IAppxBlockMapFile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxBlockMapFile**, int> GetCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}