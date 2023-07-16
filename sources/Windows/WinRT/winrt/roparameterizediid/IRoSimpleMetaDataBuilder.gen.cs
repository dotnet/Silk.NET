// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/roparameterizediid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.WinRT;
/// <include file='IRoSimpleMetaDataBuilder.xml' path='doc/member[@name="IRoSimpleMetaDataBuilder"]/*'/>
public unsafe partial struct IRoSimpleMetaDataBuilder : IRoSimpleMetaDataBuilder.Interface
{
    public void** lpVtbl;
    /// <include file='IRoSimpleMetaDataBuilder.xml' path='doc/member[@name="IRoSimpleMetaDataBuilder.SetWinRtInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT SetWinRtInterface(Guid iid)
    {
        return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, Guid, int> )(lpVtbl[0]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), iid);
    }

    /// <include file='IRoSimpleMetaDataBuilder.xml' path='doc/member[@name="IRoSimpleMetaDataBuilder.SetDelegate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT SetDelegate(Guid iid)
    {
        return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, Guid, int> )(lpVtbl[1]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), iid);
    }

    /// <include file='IRoSimpleMetaDataBuilder.xml' path='doc/member[@name="IRoSimpleMetaDataBuilder.SetInterfaceGroupSimpleDefault"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT SetInterfaceGroupSimpleDefault([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("PCWSTR")] ushort* defaultInterfaceName, [NativeTypeName("const GUID *")] Guid* defaultInterfaceIID)
    {
        return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, ushort*, ushort*, Guid*, int> )(lpVtbl[2]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), name, defaultInterfaceName, defaultInterfaceIID);
    }

    /// <include file='IRoSimpleMetaDataBuilder.xml' path='doc/member[@name="IRoSimpleMetaDataBuilder.SetInterfaceGroupParameterizedDefault"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInterfaceGroupParameterizedDefault([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("UINT32")] uint elementCount, [NativeTypeName("PCWSTR *")] ushort** defaultInterfaceNameElements)
    {
        return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, ushort*, uint, ushort**, int> )(lpVtbl[3]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), name, elementCount, defaultInterfaceNameElements);
    }

    /// <include file='IRoSimpleMetaDataBuilder.xml' path='doc/member[@name="IRoSimpleMetaDataBuilder.SetRuntimeClassSimpleDefault"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetRuntimeClassSimpleDefault([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("PCWSTR")] ushort* defaultInterfaceName, [NativeTypeName("const GUID *")] Guid* defaultInterfaceIID)
    {
        return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, ushort*, ushort*, Guid*, int> )(lpVtbl[4]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), name, defaultInterfaceName, defaultInterfaceIID);
    }

    /// <include file='IRoSimpleMetaDataBuilder.xml' path='doc/member[@name="IRoSimpleMetaDataBuilder.SetRuntimeClassParameterizedDefault"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetRuntimeClassParameterizedDefault([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("UINT32")] uint elementCount, [NativeTypeName("const PCWSTR *")] ushort** defaultInterfaceNameElements)
    {
        return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, ushort*, uint, ushort**, int> )(lpVtbl[5]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), name, elementCount, defaultInterfaceNameElements);
    }

    /// <include file='IRoSimpleMetaDataBuilder.xml' path='doc/member[@name="IRoSimpleMetaDataBuilder.SetStruct"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetStruct([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("UINT32")] uint numFields, [NativeTypeName("const PCWSTR *")] ushort** fieldTypeNames)
    {
        return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, ushort*, uint, ushort**, int> )(lpVtbl[6]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), name, numFields, fieldTypeNames);
    }

    /// <include file='IRoSimpleMetaDataBuilder.xml' path='doc/member[@name="IRoSimpleMetaDataBuilder.SetEnum"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetEnum([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("PCWSTR")] ushort* baseType)
    {
        return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, ushort*, ushort*, int> )(lpVtbl[7]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), name, baseType);
    }

    /// <include file='IRoSimpleMetaDataBuilder.xml' path='doc/member[@name="IRoSimpleMetaDataBuilder.SetParameterizedInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetParameterizedInterface(Guid piid, [NativeTypeName("UINT32")] uint numArgs)
    {
        return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, Guid, uint, int> )(lpVtbl[8]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), piid, numArgs);
    }

    /// <include file='IRoSimpleMetaDataBuilder.xml' path='doc/member[@name="IRoSimpleMetaDataBuilder.SetParameterizedDelegate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetParameterizedDelegate(Guid piid, [NativeTypeName("UINT32")] uint numArgs)
    {
        return ((delegate* unmanaged<IRoSimpleMetaDataBuilder*, Guid, uint, int> )(lpVtbl[9]))((IRoSimpleMetaDataBuilder*)Unsafe.AsPointer(ref this), piid, numArgs);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT SetWinRtInterface(Guid iid);
        [VtblIndex(1)]
        HRESULT SetDelegate(Guid iid);
        [VtblIndex(2)]
        HRESULT SetInterfaceGroupSimpleDefault([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("PCWSTR")] ushort* defaultInterfaceName, [NativeTypeName("const GUID *")] Guid* defaultInterfaceIID);
        [VtblIndex(3)]
        HRESULT SetInterfaceGroupParameterizedDefault([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("UINT32")] uint elementCount, [NativeTypeName("PCWSTR *")] ushort** defaultInterfaceNameElements);
        [VtblIndex(4)]
        HRESULT SetRuntimeClassSimpleDefault([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("PCWSTR")] ushort* defaultInterfaceName, [NativeTypeName("const GUID *")] Guid* defaultInterfaceIID);
        [VtblIndex(5)]
        HRESULT SetRuntimeClassParameterizedDefault([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("UINT32")] uint elementCount, [NativeTypeName("const PCWSTR *")] ushort** defaultInterfaceNameElements);
        [VtblIndex(6)]
        HRESULT SetStruct([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("UINT32")] uint numFields, [NativeTypeName("const PCWSTR *")] ushort** fieldTypeNames);
        [VtblIndex(7)]
        HRESULT SetEnum([NativeTypeName("PCWSTR")] ushort* name, [NativeTypeName("PCWSTR")] ushort* baseType);
        [VtblIndex(8)]
        HRESULT SetParameterizedInterface(Guid piid, [NativeTypeName("UINT32")] uint numArgs);
        [VtblIndex(9)]
        HRESULT SetParameterizedDelegate(Guid piid, [NativeTypeName("UINT32")] uint numArgs);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (GUID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> SetWinRtInterface;
        [NativeTypeName("HRESULT (GUID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> SetDelegate;
        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, const GUID *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, Guid*, int> SetInterfaceGroupSimpleDefault;
        [NativeTypeName("HRESULT (PCWSTR, UINT32, PCWSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort**, int> SetInterfaceGroupParameterizedDefault;
        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, const GUID *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, Guid*, int> SetRuntimeClassSimpleDefault;
        [NativeTypeName("HRESULT (PCWSTR, UINT32, const PCWSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort**, int> SetRuntimeClassParameterizedDefault;
        [NativeTypeName("HRESULT (PCWSTR, UINT32, const PCWSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort**, int> SetStruct;
        [NativeTypeName("HRESULT (PCWSTR, PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> SetEnum;
        [NativeTypeName("HRESULT (GUID, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, uint, int> SetParameterizedInterface;
        [NativeTypeName("HRESULT (GUID, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, uint, int> SetParameterizedDelegate;
    }
}