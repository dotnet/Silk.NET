// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from ffx-api and corresponding dependencies of FidelityFX.
// Original source is Copyright (C) 2024 Advanced Micro Devices, Inc. Licensed under the MIT license.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.FidelityFX;

public unsafe partial class FFX : IFFX, IFFX.Static
{
    public partial class DllImport : IFFX.Static
    {
        [DllImport("FidelityFX", ExactSpelling = true, EntryPoint = "ffxConfigure")]
        [return: NativeTypeName("ffxReturnCode_t")]
        public static extern uint Configure(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("const ffxConfigureDescHeader *")] ApiHeader* desc
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxConfigure")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint Configure(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("const ffxConfigureDescHeader *")] Ref<ApiHeader> desc
        )
        {
            fixed (ApiHeader* __dsl_desc = desc)
            fixed (void** __dsl_context = context)
            {
                return (uint)Configure(__dsl_context, __dsl_desc);
            }
        }

        [DllImport("FidelityFX", ExactSpelling = true, EntryPoint = "ffxCreateContext")]
        [return: NativeTypeName("ffxReturnCode_t")]
        public static extern uint CreateContext(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("ffxCreateContextDescHeader *")] ApiHeader* desc,
            [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint CreateContext(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("ffxCreateContextDescHeader *")] Ref<ApiHeader> desc,
            [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
        )
        {
            fixed (AllocationCallbacks* __dsl_memCb = memCb)
            fixed (ApiHeader* __dsl_desc = desc)
            fixed (void** __dsl_context = context)
            {
                return (uint)CreateContext(__dsl_context, __dsl_desc, __dsl_memCb);
            }
        }

        [DllImport("FidelityFX", ExactSpelling = true, EntryPoint = "ffxDestroyContext")]
        [return: NativeTypeName("ffxReturnCode_t")]
        public static extern uint DestroyContext(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint DestroyContext(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
        )
        {
            fixed (AllocationCallbacks* __dsl_memCb = memCb)
            fixed (void** __dsl_context = context)
            {
                return (uint)DestroyContext(__dsl_context, __dsl_memCb);
            }
        }

        [DllImport("FidelityFX", ExactSpelling = true, EntryPoint = "ffxDispatch")]
        [return: NativeTypeName("ffxReturnCode_t")]
        public static extern uint Dispatch(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("const ffxDispatchDescHeader *")] ApiHeader* desc
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDispatch")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint Dispatch(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("const ffxDispatchDescHeader *")] Ref<ApiHeader> desc
        )
        {
            fixed (ApiHeader* __dsl_desc = desc)
            fixed (void** __dsl_context = context)
            {
                return (uint)Dispatch(__dsl_context, __dsl_desc);
            }
        }

        [DllImport("FidelityFX", ExactSpelling = true, EntryPoint = "ffxQuery")]
        [return: NativeTypeName("ffxReturnCode_t")]
        public static extern uint Query(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("ffxQueryDescHeader *")] ApiHeader* desc
        );

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxQuery")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint Query(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("ffxQueryDescHeader *")] Ref<ApiHeader> desc
        )
        {
            fixed (ApiHeader* __dsl_desc = desc)
            fixed (void** __dsl_context = context)
            {
                return (uint)Query(__dsl_context, __dsl_desc);
            }
        }
    }

    public partial class StaticWrapper<T> : IFFX
        where T : IFFX.Static
    {
        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxConfigure")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint Configure(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("const ffxConfigureDescHeader *")] ApiHeader* desc
        ) => T.Configure(context, desc);

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxConfigure")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint Configure(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("const ffxConfigureDescHeader *")] Ref<ApiHeader> desc
        ) => T.Configure(context, desc);

        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint CreateContext(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("ffxCreateContextDescHeader *")] ApiHeader* desc,
            [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
        ) => T.CreateContext(context, desc, memCb);

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint CreateContext(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("ffxCreateContextDescHeader *")] Ref<ApiHeader> desc,
            [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
        ) => T.CreateContext(context, desc, memCb);

        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint DestroyContext(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
        ) => T.DestroyContext(context, memCb);

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint DestroyContext(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
        ) => T.DestroyContext(context, memCb);

        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDispatch")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint Dispatch(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("const ffxDispatchDescHeader *")] ApiHeader* desc
        ) => T.Dispatch(context, desc);

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDispatch")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint Dispatch(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("const ffxDispatchDescHeader *")] Ref<ApiHeader> desc
        ) => T.Dispatch(context, desc);

        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxQuery")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint Query(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("ffxQueryDescHeader *")] ApiHeader* desc
        ) => T.Query(context, desc);

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxQuery")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public uint Query(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("ffxQueryDescHeader *")] Ref<ApiHeader> desc
        ) => T.Query(context, desc);
    }

    public partial class ThisThread
    {
        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxConfigure")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint Configure(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("const ffxConfigureDescHeader *")] ApiHeader* desc
        ) => Underlying.Value!.Configure(context, desc);

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxConfigure")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint Configure(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("const ffxConfigureDescHeader *")] Ref<ApiHeader> desc
        )
        {
            fixed (ApiHeader* __dsl_desc = desc)
            fixed (void** __dsl_context = context)
            {
                return (uint)Configure(__dsl_context, __dsl_desc);
            }
        }

        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint CreateContext(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("ffxCreateContextDescHeader *")] ApiHeader* desc,
            [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
        ) => Underlying.Value!.CreateContext(context, desc, memCb);

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxCreateContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint CreateContext(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("ffxCreateContextDescHeader *")] Ref<ApiHeader> desc,
            [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
        )
        {
            fixed (AllocationCallbacks* __dsl_memCb = memCb)
            fixed (ApiHeader* __dsl_desc = desc)
            fixed (void** __dsl_context = context)
            {
                return (uint)CreateContext(__dsl_context, __dsl_desc, __dsl_memCb);
            }
        }

        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint DestroyContext(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
        ) => Underlying.Value!.DestroyContext(context, memCb);

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDestroyContext")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint DestroyContext(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
        )
        {
            fixed (AllocationCallbacks* __dsl_memCb = memCb)
            fixed (void** __dsl_context = context)
            {
                return (uint)DestroyContext(__dsl_context, __dsl_memCb);
            }
        }

        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDispatch")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint Dispatch(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("const ffxDispatchDescHeader *")] ApiHeader* desc
        ) => Underlying.Value!.Dispatch(context, desc);

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxDispatch")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint Dispatch(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("const ffxDispatchDescHeader *")] Ref<ApiHeader> desc
        )
        {
            fixed (ApiHeader* __dsl_desc = desc)
            fixed (void** __dsl_context = context)
            {
                return (uint)Dispatch(__dsl_context, __dsl_desc);
            }
        }

        [return: NativeTypeName("ffxReturnCode_t")]
        [NativeFunction("FidelityFX", EntryPoint = "ffxQuery")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint Query(
            [NativeTypeName("ffxContext *")] void** context,
            [NativeTypeName("ffxQueryDescHeader *")] ApiHeader* desc
        ) => Underlying.Value!.Query(context, desc);

        [return: NativeTypeName("ffxReturnCode_t")]
        [Transformed]
        [NativeFunction("FidelityFX", EntryPoint = "ffxQuery")]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public static uint Query(
            [NativeTypeName("ffxContext *")] Ref2D context,
            [NativeTypeName("ffxQueryDescHeader *")] Ref<ApiHeader> desc
        )
        {
            fixed (ApiHeader* __dsl_desc = desc)
            fixed (void** __dsl_context = context)
            {
                return (uint)Query(__dsl_context, __dsl_desc);
            }
        }
    }

    [NativeTypeName("#define FFX_API_EFFECT_MASK 0xffff0000u")]
    public const uint EffectMask = 0xffff0000U;

    [NativeTypeName("#define FFX_API_EFFECT_ID_GENERAL 0x00000000u")]
    public const uint EffectIdGeneral = 0x00000000U;

    [NativeTypeName("#define FFX_API_CONFIGURE_GLOBALDEBUG_LEVEL_SILENCE 0x0000000u")]
    public const uint ConfigureGlobaldebugLevelSilence = 0x0000000U;

    [NativeTypeName("#define FFX_API_CONFIGURE_GLOBALDEBUG_LEVEL_ERRORS 0x0000001u")]
    public const uint ConfigureGlobaldebugLevelErrors = 0x0000001U;

    [NativeTypeName("#define FFX_API_CONFIGURE_GLOBALDEBUG_LEVEL_WARNINGS 0x0000002u")]
    public const uint ConfigureGlobaldebugLevelWarnings = 0x0000002U;

    [NativeTypeName("#define FFX_API_CONFIGURE_GLOBALDEBUG_LEVEL_VERBOSE 0xfffffffu")]
    public const uint ConfigureGlobaldebugLevelVerbose = 0xfffffffU;

    [NativeTypeName("#define FFX_API_CONFIGURE_DESC_TYPE_GLOBALDEBUG1 0x0000001u")]
    public const uint ConfigureDescTypeGlobaldebug1 = 0x0000001U;

    [NativeTypeName("#define FFX_API_QUERY_DESC_TYPE_GET_VERSIONS 4u")]
    public const uint QueryDescTypeGetVersions = 4U;

    [NativeTypeName("#define FFX_API_DESC_TYPE_OVERRIDE_VERSION 5u")]
    public const uint DescTypeOverrideVersion = 5U;

    [NativeTypeName("#define FFX_API_EFFECT_ID_FRAMEGENERATION 0x00020000u")]
    public const uint EffectIdFramegeneration = 0x00020000U;

    [NativeTypeName("#define FFX_API_CREATE_CONTEXT_DESC_TYPE_FRAMEGENERATION 0x00020001u")]
    public const uint CreateContextDescTypeFramegeneration = 0x00020001U;

    [NativeTypeName("#define FFX_API_CALLBACK_DESC_TYPE_FRAMEGENERATION_PRESENT 0x00020005u")]
    public const uint CallbackDescTypeFramegenerationPresent = 0x00020005U;

    [NativeTypeName("#define FFX_API_DISPATCH_DESC_TYPE_FRAMEGENERATION 0x00020003u")]
    public const uint DispatchDescTypeFramegeneration = 0x00020003U;

    [NativeTypeName("#define FFX_API_CONFIGURE_DESC_TYPE_FRAMEGENERATION 0x00020002u")]
    public const uint ConfigureDescTypeFramegeneration = 0x00020002U;

    [NativeTypeName("#define FFX_API_DISPATCH_DESC_TYPE_FRAMEGENERATION_PREPARE 0x00020004u")]
    public const uint DispatchDescTypeFramegenerationPrepare = 0x00020004U;

    [NativeTypeName("#define FFX_API_CONFIGURE_DESC_TYPE_FRAMEGENERATION_KEYVALUE 0x00020006u")]
    public const uint ConfigureDescTypeFramegenerationKeyvalue = 0x00020006U;

    [NativeTypeName("#define FFX_API_QUERY_DESC_TYPE_FRAMEGENERATION_GPU_MEMORY_USAGE 0x00020007u")]
    public const uint QueryDescTypeFramegenerationGpuMemoryUsage = 0x00020007U;

    [NativeTypeName(
        "#define FFX_API_CONFIGURE_DESC_TYPE_FRAMEGENERATION_REGISTERDISTORTIONRESOURCE 0x00020008u"
    )]
    public const uint ConfigureDescTypeFramegenerationRegisterdistortionresource = 0x00020008U;

    [NativeTypeName("#define FFX_API_CREATE_CONTEXT_DESC_TYPE_FRAMEGENERATION_HUDLESS 0x00020009u")]
    public const uint CreateContextDescTypeFramegenerationHudless = 0x00020009U;

    [NativeTypeName("#define FFX_API_EFFECT_ID_UPSCALE 0x00010000u")]
    public const uint EffectIdUpscale = 0x00010000U;

    [NativeTypeName("#define FFX_API_CREATE_CONTEXT_DESC_TYPE_UPSCALE 0x00010000u")]
    public const uint CreateContextDescTypeUpscale = 0x00010000U;

    [NativeTypeName("#define FFX_API_DISPATCH_DESC_TYPE_UPSCALE 0x00010001u")]
    public const uint DispatchDescTypeUpscale = 0x00010001U;

    [NativeTypeName(
        "#define FFX_API_QUERY_DESC_TYPE_UPSCALE_GETUPSCALERATIOFROMQUALITYMODE 0x00010002u"
    )]
    public const uint QueryDescTypeUpscaleGetupscaleratiofromqualitymode = 0x00010002U;

    [NativeTypeName(
        "#define FFX_API_QUERY_DESC_TYPE_UPSCALE_GETRENDERRESOLUTIONFROMQUALITYMODE 0x00010003u"
    )]
    public const uint QueryDescTypeUpscaleGetrenderresolutionfromqualitymode = 0x00010003U;

    [NativeTypeName("#define FFX_API_QUERY_DESC_TYPE_UPSCALE_GETJITTERPHASECOUNT 0x00010004u")]
    public const uint QueryDescTypeUpscaleGetjitterphasecount = 0x00010004U;

    [NativeTypeName("#define FFX_API_QUERY_DESC_TYPE_UPSCALE_GETJITTEROFFSET 0x00010005u")]
    public const uint QueryDescTypeUpscaleGetjitteroffset = 0x00010005U;

    [NativeTypeName("#define FFX_API_DISPATCH_DESC_TYPE_UPSCALE_GENERATEREACTIVEMASK 0x00010006u")]
    public const uint DispatchDescTypeUpscaleGeneratereactivemask = 0x00010006U;

    [NativeTypeName("#define FFX_API_CONFIGURE_DESC_TYPE_UPSCALE_KEYVALUE 0x00010007u")]
    public const uint ConfigureDescTypeUpscaleKeyvalue = 0x00010007U;

    [NativeTypeName("#define FFX_API_QUERY_DESC_TYPE_UPSCALE_GPU_MEMORY_USAGE 0x00010008u")]
    public const uint QueryDescTypeUpscaleGpuMemoryUsage = 0x00010008U;

    public static void LoadFunctions(
        Functions* pOutFunctions,
        [NativeTypeName("HMODULE")] HinstanceHandle module
    )
    {
        pOutFunctions->CreateContext = (delegate* unmanaged<
            void**,
            ApiHeader*,
            AllocationCallbacks*,
            uint>)(GetProcAddress(module, "ffxCreateContext"u8));
        pOutFunctions->DestroyContext = (delegate* unmanaged<void**, AllocationCallbacks*, uint>)(
            GetProcAddress(module, "ffxDestroyContext"u8)
        );
        pOutFunctions->Configure = (delegate* unmanaged<void**, ApiHeader*, uint>)(
            GetProcAddress(module, "ffxConfigure"u8)
        );
        pOutFunctions->Query = (delegate* unmanaged<void**, ApiHeader*, uint>)(
            GetProcAddress(module, "ffxQuery"u8)
        );
        pOutFunctions->Dispatch = (delegate* unmanaged<void**, ApiHeader*, uint>)(
            GetProcAddress(module, "ffxDispatch"u8)
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void LoadFunctions(
        Ref<Functions> pOutFunctions,
        [NativeTypeName("HMODULE")] HinstanceHandle module
    )
    {
        fixed (Functions* __dsl_pOutFunctions = pOutFunctions)
        {
            LoadFunctions(__dsl_pOutFunctions, module);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFFX.Configure(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("const ffxConfigureDescHeader *")] ApiHeader* desc
    ) =>
        (
            (delegate* unmanaged<void**, ApiHeader*, uint>)(
                _slots[0] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[0] = nativeContext.LoadFunction("ffxConfigure", "FidelityFX")
            )
        )(context, desc);

    [return: NativeTypeName("ffxReturnCode_t")]
    [NativeFunction("FidelityFX", EntryPoint = "ffxConfigure")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint Configure(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("const ffxConfigureDescHeader *")] ApiHeader* desc
    ) => DllImport.Configure(context, desc);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFFX.Configure(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("const ffxConfigureDescHeader *")] Ref<ApiHeader> desc
    )
    {
        fixed (ApiHeader* __dsl_desc = desc)
        fixed (void** __dsl_context = context)
        {
            return (uint)((IFFX)this).Configure(__dsl_context, __dsl_desc);
        }
    }

    [return: NativeTypeName("ffxReturnCode_t")]
    [Transformed]
    [NativeFunction("FidelityFX", EntryPoint = "ffxConfigure")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint Configure(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("const ffxConfigureDescHeader *")] Ref<ApiHeader> desc
    ) => DllImport.Configure(context, desc);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFFX.CreateContext(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("ffxCreateContextDescHeader *")] ApiHeader* desc,
        [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
    ) =>
        (
            (delegate* unmanaged<void**, ApiHeader*, AllocationCallbacks*, uint>)(
                _slots[1] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[1] = nativeContext.LoadFunction("ffxCreateContext", "FidelityFX")
            )
        )(context, desc, memCb);

    [return: NativeTypeName("ffxReturnCode_t")]
    [NativeFunction("FidelityFX", EntryPoint = "ffxCreateContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint CreateContext(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("ffxCreateContextDescHeader *")] ApiHeader* desc,
        [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
    ) => DllImport.CreateContext(context, desc, memCb);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFFX.CreateContext(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("ffxCreateContextDescHeader *")] Ref<ApiHeader> desc,
        [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
    )
    {
        fixed (AllocationCallbacks* __dsl_memCb = memCb)
        fixed (ApiHeader* __dsl_desc = desc)
        fixed (void** __dsl_context = context)
        {
            return (uint)((IFFX)this).CreateContext(__dsl_context, __dsl_desc, __dsl_memCb);
        }
    }

    [return: NativeTypeName("ffxReturnCode_t")]
    [Transformed]
    [NativeFunction("FidelityFX", EntryPoint = "ffxCreateContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint CreateContext(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("ffxCreateContextDescHeader *")] Ref<ApiHeader> desc,
        [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
    ) => DllImport.CreateContext(context, desc, memCb);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFFX.DestroyContext(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
    ) =>
        (
            (delegate* unmanaged<void**, AllocationCallbacks*, uint>)(
                _slots[2] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[2] = nativeContext.LoadFunction("ffxDestroyContext", "FidelityFX")
            )
        )(context, memCb);

    [return: NativeTypeName("ffxReturnCode_t")]
    [NativeFunction("FidelityFX", EntryPoint = "ffxDestroyContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint DestroyContext(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("const ffxAllocationCallbacks *")] AllocationCallbacks* memCb
    ) => DllImport.DestroyContext(context, memCb);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFFX.DestroyContext(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
    )
    {
        fixed (AllocationCallbacks* __dsl_memCb = memCb)
        fixed (void** __dsl_context = context)
        {
            return (uint)((IFFX)this).DestroyContext(__dsl_context, __dsl_memCb);
        }
    }

    [return: NativeTypeName("ffxReturnCode_t")]
    [Transformed]
    [NativeFunction("FidelityFX", EntryPoint = "ffxDestroyContext")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint DestroyContext(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("const ffxAllocationCallbacks *")] Ref<AllocationCallbacks> memCb
    ) => DllImport.DestroyContext(context, memCb);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFFX.Dispatch(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("const ffxDispatchDescHeader *")] ApiHeader* desc
    ) =>
        (
            (delegate* unmanaged<void**, ApiHeader*, uint>)(
                _slots[3] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[3] = nativeContext.LoadFunction("ffxDispatch", "FidelityFX")
            )
        )(context, desc);

    [return: NativeTypeName("ffxReturnCode_t")]
    [NativeFunction("FidelityFX", EntryPoint = "ffxDispatch")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint Dispatch(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("const ffxDispatchDescHeader *")] ApiHeader* desc
    ) => DllImport.Dispatch(context, desc);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFFX.Dispatch(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("const ffxDispatchDescHeader *")] Ref<ApiHeader> desc
    )
    {
        fixed (ApiHeader* __dsl_desc = desc)
        fixed (void** __dsl_context = context)
        {
            return (uint)((IFFX)this).Dispatch(__dsl_context, __dsl_desc);
        }
    }

    [return: NativeTypeName("ffxReturnCode_t")]
    [Transformed]
    [NativeFunction("FidelityFX", EntryPoint = "ffxDispatch")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint Dispatch(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("const ffxDispatchDescHeader *")] Ref<ApiHeader> desc
    ) => DllImport.Dispatch(context, desc);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFFX.Query(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("ffxQueryDescHeader *")] ApiHeader* desc
    ) =>
        (
            (delegate* unmanaged<void**, ApiHeader*, uint>)(
                _slots[4] is not null and var loadedFnPtr
                    ? loadedFnPtr
                    : _slots[4] = nativeContext.LoadFunction("ffxQuery", "FidelityFX")
            )
        )(context, desc);

    [return: NativeTypeName("ffxReturnCode_t")]
    [NativeFunction("FidelityFX", EntryPoint = "ffxQuery")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint Query(
        [NativeTypeName("ffxContext *")] void** context,
        [NativeTypeName("ffxQueryDescHeader *")] ApiHeader* desc
    ) => DllImport.Query(context, desc);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    uint IFFX.Query(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("ffxQueryDescHeader *")] Ref<ApiHeader> desc
    )
    {
        fixed (ApiHeader* __dsl_desc = desc)
        fixed (void** __dsl_context = context)
        {
            return (uint)((IFFX)this).Query(__dsl_context, __dsl_desc);
        }
    }

    [return: NativeTypeName("ffxReturnCode_t")]
    [Transformed]
    [NativeFunction("FidelityFX", EntryPoint = "ffxQuery")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint Query(
        [NativeTypeName("ffxContext *")] Ref2D context,
        [NativeTypeName("ffxQueryDescHeader *")] Ref<ApiHeader> desc
    ) => DllImport.Query(context, desc);
}
