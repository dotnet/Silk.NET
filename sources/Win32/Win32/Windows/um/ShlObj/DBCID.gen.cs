// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DBCID
{
    public const int DBCID_EMPTY = 0;
    public const int DBCID_ONDRAG = 1;
    public const int DBCID_CLSIDOFBAR = 2;
    public const int DBCID_RESIZE = 3;
    public const int DBCID_GETBAR = 4;
    public const int DBCID_UPDATESIZE = 5;
}
