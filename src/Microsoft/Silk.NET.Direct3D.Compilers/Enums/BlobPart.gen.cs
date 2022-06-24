// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [NativeName("Name", "D3D_BLOB_PART")]
    public enum BlobPart : int
    {
        [Obsolete("Deprecated in favour of \"InputSignatureBlob\"")]
        [NativeName("Name", "D3D_BLOB_INPUT_SIGNATURE_BLOB")]
        BlobInputSignatureBlob = 0x0,
        [Obsolete("Deprecated in favour of \"OutputSignatureBlob\"")]
        [NativeName("Name", "D3D_BLOB_OUTPUT_SIGNATURE_BLOB")]
        BlobOutputSignatureBlob = 0x1,
        [Obsolete("Deprecated in favour of \"InputAndOutputSignatureBlob\"")]
        [NativeName("Name", "D3D_BLOB_INPUT_AND_OUTPUT_SIGNATURE_BLOB")]
        BlobInputAndOutputSignatureBlob = 0x2,
        [Obsolete("Deprecated in favour of \"PatchConstantSignatureBlob\"")]
        [NativeName("Name", "D3D_BLOB_PATCH_CONSTANT_SIGNATURE_BLOB")]
        BlobPatchConstantSignatureBlob = 0x3,
        [Obsolete("Deprecated in favour of \"AllSignatureBlob\"")]
        [NativeName("Name", "D3D_BLOB_ALL_SIGNATURE_BLOB")]
        BlobAllSignatureBlob = 0x4,
        [Obsolete("Deprecated in favour of \"DebugInfo\"")]
        [NativeName("Name", "D3D_BLOB_DEBUG_INFO")]
        BlobDebugInfo = 0x5,
        [Obsolete("Deprecated in favour of \"LegacyShader\"")]
        [NativeName("Name", "D3D_BLOB_LEGACY_SHADER")]
        BlobLegacyShader = 0x6,
        [Obsolete("Deprecated in favour of \"XnaPrepassShader\"")]
        [NativeName("Name", "D3D_BLOB_XNA_PREPASS_SHADER")]
        BlobXnaPrepassShader = 0x7,
        [Obsolete("Deprecated in favour of \"XnaShader\"")]
        [NativeName("Name", "D3D_BLOB_XNA_SHADER")]
        BlobXnaShader = 0x8,
        [Obsolete("Deprecated in favour of \"Pdb\"")]
        [NativeName("Name", "D3D_BLOB_PDB")]
        BlobPdb = 0x9,
        [Obsolete("Deprecated in favour of \"PrivateData\"")]
        [NativeName("Name", "D3D_BLOB_PRIVATE_DATA")]
        BlobPrivateData = 0xA,
        [Obsolete("Deprecated in favour of \"RootSignature\"")]
        [NativeName("Name", "D3D_BLOB_ROOT_SIGNATURE")]
        BlobRootSignature = 0xB,
        [Obsolete("Deprecated in favour of \"DebugName\"")]
        [NativeName("Name", "D3D_BLOB_DEBUG_NAME")]
        BlobDebugName = 0xC,
        [Obsolete("Deprecated in favour of \"TestAlternateShader\"")]
        [NativeName("Name", "D3D_BLOB_TEST_ALTERNATE_SHADER")]
        BlobTestAlternateShader = 0x8000,
        [Obsolete("Deprecated in favour of \"TestCompileDetails\"")]
        [NativeName("Name", "D3D_BLOB_TEST_COMPILE_DETAILS")]
        BlobTestCompileDetails = 0x8001,
        [Obsolete("Deprecated in favour of \"TestCompilePerf\"")]
        [NativeName("Name", "D3D_BLOB_TEST_COMPILE_PERF")]
        BlobTestCompilePerf = 0x8002,
        [Obsolete("Deprecated in favour of \"TestCompileReport\"")]
        [NativeName("Name", "D3D_BLOB_TEST_COMPILE_REPORT")]
        BlobTestCompileReport = 0x8003,
        [NativeName("Name", "D3D_BLOB_INPUT_SIGNATURE_BLOB")]
        InputSignatureBlob = 0x0,
        [NativeName("Name", "D3D_BLOB_OUTPUT_SIGNATURE_BLOB")]
        OutputSignatureBlob = 0x1,
        [NativeName("Name", "D3D_BLOB_INPUT_AND_OUTPUT_SIGNATURE_BLOB")]
        InputAndOutputSignatureBlob = 0x2,
        [NativeName("Name", "D3D_BLOB_PATCH_CONSTANT_SIGNATURE_BLOB")]
        PatchConstantSignatureBlob = 0x3,
        [NativeName("Name", "D3D_BLOB_ALL_SIGNATURE_BLOB")]
        AllSignatureBlob = 0x4,
        [NativeName("Name", "D3D_BLOB_DEBUG_INFO")]
        DebugInfo = 0x5,
        [NativeName("Name", "D3D_BLOB_LEGACY_SHADER")]
        LegacyShader = 0x6,
        [NativeName("Name", "D3D_BLOB_XNA_PREPASS_SHADER")]
        XnaPrepassShader = 0x7,
        [NativeName("Name", "D3D_BLOB_XNA_SHADER")]
        XnaShader = 0x8,
        [NativeName("Name", "D3D_BLOB_PDB")]
        Pdb = 0x9,
        [NativeName("Name", "D3D_BLOB_PRIVATE_DATA")]
        PrivateData = 0xA,
        [NativeName("Name", "D3D_BLOB_ROOT_SIGNATURE")]
        RootSignature = 0xB,
        [NativeName("Name", "D3D_BLOB_DEBUG_NAME")]
        DebugName = 0xC,
        [NativeName("Name", "D3D_BLOB_TEST_ALTERNATE_SHADER")]
        TestAlternateShader = 0x8000,
        [NativeName("Name", "D3D_BLOB_TEST_COMPILE_DETAILS")]
        TestCompileDetails = 0x8001,
        [NativeName("Name", "D3D_BLOB_TEST_COMPILE_PERF")]
        TestCompilePerf = 0x8002,
        [NativeName("Name", "D3D_BLOB_TEST_COMPILE_REPORT")]
        TestCompileReport = 0x8003,
    }
}
