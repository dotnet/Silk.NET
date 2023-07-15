// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxBlockMapReader.xml' path='doc/member[@name="IAppxBlockMapReader"]/*'/>
[Guid("5EFEC991-BCA3-42D1-9EC2-E92D609EC22A")]
[NativeTypeName("struct IAppxBlockMapReader : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxBlockMapReader : IAppxBlockMapReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBlockMapReader));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBlockMapReader*, Guid*, void**, int> )(lpVtbl[0]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBlockMapReader*, uint> )(lpVtbl[1]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBlockMapReader*, uint> )(lpVtbl[2]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBlockMapReader.xml' path='doc/member[@name="IAppxBlockMapReader.GetFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFile([NativeTypeName("LPCWSTR")] ushort* filename, IAppxBlockMapFile** file)
    {
        return ((delegate* unmanaged<IAppxBlockMapReader*, ushort*, IAppxBlockMapFile**, int> )(lpVtbl[3]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this), filename, file);
    }

    /// <include file='IAppxBlockMapReader.xml' path='doc/member[@name="IAppxBlockMapReader.GetFiles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFiles(IAppxBlockMapFilesEnumerator** enumerator)
    {
        return ((delegate* unmanaged<IAppxBlockMapReader*, IAppxBlockMapFilesEnumerator**, int> )(lpVtbl[4]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this), enumerator);
    }

    /// <include file='IAppxBlockMapReader.xml' path='doc/member[@name="IAppxBlockMapReader.GetHashMethod"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetHashMethod(IUri** hashMethod)
    {
        return ((delegate* unmanaged<IAppxBlockMapReader*, IUri**, int> )(lpVtbl[5]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this), hashMethod);
    }

    /// <include file='IAppxBlockMapReader.xml' path='doc/member[@name="IAppxBlockMapReader.GetStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStream(IStream** blockMapStream)
    {
        return ((delegate* unmanaged<IAppxBlockMapReader*, IStream**, int> )(lpVtbl[6]))((IAppxBlockMapReader*)Unsafe.AsPointer(ref this), blockMapStream);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFile([NativeTypeName("LPCWSTR")] ushort* filename, IAppxBlockMapFile** file);
        [VtblIndex(4)]
        HRESULT GetFiles(IAppxBlockMapFilesEnumerator** enumerator);
        [VtblIndex(5)]
        HRESULT GetHashMethod(IUri** hashMethod);
        [VtblIndex(6)]
        HRESULT GetStream(IStream** blockMapStream);
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
        [NativeTypeName("HRESULT (LPCWSTR, IAppxBlockMapFile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IAppxBlockMapFile**, int> GetFile;
        [NativeTypeName("HRESULT (IAppxBlockMapFilesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxBlockMapFilesEnumerator**, int> GetFiles;
        [NativeTypeName("HRESULT (IUri **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUri**, int> GetHashMethod;
        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream**, int> GetStream;
    }
}