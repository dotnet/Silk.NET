// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public unsafe partial interface IFFX
{
    public partial interface Static
    {
        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxConfigure")]
        static abstract uint Configure(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("const ffxConfigureDescHeader *")] ApiHeader* desc
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxConfigure")]
        static abstract uint Configure(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("const ffxConfigureDescHeader *")] Ref<ApiHeader> desc
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxCreateContext")]
        static abstract uint CreateContext(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("ffxCreateContextDescHeader *")] ApiHeader* desc,
            [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxCreateContext")]
        static abstract uint CreateContext(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("ffxCreateContextDescHeader *")] Ref<ApiHeader> desc,
            [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDestroyContext")]
        static abstract uint DestroyContext(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDestroyContext")]
        static abstract uint DestroyContext(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDispatch")]
        static abstract uint Dispatch(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("const ffxDispatchDescHeader *")] ApiHeader* desc
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDispatch")]
        static abstract uint Dispatch(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("const ffxDispatchDescHeader *")] Ref<ApiHeader> desc
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxQuery")]
        static abstract uint Query(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("ffxQueryDescHeader *")] ApiHeader* desc
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxQuery")]
        static abstract uint Query(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("ffxQueryDescHeader *")] Ref<ApiHeader> desc
        );
    }

    [return: NativeTypeName("ffxReturnCode_t")]
    [NativeFunction("FidelityFX", EntryPoint = "ffxConfigure")]
    uint Configure(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("const ffxConfigureDescHeader *")] ApiHeader* desc
    );

    [return: NativeTypeName("ffxReturnCode_t")]
    [Transformed]
    [NativeFunction("FidelityFX", EntryPoint = "ffxConfigure")]
    uint Configure(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("const ffxConfigureDescHeader *")] Ref<ApiHeader> desc
    );

    [return: NativeTypeName("ffxReturnCode_t")]
    [NativeFunction("FidelityFX", EntryPoint = "ffxCreateContext")]
    uint CreateContext(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("ffxCreateContextDescHeader *")] ApiHeader* desc,
        [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
    );

    [return: NativeTypeName("ffxReturnCode_t")]
    [Transformed]
    [NativeFunction("FidelityFX", EntryPoint = "ffxCreateContext")]
    uint CreateContext(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("ffxCreateContextDescHeader *")] Ref<ApiHeader> desc,
        [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
    );

    [return: NativeTypeName("ffxReturnCode_t")]
    [NativeFunction("FidelityFX", EntryPoint = "ffxDestroyContext")]
    uint DestroyContext(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
    );

    [return: NativeTypeName("ffxReturnCode_t")]
    [Transformed]
    [NativeFunction("FidelityFX", EntryPoint = "ffxDestroyContext")]
    uint DestroyContext(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
    );

    [return: NativeTypeName("ffxReturnCode_t")]
    [NativeFunction("FidelityFX", EntryPoint = "ffxDispatch")]
    uint Dispatch(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("const ffxDispatchDescHeader *")] ApiHeader* desc
    );

    [return: NativeTypeName("ffxReturnCode_t")]
    [Transformed]
    [NativeFunction("FidelityFX", EntryPoint = "ffxDispatch")]
    uint Dispatch(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("const ffxDispatchDescHeader *")] Ref<ApiHeader> desc
    );

    [return: NativeTypeName("ffxReturnCode_t")]
    [NativeFunction("FidelityFX", EntryPoint = "ffxQuery")]
    uint Query(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("ffxQueryDescHeader *")] ApiHeader* desc
    );

    [return: NativeTypeName("ffxReturnCode_t")]
    [Transformed]
    [NativeFunction("FidelityFX", EntryPoint = "ffxQuery")]
    uint Query(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("ffxQueryDescHeader *")] Ref<ApiHeader> desc
    );
}
