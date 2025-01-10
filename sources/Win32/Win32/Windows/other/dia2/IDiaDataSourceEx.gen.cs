// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1A21EB69-962A-4BC4-8BD3-681797D38B23")]
[NativeTypeName("struct IDiaDataSourceEx : IDiaDataSource")]
[NativeInheritance("IDiaDataSource")]
public unsafe partial struct IDiaDataSourceEx : IDiaDataSourceEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaDataSourceEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaDataSourceEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaDataSourceEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaDataSourceEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_lastError([NativeTypeName("BSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IDiaDataSourceEx, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT loadDataFromPdb([NativeTypeName("LPCOLESTR")] ushort* pdbPath)
    {
        return ((delegate* unmanaged<IDiaDataSourceEx, ushort*, int>)((*lpVtbl)[4]))(this, pdbPath);
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
            (delegate* unmanaged<IDiaDataSourceEx, ushort*, Guid*, uint, uint, int>)((*lpVtbl)[5])
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
            (delegate* unmanaged<IDiaDataSourceEx, ushort*, ushort*, IUnknown, int>)((*lpVtbl)[6])
        )(this, executable, searchPath, pCallback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT loadDataFromIStream(IStream pIStream)
    {
        return ((delegate* unmanaged<IDiaDataSourceEx, IStream, int>)((*lpVtbl)[7]))(
            this,
            pIStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT openSession(IDiaSession* ppSession)
    {
        return ((delegate* unmanaged<IDiaDataSourceEx, IDiaSession*, int>)((*lpVtbl)[8]))(
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
            (delegate* unmanaged<IDiaDataSourceEx, ushort*, ushort*, uint, byte*, IUnknown, int>)(
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
                IDiaDataSourceEx,
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT loadDataFromPdbEx(
        [NativeTypeName("LPCOLESTR")] ushort* pdbPath,
        BOOL fPdbPrefetching
    )
    {
        return ((delegate* unmanaged<IDiaDataSourceEx, ushort*, BOOL, int>)((*lpVtbl)[11]))(
            this,
            pdbPath,
            fPdbPrefetching
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT loadAndValidateDataFromPdbEx(
        [NativeTypeName("LPCOLESTR")] ushort* pdbPath,
        Guid* pcsig70,
        [NativeTypeName("DWORD")] uint sig,
        [NativeTypeName("DWORD")] uint age,
        BOOL fPdbPrefetching
    )
    {
        return (
            (delegate* unmanaged<IDiaDataSourceEx, ushort*, Guid*, uint, uint, BOOL, int>)(
                (*lpVtbl)[12]
            )
        )(this, pdbPath, pcsig70, sig, age, fPdbPrefetching);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT loadDataForExeEx(
        [NativeTypeName("LPCOLESTR")] ushort* executable,
        [NativeTypeName("LPCOLESTR")] ushort* searchPath,
        IUnknown pCallback,
        BOOL fPdbPrefetching
    )
    {
        return (
            (delegate* unmanaged<IDiaDataSourceEx, ushort*, ushort*, IUnknown, BOOL, int>)(
                (*lpVtbl)[13]
            )
        )(this, executable, searchPath, pCallback, fPdbPrefetching);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT loadDataFromIStreamEx(IStream pIStream, BOOL fPdbPrefetching)
    {
        return ((delegate* unmanaged<IDiaDataSourceEx, IStream, BOOL, int>)((*lpVtbl)[14]))(
            this,
            pIStream,
            fPdbPrefetching
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT getStreamSize(
        [NativeTypeName("LPCOLESTR")] ushort* stream,
        [NativeTypeName("ULONGLONG *")] ulong* pcb
    )
    {
        return ((delegate* unmanaged<IDiaDataSourceEx, ushort*, ulong*, int>)((*lpVtbl)[15]))(
            this,
            stream,
            pcb
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT getStreamRawData(
        [NativeTypeName("LPCOLESTR")] ushort* stream,
        [NativeTypeName("ULONGLONG")] ulong cbOffset,
        [NativeTypeName("ULONGLONG")] ulong cbRead,
        [NativeTypeName("ULONGLONG *")] ulong* pcbRead,
        byte* pbData
    )
    {
        return (
            (delegate* unmanaged<IDiaDataSourceEx, ushort*, ulong, ulong, ulong*, byte*, int>)(
                (*lpVtbl)[16]
            )
        )(this, stream, cbOffset, cbRead, pcbRead, pbData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT setPfnMiniPDBErrorCallback2(
        void* pvContext,
        [NativeTypeName("PFNMINIPDBERRORCALLBACK2")]
            delegate* unmanaged<void*, uint, ushort*, ushort*, HRESULT> pfn
    )
    {
        return (
            (delegate* unmanaged<
                IDiaDataSourceEx,
                void*,
                delegate* unmanaged<void*, uint, ushort*, ushort*, HRESULT>,
                int>)((*lpVtbl)[17])
        )(this, pvContext, pfn);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ValidatePdb(
        [NativeTypeName("LPCOLESTR")] ushort* pdbPath,
        [NativeTypeName("const GUID *")] Guid* pcsig70,
        [NativeTypeName("DWORD")] uint sig,
        [NativeTypeName("DWORD")] uint age,
        BOOL* pfStripped
    )
    {
        return (
            (delegate* unmanaged<IDiaDataSourceEx, ushort*, Guid*, uint, uint, BOOL*, int>)(
                (*lpVtbl)[18]
            )
        )(this, pdbPath, pcsig70, sig, age, pfStripped);
    }

    public interface Interface : IDiaDataSource.Interface
    {
        [VtblIndex(11)]
        HRESULT loadDataFromPdbEx(
            [NativeTypeName("LPCOLESTR")] ushort* pdbPath,
            BOOL fPdbPrefetching
        );

        [VtblIndex(12)]
        HRESULT loadAndValidateDataFromPdbEx(
            [NativeTypeName("LPCOLESTR")] ushort* pdbPath,
            Guid* pcsig70,
            [NativeTypeName("DWORD")] uint sig,
            [NativeTypeName("DWORD")] uint age,
            BOOL fPdbPrefetching
        );

        [VtblIndex(13)]
        HRESULT loadDataForExeEx(
            [NativeTypeName("LPCOLESTR")] ushort* executable,
            [NativeTypeName("LPCOLESTR")] ushort* searchPath,
            IUnknown pCallback,
            BOOL fPdbPrefetching
        );

        [VtblIndex(14)]
        HRESULT loadDataFromIStreamEx(IStream pIStream, BOOL fPdbPrefetching);

        [VtblIndex(15)]
        HRESULT getStreamSize(
            [NativeTypeName("LPCOLESTR")] ushort* stream,
            [NativeTypeName("ULONGLONG *")] ulong* pcb
        );

        [VtblIndex(16)]
        HRESULT getStreamRawData(
            [NativeTypeName("LPCOLESTR")] ushort* stream,
            [NativeTypeName("ULONGLONG")] ulong cbOffset,
            [NativeTypeName("ULONGLONG")] ulong cbRead,
            [NativeTypeName("ULONGLONG *")] ulong* pcbRead,
            byte* pbData
        );

        [VtblIndex(18)]
        HRESULT ValidatePdb(
            [NativeTypeName("LPCOLESTR")] ushort* pdbPath,
            [NativeTypeName("const GUID *")] Guid* pcsig70,
            [NativeTypeName("DWORD")] uint sig,
            [NativeTypeName("DWORD")] uint age,
            BOOL* pfStripped
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

        [NativeTypeName("HRESULT (LPCOLESTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL, int> loadDataFromPdbEx;

        [NativeTypeName("HRESULT (LPCOLESTR, GUID *, DWORD, DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            Guid*,
            uint,
            uint,
            BOOL,
            int> loadAndValidateDataFromPdbEx;

        [NativeTypeName(
            "HRESULT (LPCOLESTR, LPCOLESTR, IUnknown *, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IUnknown, BOOL, int> loadDataForExeEx;

        [NativeTypeName("HRESULT (IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, BOOL, int> loadDataFromIStreamEx;

        [NativeTypeName("HRESULT (LPCOLESTR, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ulong*, int> getStreamSize;

        [NativeTypeName(
            "HRESULT (LPCOLESTR, ULONGLONG, ULONGLONG, ULONGLONG *, BYTE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ulong,
            ulong,
            ulong*,
            byte*,
            int> getStreamRawData;

        [NativeTypeName("HRESULT (void *, PFNMINIPDBERRORCALLBACK2) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            void*,
            delegate* unmanaged<void*, uint, ushort*, ushort*, HRESULT>,
            int> setPfnMiniPDBErrorCallback2;

        [NativeTypeName(
            "HRESULT (LPCOLESTR, const GUID *, DWORD, DWORD, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, uint, uint, BOOL*, int> ValidatePdb;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaDataSourceEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaDataSourceEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDiaDataSource"/> to <see cref = "IDiaDataSourceEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDiaDataSource"/> instance to be converted </param>
    public static explicit operator IDiaDataSourceEx(Silk.NET.Windows.IDiaDataSource value)
    {
        return new IDiaDataSourceEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaDataSourceEx"/> to <see cref = "Silk.NET.Windows.IDiaDataSource"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaDataSourceEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDiaDataSource(IDiaDataSourceEx value)
    {
        return new Silk.NET.Windows.IDiaDataSource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaDataSourceEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaDataSourceEx(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaDataSourceEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaDataSourceEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaDataSourceEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaDataSourceEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
