// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Gdiplus;

/// <include file='GpStatus.xml' path='doc/member[@name="GpStatus"]/*' />
public enum GpStatus
{
    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.Ok"]/*' />
    Ok = 0,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.GenericError"]/*' />
    GenericError = 1,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.InvalidParameter"]/*' />
    InvalidParameter = 2,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.OutOfMemory"]/*' />
    OutOfMemory = 3,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.ObjectBusy"]/*' />
    ObjectBusy = 4,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.InsufficientBuffer"]/*' />
    InsufficientBuffer = 5,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.NotImplemented"]/*' />
    NotImplemented = 6,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.Win32Error"]/*' />
    Win32Error = 7,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.WrongState"]/*' />
    WrongState = 8,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.Aborted"]/*' />
    Aborted = 9,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.FileNotFound"]/*' />
    FileNotFound = 10,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.ValueOverflow"]/*' />
    ValueOverflow = 11,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.AccessDenied"]/*' />
    AccessDenied = 12,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.UnknownImageFormat"]/*' />
    UnknownImageFormat = 13,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.FontFamilyNotFound"]/*' />
    FontFamilyNotFound = 14,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.FontStyleNotFound"]/*' />
    FontStyleNotFound = 15,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.NotTrueTypeFont"]/*' />
    NotTrueTypeFont = 16,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.UnsupportedGdiplusVersion"]/*' />
    UnsupportedGdiplusVersion = 17,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.GdiplusNotInitialized"]/*' />
    GdiplusNotInitialized = 18,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.PropertyNotFound"]/*' />
    PropertyNotFound = 19,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.PropertyNotSupported"]/*' />
    PropertyNotSupported = 20,

    /// <include file='GpStatus.xml' path='doc/member[@name="GpStatus.ProfileNotFound"]/*' />
    ProfileNotFound = 21,
}
