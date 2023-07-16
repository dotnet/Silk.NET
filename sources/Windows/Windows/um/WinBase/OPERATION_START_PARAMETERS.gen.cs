// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='OPERATION_START_PARAMETERS.xml' path='doc/member[@name="OPERATION_START_PARAMETERS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct OPERATION_START_PARAMETERS
{
    /// <include file='OPERATION_START_PARAMETERS.xml' path='doc/member[@name="OPERATION_START_PARAMETERS.Version"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Version;
    /// <include file='OPERATION_START_PARAMETERS.xml' path='doc/member[@name="OPERATION_START_PARAMETERS.OperationId"]/*'/>
    [NativeTypeName("OPERATION_ID")]
    public uint OperationId;
    /// <include file='OPERATION_START_PARAMETERS.xml' path='doc/member[@name="OPERATION_START_PARAMETERS.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
}