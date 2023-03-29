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
        [NativeName("Src", "Line 44, Column 1 in fileapi.h")]
        public static unsafe int CompareFileTime(this Windows thisApi, [Flow(FlowDirection.In)] Filetime* lpFileTime1, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpFileTime2)
        {
            // SpanOverloader
            return thisApi.CompareFileTime(lpFileTime1, in lpFileTime2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 44, Column 1 in fileapi.h")]
        public static unsafe int CompareFileTime(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpFileTime1, [Flow(FlowDirection.In)] Filetime* lpFileTime2)
        {
            // SpanOverloader
            return thisApi.CompareFileTime(in lpFileTime1.GetPinnableReference(), lpFileTime2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 44, Column 1 in fileapi.h")]
        public static unsafe int CompareFileTime(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpFileTime1, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpFileTime2)
        {
            // SpanOverloader
            return thisApi.CompareFileTime(in lpFileTime1.GetPinnableReference(), in lpFileTime2.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 52, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 CreateDirectoryA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpPathName, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryA(lpPathName, ref lpSecurityAttributes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 52, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 CreateDirectoryA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryA(in lpPathName.GetPinnableReference(), lpSecurityAttributes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 52, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 CreateDirectoryA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryA(in lpPathName.GetPinnableReference(), ref lpSecurityAttributes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 52, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 CreateDirectoryA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpPathName, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryA(lpPathName, ref lpSecurityAttributes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 60, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 CreateDirectoryW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpPathName, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryW(lpPathName, ref lpSecurityAttributes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 60, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 CreateDirectoryW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryW(in lpPathName.GetPinnableReference(), lpSecurityAttributes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 60, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 CreateDirectoryW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryW(in lpPathName.GetPinnableReference(), ref lpSecurityAttributes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 60, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 CreateDirectoryW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpPathName, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes)
        {
            // SpanOverloader
            return thisApi.CreateDirectoryW(lpPathName, ref lpSecurityAttributes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in fileapi.h")]
        public static unsafe void* CreateFileA<T0>(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpFileName, uint dwDesiredAccess, uint dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, Span<T0> hTemplateFile) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hTemplateFileSpp = hTemplateFile)
                return thisApi.CreateFileA(lpFileName, dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, hTemplateFileSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in fileapi.h")]
        public static unsafe void* CreateFileA<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, uint dwDesiredAccess, uint dwShareMode, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, Span<T0> hTemplateFile) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hTemplateFileSpp = hTemplateFile)
                return thisApi.CreateFileA(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFileSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in fileapi.h")]
        public static unsafe void* CreateFileA<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, uint dwDesiredAccess, uint dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, Span<T0> hTemplateFile) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hTemplateFileSpp = hTemplateFile)
                return thisApi.CreateFileA(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, hTemplateFileSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in fileapi.h")]
        public static unsafe void* CreateFileA<T0>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileName, uint dwDesiredAccess, uint dwShareMode, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, Span<T0> hTemplateFile) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hTemplateFileSpp = hTemplateFile)
                return thisApi.CreateFileA(lpFileName, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFileSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in fileapi.h")]
        public static unsafe void* CreateFileA<T0>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileName, uint dwDesiredAccess, uint dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, Span<T0> hTemplateFile) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hTemplateFileSpp = hTemplateFile)
                return thisApi.CreateFileA(lpFileName, dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, hTemplateFileSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in fileapi.h")]
        public static unsafe void* CreateFileW<T0>(this Windows thisApi, [Flow(FlowDirection.In)] char* lpFileName, uint dwDesiredAccess, uint dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, Span<T0> hTemplateFile) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hTemplateFileSpp = hTemplateFile)
                return thisApi.CreateFileW(lpFileName, dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, hTemplateFileSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in fileapi.h")]
        public static unsafe void* CreateFileW<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint dwDesiredAccess, uint dwShareMode, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, Span<T0> hTemplateFile) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hTemplateFileSpp = hTemplateFile)
                return thisApi.CreateFileW(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFileSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in fileapi.h")]
        public static unsafe void* CreateFileW<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint dwDesiredAccess, uint dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, Span<T0> hTemplateFile) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hTemplateFileSpp = hTemplateFile)
                return thisApi.CreateFileW(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, hTemplateFileSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in fileapi.h")]
        public static unsafe void* CreateFileW<T0>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, uint dwDesiredAccess, uint dwShareMode, Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, Span<T0> hTemplateFile) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hTemplateFileSpp = hTemplateFile)
                return thisApi.CreateFileW(lpFileName, dwDesiredAccess, dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFileSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in fileapi.h")]
        public static unsafe void* CreateFileW<T0>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, uint dwDesiredAccess, uint dwShareMode, Span<Silk.NET.Core.Native.SecurityAttributes> lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, Span<T0> hTemplateFile) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hTemplateFileSpp = hTemplateFile)
                return thisApi.CreateFileW(lpFileName, dwDesiredAccess, dwShareMode, ref lpSecurityAttributes.GetPinnableReference(), dwCreationDisposition, dwFlagsAndAttributes, hTemplateFileSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 DefineDosDeviceW(this Windows thisApi, uint dwFlags, [Flow(FlowDirection.In)] char* lpDeviceName, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpTargetPath)
        {
            // SpanOverloader
            return thisApi.DefineDosDeviceW(dwFlags, lpDeviceName, in lpTargetPath.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 DefineDosDeviceW(this Windows thisApi, uint dwFlags, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDeviceName, [Flow(FlowDirection.In)] char* lpTargetPath)
        {
            // SpanOverloader
            return thisApi.DefineDosDeviceW(dwFlags, in lpDeviceName.GetPinnableReference(), lpTargetPath);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 DefineDosDeviceW(this Windows thisApi, uint dwFlags, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDeviceName, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpTargetPath)
        {
            // SpanOverloader
            return thisApi.DefineDosDeviceW(dwFlags, in lpDeviceName.GetPinnableReference(), in lpTargetPath.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 DefineDosDeviceW(this Windows thisApi, uint dwFlags, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDeviceName, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpTargetPath)
        {
            // SpanOverloader
            return thisApi.DefineDosDeviceW(dwFlags, in lpDeviceName.GetPinnableReference(), lpTargetPath);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 116, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 DefineDosDeviceW(this Windows thisApi, uint dwFlags, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpDeviceName, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpTargetPath)
        {
            // SpanOverloader
            return thisApi.DefineDosDeviceW(dwFlags, lpDeviceName, in lpTargetPath.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 DeleteFileA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName)
        {
            // SpanOverloader
            return thisApi.DeleteFileA(in lpFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 DeleteFileW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName)
        {
            // SpanOverloader
            return thisApi.DeleteFileW(in lpFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 DeleteVolumeMountPointW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszVolumeMountPoint)
        {
            // SpanOverloader
            return thisApi.DeleteVolumeMountPointW(in lpszVolumeMountPoint.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 FileTimeToLocalFileTime(this Windows thisApi, [Flow(FlowDirection.In)] Filetime* lpFileTime, Span<Filetime> lpLocalFileTime)
        {
            // SpanOverloader
            return thisApi.FileTimeToLocalFileTime(lpFileTime, ref lpLocalFileTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 FileTimeToLocalFileTime(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpFileTime, Filetime* lpLocalFileTime)
        {
            // SpanOverloader
            return thisApi.FileTimeToLocalFileTime(in lpFileTime.GetPinnableReference(), lpLocalFileTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 177, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 FileTimeToLocalFileTime(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpFileTime, Span<Filetime> lpLocalFileTime)
        {
            // SpanOverloader
            return thisApi.FileTimeToLocalFileTime(in lpFileTime.GetPinnableReference(), ref lpLocalFileTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 211, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstChangeNotificationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName, Silk.NET.Core.Bool32 bWatchSubtree, uint dwNotifyFilter)
        {
            // SpanOverloader
            return thisApi.FindFirstChangeNotificationA(in lpPathName.GetPinnableReference(), bWatchSubtree, dwNotifyFilter);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 220, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstChangeNotificationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName, Silk.NET.Core.Bool32 bWatchSubtree, uint dwNotifyFilter)
        {
            // SpanOverloader
            return thisApi.FindFirstChangeNotificationW(in lpPathName.GetPinnableReference(), bWatchSubtree, dwNotifyFilter);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpFileName, Span<Win32FindDataa> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileA(lpFileName, ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, Win32FindDataa* lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileA(in lpFileName.GetPinnableReference(), lpFindFileData);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, Span<Win32FindDataa> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileA(in lpFileName.GetPinnableReference(), ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileName, Span<Win32FindDataa> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileA(lpFileName, ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpFileName, Span<Win32FindDataw> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileW(lpFileName, ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, Win32FindDataw* lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileW(in lpFileName.GetPinnableReference(), lpFindFileData);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, Span<Win32FindDataw> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileW(in lpFileName.GetPinnableReference(), ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, Span<Win32FindDataw> lpFindFileData)
        {
            // SpanOverloader
            return thisApi.FindFirstFileW(lpFileName, ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileExA<T0, T1>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, FindexInfoLevels fInfoLevelId, Span<T0> lpFindFileData, FindexSearchOps fSearchOp, Span<T1> lpSearchFilter, uint dwAdditionalFlags) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* lpFindFileDataSpp = lpFindFileData)
            fixed (void* lpSearchFilterSpp = lpSearchFilter)
                return thisApi.FindFirstFileExA(in lpFileName.GetPinnableReference(), fInfoLevelId, lpFindFileDataSpp, fSearchOp, lpSearchFilterSpp, dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileExA<T0, T1>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileName, FindexInfoLevels fInfoLevelId, Span<T0> lpFindFileData, FindexSearchOps fSearchOp, Span<T1> lpSearchFilter, uint dwAdditionalFlags) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* lpFindFileDataSpp = lpFindFileData)
            fixed (void* lpSearchFilterSpp = lpSearchFilter)
                return thisApi.FindFirstFileExA(lpFileName, fInfoLevelId, lpFindFileDataSpp, fSearchOp, lpSearchFilterSpp, dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 275, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileExW<T0, T1>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, FindexInfoLevels fInfoLevelId, Span<T0> lpFindFileData, FindexSearchOps fSearchOp, Span<T1> lpSearchFilter, uint dwAdditionalFlags) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* lpFindFileDataSpp = lpFindFileData)
            fixed (void* lpSearchFilterSpp = lpSearchFilter)
                return thisApi.FindFirstFileExW(in lpFileName.GetPinnableReference(), fInfoLevelId, lpFindFileDataSpp, fSearchOp, lpSearchFilterSpp, dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 275, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileExW<T0, T1>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, FindexInfoLevels fInfoLevelId, Span<T0> lpFindFileData, FindexSearchOps fSearchOp, Span<T1> lpSearchFilter, uint dwAdditionalFlags) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* lpFindFileDataSpp = lpFindFileData)
            fixed (void* lpSearchFilterSpp = lpSearchFilter)
                return thisApi.FindFirstFileExW(lpFileName, fInfoLevelId, lpFindFileDataSpp, fSearchOp, lpSearchFilterSpp, dwAdditionalFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstVolumeW(this Windows thisApi, Span<char> lpszVolumeName, uint cchBufferLength)
        {
            // SpanOverloader
            return thisApi.FindFirstVolumeW(ref lpszVolumeName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 FindNextFileA<T0>(this Windows thisApi, Span<T0> hFindFile, Span<Win32FindDataa> lpFindFileData) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFindFileSpp = hFindFile)
                return thisApi.FindNextFileA(hFindFileSpp, ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 333, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 FindNextFileW<T0>(this Windows thisApi, Span<T0> hFindFile, Span<Win32FindDataw> lpFindFileData) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFindFileSpp = hFindFile)
                return thisApi.FindNextFileW(hFindFileSpp, ref lpFindFileData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 FindNextVolumeW<T0>(this Windows thisApi, Span<T0> hFindVolume, Span<char> lpszVolumeName, uint cchBufferLength) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFindVolumeSpp = hFindVolume)
                return thisApi.FindNextVolumeW(hFindVolumeSpp, ref lpszVolumeName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 FindNextVolumeW<T0>(this Windows thisApi, Span<T0> hFindVolume, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszVolumeName, uint cchBufferLength) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFindVolumeSpp = hFindVolume)
                return thisApi.FindNextVolumeW(hFindVolumeSpp, lpszVolumeName, cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceA(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(in lpRootPathName.GetPinnableReference(), ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, uint* lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, uint* lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, lpSectorsPerCluster, ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, uint* lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), lpBytesPerSector, ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, uint* lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), lpNumberOfFreeClusters, ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, uint* lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), lpTotalNumberOfClusters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 396, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<uint> lpSectorsPerCluster, Span<uint> lpBytesPerSector, Span<uint> lpNumberOfFreeClusters, Span<uint> lpTotalNumberOfClusters)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceW(lpRootPathName, ref lpSectorsPerCluster.GetPinnableReference(), ref lpBytesPerSector.GetPinnableReference(), ref lpNumberOfFreeClusters.GetPinnableReference(), ref lpTotalNumberOfClusters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExA(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(in lpDirectoryName.GetPinnableReference(), ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, lpFreeBytesAvailableToCaller, lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpDirectoryName, ulong* lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, lpFreeBytesAvailableToCaller, ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, ulong* lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), lpTotalNumberOfBytes, ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, ulong* lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), lpTotalNumberOfFreeBytes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 422, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetDiskFreeSpaceExW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpDirectoryName, Span<ulong> lpFreeBytesAvailableToCaller, Span<ulong> lpTotalNumberOfBytes, Span<ulong> lpTotalNumberOfFreeBytes)
        {
            // SpanOverloader
            return thisApi.GetDiskFreeSpaceExW(lpDirectoryName, ref lpFreeBytesAvailableToCaller.GetPinnableReference(), ref lpTotalNumberOfBytes.GetPinnableReference(), ref lpTotalNumberOfFreeBytes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 534, Column 1 in fileapi.h")]
        public static unsafe int GetDiskSpaceInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* rootPath, Span<DiskSpaceInformation> diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationA(rootPath, ref diskSpaceInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 534, Column 1 in fileapi.h")]
        public static unsafe int GetDiskSpaceInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> rootPath, DiskSpaceInformation* diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationA(in rootPath.GetPinnableReference(), diskSpaceInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 534, Column 1 in fileapi.h")]
        public static unsafe int GetDiskSpaceInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> rootPath, Span<DiskSpaceInformation> diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationA(in rootPath.GetPinnableReference(), ref diskSpaceInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 534, Column 1 in fileapi.h")]
        public static unsafe int GetDiskSpaceInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string rootPath, Span<DiskSpaceInformation> diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationA(rootPath, ref diskSpaceInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 542, Column 1 in fileapi.h")]
        public static unsafe int GetDiskSpaceInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* rootPath, Span<DiskSpaceInformation> diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationW(rootPath, ref diskSpaceInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 542, Column 1 in fileapi.h")]
        public static unsafe int GetDiskSpaceInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> rootPath, DiskSpaceInformation* diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationW(in rootPath.GetPinnableReference(), diskSpaceInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 542, Column 1 in fileapi.h")]
        public static unsafe int GetDiskSpaceInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> rootPath, Span<DiskSpaceInformation> diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationW(in rootPath.GetPinnableReference(), ref diskSpaceInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 542, Column 1 in fileapi.h")]
        public static unsafe int GetDiskSpaceInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string rootPath, Span<DiskSpaceInformation> diskSpaceInfo)
        {
            // SpanOverloader
            return thisApi.GetDiskSpaceInformationW(rootPath, ref diskSpaceInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 561, Column 1 in fileapi.h")]
        public static unsafe uint GetDriveTypeA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName)
        {
            // SpanOverloader
            return thisApi.GetDriveTypeA(in lpRootPathName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 568, Column 1 in fileapi.h")]
        public static unsafe uint GetDriveTypeW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName)
        {
            // SpanOverloader
            return thisApi.GetDriveTypeW(in lpRootPathName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 589, Column 1 in fileapi.h")]
        public static unsafe uint GetFileAttributesA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName)
        {
            // SpanOverloader
            return thisApi.GetFileAttributesA(in lpFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 596, Column 1 in fileapi.h")]
        public static unsafe uint GetFileAttributesW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName)
        {
            // SpanOverloader
            return thisApi.GetFileAttributesW(in lpFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 608, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileAttributesExA<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, GetFileexInfoLevels fInfoLevelId, Span<T0> lpFileInformation) where T0 : struct
        {
            // SpanOverloader
            fixed (void* lpFileInformationSpp = lpFileInformation)
                return thisApi.GetFileAttributesExA(in lpFileName.GetPinnableReference(), fInfoLevelId, lpFileInformationSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 608, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileAttributesExA<T0>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileName, GetFileexInfoLevels fInfoLevelId, Span<T0> lpFileInformation) where T0 : struct
        {
            // SpanOverloader
            fixed (void* lpFileInformationSpp = lpFileInformation)
                return thisApi.GetFileAttributesExA(lpFileName, fInfoLevelId, lpFileInformationSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileAttributesExW<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, GetFileexInfoLevels fInfoLevelId, Span<T0> lpFileInformation) where T0 : struct
        {
            // SpanOverloader
            fixed (void* lpFileInformationSpp = lpFileInformation)
                return thisApi.GetFileAttributesExW(in lpFileName.GetPinnableReference(), fInfoLevelId, lpFileInformationSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 617, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileAttributesExW<T0>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, GetFileexInfoLevels fInfoLevelId, Span<T0> lpFileInformation) where T0 : struct
        {
            // SpanOverloader
            fixed (void* lpFileInformationSpp = lpFileInformation)
                return thisApi.GetFileAttributesExW(lpFileName, fInfoLevelId, lpFileInformationSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 644, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileInformationByHandle<T0>(this Windows thisApi, Span<T0> hFile, Span<ByHandleFileInformation> lpFileInformation) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFileInformationByHandle(hFileSpp, ref lpFileInformation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 658, Column 1 in fileapi.h")]
        public static unsafe uint GetFileSize<T0>(this Windows thisApi, Span<T0> hFile, Span<uint> lpFileSizeHigh) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFileSize(hFileSpp, ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 672, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileSizeEx<T0>(this Windows thisApi, Span<T0> hFile, Span<long> lpFileSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFileSizeEx(hFileSpp, ref lpFileSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 1 in fileapi.h")]
        public static unsafe uint GetFinalPathNameByHandleA<T0>(this Windows thisApi, Span<T0> hFile, Span<byte> lpszFilePath, uint cchFilePath, uint dwFlags) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFinalPathNameByHandleA(hFileSpp, ref lpszFilePath.GetPinnableReference(), cchFilePath, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 689, Column 1 in fileapi.h")]
        public static unsafe uint GetFinalPathNameByHandleA<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpszFilePath, uint cchFilePath, uint dwFlags) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFinalPathNameByHandleA(hFileSpp, lpszFilePath, cchFilePath, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 699, Column 1 in fileapi.h")]
        public static unsafe uint GetFinalPathNameByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpszFilePath, uint cchFilePath, uint dwFlags) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFinalPathNameByHandleW(hFileSpp, ref lpszFilePath.GetPinnableReference(), cchFilePath, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 699, Column 1 in fileapi.h")]
        public static unsafe uint GetFinalPathNameByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszFilePath, uint cchFilePath, uint dwFlags) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFinalPathNameByHandleW(hFileSpp, lpszFilePath, cchFilePath, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileTime<T0>(this Windows thisApi, Span<T0> hFile, Filetime* lpCreationTime, Filetime* lpLastAccessTime, Span<Filetime> lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFileTime(hFileSpp, lpCreationTime, lpLastAccessTime, ref lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileTime<T0>(this Windows thisApi, Span<T0> hFile, Filetime* lpCreationTime, Span<Filetime> lpLastAccessTime, Filetime* lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFileTime(hFileSpp, lpCreationTime, ref lpLastAccessTime.GetPinnableReference(), lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileTime<T0>(this Windows thisApi, Span<T0> hFile, Filetime* lpCreationTime, Span<Filetime> lpLastAccessTime, Span<Filetime> lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFileTime(hFileSpp, lpCreationTime, ref lpLastAccessTime.GetPinnableReference(), ref lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileTime<T0>(this Windows thisApi, Span<T0> hFile, Span<Filetime> lpCreationTime, Filetime* lpLastAccessTime, Filetime* lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFileTime(hFileSpp, ref lpCreationTime.GetPinnableReference(), lpLastAccessTime, lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileTime<T0>(this Windows thisApi, Span<T0> hFile, Span<Filetime> lpCreationTime, Filetime* lpLastAccessTime, Span<Filetime> lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFileTime(hFileSpp, ref lpCreationTime.GetPinnableReference(), lpLastAccessTime, ref lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileTime<T0>(this Windows thisApi, Span<T0> hFile, Span<Filetime> lpCreationTime, Span<Filetime> lpLastAccessTime, Filetime* lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFileTime(hFileSpp, ref lpCreationTime.GetPinnableReference(), ref lpLastAccessTime.GetPinnableReference(), lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 716, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetFileTime<T0>(this Windows thisApi, Span<T0> hFile, Span<Filetime> lpCreationTime, Span<Filetime> lpLastAccessTime, Span<Filetime> lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetFileTime(hFileSpp, ref lpCreationTime.GetPinnableReference(), ref lpLastAccessTime.GetPinnableReference(), ref lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpFileName, uint nBufferLength, Span<char> lpBuffer, char** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(lpFileName, nBufferLength, ref lpBuffer.GetPinnableReference(), lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpFileName, uint nBufferLength, Span<char> lpBuffer, ref char* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(lpFileName, nBufferLength, ref lpBuffer.GetPinnableReference(), ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint nBufferLength, char* lpBuffer, char** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint nBufferLength, char* lpBuffer, ref char* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint nBufferLength, Span<char> lpBuffer, char** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(in lpFileName.GetPinnableReference(), nBufferLength, ref lpBuffer.GetPinnableReference(), lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint nBufferLength, Span<char> lpBuffer, ref char* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(in lpFileName.GetPinnableReference(), nBufferLength, ref lpBuffer.GetPinnableReference(), ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint nBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpBuffer, char** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint nBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpBuffer, ref char* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, uint nBufferLength, Span<char> lpBuffer, char** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(lpFileName, nBufferLength, ref lpBuffer.GetPinnableReference(), lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, uint nBufferLength, Span<char> lpBuffer, ref char* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameW(lpFileName, nBufferLength, ref lpBuffer.GetPinnableReference(), ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpFileName, uint nBufferLength, Span<byte> lpBuffer, byte** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(lpFileName, nBufferLength, ref lpBuffer.GetPinnableReference(), lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpFileName, uint nBufferLength, Span<byte> lpBuffer, ref byte* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(lpFileName, nBufferLength, ref lpBuffer.GetPinnableReference(), ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, uint nBufferLength, byte* lpBuffer, byte** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, uint nBufferLength, byte* lpBuffer, ref byte* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, uint nBufferLength, Span<byte> lpBuffer, byte** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(in lpFileName.GetPinnableReference(), nBufferLength, ref lpBuffer.GetPinnableReference(), lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, uint nBufferLength, Span<byte> lpBuffer, ref byte* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(in lpFileName.GetPinnableReference(), nBufferLength, ref lpBuffer.GetPinnableReference(), ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, uint nBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpBuffer, byte** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, uint nBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpBuffer, ref byte* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(in lpFileName.GetPinnableReference(), nBufferLength, lpBuffer, ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileName, uint nBufferLength, Span<byte> lpBuffer, byte** lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(lpFileName, nBufferLength, ref lpBuffer.GetPinnableReference(), lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in fileapi.h")]
        public static unsafe uint GetFullPathNameA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileName, uint nBufferLength, Span<byte> lpBuffer, ref byte* lpFilePart)
        {
            // SpanOverloader
            return thisApi.GetFullPathNameA(lpFileName, nBufferLength, ref lpBuffer.GetPinnableReference(), ref lpFilePart);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 1 in fileapi.h")]
        public static unsafe uint GetLogicalDriveStringsW(this Windows thisApi, uint nBufferLength, Span<char> lpBuffer)
        {
            // SpanOverloader
            return thisApi.GetLogicalDriveStringsW(nBufferLength, ref lpBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 788, Column 1 in fileapi.h")]
        public static unsafe uint GetLongPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpszShortPath, Span<byte> lpszLongPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameA(lpszShortPath, ref lpszLongPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 788, Column 1 in fileapi.h")]
        public static unsafe uint GetLongPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpszShortPath, byte* lpszLongPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameA(in lpszShortPath.GetPinnableReference(), lpszLongPath, cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 788, Column 1 in fileapi.h")]
        public static unsafe uint GetLongPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpszShortPath, Span<byte> lpszLongPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameA(in lpszShortPath.GetPinnableReference(), ref lpszLongPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 788, Column 1 in fileapi.h")]
        public static unsafe uint GetLongPathNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpszShortPath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpszLongPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameA(in lpszShortPath.GetPinnableReference(), lpszLongPath, cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 788, Column 1 in fileapi.h")]
        public static unsafe uint GetLongPathNameA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpszShortPath, Span<byte> lpszLongPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameA(lpszShortPath, ref lpszLongPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 802, Column 1 in fileapi.h")]
        public static unsafe uint GetLongPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpszShortPath, Span<char> lpszLongPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameW(lpszShortPath, ref lpszLongPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 802, Column 1 in fileapi.h")]
        public static unsafe uint GetLongPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszShortPath, char* lpszLongPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameW(in lpszShortPath.GetPinnableReference(), lpszLongPath, cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 802, Column 1 in fileapi.h")]
        public static unsafe uint GetLongPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszShortPath, Span<char> lpszLongPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameW(in lpszShortPath.GetPinnableReference(), ref lpszLongPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 802, Column 1 in fileapi.h")]
        public static unsafe uint GetLongPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszShortPath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszLongPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameW(in lpszShortPath.GetPinnableReference(), lpszLongPath, cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 802, Column 1 in fileapi.h")]
        public static unsafe uint GetLongPathNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszShortPath, Span<char> lpszLongPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetLongPathNameW(lpszShortPath, ref lpszLongPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 823, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 AreShortNamesEnabled<T0>(this Windows thisApi, Span<T0> Handle, Span<int> Enabled) where T0 : struct
        {
            // SpanOverloader
            fixed (void* HandleSpp = Handle)
                return thisApi.AreShortNamesEnabled(HandleSpp, ref Enabled.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 1 in fileapi.h")]
        public static unsafe uint GetShortPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpszLongPath, Span<char> lpszShortPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetShortPathNameW(lpszLongPath, ref lpszShortPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 1 in fileapi.h")]
        public static unsafe uint GetShortPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszLongPath, char* lpszShortPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetShortPathNameW(in lpszLongPath.GetPinnableReference(), lpszShortPath, cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 1 in fileapi.h")]
        public static unsafe uint GetShortPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszLongPath, Span<char> lpszShortPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetShortPathNameW(in lpszLongPath.GetPinnableReference(), ref lpszShortPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 1 in fileapi.h")]
        public static unsafe uint GetShortPathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszLongPath, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszShortPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetShortPathNameW(in lpszLongPath.GetPinnableReference(), lpszShortPath, cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 834, Column 1 in fileapi.h")]
        public static unsafe uint GetShortPathNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszLongPath, Span<char> lpszShortPath, uint cchBuffer)
        {
            // SpanOverloader
            return thisApi.GetShortPathNameW(lpszLongPath, ref lpszShortPath.GetPinnableReference(), cchBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpPathName, [Flow(FlowDirection.In)] char* lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPrefixString, uint uUnique, char* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpPathName, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName, [Flow(FlowDirection.In)] char* lpPrefixString, uint uUnique, char* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName, [Flow(FlowDirection.In)] char* lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName, [Flow(FlowDirection.In)] char* lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPrefixString, uint uUnique, char* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), in lpPrefixString.GetPinnableReference(), uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, char* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpPathName, [Flow(FlowDirection.In)] char* lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPrefixString, uint uUnique, char* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpPathName, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpPrefixString, uint uUnique, Span<char> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameW(lpPathName, lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationByHandleW<T0>(this Windows thisApi, Span<T0> hFile, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.GetVolumeInformationByHandleW(hFileSpp, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, char* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, Span<char> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, char* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<char> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationW(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpszFileName, Span<char> lpszVolumePathName, uint cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNameW(lpszFileName, ref lpszVolumePathName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszFileName, char* lpszVolumePathName, uint cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNameW(in lpszFileName.GetPinnableReference(), lpszVolumePathName, cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszFileName, Span<char> lpszVolumePathName, uint cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNameW(in lpszFileName.GetPinnableReference(), ref lpszVolumePathName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszFileName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszVolumePathName, uint cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNameW(in lpszFileName.GetPinnableReference(), lpszVolumePathName, cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszFileName, Span<char> lpszVolumePathName, uint cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNameW(lpszFileName, ref lpszVolumePathName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 LocalFileTimeToFileTime(this Windows thisApi, [Flow(FlowDirection.In)] Filetime* lpLocalFileTime, Span<Filetime> lpFileTime)
        {
            // SpanOverloader
            return thisApi.LocalFileTimeToFileTime(lpLocalFileTime, ref lpFileTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 LocalFileTimeToFileTime(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLocalFileTime, Filetime* lpFileTime)
        {
            // SpanOverloader
            return thisApi.LocalFileTimeToFileTime(in lpLocalFileTime.GetPinnableReference(), lpFileTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 922, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 LocalFileTimeToFileTime(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLocalFileTime, Span<Filetime> lpFileTime)
        {
            // SpanOverloader
            return thisApi.LocalFileTimeToFileTime(in lpLocalFileTime.GetPinnableReference(), ref lpFileTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 941, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 LockFileEx<T0>(this Windows thisApi, Span<T0> hFile, uint dwFlags, uint dwReserved, uint nNumberOfBytesToLockLow, uint nNumberOfBytesToLockHigh, Span<Overlapped> lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.LockFileEx(hFileSpp, dwFlags, dwReserved, nNumberOfBytesToLockLow, nNumberOfBytesToLockHigh, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 1 in fileapi.h")]
        public static unsafe uint QueryDosDeviceW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpDeviceName, Span<char> lpTargetPath, uint ucchMax)
        {
            // SpanOverloader
            return thisApi.QueryDosDeviceW(lpDeviceName, ref lpTargetPath.GetPinnableReference(), ucchMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 1 in fileapi.h")]
        public static unsafe uint QueryDosDeviceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDeviceName, char* lpTargetPath, uint ucchMax)
        {
            // SpanOverloader
            return thisApi.QueryDosDeviceW(in lpDeviceName.GetPinnableReference(), lpTargetPath, ucchMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 1 in fileapi.h")]
        public static unsafe uint QueryDosDeviceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDeviceName, Span<char> lpTargetPath, uint ucchMax)
        {
            // SpanOverloader
            return thisApi.QueryDosDeviceW(in lpDeviceName.GetPinnableReference(), ref lpTargetPath.GetPinnableReference(), ucchMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 1 in fileapi.h")]
        public static unsafe uint QueryDosDeviceW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpDeviceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpTargetPath, uint ucchMax)
        {
            // SpanOverloader
            return thisApi.QueryDosDeviceW(in lpDeviceName.GetPinnableReference(), lpTargetPath, ucchMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 959, Column 1 in fileapi.h")]
        public static unsafe uint QueryDosDeviceW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpDeviceName, Span<char> lpTargetPath, uint ucchMax)
        {
            // SpanOverloader
            return thisApi.QueryDosDeviceW(lpDeviceName, ref lpTargetPath.GetPinnableReference(), ucchMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 ReadFile<T0, T1>(this Windows thisApi, Span<T0> hFile, Span<T1> lpBuffer, uint nNumberOfBytesToRead, uint* lpNumberOfBytesRead, Span<Overlapped> lpOverlapped) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
            fixed (void* lpBufferSpp = lpBuffer)
                return thisApi.ReadFile(hFileSpp, lpBufferSpp, nNumberOfBytesToRead, lpNumberOfBytesRead, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 ReadFile<T0, T1>(this Windows thisApi, Span<T0> hFile, Span<T1> lpBuffer, uint nNumberOfBytesToRead, Span<uint> lpNumberOfBytesRead, Overlapped* lpOverlapped) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
            fixed (void* lpBufferSpp = lpBuffer)
                return thisApi.ReadFile(hFileSpp, lpBufferSpp, nNumberOfBytesToRead, ref lpNumberOfBytesRead.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 979, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 ReadFile<T0, T1>(this Windows thisApi, Span<T0> hFile, Span<T1> lpBuffer, uint nNumberOfBytesToRead, Span<uint> lpNumberOfBytesRead, Span<Overlapped> lpOverlapped) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
            fixed (void* lpBufferSpp = lpBuffer)
                return thisApi.ReadFile(hFileSpp, lpBufferSpp, nNumberOfBytesToRead, ref lpNumberOfBytesRead.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 ReadFileEx<T0, T1>(this Windows thisApi, Span<T0> hFile, Span<T1> lpBuffer, uint nNumberOfBytesToRead, Span<Overlapped> lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
            fixed (void* lpBufferSpp = lpBuffer)
                return thisApi.ReadFileEx(hFileSpp, lpBufferSpp, nNumberOfBytesToRead, ref lpOverlapped.GetPinnableReference(), lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 ReadFileScatter<T0>(this Windows thisApi, Span<T0> hFile, FileSegmentElement* aSegmentArray, uint nNumberOfBytesToRead, uint* lpReserved, Span<Overlapped> lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.ReadFileScatter(hFileSpp, aSegmentArray, nNumberOfBytesToRead, lpReserved, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 ReadFileScatter<T0>(this Windows thisApi, Span<T0> hFile, FileSegmentElement* aSegmentArray, uint nNumberOfBytesToRead, Span<uint> lpReserved, Overlapped* lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.ReadFileScatter(hFileSpp, aSegmentArray, nNumberOfBytesToRead, ref lpReserved.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 ReadFileScatter<T0>(this Windows thisApi, Span<T0> hFile, FileSegmentElement* aSegmentArray, uint nNumberOfBytesToRead, Span<uint> lpReserved, Span<Overlapped> lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.ReadFileScatter(hFileSpp, aSegmentArray, nNumberOfBytesToRead, ref lpReserved.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 ReadFileScatter<T0>(this Windows thisApi, Span<T0> hFile, Span<FileSegmentElement> aSegmentArray, uint nNumberOfBytesToRead, uint* lpReserved, Overlapped* lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.ReadFileScatter(hFileSpp, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToRead, lpReserved, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 ReadFileScatter<T0>(this Windows thisApi, Span<T0> hFile, Span<FileSegmentElement> aSegmentArray, uint nNumberOfBytesToRead, uint* lpReserved, Span<Overlapped> lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.ReadFileScatter(hFileSpp, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToRead, lpReserved, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 ReadFileScatter<T0>(this Windows thisApi, Span<T0> hFile, Span<FileSegmentElement> aSegmentArray, uint nNumberOfBytesToRead, Span<uint> lpReserved, Overlapped* lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.ReadFileScatter(hFileSpp, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToRead, ref lpReserved.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 ReadFileScatter<T0>(this Windows thisApi, Span<T0> hFile, Span<FileSegmentElement> aSegmentArray, uint nNumberOfBytesToRead, Span<uint> lpReserved, Span<Overlapped> lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.ReadFileScatter(hFileSpp, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToRead, ref lpReserved.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 RemoveDirectoryA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName)
        {
            // SpanOverloader
            return thisApi.RemoveDirectoryA(in lpPathName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1021, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 RemoveDirectoryW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpPathName)
        {
            // SpanOverloader
            return thisApi.RemoveDirectoryW(in lpPathName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 SetFileAttributesA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, uint dwFileAttributes)
        {
            // SpanOverloader
            return thisApi.SetFileAttributesA(in lpFileName.GetPinnableReference(), dwFileAttributes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1048, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 SetFileAttributesW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint dwFileAttributes)
        {
            // SpanOverloader
            return thisApi.SetFileAttributesW(in lpFileName.GetPinnableReference(), dwFileAttributes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1075, Column 1 in fileapi.h")]
        public static unsafe uint SetFilePointer<T0>(this Windows thisApi, Span<T0> hFile, int lDistanceToMove, Span<int> lpDistanceToMoveHigh, uint dwMoveMethod) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.SetFilePointer(hFileSpp, lDistanceToMove, ref lpDistanceToMoveHigh.GetPinnableReference(), dwMoveMethod);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1085, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 SetFilePointerEx<T0>(this Windows thisApi, Span<T0> hFile, long liDistanceToMove, Span<long> lpNewFilePointer, uint dwMoveMethod) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.SetFilePointerEx(hFileSpp, liDistanceToMove, ref lpNewFilePointer.GetPinnableReference(), dwMoveMethod);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 SetFileTime<T0>(this Windows thisApi, Span<T0> hFile, [Flow(FlowDirection.In)] Filetime* lpCreationTime, [Flow(FlowDirection.In)] Filetime* lpLastAccessTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.SetFileTime(hFileSpp, lpCreationTime, lpLastAccessTime, in lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 SetFileTime<T0>(this Windows thisApi, Span<T0> hFile, [Flow(FlowDirection.In)] Filetime* lpCreationTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastAccessTime, [Flow(FlowDirection.In)] Filetime* lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.SetFileTime(hFileSpp, lpCreationTime, in lpLastAccessTime.GetPinnableReference(), lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 SetFileTime<T0>(this Windows thisApi, Span<T0> hFile, [Flow(FlowDirection.In)] Filetime* lpCreationTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastAccessTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.SetFileTime(hFileSpp, lpCreationTime, in lpLastAccessTime.GetPinnableReference(), in lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 SetFileTime<T0>(this Windows thisApi, Span<T0> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpCreationTime, [Flow(FlowDirection.In)] Filetime* lpLastAccessTime, [Flow(FlowDirection.In)] Filetime* lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.SetFileTime(hFileSpp, in lpCreationTime.GetPinnableReference(), lpLastAccessTime, lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 SetFileTime<T0>(this Windows thisApi, Span<T0> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpCreationTime, [Flow(FlowDirection.In)] Filetime* lpLastAccessTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.SetFileTime(hFileSpp, in lpCreationTime.GetPinnableReference(), lpLastAccessTime, in lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 SetFileTime<T0>(this Windows thisApi, Span<T0> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpCreationTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastAccessTime, [Flow(FlowDirection.In)] Filetime* lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.SetFileTime(hFileSpp, in lpCreationTime.GetPinnableReference(), in lpLastAccessTime.GetPinnableReference(), lpLastWriteTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1095, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 SetFileTime<T0>(this Windows thisApi, Span<T0> hFile, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpCreationTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastAccessTime, [Flow(FlowDirection.In)] ReadOnlySpan<Filetime> lpLastWriteTime) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.SetFileTime(hFileSpp, in lpCreationTime.GetPinnableReference(), in lpLastAccessTime.GetPinnableReference(), in lpLastWriteTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1128, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 UnlockFileEx<T0>(this Windows thisApi, Span<T0> hFile, uint dwReserved, uint nNumberOfBytesToUnlockLow, uint nNumberOfBytesToUnlockHigh, Span<Overlapped> lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.UnlockFileEx(hFileSpp, dwReserved, nNumberOfBytesToUnlockLow, nNumberOfBytesToUnlockHigh, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 WriteFile<T0, T1>(this Windows thisApi, Span<T0> hFile, [Flow(FlowDirection.In)] Span<T1> lpBuffer, uint nNumberOfBytesToWrite, uint* lpNumberOfBytesWritten, Span<Overlapped> lpOverlapped) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
            fixed (void* lpBufferSpp = lpBuffer)
                return thisApi.WriteFile(hFileSpp, lpBufferSpp, nNumberOfBytesToWrite, lpNumberOfBytesWritten, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 WriteFile<T0, T1>(this Windows thisApi, Span<T0> hFile, [Flow(FlowDirection.In)] Span<T1> lpBuffer, uint nNumberOfBytesToWrite, Span<uint> lpNumberOfBytesWritten, Overlapped* lpOverlapped) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
            fixed (void* lpBufferSpp = lpBuffer)
                return thisApi.WriteFile(hFileSpp, lpBufferSpp, nNumberOfBytesToWrite, ref lpNumberOfBytesWritten.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1139, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 WriteFile<T0, T1>(this Windows thisApi, Span<T0> hFile, [Flow(FlowDirection.In)] Span<T1> lpBuffer, uint nNumberOfBytesToWrite, Span<uint> lpNumberOfBytesWritten, Span<Overlapped> lpOverlapped) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
            fixed (void* lpBufferSpp = lpBuffer)
                return thisApi.WriteFile(hFileSpp, lpBufferSpp, nNumberOfBytesToWrite, ref lpNumberOfBytesWritten.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1150, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 WriteFileEx<T0, T1>(this Windows thisApi, Span<T0> hFile, [Flow(FlowDirection.In)] Span<T1> lpBuffer, uint nNumberOfBytesToWrite, Span<Overlapped> lpOverlapped, PfnLpoverlappedCompletionRoutine lpCompletionRoutine) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
            fixed (void* lpBufferSpp = lpBuffer)
                return thisApi.WriteFileEx(hFileSpp, lpBufferSpp, nNumberOfBytesToWrite, ref lpOverlapped.GetPinnableReference(), lpCompletionRoutine);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 WriteFileGather<T0>(this Windows thisApi, Span<T0> hFile, FileSegmentElement* aSegmentArray, uint nNumberOfBytesToWrite, uint* lpReserved, Span<Overlapped> lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.WriteFileGather(hFileSpp, aSegmentArray, nNumberOfBytesToWrite, lpReserved, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 WriteFileGather<T0>(this Windows thisApi, Span<T0> hFile, FileSegmentElement* aSegmentArray, uint nNumberOfBytesToWrite, Span<uint> lpReserved, Overlapped* lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.WriteFileGather(hFileSpp, aSegmentArray, nNumberOfBytesToWrite, ref lpReserved.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 WriteFileGather<T0>(this Windows thisApi, Span<T0> hFile, FileSegmentElement* aSegmentArray, uint nNumberOfBytesToWrite, Span<uint> lpReserved, Span<Overlapped> lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.WriteFileGather(hFileSpp, aSegmentArray, nNumberOfBytesToWrite, ref lpReserved.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 WriteFileGather<T0>(this Windows thisApi, Span<T0> hFile, Span<FileSegmentElement> aSegmentArray, uint nNumberOfBytesToWrite, uint* lpReserved, Overlapped* lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.WriteFileGather(hFileSpp, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToWrite, lpReserved, lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 WriteFileGather<T0>(this Windows thisApi, Span<T0> hFile, Span<FileSegmentElement> aSegmentArray, uint nNumberOfBytesToWrite, uint* lpReserved, Span<Overlapped> lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.WriteFileGather(hFileSpp, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToWrite, lpReserved, ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 WriteFileGather<T0>(this Windows thisApi, Span<T0> hFile, Span<FileSegmentElement> aSegmentArray, uint nNumberOfBytesToWrite, Span<uint> lpReserved, Overlapped* lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.WriteFileGather(hFileSpp, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToWrite, ref lpReserved.GetPinnableReference(), lpOverlapped);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1161, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 WriteFileGather<T0>(this Windows thisApi, Span<T0> hFile, Span<FileSegmentElement> aSegmentArray, uint nNumberOfBytesToWrite, Span<uint> lpReserved, Span<Overlapped> lpOverlapped) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFileSpp = hFile)
                return thisApi.WriteFileGather(hFileSpp, ref aSegmentArray.GetPinnableReference(), nNumberOfBytesToWrite, ref lpReserved.GetPinnableReference(), ref lpOverlapped.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1172, Column 1 in fileapi.h")]
        public static unsafe uint GetTempPathW(this Windows thisApi, uint nBufferLength, Span<char> lpBuffer)
        {
            // SpanOverloader
            return thisApi.GetTempPathW(nBufferLength, ref lpBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1190, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeNameForVolumeMountPointW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpszVolumeMountPoint, Span<char> lpszVolumeName, uint cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumeNameForVolumeMountPointW(lpszVolumeMountPoint, ref lpszVolumeName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1190, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeNameForVolumeMountPointW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszVolumeMountPoint, char* lpszVolumeName, uint cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumeNameForVolumeMountPointW(in lpszVolumeMountPoint.GetPinnableReference(), lpszVolumeName, cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1190, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeNameForVolumeMountPointW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszVolumeMountPoint, Span<char> lpszVolumeName, uint cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumeNameForVolumeMountPointW(in lpszVolumeMountPoint.GetPinnableReference(), ref lpszVolumeName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1190, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeNameForVolumeMountPointW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszVolumeMountPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszVolumeName, uint cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumeNameForVolumeMountPointW(in lpszVolumeMountPoint.GetPinnableReference(), lpszVolumeName, cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1190, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeNameForVolumeMountPointW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszVolumeMountPoint, Span<char> lpszVolumeName, uint cchBufferLength)
        {
            // SpanOverloader
            return thisApi.GetVolumeNameForVolumeMountPointW(lpszVolumeMountPoint, ref lpszVolumeName.GetPinnableReference(), cchBufferLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpszVolumeName, char* lpszVolumePathNames, uint cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(lpszVolumeName, lpszVolumePathNames, cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpszVolumeName, Span<char> lpszVolumePathNames, uint cchBufferLength, uint* lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(lpszVolumeName, ref lpszVolumePathNames.GetPinnableReference(), cchBufferLength, lpcchReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpszVolumeName, Span<char> lpszVolumePathNames, uint cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(lpszVolumeName, ref lpszVolumePathNames.GetPinnableReference(), cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpszVolumeName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string lpszVolumePathNames, uint cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(lpszVolumeName, lpszVolumePathNames, cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszVolumeName, char* lpszVolumePathNames, uint cchBufferLength, uint* lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(in lpszVolumeName.GetPinnableReference(), lpszVolumePathNames, cchBufferLength, lpcchReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszVolumeName, char* lpszVolumePathNames, uint cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(in lpszVolumeName.GetPinnableReference(), lpszVolumePathNames, cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszVolumeName, Span<char> lpszVolumePathNames, uint cchBufferLength, uint* lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(in lpszVolumeName.GetPinnableReference(), ref lpszVolumePathNames.GetPinnableReference(), cchBufferLength, lpcchReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszVolumeName, Span<char> lpszVolumePathNames, uint cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(in lpszVolumeName.GetPinnableReference(), ref lpszVolumePathNames.GetPinnableReference(), cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszVolumeName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string lpszVolumePathNames, uint cchBufferLength, uint* lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(in lpszVolumeName.GetPinnableReference(), lpszVolumePathNames, cchBufferLength, lpcchReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpszVolumeName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string lpszVolumePathNames, uint cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(in lpszVolumeName.GetPinnableReference(), lpszVolumePathNames, cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszVolumeName, char* lpszVolumePathNames, uint cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(lpszVolumeName, lpszVolumePathNames, cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszVolumeName, Span<char> lpszVolumePathNames, uint cchBufferLength, uint* lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(lpszVolumeName, ref lpszVolumePathNames.GetPinnableReference(), cchBufferLength, lpcchReturnLength);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszVolumeName, Span<char> lpszVolumePathNames, uint cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(lpszVolumeName, ref lpszVolumePathNames.GetPinnableReference(), cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1211, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumePathNamesForVolumeNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpszVolumeName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string lpszVolumePathNames, uint cchBufferLength, Span<uint> lpcchReturnLength)
        {
            // SpanOverloader
            return thisApi.GetVolumePathNamesForVolumeNameW(lpszVolumeName, lpszVolumePathNames, cchBufferLength, ref lpcchReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1244, Column 1 in fileapi.h")]
        public static unsafe void* CreateFile2(this Windows thisApi, [Flow(FlowDirection.In)] char* lpFileName, uint dwDesiredAccess, uint dwShareMode, uint dwCreationDisposition, Span<Createfile2ExtendedParameters> pCreateExParams)
        {
            // SpanOverloader
            return thisApi.CreateFile2(lpFileName, dwDesiredAccess, dwShareMode, dwCreationDisposition, ref pCreateExParams.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1244, Column 1 in fileapi.h")]
        public static unsafe void* CreateFile2(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint dwDesiredAccess, uint dwShareMode, uint dwCreationDisposition, Createfile2ExtendedParameters* pCreateExParams)
        {
            // SpanOverloader
            return thisApi.CreateFile2(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, dwCreationDisposition, pCreateExParams);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1244, Column 1 in fileapi.h")]
        public static unsafe void* CreateFile2(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint dwDesiredAccess, uint dwShareMode, uint dwCreationDisposition, Span<Createfile2ExtendedParameters> pCreateExParams)
        {
            // SpanOverloader
            return thisApi.CreateFile2(in lpFileName.GetPinnableReference(), dwDesiredAccess, dwShareMode, dwCreationDisposition, ref pCreateExParams.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1244, Column 1 in fileapi.h")]
        public static unsafe void* CreateFile2(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, uint dwDesiredAccess, uint dwShareMode, uint dwCreationDisposition, Span<Createfile2ExtendedParameters> pCreateExParams)
        {
            // SpanOverloader
            return thisApi.CreateFile2(lpFileName, dwDesiredAccess, dwShareMode, dwCreationDisposition, ref pCreateExParams.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1265, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 SetFileIoOverlappedRange<T0>(this Windows thisApi, Span<T0> FileHandle, Span<byte> OverlappedRangeStart, uint Length) where T0 : struct
        {
            // SpanOverloader
            fixed (void* FileHandleSpp = FileHandle)
                return thisApi.SetFileIoOverlappedRange(FileHandleSpp, ref OverlappedRangeStart.GetPinnableReference(), Length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1265, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 SetFileIoOverlappedRange<T0>(this Windows thisApi, Span<T0> FileHandle, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string OverlappedRangeStart, uint Length) where T0 : struct
        {
            // SpanOverloader
            fixed (void* FileHandleSpp = FileHandle)
                return thisApi.SetFileIoOverlappedRange(FileHandleSpp, OverlappedRangeStart, Length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1278, Column 1 in fileapi.h")]
        public static unsafe uint GetCompressedFileSizeA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpFileName, Span<uint> lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeA(lpFileName, ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1278, Column 1 in fileapi.h")]
        public static unsafe uint GetCompressedFileSizeA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, uint* lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeA(in lpFileName.GetPinnableReference(), lpFileSizeHigh);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1278, Column 1 in fileapi.h")]
        public static unsafe uint GetCompressedFileSizeA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpFileName, Span<uint> lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeA(in lpFileName.GetPinnableReference(), ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1278, Column 1 in fileapi.h")]
        public static unsafe uint GetCompressedFileSizeA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileName, Span<uint> lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeA(lpFileName, ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1286, Column 1 in fileapi.h")]
        public static unsafe uint GetCompressedFileSizeW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpFileName, Span<uint> lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeW(lpFileName, ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1286, Column 1 in fileapi.h")]
        public static unsafe uint GetCompressedFileSizeW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint* lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeW(in lpFileName.GetPinnableReference(), lpFileSizeHigh);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1286, Column 1 in fileapi.h")]
        public static unsafe uint GetCompressedFileSizeW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, Span<uint> lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeW(in lpFileName.GetPinnableReference(), ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1286, Column 1 in fileapi.h")]
        public static unsafe uint GetCompressedFileSizeW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, Span<uint> lpFileSizeHigh)
        {
            // SpanOverloader
            return thisApi.GetCompressedFileSizeW(lpFileName, ref lpFileSizeHigh.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstStreamW<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, StreamInfoLevels InfoLevel, Span<T0> lpFindStreamData, uint dwFlags) where T0 : struct
        {
            // SpanOverloader
            fixed (void* lpFindStreamDataSpp = lpFindStreamData)
                return thisApi.FindFirstStreamW(in lpFileName.GetPinnableReference(), InfoLevel, lpFindStreamDataSpp, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstStreamW<T0>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, StreamInfoLevels InfoLevel, Span<T0> lpFindStreamData, uint dwFlags) where T0 : struct
        {
            // SpanOverloader
            fixed (void* lpFindStreamDataSpp = lpFindStreamData)
                return thisApi.FindFirstStreamW(lpFileName, InfoLevel, lpFindStreamDataSpp, dwFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1356, Column 1 in fileapi.h")]
        public static unsafe uint GetTempPathA(this Windows thisApi, uint nBufferLength, Span<byte> lpBuffer)
        {
            // SpanOverloader
            return thisApi.GetTempPathA(nBufferLength, ref lpBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpFileName, uint dwFlags, uint* StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(lpFileName, dwFlags, StringLength, ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpFileName, uint dwFlags, Span<uint> StringLength, char* LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(lpFileName, dwFlags, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpFileName, uint dwFlags, Span<uint> StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(lpFileName, dwFlags, ref StringLength.GetPinnableReference(), ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] char* lpFileName, uint dwFlags, Span<uint> StringLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(lpFileName, dwFlags, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint dwFlags, uint* StringLength, char* LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(in lpFileName.GetPinnableReference(), dwFlags, StringLength, LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint dwFlags, uint* StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(in lpFileName.GetPinnableReference(), dwFlags, StringLength, ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint dwFlags, uint* StringLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(in lpFileName.GetPinnableReference(), dwFlags, StringLength, LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint dwFlags, Span<uint> StringLength, char* LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(in lpFileName.GetPinnableReference(), dwFlags, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint dwFlags, Span<uint> StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(in lpFileName.GetPinnableReference(), dwFlags, ref StringLength.GetPinnableReference(), ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> lpFileName, uint dwFlags, Span<uint> StringLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(in lpFileName.GetPinnableReference(), dwFlags, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, uint dwFlags, uint* StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(lpFileName, dwFlags, StringLength, ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, uint dwFlags, Span<uint> StringLength, char* LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(lpFileName, dwFlags, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, uint dwFlags, Span<uint> StringLength, Span<char> LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(lpFileName, dwFlags, ref StringLength.GetPinnableReference(), ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1376, Column 1 in fileapi.h")]
        public static unsafe void* FindFirstFileNameW(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpFileName, uint dwFlags, Span<uint> StringLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LinkName)
        {
            // SpanOverloader
            return thisApi.FindFirstFileNameW(lpFileName, dwFlags, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 FindNextFileNameW<T0>(this Windows thisApi, Span<T0> hFindStream, uint* StringLength, Span<char> LinkName) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFindStreamSpp = hFindStream)
                return thisApi.FindNextFileNameW(hFindStreamSpp, StringLength, ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 FindNextFileNameW<T0>(this Windows thisApi, Span<T0> hFindStream, uint* StringLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LinkName) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFindStreamSpp = hFindStream)
                return thisApi.FindNextFileNameW(hFindStreamSpp, StringLength, LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 FindNextFileNameW<T0>(this Windows thisApi, Span<T0> hFindStream, Span<uint> StringLength, char* LinkName) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFindStreamSpp = hFindStream)
                return thisApi.FindNextFileNameW(hFindStreamSpp, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 FindNextFileNameW<T0>(this Windows thisApi, Span<T0> hFindStream, Span<uint> StringLength, Span<char> LinkName) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFindStreamSpp = hFindStream)
                return thisApi.FindNextFileNameW(hFindStreamSpp, ref StringLength.GetPinnableReference(), ref LinkName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1386, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 FindNextFileNameW<T0>(this Windows thisApi, Span<T0> hFindStream, Span<uint> StringLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LinkName) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hFindStreamSpp = hFindStream)
                return thisApi.FindNextFileNameW(hFindStreamSpp, ref StringLength.GetPinnableReference(), LinkName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(in lpRootPathName.GetPinnableReference(), lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, byte* lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, Span<byte> lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, ref lpVolumeNameBuffer.GetPinnableReference(), nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, uint* lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, lpVolumeSerialNumber, ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, uint* lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), lpMaximumComponentLength, ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, uint* lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), lpFileSystemFlags, lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, byte* lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, Span<byte> lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), ref lpFileSystemNameBuffer.GetPinnableReference(), nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1403, Column 1 in fileapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetVolumeInformationA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpRootPathName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpVolumeNameBuffer, uint nVolumeNameSize, Span<uint> lpVolumeSerialNumber, Span<uint> lpMaximumComponentLength, Span<uint> lpFileSystemFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpFileSystemNameBuffer, uint nFileSystemNameSize)
        {
            // SpanOverloader
            return thisApi.GetVolumeInformationA(lpRootPathName, lpVolumeNameBuffer, nVolumeNameSize, ref lpVolumeSerialNumber.GetPinnableReference(), ref lpMaximumComponentLength.GetPinnableReference(), ref lpFileSystemFlags.GetPinnableReference(), lpFileSystemNameBuffer, nFileSystemNameSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpPathName, [Flow(FlowDirection.In)] byte* lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPrefixString, uint uUnique, byte* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] byte* lpPathName, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName, [Flow(FlowDirection.In)] byte* lpPrefixString, uint uUnique, byte* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName, [Flow(FlowDirection.In)] byte* lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName, [Flow(FlowDirection.In)] byte* lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPrefixString, uint uUnique, byte* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), in lpPrefixString.GetPinnableReference(), uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpPrefixString, uint uUnique, byte* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPathName, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(in lpPathName.GetPinnableReference(), lpPrefixString, uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpPathName, [Flow(FlowDirection.In)] byte* lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPrefixString, uint uUnique, byte* lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpPathName, [Flow(FlowDirection.In)] ReadOnlySpan<byte> lpPrefixString, uint uUnique, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, in lpPrefixString.GetPinnableReference(), uUnique, lpTempFileName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1427, Column 1 in fileapi.h")]
        public static unsafe uint GetTempFileNameA(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpPathName, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string lpPrefixString, uint uUnique, Span<byte> lpTempFileName)
        {
            // SpanOverloader
            return thisApi.GetTempFileNameA(lpPathName, lpPrefixString, uUnique, ref lpTempFileName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1469, Column 1 in fileapi.h")]
        public static unsafe uint GetTempPath2W(this Windows thisApi, uint BufferLength, Span<char> Buffer)
        {
            // SpanOverloader
            return thisApi.GetTempPath2W(BufferLength, ref Buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1482, Column 1 in fileapi.h")]
        public static unsafe uint GetTempPath2A(this Windows thisApi, uint BufferLength, Span<byte> Buffer)
        {
            // SpanOverloader
            return thisApi.GetTempPath2A(BufferLength, ref Buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 1 in handleapi.h")]
        public static unsafe Silk.NET.Core.Bool32 DuplicateHandle<T0, T1, T2>(this Windows thisApi, Span<T0> hSourceProcessHandle, Span<T1> hSourceHandle, Span<T2> hTargetProcessHandle, ref void* lpTargetHandle, uint dwDesiredAccess, Silk.NET.Core.Bool32 bInheritHandle, uint dwOptions) where T0 : struct where T1 : struct where T2 : struct
        {
            // SpanOverloader
            fixed (void* hSourceProcessHandleSpp = hSourceProcessHandle)
            fixed (void* hSourceHandleSpp = hSourceHandle)
            fixed (void* hTargetProcessHandleSpp = hTargetProcessHandle)
                return thisApi.DuplicateHandle(hSourceProcessHandleSpp, hSourceHandleSpp, hTargetProcessHandleSpp, ref lpTargetHandle, dwDesiredAccess, bInheritHandle, dwOptions);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in handleapi.h")]
        public static unsafe Silk.NET.Core.Bool32 GetHandleInformation<T0>(this Windows thisApi, Span<T0> hObject, Span<uint> lpdwFlags) where T0 : struct
        {
            // SpanOverloader
            fixed (void* hObjectSpp = hObject)
                return thisApi.GetHandleInformation(hObjectSpp, ref lpdwFlags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2005, Column 43 in objidlbase.h")]
        public static unsafe int IEnumUnknownRemoteNextProxy(this Windows thisApi, IEnumUnknown* This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownRemoteNextProxy(This, celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2005, Column 43 in objidlbase.h")]
        public static unsafe int IEnumUnknownRemoteNextProxy(this Windows thisApi, IEnumUnknown* This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownRemoteNextProxy(This, celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2005, Column 43 in objidlbase.h")]
        public static unsafe int IEnumUnknownRemoteNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownRemoteNextProxy(ref This.GetPinnableReference(), celt, rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2005, Column 43 in objidlbase.h")]
        public static unsafe int IEnumUnknownRemoteNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownRemoteNextProxy(ref This.GetPinnableReference(), celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2005, Column 43 in objidlbase.h")]
        public static unsafe int IEnumUnknownRemoteNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownRemoteNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2005, Column 43 in objidlbase.h")]
        public static unsafe int IEnumUnknownRemoteNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownRemoteNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 17 in objidlbase.h")]
        public static unsafe void IEnumUnknownRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumUnknownRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2144, Column 43 in objidlbase.h")]
        public static unsafe int IEnumStringRemoteNextProxy(this Windows thisApi, IEnumString* This, uint celt, char** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringRemoteNextProxy(This, celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2144, Column 43 in objidlbase.h")]
        public static unsafe int IEnumStringRemoteNextProxy(this Windows thisApi, IEnumString* This, uint celt, ref char* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringRemoteNextProxy(This, celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2144, Column 43 in objidlbase.h")]
        public static unsafe int IEnumStringRemoteNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, char** rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringRemoteNextProxy(ref This.GetPinnableReference(), celt, rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2144, Column 43 in objidlbase.h")]
        public static unsafe int IEnumStringRemoteNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, char** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringRemoteNextProxy(ref This.GetPinnableReference(), celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2144, Column 43 in objidlbase.h")]
        public static unsafe int IEnumStringRemoteNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, ref char* rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringRemoteNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2144, Column 43 in objidlbase.h")]
        public static unsafe int IEnumStringRemoteNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, ref char* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringRemoteNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2151, Column 17 in objidlbase.h")]
        public static unsafe void IEnumStringRemoteNextStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IEnumStringRemoteNextStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, ISequentialStream* This, byte* pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(This, pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, ISequentialStream* This, Span<byte> pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(This, ref pv.GetPinnableReference(), cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, ISequentialStream* This, Span<byte> pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(This, ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, ISequentialStream* This, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(This, pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, Span<ISequentialStream> This, byte* pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(ref This.GetPinnableReference(), pv, cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, Span<ISequentialStream> This, byte* pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(ref This.GetPinnableReference(), pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, Span<ISequentialStream> This, Span<byte> pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(ref This.GetPinnableReference(), ref pv.GetPinnableReference(), cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, Span<ISequentialStream> This, Span<byte> pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(ref This.GetPinnableReference(), ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, Span<ISequentialStream> This, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(ref This.GetPinnableReference(), pv, cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2273, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteReadProxy(this Windows thisApi, Span<ISequentialStream> This, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteReadProxy(ref This.GetPinnableReference(), pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2280, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteReadStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteReadStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] byte* pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(This, pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(This, in pv.GetPinnableReference(), cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(This, in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(This, pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] byte* pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(ref This.GetPinnableReference(), pv, cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] byte* pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(ref This.GetPinnableReference(), pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(ref This.GetPinnableReference(), in pv.GetPinnableReference(), cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(ref This.GetPinnableReference(), in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(ref This.GetPinnableReference(), pv, cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2287, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamRemoteWriteProxy(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamRemoteWriteProxy(ref This.GetPinnableReference(), pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2294, Column 17 in objidlbase.h")]
        public static unsafe void ISequentialStreamRemoteWriteStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.ISequentialStreamRemoteWriteStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2568, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteSeekProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, long dlibMove, uint dwOrigin, Span<ulong> plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteSeekProxy(This, dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2568, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteSeekProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, long dlibMove, uint dwOrigin, ulong* plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteSeekProxy(ref This.GetPinnableReference(), dlibMove, dwOrigin, plibNewPosition);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2568, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteSeekProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, long dlibMove, uint dwOrigin, Span<ulong> plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteSeekProxy(ref This.GetPinnableReference(), dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2575, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteSeekStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteSeekStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(This, ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), pstm, cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2582, Column 43 in objidlbase.h")]
        public static unsafe int IStreamRemoteCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamRemoteCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, IRpcStubBuffer* This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(This, ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, IRpcChannelBuffer* _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), _pRpcChannelBuffer, ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, RPCMessage* _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), _pRpcMessage, ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, uint* _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), _pdwStubPhase);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 17 in objidlbase.h")]
        public static unsafe void IStreamRemoteCopyToStub(this Windows thisApi, Span<IRpcStubBuffer> This, Span<IRpcChannelBuffer> _pRpcChannelBuffer, Span<RPCMessage> _pRpcMessage, Span<uint> _pdwStubPhase)
        {
            // SpanOverloader
            thisApi.IStreamRemoteCopyToStub(ref This.GetPinnableReference(), ref _pRpcChannelBuffer.GetPinnableReference(), ref _pRpcMessage.GetPinnableReference(), ref _pdwStubPhase.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8449, Column 41 in objidlbase.h")]
        public static unsafe int IEnumUnknownNextProxy(this Windows thisApi, IEnumUnknown* This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextProxy(This, celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8449, Column 41 in objidlbase.h")]
        public static unsafe int IEnumUnknownNextProxy(this Windows thisApi, IEnumUnknown* This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextProxy(This, celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8449, Column 41 in objidlbase.h")]
        public static unsafe int IEnumUnknownNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextProxy(ref This.GetPinnableReference(), celt, rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8449, Column 41 in objidlbase.h")]
        public static unsafe int IEnumUnknownNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextProxy(ref This.GetPinnableReference(), celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8449, Column 41 in objidlbase.h")]
        public static unsafe int IEnumUnknownNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8449, Column 41 in objidlbase.h")]
        public static unsafe int IEnumUnknownNextProxy(this Windows thisApi, Span<IEnumUnknown> This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8459, Column 43 in objidlbase.h")]
        public static unsafe int IEnumUnknownNextStub(this Windows thisApi, IEnumUnknown* This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextStub(This, celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8459, Column 43 in objidlbase.h")]
        public static unsafe int IEnumUnknownNextStub(this Windows thisApi, IEnumUnknown* This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextStub(This, celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8459, Column 43 in objidlbase.h")]
        public static unsafe int IEnumUnknownNextStub(this Windows thisApi, Span<IEnumUnknown> This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextStub(ref This.GetPinnableReference(), celt, rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8459, Column 43 in objidlbase.h")]
        public static unsafe int IEnumUnknownNextStub(this Windows thisApi, Span<IEnumUnknown> This, uint celt, Silk.NET.Core.Native.IUnknown** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextStub(ref This.GetPinnableReference(), celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8459, Column 43 in objidlbase.h")]
        public static unsafe int IEnumUnknownNextStub(this Windows thisApi, Span<IEnumUnknown> This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextStub(ref This.GetPinnableReference(), celt, ref rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8459, Column 43 in objidlbase.h")]
        public static unsafe int IEnumUnknownNextStub(this Windows thisApi, Span<IEnumUnknown> This, uint celt, ref Silk.NET.Core.Native.IUnknown* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumUnknownNextStub(ref This.GetPinnableReference(), celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8465, Column 41 in objidlbase.h")]
        public static unsafe int IEnumStringNextProxy(this Windows thisApi, IEnumString* This, uint celt, char** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextProxy(This, celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8465, Column 41 in objidlbase.h")]
        public static unsafe int IEnumStringNextProxy(this Windows thisApi, IEnumString* This, uint celt, ref char* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextProxy(This, celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8465, Column 41 in objidlbase.h")]
        public static unsafe int IEnumStringNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, char** rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextProxy(ref This.GetPinnableReference(), celt, rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8465, Column 41 in objidlbase.h")]
        public static unsafe int IEnumStringNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, char** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextProxy(ref This.GetPinnableReference(), celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8465, Column 41 in objidlbase.h")]
        public static unsafe int IEnumStringNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, ref char* rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8465, Column 41 in objidlbase.h")]
        public static unsafe int IEnumStringNextProxy(this Windows thisApi, Span<IEnumString> This, uint celt, ref char* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextProxy(ref This.GetPinnableReference(), celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8474, Column 43 in objidlbase.h")]
        public static unsafe int IEnumStringNextStub(this Windows thisApi, IEnumString* This, uint celt, char** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextStub(This, celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8474, Column 43 in objidlbase.h")]
        public static unsafe int IEnumStringNextStub(this Windows thisApi, IEnumString* This, uint celt, ref char* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextStub(This, celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8474, Column 43 in objidlbase.h")]
        public static unsafe int IEnumStringNextStub(this Windows thisApi, Span<IEnumString> This, uint celt, char** rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextStub(ref This.GetPinnableReference(), celt, rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8474, Column 43 in objidlbase.h")]
        public static unsafe int IEnumStringNextStub(this Windows thisApi, Span<IEnumString> This, uint celt, char** rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextStub(ref This.GetPinnableReference(), celt, rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8474, Column 43 in objidlbase.h")]
        public static unsafe int IEnumStringNextStub(this Windows thisApi, Span<IEnumString> This, uint celt, ref char* rgelt, uint* pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextStub(ref This.GetPinnableReference(), celt, ref rgelt, pceltFetched);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8474, Column 43 in objidlbase.h")]
        public static unsafe int IEnumStringNextStub(this Windows thisApi, Span<IEnumString> This, uint celt, ref char* rgelt, Span<uint> pceltFetched)
        {
            // SpanOverloader
            return thisApi.IEnumStringNextStub(ref This.GetPinnableReference(), celt, ref rgelt, ref pceltFetched.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8480, Column 41 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadProxy<T0>(this Windows thisApi, ISequentialStream* This, Span<T0> pv, uint cb, Span<uint> pcbRead) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pvSpp = pv)
                return thisApi.ISequentialStreamReadProxy(This, pvSpp, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8480, Column 41 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadProxy<T0>(this Windows thisApi, Span<ISequentialStream> This, Span<T0> pv, uint cb, uint* pcbRead) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pvSpp = pv)
                return thisApi.ISequentialStreamReadProxy(ref This.GetPinnableReference(), pvSpp, cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8480, Column 41 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadProxy<T0>(this Windows thisApi, Span<ISequentialStream> This, Span<T0> pv, uint cb, Span<uint> pcbRead) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pvSpp = pv)
                return thisApi.ISequentialStreamReadProxy(ref This.GetPinnableReference(), pvSpp, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, ISequentialStream* This, byte* pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(This, pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, ISequentialStream* This, Span<byte> pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(This, ref pv.GetPinnableReference(), cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, ISequentialStream* This, Span<byte> pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(This, ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, ISequentialStream* This, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(This, pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, Span<ISequentialStream> This, byte* pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(ref This.GetPinnableReference(), pv, cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, Span<ISequentialStream> This, byte* pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(ref This.GetPinnableReference(), pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, Span<ISequentialStream> This, Span<byte> pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(ref This.GetPinnableReference(), ref pv.GetPinnableReference(), cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, Span<ISequentialStream> This, Span<byte> pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(ref This.GetPinnableReference(), ref pv.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, Span<ISequentialStream> This, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, uint* pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(ref This.GetPinnableReference(), pv, cb, pcbRead);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8490, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamReadStub(this Windows thisApi, Span<ISequentialStream> This, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbRead)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamReadStub(ref This.GetPinnableReference(), pv, cb, ref pcbRead.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8496, Column 41 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteProxy<T0>(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] Span<T0> pv, uint cb, Span<uint> pcbWritten) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pvSpp = pv)
                return thisApi.ISequentialStreamWriteProxy(This, pvSpp, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8496, Column 41 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteProxy<T0>(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] Span<T0> pv, uint cb, uint* pcbWritten) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pvSpp = pv)
                return thisApi.ISequentialStreamWriteProxy(ref This.GetPinnableReference(), pvSpp, cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8496, Column 41 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteProxy<T0>(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] Span<T0> pv, uint cb, Span<uint> pcbWritten) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pvSpp = pv)
                return thisApi.ISequentialStreamWriteProxy(ref This.GetPinnableReference(), pvSpp, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] byte* pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(This, pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(This, in pv.GetPinnableReference(), cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(This, in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, ISequentialStream* This, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(This, pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] byte* pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(ref This.GetPinnableReference(), pv, cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] byte* pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(ref This.GetPinnableReference(), pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(ref This.GetPinnableReference(), in pv.GetPinnableReference(), cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In)] ReadOnlySpan<byte> pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(ref This.GetPinnableReference(), in pv.GetPinnableReference(), cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, uint* pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(ref This.GetPinnableReference(), pv, cb, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8506, Column 43 in objidlbase.h")]
        public static unsafe int ISequentialStreamWriteStub(this Windows thisApi, Span<ISequentialStream> This, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pv, uint cb, Span<uint> pcbWritten)
        {
            // SpanOverloader
            return thisApi.ISequentialStreamWriteStub(ref This.GetPinnableReference(), pv, cb, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8512, Column 41 in objidlbase.h")]
        public static unsafe int IStreamSeekProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, long dlibMove, uint dwOrigin, Span<ulong> plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamSeekProxy(This, dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8512, Column 41 in objidlbase.h")]
        public static unsafe int IStreamSeekProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, long dlibMove, uint dwOrigin, ulong* plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamSeekProxy(ref This.GetPinnableReference(), dlibMove, dwOrigin, plibNewPosition);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8512, Column 41 in objidlbase.h")]
        public static unsafe int IStreamSeekProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, long dlibMove, uint dwOrigin, Span<ulong> plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamSeekProxy(ref This.GetPinnableReference(), dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8520, Column 43 in objidlbase.h")]
        public static unsafe int IStreamSeekStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, long dlibMove, uint dwOrigin, Span<ulong> plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamSeekStub(This, dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8520, Column 43 in objidlbase.h")]
        public static unsafe int IStreamSeekStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, long dlibMove, uint dwOrigin, ulong* plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamSeekStub(ref This.GetPinnableReference(), dlibMove, dwOrigin, plibNewPosition);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8520, Column 43 in objidlbase.h")]
        public static unsafe int IStreamSeekStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, long dlibMove, uint dwOrigin, Span<ulong> plibNewPosition)
        {
            // SpanOverloader
            return thisApi.IStreamSeekStub(ref This.GetPinnableReference(), dlibMove, dwOrigin, ref plibNewPosition.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(This, ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), pstm, cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8526, Column 41 in objidlbase.h")]
        public static unsafe int IStreamCopyToProxy(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToProxy(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Silk.NET.Core.Win32Extras.IStream* This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(This, ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), pstm, cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), pstm, cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), pstm, cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Silk.NET.Core.Win32Extras.IStream* pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), pstm, cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, pcbRead, pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, ulong* pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, pcbRead, ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, ulong* pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), pcbWritten);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 8537, Column 43 in objidlbase.h")]
        public static unsafe int IStreamCopyToStub(this Windows thisApi, Span<Silk.NET.Core.Win32Extras.IStream> This, Span<Silk.NET.Core.Win32Extras.IStream> pstm, ulong cb, Span<ulong> pcbRead, Span<ulong> pcbWritten)
        {
            // SpanOverloader
            return thisApi.IStreamCopyToStub(ref This.GetPinnableReference(), ref pstm.GetPinnableReference(), cb, ref pcbRead.GetPinnableReference(), ref pcbWritten.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In)] char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] char* InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceW(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceW(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In)] byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, ulong* TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] byte* InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1686, Column 1 in evntrace.h")]
        public static unsafe uint StartTraceA(this Windows thisApi, Span<ulong> TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StartTraceA(ref TraceHandle.GetPinnableReference(), InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 1 in evntrace.h")]
        public static unsafe uint StopTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 1 in evntrace.h")]
        public static unsafe uint StopTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 1 in evntrace.h")]
        public static unsafe uint StopTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1713, Column 1 in evntrace.h")]
        public static unsafe uint StopTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 1 in evntrace.h")]
        public static unsafe uint StopTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 1 in evntrace.h")]
        public static unsafe uint StopTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 1 in evntrace.h")]
        public static unsafe uint StopTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1728, Column 1 in evntrace.h")]
        public static unsafe uint StopTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.StopTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1754, Column 1 in evntrace.h")]
        public static unsafe uint QueryTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1754, Column 1 in evntrace.h")]
        public static unsafe uint QueryTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1754, Column 1 in evntrace.h")]
        public static unsafe uint QueryTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1754, Column 1 in evntrace.h")]
        public static unsafe uint QueryTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 1 in evntrace.h")]
        public static unsafe uint QueryTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 1 in evntrace.h")]
        public static unsafe uint QueryTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 1 in evntrace.h")]
        public static unsafe uint QueryTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1769, Column 1 in evntrace.h")]
        public static unsafe uint QueryTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.QueryTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 1 in evntrace.h")]
        public static unsafe uint UpdateTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 1 in evntrace.h")]
        public static unsafe uint UpdateTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 1 in evntrace.h")]
        public static unsafe uint UpdateTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1789, Column 1 in evntrace.h")]
        public static unsafe uint UpdateTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 1 in evntrace.h")]
        public static unsafe uint UpdateTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 1 in evntrace.h")]
        public static unsafe uint UpdateTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 1 in evntrace.h")]
        public static unsafe uint UpdateTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1798, Column 1 in evntrace.h")]
        public static unsafe uint UpdateTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.UpdateTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1826, Column 1 in evntrace.h")]
        public static unsafe uint FlushTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] char* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1826, Column 1 in evntrace.h")]
        public static unsafe uint FlushTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1826, Column 1 in evntrace.h")]
        public static unsafe uint FlushTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1826, Column 1 in evntrace.h")]
        public static unsafe uint FlushTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 1 in evntrace.h")]
        public static unsafe uint FlushTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] byte* InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 1 in evntrace.h")]
        public static unsafe uint FlushTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, EventTraceProperties* Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, in InstanceName.GetPinnableReference(), Properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 1 in evntrace.h")]
        public static unsafe uint FlushTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 1 in evntrace.h")]
        public static unsafe uint FlushTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties)
        {
            // SpanOverloader
            return thisApi.FlushTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1862, Column 1 in evntrace.h")]
        public static unsafe uint ControlTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] char* InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1862, Column 1 in evntrace.h")]
        public static unsafe uint ControlTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, EventTraceProperties* Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, in InstanceName.GetPinnableReference(), Properties, ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1862, Column 1 in evntrace.h")]
        public static unsafe uint ControlTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<char> InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1862, Column 1 in evntrace.h")]
        public static unsafe uint ControlTraceW(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceW(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1878, Column 1 in evntrace.h")]
        public static unsafe uint ControlTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] byte* InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1878, Column 1 in evntrace.h")]
        public static unsafe uint ControlTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, EventTraceProperties* Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, in InstanceName.GetPinnableReference(), Properties, ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1878, Column 1 in evntrace.h")]
        public static unsafe uint ControlTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<byte> InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, in InstanceName.GetPinnableReference(), ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1878, Column 1 in evntrace.h")]
        public static unsafe uint ControlTraceA(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string InstanceName, Span<EventTraceProperties> Properties, uint ControlCode)
        {
            // SpanOverloader
            return thisApi.ControlTraceA(TraceHandle, InstanceName, ref Properties.GetPinnableReference(), ControlCode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1896, Column 1 in evntrace.h")]
        public static unsafe uint QueryAllTracesW(this Windows thisApi, EventTraceProperties** PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesW(PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1896, Column 1 in evntrace.h")]
        public static unsafe uint QueryAllTracesW(this Windows thisApi, ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesW(ref PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1905, Column 1 in evntrace.h")]
        public static unsafe uint QueryAllTracesA(this Windows thisApi, EventTraceProperties** PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesA(PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1905, Column 1 in evntrace.h")]
        public static unsafe uint QueryAllTracesA(this Windows thisApi, ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, Span<uint> LoggerCount)
        {
            // SpanOverloader
            return thisApi.QueryAllTracesA(ref PropertyArray, PropertyArrayCount, ref LoggerCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1924, Column 1 in evntrace.h")]
        public static unsafe uint EnableTrace(this Windows thisApi, uint Enable, uint EnableFlag, uint EnableLevel, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, ulong TraceHandle)
        {
            // SpanOverloader
            return thisApi.EnableTrace(Enable, EnableFlag, EnableLevel, in ControlGuid.GetPinnableReference(), TraceHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] Guid* ProviderId, [Flow(FlowDirection.In)] Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ProviderId, SourceId, TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] Guid* ProviderId, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ProviderId, in SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, EnableFilterDesc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] Guid* ProviderId, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(ProviderId, in SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ProviderId, [Flow(FlowDirection.In)] Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(in ProviderId.GetPinnableReference(), SourceId, TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, EnableFilterDesc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ProviderId, [Flow(FlowDirection.In)] Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(in ProviderId.GetPinnableReference(), SourceId, TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ProviderId, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(in ProviderId.GetPinnableReference(), in SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, EnableFilterDesc);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1946, Column 1 in evntrace.h")]
        public static unsafe uint EnableTraceEx(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ProviderId, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, Span<EventFilterDescriptor> EnableFilterDesc)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx(in ProviderId.GetPinnableReference(), in SourceId.GetPinnableReference(), TraceHandle, IsEnabled, Level, MatchAnyKeyword, MatchAllKeyword, EnableProperty, ref EnableFilterDesc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1993, Column 1 in evntrace.h")]
        public static unsafe uint EnableTraceEx2(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] Guid* ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, Span<EnableTraceParameters> EnableParameters)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx2(TraceHandle, ProviderId, ControlCode, Level, MatchAnyKeyword, MatchAllKeyword, Timeout, ref EnableParameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1993, Column 1 in evntrace.h")]
        public static unsafe uint EnableTraceEx2(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, EnableTraceParameters* EnableParameters)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx2(TraceHandle, in ProviderId.GetPinnableReference(), ControlCode, Level, MatchAnyKeyword, MatchAllKeyword, Timeout, EnableParameters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1993, Column 1 in evntrace.h")]
        public static unsafe uint EnableTraceEx2(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, Span<EnableTraceParameters> EnableParameters)
        {
            // SpanOverloader
            return thisApi.EnableTraceEx2(TraceHandle, in ProviderId.GetPinnableReference(), ControlCode, Level, MatchAnyKeyword, MatchAllKeyword, Timeout, ref EnableParameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2370, Column 1 in evntrace.h")]
        public static unsafe uint EnumerateTraceGuidsEx<T0, T1>(this Windows thisApi, TraceQueryInfoClass TraceQueryInfoClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* InBufferSpp = InBuffer)
            fixed (void* OutBufferSpp = OutBuffer)
                return thisApi.EnumerateTraceGuidsEx(TraceQueryInfoClass, InBufferSpp, InBufferSize, OutBufferSpp, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2434, Column 1 in evntrace.h")]
        public static unsafe uint TraceQueryInformation<T0>(this Windows thisApi, ulong SessionHandle, TraceQueryInfoClass InformationClass, Span<T0> TraceInformation, uint InformationLength, Span<uint> ReturnLength) where T0 : struct
        {
            // SpanOverloader
            fixed (void* TraceInformationSpp = TraceInformation)
                return thisApi.TraceQueryInformation(SessionHandle, InformationClass, TraceInformationSpp, InformationLength, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2456, Column 1 in evntrace.h")]
        public static unsafe uint CreateTraceInstanceId<T0>(this Windows thisApi, Span<T0> RegHandle, Span<EventInstanceInfo> InstInfo) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RegHandleSpp = RegHandle)
                return thisApi.CreateTraceInstanceId(RegHandleSpp, ref InstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2474, Column 1 in evntrace.h")]
        public static unsafe uint TraceEvent(this Windows thisApi, ulong TraceHandle, Span<EventTraceHeader> EventTrace)
        {
            // SpanOverloader
            return thisApi.TraceEvent(TraceHandle, ref EventTrace.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, EventInstanceHeader* EventTrace, EventInstanceInfo* InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, EventTrace, InstInfo, ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, EventInstanceHeader* EventTrace, Span<EventInstanceInfo> InstInfo, EventInstanceInfo* ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, EventTrace, ref InstInfo.GetPinnableReference(), ParentInstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, EventInstanceHeader* EventTrace, Span<EventInstanceInfo> InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, EventTrace, ref InstInfo.GetPinnableReference(), ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, EventInstanceInfo* InstInfo, EventInstanceInfo* ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), InstInfo, ParentInstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, EventInstanceInfo* InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), InstInfo, ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, Span<EventInstanceInfo> InstInfo, EventInstanceInfo* ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), ref InstInfo.GetPinnableReference(), ParentInstInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2488, Column 1 in evntrace.h")]
        public static unsafe uint TraceEventInstance(this Windows thisApi, ulong TraceHandle, Span<EventInstanceHeader> EventTrace, Span<EventInstanceInfo> InstInfo, Span<EventInstanceInfo> ParentInstInfo)
        {
            // SpanOverloader
            return thisApi.TraceEventInstance(TraceHandle, ref EventTrace.GetPinnableReference(), ref InstInfo.GetPinnableReference(), ref ParentInstInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] char* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] char* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<char> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2522, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsW<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsW(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] Guid* ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, ControlGuid, GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, TraceGuidReg, MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] byte* MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), in MofImagePath.GetPinnableReference(), MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] byte* MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In)] ReadOnlySpan<byte> MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, in MofResourceName.GetPinnableReference(), ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, ulong* RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, RegistrationHandle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2542, Column 1 in evntrace.h")]
        public static unsafe uint RegisterTraceGuidsA<T0>(this Windows thisApi, PfnWmidprequest RequestAddress, Span<T0> RequestContext, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> ControlGuid, uint GuidCount, Span<TraceGuidRegistration> TraceGuidReg, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofImagePath, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string MofResourceName, Span<ulong> RegistrationHandle) where T0 : struct
        {
            // SpanOverloader
            fixed (void* RequestContextSpp = RequestContext)
                return thisApi.RegisterTraceGuidsA(RequestAddress, RequestContextSpp, in ControlGuid.GetPinnableReference(), GuidCount, ref TraceGuidReg.GetPinnableReference(), MofImagePath, MofResourceName, ref RegistrationHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2557, Column 1 in evntrace.h")]
        public static unsafe uint EnumerateTraceGuids(this Windows thisApi, TraceGuidProperties** GuidPropertiesArray, uint PropertyArrayCount, Span<uint> GuidCount)
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuids(GuidPropertiesArray, PropertyArrayCount, ref GuidCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2557, Column 1 in evntrace.h")]
        public static unsafe uint EnumerateTraceGuids(this Windows thisApi, ref TraceGuidProperties* GuidPropertiesArray, uint PropertyArrayCount, Span<uint> GuidCount)
        {
            // SpanOverloader
            return thisApi.EnumerateTraceGuids(ref GuidPropertiesArray, PropertyArrayCount, ref GuidCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2619, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceW(this Windows thisApi, Span<EventTraceLogfilew> Logfile)
        {
            // SpanOverloader
            return thisApi.OpenTraceW(ref Logfile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, ulong* HandleArray, uint HandleCount, Filetime* StartTime, Span<Filetime> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(HandleArray, HandleCount, StartTime, ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, ulong* HandleArray, uint HandleCount, Span<Filetime> StartTime, Filetime* EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(HandleArray, HandleCount, ref StartTime.GetPinnableReference(), EndTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, ulong* HandleArray, uint HandleCount, Span<Filetime> StartTime, Span<Filetime> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(HandleArray, HandleCount, ref StartTime.GetPinnableReference(), ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, Span<ulong> HandleArray, uint HandleCount, Filetime* StartTime, Filetime* EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, StartTime, EndTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, Span<ulong> HandleArray, uint HandleCount, Filetime* StartTime, Span<Filetime> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, StartTime, ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, Span<ulong> HandleArray, uint HandleCount, Span<Filetime> StartTime, Filetime* EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, ref StartTime.GetPinnableReference(), EndTime);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2627, Column 1 in evntrace.h")]
        public static unsafe uint ProcessTrace(this Windows thisApi, Span<ulong> HandleArray, uint HandleCount, Span<Filetime> StartTime, Span<Filetime> EndTime)
        {
            // SpanOverloader
            return thisApi.ProcessTrace(ref HandleArray.GetPinnableReference(), HandleCount, ref StartTime.GetPinnableReference(), ref EndTime.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2647, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromBufferStream<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, PfnPetwBufferCompletionCallback BufferCompletionCallback, Span<T0> BufferCompletionContext) where T0 : struct
        {
            // SpanOverloader
            fixed (void* BufferCompletionContextSpp = BufferCompletionContext)
                return thisApi.OpenTraceFromBufferStream(in Options.GetPinnableReference(), BufferCompletionCallback, BufferCompletionContextSpp);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(LoggerName, Options, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(LoggerName, in Options.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(LoggerName, in Options.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(in LoggerName.GetPinnableReference(), Options, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(in LoggerName.GetPinnableReference(), Options, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(in LoggerName.GetPinnableReference(), in Options.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(in LoggerName.GetPinnableReference(), in Options.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(LoggerName, Options, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(LoggerName, in Options.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2658, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLogger(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromRealTimeLogger(LoggerName, in Options.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions<T0>(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, Span<T0> MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader) where T0 : struct
        {
            // SpanOverloader
            fixed (void* MemoryPartitionHandleSpp = MemoryPartitionHandle)
                return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, Options, AllocationSize, MemoryPartitionHandleSpp, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions<T0>(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, Span<T0> MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader) where T0 : struct
        {
            // SpanOverloader
            fixed (void* MemoryPartitionHandleSpp = MemoryPartitionHandle)
                return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, in Options.GetPinnableReference(), AllocationSize, MemoryPartitionHandleSpp, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions<T0>(this Windows thisApi, [Flow(FlowDirection.In)] char* LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, Span<T0> MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader) where T0 : struct
        {
            // SpanOverloader
            fixed (void* MemoryPartitionHandleSpp = MemoryPartitionHandle)
                return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, in Options.GetPinnableReference(), AllocationSize, MemoryPartitionHandleSpp, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, Span<T0> MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader) where T0 : struct
        {
            // SpanOverloader
            fixed (void* MemoryPartitionHandleSpp = MemoryPartitionHandle)
                return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(in LoggerName.GetPinnableReference(), Options, AllocationSize, MemoryPartitionHandleSpp, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, Span<T0> MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader) where T0 : struct
        {
            // SpanOverloader
            fixed (void* MemoryPartitionHandleSpp = MemoryPartitionHandle)
                return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(in LoggerName.GetPinnableReference(), Options, AllocationSize, MemoryPartitionHandleSpp, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, Span<T0> MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader) where T0 : struct
        {
            // SpanOverloader
            fixed (void* MemoryPartitionHandleSpp = MemoryPartitionHandle)
                return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(in LoggerName.GetPinnableReference(), in Options.GetPinnableReference(), AllocationSize, MemoryPartitionHandleSpp, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions<T0>(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, Span<T0> MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader) where T0 : struct
        {
            // SpanOverloader
            fixed (void* MemoryPartitionHandleSpp = MemoryPartitionHandle)
                return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(in LoggerName.GetPinnableReference(), in Options.GetPinnableReference(), AllocationSize, MemoryPartitionHandleSpp, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions<T0>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, Span<T0> MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader) where T0 : struct
        {
            // SpanOverloader
            fixed (void* MemoryPartitionHandleSpp = MemoryPartitionHandle)
                return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, Options, AllocationSize, MemoryPartitionHandleSpp, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions<T0>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, nuint AllocationSize, Span<T0> MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader) where T0 : struct
        {
            // SpanOverloader
            fixed (void* MemoryPartitionHandleSpp = MemoryPartitionHandle)
                return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, Options, AllocationSize, MemoryPartitionHandleSpp, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions<T0>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, Span<T0> MemoryPartitionHandle, TraceLogfileHeader* LogFileHeader) where T0 : struct
        {
            // SpanOverloader
            fixed (void* MemoryPartitionHandleSpp = MemoryPartitionHandle)
                return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, in Options.GetPinnableReference(), AllocationSize, MemoryPartitionHandleSpp, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2669, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromRealTimeLoggerWithAllocationOptions<T0>(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LoggerName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, nuint AllocationSize, Span<T0> MemoryPartitionHandle, Span<TraceLogfileHeader> LogFileHeader) where T0 : struct
        {
            // SpanOverloader
            fixed (void* MemoryPartitionHandleSpp = MemoryPartitionHandle)
                return thisApi.OpenTraceFromRealTimeLoggerWithAllocationOptions(LoggerName, in Options.GetPinnableReference(), AllocationSize, MemoryPartitionHandleSpp, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] char* LogFileName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(LogFileName, Options, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] char* LogFileName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(LogFileName, in Options.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] char* LogFileName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(LogFileName, in Options.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LogFileName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(in LogFileName.GetPinnableReference(), Options, LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LogFileName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(in LogFileName.GetPinnableReference(), Options, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LogFileName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(in LogFileName.GetPinnableReference(), in Options.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<char> LogFileName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(in LogFileName.GetPinnableReference(), in Options.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LogFileName, [Flow(FlowDirection.In)] EtwOpenTraceOptions* Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(LogFileName, Options, ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LogFileName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, TraceLogfileHeader* LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(LogFileName, in Options.GetPinnableReference(), LogFileHeader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2682, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceFromFile(this Windows thisApi, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string LogFileName, [Flow(FlowDirection.In)] ReadOnlySpan<EtwOpenTraceOptions> Options, Span<TraceLogfileHeader> LogFileHeader)
        {
            // SpanOverloader
            return thisApi.OpenTraceFromFile(LogFileName, in Options.GetPinnableReference(), ref LogFileHeader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2693, Column 1 in evntrace.h")]
        public static unsafe uint ProcessTraceBufferIncrementReference(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<EtwBufferHeader> Buffer)
        {
            // SpanOverloader
            return thisApi.ProcessTraceBufferIncrementReference(TraceHandle, in Buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 1 in evntrace.h")]
        public static unsafe uint ProcessTraceBufferDecrementReference(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<EtwBufferHeader> Buffer)
        {
            // SpanOverloader
            return thisApi.ProcessTraceBufferDecrementReference(in Buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2712, Column 1 in evntrace.h")]
        public static unsafe uint ProcessTraceAddBufferToBufferStream(this Windows thisApi, ulong TraceHandle, [Flow(FlowDirection.In)] ReadOnlySpan<EtwBufferHeader> Buffer, uint BufferSize)
        {
            // SpanOverloader
            return thisApi.ProcessTraceAddBufferToBufferStream(TraceHandle, in Buffer.GetPinnableReference(), BufferSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2749, Column 1 in evntrace.h")]
        public static unsafe uint QueryTraceProcessingHandle<T0, T1>(this Windows thisApi, ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, Span<T0> InBuffer, uint InBufferSize, Span<T1> OutBuffer, uint OutBufferSize, Span<uint> ReturnLength) where T0 : struct where T1 : struct
        {
            // SpanOverloader
            fixed (void* InBufferSpp = InBuffer)
            fixed (void* OutBufferSpp = OutBuffer)
                return thisApi.QueryTraceProcessingHandle(ProcessingHandle, InformationClass, InBufferSpp, InBufferSize, OutBufferSpp, OutBufferSize, ref ReturnLength.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2779, Column 1 in evntrace.h")]
        public static unsafe ulong OpenTraceA(this Windows thisApi, Span<EventTraceLogfilea> Logfile)
        {
            // SpanOverloader
            return thisApi.OpenTraceA(ref Logfile.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2786, Column 1 in evntrace.h")]
        public static unsafe uint SetTraceCallback(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> pGuid, PfnPeventCallback EventCallback)
        {
            // SpanOverloader
            return thisApi.SetTraceCallback(in pGuid.GetPinnableReference(), EventCallback);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2794, Column 1 in evntrace.h")]
        public static unsafe uint RemoveTraceCallback(this Windows thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> pGuid)
        {
            // SpanOverloader
            return thisApi.RemoveTraceCallback(in pGuid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2811, Column 1 in evntrace.h")]
        public static unsafe uint TraceMessage(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> MessageGuid, ushort MessageNumber)
        {
            // SpanOverloader
            return thisApi.TraceMessage(LoggerHandle, MessageFlags, in MessageGuid.GetPinnableReference(), MessageNumber);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2827, Column 1 in evntrace.h")]
        public static unsafe uint TraceMessageVa(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, [Flow(FlowDirection.In)] Guid* MessageGuid, ushort MessageNumber, Span<byte> MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, MessageGuid, MessageNumber, ref MessageArgList.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2827, Column 1 in evntrace.h")]
        public static unsafe uint TraceMessageVa(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> MessageGuid, ushort MessageNumber, byte* MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, in MessageGuid.GetPinnableReference(), MessageNumber, MessageArgList);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2827, Column 1 in evntrace.h")]
        public static unsafe uint TraceMessageVa(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> MessageGuid, ushort MessageNumber, Span<byte> MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, in MessageGuid.GetPinnableReference(), MessageNumber, ref MessageArgList.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2827, Column 1 in evntrace.h")]
        public static unsafe uint TraceMessageVa(this Windows thisApi, ulong LoggerHandle, uint MessageFlags, [Flow(FlowDirection.In)] ReadOnlySpan<Guid> MessageGuid, ushort MessageNumber, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string MessageArgList)
        {
            // SpanOverloader
            return thisApi.TraceMessageVa(LoggerHandle, MessageFlags, in MessageGuid.GetPinnableReference(), MessageNumber, MessageArgList);
        }

    }
}

