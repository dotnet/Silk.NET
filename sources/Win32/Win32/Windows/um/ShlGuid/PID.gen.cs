// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class PID
{
    [NativeTypeName("#define PID_FINDDATA 0")]
    public const int PID_FINDDATA = 0;

    [NativeTypeName("#define PID_NETRESOURCE 1")]
    public const int PID_NETRESOURCE = 1;

    [NativeTypeName("#define PID_DESCRIPTIONID 2")]
    public const int PID_DESCRIPTIONID = 2;

    [NativeTypeName("#define PID_WHICHFOLDER 3")]
    public const int PID_WHICHFOLDER = 3;

    [NativeTypeName("#define PID_NETWORKLOCATION 4")]
    public const int PID_NETWORKLOCATION = 4;

    [NativeTypeName("#define PID_COMPUTERNAME 5")]
    public const int PID_COMPUTERNAME = 5;

    [NativeTypeName("#define PID_DISPLACED_FROM 2")]
    public const int PID_DISPLACED_FROM = 2;

    [NativeTypeName("#define PID_DISPLACED_DATE 3")]
    public const int PID_DISPLACED_DATE = 3;

    [NativeTypeName("#define PID_SYNC_COPY_IN 2")]
    public const int PID_SYNC_COPY_IN = 2;

    [NativeTypeName("#define PID_MISC_STATUS 2")]
    public const int PID_MISC_STATUS = 2;

    [NativeTypeName("#define PID_MISC_ACCESSCOUNT 3")]
    public const int PID_MISC_ACCESSCOUNT = 3;

    [NativeTypeName("#define PID_MISC_OWNER 4")]
    public const int PID_MISC_OWNER = 4;

    [NativeTypeName("#define PID_HTMLINFOTIPFILE 5")]
    public const int PID_HTMLINFOTIPFILE = 5;

    [NativeTypeName("#define PID_MISC_PICS 6")]
    public const int PID_MISC_PICS = 6;

    [NativeTypeName("#define PID_DISPLAY_PROPERTIES 0")]
    public const int PID_DISPLAY_PROPERTIES = 0;

    [NativeTypeName("#define PID_INTROTEXT 1")]
    public const int PID_INTROTEXT = 1;

    [NativeTypeName("#define PID_CONTROLPANEL_CATEGORY 2")]
    public const int PID_CONTROLPANEL_CATEGORY = 2;

    [NativeTypeName("#define PID_VOLUME_FREE 2")]
    public const int PID_VOLUME_FREE = 2;

    [NativeTypeName("#define PID_VOLUME_CAPACITY 3")]
    public const int PID_VOLUME_CAPACITY = 3;

    [NativeTypeName("#define PID_VOLUME_FILESYSTEM 4")]
    public const int PID_VOLUME_FILESYSTEM = 4;

    [NativeTypeName("#define PID_SHARE_CSC_STATUS 2")]
    public const int PID_SHARE_CSC_STATUS = 2;

    [NativeTypeName("#define PID_LINK_TARGET 2")]
    public const int PID_LINK_TARGET = 2;

    [NativeTypeName("#define PID_LINK_TARGET_TYPE 3")]
    public const int PID_LINK_TARGET_TYPE = 3;

    [NativeTypeName("#define PID_QUERY_RANK 2")]
    public const int PID_QUERY_RANK = 2;
}
