// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PROCESS_MEMORY_EXHAUSTION_TYPE.xml' path='doc/member[@name="PROCESS_MEMORY_EXHAUSTION_TYPE"]/*'/>
[SupportedOSPlatform("windows10.0.10586.0")]
public enum PROCESS_MEMORY_EXHAUSTION_TYPE
{
    /// <include file='PROCESS_MEMORY_EXHAUSTION_TYPE.xml' path='doc/member[@name="PROCESS_MEMORY_EXHAUSTION_TYPE.PMETypeFailFastOnCommitFailure"]/*'/>
    PMETypeFailFastOnCommitFailure,
    /// <include file='PROCESS_MEMORY_EXHAUSTION_TYPE.xml' path='doc/member[@name="PROCESS_MEMORY_EXHAUSTION_TYPE.PMETypeMax"]/*'/>
    PMETypeMax,
}