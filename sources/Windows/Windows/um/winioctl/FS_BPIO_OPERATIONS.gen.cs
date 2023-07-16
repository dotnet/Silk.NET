// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FS_BPIO_OPERATIONS.xml' path='doc/member[@name="FS_BPIO_OPERATIONS"]/*'/>
public enum FS_BPIO_OPERATIONS
{
    /// <include file='FS_BPIO_OPERATIONS.xml' path='doc/member[@name="FS_BPIO_OPERATIONS.FS_BPIO_OP_ENABLE"]/*'/>
    FS_BPIO_OP_ENABLE = 1,
    /// <include file='FS_BPIO_OPERATIONS.xml' path='doc/member[@name="FS_BPIO_OPERATIONS.FS_BPIO_OP_DISABLE"]/*'/>
    FS_BPIO_OP_DISABLE = 2,
    /// <include file='FS_BPIO_OPERATIONS.xml' path='doc/member[@name="FS_BPIO_OPERATIONS.FS_BPIO_OP_QUERY"]/*'/>
    FS_BPIO_OP_QUERY = 3,
    /// <include file='FS_BPIO_OPERATIONS.xml' path='doc/member[@name="FS_BPIO_OPERATIONS.FS_BPIO_OP_VOLUME_STACK_PAUSE"]/*'/>
    FS_BPIO_OP_VOLUME_STACK_PAUSE = 4,
    /// <include file='FS_BPIO_OPERATIONS.xml' path='doc/member[@name="FS_BPIO_OPERATIONS.FS_BPIO_OP_VOLUME_STACK_RESUME"]/*'/>
    FS_BPIO_OP_VOLUME_STACK_RESUME = 5,
    /// <include file='FS_BPIO_OPERATIONS.xml' path='doc/member[@name="FS_BPIO_OPERATIONS.FS_BPIO_OP_STREAM_PAUSE"]/*'/>
    FS_BPIO_OP_STREAM_PAUSE = 6,
    /// <include file='FS_BPIO_OPERATIONS.xml' path='doc/member[@name="FS_BPIO_OPERATIONS.FS_BPIO_OP_STREAM_RESUME"]/*'/>
    FS_BPIO_OP_STREAM_RESUME = 7,
    /// <include file='FS_BPIO_OPERATIONS.xml' path='doc/member[@name="FS_BPIO_OPERATIONS.FS_BPIO_OP_GET_INFO"]/*'/>
    FS_BPIO_OP_GET_INFO = 8,
    /// <include file='FS_BPIO_OPERATIONS.xml' path='doc/member[@name="FS_BPIO_OPERATIONS.FS_BPIO_OP_MAX_OPERATION"]/*'/>
    FS_BPIO_OP_MAX_OPERATION,
}