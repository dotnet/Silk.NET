// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST.xml' path='doc/member[@name="GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST"]/*' />
public partial struct GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST
{
    /// <include file='GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST.xml' path='doc/member[@name="GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST.xml' path='doc/member[@name="GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST.xml' path='doc/member[@name="GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST.RequestDataType"]/*' />
    public DEVICE_INTERNAL_STATUS_DATA_REQUEST_TYPE RequestDataType;

    /// <include file='GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST.xml' path='doc/member[@name="GET_DEVICE_INTERNAL_STATUS_DATA_REQUEST.RequestDataSet"]/*' />
    public DEVICE_INTERNAL_STATUS_DATA_SET RequestDataSet;
}
