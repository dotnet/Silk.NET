// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IIMEServices.xml' path='doc/member[@name="IIMEServices"]/*'/>
[Guid("3050F6CA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IIMEServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IIMEServices : IIMEServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIMEServices));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIMEServices*, Guid*, void**, int> )(lpVtbl[0]))((IIMEServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IIMEServices*, uint> )(lpVtbl[1]))((IIMEServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIMEServices*, uint> )(lpVtbl[2]))((IIMEServices*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IIMEServices.xml' path='doc/member[@name="IIMEServices.GetActiveIMM"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetActiveIMM(IActiveIMMApp** ppActiveIMM)
    {
        return ((delegate* unmanaged<IIMEServices*, IActiveIMMApp**, int> )(lpVtbl[3]))((IIMEServices*)Unsafe.AsPointer(ref this), ppActiveIMM);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetActiveIMM(IActiveIMMApp** ppActiveIMM);
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
        [NativeTypeName("HRESULT (IActiveIMMApp **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IActiveIMMApp**, int> GetActiveIMM;
    }
}