#include <stdint.h>
#include <stdio.h>
#include <dlfcn.h>

#define COBJMACROS
#define CINTERFACE
#define COM_NO_WINDOWS_H

/* Macros for COM interfaces */
#define interface struct
#define BEGIN_INTERFACE
#define END_INTERFACE
#define MIDL_INTERFACE(x) struct

#define D3DCOMPILE_DEBUG 0x00000001
#define D3DCOMPILE_SKIP_VALIDATION 0x00000002
#define D3DCOMPILE_SKIP_OPTIMIZATION 0x00000004
#define D3DCOMPILE_PACK_MATRIX_ROW_MAJOR 0x00000008
#define D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR 0x00000010
#define D3DCOMPILE_PARTIAL_PRECISION 0x00000020
#define D3DCOMPILE_FORCE_VS_SOFTWARE_NO_OPT 0x00000040
#define D3DCOMPILE_FORCE_PS_SOFTWARE_NO_OPT 0x00000080
#define D3DCOMPILE_NO_PRESHADER 0x00000100
#define D3DCOMPILE_AVOID_FLOW_CONTROL 0x00000200
#define D3DCOMPILE_PREFER_FLOW_CONTROL 0x00000400
#define D3DCOMPILE_ENABLE_STRICTNESS 0x00000800
#define D3DCOMPILE_ENABLE_BACKWARDS_COMPATIBILITY 0x00001000
#define D3DCOMPILE_IEEE_STRICTNESS 0x00002000
#define D3DCOMPILE_OPTIMIZATION_LEVEL0 0x00004000
#define D3DCOMPILE_OPTIMIZATION_LEVEL1 0x00000000
#define D3DCOMPILE_OPTIMIZATION_LEVEL2 0x0000c000
#define D3DCOMPILE_OPTIMIZATION_LEVEL3 0x00008000
#define D3DCOMPILE_RESERVED16 0x00010000
#define D3DCOMPILE_RESERVED17 0x00020000
#define D3DCOMPILE_WARNINGS_ARE_ERRORS 0x00040000
#define D3DCOMPILE_RESOURCES_MAY_ALIAS 0x00080000
#define D3DCOMPILE_ENABLE_UNBOUNDED_DESCRIPTOR_TABLES 0x00100000
#define D3DCOMPILE_ALL_RESOURCES_BOUND 0x00200000
#define D3DCOMPILE_DEBUG_NAME_FOR_SOURCE 0x00400000
#define D3DCOMPILE_DEBUG_NAME_FOR_BINARY 0x00800000

#define D3DCOMPILE_EFFECT_CHILD_EFFECT 0x00000001
#define D3DCOMPILE_EFFECT_ALLOW_SLOW_OPS 0x00000002

#define D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_LATEST 0x00000000
#define D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_0 0x00000010
#define D3DCOMPILE_FLAGS2_FORCE_ROOT_SIGNATURE_1_1 0x00000020

#define D3DCOMPILE_SECDATA_MERGE_UAV_SLOTS 0x00000001
#define D3DCOMPILE_SECDATA_PRESERVE_TEMPLATE_SLOTS 0x00000002
#define D3DCOMPILE_SECDATA_REQUIRE_TEMPLATE_MATCH 0x00000004

#include <vkd3d_types.h>
#include <vkd3d_shader.h>
#include <vkd3d_d3dcommon.h>
#include <private/vkd3d_common.h>
#include <private/vkd3d_blob.h>

#define D3DCOMPILE_DEBUG 0x00000001

static int open_include(const char *filename, bool local, const char *parent_data, void *context,
                        struct vkd3d_shader_code *code)
{
    ID3DInclude *iface = context;
    unsigned int size = 0;

    if (!iface)
        return VKD3D_ERROR;

    memset(code, 0, sizeof(*code));
    if (FAILED(ID3DInclude_Open(iface, local ? D3D_INCLUDE_LOCAL : D3D_INCLUDE_SYSTEM,
                                filename, parent_data, &code->code, &size)))
        return VKD3D_ERROR;

    code->size = size;
    return VKD3D_OK;
}

static void close_include(const struct vkd3d_shader_code *code, void *context)
{
    ID3DInclude *iface = context;

    ID3DInclude_Close(iface, code->code);
}

