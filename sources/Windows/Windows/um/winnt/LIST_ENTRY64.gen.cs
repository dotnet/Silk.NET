// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LIST_ENTRY64.xml' path='doc/member[@name="LIST_ENTRY64"]/*'/>
public partial struct LIST_ENTRY64
{
    /// <include file='LIST_ENTRY64.xml' path='doc/member[@name="LIST_ENTRY64.Flink"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong Flink;
    /// <include file='LIST_ENTRY64.xml' path='doc/member[@name="LIST_ENTRY64.Blink"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong Blink;
}