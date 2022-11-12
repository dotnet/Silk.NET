// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_OVERLAPPED_ENTRY")]
    public unsafe partial struct OverlappedEntry
    {
        public OverlappedEntry
        (
            nuint? lpCompletionKey = null,
            Overlapped* lpOverlapped = null,
            nuint? @internal = null,
            uint? dwNumberOfBytesTransferred = null
        ) : this()
        {
            if (lpCompletionKey is not null)
            {
                LpCompletionKey = lpCompletionKey.Value;
            }

            if (lpOverlapped is not null)
            {
                LpOverlapped = lpOverlapped;
            }

            if (@internal is not null)
            {
                Internal = @internal.Value;
            }

            if (dwNumberOfBytesTransferred is not null)
            {
                DwNumberOfBytesTransferred = dwNumberOfBytesTransferred.Value;
            }
        }


        [NativeName("Type", "ULONG_PTR")]
        [NativeName("Type.Name", "ULONG_PTR")]
        [NativeName("Name", "lpCompletionKey")]
        public nuint LpCompletionKey;

        [NativeName("Type", "LPOVERLAPPED")]
        [NativeName("Type.Name", "LPOVERLAPPED")]
        [NativeName("Name", "lpOverlapped")]
        public Overlapped* LpOverlapped;

        [NativeName("Type", "ULONG_PTR")]
        [NativeName("Type.Name", "ULONG_PTR")]
        [NativeName("Name", "Internal")]
        public nuint Internal;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwNumberOfBytesTransferred")]
        public uint DwNumberOfBytesTransferred;
    }
}
