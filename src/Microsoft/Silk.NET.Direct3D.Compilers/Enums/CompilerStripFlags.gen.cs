// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [Flags]
    [NativeName("Name", "D3DCOMPILER_STRIP_FLAGS")]
    public enum CompilerStripFlags : int
    {
        [NativeName("Name", "D3DCOMPILER_STRIP_REFLECTION_DATA")]
        CompilerStripReflectionData = 0x1,
        [NativeName("Name", "D3DCOMPILER_STRIP_DEBUG_INFO")]
        CompilerStripDebugInfo = 0x2,
        [NativeName("Name", "D3DCOMPILER_STRIP_TEST_BLOBS")]
        CompilerStripTestBlobs = 0x4,
        [NativeName("Name", "D3DCOMPILER_STRIP_PRIVATE_DATA")]
        CompilerStripPrivateData = 0x8,
        [NativeName("Name", "D3DCOMPILER_STRIP_ROOT_SIGNATURE")]
        CompilerStripRootSignature = 0x10,
        [NativeName("Name", "D3DCOMPILER_STRIP_FORCE_DWORD")]
        CompilerStripForceDword = 0x7FFFFFFF,
    }
}
