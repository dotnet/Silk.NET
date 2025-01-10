// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D7FE3D77-68BC-4D4A-851F-EEC9FB68017C")]
public unsafe partial struct IScriptMapInfo : IScriptMapInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IScriptMapInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetPath()
    {
        return ((delegate* unmanaged<IScriptMapInfo*, ushort*>)((*lpVtbl)[0]))(
            (IScriptMapInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCSTR")]
    public sbyte* GetAllowedVerbs()
    {
        return ((delegate* unmanaged<IScriptMapInfo*, sbyte*>)((*lpVtbl)[1]))(
            (IScriptMapInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetModules([NativeTypeName("DWORD *")] uint* pcchModules = null)
    {
        return ((delegate* unmanaged<IScriptMapInfo*, uint*, ushort*>)((*lpVtbl)[2]))(
            (IScriptMapInfo*)Unsafe.AsPointer(ref this),
            pcchModules
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetScriptProcessor([NativeTypeName("DWORD *")] uint* pcchScriptProcessor = null)
    {
        return ((delegate* unmanaged<IScriptMapInfo*, uint*, ushort*>)((*lpVtbl)[3]))(
            (IScriptMapInfo*)Unsafe.AsPointer(ref this),
            pcchScriptProcessor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetManagedType([NativeTypeName("DWORD *")] uint* pcchManagedType = null)
    {
        return ((delegate* unmanaged<IScriptMapInfo*, uint*, ushort*>)((*lpVtbl)[4]))(
            (IScriptMapInfo*)Unsafe.AsPointer(ref this),
            pcchManagedType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public BOOL GetAllowPathInfoForScriptMappings()
    {
        return ((delegate* unmanaged<IScriptMapInfo*, int>)((*lpVtbl)[5]))(
            (IScriptMapInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("DWORD")]
    public uint GetRequiredAccess()
    {
        return ((delegate* unmanaged<IScriptMapInfo*, uint>)((*lpVtbl)[6]))(
            (IScriptMapInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("DWORD")]
    public uint GetResourceType()
    {
        return ((delegate* unmanaged<IScriptMapInfo*, uint>)((*lpVtbl)[7]))(
            (IScriptMapInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public BOOL GetIsStarScriptMap()
    {
        return ((delegate* unmanaged<IScriptMapInfo*, int>)((*lpVtbl)[8]))(
            (IScriptMapInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("DWORD")]
    public uint GetResponseBufferLimit()
    {
        return ((delegate* unmanaged<IScriptMapInfo*, uint>)((*lpVtbl)[9]))(
            (IScriptMapInfo*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetName()
    {
        return ((delegate* unmanaged<IScriptMapInfo*, ushort*>)((*lpVtbl)[10]))(
            (IScriptMapInfo*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetPath();

        [VtblIndex(1)]
        [return: NativeTypeName("PCSTR")]
        sbyte* GetAllowedVerbs();

        [VtblIndex(2)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetModules([NativeTypeName("DWORD *")] uint* pcchModules = null);

        [VtblIndex(3)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetScriptProcessor([NativeTypeName("DWORD *")] uint* pcchScriptProcessor = null);

        [VtblIndex(4)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetManagedType([NativeTypeName("DWORD *")] uint* pcchManagedType = null);

        [VtblIndex(5)]
        BOOL GetAllowPathInfoForScriptMappings();

        [VtblIndex(6)]
        [return: NativeTypeName("DWORD")]
        uint GetRequiredAccess();

        [VtblIndex(7)]
        [return: NativeTypeName("DWORD")]
        uint GetResourceType();

        [VtblIndex(8)]
        BOOL GetIsStarScriptMap();

        [VtblIndex(9)]
        [return: NativeTypeName("DWORD")]
        uint GetResponseBufferLimit();

        [VtblIndex(10)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetName();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetPath;

        [NativeTypeName("PCSTR () const")]
        public delegate* unmanaged<TSelf*, sbyte*> GetAllowedVerbs;

        [NativeTypeName("PCWSTR (DWORD *) const")]
        public delegate* unmanaged<TSelf*, uint*, ushort*> GetModules;

        [NativeTypeName("PCWSTR (DWORD *) const")]
        public delegate* unmanaged<TSelf*, uint*, ushort*> GetScriptProcessor;

        [NativeTypeName("PCWSTR (DWORD *) const")]
        public delegate* unmanaged<TSelf*, uint*, ushort*> GetManagedType;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> GetAllowPathInfoForScriptMappings;

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged<TSelf*, uint> GetRequiredAccess;

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged<TSelf*, uint> GetResourceType;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> GetIsStarScriptMap;

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged<TSelf*, uint> GetResponseBufferLimit;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetName;
    }
}
