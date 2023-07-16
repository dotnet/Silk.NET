// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WRITE_THROUGH.xml' path='doc/member[@name="WRITE_THROUGH"]/*'/>
public enum WRITE_THROUGH
{
    /// <include file='WRITE_THROUGH.xml' path='doc/member[@name="WRITE_THROUGH.WriteThroughUnknown"]/*'/>
    WriteThroughUnknown,
    /// <include file='WRITE_THROUGH.xml' path='doc/member[@name="WRITE_THROUGH.WriteThroughNotSupported"]/*'/>
    WriteThroughNotSupported,
    /// <include file='WRITE_THROUGH.xml' path='doc/member[@name="WRITE_THROUGH.WriteThroughSupported"]/*'/>
    WriteThroughSupported,
}