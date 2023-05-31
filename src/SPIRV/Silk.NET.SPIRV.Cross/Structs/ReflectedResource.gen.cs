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
    [NativeName("Name", "spvc_reflected_resource")]
    public unsafe partial struct ReflectedResource
    {
        public ReflectedResource
        (
            uint? id = null,
            uint? baseTypeId = null,
            uint? typeId = null,
            byte* name = null
        ) : this()
        {
            if (id is not null)
            {
                Id = id.Value;
            }

            if (baseTypeId is not null)
            {
                BaseTypeId = baseTypeId.Value;
            }

            if (typeId is not null)
            {
                TypeId = typeId.Value;
            }

            if (name is not null)
            {
                Name = name;
            }
        }


        [NativeName("Type", "spvc_variable_id")]
        [NativeName("Type.Name", "spvc_variable_id")]
        [NativeName("Name", "id")]
        public uint Id;

        [NativeName("Type", "spvc_type_id")]
        [NativeName("Type.Name", "spvc_type_id")]
        [NativeName("Name", "base_type_id")]
        public uint BaseTypeId;

        [NativeName("Type", "spvc_type_id")]
        [NativeName("Type.Name", "spvc_type_id")]
        [NativeName("Name", "type_id")]
        public uint TypeId;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "name")]
        public byte* Name;
    }
}
