// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IO_COUNTERS.xml' path='doc/member[@name="IO_COUNTERS"]/*'/>
public partial struct IO_COUNTERS
{
    /// <include file='IO_COUNTERS.xml' path='doc/member[@name="IO_COUNTERS.ReadOperationCount"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ReadOperationCount;
    /// <include file='IO_COUNTERS.xml' path='doc/member[@name="IO_COUNTERS.WriteOperationCount"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong WriteOperationCount;
    /// <include file='IO_COUNTERS.xml' path='doc/member[@name="IO_COUNTERS.OtherOperationCount"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong OtherOperationCount;
    /// <include file='IO_COUNTERS.xml' path='doc/member[@name="IO_COUNTERS.ReadTransferCount"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ReadTransferCount;
    /// <include file='IO_COUNTERS.xml' path='doc/member[@name="IO_COUNTERS.WriteTransferCount"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong WriteTransferCount;
    /// <include file='IO_COUNTERS.xml' path='doc/member[@name="IO_COUNTERS.OtherTransferCount"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong OtherTransferCount;
}