extern int32_t D3DCompile2(const void *data, void *data_size, const char *filename,
                           const D3D_SHADER_MACRO *macros, ID3DInclude *include, const char *entry_point,
                           const char *profile, UINT flags, UINT effect_flags, UINT secondary_flags,
                           const void *secondary_data, SIZE_T secondary_data_size, ID3DBlob **shader_blob,
                           ID3DBlob **messages_blob)
{
    struct vkd3d_shader_preprocess_info preprocess_info;
    struct vkd3d_shader_hlsl_source_info hlsl_info;
    struct vkd3d_shader_compile_option options[3];
    struct vkd3d_shader_compile_info compile_info;
    struct vkd3d_shader_compile_option *option;
    struct vkd3d_shader_code byte_code;
    const D3D_SHADER_MACRO *macro;
    size_t profile_len, i;
    char *messages;
    HRESULT hr;
    int ret;

    static const char *const d3dbc_profiles[] =
        {
            "fx_2_",

            "ps.1.",
            "ps.2.",
            "ps.3.",

            "ps_1_",
            "ps_2_",
            "ps_3_",

            "vs.1.",
            "vs.2.",
            "vs.3.",

            "vs_1_",
            "vs_2_",
            "vs_3_",

            "tx_1_",
        };

    // TRACE("data %p, data_size %lu, filename %s, macros %p, include %p, entry_point %s, "
    //       "profile %s, flags %#x, effect_flags %#x, secondary_flags %#x, secondary_data %p, "
    //       "secondary_data_size %lu, shader_blob %p, messages_blob %p.\n",
    //       data, data_size, debugstr_a(filename), macros, include, debugstr_a(entry_point),
    //       debugstr_a(profile), flags, effect_flags, secondary_flags, secondary_data,
    //       secondary_data_size, shader_blob, messages_blob);

    // if (flags & ~(D3DCOMPILE_DEBUG | D3DCOMPILE_PACK_MATRIX_ROW_MAJOR | D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR))
    //     FIXME("Ignoring flags %#x.\n", flags);
    // if (effect_flags)
    //     FIXME("Ignoring effect flags %#x.\n", effect_flags);
    // if (secondary_flags)
    //     FIXME("Ignoring secondary flags %#x.\n", secondary_flags);

    if (messages_blob)
        *messages_blob = NULL;

    option = &options[0];
    option->name = VKD3D_SHADER_COMPILE_OPTION_API_VERSION;
    option->value = VKD3D_SHADER_API_VERSION_1_9;

    compile_info.type = VKD3D_SHADER_STRUCTURE_TYPE_COMPILE_INFO;
    compile_info.next = &preprocess_info;
    compile_info.source.code = data;
    compile_info.source.size = (size_t)data_size;
    compile_info.source_type = VKD3D_SHADER_SOURCE_HLSL;
    compile_info.target_type = VKD3D_SHADER_TARGET_DXBC_TPF;
    compile_info.options = options;
    compile_info.option_count = 1;
    compile_info.log_level = VKD3D_SHADER_LOG_INFO;
    compile_info.source_name = filename;

    profile_len = strlen(profile);
    for (i = 0; i < ARRAY_SIZE(d3dbc_profiles); ++i)
    {
        size_t len = strlen(d3dbc_profiles[i]);

        if (len <= profile_len && !memcmp(profile, d3dbc_profiles[i], len))
        {
            compile_info.target_type = VKD3D_SHADER_TARGET_D3D_BYTECODE;
            break;
        }
    }

    preprocess_info.type = VKD3D_SHADER_STRUCTURE_TYPE_PREPROCESS_INFO;
    preprocess_info.next = &hlsl_info;
    preprocess_info.macros = (const struct vkd3d_shader_macro *)macros;
    preprocess_info.macro_count = 0;
    if (macros)
    {
        for (macro = macros; macro->Name; ++macro)
            ++preprocess_info.macro_count;
    }
    preprocess_info.pfn_open_include = open_include;
    preprocess_info.pfn_close_include = close_include;
    preprocess_info.include_context = include;

    hlsl_info.type = VKD3D_SHADER_STRUCTURE_TYPE_HLSL_SOURCE_INFO;
    hlsl_info.next = NULL;
    hlsl_info.profile = profile;
    hlsl_info.entry_point = entry_point;
    hlsl_info.secondary_code.code = secondary_data;
    hlsl_info.secondary_code.size = secondary_data_size;

    if (!(flags & D3DCOMPILE_DEBUG))
    {
        option = &options[compile_info.option_count++];
        option->name = VKD3D_SHADER_COMPILE_OPTION_STRIP_DEBUG;
        option->value = true;
    }

    if (flags & (D3DCOMPILE_PACK_MATRIX_ROW_MAJOR | D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR))
    {
        option = &options[compile_info.option_count++];
        option->name = VKD3D_SHADER_COMPILE_OPTION_PACK_MATRIX_ORDER;
        option->value = 0;
        if (flags & D3DCOMPILE_PACK_MATRIX_ROW_MAJOR)
            option->value |= VKD3D_SHADER_COMPILE_OPTION_PACK_MATRIX_ROW_MAJOR;
        if (flags & D3DCOMPILE_PACK_MATRIX_COLUMN_MAJOR)
            option->value |= VKD3D_SHADER_COMPILE_OPTION_PACK_MATRIX_COLUMN_MAJOR;
    }

    ret = vkd3d_shader_compile(&compile_info, &byte_code, &messages);

    if (messages && messages_blob)
    {
        if (FAILED(hr = vkd3d_blob_create(messages, strlen(messages), messages_blob)))
        {
            vkd3d_shader_free_messages(messages);
            vkd3d_shader_free_shader_code(&byte_code);
            return hr;
        }
        messages = NULL;
    }
    vkd3d_shader_free_messages(messages);

    if (!ret)
    {
        if (FAILED(hr = vkd3d_blob_create((void *)byte_code.code, byte_code.size, shader_blob)))
        {
            vkd3d_shader_free_shader_code(&byte_code);
            return hr;
        }
    }

    return hresult_from_vkd3d_result(ret);
}

extern int32_t D3DCompile(void *data,
                          void *data_size,
                          void *filename,
                          const void *macros,
                          void *include,
                          void *entrypoint,
                          void *profile,
                          int32_t flags,
                          int32_t effect_flags,
                          void *shader,
                          void *error_messages)
{

    return D3DCompile2(data, data_size, filename, macros, include, entrypoint, profile, flags,
                       effect_flags, 0, NULL, 0, shader, error_messages);
}