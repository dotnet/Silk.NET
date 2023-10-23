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

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_reflected_builtin_resource")]
    public unsafe partial struct ReflectedBuiltinResource
    {
        public ReflectedBuiltinResource
        (
            Silk.NET.SPIRV.BuiltIn? builtin = null,
            uint? valueTypeId = null,
            ReflectedResource? resource = null
        ) : this()
        {
            if (builtin is not null)
            {
                Builtin = builtin.Value;
            }

            if (valueTypeId is not null)
            {
                ValueTypeId = valueTypeId.Value;
            }

            if (resource is not null)
            {
                Resource = resource.Value;
            }
        }


        [NativeName("Type", "SpvBuiltIn")]
        [NativeName("Type.Name", "SpvBuiltIn")]
        [NativeName("Name", "builtin")]
        public Silk.NET.SPIRV.BuiltIn Builtin;

        [NativeName("Type", "spvc_type_id")]
        [NativeName("Type.Name", "spvc_type_id")]
        [NativeName("Name", "value_type_id")]
        public uint ValueTypeId;

        [NativeName("Type", "spvc_reflected_resource")]
        [NativeName("Type.Name", "spvc_reflected_resource")]
        [NativeName("Name", "resource")]
        public ReflectedResource Resource;
    }
}
