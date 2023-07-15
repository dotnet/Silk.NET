// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CRYPT_ASYNC_RETRIEVAL_COMPLETION.xml' path='doc/member[@name="CRYPT_ASYNC_RETRIEVAL_COMPLETION"]/*'/>
public unsafe partial struct CRYPT_ASYNC_RETRIEVAL_COMPLETION
{
    /// <include file='CRYPT_ASYNC_RETRIEVAL_COMPLETION.xml' path='doc/member[@name="CRYPT_ASYNC_RETRIEVAL_COMPLETION.pfnCompletion"]/*'/>
    [NativeTypeName("PFN_CRYPT_ASYNC_RETRIEVAL_COMPLETION_FUNC")]
    public delegate* unmanaged<void*, uint, sbyte*, sbyte*, void*, void> pfnCompletion;
    /// <include file='CRYPT_ASYNC_RETRIEVAL_COMPLETION.xml' path='doc/member[@name="CRYPT_ASYNC_RETRIEVAL_COMPLETION.pvCompletion"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* pvCompletion;
}