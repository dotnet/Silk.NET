#include <stdint.h>
#include <stdio.h>
#include <dlfcn.h>

#define COBJMACROS
#define CINTERFACE
#define COM_NO_WINDOWS_H

/* Macros for COM interfaces */
# define interface struct
# define BEGIN_INTERFACE
# define END_INTERFACE
# define MIDL_INTERFACE(x) struct

#include <vkd3d_types.h>
#include <vkd3d_shader.h>
#include <vkd3d_d3dcommon.h>
#include <private/vkd3d_common.h>
#include <private/vkd3d_blob.h>

#define D3DCOMPILE_DEBUG 0x00000001

extern int32_t D3DCompile2(const void *data, void* data_size, const char *filename,
        const D3D_SHADER_MACRO *macros, ID3DInclude *include, const char *entry_point,
        const char *profile, UINT flags, UINT effect_flags, UINT secondary_flags,
        const void *secondary_data, SIZE_T secondary_data_size, ID3DBlob **shader_blob,
        ID3DBlob **messages_blob)
{
    struct vkd3d_shader_preprocess_info preprocess_info;
    struct vkd3d_shader_hlsl_source_info hlsl_info;
    struct vkd3d_shader_compile_option options[2];
    struct vkd3d_shader_compile_info compile_info;
    struct vkd3d_shader_compile_option *option;
    struct vkd3d_shader_code byte_code;
    const D3D_SHADER_MACRO *macro;
    size_t profile_len, i;
    char *messages;
    HRESULT hr;
    int ret;

    static const char * const d3dbc_profiles[] =
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
    //         "profile %s, flags %#x, effect_flags %#x, secondary_flags %#x, secondary_data %p, "
    //         "secondary_data_size %lu, shader_blob %p, messages_blob %p.\n",
    //         data, data_size, debugstr_a(filename), macros, include, debugstr_a(entry_point),
    //         debugstr_a(profile), flags, effect_flags, secondary_flags, secondary_data,
    //         secondary_data_size, shader_blob, messages_blob);

    // if (flags & ~D3DCOMPILE_DEBUG)
        // FIXME("Ignoring flags %#x.\n", flags);
    // if (effect_flags)
        // FIXME("Ignoring effect flags %#x.\n", effect_flags);
    // if (secondary_flags)
        // FIXME("Ignoring secondary flags %#x.\n", secondary_flags);

    if (messages_blob)
        *messages_blob = NULL;

    option = &options[0];
    option->name = VKD3D_SHADER_COMPILE_OPTION_API_VERSION;
    option->value = VKD3D_SHADER_API_VERSION_1_6;

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
    preprocess_info.pfn_open_include = NULL;
    preprocess_info.pfn_close_include = NULL;
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

    ret = vkd3d_shader_compile(&compile_info, &byte_code, &messages);

    if (messages && messages_blob)
    {
        if (FAILED(hr = vkd3d_blob_create(messages, strlen(messages), messages_blob)))
        {
            vkd3d_shader_free_messages(messages);
            vkd3d_shader_free_shader_code(&byte_code);
            printf("Failed to create blob for messages.\n");
            return hr;
        }
        messages = NULL;
    }
    vkd3d_shader_free_messages(messages);

    if (!ret)
    {
        if (FAILED(hr = vkd3d_blob_create((void *)byte_code.code, byte_code.size, shader_blob)))
        {
            printf("Failed to create blob for bytecode.\n");
            vkd3d_shader_free_shader_code(&byte_code);
            return hr;
        }
    }

    printf("got to end?.\n");
    return hresult_from_vkd3d_result(ret);
}

extern int32_t D3DCompile(void* data,
    void* data_size,
    void* filename,
    const void* macros,
    void* include,
    void* entrypoint,
    void* profile,
    int32_t flags,
    int32_t effect_flags,
    void* shader,
    void* error_messages) {

    return D3DCompile2(data, data_size, filename, macros, include, entrypoint, profile, flags,
            effect_flags, 0, NULL, 0, shader, error_messages);
}