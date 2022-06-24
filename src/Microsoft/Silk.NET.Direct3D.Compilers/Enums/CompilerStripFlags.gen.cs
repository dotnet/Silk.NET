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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ReflectionData\"")]
        [NativeName("Name", "D3DCOMPILER_STRIP_REFLECTION_DATA")]
        CompilerStripReflectionData = 0x1,
        [Obsolete("Deprecated in favour of \"DebugInfo\"")]
        [NativeName("Name", "D3DCOMPILER_STRIP_DEBUG_INFO")]
        CompilerStripDebugInfo = 0x2,
        [Obsolete("Deprecated in favour of \"TestBlobs\"")]
        [NativeName("Name", "D3DCOMPILER_STRIP_TEST_BLOBS")]
        CompilerStripTestBlobs = 0x4,
        [Obsolete("Deprecated in favour of \"PrivateData\"")]
        [NativeName("Name", "D3DCOMPILER_STRIP_PRIVATE_DATA")]
        CompilerStripPrivateData = 0x8,
        [Obsolete("Deprecated in favour of \"RootSignature\"")]
        [NativeName("Name", "D3DCOMPILER_STRIP_ROOT_SIGNATURE")]
        CompilerStripRootSignature = 0x10,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DCOMPILER_STRIP_FORCE_DWORD")]
        CompilerStripForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DCOMPILER_STRIP_REFLECTION_DATA")]
        ReflectionData = 0x1,
        [NativeName("Name", "D3DCOMPILER_STRIP_DEBUG_INFO")]
        DebugInfo = 0x2,
        [NativeName("Name", "D3DCOMPILER_STRIP_TEST_BLOBS")]
        TestBlobs = 0x4,
        [NativeName("Name", "D3DCOMPILER_STRIP_PRIVATE_DATA")]
        PrivateData = 0x8,
        [NativeName("Name", "D3DCOMPILER_STRIP_ROOT_SIGNATURE")]
        RootSignature = 0x10,
        [NativeName("Name", "D3DCOMPILER_STRIP_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
