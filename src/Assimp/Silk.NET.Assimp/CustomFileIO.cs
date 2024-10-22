// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;

namespace Silk.NET.Assimp;

#nullable enable

#if NET5_0_OR_GREATER
/// <summary>
/// A delegate for use with <see cref="OpenFileCustomIOCallback"/> to open a <see cref="Stream"/> representing the
/// requested file, or <c>null</c> if this was not possible.
/// </summary>
/// <param name="file">The file to open.</param>
/// <param name="access">The access mode.</param>
/// <param name="mode">The file open mode.</param>
/// <returns>The opened file, or null if not successful.</returns>
public delegate Stream? OpenFileCustomIOCallback(ReadOnlySpan<char> file, FileAccess access, FileMode mode);

/// <summary>
/// An adapter for using a <see cref="Stream"/> through Assimp's <see cref="FileIO"/> interface.
/// </summary>
public sealed unsafe class CustomFileIO : IDisposable
{
    private OpenFileCustomIOCallback _streamFactory;
    private FileIO _fileIO;
    
    public CustomFileIO(OpenFileCustomIOCallback streamFactory)
    {
        var self = GCHandle.Alloc(this);
        if (!self.IsAllocated)
        {
            throw new InvalidOperationException("Failed to allocate GCHandle for CustomFileIO");
        }
        
        _streamFactory = streamFactory;
        _fileIO = new FileIO
        {
            OpenProc = (delegate* unmanaged[Cdecl]<FileIO*, byte*, byte*, File*>) &OpenFile,
            CloseProc = (delegate* unmanaged[Cdecl]<FileIO*, File*, void>) &CloseFile,
            UserData = (byte*) GCHandle.ToIntPtr(self)
        };
    }
    
    /// <summary>
    /// Gets a reference to the <see cref="FileIO"/> to pass to native.
    /// </summary>
    public ref FileIO FileIO => ref _fileIO;
    
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    private static File* OpenFile(FileIO* mFileSystem, byte* pFile, byte* pMode)
    {
        if (GCHandle.FromIntPtr((nint) mFileSystem->UserData).Target is not CustomFileIO self)
        {
            throw new InvalidOperationException("Invalid UserData for FileIO.");
        }
        
        // We can use SilkMarshal.PtrToString for the string marshalling here, but given this is a short-lived
        // allocation that is likely to be small, we can survive without it. 
        var len = 0;
        while (pFile[len] != 0)
        {
            len++;
        }
        
        var fileSpan = new Span<byte>(pFile, len);
        var charLen = Encoding.UTF8.GetCharCount(fileSpan);
        var chars = charLen > 256 ? new char[charLen] : stackalloc char[charLen];
        Encoding.UTF8.GetChars(fileSpan, chars);
        
        len = 0;
        while (pMode[len] != 0)
        {
            len++;
        }
        
        var modeSpan = new Span<byte>(pMode, len);
        var plus = modeSpan.Contains((byte) '+');
        var write = modeSpan.Contains((byte) 'w') || modeSpan.Contains((byte) 'W');
        var read = modeSpan.Contains((byte) 'r') || modeSpan.Contains((byte) 'R');
        var append = modeSpan.Contains((byte) 'a') || modeSpan.Contains((byte) 'A');
        var access = plus ? FileAccess.ReadWrite :
            write || append ? FileAccess.Write :
            read ? FileAccess.Read : throw new ArgumentException
                ("Invalid mode, must have 'r', 'w', 'a', or '+' set.", nameof(pMode));
        var mode = append && !plus ? FileMode.Append :
            read || append ? FileMode.Open :
            write ? FileMode.Create : throw new ArgumentException("Invalid mode", nameof(pMode));
        
        var stream = self._streamFactory(chars, access, mode);
        if (stream is null)
        {
            return null;
        }
        
        if (append && plus)
        {
            stream.Seek(0, SeekOrigin.End);
        }
        
        var gch = GCHandle.Alloc(stream);
        if (!gch.IsAllocated)
        {
            throw new InvalidOperationException("Failed to allocate GCHandle.");
        }
        
        var file = (File*)SilkMarshal.Allocate(sizeof(File));
        *file = new File
        {
            ReadProc = (delegate* unmanaged[Cdecl]<File*, byte*, nuint, nuint, nuint>)&ReadFile,
            WriteProc = (delegate* unmanaged[Cdecl]<File*, byte*, nuint, nuint, nuint>)&WriteFile,
            FileSizeProc = (delegate* unmanaged[Cdecl]<File*, nuint>)&FileSize,
            TellProc = (delegate* unmanaged[Cdecl]<File*, nuint>)&FileTell,
            FlushProc = (delegate* unmanaged[Cdecl]<File*, void>)&FileFlush,
            SeekProc = (delegate* unmanaged[Cdecl]<File*, nuint, Origin, Return>)&FileSeek,
            UserData = (byte*)GCHandle.ToIntPtr(gch)
        };
        
        return file;
    }
    
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    private static void CloseFile(FileIO* mFileSystem, File* pFile)
    {
        var sHandle = GCHandle.FromIntPtr((nint) pFile->UserData);
        if (sHandle.Target is not Stream s)
        {
            throw new InvalidOperationException("Invalid UserData for FileIO.");
        }
        
        s.Dispose();
        sHandle.Free();
        SilkMarshal.Free((nint) pFile);
    }

    public static Stream GetStream(File* file) =>
        GCHandle.FromIntPtr((nint) file->UserData).Target is not Stream s
            ? throw new InvalidOperationException("Invalid UserData for File.")
            : s;
    
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    private static nuint ReadFile(File* file, byte* buffer, nuint size, nuint count) =>
        ((nuint) GetStream(file).Read(new Span<byte>(buffer, (int) (size * count)))) / size;
    
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    private static nuint WriteFile(File* file, byte* buffer, nuint size, nuint count)
    {
        GetStream(file).Write(new Span<byte>(buffer, (int) (size * count)));
        return count;
    }
    
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    private static nuint FileSize(File* file) =>
        (nuint) GetStream(file).Length;
    
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    private static nuint FileTell(File* file) =>
        (nuint) GetStream(file).Position;
    
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    private static void FileFlush(File* file)
        => GetStream(file).Flush();
    
    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
    private static Return FileSeek(File* file, nuint offset, Origin origin)
    {
        GetStream(file).Seek((long) offset, (SeekOrigin) origin);
        return Return.Success;
    }

    /// <inheritdoc />
    public void Dispose() => GCHandle.FromIntPtr((nint) _fileIO.UserData).Free();
}
#endif
