// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFPMPSESSION_CREATION_FLAGS.xml' path='doc/member[@name="MFPMPSESSION_CREATION_FLAGS"]/*'/>
public enum MFPMPSESSION_CREATION_FLAGS
{
    /// <include file='MFPMPSESSION_CREATION_FLAGS.xml' path='doc/member[@name="MFPMPSESSION_CREATION_FLAGS.MFPMPSESSION_UNPROTECTED_PROCESS"]/*'/>
    MFPMPSESSION_UNPROTECTED_PROCESS = 0x1,
    /// <include file='MFPMPSESSION_CREATION_FLAGS.xml' path='doc/member[@name="MFPMPSESSION_CREATION_FLAGS.MFPMPSESSION_IN_PROCESS"]/*'/>
    MFPMPSESSION_IN_PROCESS = 0x2,
}