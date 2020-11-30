// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDrawMeshTasksIndirectCommandNV")]
    public unsafe partial struct DrawMeshTasksIndirectCommandNV
    {
        public DrawMeshTasksIndirectCommandNV
        (
            uint? taskCount = null,
            uint? firstTask = null
        ) : this()
        {
            if (taskCount is not null)
            {
                TaskCount = taskCount.Value;
            }

            if (firstTask is not null)
            {
                FirstTask = firstTask.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "taskCount")]
        public uint TaskCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "firstTask")]
        public uint FirstTask;
    }
}
