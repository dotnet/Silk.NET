// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [NativeName("Name", "D3D_BLOB_PART")]
    public enum BlobPart : int
    {
        [NativeName("Name", "D3D_BLOB_INPUT_SIGNATURE_BLOB")]
        BlobInputSignatureBlob = 0x0,
        [NativeName("Name", "D3D_BLOB_OUTPUT_SIGNATURE_BLOB")]
        BlobOutputSignatureBlob = 0x1,
        [NativeName("Name", "D3D_BLOB_INPUT_AND_OUTPUT_SIGNATURE_BLOB")]
        BlobInputAndOutputSignatureBlob = 0x2,
        [NativeName("Name", "D3D_BLOB_PATCH_CONSTANT_SIGNATURE_BLOB")]
        BlobPatchConstantSignatureBlob = 0x3,
        [NativeName("Name", "D3D_BLOB_ALL_SIGNATURE_BLOB")]
        BlobAllSignatureBlob = 0x4,
        [NativeName("Name", "D3D_BLOB_DEBUG_INFO")]
        BlobDebugInfo = 0x5,
        [NativeName("Name", "D3D_BLOB_LEGACY_SHADER")]
        BlobLegacyShader = 0x6,
        [NativeName("Name", "D3D_BLOB_XNA_PREPASS_SHADER")]
        BlobXnaPrepassShader = 0x7,
        [NativeName("Name", "D3D_BLOB_XNA_SHADER")]
        BlobXnaShader = 0x8,
        [NativeName("Name", "D3D_BLOB_PDB")]
        BlobPdb = 0x9,
        [NativeName("Name", "D3D_BLOB_PRIVATE_DATA")]
        BlobPrivateData = 0xA,
        [NativeName("Name", "D3D_BLOB_ROOT_SIGNATURE")]
        BlobRootSignature = 0xB,
        [NativeName("Name", "D3D_BLOB_DEBUG_NAME")]
        BlobDebugName = 0xC,
        [NativeName("Name", "D3D_BLOB_TEST_ALTERNATE_SHADER")]
        BlobTestAlternateShader = 0x8000,
        [NativeName("Name", "D3D_BLOB_TEST_COMPILE_DETAILS")]
        BlobTestCompileDetails = 0x8001,
        [NativeName("Name", "D3D_BLOB_TEST_COMPILE_PERF")]
        BlobTestCompilePerf = 0x8002,
        [NativeName("Name", "D3D_BLOB_TEST_COMPILE_REPORT")]
        BlobTestCompileReport = 0x8003,
    }
}
