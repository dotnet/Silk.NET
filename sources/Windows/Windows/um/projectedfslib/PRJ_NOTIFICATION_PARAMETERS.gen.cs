// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='PRJ_NOTIFICATION_PARAMETERS.xml' path='doc/member[@name="PRJ_NOTIFICATION_PARAMETERS"]/*'/>
[StructLayout(LayoutKind.Explicit)]
[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct PRJ_NOTIFICATION_PARAMETERS
{
    /// <include file='PRJ_NOTIFICATION_PARAMETERS.xml' path='doc/member[@name="PRJ_NOTIFICATION_PARAMETERS.PostCreate"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_projectedfslib_L407_C5")]
    public _PostCreate_e__Struct PostCreate;
    /// <include file='PRJ_NOTIFICATION_PARAMETERS.xml' path='doc/member[@name="PRJ_NOTIFICATION_PARAMETERS.FileRenamed"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_projectedfslib_L411_C5")]
    public _FileRenamed_e__Struct FileRenamed;
    /// <include file='PRJ_NOTIFICATION_PARAMETERS.xml' path='doc/member[@name="PRJ_NOTIFICATION_PARAMETERS.FileDeletedOnHandleClose"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_projectedfslib_L415_C5")]
    public _FileDeletedOnHandleClose_e__Struct FileDeletedOnHandleClose;
    /// <include file='_PostCreate_e__Struct.xml' path='doc/member[@name="_PostCreate_e__Struct"]/*'/>
    public partial struct _PostCreate_e__Struct
    {
        /// <include file='_PostCreate_e__Struct.xml' path='doc/member[@name="_PostCreate_e__Struct.NotificationMask"]/*'/>
        public PRJ_NOTIFY_TYPES NotificationMask;
    }

    /// <include file='_FileRenamed_e__Struct.xml' path='doc/member[@name="_FileRenamed_e__Struct"]/*'/>
    public partial struct _FileRenamed_e__Struct
    {
        /// <include file='_FileRenamed_e__Struct.xml' path='doc/member[@name="_FileRenamed_e__Struct.NotificationMask"]/*'/>
        public PRJ_NOTIFY_TYPES NotificationMask;
    }

    /// <include file='_FileDeletedOnHandleClose_e__Struct.xml' path='doc/member[@name="_FileDeletedOnHandleClose_e__Struct"]/*'/>
    public partial struct _FileDeletedOnHandleClose_e__Struct
    {
        /// <include file='_FileDeletedOnHandleClose_e__Struct.xml' path='doc/member[@name="_FileDeletedOnHandleClose_e__Struct.IsFileModified"]/*'/>
        [NativeTypeName("BOOLEAN")]
        public byte IsFileModified;
    }
}