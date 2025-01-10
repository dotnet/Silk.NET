// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("065ACF71-F863-4B89-82F4-02E4D5886757")]
[NativeTypeName("struct ID3D12WorkGraphProperties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12WorkGraphProperties
    : ID3D12WorkGraphProperties.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12WorkGraphProperties));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12WorkGraphProperties, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D12WorkGraphProperties, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12WorkGraphProperties, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public uint GetNumWorkGraphs()
    {
        return ((delegate* unmanaged<ID3D12WorkGraphProperties, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("LPCWSTR")]
    public ushort* GetProgramName(uint WorkGraphIndex)
    {
        return ((delegate* unmanaged<ID3D12WorkGraphProperties, uint, ushort*>)((*lpVtbl)[4]))(
            this,
            WorkGraphIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public uint GetWorkGraphIndex([NativeTypeName("LPCWSTR")] ushort* pProgramName)
    {
        return ((delegate* unmanaged<ID3D12WorkGraphProperties, ushort*, uint>)((*lpVtbl)[5]))(
            this,
            pProgramName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public uint GetNumNodes(uint WorkGraphIndex)
    {
        return ((delegate* unmanaged<ID3D12WorkGraphProperties, uint, uint>)((*lpVtbl)[6]))(
            this,
            WorkGraphIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public D3D12_NODE_ID GetNodeID(uint WorkGraphIndex, uint NodeIndex)
    {
        D3D12_NODE_ID result;
        return *(
            (delegate* unmanaged<
                ID3D12WorkGraphProperties,
                D3D12_NODE_ID*,
                uint,
                uint,
                D3D12_NODE_ID*>)((*lpVtbl)[7])
        )(this, &result, WorkGraphIndex, NodeIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public uint GetNodeIndex(uint WorkGraphIndex, D3D12_NODE_ID NodeID)
    {
        return (
            (delegate* unmanaged<ID3D12WorkGraphProperties, uint, D3D12_NODE_ID, uint>)(
                (*lpVtbl)[8]
            )
        )(this, WorkGraphIndex, NodeID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public uint GetNodeLocalRootArgumentsTableIndex(uint WorkGraphIndex, uint NodeIndex)
    {
        return ((delegate* unmanaged<ID3D12WorkGraphProperties, uint, uint, uint>)((*lpVtbl)[9]))(
            this,
            WorkGraphIndex,
            NodeIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public uint GetNumEntrypoints(uint WorkGraphIndex)
    {
        return ((delegate* unmanaged<ID3D12WorkGraphProperties, uint, uint>)((*lpVtbl)[10]))(
            this,
            WorkGraphIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public D3D12_NODE_ID GetEntrypointID(uint WorkGraphIndex, uint EntrypointIndex)
    {
        D3D12_NODE_ID result;
        return *(
            (delegate* unmanaged<
                ID3D12WorkGraphProperties,
                D3D12_NODE_ID*,
                uint,
                uint,
                D3D12_NODE_ID*>)((*lpVtbl)[11])
        )(this, &result, WorkGraphIndex, EntrypointIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public uint GetEntrypointIndex(uint WorkGraphIndex, D3D12_NODE_ID NodeID)
    {
        return (
            (delegate* unmanaged<ID3D12WorkGraphProperties, uint, D3D12_NODE_ID, uint>)(
                (*lpVtbl)[12]
            )
        )(this, WorkGraphIndex, NodeID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public uint GetEntrypointRecordSizeInBytes(uint WorkGraphIndex, uint EntrypointIndex)
    {
        return ((delegate* unmanaged<ID3D12WorkGraphProperties, uint, uint, uint>)((*lpVtbl)[13]))(
            this,
            WorkGraphIndex,
            EntrypointIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void GetWorkGraphMemoryRequirements(
        uint WorkGraphIndex,
        D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS* pWorkGraphMemoryRequirements
    )
    {
        (
            (delegate* unmanaged<
                ID3D12WorkGraphProperties,
                uint,
                D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS*,
                void>)((*lpVtbl)[14])
        )(this, WorkGraphIndex, pWorkGraphMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public uint GetEntrypointRecordAlignmentInBytes(uint WorkGraphIndex, uint EntrypointIndex)
    {
        return ((delegate* unmanaged<ID3D12WorkGraphProperties, uint, uint, uint>)((*lpVtbl)[15]))(
            this,
            WorkGraphIndex,
            EntrypointIndex
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        uint GetNumWorkGraphs();

        [VtblIndex(4)]
        [return: NativeTypeName("LPCWSTR")]
        ushort* GetProgramName(uint WorkGraphIndex);

        [VtblIndex(5)]
        uint GetWorkGraphIndex([NativeTypeName("LPCWSTR")] ushort* pProgramName);

        [VtblIndex(6)]
        uint GetNumNodes(uint WorkGraphIndex);

        [VtblIndex(7)]
        D3D12_NODE_ID GetNodeID(uint WorkGraphIndex, uint NodeIndex);

        [VtblIndex(8)]
        uint GetNodeIndex(uint WorkGraphIndex, D3D12_NODE_ID NodeID);

        [VtblIndex(9)]
        uint GetNodeLocalRootArgumentsTableIndex(uint WorkGraphIndex, uint NodeIndex);

        [VtblIndex(10)]
        uint GetNumEntrypoints(uint WorkGraphIndex);

        [VtblIndex(11)]
        D3D12_NODE_ID GetEntrypointID(uint WorkGraphIndex, uint EntrypointIndex);

        [VtblIndex(12)]
        uint GetEntrypointIndex(uint WorkGraphIndex, D3D12_NODE_ID NodeID);

        [VtblIndex(13)]
        uint GetEntrypointRecordSizeInBytes(uint WorkGraphIndex, uint EntrypointIndex);

        [VtblIndex(14)]
        void GetWorkGraphMemoryRequirements(
            uint WorkGraphIndex,
            D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS* pWorkGraphMemoryRequirements
        );

        [VtblIndex(15)]
        uint GetEntrypointRecordAlignmentInBytes(uint WorkGraphIndex, uint EntrypointIndex);
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

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetNumWorkGraphs;

        [NativeTypeName("LPCWSTR (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*> GetProgramName;

        [NativeTypeName("UINT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint> GetWorkGraphIndex;

        [NativeTypeName("UINT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint> GetNumNodes;

        [NativeTypeName("D3D12_NODE_ID (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_NODE_ID*, uint, uint, D3D12_NODE_ID*> GetNodeID;

        [NativeTypeName("UINT (UINT, D3D12_NODE_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_NODE_ID, uint> GetNodeIndex;

        [NativeTypeName("UINT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint> GetNodeLocalRootArgumentsTableIndex;

        [NativeTypeName("UINT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint> GetNumEntrypoints;

        [NativeTypeName("D3D12_NODE_ID (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_NODE_ID*,
            uint,
            uint,
            D3D12_NODE_ID*> GetEntrypointID;

        [NativeTypeName("UINT (UINT, D3D12_NODE_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, D3D12_NODE_ID, uint> GetEntrypointIndex;

        [NativeTypeName("UINT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint> GetEntrypointRecordSizeInBytes;

        [NativeTypeName(
            "void (UINT, D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3D12_WORK_GRAPH_MEMORY_REQUIREMENTS*,
            void> GetWorkGraphMemoryRequirements;

        [NativeTypeName("UINT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint> GetEntrypointRecordAlignmentInBytes;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12WorkGraphProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12WorkGraphProperties(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D12WorkGraphProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D12WorkGraphProperties(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D12WorkGraphProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D12WorkGraphProperties"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12WorkGraphProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D12WorkGraphProperties value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
