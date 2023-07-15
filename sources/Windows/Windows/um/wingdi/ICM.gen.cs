// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class ICM
{
    [NativeTypeName("#define ICM_ADDPROFILE 1")]
    public const int ICM_ADDPROFILE = 1;
    [NativeTypeName("#define ICM_DELETEPROFILE 2")]
    public const int ICM_DELETEPROFILE = 2;
    [NativeTypeName("#define ICM_QUERYPROFILE 3")]
    public const int ICM_QUERYPROFILE = 3;
    [NativeTypeName("#define ICM_SETDEFAULTPROFILE 4")]
    public const int ICM_SETDEFAULTPROFILE = 4;
    [NativeTypeName("#define ICM_REGISTERICMATCHER 5")]
    public const int ICM_REGISTERICMATCHER = 5;
    [NativeTypeName("#define ICM_UNREGISTERICMATCHER 6")]
    public const int ICM_UNREGISTERICMATCHER = 6;
    [NativeTypeName("#define ICM_QUERYMATCH 7")]
    public const int ICM_QUERYMATCH = 7;
    [NativeTypeName("#define ICM_OFF 1")]
    public const int ICM_OFF = 1;
    [NativeTypeName("#define ICM_ON 2")]
    public const int ICM_ON = 2;
    [NativeTypeName("#define ICM_QUERY 3")]
    public const int ICM_QUERY = 3;
    [NativeTypeName("#define ICM_DONE_OUTSIDEDC 4")]
    public const int ICM_DONE_OUTSIDEDC = 4;
}