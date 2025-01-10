// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000010-0000-0000-C000-000000000046")]
[NativeTypeName("struct IRunningObjectTable : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRunningObjectTable : IRunningObjectTable.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRunningObjectTable));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRunningObjectTable, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRunningObjectTable, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRunningObjectTable, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Register(
        [NativeTypeName("DWORD")] uint grfFlags,
        IUnknown punkObject,
        IMoniker pmkObjectName,
        [NativeTypeName("DWORD *")] uint* pdwRegister
    )
    {
        return (
            (delegate* unmanaged<IRunningObjectTable, uint, IUnknown, IMoniker, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, grfFlags, punkObject, pmkObjectName, pdwRegister);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Revoke([NativeTypeName("DWORD")] uint dwRegister)
    {
        return ((delegate* unmanaged<IRunningObjectTable, uint, int>)((*lpVtbl)[4]))(
            this,
            dwRegister
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsRunning(IMoniker pmkObjectName)
    {
        return ((delegate* unmanaged<IRunningObjectTable, IMoniker, int>)((*lpVtbl)[5]))(
            this,
            pmkObjectName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetObject(IMoniker pmkObjectName, IUnknown* ppunkObject)
    {
        return ((delegate* unmanaged<IRunningObjectTable, IMoniker, IUnknown*, int>)((*lpVtbl)[6]))(
            this,
            pmkObjectName,
            ppunkObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT NoteChangeTime([NativeTypeName("DWORD")] uint dwRegister, FILETIME* pfiletime)
    {
        return ((delegate* unmanaged<IRunningObjectTable, uint, FILETIME*, int>)((*lpVtbl)[7]))(
            this,
            dwRegister,
            pfiletime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTimeOfLastChange(IMoniker pmkObjectName, FILETIME* pfiletime)
    {
        return ((delegate* unmanaged<IRunningObjectTable, IMoniker, FILETIME*, int>)((*lpVtbl)[8]))(
            this,
            pmkObjectName,
            pfiletime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnumRunning(IEnumMoniker* ppenumMoniker)
    {
        return ((delegate* unmanaged<IRunningObjectTable, IEnumMoniker*, int>)((*lpVtbl)[9]))(
            this,
            ppenumMoniker
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Register(
            [NativeTypeName("DWORD")] uint grfFlags,
            IUnknown punkObject,
            IMoniker pmkObjectName,
            [NativeTypeName("DWORD *")] uint* pdwRegister
        );

        [VtblIndex(4)]
        HRESULT Revoke([NativeTypeName("DWORD")] uint dwRegister);

        [VtblIndex(5)]
        HRESULT IsRunning(IMoniker pmkObjectName);

        [VtblIndex(6)]
        HRESULT GetObject(IMoniker pmkObjectName, IUnknown* ppunkObject);

        [VtblIndex(7)]
        HRESULT NoteChangeTime([NativeTypeName("DWORD")] uint dwRegister, FILETIME* pfiletime);

        [VtblIndex(8)]
        HRESULT GetTimeOfLastChange(IMoniker pmkObjectName, FILETIME* pfiletime);

        [VtblIndex(9)]
        HRESULT EnumRunning(IEnumMoniker* ppenumMoniker);
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

        [NativeTypeName(
            "HRESULT (DWORD, IUnknown *, IMoniker *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IUnknown, IMoniker, uint*, int> Register;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Revoke;

        [NativeTypeName("HRESULT (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker, int> IsRunning;

        [NativeTypeName("HRESULT (IMoniker *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker, IUnknown*, int> GetObject;

        [NativeTypeName("HRESULT (DWORD, FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, FILETIME*, int> NoteChangeTime;

        [NativeTypeName("HRESULT (IMoniker *, FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker, FILETIME*, int> GetTimeOfLastChange;

        [NativeTypeName("HRESULT (IEnumMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumMoniker*, int> EnumRunning;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRunningObjectTable"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRunningObjectTable(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRunningObjectTable"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRunningObjectTable(Silk.NET.Windows.IUnknown value)
    {
        return new IRunningObjectTable(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRunningObjectTable"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRunningObjectTable"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRunningObjectTable value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
