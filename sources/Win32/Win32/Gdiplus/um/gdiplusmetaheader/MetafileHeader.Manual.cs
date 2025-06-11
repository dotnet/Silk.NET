// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Win32;
using static Silk.NET.Gdiplus.MetafileType;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public partial struct MetafileHeader
{
    public readonly BOOL IsEmfOrEmfPlus()
    {
        return Type >= MetafileTypeEmf;
    }

    public readonly BOOL IsEmfPlus()
    {
        return Type >= MetafileTypeEmfPlusOnly;
    }
}
