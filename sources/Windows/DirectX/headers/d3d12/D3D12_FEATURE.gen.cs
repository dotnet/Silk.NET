// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE"]/*' />
public enum D3D12_FEATURE
{
    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS = 0,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_ARCHITECTURE"]/*' />
    D3D12_FEATURE_ARCHITECTURE = 1,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_FEATURE_LEVELS"]/*' />
    D3D12_FEATURE_FEATURE_LEVELS = 2,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_FORMAT_SUPPORT"]/*' />
    D3D12_FEATURE_FORMAT_SUPPORT = 3,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_MULTISAMPLE_QUALITY_LEVELS"]/*' />
    D3D12_FEATURE_MULTISAMPLE_QUALITY_LEVELS = 4,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_FORMAT_INFO"]/*' />
    D3D12_FEATURE_FORMAT_INFO = 5,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT"]/*' />
    D3D12_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT = 6,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_SHADER_MODEL"]/*' />
    D3D12_FEATURE_SHADER_MODEL = 7,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS1"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS1 = 8,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_SUPPORT"]/*' />
    D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_SUPPORT = 10,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_ROOT_SIGNATURE"]/*' />
    D3D12_FEATURE_ROOT_SIGNATURE = 12,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_ARCHITECTURE1"]/*' />
    D3D12_FEATURE_ARCHITECTURE1 = 16,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS2"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS2 = 18,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_SHADER_CACHE"]/*' />
    D3D12_FEATURE_SHADER_CACHE = 19,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_COMMAND_QUEUE_PRIORITY"]/*' />
    D3D12_FEATURE_COMMAND_QUEUE_PRIORITY = 20,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS3"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS3 = 21,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_EXISTING_HEAPS"]/*' />
    D3D12_FEATURE_EXISTING_HEAPS = 22,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS4"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS4 = 23,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_SERIALIZATION"]/*' />
    D3D12_FEATURE_SERIALIZATION = 24,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_CROSS_NODE"]/*' />
    D3D12_FEATURE_CROSS_NODE = 25,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS5"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS5 = 27,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_DISPLAYABLE"]/*' />
    D3D12_FEATURE_DISPLAYABLE = 28,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS6"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS6 = 30,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_QUERY_META_COMMAND"]/*' />
    D3D12_FEATURE_QUERY_META_COMMAND = 31,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS7"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS7 = 32,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPE_COUNT"]/*' />
    D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPE_COUNT = 33,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPES"]/*' />
    D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPES = 34,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS8"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS8 = 36,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS9"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS9 = 37,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS10"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS10 = 39,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS11"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS11 = 40,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS12"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS12 = 41,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS13"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS13 = 42,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS14"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS14 = 43,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS15"]/*' />
    D3D12_FEATURE_D3D12_OPTIONS15 = 44,
}
