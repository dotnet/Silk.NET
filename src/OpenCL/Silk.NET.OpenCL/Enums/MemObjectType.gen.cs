// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_mem_object_type")]
    public enum MemObjectType : int
    {
        [NativeName("Name", "CL_MEM_OBJECT_BUFFER")]
        MemObjectBuffer = 0x10F0,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE2D")]
        MemObjectImage2D = 0x10F1,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE3D")]
        MemObjectImage3D = 0x10F2,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE2D_ARRAY")]
        MemObjectImage2DArray = 0x10F3,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE1D")]
        MemObjectImage1D = 0x10F4,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE1D_ARRAY")]
        MemObjectImage1DArray = 0x10F5,
        [NativeName("Name", "CL_MEM_OBJECT_IMAGE1D_BUFFER")]
        MemObjectImage1DBuffer = 0x10F6,
        [NativeName("Name", "CL_MEM_OBJECT_PIPE")]
        MemObjectPipe = 0x10F7,
    }
}
