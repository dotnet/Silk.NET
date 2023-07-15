// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3dcompiler.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART"]/*'/>
public enum D3D_BLOB_PART
{
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_INPUT_SIGNATURE_BLOB"]/*'/>
    D3D_BLOB_INPUT_SIGNATURE_BLOB,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_OUTPUT_SIGNATURE_BLOB"]/*'/>
    D3D_BLOB_OUTPUT_SIGNATURE_BLOB,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_INPUT_AND_OUTPUT_SIGNATURE_BLOB"]/*'/>
    D3D_BLOB_INPUT_AND_OUTPUT_SIGNATURE_BLOB,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_PATCH_CONSTANT_SIGNATURE_BLOB"]/*'/>
    D3D_BLOB_PATCH_CONSTANT_SIGNATURE_BLOB,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_ALL_SIGNATURE_BLOB"]/*'/>
    D3D_BLOB_ALL_SIGNATURE_BLOB,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_DEBUG_INFO"]/*'/>
    D3D_BLOB_DEBUG_INFO,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_LEGACY_SHADER"]/*'/>
    D3D_BLOB_LEGACY_SHADER,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_XNA_PREPASS_SHADER"]/*'/>
    D3D_BLOB_XNA_PREPASS_SHADER,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_XNA_SHADER"]/*'/>
    D3D_BLOB_XNA_SHADER,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_PDB"]/*'/>
    D3D_BLOB_PDB,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_PRIVATE_DATA"]/*'/>
    D3D_BLOB_PRIVATE_DATA,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_ROOT_SIGNATURE"]/*'/>
    D3D_BLOB_ROOT_SIGNATURE,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_DEBUG_NAME"]/*'/>
    D3D_BLOB_DEBUG_NAME,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_TEST_ALTERNATE_SHADER"]/*'/>
    D3D_BLOB_TEST_ALTERNATE_SHADER = 0x8000,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_TEST_COMPILE_DETAILS"]/*'/>
    D3D_BLOB_TEST_COMPILE_DETAILS,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_TEST_COMPILE_PERF"]/*'/>
    D3D_BLOB_TEST_COMPILE_PERF,
    /// <include file='D3D_BLOB_PART.xml' path='doc/member[@name="D3D_BLOB_PART.D3D_BLOB_TEST_COMPILE_REPORT"]/*'/>
    D3D_BLOB_TEST_COMPILE_REPORT,
}