// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [NativeName("Name", "D3DCOMPILER_STRIP_FLAGS")]
    public enum CompilerStripFlags
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
