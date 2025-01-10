// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum NameSearchOptions
{
    nsNone = 0,
    nsfCaseSensitive = 0x1,
    nsfCaseInsensitive = 0x2,
    nsfFNameExt = 0x4,
    nsfRegularExpression = 0x8,
    nsfUndecoratedName = 0x10,
    nsCaseSensitive = nsfCaseSensitive,
    nsCaseInsensitive = nsfCaseInsensitive,
    nsFNameExt = (nsfCaseInsensitive | nsfFNameExt),
    nsRegularExpression = (nsfRegularExpression | nsfCaseSensitive),
    nsCaseInRegularExpression = (nsfRegularExpression | nsfCaseInsensitive),
}
