// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE")]
    public enum D3DShaderCacheAppRegistrationScope : int
    {
        [Obsolete("Deprecated in favour of \"User\"")]
        [NativeName("Name", "D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE_USER")]
        D3DShaderCacheAppRegistrationScopeUser = 0x0,
        [Obsolete("Deprecated in favour of \"System\"")]
        [NativeName("Name", "D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE_SYSTEM")]
        D3DShaderCacheAppRegistrationScopeSystem = 0x1,
        [NativeName("Name", "D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE_USER")]
        User = 0x0,
        [NativeName("Name", "D3D_SHADER_CACHE_APP_REGISTRATION_SCOPE_SYSTEM")]
        System = 0x1,
    }
}
