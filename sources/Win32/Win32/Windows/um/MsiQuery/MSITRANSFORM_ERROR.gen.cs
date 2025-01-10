// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MSITRANSFORM_ERROR
{
    MSITRANSFORM_ERROR_ADDEXISTINGROW = 0x00000001,
    MSITRANSFORM_ERROR_DELMISSINGROW = 0x00000002,
    MSITRANSFORM_ERROR_ADDEXISTINGTABLE = 0x00000004,
    MSITRANSFORM_ERROR_DELMISSINGTABLE = 0x00000008,
    MSITRANSFORM_ERROR_UPDATEMISSINGROW = 0x00000010,
    MSITRANSFORM_ERROR_CHANGECODEPAGE = 0x00000020,
    MSITRANSFORM_ERROR_VIEWTRANSFORM = 0x00000100,
}
