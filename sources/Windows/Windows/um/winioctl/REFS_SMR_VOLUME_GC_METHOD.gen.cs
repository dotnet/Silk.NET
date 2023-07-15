// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='REFS_SMR_VOLUME_GC_METHOD.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_METHOD"]/*'/>
public enum REFS_SMR_VOLUME_GC_METHOD
{
    /// <include file='REFS_SMR_VOLUME_GC_METHOD.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_METHOD.SmrGcMethodCompaction"]/*'/>
    SmrGcMethodCompaction = 1,
    /// <include file='REFS_SMR_VOLUME_GC_METHOD.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_METHOD.SmrGcMethodCompression"]/*'/>
    SmrGcMethodCompression = 2,
    /// <include file='REFS_SMR_VOLUME_GC_METHOD.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_METHOD.SmrGcMethodRotation"]/*'/>
    SmrGcMethodRotation = 3,
}