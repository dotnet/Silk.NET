// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "PrintDocumentPackageCompletion")]
    public enum PrintDocumentPackageCompletion : int
    {
        [Obsolete("Deprecated in favour of \"InProgress\"")]
        [NativeName("Name", "PrintDocumentPackageCompletion_InProgress")]
        PrintDocumentPackageCompletionInProgress = 0x0,
        [Obsolete("Deprecated in favour of \"Completed\"")]
        [NativeName("Name", "PrintDocumentPackageCompletion_Completed")]
        PrintDocumentPackageCompletionCompleted = 0x1,
        [Obsolete("Deprecated in favour of \"Canceled\"")]
        [NativeName("Name", "PrintDocumentPackageCompletion_Canceled")]
        PrintDocumentPackageCompletionCanceled = 0x2,
        [Obsolete("Deprecated in favour of \"Failed\"")]
        [NativeName("Name", "PrintDocumentPackageCompletion_Failed")]
        PrintDocumentPackageCompletionFailed = 0x3,
        [NativeName("Name", "PrintDocumentPackageCompletion_InProgress")]
        InProgress = 0x0,
        [NativeName("Name", "PrintDocumentPackageCompletion_Completed")]
        Completed = 0x1,
        [NativeName("Name", "PrintDocumentPackageCompletion_Canceled")]
        Canceled = 0x2,
        [NativeName("Name", "PrintDocumentPackageCompletion_Failed")]
        Failed = 0x3,
    }
}
