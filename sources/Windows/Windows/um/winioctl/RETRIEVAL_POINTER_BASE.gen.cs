// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RETRIEVAL_POINTER_BASE.xml' path='doc/member[@name="RETRIEVAL_POINTER_BASE"]/*'/>
public partial struct RETRIEVAL_POINTER_BASE
{
    /// <include file='RETRIEVAL_POINTER_BASE.xml' path='doc/member[@name="RETRIEVAL_POINTER_BASE.FileAreaOffset"]/*'/>
    public LARGE_INTEGER FileAreaOffset;
}