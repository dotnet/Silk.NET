// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IScriptEventHandlerSourceInfo.xml' path='doc/member[@name="IScriptEventHandlerSourceInfo"]/*'/>
[Guid("30510841-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IScriptEventHandlerSourceInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IScriptEventHandlerSourceInfo : IScriptEventHandlerSourceInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IScriptEventHandlerSourceInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IScriptEventHandlerSourceInfo*, Guid*, void**, int> )(lpVtbl[0]))((IScriptEventHandlerSourceInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IScriptEventHandlerSourceInfo*, uint> )(lpVtbl[1]))((IScriptEventHandlerSourceInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IScriptEventHandlerSourceInfo*, uint> )(lpVtbl[2]))((IScriptEventHandlerSourceInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IScriptEventHandlerSourceInfo.xml' path='doc/member[@name="IScriptEventHandlerSourceInfo.GetSourceInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSourceInfo([NativeTypeName("BSTR *")] ushort** pbstrFunctionName, [NativeTypeName("UINT32 *")] uint* line, [NativeTypeName("UINT32 *")] uint* column, [NativeTypeName("UINT32 *")] uint* cchLength)
    {
        return ((delegate* unmanaged<IScriptEventHandlerSourceInfo*, ushort**, uint*, uint*, uint*, int> )(lpVtbl[3]))((IScriptEventHandlerSourceInfo*)Unsafe.AsPointer(ref this), pbstrFunctionName, line, column, cchLength);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSourceInfo([NativeTypeName("BSTR *")] ushort** pbstrFunctionName, [NativeTypeName("UINT32 *")] uint* line, [NativeTypeName("UINT32 *")] uint* column, [NativeTypeName("UINT32 *")] uint* cchLength);
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
        [NativeTypeName("HRESULT (BSTR *, UINT32 *, UINT32 *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, uint*, uint*, int> GetSourceInfo;
    }
}