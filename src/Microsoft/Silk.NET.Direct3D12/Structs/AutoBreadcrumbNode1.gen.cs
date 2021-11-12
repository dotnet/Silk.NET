// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "D3D12_AUTO_BREADCRUMB_NODE1")]
    public unsafe partial struct AutoBreadcrumbNode1
    {
        public AutoBreadcrumbNode1
        (
            byte* pCommandListDebugNameA = null,
            char* pCommandListDebugNameW = null,
            byte* pCommandQueueDebugNameA = null,
            char* pCommandQueueDebugNameW = null,
            ID3D12GraphicsCommandList* pCommandList = null,
            ID3D12CommandQueue* pCommandQueue = null,
            uint? breadcrumbCount = null,
            uint* pLastBreadcrumbValue = null,
            AutoBreadcrumbOp* pCommandHistory = null,
            AutoBreadcrumbNode1* pNext = null,
            uint? breadcrumbContextsCount = null,
            DredBreadcrumbContext* pBreadcrumbContexts = null
        ) : this()
        {
            if (pCommandListDebugNameA is not null)
            {
                PCommandListDebugNameA = pCommandListDebugNameA;
            }

            if (pCommandListDebugNameW is not null)
            {
                PCommandListDebugNameW = pCommandListDebugNameW;
            }

            if (pCommandQueueDebugNameA is not null)
            {
                PCommandQueueDebugNameA = pCommandQueueDebugNameA;
            }

            if (pCommandQueueDebugNameW is not null)
            {
                PCommandQueueDebugNameW = pCommandQueueDebugNameW;
            }

            if (pCommandList is not null)
            {
                PCommandList = pCommandList;
            }

            if (pCommandQueue is not null)
            {
                PCommandQueue = pCommandQueue;
            }

            if (breadcrumbCount is not null)
            {
                BreadcrumbCount = breadcrumbCount.Value;
            }

            if (pLastBreadcrumbValue is not null)
            {
                PLastBreadcrumbValue = pLastBreadcrumbValue;
            }

            if (pCommandHistory is not null)
            {
                PCommandHistory = pCommandHistory;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (breadcrumbContextsCount is not null)
            {
                BreadcrumbContextsCount = breadcrumbContextsCount.Value;
            }

            if (pBreadcrumbContexts is not null)
            {
                PBreadcrumbContexts = pBreadcrumbContexts;
            }
        }


        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "pCommandListDebugNameA")]
        public byte* PCommandListDebugNameA;

        [NativeName("Type", "const wchar_t *")]
        [NativeName("Type.Name", "const wchar_t *")]
        [NativeName("Name", "pCommandListDebugNameW")]
        public char* PCommandListDebugNameW;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "pCommandQueueDebugNameA")]
        public byte* PCommandQueueDebugNameA;

        [NativeName("Type", "const wchar_t *")]
        [NativeName("Type.Name", "const wchar_t *")]
        [NativeName("Name", "pCommandQueueDebugNameW")]
        public char* PCommandQueueDebugNameW;

        [NativeName("Type", "ID3D12GraphicsCommandList *")]
        [NativeName("Type.Name", "ID3D12GraphicsCommandList *")]
        [NativeName("Name", "pCommandList")]
        public ID3D12GraphicsCommandList* PCommandList;

        [NativeName("Type", "ID3D12CommandQueue *")]
        [NativeName("Type.Name", "ID3D12CommandQueue *")]
        [NativeName("Name", "pCommandQueue")]
        public ID3D12CommandQueue* PCommandQueue;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BreadcrumbCount")]
        public uint BreadcrumbCount;

        [NativeName("Type", "const UINT *")]
        [NativeName("Type.Name", "const UINT *")]
        [NativeName("Name", "pLastBreadcrumbValue")]
        public uint* PLastBreadcrumbValue;

        [NativeName("Type", "const D3D12_AUTO_BREADCRUMB_OP *")]
        [NativeName("Type.Name", "const D3D12_AUTO_BREADCRUMB_OP *")]
        [NativeName("Name", "pCommandHistory")]
        public AutoBreadcrumbOp* PCommandHistory;

        [NativeName("Type", "const struct D3D12_AUTO_BREADCRUMB_NODE1 *")]
        [NativeName("Type.Name", "const struct D3D12_AUTO_BREADCRUMB_NODE1 *")]
        [NativeName("Name", "pNext")]
        public AutoBreadcrumbNode1* PNext;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BreadcrumbContextsCount")]
        public uint BreadcrumbContextsCount;

        [NativeName("Type", "D3D12_DRED_BREADCRUMB_CONTEXT *")]
        [NativeName("Type.Name", "D3D12_DRED_BREADCRUMB_CONTEXT *")]
        [NativeName("Name", "pBreadcrumbContexts")]
        public DredBreadcrumbContext* PBreadcrumbContexts;
    }
}
