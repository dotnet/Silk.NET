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
    [NativeName("Name", "spvc_entry_point")]
    public unsafe partial struct EntryPoint
    {
        public EntryPoint
        (
            Silk.NET.SPIRV.ExecutionModel? executionModel = null,
            byte* name = null
        ) : this()
        {
            if (executionModel is not null)
            {
                ExecutionModel = executionModel.Value;
            }

            if (name is not null)
            {
                Name = name;
            }
        }


        [NativeName("Type", "SpvExecutionModel")]
        [NativeName("Type.Name", "SpvExecutionModel")]
        [NativeName("Name", "execution_model")]
        public Silk.NET.SPIRV.ExecutionModel ExecutionModel;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "name")]
        public byte* Name;
    }
}
