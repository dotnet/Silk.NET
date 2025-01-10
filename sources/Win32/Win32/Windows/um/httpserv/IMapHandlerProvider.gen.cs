// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FEA3CE6B-E346-47E7-B2A6-AD265BAEFF2C")]
[NativeTypeName("struct IMapHandlerProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IMapHandlerProvider : IMapHandlerProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMapHandlerProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged<IMapHandlerProvider*, HRESULT, void>)((*lpVtbl)[0]))(
            (IMapHandlerProvider*)Unsafe.AsPointer(ref this),
            hrError
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public HRESULT SetScriptName(
        [NativeTypeName("PCWSTR")] ushort* pszScriptName,
        [NativeTypeName("DWORD")] uint cchScriptName
    )
    {
        return ((delegate* unmanaged<IMapHandlerProvider*, ushort*, uint, int>)((*lpVtbl)[1]))(
            (IMapHandlerProvider*)Unsafe.AsPointer(ref this),
            pszScriptName,
            cchScriptName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public void SetScriptMap(IScriptMapInfo* pScriptMap)
    {
        ((delegate* unmanaged<IMapHandlerProvider*, IScriptMapInfo*, void>)((*lpVtbl)[2]))(
            (IMapHandlerProvider*)Unsafe.AsPointer(ref this),
            pScriptMap
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetFileInfo(IHttpFileInfo* pFileInfo)
    {
        ((delegate* unmanaged<IMapHandlerProvider*, IHttpFileInfo*, void>)((*lpVtbl)[3]))(
            (IMapHandlerProvider*)Unsafe.AsPointer(ref this),
            pFileInfo
        );
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        HRESULT SetScriptName(
            [NativeTypeName("PCWSTR")] ushort* pszScriptName,
            [NativeTypeName("DWORD")] uint cchScriptName
        );

        [VtblIndex(2)]
        void SetScriptMap(IScriptMapInfo* pScriptMap);

        [VtblIndex(3)]
        void SetFileInfo(IHttpFileInfo* pFileInfo);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("HRESULT (PCWSTR, DWORD)")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetScriptName;

        [NativeTypeName("void (IScriptMapInfo *)")]
        public delegate* unmanaged<TSelf*, IScriptMapInfo*, void> SetScriptMap;

        [NativeTypeName("void (IHttpFileInfo *)")]
        public delegate* unmanaged<TSelf*, IHttpFileInfo*, void> SetFileInfo;
    }
}
