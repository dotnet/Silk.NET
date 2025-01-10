// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000034-0000-0000-C000-000000000046")]
[NativeTypeName("struct IInitializeSpy : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInitializeSpy : IInitializeSpy.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInitializeSpy));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInitializeSpy, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInitializeSpy, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInitializeSpy, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT PreInitialize(
        [NativeTypeName("DWORD")] uint dwCoInit,
        [NativeTypeName("DWORD")] uint dwCurThreadAptRefs
    )
    {
        return ((delegate* unmanaged<IInitializeSpy, uint, uint, int>)((*lpVtbl)[3]))(
            this,
            dwCoInit,
            dwCurThreadAptRefs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PostInitialize(
        HRESULT hrCoInit,
        [NativeTypeName("DWORD")] uint dwCoInit,
        [NativeTypeName("DWORD")] uint dwNewThreadAptRefs
    )
    {
        return ((delegate* unmanaged<IInitializeSpy, HRESULT, uint, uint, int>)((*lpVtbl)[4]))(
            this,
            hrCoInit,
            dwCoInit,
            dwNewThreadAptRefs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT PreUninitialize([NativeTypeName("DWORD")] uint dwCurThreadAptRefs)
    {
        return ((delegate* unmanaged<IInitializeSpy, uint, int>)((*lpVtbl)[5]))(
            this,
            dwCurThreadAptRefs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT PostUninitialize([NativeTypeName("DWORD")] uint dwNewThreadAptRefs)
    {
        return ((delegate* unmanaged<IInitializeSpy, uint, int>)((*lpVtbl)[6]))(
            this,
            dwNewThreadAptRefs
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT PreInitialize(
            [NativeTypeName("DWORD")] uint dwCoInit,
            [NativeTypeName("DWORD")] uint dwCurThreadAptRefs
        );

        [VtblIndex(4)]
        HRESULT PostInitialize(
            HRESULT hrCoInit,
            [NativeTypeName("DWORD")] uint dwCoInit,
            [NativeTypeName("DWORD")] uint dwNewThreadAptRefs
        );

        [VtblIndex(5)]
        HRESULT PreUninitialize([NativeTypeName("DWORD")] uint dwCurThreadAptRefs);

        [VtblIndex(6)]
        HRESULT PostUninitialize([NativeTypeName("DWORD")] uint dwNewThreadAptRefs);
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

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> PreInitialize;

        [NativeTypeName("HRESULT (HRESULT, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, uint, uint, int> PostInitialize;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> PreUninitialize;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> PostUninitialize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInitializeSpy"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInitializeSpy(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInitializeSpy"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInitializeSpy(Silk.NET.Windows.IUnknown value)
    {
        return new IInitializeSpy(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInitializeSpy"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInitializeSpy"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInitializeSpy value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
