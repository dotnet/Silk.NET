// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/guiddef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InlineIsEqualGUID"]/*'/>
    public static int InlineIsEqualGUID([NativeTypeName("const GUID &")] Guid* rguid1, [NativeTypeName("const GUID &")] Guid* rguid2)
    {
        return unchecked(((uint*)(rguid1))[0] == ((uint*)(rguid2))[0] && ((uint*)(rguid1))[1] == ((uint*)(rguid2))[1] && ((uint*)(rguid1))[2] == ((uint*)(rguid2))[2] && ((uint*)(rguid1))[3] == ((uint*)(rguid2))[3]) ? 1 : 0;
    }
}