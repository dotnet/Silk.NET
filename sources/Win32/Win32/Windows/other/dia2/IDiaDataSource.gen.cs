// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79F1BB5F-B66E-48E5-B6A9-1545C323CA3D")]
[NativeTypeName("struct IDiaDataSource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaDataSource : IDiaDataSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaDataSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaDataSource, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaDataSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaDataSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_lastError([NativeTypeName("BSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IDiaDataSource, ushort**, int>)((*lpVtbl)[3]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT loadDataFromPdb([NativeTypeName("LPCOLESTR")] ushort* pdbPath)
    {
        return ((delegate* unmanaged<IDiaDataSource, ushort*, int>)((*lpVtbl)[4]))(this, pdbPath);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT loadAndValidateDataFromPdb(
        [NativeTypeName("LPCOLESTR")] ushort* pdbPath,
        Guid* pcsig70,
        [NativeTypeName("DWORD")] uint sig,
        [NativeTypeName("DWORD")] uint age
    )
    {
        return (
            (delegate* unmanaged<IDiaDataSource, ushort*, Guid*, uint, uint, int>)((*lpVtbl)[5])
        )(this, pdbPath, pcsig70, sig, age);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT loadDataForExe(
        [NativeTypeName("LPCOLESTR")] ushort* executable,
        [NativeTypeName("LPCOLESTR")] ushort* searchPath,
        IUnknown pCallback
    )
    {
        return (
            (delegate* unmanaged<IDiaDataSource, ushort*, ushort*, IUnknown, int>)((*lpVtbl)[6])
        )(this, executable, searchPath, pCallback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT loadDataFromIStream(IStream pIStream)
    {
        return ((delegate* unmanaged<IDiaDataSource, IStream, int>)((*lpVtbl)[7]))(this, pIStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT openSession(IDiaSession* ppSession)
    {
        return ((delegate* unmanaged<IDiaDataSource, IDiaSession*, int>)((*lpVtbl)[8]))(
            this,
            ppSession
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT loadDataFromCodeViewInfo(
        [NativeTypeName("LPCOLESTR")] ushort* executable,
        [NativeTypeName("LPCOLESTR")] ushort* searchPath,
        [NativeTypeName("DWORD")] uint cbCvInfo,
        byte* pbCvInfo,
        IUnknown pCallback
    )
    {
        return (
            (delegate* unmanaged<IDiaDataSource, ushort*, ushort*, uint, byte*, IUnknown, int>)(
                (*lpVtbl)[9]
            )
        )(this, executable, searchPath, cbCvInfo, pbCvInfo, pCallback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT loadDataFromMiscInfo(
        [NativeTypeName("LPCOLESTR")] ushort* executable,
        [NativeTypeName("LPCOLESTR")] ushort* searchPath,
        [NativeTypeName("DWORD")] uint timeStampExe,
        [NativeTypeName("DWORD")] uint timeStampDbg,
        [NativeTypeName("DWORD")] uint sizeOfExe,
        [NativeTypeName("DWORD")] uint cbMiscInfo,
        byte* pbMiscInfo,
        IUnknown pCallback
    )
    {
        return (
            (delegate* unmanaged<
                IDiaDataSource,
                ushort*,
                ushort*,
                uint,
                uint,
                uint,
                uint,
                byte*,
                IUnknown,
                int>)((*lpVtbl)[10])
        )(
            this,
            executable,
            searchPath,
            timeStampExe,
            timeStampDbg,
            sizeOfExe,
            cbMiscInfo,
            pbMiscInfo,
            pCallback
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_lastError([NativeTypeName("BSTR *")] ushort** pRetVal);

        [VtblIndex(4)]
        HRESULT loadDataFromPdb([NativeTypeName("LPCOLESTR")] ushort* pdbPath);

        [VtblIndex(5)]
        HRESULT loadAndValidateDataFromPdb(
            [NativeTypeName("LPCOLESTR")] ushort* pdbPath,
            Guid* pcsig70,
            [NativeTypeName("DWORD")] uint sig,
            [NativeTypeName("DWORD")] uint age
        );

        [VtblIndex(6)]
        HRESULT loadDataForExe(
            [NativeTypeName("LPCOLESTR")] ushort* executable,
            [NativeTypeName("LPCOLESTR")] ushort* searchPath,
            IUnknown pCallback
        );

        [VtblIndex(7)]
        HRESULT loadDataFromIStream(IStream pIStream);

        [VtblIndex(8)]
        HRESULT openSession(IDiaSession* ppSession);

        [VtblIndex(9)]
        HRESULT loadDataFromCodeViewInfo(
            [NativeTypeName("LPCOLESTR")] ushort* executable,
            [NativeTypeName("LPCOLESTR")] ushort* searchPath,
            [NativeTypeName("DWORD")] uint cbCvInfo,
            byte* pbCvInfo,
            IUnknown pCallback
        );

        [VtblIndex(10)]
        HRESULT loadDataFromMiscInfo(
            [NativeTypeName("LPCOLESTR")] ushort* executable,
            [NativeTypeName("LPCOLESTR")] ushort* searchPath,
            [NativeTypeName("DWORD")] uint timeStampExe,
            [NativeTypeName("DWORD")] uint timeStampDbg,
            [NativeTypeName("DWORD")] uint sizeOfExe,
            [NativeTypeName("DWORD")] uint cbMiscInfo,
            byte* pbMiscInfo,
            IUnknown pCallback
        );
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_lastError;

        [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> loadDataFromPdb;

        [NativeTypeName("HRESULT (LPCOLESTR, GUID *, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            Guid*,
            uint,
            uint,
            int> loadAndValidateDataFromPdb;

        [NativeTypeName("HRESULT (LPCOLESTR, LPCOLESTR, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IUnknown, int> loadDataForExe;

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int> loadDataFromIStream;

        [NativeTypeName("HRESULT (IDiaSession **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaSession*, int> openSession;

        [NativeTypeName(
            "HRESULT (LPCOLESTR, LPCOLESTR, DWORD, BYTE *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            uint,
            byte*,
            IUnknown,
            int> loadDataFromCodeViewInfo;

        [NativeTypeName(
            "HRESULT (LPCOLESTR, LPCOLESTR, DWORD, DWORD, DWORD, DWORD, BYTE *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            uint,
            uint,
            uint,
            uint,
            byte*,
            IUnknown,
            int> loadDataFromMiscInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaDataSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaDataSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaDataSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaDataSource(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaDataSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaDataSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaDataSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaDataSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
