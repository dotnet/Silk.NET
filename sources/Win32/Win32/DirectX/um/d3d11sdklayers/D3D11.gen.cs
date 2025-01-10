// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3D11
{
    [NativeTypeName("#define D3D11_SDK_LAYERS_VERSION ( 1 )")]
    public const int D3D11_SDK_LAYERS_VERSION = (1);

    [NativeTypeName("#define D3D11_DEBUG_FEATURE_FLUSH_PER_RENDER_OP ( 0x1 )")]
    public const int D3D11_DEBUG_FEATURE_FLUSH_PER_RENDER_OP = (0x1);

    [NativeTypeName("#define D3D11_DEBUG_FEATURE_FINISH_PER_RENDER_OP ( 0x2 )")]
    public const int D3D11_DEBUG_FEATURE_FINISH_PER_RENDER_OP = (0x2);

    [NativeTypeName("#define D3D11_DEBUG_FEATURE_PRESENT_PER_RENDER_OP ( 0x4 )")]
    public const int D3D11_DEBUG_FEATURE_PRESENT_PER_RENDER_OP = (0x4);

    [NativeTypeName("#define D3D11_DEBUG_FEATURE_ALWAYS_DISCARD_OFFERED_RESOURCE ( 0x8 )")]
    public const int D3D11_DEBUG_FEATURE_ALWAYS_DISCARD_OFFERED_RESOURCE = (0x8);

    [NativeTypeName("#define D3D11_DEBUG_FEATURE_NEVER_DISCARD_OFFERED_RESOURCE ( 0x10 )")]
    public const int D3D11_DEBUG_FEATURE_NEVER_DISCARD_OFFERED_RESOURCE = (0x10);

    [NativeTypeName("#define D3D11_DEBUG_FEATURE_AVOID_BEHAVIOR_CHANGING_DEBUG_AIDS ( 0x40 )")]
    public const int D3D11_DEBUG_FEATURE_AVOID_BEHAVIOR_CHANGING_DEBUG_AIDS = (0x40);

    [NativeTypeName(
        "#define D3D11_DEBUG_FEATURE_DISABLE_TILED_RESOURCE_MAPPING_TRACKING_AND_VALIDATION ( 0x80 )"
    )]
    public const int D3D11_DEBUG_FEATURE_DISABLE_TILED_RESOURCE_MAPPING_TRACKING_AND_VALIDATION = (
        0x80
    );

    [NativeTypeName("#define D3D11_REGKEY_PATH __TEXT(\"Software\\Microsoft\\Direct3D\")")]
    public const string D3D11_REGKEY_PATH = "Software\\Microsoft\\Direct3D";

    [NativeTypeName("#define D3D11_MUTE_DEBUG_OUTPUT __TEXT(\"MuteDebugOutput\")")]
    public const string D3D11_MUTE_DEBUG_OUTPUT = "MuteDebugOutput";

    [NativeTypeName("#define D3D11_ENABLE_BREAK_ON_MESSAGE __TEXT(\"EnableBreakOnMessage\")")]
    public const string D3D11_ENABLE_BREAK_ON_MESSAGE = "EnableBreakOnMessage";

    [NativeTypeName(
        "#define D3D11_INFOQUEUE_STORAGE_FILTER_OVERRIDE __TEXT(\"InfoQueueStorageFilterOverride\")"
    )]
    public const string D3D11_INFOQUEUE_STORAGE_FILTER_OVERRIDE = "InfoQueueStorageFilterOverride";

    [NativeTypeName("#define D3D11_MUTE_CATEGORY __TEXT(\"Mute_CATEGORY_%s\")")]
    public const string D3D11_MUTE_CATEGORY = "Mute_CATEGORY_%s";

    [NativeTypeName("#define D3D11_MUTE_SEVERITY __TEXT(\"Mute_SEVERITY_%s\")")]
    public const string D3D11_MUTE_SEVERITY = "Mute_SEVERITY_%s";

    [NativeTypeName("#define D3D11_MUTE_ID_STRING __TEXT(\"Mute_ID_%s\")")]
    public const string D3D11_MUTE_ID_STRING = "Mute_ID_%s";

    [NativeTypeName("#define D3D11_MUTE_ID_DECIMAL __TEXT(\"Mute_ID_%d\")")]
    public const string D3D11_MUTE_ID_DECIMAL = "Mute_ID_%d";

    [NativeTypeName("#define D3D11_UNMUTE_SEVERITY_INFO __TEXT(\"Unmute_SEVERITY_INFO\")")]
    public const string D3D11_UNMUTE_SEVERITY_INFO = "Unmute_SEVERITY_INFO";

    [NativeTypeName("#define D3D11_BREAKON_CATEGORY __TEXT(\"BreakOn_CATEGORY_%s\")")]
    public const string D3D11_BREAKON_CATEGORY = "BreakOn_CATEGORY_%s";

    [NativeTypeName("#define D3D11_BREAKON_SEVERITY __TEXT(\"BreakOn_SEVERITY_%s\")")]
    public const string D3D11_BREAKON_SEVERITY = "BreakOn_SEVERITY_%s";

    [NativeTypeName("#define D3D11_BREAKON_ID_STRING __TEXT(\"BreakOn_ID_%s\")")]
    public const string D3D11_BREAKON_ID_STRING = "BreakOn_ID_%s";

    [NativeTypeName("#define D3D11_BREAKON_ID_DECIMAL __TEXT(\"BreakOn_ID_%d\")")]
    public const string D3D11_BREAKON_ID_DECIMAL = "BreakOn_ID_%d";

    [NativeTypeName("#define D3D11_APPSIZE_STRING __TEXT(\"Size\")")]
    public const string D3D11_APPSIZE_STRING = "Size";

    [NativeTypeName("#define D3D11_APPNAME_STRING __TEXT(\"Name\")")]
    public const string D3D11_APPNAME_STRING = "Name";

    [NativeTypeName("#define D3D11_FORCE_DEBUGGABLE __TEXT(\"ForceDebuggable\")")]
    public const string D3D11_FORCE_DEBUGGABLE = "ForceDebuggable";

    [NativeTypeName(
        "#define D3D11_FORCE_SHADER_SKIP_OPTIMIZATION __TEXT(\"ForceShaderSkipOptimization\")"
    )]
    public const string D3D11_FORCE_SHADER_SKIP_OPTIMIZATION = "ForceShaderSkipOptimization";

    [NativeTypeName("#define D3D11_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT 1024")]
    public const int D3D11_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;
}
