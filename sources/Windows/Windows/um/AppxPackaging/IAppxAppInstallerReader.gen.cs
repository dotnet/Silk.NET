// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxAppInstallerReader.xml' path='doc/member[@name="IAppxAppInstallerReader"]/*'/>
[Guid("F35BC38C-1D2F-43DB-A1F4-586430D1FED2")]
[NativeTypeName("struct IAppxAppInstallerReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxAppInstallerReader : IAppxAppInstallerReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxAppInstallerReader));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxAppInstallerReader*, Guid*, void**, int> )(lpVtbl[0]))((IAppxAppInstallerReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxAppInstallerReader*, uint> )(lpVtbl[1]))((IAppxAppInstallerReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxAppInstallerReader*, uint> )(lpVtbl[2]))((IAppxAppInstallerReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxAppInstallerReader.xml' path='doc/member[@name="IAppxAppInstallerReader.GetXmlDom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetXmlDom(IXMLDOMDocument** dom)
    {
        return ((delegate* unmanaged<IAppxAppInstallerReader*, IXMLDOMDocument**, int> )(lpVtbl[3]))((IAppxAppInstallerReader*)Unsafe.AsPointer(ref this), dom);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetXmlDom(IXMLDOMDocument** dom);
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
        [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMDocument**, int> GetXmlDom;
    }
}