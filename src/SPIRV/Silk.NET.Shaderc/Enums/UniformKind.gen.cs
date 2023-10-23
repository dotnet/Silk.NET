// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Shaderc
{
    [NativeName("AnonymousName", "__AnonymousEnum_shaderc_L216_C9")]
    [NativeName("Name", "shaderc_uniform_kind")]
    public enum UniformKind : int
    {
        [NativeName("Name", "shaderc_uniform_kind_image")]
        Image = 0x0,
        [NativeName("Name", "shaderc_uniform_kind_sampler")]
        Sampler = 0x1,
        [NativeName("Name", "shaderc_uniform_kind_texture")]
        Texture = 0x2,
        [NativeName("Name", "shaderc_uniform_kind_buffer")]
        Buffer = 0x3,
        [NativeName("Name", "shaderc_uniform_kind_storage_buffer")]
        StorageBuffer = 0x4,
        [NativeName("Name", "shaderc_uniform_kind_unordered_access_view")]
        UnorderedAccessView = 0x5,
    }
}
