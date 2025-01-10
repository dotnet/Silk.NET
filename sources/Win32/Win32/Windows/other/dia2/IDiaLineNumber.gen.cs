// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B388EB14-BE4D-421D-A8A1-6CF7AB057086")]
[NativeTypeName("struct IDiaLineNumber : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaLineNumber : IDiaLineNumber.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaLineNumber));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaLineNumber, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaLineNumber, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaLineNumber, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_compiland(IDiaSymbol* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, IDiaSymbol*, int>)((*lpVtbl)[3]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_sourceFile(IDiaSourceFile* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, IDiaSourceFile*, int>)((*lpVtbl)[4]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_lineNumber([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, uint*, int>)((*lpVtbl)[5]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_lineNumberEnd([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, uint*, int>)((*lpVtbl)[6]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_columnNumber([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, uint*, int>)((*lpVtbl)[7]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_columnNumberEnd([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, uint*, int>)((*lpVtbl)[8]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, uint*, int>)((*lpVtbl)[9]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_addressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, uint*, int>)((*lpVtbl)[10]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, uint*, int>)((*lpVtbl)[11]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, ulong*, int>)((*lpVtbl)[12]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_length([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, uint*, int>)((*lpVtbl)[13]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_sourceFileId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, uint*, int>)((*lpVtbl)[14]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_statement(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, BOOL*, int>)((*lpVtbl)[15]))(this, pRetVal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_compilandId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaLineNumber, uint*, int>)((*lpVtbl)[16]))(this, pRetVal);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_compiland(IDiaSymbol* pRetVal);

        [VtblIndex(4)]
        HRESULT get_sourceFile(IDiaSourceFile* pRetVal);

        [VtblIndex(5)]
        HRESULT get_lineNumber([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(6)]
        HRESULT get_lineNumberEnd([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(7)]
        HRESULT get_columnNumber([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(8)]
        HRESULT get_columnNumberEnd([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(9)]
        HRESULT get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(10)]
        HRESULT get_addressOffset([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(11)]
        HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(12)]
        HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal);

        [VtblIndex(13)]
        HRESULT get_length([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(14)]
        HRESULT get_sourceFileId([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(15)]
        HRESULT get_statement(BOOL* pRetVal);

        [VtblIndex(16)]
        HRESULT get_compilandId([NativeTypeName("DWORD *")] uint* pRetVal);
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

        [NativeTypeName("HRESULT (IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaSymbol*, int> get_compiland;

        [NativeTypeName("HRESULT (IDiaSourceFile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaSourceFile*, int> get_sourceFile;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_lineNumber;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_lineNumberEnd;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_columnNumber;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_columnNumberEnd;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_addressSection;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_addressOffset;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_relativeVirtualAddress;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_virtualAddress;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_length;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_sourceFileId;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_statement;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_compilandId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaLineNumber"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaLineNumber(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaLineNumber"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaLineNumber(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaLineNumber(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaLineNumber"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaLineNumber"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaLineNumber value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
