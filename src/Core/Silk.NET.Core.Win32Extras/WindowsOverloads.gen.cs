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
    public static class WindowsOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 44, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int CompareFileTime(this Windows thisApi, [Flow(FlowDirection.In)] Filetime* lpFileTime1, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpFileTime2)
        {
            // SpanOverloader
            return thisApi.CompareFileTime(lpFileTime1, in lpFileTime2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 44, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int CompareFileTime(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpFileTime1, [Flow(FlowDirection.In)] Filetime* lpFileTime2)
        {
            // SpanOverloader
            return thisApi.CompareFileTime(in lpFileTime1.GetPinnableReference(), lpFileTime2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 44, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int CompareFileTime(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpFileTime1, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpFileTime2)
        {
            // SpanOverloader
            return thisApi.CompareFileTime(in lpFileTime1.GetPinnableReference(), in lpFileTime2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 52, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool CreateDirectoryA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpPathName, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryA(lpPathName, ref lpSecurityAttributes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 52, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool CreateDirectoryA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPathName, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryA(in lpPathName.GetPinnableReference(), lpSecurityAttributes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 52, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool CreateDirectoryA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPathName, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryA(in lpPathName.GetPinnableReference(), ref lpSecurityAttributes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 60, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool CreateDirectoryW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpPathName, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryW(lpPathName, ref lpSecurityAttributes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 60, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool CreateDirectoryW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPathName, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryW(in lpPathName.GetPinnableReference(), lpSecurityAttributes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 60, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool CreateDirectoryW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPathName, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryW(in lpPathName.GetPinnableReference(), ref lpSecurityAttributes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpFileName, int dwDesiredAccess, int dwShareMode, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, Span<nint> hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileA(lpFileName, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, ref hTemplateFile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpFileName, int dwDesiredAccess, int dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, nint* hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileA(lpFileName, dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpFileName, int dwDesiredAccess, int dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, Span<nint> hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileA(lpFileName, dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, ref hTemplateFile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, int dwDesiredAccess, int dwShareMode, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, nint* hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileA(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, int dwDesiredAccess, int dwShareMode, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, Span<nint> hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileA(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, ref hTemplateFile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, int dwDesiredAccess, int dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, nint* hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileA(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, int dwDesiredAccess, int dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, Span<nint> hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileA(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, ref hTemplateFile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, int dwDesiredAccess, int dwShareMode, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, Span<nint> hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileW(lpFileName, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, ref hTemplateFile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, int dwDesiredAccess, int dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, nint* hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileW(lpFileName, dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, int dwDesiredAccess, int dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, Span<nint> hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileW(lpFileName, dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, ref hTemplateFile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwDesiredAccess, int dwShareMode, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, nint* hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileW(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwDesiredAccess, int dwShareMode, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, Span<nint> hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileW(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, ref hTemplateFile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwDesiredAccess, int dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, nint* hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileW(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFileW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwDesiredAccess, int dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, int dwCreationDisposition, int dwFlagsAndAttributes, Span<nint> hTemplateFile)
        {
            // SpanOverloader
            return thisApi.CreateFileW(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, ref hTemplateFile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool DefineDosDeviceW(this Windows thisApi, int dwFlags, [Flow(FlowDirection.In)] nint* lpDeviceName, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpTargetPath)
        {
            // SpanOverloader
            return thisApi.DefineDosDeviceW(dwFlags, lpDeviceName, in lpTargetPath.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool DefineDosDeviceW(this Windows thisApi, int dwFlags, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDeviceName, [Flow(FlowDirection.In)] nint* lpTargetPath)
        {
            // SpanOverloader
            return thisApi.DefineDosDeviceW(dwFlags, in lpDeviceName.GetPinnableReference(), lpTargetPath);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool DefineDosDeviceW(this Windows thisApi, int dwFlags, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDeviceName, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpTargetPath)
        {
            // SpanOverloader
            return thisApi.DefineDosDeviceW(dwFlags, in lpDeviceName.GetPinnableReference(), in lpTargetPath.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool DeleteFileA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName)
        {
            // SpanOverloader
            return thisApi.DeleteFileA(in lpFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool DeleteFileW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName)
        {
            // SpanOverloader
            return thisApi.DeleteFileW(in lpFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool DeleteVolumeMountPointW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszVolumeMountPoint)
        {
            // SpanOverloader
            return thisApi.DeleteVolumeMountPointW(in lpszVolumeMountPoint.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FileTimeToLocalFileTime(this Windows thisApi, [Flow(FlowDirection.In)] Filetime* lpFileTime, Span<Filetime> lpLocalFileTime)
        {
            // SpanOverloader
            return thisApi.FileTimeToLocalFileTime(lpFileTime, ref lpLocalFileTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FileTimeToLocalFileTime(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpFileTime, Filetime* lpLocalFileTime)
        {
            // SpanOverloader
            return thisApi.FileTimeToLocalFileTime(in lpFileTime.GetPinnableReference(), lpLocalFileTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FileTimeToLocalFileTime(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpFileTime, Span<Filetime> lpLocalFileTime)
        {
            // SpanOverloader
            return thisApi.FileTimeToLocalFileTime(in lpFileTime.GetPinnableReference(), ref lpLocalFileTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 191, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindClose(this Windows thisApi, Span<nint> hFindFile)
        {
            // SpanOverloader
            return thisApi.FindClose(ref hFindFile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 204, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindCloseChangeNotification(this Windows thisApi, Span<nint> hChangeHandle)
        {
            // SpanOverloader
            return thisApi.FindCloseChangeNotification(ref hChangeHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstChangeNotificationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPathName, bool bWatchSubtree, int dwNotifyFilter)
        {
            // SpanOverloader
            return thisApi.FindFirstChangeNotificationA(in lpPathName.GetPinnableReference(), bWatchSubtree, dwNotifyFilter);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstChangeNotificationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPathName, bool bWatchSubtree, int dwNotifyFilter)
        {
            // SpanOverloader
            return thisApi.FindFirstChangeNotificationW(in lpPathName.GetPinnableReference(), bWatchSubtree, dwNotifyFilter);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpFileName, Span<Win32FindDataa> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileA(lpFileName, ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, Win32FindDataa* lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileA(in lpFileName.GetPinnableReference(), lpFindFileData);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, Span<Win32FindDataa> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileA(in lpFileName.GetPinnableReference(), ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, Span<Win32FindDataw> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileW(lpFileName, ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, Win32FindDataw* lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileW(in lpFileName.GetPinnableReference(), lpFindFileData);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, Span<Win32FindDataw> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileW(in lpFileName.GetPinnableReference(), ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpFileName, FindexInfoLevels fInfoLevelId, nint* lpFindFileData, FindexSearchOps fSearchOp, Span<nint> lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExA(lpFileName, fInfoLevelId, lpFindFileData, fSearchOp, ref lpSearchFilter.GetPinnableReference(), dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpFileName, FindexInfoLevels fInfoLevelId, Span<nint> lpFindFileData, FindexSearchOps fSearchOp, nint* lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExA(lpFileName, fInfoLevelId, ref lpFindFileData.GetPinnableReference(), fSearchOp, lpSearchFilter, dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpFileName, FindexInfoLevels fInfoLevelId, Span<nint> lpFindFileData, FindexSearchOps fSearchOp, Span<nint> lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExA(lpFileName, fInfoLevelId, ref lpFindFileData.GetPinnableReference(), fSearchOp, ref lpSearchFilter.GetPinnableReference(), dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, FindexInfoLevels fInfoLevelId, nint* lpFindFileData, FindexSearchOps fSearchOp, nint* lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExA(in lpFileName.GetPinnableReference(), fInfoLevelId, lpFindFileData, fSearchOp, lpSearchFilter, dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, FindexInfoLevels fInfoLevelId, nint* lpFindFileData, FindexSearchOps fSearchOp, Span<nint> lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExA(in lpFileName.GetPinnableReference(), fInfoLevelId, lpFindFileData, fSearchOp, ref lpSearchFilter.GetPinnableReference(), dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, FindexInfoLevels fInfoLevelId, Span<nint> lpFindFileData, FindexSearchOps fSearchOp, nint* lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExA(in lpFileName.GetPinnableReference(), fInfoLevelId, ref lpFindFileData.GetPinnableReference(), fSearchOp, lpSearchFilter, dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, FindexInfoLevels fInfoLevelId, Span<nint> lpFindFileData, FindexSearchOps fSearchOp, Span<nint> lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExA(in lpFileName.GetPinnableReference(), fInfoLevelId, ref lpFindFileData.GetPinnableReference(), fSearchOp, ref lpSearchFilter.GetPinnableReference(), dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, FindexInfoLevels fInfoLevelId, nint* lpFindFileData, FindexSearchOps fSearchOp, Span<nint> lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExW(lpFileName, fInfoLevelId, lpFindFileData, fSearchOp, ref lpSearchFilter.GetPinnableReference(), dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, FindexInfoLevels fInfoLevelId, Span<nint> lpFindFileData, FindexSearchOps fSearchOp, nint* lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExW(lpFileName, fInfoLevelId, ref lpFindFileData.GetPinnableReference(), fSearchOp, lpSearchFilter, dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, FindexInfoLevels fInfoLevelId, Span<nint> lpFindFileData, FindexSearchOps fSearchOp, Span<nint> lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExW(lpFileName, fInfoLevelId, ref lpFindFileData.GetPinnableReference(), fSearchOp, ref lpSearchFilter.GetPinnableReference(), dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, FindexInfoLevels fInfoLevelId, nint* lpFindFileData, FindexSearchOps fSearchOp, nint* lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExW(in lpFileName.GetPinnableReference(), fInfoLevelId, lpFindFileData, fSearchOp, lpSearchFilter, dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, FindexInfoLevels fInfoLevelId, nint* lpFindFileData, FindexSearchOps fSearchOp, Span<nint> lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExW(in lpFileName.GetPinnableReference(), fInfoLevelId, lpFindFileData, fSearchOp, ref lpSearchFilter.GetPinnableReference(), dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, FindexInfoLevels fInfoLevelId, Span<nint> lpFindFileData, FindexSearchOps fSearchOp, nint* lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExW(in lpFileName.GetPinnableReference(), fInfoLevelId, ref lpFindFileData.GetPinnableReference(), fSearchOp, lpSearchFilter, dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, FindexInfoLevels fInfoLevelId, Span<nint> lpFindFileData, FindexSearchOps fSearchOp, Span<nint> lpSearchFilter, int dwAdditionalFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstFileExW(in lpFileName.GetPinnableReference(), fInfoLevelId, ref lpFindFileData.GetPinnableReference(), fSearchOp, ref lpSearchFilter.GetPinnableReference(), dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstVolumeW(this Windows thisApi, Span<char> lpszVolumeName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.FindFirstVolumeW(ref lpszVolumeName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextChangeNotification(this Windows thisApi, Span<nint> hChangeHandle)
        {
            // SpanOverloader
            return thisApi.FindNextChangeNotification(ref hChangeHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileA(this Windows thisApi, nint* hFindFile, Span<Win32FindDataa> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindNextFileA(hFindFile, ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileA(this Windows thisApi, Span<nint> hFindFile, Win32FindDataa* lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindNextFileA(ref hFindFile.GetPinnableReference(), lpFindFileData);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileA(this Windows thisApi, Span<nint> hFindFile, Span<Win32FindDataa> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindNextFileA(ref hFindFile.GetPinnableReference(), ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 333, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileW(this Windows thisApi, nint* hFindFile, Span<Win32FindDataw> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindNextFileW(hFindFile, ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 333, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileW(this Windows thisApi, Span<nint> hFindFile, Win32FindDataw* lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindNextFileW(ref hFindFile.GetPinnableReference(), lpFindFileData);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 333, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileW(this Windows thisApi, Span<nint> hFindFile, Span<Win32FindDataw> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindNextFileW(ref hFindFile.GetPinnableReference(), ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextVolumeW(this Windows thisApi, nint* hFindVolume, Span<char> lpszVolumeName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.FindNextVolumeW(hFindVolume, ref lpszVolumeName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextVolumeW(this Windows thisApi, Span<nint> hFindVolume, char* lpszVolumeName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.FindNextVolumeW(ref hFindVolume.GetPinnableReference(), lpszVolumeName, cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextVolumeW(this Windows thisApi, Span<nint> hFindVolume, Span<char> lpszVolumeName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.FindNextVolumeW(ref hFindVolume.GetPinnableReference(), ref lpszVolumeName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextVolumeW(this Windows thisApi, Span<nint> hFindVolume, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszVolumeName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.FindNextVolumeW(ref hFindVolume.GetPinnableReference(), lpszVolumeName, cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindVolumeClose(this Windows thisApi, Span<nint> hFindVolume)
        {
            // SpanOverloader
            return thisApi.FindVolumeClose(ref hFindVolume.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 378, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FlushFileBuffers(this Windows thisApi, Span<nint> hFile)
        {
            // SpanOverloader
            return thisApi.FlushFileBuffers(ref hFile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 534, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetDiskSpaceInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* rootPath, Span<DiskSpaceInformation> diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationA(rootPath, ref diskSpaceInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 534, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetDiskSpaceInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> rootPath, DiskSpaceInformation* diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationA(in rootPath.GetPinnableReference(), diskSpaceInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 534, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetDiskSpaceInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> rootPath, Span<DiskSpaceInformation> diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationA(in rootPath.GetPinnableReference(), ref diskSpaceInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetDiskSpaceInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* rootPath, Span<DiskSpaceInformation> diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationW(rootPath, ref diskSpaceInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetDiskSpaceInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> rootPath, DiskSpaceInformation* diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationW(in rootPath.GetPinnableReference(), diskSpaceInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetDiskSpaceInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> rootPath, Span<DiskSpaceInformation> diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationW(in rootPath.GetPinnableReference(), ref diskSpaceInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 561, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetDriveTypeA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName)
        {
            // SpanOverloader
            return thisApi.GetDriveTypeA(in lpRootPathName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 568, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetDriveTypeW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName)
        {
            // SpanOverloader
            return thisApi.GetDriveTypeW(in lpRootPathName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFileAttributesA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName)
        {
            // SpanOverloader
            return thisApi.GetFileAttributesA(in lpFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 596, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFileAttributesW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName)
        {
            // SpanOverloader
            return thisApi.GetFileAttributesW(in lpFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 608, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileAttributesExA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpFileName, GetFileexInfoLevels fInfoLevelId, Span<nint> lpFileInformation)
        {
            // SpanOverloader
            return thisApi.GetFileAttributesExA(lpFileName, fInfoLevelId, ref lpFileInformation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 608, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileAttributesExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, GetFileexInfoLevels fInfoLevelId, nint* lpFileInformation)
        {
            // SpanOverloader
            return thisApi.GetFileAttributesExA(in lpFileName.GetPinnableReference(), fInfoLevelId, lpFileInformation);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 608, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileAttributesExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, GetFileexInfoLevels fInfoLevelId, Span<nint> lpFileInformation)
        {
            // SpanOverloader
            return thisApi.GetFileAttributesExA(in lpFileName.GetPinnableReference(), fInfoLevelId, ref lpFileInformation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileAttributesExW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, GetFileexInfoLevels fInfoLevelId, Span<nint> lpFileInformation)
        {
            // SpanOverloader
            return thisApi.GetFileAttributesExW(lpFileName, fInfoLevelId, ref lpFileInformation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileAttributesExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, GetFileexInfoLevels fInfoLevelId, nint* lpFileInformation)
        {
            // SpanOverloader
            return thisApi.GetFileAttributesExW(in lpFileName.GetPinnableReference(), fInfoLevelId, lpFileInformation);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileAttributesExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, GetFileexInfoLevels fInfoLevelId, Span<nint> lpFileInformation)
        {
            // SpanOverloader
            return thisApi.GetFileAttributesExW(in lpFileName.GetPinnableReference(), fInfoLevelId, ref lpFileInformation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 644, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileInformationByHandle(this Windows thisApi, nint* hFile, Span<ByHandleFileInformation> lpFileInformation)
        {
            // SpanOverloader
            return thisApi.GetFileInformationByHandle(hFile, ref lpFileInformation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 644, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileInformationByHandle(this Windows thisApi, Span<nint> hFile, ByHandleFileInformation* lpFileInformation)
        {
            // SpanOverloader
            return thisApi.GetFileInformationByHandle(ref hFile.GetPinnableReference(), lpFileInformation);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 644, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileInformationByHandle(this Windows thisApi, Span<nint> hFile, Span<ByHandleFileInformation> lpFileInformation)
        {
            // SpanOverloader
            return thisApi.GetFileInformationByHandle(ref hFile.GetPinnableReference(), ref lpFileInformation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFileSize(this Windows thisApi, nint* hFile, Span<uint> lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetFileSize(hFile, ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFileSize(this Windows thisApi, Span<nint> hFile, uint* lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetFileSize(ref hFile.GetPinnableReference(), lpFileSizeHigh);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFileSize(this Windows thisApi, Span<nint> hFile, Span<uint> lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetFileSize(ref hFile.GetPinnableReference(), ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 672, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileSizeEx(this Windows thisApi, nint* hFile, Span<long> lpFileSize)
        {
            // SpanOverloader
            return thisApi.GetFileSizeEx(hFile, ref lpFileSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 672, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileSizeEx(this Windows thisApi, Span<nint> hFile, long* lpFileSize)
        {
            // SpanOverloader
            return thisApi.GetFileSizeEx(ref hFile.GetPinnableReference(), lpFileSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 672, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileSizeEx(this Windows thisApi, Span<nint> hFile, Span<long> lpFileSize)
        {
            // SpanOverloader
            return thisApi.GetFileSizeEx(ref hFile.GetPinnableReference(), ref lpFileSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 680, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFileType(this Windows thisApi, Span<nint> hFile)
        {
            // SpanOverloader
            return thisApi.GetFileType(ref hFile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFinalPathNameByHandleA(this Windows thisApi, nint* hFile, Span<byte> lpszFilePath, int cchFilePath, int dwFlags)
        {
            // SpanOverloader
            return thisApi.GetFinalPathNameByHandleA(hFile, ref lpszFilePath.GetPinnableReference(), cchFilePath, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFinalPathNameByHandleA(this Windows thisApi, Span<nint> hFile, byte* lpszFilePath, int cchFilePath, int dwFlags)
        {
            // SpanOverloader
            return thisApi.GetFinalPathNameByHandleA(ref hFile.GetPinnableReference(), lpszFilePath, cchFilePath, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFinalPathNameByHandleA(this Windows thisApi, Span<nint> hFile, Span<byte> lpszFilePath, int cchFilePath, int dwFlags)
        {
            // SpanOverloader
            return thisApi.GetFinalPathNameByHandleA(ref hFile.GetPinnableReference(), ref lpszFilePath.GetPinnableReference(), cchFilePath, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFinalPathNameByHandleA(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpszFilePath, int cchFilePath, int dwFlags)
        {
            // SpanOverloader
            return thisApi.GetFinalPathNameByHandleA(ref hFile.GetPinnableReference(), lpszFilePath, cchFilePath, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 699, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFinalPathNameByHandleW(this Windows thisApi, nint* hFile, Span<char> lpszFilePath, int cchFilePath, int dwFlags)
        {
            // SpanOverloader
            return thisApi.GetFinalPathNameByHandleW(hFile, ref lpszFilePath.GetPinnableReference(), cchFilePath, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 699, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFinalPathNameByHandleW(this Windows thisApi, Span<nint> hFile, char* lpszFilePath, int cchFilePath, int dwFlags)
        {
            // SpanOverloader
            return thisApi.GetFinalPathNameByHandleW(ref hFile.GetPinnableReference(), lpszFilePath, cchFilePath, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 699, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFinalPathNameByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpszFilePath, int cchFilePath, int dwFlags)
        {
            // SpanOverloader
            return thisApi.GetFinalPathNameByHandleW(ref hFile.GetPinnableReference(), ref lpszFilePath.GetPinnableReference(), cchFilePath, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 699, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFinalPathNameByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszFilePath, int cchFilePath, int dwFlags)
        {
            // SpanOverloader
            return thisApi.GetFinalPathNameByHandleW(ref hFile.GetPinnableReference(), lpszFilePath, cchFilePath, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, nint* hFile, Filetime* lpCreationTime, Filetime* lpLastAccessTime, Span<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(hFile, lpCreationTime, lpLastAccessTime, ref lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, nint* hFile, Filetime* lpCreationTime, Span<Filetime> lpLastAccessTime, Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(hFile, lpCreationTime, ref lpLastAccessTime.GetPinnableReference(), lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, nint* hFile, Filetime* lpCreationTime, Span<Filetime> lpLastAccessTime, Span<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(hFile, lpCreationTime, ref lpLastAccessTime.GetPinnableReference(), ref lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, nint* hFile, Span<Filetime> lpCreationTime, Filetime* lpLastAccessTime, Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(hFile, ref lpCreationTime.GetPinnableReference(), lpLastAccessTime, lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, nint* hFile, Span<Filetime> lpCreationTime, Filetime* lpLastAccessTime, Span<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(hFile, ref lpCreationTime.GetPinnableReference(), lpLastAccessTime, ref lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, nint* hFile, Span<Filetime> lpCreationTime, Span<Filetime> lpLastAccessTime, Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(hFile, ref lpCreationTime.GetPinnableReference(), ref lpLastAccessTime.GetPinnableReference(), lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, nint* hFile, Span<Filetime> lpCreationTime, Span<Filetime> lpLastAccessTime, Span<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(hFile, ref lpCreationTime.GetPinnableReference(), ref lpLastAccessTime.GetPinnableReference(), ref lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, Span<nint> hFile, Filetime* lpCreationTime, Filetime* lpLastAccessTime, Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(ref hFile.GetPinnableReference(), lpCreationTime, lpLastAccessTime, lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, Span<nint> hFile, Filetime* lpCreationTime, Filetime* lpLastAccessTime, Span<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(ref hFile.GetPinnableReference(), lpCreationTime, lpLastAccessTime, ref lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, Span<nint> hFile, Filetime* lpCreationTime, Span<Filetime> lpLastAccessTime, Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(ref hFile.GetPinnableReference(), lpCreationTime, ref lpLastAccessTime.GetPinnableReference(), lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, Span<nint> hFile, Filetime* lpCreationTime, Span<Filetime> lpLastAccessTime, Span<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(ref hFile.GetPinnableReference(), lpCreationTime, ref lpLastAccessTime.GetPinnableReference(), ref lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, Span<nint> hFile, Span<Filetime> lpCreationTime, Filetime* lpLastAccessTime, Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(ref hFile.GetPinnableReference(), ref lpCreationTime.GetPinnableReference(), lpLastAccessTime, lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, Span<nint> hFile, Span<Filetime> lpCreationTime, Filetime* lpLastAccessTime, Span<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(ref hFile.GetPinnableReference(), ref lpCreationTime.GetPinnableReference(), lpLastAccessTime, ref lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, Span<nint> hFile, Span<Filetime> lpCreationTime, Span<Filetime> lpLastAccessTime, Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(ref hFile.GetPinnableReference(), ref lpCreationTime.GetPinnableReference(), ref lpLastAccessTime.GetPinnableReference(), lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetFileTime(this Windows thisApi, Span<nint> hFile, Span<Filetime> lpCreationTime, Span<Filetime> lpLastAccessTime, Span<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.GetFileTime(ref hFile.GetPinnableReference(), ref lpCreationTime.GetPinnableReference(), ref lpLastAccessTime.GetPinnableReference(), ref lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, int nBufferLength, Span<char> lpBuffer, char** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(lpFileName, nBufferLength, ref lpBuffer.GetPinnableReference(), lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, int nBufferLength, Span<char> lpBuffer, ref char* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(lpFileName, nBufferLength, ref lpBuffer.GetPinnableReference(), ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int nBufferLength, char* lpBuffer, char** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int nBufferLength, char* lpBuffer, ref char* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int nBufferLength, Span<char> lpBuffer, char** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(in lpFileName.GetPinnableReference(), nBufferLength, ref lpBuffer.GetPinnableReference(), lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int nBufferLength, Span<char> lpBuffer, ref char* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(in lpFileName.GetPinnableReference(), nBufferLength, ref lpBuffer.GetPinnableReference(), ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int nBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpBuffer, char** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int nBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpBuffer, ref char* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpFileName, int nBufferLength, Span<byte> lpBuffer, byte** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(lpFileName, nBufferLength, ref lpBuffer.GetPinnableReference(), lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpFileName, int nBufferLength, Span<byte> lpBuffer, ref byte* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(lpFileName, nBufferLength, ref lpBuffer.GetPinnableReference(), ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, int nBufferLength, byte* lpBuffer, byte** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, int nBufferLength, byte* lpBuffer, ref byte* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, int nBufferLength, Span<byte> lpBuffer, byte** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(in lpFileName.GetPinnableReference(), nBufferLength, ref lpBuffer.GetPinnableReference(), lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, int nBufferLength, Span<byte> lpBuffer, ref byte* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(in lpFileName.GetPinnableReference(), nBufferLength, ref lpBuffer.GetPinnableReference(), ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, int nBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, int nBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpBuffer, ref byte* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetLogicalDriveStringsW(this Windows thisApi, int nBufferLength, Span<char> lpBuffer)
        {
            // SpanOverloader
            return thisApi.GetLogicalDriveStringsW(nBufferLength, ref lpBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 788, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetLongPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpszShortPath, Span<byte> lpszLongPath, int cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameA(lpszShortPath, ref lpszLongPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 788, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetLongPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpszShortPath, byte* lpszLongPath, int cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameA(in lpszShortPath.GetPinnableReference(), lpszLongPath, cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 788, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetLongPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpszShortPath, Span<byte> lpszLongPath, int cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameA(in lpszShortPath.GetPinnableReference(), ref lpszLongPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 788, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetLongPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpszShortPath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpszLongPath, int cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameA(in lpszShortPath.GetPinnableReference(), lpszLongPath, cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 802, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetLongPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpszShortPath, Span<char> lpszLongPath, int cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameW(lpszShortPath, ref lpszLongPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 802, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetLongPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszShortPath, char* lpszLongPath, int cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameW(in lpszShortPath.GetPinnableReference(), lpszLongPath, cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 802, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetLongPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszShortPath, Span<char> lpszLongPath, int cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameW(in lpszShortPath.GetPinnableReference(), ref lpszLongPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 802, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetLongPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszShortPath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszLongPath, int cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameW(in lpszShortPath.GetPinnableReference(), lpszLongPath, cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 823, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool AreShortNamesEnabled(this Windows thisApi, nint* Handle, Span<int> Enabled)
        {
            // SpanOverloader
            return thisApi.AreShortNamesEnabled(Handle, ref Enabled.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 823, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool AreShortNamesEnabled(this Windows thisApi, Span<nint> Handle, int* Enabled)
        {
            // SpanOverloader
            return thisApi.AreShortNamesEnabled(ref Handle.GetPinnableReference(), Enabled);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 823, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool AreShortNamesEnabled(this Windows thisApi, Span<nint> Handle, Span<int> Enabled)
        {
            // SpanOverloader
            return thisApi.AreShortNamesEnabled(ref Handle.GetPinnableReference(), ref Enabled.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetShortPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpszLongPath, Span<char> lpszShortPath, int cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetShortPathNameW(lpszLongPath, ref lpszShortPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetShortPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszLongPath, char* lpszShortPath, int cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetShortPathNameW(in lpszLongPath.GetPinnableReference(), lpszShortPath, cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetShortPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszLongPath, Span<char> lpszShortPath, int cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetShortPathNameW(in lpszLongPath.GetPinnableReference(), ref lpszShortPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetShortPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszLongPath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszShortPath, int cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetShortPathNameW(in lpszLongPath.GetPinnableReference(), lpszShortPath, cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpPathName, [Flow(FlowDirection.In)] nint* lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPrefixString, uint uUnique, char* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPathName, [Flow(FlowDirection.In)] nint* lpPrefixString, uint uUnique, char* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPathName, [Flow(FlowDirection.In)] nint* lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPathName, [Flow(FlowDirection.In)] nint* lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPrefixString, uint uUnique, char* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), in lpPrefixString.GetPinnableReference(), uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, nint* hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(hFile, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationByHandleW(this Windows thisApi, Span<nint> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationByHandleW(ref hFile.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, char* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, Span<char> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpszFileName, Span<char> lpszVolumePathName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNameW(lpszFileName, ref lpszVolumePathName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszFileName, char* lpszVolumePathName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNameW(in lpszFileName.GetPinnableReference(), lpszVolumePathName, cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszFileName, Span<char> lpszVolumePathName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNameW(in lpszFileName.GetPinnableReference(), ref lpszVolumePathName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszFileName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszVolumePathName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNameW(in lpszFileName.GetPinnableReference(), lpszVolumePathName, cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool LocalFileTimeToFileTime(this Windows thisApi, [Flow(FlowDirection.In)] Filetime* lpLocalFileTime, Span<Filetime> lpFileTime)
        {
            // SpanOverloader
            return thisApi.LocalFileTimeToFileTime(lpLocalFileTime, ref lpFileTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool LocalFileTimeToFileTime(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLocalFileTime, Filetime* lpFileTime)
        {
            // SpanOverloader
            return thisApi.LocalFileTimeToFileTime(in lpLocalFileTime.GetPinnableReference(), lpFileTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool LocalFileTimeToFileTime(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLocalFileTime, Span<Filetime> lpFileTime)
        {
            // SpanOverloader
            return thisApi.LocalFileTimeToFileTime(in lpLocalFileTime.GetPinnableReference(), ref lpFileTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool LockFile(this Windows thisApi, Span<nint> hFile, int dwFileOffsetLow, int dwFileOffsetHigh, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh)
        {
            // SpanOverloader
            return thisApi.LockFile(ref hFile.GetPinnableReference(), dwFileOffsetLow, dwFileOffsetHigh, nNumberOfBytesToLockLow, nNumberOfBytesToLockHigh);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 941, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool LockFileEx(this Windows thisApi, nint* hFile, int dwFlags, int dwReserved, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.LockFileEx(hFile, dwFlags, dwReserved, nNumberOfBytesToLockLow, nNumberOfBytesToLockHigh, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 941, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool LockFileEx(this Windows thisApi, Span<nint> hFile, int dwFlags, int dwReserved, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.LockFileEx(ref hFile.GetPinnableReference(), dwFlags, dwReserved, nNumberOfBytesToLockLow, nNumberOfBytesToLockHigh, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 941, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool LockFileEx(this Windows thisApi, Span<nint> hFile, int dwFlags, int dwReserved, int nNumberOfBytesToLockLow, int nNumberOfBytesToLockHigh, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.LockFileEx(ref hFile.GetPinnableReference(), dwFlags, dwReserved, nNumberOfBytesToLockLow, nNumberOfBytesToLockHigh, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int QueryDosDeviceW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpDeviceName, Span<char> lpTargetPath, int ucchMax)
        {
            // SpanOverloader
            return thisApi.QueryDosDeviceW(lpDeviceName, ref lpTargetPath.GetPinnableReference(), ucchMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int QueryDosDeviceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDeviceName, char* lpTargetPath, int ucchMax)
        {
            // SpanOverloader
            return thisApi.QueryDosDeviceW(in lpDeviceName.GetPinnableReference(), lpTargetPath, ucchMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int QueryDosDeviceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDeviceName, Span<char> lpTargetPath, int ucchMax)
        {
            // SpanOverloader
            return thisApi.QueryDosDeviceW(in lpDeviceName.GetPinnableReference(), ref lpTargetPath.GetPinnableReference(), ucchMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int QueryDosDeviceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpDeviceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpTargetPath, int ucchMax)
        {
            // SpanOverloader
            return thisApi.QueryDosDeviceW(in lpDeviceName.GetPinnableReference(), lpTargetPath, ucchMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, nint* hFile, nint* lpBuffer, int nNumberOfBytesToRead, uint* lpNumberOfBytesRead, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(hFile, lpBuffer, nNumberOfBytesToRead, lpNumberOfBytesRead, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, nint* hFile, nint* lpBuffer, int nNumberOfBytesToRead, Span<uint> lpNumberOfBytesRead, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(hFile, lpBuffer, nNumberOfBytesToRead, ref lpNumberOfBytesRead.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, nint* hFile, nint* lpBuffer, int nNumberOfBytesToRead, Span<uint> lpNumberOfBytesRead, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(hFile, lpBuffer, nNumberOfBytesToRead, ref lpNumberOfBytesRead.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, nint* hFile, Span<nint> lpBuffer, int nNumberOfBytesToRead, uint* lpNumberOfBytesRead, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(hFile, ref lpBuffer.GetPinnableReference(), nNumberOfBytesToRead, lpNumberOfBytesRead, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, nint* hFile, Span<nint> lpBuffer, int nNumberOfBytesToRead, uint* lpNumberOfBytesRead, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(hFile, ref lpBuffer.GetPinnableReference(), nNumberOfBytesToRead, lpNumberOfBytesRead, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, nint* hFile, Span<nint> lpBuffer, int nNumberOfBytesToRead, Span<uint> lpNumberOfBytesRead, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(hFile, ref lpBuffer.GetPinnableReference(), nNumberOfBytesToRead, ref lpNumberOfBytesRead.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, nint* hFile, Span<nint> lpBuffer, int nNumberOfBytesToRead, Span<uint> lpNumberOfBytesRead, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(hFile, ref lpBuffer.GetPinnableReference(), nNumberOfBytesToRead, ref lpNumberOfBytesRead.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, Span<nint> hFile, nint* lpBuffer, int nNumberOfBytesToRead, uint* lpNumberOfBytesRead, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(ref hFile.GetPinnableReference(), lpBuffer, nNumberOfBytesToRead, lpNumberOfBytesRead, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, Span<nint> hFile, nint* lpBuffer, int nNumberOfBytesToRead, uint* lpNumberOfBytesRead, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(ref hFile.GetPinnableReference(), lpBuffer, nNumberOfBytesToRead, lpNumberOfBytesRead, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, Span<nint> hFile, nint* lpBuffer, int nNumberOfBytesToRead, Span<uint> lpNumberOfBytesRead, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(ref hFile.GetPinnableReference(), lpBuffer, nNumberOfBytesToRead, ref lpNumberOfBytesRead.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, Span<nint> hFile, nint* lpBuffer, int nNumberOfBytesToRead, Span<uint> lpNumberOfBytesRead, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(ref hFile.GetPinnableReference(), lpBuffer, nNumberOfBytesToRead, ref lpNumberOfBytesRead.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, Span<nint> hFile, Span<nint> lpBuffer, int nNumberOfBytesToRead, uint* lpNumberOfBytesRead, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(ref hFile.GetPinnableReference(), ref lpBuffer.GetPinnableReference(), nNumberOfBytesToRead, lpNumberOfBytesRead, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, Span<nint> hFile, Span<nint> lpBuffer, int nNumberOfBytesToRead, uint* lpNumberOfBytesRead, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(ref hFile.GetPinnableReference(), ref lpBuffer.GetPinnableReference(), nNumberOfBytesToRead, lpNumberOfBytesRead, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, Span<nint> hFile, Span<nint> lpBuffer, int nNumberOfBytesToRead, Span<uint> lpNumberOfBytesRead, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(ref hFile.GetPinnableReference(), ref lpBuffer.GetPinnableReference(), nNumberOfBytesToRead, ref lpNumberOfBytesRead.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFile(this Windows thisApi, Span<nint> hFile, Span<nint> lpBuffer, int nNumberOfBytesToRead, Span<uint> lpNumberOfBytesRead, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFile(ref hFile.GetPinnableReference(), ref lpBuffer.GetPinnableReference(), nNumberOfBytesToRead, ref lpNumberOfBytesRead.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileEx(this Windows thisApi, nint* hFile, nint* lpBuffer, int nNumberOfBytesToRead, Span<Overlapped> lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine)
        {
            // SpanOverloader
            return thisApi.ReadFileEx(hFile, lpBuffer, nNumberOfBytesToRead, ref lpOverlapped.GetPinnableReference(), lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileEx(this Windows thisApi, nint* hFile, Span<nint> lpBuffer, int nNumberOfBytesToRead, Overlapped* lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine)
        {
            // SpanOverloader
            return thisApi.ReadFileEx(hFile, ref lpBuffer.GetPinnableReference(), nNumberOfBytesToRead, lpOverlapped, lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileEx(this Windows thisApi, nint* hFile, Span<nint> lpBuffer, int nNumberOfBytesToRead, Span<Overlapped> lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine)
        {
            // SpanOverloader
            return thisApi.ReadFileEx(hFile, ref lpBuffer.GetPinnableReference(), nNumberOfBytesToRead, ref lpOverlapped.GetPinnableReference(), lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileEx(this Windows thisApi, Span<nint> hFile, nint* lpBuffer, int nNumberOfBytesToRead, Overlapped* lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine)
        {
            // SpanOverloader
            return thisApi.ReadFileEx(ref hFile.GetPinnableReference(), lpBuffer, nNumberOfBytesToRead, lpOverlapped, lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileEx(this Windows thisApi, Span<nint> hFile, nint* lpBuffer, int nNumberOfBytesToRead, Span<Overlapped> lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine)
        {
            // SpanOverloader
            return thisApi.ReadFileEx(ref hFile.GetPinnableReference(), lpBuffer, nNumberOfBytesToRead, ref lpOverlapped.GetPinnableReference(), lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileEx(this Windows thisApi, Span<nint> hFile, Span<nint> lpBuffer, int nNumberOfBytesToRead, Overlapped* lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine)
        {
            // SpanOverloader
            return thisApi.ReadFileEx(ref hFile.GetPinnableReference(), ref lpBuffer.GetPinnableReference(), nNumberOfBytesToRead, lpOverlapped, lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileEx(this Windows thisApi, Span<nint> hFile, Span<nint> lpBuffer, int nNumberOfBytesToRead, Span<Overlapped> lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine)
        {
            // SpanOverloader
            return thisApi.ReadFileEx(ref hFile.GetPinnableReference(), ref lpBuffer.GetPinnableReference(), nNumberOfBytesToRead, ref lpOverlapped.GetPinnableReference(), lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, nint* hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToRead, uint* lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(hFile, aSegmentArray, nNumberOfBytesToRead, lpReserved, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, nint* hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToRead, Span<uint> lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(hFile, aSegmentArray, nNumberOfBytesToRead, ref lpReserved.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, nint* hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToRead, Span<uint> lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(hFile, aSegmentArray, nNumberOfBytesToRead, ref lpReserved.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, nint* hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToRead, uint* lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(hFile, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToRead, lpReserved, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, nint* hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToRead, uint* lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(hFile, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToRead, lpReserved, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, nint* hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToRead, Span<uint> lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(hFile, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToRead, ref lpReserved.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, nint* hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToRead, Span<uint> lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(hFile, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToRead, ref lpReserved.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, Span<nint> hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToRead, uint* lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(ref hFile.GetPinnableReference(), aSegmentArray, nNumberOfBytesToRead, lpReserved, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, Span<nint> hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToRead, uint* lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(ref hFile.GetPinnableReference(), aSegmentArray, nNumberOfBytesToRead, lpReserved, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, Span<nint> hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToRead, Span<uint> lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(ref hFile.GetPinnableReference(), aSegmentArray, nNumberOfBytesToRead, ref lpReserved.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, Span<nint> hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToRead, Span<uint> lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(ref hFile.GetPinnableReference(), aSegmentArray, nNumberOfBytesToRead, ref lpReserved.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, Span<nint> hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToRead, uint* lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(ref hFile.GetPinnableReference(), ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToRead, lpReserved, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, Span<nint> hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToRead, uint* lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(ref hFile.GetPinnableReference(), ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToRead, lpReserved, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, Span<nint> hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToRead, Span<uint> lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(ref hFile.GetPinnableReference(), ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToRead, ref lpReserved.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool ReadFileScatter(this Windows thisApi, Span<nint> hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToRead, Span<uint> lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.ReadFileScatter(ref hFile.GetPinnableReference(), ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToRead, ref lpReserved.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool RemoveDirectoryA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPathName)
        {
            // SpanOverloader
            return thisApi.RemoveDirectoryA(in lpPathName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1021, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool RemoveDirectoryW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpPathName)
        {
            // SpanOverloader
            return thisApi.RemoveDirectoryW(in lpPathName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1033, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetEndOfFile(this Windows thisApi, Span<nint> hFile)
        {
            // SpanOverloader
            return thisApi.SetEndOfFile(ref hFile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileAttributesA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, int dwFileAttributes)
        {
            // SpanOverloader
            return thisApi.SetFileAttributesA(in lpFileName.GetPinnableReference(), dwFileAttributes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileAttributesW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwFileAttributes)
        {
            // SpanOverloader
            return thisApi.SetFileAttributesW(in lpFileName.GetPinnableReference(), dwFileAttributes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileInformationByHandle(this Windows thisApi, nint* hFile, FileInfoByHandleClass FileInformationClass, Span<nint> lpFileInformation, int dwBufferSize)
        {
            // SpanOverloader
            return thisApi.SetFileInformationByHandle(hFile, FileInformationClass, ref lpFileInformation.GetPinnableReference(), dwBufferSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileInformationByHandle(this Windows thisApi, Span<nint> hFile, FileInfoByHandleClass FileInformationClass, nint* lpFileInformation, int dwBufferSize)
        {
            // SpanOverloader
            return thisApi.SetFileInformationByHandle(ref hFile.GetPinnableReference(), FileInformationClass, lpFileInformation, dwBufferSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileInformationByHandle(this Windows thisApi, Span<nint> hFile, FileInfoByHandleClass FileInformationClass, Span<nint> lpFileInformation, int dwBufferSize)
        {
            // SpanOverloader
            return thisApi.SetFileInformationByHandle(ref hFile.GetPinnableReference(), FileInformationClass, ref lpFileInformation.GetPinnableReference(), dwBufferSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1075, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int SetFilePointer(this Windows thisApi, nint* hFile, int lDistanceToMove, Span<int> lpDistanceToMoveHigh, int dwMoveMethod)
        {
            // SpanOverloader
            return thisApi.SetFilePointer(hFile, lDistanceToMove, ref lpDistanceToMoveHigh.GetPinnableReference(), dwMoveMethod);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1075, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int SetFilePointer(this Windows thisApi, Span<nint> hFile, int lDistanceToMove, int* lpDistanceToMoveHigh, int dwMoveMethod)
        {
            // SpanOverloader
            return thisApi.SetFilePointer(ref hFile.GetPinnableReference(), lDistanceToMove, lpDistanceToMoveHigh, dwMoveMethod);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1075, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int SetFilePointer(this Windows thisApi, Span<nint> hFile, int lDistanceToMove, Span<int> lpDistanceToMoveHigh, int dwMoveMethod)
        {
            // SpanOverloader
            return thisApi.SetFilePointer(ref hFile.GetPinnableReference(), lDistanceToMove, ref lpDistanceToMoveHigh.GetPinnableReference(), dwMoveMethod);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1085, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFilePointerEx(this Windows thisApi, nint* hFile, long liDistanceToMove, Span<long> lpNewFilePointer, int dwMoveMethod)
        {
            // SpanOverloader
            return thisApi.SetFilePointerEx(hFile, liDistanceToMove, ref lpNewFilePointer.GetPinnableReference(), dwMoveMethod);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1085, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFilePointerEx(this Windows thisApi, Span<nint> hFile, long liDistanceToMove, long* lpNewFilePointer, int dwMoveMethod)
        {
            // SpanOverloader
            return thisApi.SetFilePointerEx(ref hFile.GetPinnableReference(), liDistanceToMove, lpNewFilePointer, dwMoveMethod);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1085, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFilePointerEx(this Windows thisApi, Span<nint> hFile, long liDistanceToMove, Span<long> lpNewFilePointer, int dwMoveMethod)
        {
            // SpanOverloader
            return thisApi.SetFilePointerEx(ref hFile.GetPinnableReference(), liDistanceToMove, ref lpNewFilePointer.GetPinnableReference(), dwMoveMethod);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] Filetime* lpCreationTime, [Flow(FlowDirection.In)] Filetime* lpLastAccessTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(hFile, lpCreationTime, lpLastAccessTime, in lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] Filetime* lpCreationTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastAccessTime, [Flow(FlowDirection.In)] Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(hFile, lpCreationTime, in lpLastAccessTime.GetPinnableReference(), lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] Filetime* lpCreationTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastAccessTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(hFile, lpCreationTime, in lpLastAccessTime.GetPinnableReference(), in lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpCreationTime, [Flow(FlowDirection.In)] Filetime* lpLastAccessTime, [Flow(FlowDirection.In)] Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(hFile, in lpCreationTime.GetPinnableReference(), lpLastAccessTime, lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpCreationTime, [Flow(FlowDirection.In)] Filetime* lpLastAccessTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(hFile, in lpCreationTime.GetPinnableReference(), lpLastAccessTime, in lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpCreationTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastAccessTime, [Flow(FlowDirection.In)] Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(hFile, in lpCreationTime.GetPinnableReference(), in lpLastAccessTime.GetPinnableReference(), lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpCreationTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastAccessTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(hFile, in lpCreationTime.GetPinnableReference(), in lpLastAccessTime.GetPinnableReference(), in lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] Filetime* lpCreationTime, [Flow(FlowDirection.In)] Filetime* lpLastAccessTime, [Flow(FlowDirection.In)] Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(ref hFile.GetPinnableReference(), lpCreationTime, lpLastAccessTime, lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] Filetime* lpCreationTime, [Flow(FlowDirection.In)] Filetime* lpLastAccessTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(ref hFile.GetPinnableReference(), lpCreationTime, lpLastAccessTime, in lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] Filetime* lpCreationTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastAccessTime, [Flow(FlowDirection.In)] Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(ref hFile.GetPinnableReference(), lpCreationTime, in lpLastAccessTime.GetPinnableReference(), lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] Filetime* lpCreationTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastAccessTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(ref hFile.GetPinnableReference(), lpCreationTime, in lpLastAccessTime.GetPinnableReference(), in lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpCreationTime, [Flow(FlowDirection.In)] Filetime* lpLastAccessTime, [Flow(FlowDirection.In)] Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(ref hFile.GetPinnableReference(), in lpCreationTime.GetPinnableReference(), lpLastAccessTime, lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpCreationTime, [Flow(FlowDirection.In)] Filetime* lpLastAccessTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(ref hFile.GetPinnableReference(), in lpCreationTime.GetPinnableReference(), lpLastAccessTime, in lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpCreationTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastAccessTime, [Flow(FlowDirection.In)] Filetime* lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(ref hFile.GetPinnableReference(), in lpCreationTime.GetPinnableReference(), in lpLastAccessTime.GetPinnableReference(), lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileTime(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpCreationTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastAccessTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastWriteTime)
        {
            // SpanOverloader
            return thisApi.SetFileTime(ref hFile.GetPinnableReference(), in lpCreationTime.GetPinnableReference(), in lpLastAccessTime.GetPinnableReference(), in lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1107, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileValidData(this Windows thisApi, Span<nint> hFile, long ValidDataLength)
        {
            // SpanOverloader
            return thisApi.SetFileValidData(ref hFile.GetPinnableReference(), ValidDataLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool UnlockFile(this Windows thisApi, Span<nint> hFile, int dwFileOffsetLow, int dwFileOffsetHigh, int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh)
        {
            // SpanOverloader
            return thisApi.UnlockFile(ref hFile.GetPinnableReference(), dwFileOffsetLow, dwFileOffsetHigh, nNumberOfBytesToUnlockLow, nNumberOfBytesToUnlockHigh);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1128, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool UnlockFileEx(this Windows thisApi, nint* hFile, int dwReserved, int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.UnlockFileEx(hFile, dwReserved, nNumberOfBytesToUnlockLow, nNumberOfBytesToUnlockHigh, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1128, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool UnlockFileEx(this Windows thisApi, Span<nint> hFile, int dwReserved, int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.UnlockFileEx(ref hFile.GetPinnableReference(), dwReserved, nNumberOfBytesToUnlockLow, nNumberOfBytesToUnlockHigh, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1128, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool UnlockFileEx(this Windows thisApi, Span<nint> hFile, int dwReserved, int nNumberOfBytesToUnlockLow, int nNumberOfBytesToUnlockHigh, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.UnlockFileEx(ref hFile.GetPinnableReference(), dwReserved, nNumberOfBytesToUnlockLow, nNumberOfBytesToUnlockHigh, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] void* lpBuffer, int nNumberOfBytesToWrite, uint* lpNumberOfBytesWritten, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFile(hFile, lpBuffer, nNumberOfBytesToWrite, lpNumberOfBytesWritten, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] void* lpBuffer, int nNumberOfBytesToWrite, Span<uint> lpNumberOfBytesWritten, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFile(hFile, lpBuffer, nNumberOfBytesToWrite, ref lpNumberOfBytesWritten.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] void* lpBuffer, int nNumberOfBytesToWrite, Span<uint> lpNumberOfBytesWritten, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFile(hFile, lpBuffer, nNumberOfBytesToWrite, ref lpNumberOfBytesWritten.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile<T0>(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] ReadOnlySpan<T0> lpBuffer, int nNumberOfBytesToWrite, uint* lpNumberOfBytesWritten, Overlapped* lpOverlapped) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteFile(hFile, in lpBuffer.GetPinnableReference(), nNumberOfBytesToWrite, lpNumberOfBytesWritten, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile<T0>(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] ReadOnlySpan<T0> lpBuffer, int nNumberOfBytesToWrite, uint* lpNumberOfBytesWritten, Span<Overlapped> lpOverlapped) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteFile(hFile, in lpBuffer.GetPinnableReference(), nNumberOfBytesToWrite, lpNumberOfBytesWritten, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile<T0>(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] ReadOnlySpan<T0> lpBuffer, int nNumberOfBytesToWrite, Span<uint> lpNumberOfBytesWritten, Overlapped* lpOverlapped) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteFile(hFile, in lpBuffer.GetPinnableReference(), nNumberOfBytesToWrite, ref lpNumberOfBytesWritten.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile<T0>(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] ReadOnlySpan<T0> lpBuffer, int nNumberOfBytesToWrite, Span<uint> lpNumberOfBytesWritten, Span<Overlapped> lpOverlapped) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteFile(hFile, in lpBuffer.GetPinnableReference(), nNumberOfBytesToWrite, ref lpNumberOfBytesWritten.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] void* lpBuffer, int nNumberOfBytesToWrite, uint* lpNumberOfBytesWritten, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFile(ref hFile.GetPinnableReference(), lpBuffer, nNumberOfBytesToWrite, lpNumberOfBytesWritten, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] void* lpBuffer, int nNumberOfBytesToWrite, uint* lpNumberOfBytesWritten, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFile(ref hFile.GetPinnableReference(), lpBuffer, nNumberOfBytesToWrite, lpNumberOfBytesWritten, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] void* lpBuffer, int nNumberOfBytesToWrite, Span<uint> lpNumberOfBytesWritten, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFile(ref hFile.GetPinnableReference(), lpBuffer, nNumberOfBytesToWrite, ref lpNumberOfBytesWritten.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] void* lpBuffer, int nNumberOfBytesToWrite, Span<uint> lpNumberOfBytesWritten, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFile(ref hFile.GetPinnableReference(), lpBuffer, nNumberOfBytesToWrite, ref lpNumberOfBytesWritten.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile<T0>(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<T0> lpBuffer, int nNumberOfBytesToWrite, uint* lpNumberOfBytesWritten, Overlapped* lpOverlapped) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteFile(ref hFile.GetPinnableReference(), in lpBuffer.GetPinnableReference(), nNumberOfBytesToWrite, lpNumberOfBytesWritten, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile<T0>(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<T0> lpBuffer, int nNumberOfBytesToWrite, uint* lpNumberOfBytesWritten, Span<Overlapped> lpOverlapped) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteFile(ref hFile.GetPinnableReference(), in lpBuffer.GetPinnableReference(), nNumberOfBytesToWrite, lpNumberOfBytesWritten, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile<T0>(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<T0> lpBuffer, int nNumberOfBytesToWrite, Span<uint> lpNumberOfBytesWritten, Overlapped* lpOverlapped) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteFile(ref hFile.GetPinnableReference(), in lpBuffer.GetPinnableReference(), nNumberOfBytesToWrite, ref lpNumberOfBytesWritten.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFile<T0>(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<T0> lpBuffer, int nNumberOfBytesToWrite, Span<uint> lpNumberOfBytesWritten, Span<Overlapped> lpOverlapped) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteFile(ref hFile.GetPinnableReference(), in lpBuffer.GetPinnableReference(), nNumberOfBytesToWrite, ref lpNumberOfBytesWritten.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1150, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileEx(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] void* lpBuffer, int nNumberOfBytesToWrite, Span<Overlapped> lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine)
        {
            // SpanOverloader
            return thisApi.WriteFileEx(hFile, lpBuffer, nNumberOfBytesToWrite, ref lpOverlapped.GetPinnableReference(), lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1150, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileEx<T0>(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] ReadOnlySpan<T0> lpBuffer, int nNumberOfBytesToWrite, Overlapped* lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteFileEx(hFile, in lpBuffer.GetPinnableReference(), nNumberOfBytesToWrite, lpOverlapped, lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1150, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileEx<T0>(this Windows thisApi, nint* hFile, [Flow(FlowDirection.In)] ReadOnlySpan<T0> lpBuffer, int nNumberOfBytesToWrite, Span<Overlapped> lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteFileEx(hFile, in lpBuffer.GetPinnableReference(), nNumberOfBytesToWrite, ref lpOverlapped.GetPinnableReference(), lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1150, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileEx(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] void* lpBuffer, int nNumberOfBytesToWrite, Overlapped* lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine)
        {
            // SpanOverloader
            return thisApi.WriteFileEx(ref hFile.GetPinnableReference(), lpBuffer, nNumberOfBytesToWrite, lpOverlapped, lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1150, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileEx(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] void* lpBuffer, int nNumberOfBytesToWrite, Span<Overlapped> lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine)
        {
            // SpanOverloader
            return thisApi.WriteFileEx(ref hFile.GetPinnableReference(), lpBuffer, nNumberOfBytesToWrite, ref lpOverlapped.GetPinnableReference(), lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1150, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileEx<T0>(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<T0> lpBuffer, int nNumberOfBytesToWrite, Overlapped* lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteFileEx(ref hFile.GetPinnableReference(), in lpBuffer.GetPinnableReference(), nNumberOfBytesToWrite, lpOverlapped, lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1150, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileEx<T0>(this Windows thisApi, Span<nint> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<T0> lpBuffer, int nNumberOfBytesToWrite, Span<Overlapped> lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.WriteFileEx(ref hFile.GetPinnableReference(), in lpBuffer.GetPinnableReference(), nNumberOfBytesToWrite, ref lpOverlapped.GetPinnableReference(), lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, nint* hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToWrite, uint* lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(hFile, aSegmentArray, nNumberOfBytesToWrite, lpReserved, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, nint* hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToWrite, Span<uint> lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(hFile, aSegmentArray, nNumberOfBytesToWrite, ref lpReserved.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, nint* hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToWrite, Span<uint> lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(hFile, aSegmentArray, nNumberOfBytesToWrite, ref lpReserved.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, nint* hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToWrite, uint* lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(hFile, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToWrite, lpReserved, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, nint* hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToWrite, uint* lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(hFile, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToWrite, lpReserved, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, nint* hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToWrite, Span<uint> lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(hFile, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToWrite, ref lpReserved.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, nint* hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToWrite, Span<uint> lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(hFile, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToWrite, ref lpReserved.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, Span<nint> hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToWrite, uint* lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(ref hFile.GetPinnableReference(), aSegmentArray, nNumberOfBytesToWrite, lpReserved, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, Span<nint> hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToWrite, uint* lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(ref hFile.GetPinnableReference(), aSegmentArray, nNumberOfBytesToWrite, lpReserved, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, Span<nint> hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToWrite, Span<uint> lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(ref hFile.GetPinnableReference(), aSegmentArray, nNumberOfBytesToWrite, ref lpReserved.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, Span<nint> hFile, FileSegmentElement* aSegmentArray, int nNumberOfBytesToWrite, Span<uint> lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(ref hFile.GetPinnableReference(), aSegmentArray, nNumberOfBytesToWrite, ref lpReserved.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, Span<nint> hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToWrite, uint* lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(ref hFile.GetPinnableReference(), ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToWrite, lpReserved, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, Span<nint> hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToWrite, uint* lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(ref hFile.GetPinnableReference(), ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToWrite, lpReserved, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, Span<nint> hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToWrite, Span<uint> lpReserved, Overlapped* lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(ref hFile.GetPinnableReference(), ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToWrite, ref lpReserved.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool WriteFileGather(this Windows thisApi, Span<nint> hFile, Span<FileSegmentElement> aSegmentArray, int nNumberOfBytesToWrite, Span<uint> lpReserved, Span<Overlapped> lpOverlapped)
        {
            // SpanOverloader
            return thisApi.WriteFileGather(ref hFile.GetPinnableReference(), ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToWrite, ref lpReserved.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1172, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetTempPathW(this Windows thisApi, int nBufferLength, Span<char> lpBuffer)
        {
            // SpanOverloader
            return thisApi.GetTempPathW(nBufferLength, ref lpBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1190, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeNameForVolumeMountPointW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpszVolumeMountPoint, Span<char> lpszVolumeName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumeNameForVolumeMountPointW(lpszVolumeMountPoint, ref lpszVolumeName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1190, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeNameForVolumeMountPointW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszVolumeMountPoint, char* lpszVolumeName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumeNameForVolumeMountPointW(in lpszVolumeMountPoint.GetPinnableReference(), lpszVolumeName, cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1190, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeNameForVolumeMountPointW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszVolumeMountPoint, Span<char> lpszVolumeName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumeNameForVolumeMountPointW(in lpszVolumeMountPoint.GetPinnableReference(), ref lpszVolumeName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1190, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeNameForVolumeMountPointW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszVolumeMountPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszVolumeName, int cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumeNameForVolumeMountPointW(in lpszVolumeMountPoint.GetPinnableReference(), lpszVolumeName, cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(lpszVolumeName, lpszVolumePathNames, cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpszVolumeName, Span<char> lpszVolumePathNames, int cchBufferLength, uint* lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(lpszVolumeName, ref lpszVolumePathNames.GetPinnableReference(), cchBufferLength, lpcchReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpszVolumeName, Span<char> lpszVolumePathNames, int cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(lpszVolumeName, ref lpszVolumePathNames.GetPinnableReference(), cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpszVolumeName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string lpszVolumePathNames, int cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(lpszVolumeName, lpszVolumePathNames, cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, uint* lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(in lpszVolumeName.GetPinnableReference(), lpszVolumePathNames, cchBufferLength, lpcchReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszVolumeName, char* lpszVolumePathNames, int cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(in lpszVolumeName.GetPinnableReference(), lpszVolumePathNames, cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszVolumeName, Span<char> lpszVolumePathNames, int cchBufferLength, uint* lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(in lpszVolumeName.GetPinnableReference(), ref lpszVolumePathNames.GetPinnableReference(), cchBufferLength, lpcchReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszVolumeName, Span<char> lpszVolumePathNames, int cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(in lpszVolumeName.GetPinnableReference(), ref lpszVolumePathNames.GetPinnableReference(), cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszVolumeName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string lpszVolumePathNames, int cchBufferLength, uint* lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(in lpszVolumeName.GetPinnableReference(), lpszVolumePathNames, cchBufferLength, lpcchReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpszVolumeName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string lpszVolumePathNames, int cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(in lpszVolumeName.GetPinnableReference(), lpszVolumePathNames, cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1244, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFile2(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, Span<Createfile2ExtendedParameters> pCreateExParams)
        {
            // SpanOverloader
            return thisApi.CreateFile2(lpFileName, dwDesiredAccess, dwShareMode, dwCreationDisposition, ref pCreateExParams.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1244, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFile2(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, Createfile2ExtendedParameters* pCreateExParams)
        {
            // SpanOverloader
            return thisApi.CreateFile2(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, dwCreationDisposition, pCreateExParams);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1244, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* CreateFile2(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwDesiredAccess, int dwShareMode, int dwCreationDisposition, Span<Createfile2ExtendedParameters> pCreateExParams)
        {
            // SpanOverloader
            return thisApi.CreateFile2(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, dwCreationDisposition, ref pCreateExParams.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1265, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileIoOverlappedRange(this Windows thisApi, nint* FileHandle, Span<byte> OverlappedRangeStart, uint Length)
        {
            // SpanOverloader
            return thisApi.SetFileIoOverlappedRange(FileHandle, ref OverlappedRangeStart.GetPinnableReference(), Length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1265, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileIoOverlappedRange(this Windows thisApi, Span<nint> FileHandle, byte* OverlappedRangeStart, uint Length)
        {
            // SpanOverloader
            return thisApi.SetFileIoOverlappedRange(ref FileHandle.GetPinnableReference(), OverlappedRangeStart, Length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1265, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileIoOverlappedRange(this Windows thisApi, Span<nint> FileHandle, Span<byte> OverlappedRangeStart, uint Length)
        {
            // SpanOverloader
            return thisApi.SetFileIoOverlappedRange(ref FileHandle.GetPinnableReference(), ref OverlappedRangeStart.GetPinnableReference(), Length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1265, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool SetFileIoOverlappedRange(this Windows thisApi, Span<nint> FileHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string OverlappedRangeStart, uint Length)
        {
            // SpanOverloader
            return thisApi.SetFileIoOverlappedRange(ref FileHandle.GetPinnableReference(), OverlappedRangeStart, Length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1278, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetCompressedFileSizeA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpFileName, Span<uint> lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeA(lpFileName, ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1278, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetCompressedFileSizeA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, uint* lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeA(in lpFileName.GetPinnableReference(), lpFileSizeHigh);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1278, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetCompressedFileSizeA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpFileName, Span<uint> lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeA(in lpFileName.GetPinnableReference(), ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1286, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetCompressedFileSizeW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, Span<uint> lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeW(lpFileName, ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1286, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetCompressedFileSizeW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, uint* lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeW(in lpFileName.GetPinnableReference(), lpFileSizeHigh);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1286, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetCompressedFileSizeW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, Span<uint> lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeW(in lpFileName.GetPinnableReference(), ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstStreamW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, StreamInfoLevels InfoLevel, Span<nint> lpFindStreamData, int dwFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstStreamW(lpFileName, InfoLevel, ref lpFindStreamData.GetPinnableReference(), dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstStreamW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, StreamInfoLevels InfoLevel, nint* lpFindStreamData, int dwFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstStreamW(in lpFileName.GetPinnableReference(), InfoLevel, lpFindStreamData, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstStreamW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, StreamInfoLevels InfoLevel, Span<nint> lpFindStreamData, int dwFlags)
        {
            // SpanOverloader
            return thisApi.FindFirstStreamW(in lpFileName.GetPinnableReference(), InfoLevel, ref lpFindStreamData.GetPinnableReference(), dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1327, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextStreamW(this Windows thisApi, nint* hFindStream, Span<nint> lpFindStreamData)
        {
            // SpanOverloader
            return thisApi.FindNextStreamW(hFindStream, ref lpFindStreamData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1327, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextStreamW(this Windows thisApi, Span<nint> hFindStream, nint* lpFindStreamData)
        {
            // SpanOverloader
            return thisApi.FindNextStreamW(ref hFindStream.GetPinnableReference(), lpFindStreamData);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1327, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextStreamW(this Windows thisApi, Span<nint> hFindStream, Span<nint> lpFindStreamData)
        {
            // SpanOverloader
            return thisApi.FindNextStreamW(ref hFindStream.GetPinnableReference(), ref lpFindStreamData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1356, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetTempPathA(this Windows thisApi, int nBufferLength, Span<byte> lpBuffer)
        {
            // SpanOverloader
            return thisApi.GetTempPathA(nBufferLength, ref lpBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, int dwFlags, uint* StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(lpFileName, dwFlags, StringLength, ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, int dwFlags, Span<uint> StringLength, char* LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(lpFileName, dwFlags, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, int dwFlags, Span<uint> StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(lpFileName, dwFlags, ref StringLength.GetPinnableReference(), ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] nint* lpFileName, int dwFlags, Span<uint> StringLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(lpFileName, dwFlags, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwFlags, uint* StringLength, char* LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(in lpFileName.GetPinnableReference(), dwFlags, StringLength, LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwFlags, uint* StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(in lpFileName.GetPinnableReference(), dwFlags, StringLength, ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwFlags, uint* StringLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(in lpFileName.GetPinnableReference(), dwFlags, StringLength, LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwFlags, Span<uint> StringLength, char* LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(in lpFileName.GetPinnableReference(), dwFlags, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwFlags, Span<uint> StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(in lpFileName.GetPinnableReference(), dwFlags, ref StringLength.GetPinnableReference(), ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe nint* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<nint> lpFileName, int dwFlags, Span<uint> StringLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(in lpFileName.GetPinnableReference(), dwFlags, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileNameW(this Windows thisApi, nint* hFindStream, uint* StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindNextFileNameW(hFindStream, StringLength, ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileNameW(this Windows thisApi, nint* hFindStream, Span<uint> StringLength, char* LinkName)
        {
            // SpanOverloader
            return thisApi.FindNextFileNameW(hFindStream, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileNameW(this Windows thisApi, nint* hFindStream, Span<uint> StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindNextFileNameW(hFindStream, ref StringLength.GetPinnableReference(), ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileNameW(this Windows thisApi, nint* hFindStream, Span<uint> StringLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LinkName)
        {
            // SpanOverloader
            return thisApi.FindNextFileNameW(hFindStream, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileNameW(this Windows thisApi, Span<nint> hFindStream, uint* StringLength, char* LinkName)
        {
            // SpanOverloader
            return thisApi.FindNextFileNameW(ref hFindStream.GetPinnableReference(), StringLength, LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileNameW(this Windows thisApi, Span<nint> hFindStream, uint* StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindNextFileNameW(ref hFindStream.GetPinnableReference(), StringLength, ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileNameW(this Windows thisApi, Span<nint> hFindStream, uint* StringLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LinkName)
        {
            // SpanOverloader
            return thisApi.FindNextFileNameW(ref hFindStream.GetPinnableReference(), StringLength, LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileNameW(this Windows thisApi, Span<nint> hFindStream, Span<uint> StringLength, char* LinkName)
        {
            // SpanOverloader
            return thisApi.FindNextFileNameW(ref hFindStream.GetPinnableReference(), ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileNameW(this Windows thisApi, Span<nint> hFindStream, Span<uint> StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindNextFileNameW(ref hFindStream.GetPinnableReference(), ref StringLength.GetPinnableReference(), ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool FindNextFileNameW(this Windows thisApi, Span<nint> hFindStream, Span<uint> StringLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LinkName)
        {
            // SpanOverloader
            return thisApi.FindNextFileNameW(ref hFindStream.GetPinnableReference(), ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, byte* lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, Span<byte> lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe bool GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, int nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, int nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpPathName, [Flow(FlowDirection.In)] string* lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPrefixString, uint uUnique, byte* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] string* lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPathName, [Flow(FlowDirection.In)] string* lpPrefixString, uint uUnique, byte* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPathName, [Flow(FlowDirection.In)] string* lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPathName, [Flow(FlowDirection.In)] string* lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPrefixString, uint uUnique, byte* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), in lpPrefixString.GetPinnableReference(), uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<string> lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetTempPath2W(this Windows thisApi, int BufferLength, Span<char> Buffer)
        {
            // SpanOverloader
            return thisApi.GetTempPath2W(BufferLength, ref Buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\fileapi.h")]
        public static unsafe int GetTempPath2A(this Windows thisApi, int BufferLength, Span<byte> Buffer)
        {
            // SpanOverloader
            return thisApi.GetTempPath2A(BufferLength, ref Buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 39, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool CloseHandle(this Windows thisApi, Span<nint> hObject)
        {
            // SpanOverloader
            return thisApi.CloseHandle(ref hObject.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, nint* hSourceProcessHandle, nint* hSourceHandle, Span<nint> hTargetProcessHandle, void** lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(hSourceProcessHandle, hSourceHandle, ref hTargetProcessHandle.GetPinnableReference(), lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, nint* hSourceProcessHandle, nint* hSourceHandle, Span<nint> hTargetProcessHandle, ref void* lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(hSourceProcessHandle, hSourceHandle, ref hTargetProcessHandle.GetPinnableReference(), ref lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, nint* hSourceProcessHandle, Span<nint> hSourceHandle, nint* hTargetProcessHandle, void** lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(hSourceProcessHandle, ref hSourceHandle.GetPinnableReference(), hTargetProcessHandle, lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, nint* hSourceProcessHandle, Span<nint> hSourceHandle, nint* hTargetProcessHandle, ref void* lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(hSourceProcessHandle, ref hSourceHandle.GetPinnableReference(), hTargetProcessHandle, ref lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, nint* hSourceProcessHandle, Span<nint> hSourceHandle, Span<nint> hTargetProcessHandle, void** lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(hSourceProcessHandle, ref hSourceHandle.GetPinnableReference(), ref hTargetProcessHandle.GetPinnableReference(), lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, nint* hSourceProcessHandle, Span<nint> hSourceHandle, Span<nint> hTargetProcessHandle, ref void* lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(hSourceProcessHandle, ref hSourceHandle.GetPinnableReference(), ref hTargetProcessHandle.GetPinnableReference(), ref lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, Span<nint> hSourceProcessHandle, nint* hSourceHandle, nint* hTargetProcessHandle, void** lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(ref hSourceProcessHandle.GetPinnableReference(), hSourceHandle, hTargetProcessHandle, lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, Span<nint> hSourceProcessHandle, nint* hSourceHandle, nint* hTargetProcessHandle, ref void* lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(ref hSourceProcessHandle.GetPinnableReference(), hSourceHandle, hTargetProcessHandle, ref lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, Span<nint> hSourceProcessHandle, nint* hSourceHandle, Span<nint> hTargetProcessHandle, void** lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(ref hSourceProcessHandle.GetPinnableReference(), hSourceHandle, ref hTargetProcessHandle.GetPinnableReference(), lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, Span<nint> hSourceProcessHandle, nint* hSourceHandle, Span<nint> hTargetProcessHandle, ref void* lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(ref hSourceProcessHandle.GetPinnableReference(), hSourceHandle, ref hTargetProcessHandle.GetPinnableReference(), ref lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, Span<nint> hSourceProcessHandle, Span<nint> hSourceHandle, nint* hTargetProcessHandle, void** lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(ref hSourceProcessHandle.GetPinnableReference(), ref hSourceHandle.GetPinnableReference(), hTargetProcessHandle, lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, Span<nint> hSourceProcessHandle, Span<nint> hSourceHandle, nint* hTargetProcessHandle, ref void* lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(ref hSourceProcessHandle.GetPinnableReference(), ref hSourceHandle.GetPinnableReference(), hTargetProcessHandle, ref lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, Span<nint> hSourceProcessHandle, Span<nint> hSourceHandle, Span<nint> hTargetProcessHandle, void** lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(ref hSourceProcessHandle.GetPinnableReference(), ref hSourceHandle.GetPinnableReference(), ref hTargetProcessHandle.GetPinnableReference(), lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool DuplicateHandle(this Windows thisApi, Span<nint> hSourceProcessHandle, Span<nint> hSourceHandle, Span<nint> hTargetProcessHandle, ref void* lpTargetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
        {
            // SpanOverloader
            return thisApi.DuplicateHandle(ref hSourceProcessHandle.GetPinnableReference(), ref hSourceHandle.GetPinnableReference(), ref hTargetProcessHandle.GetPinnableReference(), ref lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool CompareObjectHandles(this Windows thisApi, nint* hFirstObjectHandle, Span<nint> hSecondObjectHandle)
        {
            // SpanOverloader
            return thisApi.CompareObjectHandles(hFirstObjectHandle, ref hSecondObjectHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool CompareObjectHandles(this Windows thisApi, Span<nint> hFirstObjectHandle, nint* hSecondObjectHandle)
        {
            // SpanOverloader
            return thisApi.CompareObjectHandles(ref hFirstObjectHandle.GetPinnableReference(), hSecondObjectHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool CompareObjectHandles(this Windows thisApi, Span<nint> hFirstObjectHandle, Span<nint> hSecondObjectHandle)
        {
            // SpanOverloader
            return thisApi.CompareObjectHandles(ref hFirstObjectHandle.GetPinnableReference(), ref hSecondObjectHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool GetHandleInformation(this Windows thisApi, nint* hObject, Span<uint> lpdwFlags)
        {
            // SpanOverloader
            return thisApi.GetHandleInformation(hObject, ref lpdwFlags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool GetHandleInformation(this Windows thisApi, Span<nint> hObject, uint* lpdwFlags)
        {
            // SpanOverloader
            return thisApi.GetHandleInformation(ref hObject.GetPinnableReference(), lpdwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool GetHandleInformation(this Windows thisApi, Span<nint> hObject, Span<uint> lpdwFlags)
        {
            // SpanOverloader
            return thisApi.GetHandleInformation(ref hObject.GetPinnableReference(), ref lpdwFlags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\handleapi.h")]
        public static unsafe bool SetHandleInformation(this Windows thisApi, Span<nint> hObject, int dwMask, int dwFlags)
        {
            // SpanOverloader
            return thisApi.SetHandleInformation(ref hObject.GetPinnableReference(), dwMask, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2005, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownRemoteNextProxy(this Windows thisApi, IEnumUnknown* This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownRemoteNextProxy(This, celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2005, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownRemoteNextProxy(this Windows thisApi, IEnumUnknown* This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownRemoteNextProxy(This, celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2005, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownRemoteNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownRemoteNextProxy(ref This.GetPinnableReference(), celt, rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2005, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownRemoteNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownRemoteNextProxy(ref This.GetPinnableReference(), celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2005, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownRemoteNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownRemoteNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2005, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownRemoteNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownRemoteNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2144, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringRemoteNextProxy(this Windows thisApi, IEnumString* This, uint celt, char** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringRemoteNextProxy(This, celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2144, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringRemoteNextProxy(this Windows thisApi, IEnumString* This, uint celt, ref char* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringRemoteNextProxy(This, celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2144, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringRemoteNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, char** rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringRemoteNextProxy(ref This.GetPinnableReference(), celt, rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2144, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringRemoteNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, char** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringRemoteNextProxy(ref This.GetPinnableReference(), celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2144, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringRemoteNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, ref char* rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringRemoteNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2144, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringRemoteNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, ref char* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringRemoteNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, ISequentialStream* This, byte* pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(This, pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, ISequentialStream* This, Span<byte> pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(This, ref pv.GetPinnableReference(), cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, ISequentialStream* This, Span<byte> pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(This, ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, ISequentialStream* This, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(This, pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, Span<ISequentialStream> This, byte* pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(ref This.GetPinnableReference(), pv, cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, Span<ISequentialStream> This, byte* pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(ref This.GetPinnableReference(), pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, Span<ISequentialStream> This, Span<byte> pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(ref This.GetPinnableReference(), ref pv.GetPinnableReference(), cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, Span<ISequentialStream> This, Span<byte> pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(ref This.GetPinnableReference(), ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, Span<ISequentialStream> This, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(ref This.GetPinnableReference(), pv, cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, Span<ISequentialStream> This, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(ref This.GetPinnableReference(), pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] byte* pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(This, pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(This, in pv.GetPinnableReference(), cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(This, in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(This, pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] byte* pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(ref This.GetPinnableReference(), pv, cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] byte* pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(ref This.GetPinnableReference(), pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(ref This.GetPinnableReference(), in pv.GetPinnableReference(), cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(ref This.GetPinnableReference(), in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(ref This.GetPinnableReference(), pv, cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(ref This.GetPinnableReference(), pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2568, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteSeekProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, long dlibMove, int dwOrigin, Span<ulong> plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteSeekProxy(This, dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2568, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteSeekProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, long dlibMove, int dwOrigin, ulong* plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteSeekProxy(ref This.GetPinnableReference(), dlibMove, dwOrigin, plibNewPosition);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2568, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteSeekProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, long dlibMove, int dwOrigin, Span<ulong> plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteSeekProxy(ref This.GetPinnableReference(), dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), pstm, cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8449, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownNextProxy(this Windows thisApi, IEnumUnknown* This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextProxy(This, celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8449, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownNextProxy(this Windows thisApi, IEnumUnknown* This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextProxy(This, celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8449, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextProxy(ref This.GetPinnableReference(), celt, rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8449, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextProxy(ref This.GetPinnableReference(), celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8449, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8449, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8459, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownNextStub(this Windows thisApi, IEnumUnknown* This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextStub(This, celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8459, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownNextStub(this Windows thisApi, IEnumUnknown* This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextStub(This, celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8459, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownNextStub(this Windows thisApi, Span<IEnumUnknown> This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextStub(ref This.GetPinnableReference(), celt, rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8459, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownNextStub(this Windows thisApi, Span<IEnumUnknown> This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextStub(ref This.GetPinnableReference(), celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8459, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownNextStub(this Windows thisApi, Span<IEnumUnknown> This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextStub(ref This.GetPinnableReference(), celt, ref rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8459, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumUnknownNextStub(this Windows thisApi, Span<IEnumUnknown> This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextStub(ref This.GetPinnableReference(), celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8465, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringNextProxy(this Windows thisApi, IEnumString* This, uint celt, char** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextProxy(This, celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8465, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringNextProxy(this Windows thisApi, IEnumString* This, uint celt, ref char* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextProxy(This, celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8465, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, char** rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextProxy(ref This.GetPinnableReference(), celt, rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8465, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, char** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextProxy(ref This.GetPinnableReference(), celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8465, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, ref char* rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8465, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, ref char* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8474, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringNextStub(this Windows thisApi, IEnumString* This, uint celt, char** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextStub(This, celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8474, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringNextStub(this Windows thisApi, IEnumString* This, uint celt, ref char* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextStub(This, celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8474, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringNextStub(this Windows thisApi, Span<IEnumString> This, uint celt, char** rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextStub(ref This.GetPinnableReference(), celt, rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8474, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringNextStub(this Windows thisApi, Span<IEnumString> This, uint celt, char** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextStub(ref This.GetPinnableReference(), celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8474, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringNextStub(this Windows thisApi, Span<IEnumString> This, uint celt, ref char* rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextStub(ref This.GetPinnableReference(), celt, ref rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8474, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IEnumStringNextStub(this Windows thisApi, Span<IEnumString> This, uint celt, ref char* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextStub(ref This.GetPinnableReference(), celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8480, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadProxy(this Windows thisApi, ISequentialStream* This, void* pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadProxy(This, pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8480, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadProxy<T0>(this Windows thisApi, ISequentialStream* This, Span<T0> pv, uint cb, uint* pcbRead) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadProxy(This, ref pv.GetPinnableReference(), cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8480, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadProxy<T0>(this Windows thisApi, ISequentialStream* This, Span<T0> pv, uint cb, Span<uint> pcbRead) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadProxy(This, ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8480, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadProxy(this Windows thisApi, Span<ISequentialStream> This, void* pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadProxy(ref This.GetPinnableReference(), pv, cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8480, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadProxy(this Windows thisApi, Span<ISequentialStream> This, void* pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadProxy(ref This.GetPinnableReference(), pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8480, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadProxy<T0>(this Windows thisApi, Span<ISequentialStream> This, Span<T0> pv, uint cb, uint* pcbRead) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadProxy(ref This.GetPinnableReference(), ref pv.GetPinnableReference(), cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8480, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadProxy<T0>(this Windows thisApi, Span<ISequentialStream> This, Span<T0> pv, uint cb, Span<uint> pcbRead) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadProxy(ref This.GetPinnableReference(), ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, ISequentialStream* This, byte* pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(This, pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, ISequentialStream* This, Span<byte> pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(This, ref pv.GetPinnableReference(), cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, ISequentialStream* This, Span<byte> pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(This, ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, ISequentialStream* This, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(This, pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, Span<ISequentialStream> This, byte* pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(ref This.GetPinnableReference(), pv, cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, Span<ISequentialStream> This, byte* pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(ref This.GetPinnableReference(), pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, Span<ISequentialStream> This, Span<byte> pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(ref This.GetPinnableReference(), ref pv.GetPinnableReference(), cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, Span<ISequentialStream> This, Span<byte> pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(ref This.GetPinnableReference(), ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, Span<ISequentialStream> This, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(ref This.GetPinnableReference(), pv, cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, Span<ISequentialStream> This, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(ref This.GetPinnableReference(), pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8496, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteProxy(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] void* pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteProxy(This, pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8496, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteProxy<T0>(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, uint* pcbWritten) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteProxy(This, in pv.GetPinnableReference(), cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8496, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteProxy<T0>(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, Span<uint> pcbWritten) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteProxy(This, in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8496, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] void* pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteProxy(ref This.GetPinnableReference(), pv, cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8496, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] void* pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteProxy(ref This.GetPinnableReference(), pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8496, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteProxy<T0>(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, uint* pcbWritten) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteProxy(ref This.GetPinnableReference(), in pv.GetPinnableReference(), cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8496, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteProxy<T0>(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] ReadOnlySpan<T0> pv, uint cb, Span<uint> pcbWritten) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteProxy(ref This.GetPinnableReference(), in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] byte* pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(This, pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(This, in pv.GetPinnableReference(), cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(This, in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(This, pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] byte* pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(ref This.GetPinnableReference(), pv, cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] byte* pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(ref This.GetPinnableReference(), pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(ref This.GetPinnableReference(), in pv.GetPinnableReference(), cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(ref This.GetPinnableReference(), in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(ref This.GetPinnableReference(), pv, cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(ref This.GetPinnableReference(), pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8512, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamSeekProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, long dlibMove, int dwOrigin, Span<ulong> plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamSeekProxy(This, dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8512, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamSeekProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, long dlibMove, int dwOrigin, ulong* plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamSeekProxy(ref This.GetPinnableReference(), dlibMove, dwOrigin, plibNewPosition);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8512, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamSeekProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, long dlibMove, int dwOrigin, Span<ulong> plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamSeekProxy(ref This.GetPinnableReference(), dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8520, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamSeekStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, long dlibMove, int dwOrigin, Span<ulong> plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamSeekStub(This, dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8520, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamSeekStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, long dlibMove, int dwOrigin, ulong* plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamSeekStub(ref This.GetPinnableReference(), dlibMove, dwOrigin, plibNewPosition);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8520, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamSeekStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, long dlibMove, int dwOrigin, Span<ulong> plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamSeekStub(ref This.GetPinnableReference(), dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), pstm, cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), pstm, cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um\\objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In)] nint* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] nint* InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] nint* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In)] string* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] string* InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] string* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] nint* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] string* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint StopTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1754, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] nint* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1754, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1754, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] string* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] nint* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] string* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint UpdateTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1826, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] nint* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1826, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1826, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] string* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint FlushTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1862, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] nint* InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1862, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, EventTraceProperties* Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, in InstanceName.GetPinnableReference(), Properties, ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1862, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<nint> InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1878, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] string* InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1878, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, EventTraceProperties* Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, in InstanceName.GetPinnableReference(), Properties, ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1878, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ControlTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<string> InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1896, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryAllTracesW(this Windows thisApi, EventTraceProperties** PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesW(PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1896, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryAllTracesW(this Windows thisApi, ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesW(ref PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1905, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryAllTracesA(this Windows thisApi, EventTraceProperties** PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesA(PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1905, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryAllTracesA(this Windows thisApi, ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesA(ref PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1924, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnableTrace(this Windows thisApi, uint Enable, uint EnableFlag, uint EnableLevel, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, ulong TraceHandle)
        {
            // SpanOverloader
            return thisApi.EnableTrace(Enable, EnableFlag, EnableLevel, in ControlGuid.GetPinnableReference(), TraceHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] Guid* ProviderId, [Flow(FlowDirection.In)] Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ProviderId, SourceId, TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] Guid* ProviderId, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ProviderId, in SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, EnableFilterDesc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] Guid* ProviderId, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ProviderId, in SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ProviderId, [Flow(FlowDirection.In)] Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(in ProviderId.GetPinnableReference(), SourceId, TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, EnableFilterDesc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ProviderId, [Flow(FlowDirection.In)] Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(in ProviderId.GetPinnableReference(), SourceId, TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ProviderId, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(in ProviderId.GetPinnableReference(), in SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, EnableFilterDesc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ProviderId, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(in ProviderId.GetPinnableReference(), in SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1993, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx2(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] Guid* ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, Span<EnableTraceParameters> EnableParameters)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx2(TraceHandle, ProviderId, ControlCode, Level, MatchAnyKeyword, MatchAllKeyword, Timeout, ref EnableParameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1993, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx2(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, EnableTraceParameters* EnableParameters)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx2(TraceHandle, in ProviderId.GetPinnableReference(), ControlCode, Level, MatchAnyKeyword, MatchAllKeyword, Timeout, EnableParameters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1993, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnableTraceEx2(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, Span<EnableTraceParameters> EnableParameters)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx2(TraceHandle, in ProviderId.GetPinnableReference(), ControlCode, Level, MatchAnyKeyword, MatchAllKeyword, Timeout, ref EnableParameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2370, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, Span<uint> ReturnLength)
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, InBuffer, InBufferSize, OutBuffer, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2370, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, Span<T0> OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, InBuffer, InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2370, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, Span<T0> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, InBuffer, InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2370, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, ref InBuffer.GetPinnableReference(), InBufferSize, OutBuffer, OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2370, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, ref InBuffer.GetPinnableReference(), InBufferSize, OutBuffer, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2370, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0, T1>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, ref InBuffer.GetPinnableReference(), InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2370, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0, T1>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, ref InBuffer.GetPinnableReference(), InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2422, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceSetInformation<T0>(this Windows thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, Span<T0> TraceInformation, uint InformationLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.TraceSetInformation(SessionHandle, InformationClass, ref TraceInformation.GetPinnableReference(), InformationLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceQueryInformation(this Windows thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, void* TraceInformation, uint InformationLength, Span<uint> ReturnLength)
        {
            // SpanOverloader
            return thisApi.TraceQueryInformation(SessionHandle, InformationClass, TraceInformation, InformationLength, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceQueryInformation<T0>(this Windows thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, Span<T0> TraceInformation, uint InformationLength, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.TraceQueryInformation(SessionHandle, InformationClass, ref TraceInformation.GetPinnableReference(), InformationLength, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceQueryInformation<T0>(this Windows thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, Span<T0> TraceInformation, uint InformationLength, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.TraceQueryInformation(SessionHandle, InformationClass, ref TraceInformation.GetPinnableReference(), InformationLength, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint CreateTraceInstanceId(this Windows thisApi, nint* RegHandle, Span<EventInstanceInfo> InstInfo)
        {
            // SpanOverloader
            return thisApi.CreateTraceInstanceId(RegHandle, ref InstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint CreateTraceInstanceId(this Windows thisApi, Span<nint> RegHandle, EventInstanceInfo* InstInfo)
        {
            // SpanOverloader
            return thisApi.CreateTraceInstanceId(ref RegHandle.GetPinnableReference(), InstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint CreateTraceInstanceId(this Windows thisApi, Span<nint> RegHandle, Span<EventInstanceInfo> InstInfo)
        {
            // SpanOverloader
            return thisApi.CreateTraceInstanceId(ref RegHandle.GetPinnableReference(), ref InstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2474, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceEvent(this Windows thisApi, ulong TraceHandle, Span<EventTraceHeader> EventTrace)
        {
            // SpanOverloader
            return thisApi.TraceEvent(TraceHandle, ref EventTrace.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, EventInstanceHeader* EventTrace, EventInstanceInfo* InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, EventTrace, InstInfo, ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, EventInstanceHeader* EventTrace, Span<EventInstanceInfo> InstInfo, EventInstanceInfo* ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, EventTrace, ref InstInfo.GetPinnableReference(), ParentInstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, EventInstanceHeader* EventTrace, Span<EventInstanceInfo> InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, EventTrace, ref InstInfo.GetPinnableReference(), ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, EventInstanceInfo* InstInfo, EventInstanceInfo* ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), InstInfo, ParentInstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, EventInstanceInfo* InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), InstInfo, ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, Span<EventInstanceInfo> InstInfo, EventInstanceInfo* ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), ref InstInfo.GetPinnableReference(), ParentInstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, Span<EventInstanceInfo> InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), ref InstInfo.GetPinnableReference(), ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] nint* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] nint* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<nint> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsW(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA(this Windows thisApi, PfnWmidprequest RequestAddress, void* RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle)
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContext, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] string* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] string* MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<string> MofResourceName, Span<ulong> RegistrationHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.RegisterTraceGuidsA(RequestAddress, ref RequestContext.GetPinnableReference(), in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2557, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuids(this Windows thisApi, TraceGuidProperties** GuidPropertiesArray, uint PropertyArrayCount, Span<uint> GuidCount)
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuids(GuidPropertiesArray, PropertyArrayCount, ref GuidCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2557, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint EnumerateTraceGuids(this Windows thisApi, ref TraceGuidProperties* GuidPropertiesArray, uint PropertyArrayCount, Span<uint> GuidCount)
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuids(ref GuidPropertiesArray, PropertyArrayCount, ref GuidCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2580, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong GetTraceLoggerHandle<T0>(this Windows thisApi, Span<T0> Buffer) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetTraceLoggerHandle(ref Buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2619, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceW(this Windows thisApi, Span<EventTraceLogfilew> Logfile)
        {
            // SpanOverloader
            return thisApi.OpenTraceW(ref Logfile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, ulong* HandleArray, uint HandleCount, Filetime* StartTime, Span<Filetime> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(HandleArray, HandleCount, StartTime, ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, ulong* HandleArray, uint HandleCount, Span<Filetime> StartTime, Filetime* EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(HandleArray, HandleCount, ref StartTime.GetPinnableReference(), EndTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, ulong* HandleArray, uint HandleCount, Span<Filetime> StartTime, Span<Filetime> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(HandleArray, HandleCount, ref StartTime.GetPinnableReference(), ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, Span<ulong> HandleArray, uint HandleCount, Filetime* StartTime, Filetime* EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, StartTime, EndTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, Span<ulong> HandleArray, uint HandleCount, Filetime* StartTime, Span<Filetime> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, StartTime, ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, Span<ulong> HandleArray, uint HandleCount, Span<Filetime> StartTime, Filetime* EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, ref StartTime.GetPinnableReference(), EndTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, Span<ulong> HandleArray, uint HandleCount, Span<Filetime> StartTime, Span<Filetime> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, ref StartTime.GetPinnableReference(), ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2647, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromBufferStream<T0>(this Windows thisApi, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, PfnPetwBufferCompletionCallback BufferCompletionCallback, Span<T0> BufferCompletionContext) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.OpenTraceFromBufferStream(Options, BufferCompletionCallback, ref BufferCompletionContext.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2647, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromBufferStream(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, PfnPetwBufferCompletionCallback BufferCompletionCallback, void* BufferCompletionContext)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromBufferStream(in Options.GetPinnableReference(), BufferCompletionCallback, BufferCompletionContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2647, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromBufferStream<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, PfnPetwBufferCompletionCallback BufferCompletionCallback, Span<T0> BufferCompletionContext) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.OpenTraceFromBufferStream(in Options.GetPinnableReference(), BufferCompletionCallback, ref BufferCompletionContext.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(LoggerName, Options, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(LoggerName, in Options.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(LoggerName, in Options.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(in LoggerName.GetPinnableReference(), Options, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(in LoggerName.GetPinnableReference(), Options, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(in LoggerName.GetPinnableReference(), in Options.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(in LoggerName.GetPinnableReference(), in Options.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(LoggerName, Options, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(LoggerName, in Options.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(LoggerName, in Options.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, nint* MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, Options, AllocationSize, MemoryPartitionHandle, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, Span<nint> MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, Options, AllocationSize, ref MemoryPartitionHandle.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, Span<nint> MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, Options, AllocationSize, ref MemoryPartitionHandle.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, nint* MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, in Options.GetPinnableReference(), AllocationSize, MemoryPartitionHandle, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, nint* MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, in Options.GetPinnableReference(), AllocationSize, MemoryPartitionHandle, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, Span<nint> MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, in Options.GetPinnableReference(), AllocationSize, ref MemoryPartitionHandle.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, Span<nint> MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, in Options.GetPinnableReference(), AllocationSize, ref MemoryPartitionHandle.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, nint* MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(in LoggerName.GetPinnableReference(), Options, AllocationSize, MemoryPartitionHandle, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, nint* MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(in LoggerName.GetPinnableReference(), Options, AllocationSize, MemoryPartitionHandle, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, Span<nint> MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(in LoggerName.GetPinnableReference(), Options, AllocationSize, ref MemoryPartitionHandle.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, Span<nint> MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(in LoggerName.GetPinnableReference(), Options, AllocationSize, ref MemoryPartitionHandle.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, nint* MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(in LoggerName.GetPinnableReference(), in Options.GetPinnableReference(), AllocationSize, MemoryPartitionHandle, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, nint* MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(in LoggerName.GetPinnableReference(), in Options.GetPinnableReference(), AllocationSize, MemoryPartitionHandle, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, Span<nint> MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(in LoggerName.GetPinnableReference(), in Options.GetPinnableReference(), AllocationSize, ref MemoryPartitionHandle.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, Span<nint> MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(in LoggerName.GetPinnableReference(), in Options.GetPinnableReference(), AllocationSize, ref MemoryPartitionHandle.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, nint* MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, Options, AllocationSize, MemoryPartitionHandle, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, Span<nint> MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, Options, AllocationSize, ref MemoryPartitionHandle.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, Span<nint> MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, Options, AllocationSize, ref MemoryPartitionHandle.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, nint* MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, in Options.GetPinnableReference(), AllocationSize, MemoryPartitionHandle, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, nint* MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, in Options.GetPinnableReference(), AllocationSize, MemoryPartitionHandle, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, Span<nint> MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, in Options.GetPinnableReference(), AllocationSize, ref MemoryPartitionHandle.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, Span<nint> MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, in Options.GetPinnableReference(), AllocationSize, ref MemoryPartitionHandle.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] char* LogFileName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(LogFileName, Options, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] char* LogFileName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(LogFileName, in Options.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] char* LogFileName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(LogFileName, in Options.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LogFileName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(in LogFileName.GetPinnableReference(), Options, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LogFileName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(in LogFileName.GetPinnableReference(), Options, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LogFileName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(in LogFileName.GetPinnableReference(), in Options.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LogFileName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(in LogFileName.GetPinnableReference(), in Options.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LogFileName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(LogFileName, Options, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LogFileName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(LogFileName, in Options.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LogFileName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(LogFileName, in Options.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2693, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTraceBufferIncrementReference(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<EtwBufferHeader> Buffer)
        {
            // SpanOverloader
            return thisApi.ProcessTraceBufferIncrementReference(TraceHandle, in Buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTraceBufferDecrementReference(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<EtwBufferHeader> Buffer)
        {
            // SpanOverloader
            return thisApi.ProcessTraceBufferDecrementReference(in Buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2712, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint ProcessTraceAddBufferToBufferStream(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<EtwBufferHeader> Buffer, uint BufferSize)
        {
            // SpanOverloader
            return thisApi.ProcessTraceAddBufferToBufferStream(TraceHandle, in Buffer.GetPinnableReference(), BufferSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2749, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, Span<uint> ReturnLength)
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, InBuffer, InBufferSize, OutBuffer, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2749, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, Span<T0> OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, InBuffer, InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2749, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, Span<T0> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, InBuffer, InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2749, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, ref InBuffer.GetPinnableReference(), InBufferSize, OutBuffer, OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2749, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, ref InBuffer.GetPinnableReference(), InBufferSize, OutBuffer, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2749, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0, T1>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, ref InBuffer.GetPinnableReference(), InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2749, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0, T1>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, ref InBuffer.GetPinnableReference(), InBufferSize, ref OutBuffer.GetPinnableReference(), OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2779, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe ulong OpenTraceA(this Windows thisApi, Span<EventTraceLogfilea> Logfile)
        {
            // SpanOverloader
            return thisApi.OpenTraceA(ref Logfile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2786, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint SetTraceCallback(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> pGuid, PfnPeventCallback EventCallback)
        {
            // SpanOverloader
            return thisApi.SetTraceCallback(in pGuid.GetPinnableReference(), EventCallback);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2794, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint RemoveTraceCallback(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> pGuid)
        {
            // SpanOverloader
            return thisApi.RemoveTraceCallback(in pGuid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2811, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessage(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> MessageGuid, ushort MessageNumber)
        {
            // SpanOverloader
            return thisApi.TraceMessage(LoggerHandle, MessageFlags, in MessageGuid.GetPinnableReference(), MessageNumber);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2827, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessageVa(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, [Flow(FlowDirection.In)] Guid* MessageGuid, ushort MessageNumber, Span<byte> MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, MessageGuid, MessageNumber, ref MessageArgList.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2827, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessageVa(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> MessageGuid, ushort MessageNumber, byte* MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, in MessageGuid.GetPinnableReference(), MessageNumber, MessageArgList);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2827, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessageVa(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> MessageGuid, ushort MessageNumber, Span<byte> MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, in MessageGuid.GetPinnableReference(), MessageNumber, ref MessageArgList.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2827, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared\\evntrace.h")]
        public static unsafe uint TraceMessageVa(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> MessageGuid, ushort MessageNumber, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, in MessageGuid.GetPinnableReference(), MessageNumber, MessageArgList);
        }

    }
}

