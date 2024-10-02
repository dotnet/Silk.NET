// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.InteropServices;
using static Silk.NET.SDL.PenAxis;
using static Silk.NET.SDL.Scancode;

namespace Silk.NET.SDL;

public static unsafe partial class Sdl
{
    [DllImport("SDL3", ExactSpelling = true)]
    public static extern AssertState ReportAssertion(
        AssertData* data,
        [NativeTypeName("const char *")] sbyte* func,
        [NativeTypeName("const char *")] sbyte* file,
        int line
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void SetAssertionHandler(
        [NativeTypeName("SDL_AssertionHandler")]
            delegate* unmanaged<AssertData*, void*, AssertState> handler,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_AssertionHandler")]
    public static extern delegate* unmanaged<
        AssertData*,
        void*,
        AssertState> GetDefaultAssertionHandler();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_AssertionHandler")]
    public static extern delegate* unmanaged<AssertData*, void*, AssertState> GetAssertionHandler(
        void** puserdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_AssertData *")]
    public static extern AssertData* GetAssertionReport();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void ResetAssertionReport();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int TryLockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void LockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UnlockSpinlock([NativeTypeName("SDL_SpinLock *")] int* @lock);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void MemoryBarrierReleaseFunction();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void MemoryBarrierAcquireFunction();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int AtomicCompareAndSwap(AtomicInt* a, int oldval, int newval);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int AtomicSet(AtomicInt* a, int v);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int AtomicGet(AtomicInt* a);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int AtomicAdd(AtomicInt* a, int v);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int AtomicCompareAndSwapPointer(void** a, void* oldval, void* newval);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* AtomicSetPtr(void** a, void* v);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* AtomicGetPtr(void** a);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int SetError([NativeTypeName("const char *")] sbyte* fmt, __arglist);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetError();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void ClearError();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int Error(Errorcode code);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Mutex* CreateMutex();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void LockMutex(SDL_Mutex* mutex);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int TryLockMutex(SDL_Mutex* mutex);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UnlockMutex(SDL_Mutex* mutex);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroyMutex(SDL_Mutex* mutex);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_RWLock* CreateRWLock();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void LockRWLockForReading(SDL_RWLock* rwlock);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void LockRWLockForWriting(SDL_RWLock* rwlock);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int TryLockRWLockForReading(SDL_RWLock* rwlock);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int TryLockRWLockForWriting(SDL_RWLock* rwlock);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UnlockRWLock(SDL_RWLock* rwlock);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroyRWLock(SDL_RWLock* rwlock);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Semaphore* CreateSemaphore(
        [NativeTypeName("Uint32")] uint initial_value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroySemaphore(SDL_Semaphore* sem);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int WaitSemaphore(SDL_Semaphore* sem);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int TryWaitSemaphore(SDL_Semaphore* sem);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int WaitSemaphoreTimeout(
        SDL_Semaphore* sem,
        [NativeTypeName("Sint32")] int timeoutMS
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int PostSemaphore(SDL_Semaphore* sem);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint GetSemaphoreValue(SDL_Semaphore* sem);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Condition* CreateCondition();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroyCondition(SDL_Condition* cond);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SignalCondition(SDL_Condition* cond);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int BroadcastCondition(SDL_Condition* cond);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int WaitCondition(SDL_Condition* cond, SDL_Mutex* mutex);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int WaitConditionTimeout(
        SDL_Condition* cond,
        SDL_Mutex* mutex,
        [NativeTypeName("Sint32")] int timeoutMS
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetGlobalProperties();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint CreateProperties();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int CopyProperties(
        [NativeTypeName("SDL_PropertiesID")] uint src,
        [NativeTypeName("SDL_PropertiesID")] uint dst
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int LockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UnlockProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetPropertyWithCleanup(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        void* value,
        [NativeTypeName("void (*)(void *, void *)")]
            delegate* unmanaged<void*, void*, void> cleanup,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        void* value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetStringProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetNumberProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("Sint64")] long value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetFloatProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        float value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetBooleanProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("SDL_bool")] int value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern PropertyType GetPropertyType(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* GetProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        void* default_value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetStringProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* default_value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Sint64")]
    public static extern long GetNumberProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("Sint64")] long default_value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern float GetFloatProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        float default_value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetBooleanProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("SDL_bool")] int default_value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ClearProperty(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("const char *")] sbyte* name
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int EnumerateProperties(
        [NativeTypeName("SDL_PropertiesID")] uint props,
        [NativeTypeName("SDL_EnumeratePropertiesCallback")]
            delegate* unmanaged<void*, uint, sbyte*, void> callback,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroyProperties([NativeTypeName("SDL_PropertiesID")] uint props);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_IOStream* IOFromFile(
        [NativeTypeName("const char *")] sbyte* file,
        [NativeTypeName("const char *")] sbyte* mode
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_IOStream* IOFromMem(void* mem, [NativeTypeName("size_t")] nuint size);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_IOStream* IOFromConstMem(
        [NativeTypeName("const void *")] void* mem,
        [NativeTypeName("size_t")] nuint size
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_IOStream* IOFromDynamicMem();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_IOStream* OpenIO(
        [NativeTypeName("const SDL_IOStreamInterface *")] IOStreamInterface* iface,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int CloseIO(SDL_IOStream* context);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetIOProperties(SDL_IOStream* context);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern IOStatus GetIOStatus(SDL_IOStream* context);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Sint64")]
    public static extern long GetIOSize(SDL_IOStream* context);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Sint64")]
    public static extern long SeekIO(
        SDL_IOStream* context,
        [NativeTypeName("Sint64")] long offset,
        int whence
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Sint64")]
    public static extern long TellIO(SDL_IOStream* context);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint ReadIO(
        SDL_IOStream* context,
        void* ptr,
        [NativeTypeName("size_t")] nuint size
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint WriteIO(
        SDL_IOStream* context,
        [NativeTypeName("const void *")] void* ptr,
        [NativeTypeName("size_t")] nuint size
    );

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint IOprintf(
        SDL_IOStream* context,
        [NativeTypeName("const char *")] sbyte* fmt,
        __arglist
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint IOvprintf(
        SDL_IOStream* context,
        [NativeTypeName("const char *")] sbyte* fmt,
        [NativeTypeName("va_list")] sbyte* ap
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* LoadFileIO(
        SDL_IOStream* src,
        [NativeTypeName("size_t *")] nuint* datasize,
        [NativeTypeName("SDL_bool")] int closeio
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* LoadFile(
        [NativeTypeName("const char *")] sbyte* file,
        [NativeTypeName("size_t *")] nuint* datasize
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadU8(SDL_IOStream* src, [NativeTypeName("Uint8 *")] byte* value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadU16LE(
        SDL_IOStream* src,
        [NativeTypeName("Uint16 *")] ushort* value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadS16LE(
        SDL_IOStream* src,
        [NativeTypeName("Sint16 *")] short* value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadU16BE(
        SDL_IOStream* src,
        [NativeTypeName("Uint16 *")] ushort* value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadS16BE(
        SDL_IOStream* src,
        [NativeTypeName("Sint16 *")] short* value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadU32LE(SDL_IOStream* src, [NativeTypeName("Uint32 *")] uint* value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadS32LE(SDL_IOStream* src, [NativeTypeName("Sint32 *")] int* value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadU32BE(SDL_IOStream* src, [NativeTypeName("Uint32 *")] uint* value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadS32BE(SDL_IOStream* src, [NativeTypeName("Sint32 *")] int* value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadU64LE(
        SDL_IOStream* src,
        [NativeTypeName("Uint64 *")] ulong* value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadS64LE(SDL_IOStream* src, [NativeTypeName("Sint64 *")] long* value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadU64BE(
        SDL_IOStream* src,
        [NativeTypeName("Uint64 *")] ulong* value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ReadS64BE(SDL_IOStream* src, [NativeTypeName("Sint64 *")] long* value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteU8(SDL_IOStream* dst, [NativeTypeName("Uint8")] byte value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteU16LE(SDL_IOStream* dst, [NativeTypeName("Uint16")] ushort value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteS16LE(SDL_IOStream* dst, [NativeTypeName("Sint16")] short value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteU16BE(SDL_IOStream* dst, [NativeTypeName("Uint16")] ushort value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteS16BE(SDL_IOStream* dst, [NativeTypeName("Sint16")] short value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteU32LE(SDL_IOStream* dst, [NativeTypeName("Uint32")] uint value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteS32LE(SDL_IOStream* dst, [NativeTypeName("Sint32")] int value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteU32BE(SDL_IOStream* dst, [NativeTypeName("Uint32")] uint value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteS32BE(SDL_IOStream* dst, [NativeTypeName("Sint32")] int value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteU64LE(SDL_IOStream* dst, [NativeTypeName("Uint64")] ulong value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteS64LE(SDL_IOStream* dst, [NativeTypeName("Sint64")] long value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteU64BE(SDL_IOStream* dst, [NativeTypeName("Uint64")] ulong value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WriteS64BE(SDL_IOStream* dst, [NativeTypeName("Sint64")] long value);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Thread* CreateThread(
        [NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged<void*, int> fn,
        [NativeTypeName("const char *")] sbyte* name,
        void* data
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Thread* CreateThreadWithStackSize(
        [NativeTypeName("SDL_ThreadFunction")] delegate* unmanaged<void*, int> fn,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const size_t")] nuint stacksize,
        void* data
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetThreadName(SDL_Thread* thread);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_ThreadID")]
    public static extern ulong GetCurrentThreadID();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_ThreadID")]
    public static extern ulong GetThreadID(SDL_Thread* thread);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetThreadPriority(ThreadPriority priority);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void WaitThread(SDL_Thread* thread, int* status);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DetachThread(SDL_Thread* thread);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_TLSID")]
    public static extern uint CreateTLS();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* GetTLS([NativeTypeName("SDL_TLSID")] uint id);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetTLS(
        [NativeTypeName("SDL_TLSID")] uint id,
        [NativeTypeName("const void *")] void* value,
        [NativeTypeName("void (*)(void *)")] delegate* unmanaged<void*, void> destructor
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void CleanupTLS();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetNumAudioDrivers();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetAudioDriver(int index);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetCurrentAudioDriver();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_AudioDeviceID *")]
    public static extern uint* GetAudioOutputDevices(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_AudioDeviceID *")]
    public static extern uint* GetAudioCaptureDevices(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetAudioDeviceName(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetAudioDeviceFormat(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        AudioSpec* spec,
        int* sample_frames
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_AudioDeviceID")]
    public static extern uint OpenAudioDevice(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* spec
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int PauseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ResumeAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int AudioDevicePaused([NativeTypeName("SDL_AudioDeviceID")] uint dev);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void CloseAudioDevice([NativeTypeName("SDL_AudioDeviceID")] uint devid);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int BindAudioStreams(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        SDL_AudioStream** streams,
        int num_streams
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int BindAudioStream(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        SDL_AudioStream* stream
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UnbindAudioStreams(SDL_AudioStream** streams, int num_streams);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UnbindAudioStream(SDL_AudioStream* stream);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_AudioDeviceID")]
    public static extern uint GetAudioStreamDevice(SDL_AudioStream* stream);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_AudioStream* CreateAudioStream(
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetAudioStreamProperties(SDL_AudioStream* stream);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetAudioStreamFormat(
        SDL_AudioStream* stream,
        AudioSpec* src_spec,
        AudioSpec* dst_spec
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetAudioStreamFormat(
        SDL_AudioStream* stream,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern float GetAudioStreamFrequencyRatio(SDL_AudioStream* stream);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetAudioStreamFrequencyRatio(SDL_AudioStream* stream, float ratio);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int PutAudioStreamData(
        SDL_AudioStream* stream,
        [NativeTypeName("const void *")] void* buf,
        int len
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetAudioStreamData(SDL_AudioStream* stream, void* buf, int len);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetAudioStreamAvailable(SDL_AudioStream* stream);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetAudioStreamQueued(SDL_AudioStream* stream);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int FlushAudioStream(SDL_AudioStream* stream);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ClearAudioStream(SDL_AudioStream* stream);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int LockAudioStream(SDL_AudioStream* stream);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int UnlockAudioStream(SDL_AudioStream* stream);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetAudioStreamGetCallback(
        SDL_AudioStream* stream,
        [NativeTypeName("SDL_AudioStreamCallback")]
            delegate* unmanaged<void*, SDL_AudioStream*, int, int, void> callback,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetAudioStreamPutCallback(
        SDL_AudioStream* stream,
        [NativeTypeName("SDL_AudioStreamCallback")]
            delegate* unmanaged<void*, SDL_AudioStream*, int, int, void> callback,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroyAudioStream(SDL_AudioStream* stream);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_AudioStream* OpenAudioDeviceStream(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* spec,
        [NativeTypeName("SDL_AudioStreamCallback")]
            delegate* unmanaged<void*, SDL_AudioStream*, int, int, void> callback,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetAudioPostmixCallback(
        [NativeTypeName("SDL_AudioDeviceID")] uint devid,
        [NativeTypeName("SDL_AudioPostmixCallback")]
            delegate* unmanaged<void*, AudioSpec*, float*, int, void> callback,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int LoadWAVIO(
        SDL_IOStream* src,
        [NativeTypeName("SDL_bool")] int closeio,
        AudioSpec* spec,
        [NativeTypeName("Uint8 **")] byte** audio_buf,
        [NativeTypeName("Uint32 *")] uint* audio_len
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int LoadWAV(
        [NativeTypeName("const char *")] sbyte* path,
        AudioSpec* spec,
        [NativeTypeName("Uint8 **")] byte** audio_buf,
        [NativeTypeName("Uint32 *")] uint* audio_len
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int MixAudioFormat(
        [NativeTypeName("Uint8 *")] byte* dst,
        [NativeTypeName("const Uint8 *")] byte* src,
        [NativeTypeName("SDL_AudioFormat")] ushort format,
        [NativeTypeName("Uint32")] uint len,
        int volume
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ConvertAudioSamples(
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* src_spec,
        [NativeTypeName("const Uint8 *")] byte* src_data,
        int src_len,
        [NativeTypeName("const SDL_AudioSpec *")] AudioSpec* dst_spec,
        [NativeTypeName("Uint8 **")] byte** dst_data,
        int* dst_len
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetSilenceValueForFormat(
        [NativeTypeName("SDL_AudioFormat")] ushort format
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern BlendMode ComposeCustomBlendMode(
        BlendFactor srcColorFactor,
        BlendFactor dstColorFactor,
        BlendOperation colorOperation,
        BlendFactor srcAlphaFactor,
        BlendFactor dstAlphaFactor,
        BlendOperation alphaOperation
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetPixelFormatName(PixelFormatEnum format);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetMasksForPixelFormatEnum(
        PixelFormatEnum format,
        int* bpp,
        [NativeTypeName("Uint32 *")] uint* Rmask,
        [NativeTypeName("Uint32 *")] uint* Gmask,
        [NativeTypeName("Uint32 *")] uint* Bmask,
        [NativeTypeName("Uint32 *")] uint* Amask
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern PixelFormatEnum GetPixelFormatEnumForMasks(
        int bpp,
        [NativeTypeName("Uint32")] uint Rmask,
        [NativeTypeName("Uint32")] uint Gmask,
        [NativeTypeName("Uint32")] uint Bmask,
        [NativeTypeName("Uint32")] uint Amask
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern PixelFormat* CreatePixelFormat(PixelFormatEnum pixel_format);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroyPixelFormat(PixelFormat* format);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Palette* CreatePalette(int ncolors);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetPixelFormatPalette(PixelFormat* format, Palette* palette);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetPaletteColors(
        Palette* palette,
        [NativeTypeName("const SDL_Color *")] Color* colors,
        int firstcolor,
        int ncolors
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroyPalette(Palette* palette);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint MapRGB(
        [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint MapRgba(
        [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void GetRGB(
        [NativeTypeName("Uint32")] uint pixel,
        [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void GetRgba(
        [NativeTypeName("Uint32")] uint pixel,
        [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b,
        [NativeTypeName("Uint8 *")] byte* a
    );

    [return: NativeTypeName("SDL_bool")]
    public static int PointInRect(
        [NativeTypeName("const SDL_Point *")] Point* p,
        [NativeTypeName("const SDL_Rect *")] Rect* r
    )
    {
        return (
            (p) != null
            && (r) != null
            && (p->X >= r->X)
            && (p->X < (r->X + r->W))
            && (p->Y >= r->Y)
            && (p->Y < (r->Y + r->H))
        )
            ? 1
            : 0;
    }

    [return: NativeTypeName("SDL_bool")]
    public static int RectEmpty([NativeTypeName("const SDL_Rect *")] Rect* r)
    {
        return ((r == null) || (r->W <= 0) || (r->H <= 0)) ? 1 : 0;
    }

    [return: NativeTypeName("SDL_bool")]
    public static int RectsEqual(
        [NativeTypeName("const SDL_Rect *")] Rect* a,
        [NativeTypeName("const SDL_Rect *")] Rect* b
    )
    {
        return (
            (a) != null
            && (b) != null
            && (a->X == b->X)
            && (a->Y == b->Y)
            && (a->W == b->W)
            && (a->H == b->H)
        )
            ? 1
            : 0;
    }

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasRectIntersection(
        [NativeTypeName("const SDL_Rect *")] Rect* A,
        [NativeTypeName("const SDL_Rect *")] Rect* B
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetRectIntersection(
        [NativeTypeName("const SDL_Rect *")] Rect* A,
        [NativeTypeName("const SDL_Rect *")] Rect* B,
        Rect* result
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRectUnion(
        [NativeTypeName("const SDL_Rect *")] Rect* A,
        [NativeTypeName("const SDL_Rect *")] Rect* B,
        Rect* result
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetRectEnclosingPoints(
        [NativeTypeName("const SDL_Point *")] Point* points,
        int count,
        [NativeTypeName("const SDL_Rect *")] Rect* clip,
        Rect* result
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetRectAndLineIntersection(
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        int* X1,
        int* Y1,
        int* X2,
        int* Y2
    );

    [return: NativeTypeName("SDL_bool")]
    public static int PointInRectFloat(
        [NativeTypeName("const SDL_FPoint *")] FPoint* p,
        [NativeTypeName("const SDL_FRect *")] FRect* r
    )
    {
        return (
            (p) != null
            && (r) != null
            && (p->X >= r->X)
            && (p->X < (r->X + r->W))
            && (p->Y >= r->Y)
            && (p->Y < (r->Y + r->H))
        )
            ? 1
            : 0;
    }

    [return: NativeTypeName("SDL_bool")]
    public static int RectEmptyFloat([NativeTypeName("const SDL_FRect *")] FRect* r)
    {
        return ((r == null) || (r->W <= 0.0f) || (r->H <= 0.0f)) ? 1 : 0;
    }

    [return: NativeTypeName("SDL_bool")]
    public static int RectsEqualEpsilon(
        [NativeTypeName("const SDL_FRect *")] FRect* a,
        [NativeTypeName("const SDL_FRect *")] FRect* b,
        [NativeTypeName("const float")] float epsilon
    )
    {
        return (
            (a) != null
            && (b) != null
            && (
                (a == b)
                || (
                    (float.Abs(a->X - b->X) <= epsilon)
                    && (float.Abs(a->Y - b->Y) <= epsilon)
                    && (float.Abs(a->W - b->W) <= epsilon)
                    && (float.Abs(a->H - b->H) <= epsilon)
                )
            )
        )
            ? 1
            : 0;
    }

    [return: NativeTypeName("SDL_bool")]
    public static int RectsEqualFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* a,
        [NativeTypeName("const SDL_FRect *")] FRect* b
    )
    {
        return RectsEqualEpsilon(a, b, 1.1920928955078125e-07F);
    }

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasRectIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* A,
        [NativeTypeName("const SDL_FRect *")] FRect* B
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetRectIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* A,
        [NativeTypeName("const SDL_FRect *")] FRect* B,
        FRect* result
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRectUnionFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* A,
        [NativeTypeName("const SDL_FRect *")] FRect* B,
        FRect* result
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetRectEnclosingPointsFloat(
        [NativeTypeName("const SDL_FPoint *")] FPoint* points,
        int count,
        [NativeTypeName("const SDL_FRect *")] FRect* clip,
        FRect* result
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetRectAndLineIntersectionFloat(
        [NativeTypeName("const SDL_FRect *")] FRect* rect,
        float* X1,
        float* Y1,
        float* X2,
        float* Y2
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Surface* CreateSurface(int width, int height, PixelFormatEnum format);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Surface* CreateSurfaceFrom(
        void* pixels,
        int width,
        int height,
        int pitch,
        PixelFormatEnum format
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroySurface(Surface* surface);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetSurfaceProperties(Surface* surface);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetSurfaceColorspace(Surface* surface, Colorspace colorspace);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetSurfaceColorspace(Surface* surface, Colorspace* colorspace);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetSurfacePalette(Surface* surface, Palette* palette);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int LockSurface(Surface* surface);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UnlockSurface(Surface* surface);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Surface* LoadBMPIO(
        SDL_IOStream* src,
        [NativeTypeName("SDL_bool")] int closeio
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Surface* LoadBMP([NativeTypeName("const char *")] sbyte* file);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SaveBMPIO(
        Surface* surface,
        SDL_IOStream* dst,
        [NativeTypeName("SDL_bool")] int closeio
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SaveBMP(
        Surface* surface,
        [NativeTypeName("const char *")] sbyte* file
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetSurfaceRLE(Surface* surface, int flag);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int SurfaceHasRLE(Surface* surface);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetSurfaceColorKey(
        Surface* surface,
        int flag,
        [NativeTypeName("Uint32")] uint key
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int SurfaceHasColorKey(Surface* surface);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetSurfaceColorKey(
        Surface* surface,
        [NativeTypeName("Uint32 *")] uint* key
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetSurfaceColorMod(
        Surface* surface,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetSurfaceColorMod(
        Surface* surface,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetSurfaceAlphaMod(
        Surface* surface,
        [NativeTypeName("Uint8")] byte alpha
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetSurfaceAlphaMod(
        Surface* surface,
        [NativeTypeName("Uint8 *")] byte* alpha
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetSurfaceBlendMode(Surface* surface, BlendMode blendMode);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetSurfaceBlendMode(Surface* surface, BlendMode* blendMode);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int SetSurfaceClipRect(
        Surface* surface,
        [NativeTypeName("const SDL_Rect *")] Rect* rect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetSurfaceClipRect(Surface* surface, Rect* rect);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int FlipSurface(Surface* surface, FlipMode flip);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Surface* DuplicateSurface(Surface* surface);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Surface* ConvertSurface(
        Surface* surface,
        [NativeTypeName("const SDL_PixelFormat *")] PixelFormat* format
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Surface* ConvertSurfaceFormat(
        Surface* surface,
        PixelFormatEnum pixel_format
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Surface* ConvertSurfaceFormatAndColorspace(
        Surface* surface,
        PixelFormatEnum pixel_format,
        Colorspace colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ConvertPixels(
        int width,
        int height,
        PixelFormatEnum src_format,
        [NativeTypeName("const void *")] void* src,
        int src_pitch,
        PixelFormatEnum dst_format,
        void* dst,
        int dst_pitch
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ConvertPixelsAndColorspace(
        int width,
        int height,
        PixelFormatEnum src_format,
        Colorspace src_colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint src_properties,
        [NativeTypeName("const void *")] void* src,
        int src_pitch,
        PixelFormatEnum dst_format,
        Colorspace dst_colorspace,
        [NativeTypeName("SDL_PropertiesID")] uint dst_properties,
        void* dst,
        int dst_pitch
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int PremultiplyAlpha(
        int width,
        int height,
        PixelFormatEnum src_format,
        [NativeTypeName("const void *")] void* src,
        int src_pitch,
        PixelFormatEnum dst_format,
        void* dst,
        int dst_pitch
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int FillSurfaceRect(
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        [NativeTypeName("Uint32")] uint color
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int FillSurfaceRects(
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* rects,
        int count,
        [NativeTypeName("Uint32")] uint color
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int BlitSurface(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        Rect* dstrect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int BlitSurfaceUnchecked(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SoftStretch(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect,
        ScaleMode scaleMode
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int BlitSurfaceScaled(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        Rect* dstrect,
        ScaleMode scaleMode
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int BlitSurfaceUncheckedScaled(
        Surface* src,
        [NativeTypeName("const SDL_Rect *")] Rect* srcrect,
        Surface* dst,
        [NativeTypeName("const SDL_Rect *")] Rect* dstrect,
        ScaleMode scaleMode
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ReadSurfacePixel(
        Surface* surface,
        int x,
        int y,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b,
        [NativeTypeName("Uint8 *")] byte* a
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetNumVideoDrivers();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetVideoDriver(int index);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetCurrentVideoDriver();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SystemTheme GetSystemTheme();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_DisplayID *")]
    public static extern uint* GetDisplays(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_DisplayID")]
    public static extern uint GetPrimaryDisplay();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetDisplayProperties(
        [NativeTypeName("SDL_DisplayID")] uint displayID
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetDisplayName([NativeTypeName("SDL_DisplayID")] uint displayID);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetDisplayBounds(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        Rect* rect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetDisplayUsableBounds(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        Rect* rect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern DisplayOrientation GetNaturalDisplayOrientation(
        [NativeTypeName("SDL_DisplayID")] uint displayID
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern DisplayOrientation GetCurrentDisplayOrientation(
        [NativeTypeName("SDL_DisplayID")] uint displayID
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern float GetDisplayContentScale(
        [NativeTypeName("SDL_DisplayID")] uint displayID
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_DisplayMode **")]
    public static extern DisplayMode** GetFullscreenDisplayModes(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        int* count
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_DisplayMode *")]
    public static extern DisplayMode* GetClosestFullscreenDisplayMode(
        [NativeTypeName("SDL_DisplayID")] uint displayID,
        int w,
        int h,
        float refresh_rate,
        [NativeTypeName("SDL_bool")] int include_high_density_modes
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_DisplayMode *")]
    public static extern DisplayMode* GetDesktopDisplayMode(
        [NativeTypeName("SDL_DisplayID")] uint displayID
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_DisplayMode *")]
    public static extern DisplayMode* GetCurrentDisplayMode(
        [NativeTypeName("SDL_DisplayID")] uint displayID
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_DisplayID")]
    public static extern uint GetDisplayForPoint(
        [NativeTypeName("const SDL_Point *")] Point* point
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_DisplayID")]
    public static extern uint GetDisplayForRect([NativeTypeName("const SDL_Rect *")] Rect* rect);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_DisplayID")]
    public static extern uint GetDisplayForWindow(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern float GetWindowPixelDensity(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern float GetWindowDisplayScale(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowFullscreenMode(
        SDL_Window* window,
        [NativeTypeName("const SDL_DisplayMode *")] DisplayMode* mode
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_DisplayMode *")]
    public static extern DisplayMode* GetWindowFullscreenMode(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* GetWindowICCProfile(
        SDL_Window* window,
        [NativeTypeName("size_t *")] nuint* size
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint GetWindowPixelFormat(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Window* CreateWindow(
        [NativeTypeName("const char *")] sbyte* title,
        int w,
        int h,
        [NativeTypeName("SDL_WindowFlags")] uint flags
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Window* CreatePopupWindow(
        SDL_Window* parent,
        int offset_x,
        int offset_y,
        int w,
        int h,
        [NativeTypeName("SDL_WindowFlags")] uint flags
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Window* CreateWindowWithProperties(
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_WindowID")]
    public static extern uint GetWindowID(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Window* GetWindowFromID([NativeTypeName("SDL_WindowID")] uint id);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Window* GetWindowParent(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetWindowProperties(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_WindowFlags")]
    public static extern uint GetWindowFlags(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowTitle(
        SDL_Window* window,
        [NativeTypeName("const char *")] sbyte* title
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetWindowTitle(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowIcon(SDL_Window* window, Surface* icon);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowPosition(SDL_Window* window, int x, int y);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetWindowPosition(SDL_Window* window, int* x, int* y);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowSize(SDL_Window* window, int w, int h);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetWindowSize(SDL_Window* window, int* w, int* h);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetWindowBordersSize(
        SDL_Window* window,
        int* top,
        int* left,
        int* bottom,
        int* right
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetWindowSizeInPixels(SDL_Window* window, int* w, int* h);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowMinimumSize(SDL_Window* window, int min_w, int min_h);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetWindowMinimumSize(SDL_Window* window, int* w, int* h);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowMaximumSize(SDL_Window* window, int max_w, int max_h);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetWindowMaximumSize(SDL_Window* window, int* w, int* h);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowBordered(
        SDL_Window* window,
        [NativeTypeName("SDL_bool")] int bordered
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowResizable(
        SDL_Window* window,
        [NativeTypeName("SDL_bool")] int resizable
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowAlwaysOnTop(
        SDL_Window* window,
        [NativeTypeName("SDL_bool")] int on_top
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ShowWindow(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HideWindow(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RaiseWindow(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int MaximizeWindow(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int MinimizeWindow(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RestoreWindow(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowFullscreen(
        SDL_Window* window,
        [NativeTypeName("SDL_bool")] int fullscreen
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SyncWindow(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WindowHasSurface(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Surface* GetWindowSurface(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int UpdateWindowSurface(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int UpdateWindowSurfaceRects(
        SDL_Window* window,
        [NativeTypeName("const SDL_Rect *")] Rect* rects,
        int numrects
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int DestroyWindowSurface(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowKeyboardGrab(
        SDL_Window* window,
        [NativeTypeName("SDL_bool")] int grabbed
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowMouseGrab(
        SDL_Window* window,
        [NativeTypeName("SDL_bool")] int grabbed
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetWindowKeyboardGrab(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetWindowMouseGrab(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Window* GetGrabbedWindow();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowMouseRect(
        SDL_Window* window,
        [NativeTypeName("const SDL_Rect *")] Rect* rect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const SDL_Rect *")]
    public static extern Rect* GetWindowMouseRect(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowOpacity(SDL_Window* window, float opacity);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetWindowOpacity(SDL_Window* window, float* out_opacity);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowModalFor(SDL_Window* modal_window, SDL_Window* parent_window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowInputFocus(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowFocusable(
        SDL_Window* window,
        [NativeTypeName("SDL_bool")] int focusable
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ShowWindowSystemMenu(SDL_Window* window, int x, int y);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowHitTest(
        SDL_Window* window,
        [NativeTypeName("SDL_HitTest")]
            delegate* unmanaged<SDL_Window*, Point*, void*, HitTestResult> callback,
        void* callback_data
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetWindowShape(SDL_Window* window, Surface* shape);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int FlashWindow(SDL_Window* window, FlashOperation operation);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroyWindow(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ScreenSaverEnabled();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int EnableScreenSaver();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int DisableScreenSaver();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GLLoadLibrary([NativeTypeName("const char *")] sbyte* path);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_FunctionPointer")]
    public static extern delegate* unmanaged<void> GLGetProcAddress(
        [NativeTypeName("const char *")] sbyte* proc
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_FunctionPointer")]
    public static extern delegate* unmanaged<void> EGLGetProcAddress(
        [NativeTypeName("const char *")] sbyte* proc
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void GLUnloadLibrary();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GLExtensionSupported(
        [NativeTypeName("const char *")] sbyte* extension
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void GLResetAttributes();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GLSetAttribute(GLattr attr, int value);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GLGetAttribute(GLattr attr, int* value);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_GLContext")]
    public static extern void* GLCreateContext(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GLMakeCurrent(
        SDL_Window* window,
        [NativeTypeName("SDL_GLContext")] void* context
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Window* GLGetCurrentWindow();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_GLContext")]
    public static extern void* GLGetCurrentContext();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_EGLDisplay")]
    public static extern void* EGLGetCurrentEGLDisplay();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_EGLConfig")]
    public static extern void* EGLGetCurrentEGLConfig();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_EGLSurface")]
    public static extern void* EGLGetWindowEGLSurface(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void EGLSetEGLAttributeCallbacks(
        [NativeTypeName("SDL_EGLAttribArrayCallback")]
            delegate* unmanaged<nint*> platformAttribCallback,
        [NativeTypeName("SDL_EGLIntArrayCallback")] delegate* unmanaged<int*> surfaceAttribCallback,
        [NativeTypeName("SDL_EGLIntArrayCallback")] delegate* unmanaged<int*> contextAttribCallback
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GLSetSwapInterval(int interval);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GLGetSwapInterval(int* interval);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GLSwapWindow(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GLDeleteContext([NativeTypeName("SDL_GLContext")] void* context);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetNumCameraDrivers();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetCameraDriver(int index);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetCurrentCameraDriver();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_CameraDeviceID *")]
    public static extern uint* GetCameraDevices(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern CameraSpec* GetCameraDeviceSupportedFormats(
        [NativeTypeName("SDL_CameraDeviceID")] uint devid,
        int* count
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetCameraDeviceName(
        [NativeTypeName("SDL_CameraDeviceID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern CameraPosition GetCameraDevicePosition(
        [NativeTypeName("SDL_CameraDeviceID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Camera* OpenCameraDevice(
        [NativeTypeName("SDL_CameraDeviceID")] uint instance_id,
        [NativeTypeName("const SDL_CameraSpec *")] CameraSpec* spec
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetCameraPermissionState(SDL_Camera* camera);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_CameraDeviceID")]
    public static extern uint GetCameraInstanceID(SDL_Camera* camera);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetCameraProperties(SDL_Camera* camera);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetCameraFormat(SDL_Camera* camera, CameraSpec* spec);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Surface* AcquireCameraFrame(
        SDL_Camera* camera,
        [NativeTypeName("Uint64 *")] ulong* timestampNS
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ReleaseCameraFrame(SDL_Camera* camera, Surface* frame);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void CloseCamera(SDL_Camera* camera);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetClipboardText([NativeTypeName("const char *")] sbyte* text);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetClipboardText();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasClipboardText();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetPrimarySelectionText([NativeTypeName("const char *")] sbyte* text);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetPrimarySelectionText();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasPrimarySelectionText();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetClipboardData(
        [NativeTypeName("SDL_ClipboardDataCallback")]
            delegate* unmanaged<void*, sbyte*, nuint*, void*> callback,
        [NativeTypeName("SDL_ClipboardCleanupCallback")] delegate* unmanaged<void*, void> cleanup,
        void* userdata,
        [NativeTypeName("const char **")] sbyte** mime_types,
        [NativeTypeName("size_t")] nuint num_mime_types
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ClearClipboardData();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* GetClipboardData(
        [NativeTypeName("const char *")] sbyte* mime_type,
        [NativeTypeName("size_t *")] nuint* size
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasClipboardData([NativeTypeName("const char *")] sbyte* mime_type);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetCPUCount();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetCPUCacheLineSize();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasAltiVec();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasMMX();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasSSE();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasSSE2();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasSSE3();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasSSE41();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasSSE42();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasAVX();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasAVX2();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasAVX512F();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasArmsimd();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasNeon();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasLSX();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasLasx();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetSystemRAM();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    public static extern nuint SimdGetAlignment();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void ShowOpenFileDialog(
        [NativeTypeName("SDL_DialogFileCallback")]
            delegate* unmanaged<void*, sbyte**, int, void> callback,
        void* userdata,
        SDL_Window* window,
        [NativeTypeName("const SDL_DialogFileFilter *")] DialogFileFilter* filters,
        [NativeTypeName("const char *")] sbyte* default_location,
        [NativeTypeName("SDL_bool")] int allow_many
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void ShowSaveFileDialog(
        [NativeTypeName("SDL_DialogFileCallback")]
            delegate* unmanaged<void*, sbyte**, int, void> callback,
        void* userdata,
        SDL_Window* window,
        [NativeTypeName("const SDL_DialogFileFilter *")] DialogFileFilter* filters,
        [NativeTypeName("const char *")] sbyte* default_location
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void ShowOpenFolderDialog(
        [NativeTypeName("SDL_DialogFileCallback")]
            delegate* unmanaged<void*, sbyte**, int, void> callback,
        void* userdata,
        SDL_Window* window,
        [NativeTypeName("const char *")] sbyte* default_location,
        [NativeTypeName("SDL_bool")] int allow_many
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GuidToString(
        Guid guid,
        [NativeTypeName("char *")] sbyte* pszGUID,
        int cbGUID
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Guid GuidFromString([NativeTypeName("const char *")] sbyte* pchGUID);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern PowerState GetPowerInfo(int* seconds, int* percent);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void LockJoysticks();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UnlockJoysticks();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasJoystick();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickID *")]
    public static extern uint* GetJoysticks(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetJoystickInstanceName(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetJoystickInstancePath(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetJoystickInstancePlayerIndex(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickGUID")]
    public static extern Guid GetJoystickInstanceGuid(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickInstanceVendor(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickInstanceProduct(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickInstanceProductVersion(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern JoystickType GetJoystickInstanceType(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Joystick* OpenJoystick(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Joystick* GetJoystickFromInstanceID(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Joystick* GetJoystickFromPlayerIndex(int player_index);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickID")]
    public static extern uint AttachVirtualJoystick(
        JoystickType type,
        int naxes,
        int nbuttons,
        int nhats
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickID")]
    public static extern uint AttachVirtualJoystickEx(
        [NativeTypeName("const SDL_VirtualJoystickDesc *")] VirtualJoystickDesc* desc
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int DetachVirtualJoystick(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int IsJoystickVirtual([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetJoystickVirtualAxis(
        SDL_Joystick* joystick,
        int axis,
        [NativeTypeName("Sint16")] short value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetJoystickVirtualButton(
        SDL_Joystick* joystick,
        int button,
        [NativeTypeName("Uint8")] byte value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetJoystickVirtualHat(
        SDL_Joystick* joystick,
        int hat,
        [NativeTypeName("Uint8")] byte value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetJoystickProperties(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetJoystickName(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetJoystickPath(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetJoystickPlayerIndex(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetJoystickPlayerIndex(SDL_Joystick* joystick, int player_index);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickGUID")]
    public static extern Guid GetJoystickGuid(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickVendor(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickProduct(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickProductVersion(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetJoystickFirmwareVersion(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetJoystickSerial(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern JoystickType GetJoystickType(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetJoystickGuidString(
        [NativeTypeName("SDL_JoystickGUID")] Guid guid,
        [NativeTypeName("char *")] sbyte* pszGUID,
        int cbGUID
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickGUID")]
    public static extern Guid GetJoystickGuidFromString(
        [NativeTypeName("const char *")] sbyte* pchGUID
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void GetJoystickGuidInfo(
        [NativeTypeName("SDL_JoystickGUID")] Guid guid,
        [NativeTypeName("Uint16 *")] ushort* vendor,
        [NativeTypeName("Uint16 *")] ushort* product,
        [NativeTypeName("Uint16 *")] ushort* version,
        [NativeTypeName("Uint16 *")] ushort* crc16
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int JoystickConnected(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickID")]
    public static extern uint GetJoystickInstanceID(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetNumJoystickAxes(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetNumJoystickBalls(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetNumJoystickHats(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetNumJoystickButtons(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void SetJoystickEventsEnabled([NativeTypeName("SDL_bool")] int enabled);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int JoystickEventsEnabled();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UpdateJoysticks();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Sint16")]
    public static extern short GetJoystickAxis(SDL_Joystick* joystick, int axis);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetJoystickAxisInitialState(
        SDL_Joystick* joystick,
        int axis,
        [NativeTypeName("Sint16 *")] short* state
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetJoystickBall(SDL_Joystick* joystick, int ball, int* dx, int* dy);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint8")]
    public static extern byte GetJoystickHat(SDL_Joystick* joystick, int hat);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint8")]
    public static extern byte GetJoystickButton(SDL_Joystick* joystick, int button);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RumbleJoystick(
        SDL_Joystick* joystick,
        [NativeTypeName("Uint16")] ushort low_frequency_rumble,
        [NativeTypeName("Uint16")] ushort high_frequency_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RumbleJoystickTriggers(
        SDL_Joystick* joystick,
        [NativeTypeName("Uint16")] ushort left_rumble,
        [NativeTypeName("Uint16")] ushort right_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetJoystickLED(
        SDL_Joystick* joystick,
        [NativeTypeName("Uint8")] byte red,
        [NativeTypeName("Uint8")] byte green,
        [NativeTypeName("Uint8")] byte blue
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SendJoystickEffect(
        SDL_Joystick* joystick,
        [NativeTypeName("const void *")] void* data,
        int size
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void CloseJoystick(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern JoystickConnectionState GetJoystickConnectionState(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern PowerState GetJoystickPowerInfo(SDL_Joystick* joystick, int* percent);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_SensorID *")]
    public static extern uint* GetSensors(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetSensorInstanceName(
        [NativeTypeName("SDL_SensorID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SensorType GetSensorInstanceType(
        [NativeTypeName("SDL_SensorID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetSensorInstanceNonPortableType(
        [NativeTypeName("SDL_SensorID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Sensor* OpenSensor([NativeTypeName("SDL_SensorID")] uint instance_id);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Sensor* GetSensorFromInstanceID(
        [NativeTypeName("SDL_SensorID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetSensorProperties(SDL_Sensor* sensor);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetSensorName(SDL_Sensor* sensor);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SensorType GetSensorType(SDL_Sensor* sensor);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetSensorNonPortableType(SDL_Sensor* sensor);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_SensorID")]
    public static extern uint GetSensorInstanceID(SDL_Sensor* sensor);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetSensorData(SDL_Sensor* sensor, float* data, int num_values);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void CloseSensor(SDL_Sensor* sensor);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UpdateSensors();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int AddGamepadMapping([NativeTypeName("const char *")] sbyte* mapping);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int AddGamepadMappingsFromIO(
        SDL_IOStream* src,
        [NativeTypeName("SDL_bool")] int closeio
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int AddGamepadMappingsFromFile(
        [NativeTypeName("const char *")] sbyte* file
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ReloadGamepadMappings();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern sbyte** GetGamepadMappings(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetGamepadMappingForGuid(
        [NativeTypeName("SDL_JoystickGUID")] Guid guid
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetGamepadMapping(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetGamepadMapping(
        [NativeTypeName("SDL_JoystickID")] uint instance_id,
        [NativeTypeName("const char *")] sbyte* mapping
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasGamepad();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickID *")]
    public static extern uint* GetGamepads(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int IsGamepad([NativeTypeName("SDL_JoystickID")] uint instance_id);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetGamepadInstanceName(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetGamepadInstancePath(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetGamepadInstancePlayerIndex(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickGUID")]
    public static extern Guid GetGamepadInstanceGuid(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadInstanceVendor(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadInstanceProduct(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadInstanceProductVersion(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern GamepadType GetGamepadInstanceType(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern GamepadType GetRealGamepadInstanceType(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetGamepadInstanceMapping(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Gamepad* OpenGamepad(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Gamepad* GetGamepadFromInstanceID(
        [NativeTypeName("SDL_JoystickID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Gamepad* GetGamepadFromPlayerIndex(int player_index);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetGamepadProperties(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_JoystickID")]
    public static extern uint GetGamepadInstanceID(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetGamepadName(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetGamepadPath(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern GamepadType GetGamepadType(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern GamepadType GetRealGamepadType(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetGamepadPlayerIndex(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetGamepadPlayerIndex(SDL_Gamepad* gamepad, int player_index);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadVendor(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadProduct(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadProductVersion(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint16")]
    public static extern ushort GetGamepadFirmwareVersion(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetGamepadSerial(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint64")]
    public static extern ulong GetGamepadSteamHandle(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern JoystickConnectionState GetGamepadConnectionState(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern PowerState GetGamepadPowerInfo(SDL_Gamepad* gamepad, int* percent);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GamepadConnected(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Joystick* GetGamepadJoystick(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void SetGamepadEventsEnabled([NativeTypeName("SDL_bool")] int enabled);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GamepadEventsEnabled();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern GamepadBinding** GetGamepadBindings(SDL_Gamepad* gamepad, int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UpdateGamepads();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern GamepadType GetGamepadTypeFromString(
        [NativeTypeName("const char *")] sbyte* str
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetGamepadStringForType(GamepadType type);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern GamepadAxis GetGamepadAxisFromString(
        [NativeTypeName("const char *")] sbyte* str
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetGamepadStringForAxis(GamepadAxis axis);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GamepadHasAxis(SDL_Gamepad* gamepad, GamepadAxis axis);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Sint16")]
    public static extern short GetGamepadAxis(SDL_Gamepad* gamepad, GamepadAxis axis);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern GamepadButton GetGamepadButtonFromString(
        [NativeTypeName("const char *")] sbyte* str
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetGamepadStringForButton(GamepadButton button);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GamepadHasButton(SDL_Gamepad* gamepad, GamepadButton button);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint8")]
    public static extern byte GetGamepadButton(SDL_Gamepad* gamepad, GamepadButton button);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern GamepadButtonLabel GetGamepadButtonLabelForType(
        GamepadType type,
        GamepadButton button
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern GamepadButtonLabel GetGamepadButtonLabel(
        SDL_Gamepad* gamepad,
        GamepadButton button
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetNumGamepadTouchpads(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetNumGamepadTouchpadFingers(SDL_Gamepad* gamepad, int touchpad);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetGamepadTouchpadFinger(
        SDL_Gamepad* gamepad,
        int touchpad,
        int finger,
        [NativeTypeName("Uint8 *")] byte* state,
        float* x,
        float* y,
        float* pressure
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GamepadHasSensor(SDL_Gamepad* gamepad, SensorType type);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetGamepadSensorEnabled(
        SDL_Gamepad* gamepad,
        SensorType type,
        [NativeTypeName("SDL_bool")] int enabled
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GamepadSensorEnabled(SDL_Gamepad* gamepad, SensorType type);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern float GetGamepadSensorDataRate(SDL_Gamepad* gamepad, SensorType type);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetGamepadSensorData(
        SDL_Gamepad* gamepad,
        SensorType type,
        float* data,
        int num_values
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RumbleGamepad(
        SDL_Gamepad* gamepad,
        [NativeTypeName("Uint16")] ushort low_frequency_rumble,
        [NativeTypeName("Uint16")] ushort high_frequency_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RumbleGamepadTriggers(
        SDL_Gamepad* gamepad,
        [NativeTypeName("Uint16")] ushort left_rumble,
        [NativeTypeName("Uint16")] ushort right_rumble,
        [NativeTypeName("Uint32")] uint duration_ms
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetGamepadLED(
        SDL_Gamepad* gamepad,
        [NativeTypeName("Uint8")] byte red,
        [NativeTypeName("Uint8")] byte green,
        [NativeTypeName("Uint8")] byte blue
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SendGamepadEffect(
        SDL_Gamepad* gamepad,
        [NativeTypeName("const void *")] void* data,
        int size
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void CloseGamepad(SDL_Gamepad* gamepad);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetGamepadAppleSFSymbolsNameForButton(
        SDL_Gamepad* gamepad,
        GamepadButton button
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetGamepadAppleSFSymbolsNameForAxis(
        SDL_Gamepad* gamepad,
        GamepadAxis axis
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasKeyboard();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_KeyboardID *")]
    public static extern uint* GetKeyboards(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetKeyboardInstanceName(
        [NativeTypeName("SDL_KeyboardID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Window* GetKeyboardFocus();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const Uint8 *")]
    public static extern byte* GetKeyboardState(int* numkeys);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void ResetKeyboard();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Keymod GetModState();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void SetModState(Keymod modstate);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_Keycode")]
    public static extern int GetKeyFromScancode(Scancode scancode);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Scancode GetScancodeFromKey([NativeTypeName("SDL_Keycode")] int key);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetScancodeName(Scancode scancode);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Scancode GetScancodeFromName([NativeTypeName("const char *")] sbyte* name);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetKeyName([NativeTypeName("SDL_Keycode")] int key);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_Keycode")]
    public static extern int GetKeyFromName([NativeTypeName("const char *")] sbyte* name);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void StartTextInput();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int TextInputActive();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void StopTextInput();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void ClearComposition();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetTextInputRect([NativeTypeName("const SDL_Rect *")] Rect* rect);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasScreenKeyboardSupport();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ScreenKeyboardShown(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasMouse();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_MouseID *")]
    public static extern uint* GetMice(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetMouseInstanceName(
        [NativeTypeName("SDL_MouseID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Window* GetMouseFocus();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint GetMouseState(float* x, float* y);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint GetGlobalMouseState(float* x, float* y);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint GetRelativeMouseState(float* x, float* y);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void WarpMouseInWindow(SDL_Window* window, float x, float y);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int WarpMouseGlobal(float x, float y);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetRelativeMouseMode([NativeTypeName("SDL_bool")] int enabled);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int CaptureMouse([NativeTypeName("SDL_bool")] int enabled);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetRelativeMouseMode();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Cursor* CreateCursor(
        [NativeTypeName("const Uint8 *")] byte* data,
        [NativeTypeName("const Uint8 *")] byte* mask,
        int w,
        int h,
        int hot_x,
        int hot_y
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Cursor* CreateColorCursor(Surface* surface, int hot_x, int hot_y);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Cursor* CreateSystemCursor(SystemCursor id);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetCursor(SDL_Cursor* cursor);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Cursor* GetCursor();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Cursor* GetDefaultCursor();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroyCursor(SDL_Cursor* cursor);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ShowCursor();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HideCursor();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int CursorVisible();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PenID *")]
    public static extern uint* GetPens(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint GetPenStatus(
        [NativeTypeName("SDL_PenID")] uint instance_id,
        float* x,
        float* y,
        float* axes,
        [NativeTypeName("size_t")] nuint num_axes
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PenID")]
    public static extern uint GetPenFromGuid(Guid guid);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Guid GetPenGuid([NativeTypeName("SDL_PenID")] uint instance_id);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int PenConnected([NativeTypeName("SDL_PenID")] uint instance_id);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetPenName([NativeTypeName("SDL_PenID")] uint instance_id);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint GetPenCapabilities(
        [NativeTypeName("SDL_PenID")] uint instance_id,
        PenCapabilityInfo* capabilities
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern PenSubtype GetPenType([NativeTypeName("SDL_PenID")] uint instance_id);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_TouchID *")]
    public static extern ulong* GetTouchDevices(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetTouchDeviceName([NativeTypeName("SDL_TouchID")] ulong touchID);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern TouchDeviceType GetTouchDeviceType(
        [NativeTypeName("SDL_TouchID")] ulong touchID
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Finger** GetTouchFingers(
        [NativeTypeName("SDL_TouchID")] ulong touchID,
        int* count
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void PumpEvents();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int PeepEvents(
        Event* events,
        int numevents,
        EventAction action,
        [NativeTypeName("Uint32")] uint minType,
        [NativeTypeName("Uint32")] uint maxType
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasEvent([NativeTypeName("Uint32")] uint type);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HasEvents(
        [NativeTypeName("Uint32")] uint minType,
        [NativeTypeName("Uint32")] uint maxType
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void FlushEvent([NativeTypeName("Uint32")] uint type);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void FlushEvents(
        [NativeTypeName("Uint32")] uint minType,
        [NativeTypeName("Uint32")] uint maxType
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int PollEvent(Event* @event);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WaitEvent(Event* @event);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int WaitEventTimeout(
        Event* @event,
        [NativeTypeName("Sint32")] int timeoutMS
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int PushEvent(Event* @event);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void SetEventFilter(
        [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetEventFilter(
        [NativeTypeName("SDL_EventFilter *")] delegate* unmanaged<void*, Event*, int>* filter,
        void** userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int AddEventWatch(
        [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DelEventWatch(
        [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void FilterEvents(
        [NativeTypeName("SDL_EventFilter")] delegate* unmanaged<void*, Event*, int> filter,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void SetEventEnabled(
        [NativeTypeName("Uint32")] uint type,
        [NativeTypeName("SDL_bool")] int enabled
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int EventEnabled([NativeTypeName("Uint32")] uint type);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint RegisterEvents(int numevents);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* AllocateEventMemory([NativeTypeName("size_t")] nuint size);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetBasePath();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetPrefPath(
        [NativeTypeName("const char *")] sbyte* org,
        [NativeTypeName("const char *")] sbyte* app
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char *")]
    public static extern sbyte* GetUserFolder(Folder folder);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int CreateDirectory([NativeTypeName("const char *")] sbyte* path);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int EnumerateDirectory(
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("SDL_EnumerateDirectoryCallback")]
            delegate* unmanaged<void*, sbyte*, sbyte*, int> callback,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RemovePath([NativeTypeName("const char *")] sbyte* path);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenamePath(
        [NativeTypeName("const char *")] sbyte* oldpath,
        [NativeTypeName("const char *")] sbyte* newpath
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetPathInfo(
        [NativeTypeName("const char *")] sbyte* path,
        PathInfo* info
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern sbyte** GlobDirectory(
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("const char *")] sbyte* pattern,
        [NativeTypeName("Uint32")] uint flags,
        int* count
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_HapticID *")]
    public static extern uint* GetHaptics(int* count);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetHapticInstanceName(
        [NativeTypeName("SDL_HapticID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Haptic* OpenHaptic([NativeTypeName("SDL_HapticID")] uint instance_id);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Haptic* GetHapticFromInstanceID(
        [NativeTypeName("SDL_HapticID")] uint instance_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_HapticID")]
    public static extern uint GetHapticInstanceID(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetHapticName(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int IsMouseHaptic();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Haptic* OpenHapticFromMouse();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int IsJoystickHaptic(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Haptic* OpenHapticFromJoystick(SDL_Joystick* joystick);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void CloseHaptic(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetMaxHapticEffects(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetMaxHapticEffectsPlaying(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint GetHapticFeatures(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetNumHapticAxes(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HapticEffectSupported(
        SDL_Haptic* haptic,
        [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* effect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int CreateHapticEffect(
        SDL_Haptic* haptic,
        [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* effect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int UpdateHapticEffect(
        SDL_Haptic* haptic,
        int effect,
        [NativeTypeName("const SDL_HapticEffect *")] HapticEffect* data
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RunHapticEffect(
        SDL_Haptic* haptic,
        int effect,
        [NativeTypeName("Uint32")] uint iterations
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int StopHapticEffect(SDL_Haptic* haptic, int effect);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroyHapticEffect(SDL_Haptic* haptic, int effect);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetHapticEffectStatus(SDL_Haptic* haptic, int effect);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetHapticGain(SDL_Haptic* haptic, int gain);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetHapticAutocenter(SDL_Haptic* haptic, int autocenter);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int PauseHaptic(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ResumeHaptic(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int StopHapticEffects(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int HapticRumbleSupported(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int InitHapticRumble(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int PlayHapticRumble(
        SDL_Haptic* haptic,
        float strength,
        [NativeTypeName("Uint32")] uint length
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int StopHapticRumble(SDL_Haptic* haptic);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidInit();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidExit();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint HidDeviceChangeCount();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern HidDeviceInfo* HidEnumerate(
        [NativeTypeName("unsigned short")] ushort vendor_id,
        [NativeTypeName("unsigned short")] ushort product_id
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void HidFreeEnumeration(HidDeviceInfo* devs);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_hid_device* HidOpen(
        [NativeTypeName("unsigned short")] ushort vendor_id,
        [NativeTypeName("unsigned short")] ushort product_id,
        [NativeTypeName("const wchar_t *")] uint* serial_number
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_hid_device* HidOpenPath([NativeTypeName("const char *")] sbyte* path);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidWrite(
        SDL_hid_device* dev,
        [NativeTypeName("const unsigned char *")] byte* data,
        [NativeTypeName("size_t")] nuint length
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidReadTimeout(
        SDL_hid_device* dev,
        [NativeTypeName("unsigned char *")] byte* data,
        [NativeTypeName("size_t")] nuint length,
        int milliseconds
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidRead(
        SDL_hid_device* dev,
        [NativeTypeName("unsigned char *")] byte* data,
        [NativeTypeName("size_t")] nuint length
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidSetNonblocking(SDL_hid_device* dev, int nonblock);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidSendFeatureReport(
        SDL_hid_device* dev,
        [NativeTypeName("const unsigned char *")] byte* data,
        [NativeTypeName("size_t")] nuint length
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidGetFeatureReport(
        SDL_hid_device* dev,
        [NativeTypeName("unsigned char *")] byte* data,
        [NativeTypeName("size_t")] nuint length
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidGetInputReport(
        SDL_hid_device* dev,
        [NativeTypeName("unsigned char *")] byte* data,
        [NativeTypeName("size_t")] nuint length
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidClose(SDL_hid_device* dev);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidGetManufacturerString(
        SDL_hid_device* dev,
        [NativeTypeName("wchar_t *")] uint* @string,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidGetProductString(
        SDL_hid_device* dev,
        [NativeTypeName("wchar_t *")] uint* @string,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidGetSerialNumberString(
        SDL_hid_device* dev,
        [NativeTypeName("wchar_t *")] uint* @string,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidGetIndexedString(
        SDL_hid_device* dev,
        int string_index,
        [NativeTypeName("wchar_t *")] uint* @string,
        [NativeTypeName("size_t")] nuint maxlen
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern HidDeviceInfo* HidGetDeviceInfo(SDL_hid_device* dev);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int HidGetReportDescriptor(
        SDL_hid_device* dev,
        [NativeTypeName("unsigned char *")] byte* buf,
        [NativeTypeName("size_t")] nuint buf_size
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void HidBleScan([NativeTypeName("SDL_bool")] int active);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int SetHintWithPriority(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* value,
        HintPriority priority
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int SetHint(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("const char *")] sbyte* value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int ResetHint([NativeTypeName("const char *")] sbyte* name);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void ResetHints();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetHint([NativeTypeName("const char *")] sbyte* name);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int GetHintBoolean(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("SDL_bool")] int default_value
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int AddHintCallback(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("SDL_HintCallback")]
            delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> callback,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DelHintCallback(
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("SDL_HintCallback")]
            delegate* unmanaged<void*, sbyte*, sbyte*, sbyte*, void> callback,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int Init([NativeTypeName("Uint32")] uint flags);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int InitSubSystem([NativeTypeName("Uint32")] uint flags);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void QuitSubSystem([NativeTypeName("Uint32")] uint flags);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint32")]
    public static extern uint WasInit([NativeTypeName("Uint32")] uint flags);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void Quit();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* LoadObject([NativeTypeName("const char *")] sbyte* sofile);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_FunctionPointer")]
    public static extern delegate* unmanaged<void> LoadFunction(
        void* handle,
        [NativeTypeName("const char *")] sbyte* name
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UnloadObject(void* handle);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Locale* GetPreferredLocales();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void LogSetAllPriority(LogPriority priority);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void LogSetPriority(int category, LogPriority priority);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern LogPriority LogGetPriority(int category);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void LogResetPriorities();

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void Log([NativeTypeName("const char *")] sbyte* fmt, __arglist);

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void LogVerbose(
        int category,
        [NativeTypeName("const char *")] sbyte* fmt,
        __arglist
    );

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void LogDebug(
        int category,
        [NativeTypeName("const char *")] sbyte* fmt,
        __arglist
    );

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void LogInfo(
        int category,
        [NativeTypeName("const char *")] sbyte* fmt,
        __arglist
    );

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void LogWarn(
        int category,
        [NativeTypeName("const char *")] sbyte* fmt,
        __arglist
    );

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void LogError(
        int category,
        [NativeTypeName("const char *")] sbyte* fmt,
        __arglist
    );

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void LogCritical(
        int category,
        [NativeTypeName("const char *")] sbyte* fmt,
        __arglist
    );

    [DllImport("SDL3", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void LogMessage(
        int category,
        LogPriority priority,
        [NativeTypeName("const char *")] sbyte* fmt,
        __arglist
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void LogMessageV(
        int category,
        LogPriority priority,
        [NativeTypeName("const char *")] sbyte* fmt,
        [NativeTypeName("va_list")] sbyte* ap
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void GetLogOutputFunction(
        [NativeTypeName("SDL_LogOutputFunction *")]
            delegate* unmanaged<void*, int, LogPriority, sbyte*, void>* callback,
        void** userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void SetLogOutputFunction(
        [NativeTypeName("SDL_LogOutputFunction")]
            delegate* unmanaged<void*, int, LogPriority, sbyte*, void> callback,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ShowMessageBox(
        [NativeTypeName("const SDL_MessageBoxData *")] MessageBoxData* messageboxdata,
        int* buttonid
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ShowSimpleMessageBox(
        [NativeTypeName("Uint32")] uint flags,
        [NativeTypeName("const char *")] sbyte* title,
        [NativeTypeName("const char *")] sbyte* message,
        SDL_Window* window
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_MetalView")]
    public static extern void* MetalCreateView(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void MetalDestroyView([NativeTypeName("SDL_MetalView")] void* view);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* MetalGetLayer([NativeTypeName("SDL_MetalView")] void* view);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int OpenURL([NativeTypeName("const char *")] sbyte* url);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetPlatform();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetNumRenderDrivers();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetRenderDriver(int index);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int CreateWindowAndRenderer(
        [NativeTypeName("const char *")] sbyte* title,
        int width,
        int height,
        [NativeTypeName("SDL_WindowFlags")] uint window_flags,
        SDL_Window** window,
        SDL_Renderer** renderer
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Renderer* CreateRenderer(
        SDL_Window* window,
        [NativeTypeName("const char *")] sbyte* name,
        [NativeTypeName("Uint32")] uint flags
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Renderer* CreateRendererWithProperties(
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Renderer* CreateSoftwareRenderer(Surface* surface);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Renderer* GetRenderer(SDL_Window* window);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Window* GetRenderWindow(SDL_Renderer* renderer);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRendererInfo(SDL_Renderer* renderer, RendererInfo* info);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetRendererProperties(SDL_Renderer* renderer);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetCurrentRenderOutputSize(SDL_Renderer* renderer, int* w, int* h);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Texture* CreateTexture(
        SDL_Renderer* renderer,
        PixelFormatEnum format,
        int access,
        int w,
        int h
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Texture* CreateTextureFromSurface(
        SDL_Renderer* renderer,
        Surface* surface
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Texture* CreateTextureWithProperties(
        SDL_Renderer* renderer,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_PropertiesID")]
    public static extern uint GetTextureProperties(SDL_Texture* texture);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Renderer* GetRendererFromTexture(SDL_Texture* texture);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int QueryTexture(
        SDL_Texture* texture,
        PixelFormatEnum* format,
        int* access,
        int* w,
        int* h
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetTextureColorMod(
        SDL_Texture* texture,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetTextureColorModFloat(
        SDL_Texture* texture,
        float r,
        float g,
        float b
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetTextureColorMod(
        SDL_Texture* texture,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetTextureColorModFloat(
        SDL_Texture* texture,
        float* r,
        float* g,
        float* b
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetTextureAlphaMod(
        SDL_Texture* texture,
        [NativeTypeName("Uint8")] byte alpha
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetTextureAlphaModFloat(SDL_Texture* texture, float alpha);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetTextureAlphaMod(
        SDL_Texture* texture,
        [NativeTypeName("Uint8 *")] byte* alpha
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetTextureAlphaModFloat(SDL_Texture* texture, float* alpha);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetTextureBlendMode(SDL_Texture* texture, BlendMode blendMode);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetTextureBlendMode(SDL_Texture* texture, BlendMode* blendMode);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetTextureScaleMode(SDL_Texture* texture, ScaleMode scaleMode);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetTextureScaleMode(SDL_Texture* texture, ScaleMode* scaleMode);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int UpdateTexture(
        SDL_Texture* texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        [NativeTypeName("const void *")] void* pixels,
        int pitch
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int UpdateYUVTexture(
        SDL_Texture* texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        [NativeTypeName("const Uint8 *")] byte* Yplane,
        int Ypitch,
        [NativeTypeName("const Uint8 *")] byte* Uplane,
        int Upitch,
        [NativeTypeName("const Uint8 *")] byte* Vplane,
        int Vpitch
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int UpdateNVTexture(
        SDL_Texture* texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        [NativeTypeName("const Uint8 *")] byte* Yplane,
        int Ypitch,
        [NativeTypeName("const Uint8 *")] byte* UVplane,
        int UVpitch
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int LockTexture(
        SDL_Texture* texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        void** pixels,
        int* pitch
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int LockTextureToSurface(
        SDL_Texture* texture,
        [NativeTypeName("const SDL_Rect *")] Rect* rect,
        Surface** surface
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void UnlockTexture(SDL_Texture* texture);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Texture* GetRenderTarget(SDL_Renderer* renderer);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetRenderLogicalPresentation(
        SDL_Renderer* renderer,
        int w,
        int h,
        RendererLogicalPresentation mode,
        ScaleMode scale_mode
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRenderLogicalPresentation(
        SDL_Renderer* renderer,
        int* w,
        int* h,
        RendererLogicalPresentation* mode,
        ScaleMode* scale_mode
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderCoordinatesFromWindow(
        SDL_Renderer* renderer,
        float window_x,
        float window_y,
        float* x,
        float* y
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderCoordinatesToWindow(
        SDL_Renderer* renderer,
        float x,
        float y,
        float* window_x,
        float* window_y
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ConvertEventToRenderCoordinates(SDL_Renderer* renderer, Event* @event);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetRenderViewport(
        SDL_Renderer* renderer,
        [NativeTypeName("const SDL_Rect *")] Rect* rect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRenderViewport(SDL_Renderer* renderer, Rect* rect);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int RenderViewportSet(SDL_Renderer* renderer);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetRenderClipRect(
        SDL_Renderer* renderer,
        [NativeTypeName("const SDL_Rect *")] Rect* rect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRenderClipRect(SDL_Renderer* renderer, Rect* rect);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int RenderClipEnabled(SDL_Renderer* renderer);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetRenderScale(SDL_Renderer* renderer, float scaleX, float scaleY);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRenderScale(SDL_Renderer* renderer, float* scaleX, float* scaleY);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetRenderDrawColor(
        SDL_Renderer* renderer,
        [NativeTypeName("Uint8")] byte r,
        [NativeTypeName("Uint8")] byte g,
        [NativeTypeName("Uint8")] byte b,
        [NativeTypeName("Uint8")] byte a
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetRenderDrawColorFloat(
        SDL_Renderer* renderer,
        float r,
        float g,
        float b,
        float a
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRenderDrawColor(
        SDL_Renderer* renderer,
        [NativeTypeName("Uint8 *")] byte* r,
        [NativeTypeName("Uint8 *")] byte* g,
        [NativeTypeName("Uint8 *")] byte* b,
        [NativeTypeName("Uint8 *")] byte* a
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRenderDrawColorFloat(
        SDL_Renderer* renderer,
        float* r,
        float* g,
        float* b,
        float* a
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetRenderColorScale(SDL_Renderer* renderer, float scale);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRenderColorScale(SDL_Renderer* renderer, float* scale);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetRenderDrawBlendMode(SDL_Renderer* renderer, BlendMode blendMode);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRenderDrawBlendMode(SDL_Renderer* renderer, BlendMode* blendMode);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderClear(SDL_Renderer* renderer);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderPoint(SDL_Renderer* renderer, float x, float y);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderPoints(
        SDL_Renderer* renderer,
        [NativeTypeName("const SDL_FPoint *")] FPoint* points,
        int count
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderLine(
        SDL_Renderer* renderer,
        float x1,
        float y1,
        float x2,
        float y2
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderLines(
        SDL_Renderer* renderer,
        [NativeTypeName("const SDL_FPoint *")] FPoint* points,
        int count
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderRect(
        SDL_Renderer* renderer,
        [NativeTypeName("const SDL_FRect *")] FRect* rect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderRects(
        SDL_Renderer* renderer,
        [NativeTypeName("const SDL_FRect *")] FRect* rects,
        int count
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderFillRect(
        SDL_Renderer* renderer,
        [NativeTypeName("const SDL_FRect *")] FRect* rect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderFillRects(
        SDL_Renderer* renderer,
        [NativeTypeName("const SDL_FRect *")] FRect* rects,
        int count
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderTexture(
        SDL_Renderer* renderer,
        SDL_Texture* texture,
        [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
        [NativeTypeName("const SDL_FRect *")] FRect* dstrect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderTextureRotated(
        SDL_Renderer* renderer,
        SDL_Texture* texture,
        [NativeTypeName("const SDL_FRect *")] FRect* srcrect,
        [NativeTypeName("const SDL_FRect *")] FRect* dstrect,
        [NativeTypeName("const double")] double angle,
        [NativeTypeName("const SDL_FPoint *")] FPoint* center,
        [NativeTypeName("const SDL_FlipMode")] FlipMode flip
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderGeometry(
        SDL_Renderer* renderer,
        SDL_Texture* texture,
        [NativeTypeName("const SDL_Vertex *")] Vertex* vertices,
        int num_vertices,
        [NativeTypeName("const int *")] int* indices,
        int num_indices
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderGeometryRaw(
        SDL_Renderer* renderer,
        SDL_Texture* texture,
        [NativeTypeName("const float *")] float* xy,
        int xy_stride,
        [NativeTypeName("const SDL_Color *")] Color* color,
        int color_stride,
        [NativeTypeName("const float *")] float* uv,
        int uv_stride,
        int num_vertices,
        [NativeTypeName("const void *")] void* indices,
        int num_indices,
        int size_indices
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderGeometryRawFloat(
        SDL_Renderer* renderer,
        SDL_Texture* texture,
        [NativeTypeName("const float *")] float* xy,
        int xy_stride,
        [NativeTypeName("const SDL_FColor *")] FColor* color,
        int color_stride,
        [NativeTypeName("const float *")] float* uv,
        int uv_stride,
        int num_vertices,
        [NativeTypeName("const void *")] void* indices,
        int num_indices,
        int size_indices
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern Surface* RenderReadPixels(
        SDL_Renderer* renderer,
        [NativeTypeName("const SDL_Rect *")] Rect* rect
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenderPresent(SDL_Renderer* renderer);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroyTexture(SDL_Texture* texture);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DestroyRenderer(SDL_Renderer* renderer);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int FlushRenderer(SDL_Renderer* renderer);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* GetRenderMetalLayer(SDL_Renderer* renderer);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void* GetRenderMetalCommandEncoder(SDL_Renderer* renderer);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int AddVulkanRenderSemaphores(
        SDL_Renderer* renderer,
        [NativeTypeName("Uint32")] uint wait_stage_mask,
        [NativeTypeName("Sint64")] long wait_semaphore,
        [NativeTypeName("Sint64")] long signal_semaphore
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int SetRenderVSync(SDL_Renderer* renderer, int vsync);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetRenderVSync(SDL_Renderer* renderer, int* vsync);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Storage* OpenTitleStorage(
        [NativeTypeName("const char *")] sbyte* @override,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Storage* OpenUserStorage(
        [NativeTypeName("const char *")] sbyte* org,
        [NativeTypeName("const char *")] sbyte* app,
        [NativeTypeName("SDL_PropertiesID")] uint props
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Storage* OpenFileStorage([NativeTypeName("const char *")] sbyte* path);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern SDL_Storage* OpenStorage(
        [NativeTypeName("const SDL_StorageInterface *")] StorageInterface* iface,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int CloseStorage(SDL_Storage* storage);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int StorageReady(SDL_Storage* storage);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetStorageFileSize(
        SDL_Storage* storage,
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("Uint64 *")] ulong* length
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int ReadStorageFile(
        SDL_Storage* storage,
        [NativeTypeName("const char *")] sbyte* path,
        void* destination,
        [NativeTypeName("Uint64")] ulong length
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int WriteStorageFile(
        SDL_Storage* storage,
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("const void *")] void* source,
        [NativeTypeName("Uint64")] ulong length
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int CreateStorageDirectory(
        SDL_Storage* storage,
        [NativeTypeName("const char *")] sbyte* path
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int EnumerateStorageDirectory(
        SDL_Storage* storage,
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("SDL_EnumerateDirectoryCallback")]
            delegate* unmanaged<void*, sbyte*, sbyte*, int> callback,
        void* userdata
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RemoveStoragePath(
        SDL_Storage* storage,
        [NativeTypeName("const char *")] sbyte* path
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int RenameStoragePath(
        SDL_Storage* storage,
        [NativeTypeName("const char *")] sbyte* oldpath,
        [NativeTypeName("const char *")] sbyte* newpath
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetStoragePathInfo(
        SDL_Storage* storage,
        [NativeTypeName("const char *")] sbyte* path,
        PathInfo* info
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint64")]
    public static extern ulong GetStorageSpaceRemaining(SDL_Storage* storage);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("char **")]
    public static extern sbyte** GlobStorageDirectory(
        SDL_Storage* storage,
        [NativeTypeName("const char *")] sbyte* path,
        [NativeTypeName("const char *")] sbyte* pattern,
        [NativeTypeName("Uint32")] uint flags,
        int* count
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int IsTablet();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void OnApplicationWillTerminate();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void OnApplicationDidReceiveMemoryWarning();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void OnApplicationWillResignActive();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void OnApplicationDidEnterBackground();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void OnApplicationWillEnterForeground();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void OnApplicationDidBecomeActive();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetCurrentTime([NativeTypeName("SDL_Time *")] long* ticks);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int TimeToDateTime(
        [NativeTypeName("SDL_Time")] long ticks,
        DateTime* dt,
        [NativeTypeName("SDL_bool")] int localTime
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int DateTimeToTime(
        [NativeTypeName("const SDL_DateTime *")] DateTime* dt,
        [NativeTypeName("SDL_Time *")] long* ticks
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void TimeToWindows(
        [NativeTypeName("SDL_Time")] long ticks,
        [NativeTypeName("Uint32 *")] uint* dwLowDateTime,
        [NativeTypeName("Uint32 *")] uint* dwHighDateTime
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_Time")]
    public static extern long TimeFromWindows(
        [NativeTypeName("Uint32")] uint dwLowDateTime,
        [NativeTypeName("Uint32")] uint dwHighDateTime
    );

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetDaysInMonth(int year, int month);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetDayOfYear(int year, int month, int day);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetDayOfWeek(int year, int month, int day);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint64")]
    public static extern ulong GetTicks();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint64")]
    public static extern ulong GetTicksNS();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint64")]
    public static extern ulong GetPerformanceCounter();

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("Uint64")]
    public static extern ulong GetPerformanceFrequency();

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void Delay([NativeTypeName("Uint32")] uint ms);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern void DelayNS([NativeTypeName("Uint64")] ulong ns);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_TimerID")]
    public static extern uint AddTimer(
        [NativeTypeName("Uint32")] uint interval,
        [NativeTypeName("SDL_TimerCallback")] delegate* unmanaged<uint, void*, uint> callback,
        void* param2
    );

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("SDL_bool")]
    public static extern int RemoveTimer([NativeTypeName("SDL_TimerID")] uint id);

    [DllImport("SDL3", ExactSpelling = true)]
    public static extern int GetVersion(Version* ver);

    [DllImport("SDL3", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* GetRevision();

    [NativeTypeName("#define SDL_ASSERT_LEVEL 2")]
    public const int AssertLevel = 2;

    [NativeTypeName("#define SDL_FILE __FILE__")]
    public static ReadOnlySpan<byte> File =>
        "/Users/dylan/Documents/Silk.NET3/eng/silktouch/sdl/SDL3/sdl-SDL.h"u8;

    [NativeTypeName("#define SDL_LINE __LINE__")]
    public const int Line = 7;

    [NativeTypeName("#define SDL_NULL_WHILE_LOOP_CONDITION (0)")]
    public const int NullWhileLoopCondition = (0);

    [NativeTypeName("#define SDL_MUTEX_TIMEDOUT 1")]
    public const int MutexTimedout = 1;

    [NativeTypeName("#define SDL_RWLOCK_TIMEDOUT SDL_MUTEX_TIMEDOUT")]
    public const int RwlockTimedout = 1;

    [NativeTypeName(
        "#define SDL_PROP_IOSTREAM_WINDOWS_HANDLE_POINTER \"SDL.iostream.windows.handle\""
    )]
    public static ReadOnlySpan<byte> PropIostreamWindowsHandlePointer =>
        "SDL.iostream.windows.handle"u8;

    [NativeTypeName("#define SDL_PROP_IOSTREAM_STDIO_FILE_POINTER \"SDL.iostream.stdio.file\"")]
    public static ReadOnlySpan<byte> PropIostreamStdioFilePointer => "SDL.iostream.stdio.file"u8;

    [NativeTypeName(
        "#define SDL_PROP_IOSTREAM_ANDROID_AASSET_POINTER \"SDL.iostream.android.aasset\""
    )]
    public static ReadOnlySpan<byte> PropIostreamAndroidAassetPointer =>
        "SDL.iostream.android.aasset"u8;

    [NativeTypeName(
        "#define SDL_PROP_IOSTREAM_DYNAMIC_MEMORY_POINTER \"SDL.iostream.dynamic.memory\""
    )]
    public static ReadOnlySpan<byte> PropIostreamDynamicMemoryPointer =>
        "SDL.iostream.dynamic.memory"u8;

    [NativeTypeName(
        "#define SDL_PROP_IOSTREAM_DYNAMIC_CHUNKSIZE_NUMBER \"SDL.iostream.dynamic.chunksize\""
    )]
    public static ReadOnlySpan<byte> PropIostreamDynamicChunksizeNumber =>
        "SDL.iostream.dynamic.chunksize"u8;

    [NativeTypeName("#define SDL_IO_SEEK_SET 0")]
    public const int IoSeekSet = 0;

    [NativeTypeName("#define SDL_IO_SEEK_CUR 1")]
    public const int IoSeekCur = 1;

    [NativeTypeName("#define SDL_IO_SEEK_END 2")]
    public const int IoSeekEnd = 2;

    [NativeTypeName("#define SDL_AUDIO_U8 0x0008")]
    public const int AudioU8 = 0x0008;

    [NativeTypeName("#define SDL_AUDIO_S8 0x8008")]
    public const int AudioS8 = 0x8008;

    [NativeTypeName("#define SDL_AUDIO_S16LE 0x8010")]
    public const int AudioS16Le = 0x8010;

    [NativeTypeName("#define SDL_AUDIO_S16BE 0x9010")]
    public const int AudioS16Be = 0x9010;

    [NativeTypeName("#define SDL_AUDIO_S32LE 0x8020")]
    public const int AudioS32Le = 0x8020;

    [NativeTypeName("#define SDL_AUDIO_S32BE 0x9020")]
    public const int AudioS32Be = 0x9020;

    [NativeTypeName("#define SDL_AUDIO_F32LE 0x8120")]
    public const int AudioF32Le = 0x8120;

    [NativeTypeName("#define SDL_AUDIO_F32BE 0x9120")]
    public const int AudioF32Be = 0x9120;

    [NativeTypeName("#define SDL_AUDIO_S16 SDL_AUDIO_S16LE")]
    public const int AudioS16 = 0x8010;

    [NativeTypeName("#define SDL_AUDIO_S32 SDL_AUDIO_S32LE")]
    public const int AudioS32 = 0x8020;

    [NativeTypeName("#define SDL_AUDIO_F32 SDL_AUDIO_F32LE")]
    public const int AudioF32 = 0x8120;

    [NativeTypeName("#define SDL_AUDIO_MASK_BITSIZE (0xFF)")]
    public const int AudioMaskBitsize = (0xFF);

    [NativeTypeName("#define SDL_AUDIO_MASK_FLOAT (1<<8)")]
    public const int AudioMaskFloat = (1 << 8);

    [NativeTypeName("#define SDL_AUDIO_MASK_BIG_ENDIAN (1<<12)")]
    public const int AudioMaskBigEndian = (1 << 12);

    [NativeTypeName("#define SDL_AUDIO_MASK_SIGNED (1<<15)")]
    public const int AudioMaskSigned = (1 << 15);

    [NativeTypeName("#define SDL_AUDIO_DEVICE_DEFAULT_OUTPUT ((SDL_AudioDeviceID) 0xFFFFFFFF)")]
    public const uint AudioDeviceDefaultOutput = ((uint)(0xFFFFFFFF));

    [NativeTypeName("#define SDL_AUDIO_DEVICE_DEFAULT_CAPTURE ((SDL_AudioDeviceID) 0xFFFFFFFE)")]
    public const uint AudioDeviceDefaultCapture = ((uint)(0xFFFFFFFE));

    [NativeTypeName("#define SDL_MIX_MAXVOLUME 128")]
    public const int MixMaxvolume = 128;

    [NativeTypeName("#define SDL_ALPHA_OPAQUE 255")]
    public const int AlphaOpaque = 255;

    [NativeTypeName("#define SDL_ALPHA_TRANSPARENT 0")]
    public const int AlphaTransparent = 0;

    [NativeTypeName("#define SDL_SWSURFACE 0")]
    public const int Swsurface = 0;

    [NativeTypeName("#define SDL_PREALLOC 0x00000001")]
    public const int Prealloc = 0x00000001;

    [NativeTypeName("#define SDL_RLEACCEL 0x00000002")]
    public const int Rleaccel = 0x00000002;

    [NativeTypeName("#define SDL_DONTFREE 0x00000004")]
    public const int Dontfree = 0x00000004;

    [NativeTypeName("#define SDL_SIMD_ALIGNED 0x00000008")]
    public const int SimdAligned = 0x00000008;

    [NativeTypeName("#define SDL_SURFACE_USES_PROPERTIES 0x00000010")]
    public const int SurfaceUsesProperties = 0x00000010;

    [NativeTypeName("#define SDL_PROP_SURFACE_COLORSPACE_NUMBER \"SDL.surface.colorspace\"")]
    public static ReadOnlySpan<byte> PropSurfaceColorspaceNumber => "SDL.surface.colorspace"u8;

    [NativeTypeName(
        "#define SDL_PROP_SURFACE_SDR_WHITE_POINT_FLOAT \"SDL.surface.SDR_white_point\""
    )]
    public static ReadOnlySpan<byte> PropSurfaceSdrWhitePointFloat =>
        "SDL.surface.SDR_white_point"u8;

    [NativeTypeName("#define SDL_PROP_SURFACE_HDR_HEADROOM_FLOAT \"SDL.surface.HDR_headroom\"")]
    public static ReadOnlySpan<byte> PropSurfaceHdrHeadroomFloat => "SDL.surface.HDR_headroom"u8;

    [NativeTypeName("#define SDL_PROP_SURFACE_TONEMAP_OPERATOR_STRING \"SDL.surface.tonemap\"")]
    public static ReadOnlySpan<byte> PropSurfaceTonemapOperatorString => "SDL.surface.tonemap"u8;

    [NativeTypeName(
        "#define SDL_PROP_GLOBAL_VIDEO_WAYLAND_WL_DISPLAY_POINTER \"SDL.video.wayland.wl_display\""
    )]
    public static ReadOnlySpan<byte> PropGlobalVideoWaylandWlDisplayPointer =>
        "SDL.video.wayland.wl_display"u8;

    [NativeTypeName("#define SDL_WINDOW_FULLSCREEN 0x00000001U")]
    public const uint WindowFullscreen = 0x00000001U;

    [NativeTypeName("#define SDL_WINDOW_OPENGL 0x00000002U")]
    public const uint WindowOpengl = 0x00000002U;

    [NativeTypeName("#define SDL_WINDOW_OCCLUDED 0x00000004U")]
    public const uint WindowOccluded = 0x00000004U;

    [NativeTypeName("#define SDL_WINDOW_HIDDEN 0x00000008U")]
    public const uint WindowHidden = 0x00000008U;

    [NativeTypeName("#define SDL_WINDOW_BORDERLESS 0x00000010U")]
    public const uint WindowBorderless = 0x00000010U;

    [NativeTypeName("#define SDL_WINDOW_RESIZABLE 0x00000020U")]
    public const uint WindowResizable = 0x00000020U;

    [NativeTypeName("#define SDL_WINDOW_MINIMIZED 0x00000040U")]
    public const uint WindowMinimized = 0x00000040U;

    [NativeTypeName("#define SDL_WINDOW_MAXIMIZED 0x00000080U")]
    public const uint WindowMaximized = 0x00000080U;

    [NativeTypeName("#define SDL_WINDOW_MOUSE_GRABBED 0x00000100U")]
    public const uint WindowMouseGrabbed = 0x00000100U;

    [NativeTypeName("#define SDL_WINDOW_INPUT_FOCUS 0x00000200U")]
    public const uint WindowInputFocus = 0x00000200U;

    [NativeTypeName("#define SDL_WINDOW_MOUSE_FOCUS 0x00000400U")]
    public const uint WindowMouseFocus = 0x00000400U;

    [NativeTypeName("#define SDL_WINDOW_EXTERNAL 0x00000800U")]
    public const uint WindowExternal = 0x00000800U;

    [NativeTypeName("#define SDL_WINDOW_MODAL 0x00001000U")]
    public const uint WindowModal = 0x00001000U;

    [NativeTypeName("#define SDL_WINDOW_HIGH_PIXEL_DENSITY 0x00002000U")]
    public const uint WindowHighPixelDensity = 0x00002000U;

    [NativeTypeName("#define SDL_WINDOW_MOUSE_CAPTURE 0x00004000U")]
    public const uint WindowMouseCapture = 0x00004000U;

    [NativeTypeName("#define SDL_WINDOW_ALWAYS_ON_TOP 0x00008000U")]
    public const uint WindowAlwaysOnTop = 0x00008000U;

    [NativeTypeName("#define SDL_WINDOW_UTILITY 0x00020000U")]
    public const uint WindowUtility = 0x00020000U;

    [NativeTypeName("#define SDL_WINDOW_TOOLTIP 0x00040000U")]
    public const uint WindowTooltip = 0x00040000U;

    [NativeTypeName("#define SDL_WINDOW_POPUP_MENU 0x00080000U")]
    public const uint WindowPopupMenu = 0x00080000U;

    [NativeTypeName("#define SDL_WINDOW_KEYBOARD_GRABBED 0x00100000U")]
    public const uint WindowKeyboardGrabbed = 0x00100000U;

    [NativeTypeName("#define SDL_WINDOW_VULKAN 0x10000000U")]
    public const uint WindowVulkan = 0x10000000U;

    [NativeTypeName("#define SDL_WINDOW_METAL 0x20000000U")]
    public const uint WindowMetal = 0x20000000U;

    [NativeTypeName("#define SDL_WINDOW_TRANSPARENT 0x40000000U")]
    public const uint WindowTransparent = 0x40000000U;

    [NativeTypeName("#define SDL_WINDOW_NOT_FOCUSABLE 0x80000000U")]
    public const uint WindowNotFocusable = 0x80000000U;

    [NativeTypeName("#define SDL_WINDOWPOS_UNDEFINED_MASK 0x1FFF0000u")]
    public const uint WindowposUndefinedMask = 0x1FFF0000U;

    [NativeTypeName("#define SDL_WINDOWPOS_UNDEFINED SDL_WINDOWPOS_UNDEFINED_DISPLAY(0)")]
    public const uint WindowposUndefined = (0x1FFF0000U | (0));

    [NativeTypeName("#define SDL_WINDOWPOS_CENTERED_MASK 0x2FFF0000u")]
    public const uint WindowposCenteredMask = 0x2FFF0000U;

    [NativeTypeName("#define SDL_WINDOWPOS_CENTERED SDL_WINDOWPOS_CENTERED_DISPLAY(0)")]
    public const uint WindowposCentered = (0x2FFF0000U | (0));

    [NativeTypeName("#define SDL_PROP_DISPLAY_HDR_ENABLED_BOOLEAN \"SDL.display.HDR_enabled\"")]
    public static ReadOnlySpan<byte> PropDisplayHdrEnabledBoolean => "SDL.display.HDR_enabled"u8;

    [NativeTypeName(
        "#define SDL_PROP_DISPLAY_SDR_WHITE_POINT_FLOAT \"SDL.display.SDR_white_point\""
    )]
    public static ReadOnlySpan<byte> PropDisplaySdrWhitePointFloat =>
        "SDL.display.SDR_white_point"u8;

    [NativeTypeName("#define SDL_PROP_DISPLAY_HDR_HEADROOM_FLOAT \"SDL.display.HDR_headroom\"")]
    public static ReadOnlySpan<byte> PropDisplayHdrHeadroomFloat => "SDL.display.HDR_headroom"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_ALWAYS_ON_TOP_BOOLEAN \"always_on_top\"")]
    public static ReadOnlySpan<byte> PropWindowCreateAlwaysOnTopBoolean => "always_on_top"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_BORDERLESS_BOOLEAN \"borderless\"")]
    public static ReadOnlySpan<byte> PropWindowCreateBorderlessBoolean => "borderless"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_FOCUSABLE_BOOLEAN \"focusable\"")]
    public static ReadOnlySpan<byte> PropWindowCreateFocusableBoolean => "focusable"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_CREATE_EXTERNAL_GRAPHICS_CONTEXT_BOOLEAN \"external_graphics_context\""
    )]
    public static ReadOnlySpan<byte> PropWindowCreateExternalGraphicsContextBoolean =>
        "external_graphics_context"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_FULLSCREEN_BOOLEAN \"fullscreen\"")]
    public static ReadOnlySpan<byte> PropWindowCreateFullscreenBoolean => "fullscreen"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_HEIGHT_NUMBER \"height\"")]
    public static ReadOnlySpan<byte> PropWindowCreateHeightNumber => "height"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_HIDDEN_BOOLEAN \"hidden\"")]
    public static ReadOnlySpan<byte> PropWindowCreateHiddenBoolean => "hidden"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_CREATE_HIGH_PIXEL_DENSITY_BOOLEAN \"high_pixel_density\""
    )]
    public static ReadOnlySpan<byte> PropWindowCreateHighPixelDensityBoolean =>
        "high_pixel_density"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MAXIMIZED_BOOLEAN \"maximized\"")]
    public static ReadOnlySpan<byte> PropWindowCreateMaximizedBoolean => "maximized"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MENU_BOOLEAN \"menu\"")]
    public static ReadOnlySpan<byte> PropWindowCreateMenuBoolean => "menu"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_METAL_BOOLEAN \"metal\"")]
    public static ReadOnlySpan<byte> PropWindowCreateMetalBoolean => "metal"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MINIMIZED_BOOLEAN \"minimized\"")]
    public static ReadOnlySpan<byte> PropWindowCreateMinimizedBoolean => "minimized"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MODAL_BOOLEAN \"modal\"")]
    public static ReadOnlySpan<byte> PropWindowCreateModalBoolean => "modal"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_MOUSE_GRABBED_BOOLEAN \"mouse_grabbed\"")]
    public static ReadOnlySpan<byte> PropWindowCreateMouseGrabbedBoolean => "mouse_grabbed"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_OPENGL_BOOLEAN \"opengl\"")]
    public static ReadOnlySpan<byte> PropWindowCreateOpenglBoolean => "opengl"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_PARENT_POINTER \"parent\"")]
    public static ReadOnlySpan<byte> PropWindowCreateParentPointer => "parent"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_RESIZABLE_BOOLEAN \"resizable\"")]
    public static ReadOnlySpan<byte> PropWindowCreateResizableBoolean => "resizable"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_TITLE_STRING \"title\"")]
    public static ReadOnlySpan<byte> PropWindowCreateTitleString => "title"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_TRANSPARENT_BOOLEAN \"transparent\"")]
    public static ReadOnlySpan<byte> PropWindowCreateTransparentBoolean => "transparent"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_TOOLTIP_BOOLEAN \"tooltip\"")]
    public static ReadOnlySpan<byte> PropWindowCreateTooltipBoolean => "tooltip"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_UTILITY_BOOLEAN \"utility\"")]
    public static ReadOnlySpan<byte> PropWindowCreateUtilityBoolean => "utility"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_VULKAN_BOOLEAN \"vulkan\"")]
    public static ReadOnlySpan<byte> PropWindowCreateVulkanBoolean => "vulkan"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WIDTH_NUMBER \"width\"")]
    public static ReadOnlySpan<byte> PropWindowCreateWidthNumber => "width"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_X_NUMBER \"x\"")]
    public static ReadOnlySpan<byte> PropWindowCreateXNumber => "x"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_Y_NUMBER \"y\"")]
    public static ReadOnlySpan<byte> PropWindowCreateYNumber => "y"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_COCOA_WINDOW_POINTER \"cocoa.window\"")]
    public static ReadOnlySpan<byte> PropWindowCreateCocoaWindowPointer => "cocoa.window"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_COCOA_VIEW_POINTER \"cocoa.view\"")]
    public static ReadOnlySpan<byte> PropWindowCreateCocoaViewPointer => "cocoa.view"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_CREATE_WAYLAND_SCALE_TO_DISPLAY_BOOLEAN \"wayland.scale_to_display\""
    )]
    public static ReadOnlySpan<byte> PropWindowCreateWaylandScaleToDisplayBoolean =>
        "wayland.scale_to_display"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_CREATE_WAYLAND_SURFACE_ROLE_CUSTOM_BOOLEAN \"wayland.surface_role_custom\""
    )]
    public static ReadOnlySpan<byte> PropWindowCreateWaylandSurfaceRoleCustomBoolean =>
        "wayland.surface_role_custom"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_CREATE_WAYLAND_CREATE_EGL_WINDOW_BOOLEAN \"wayland.create_egl_window\""
    )]
    public static ReadOnlySpan<byte> PropWindowCreateWaylandCreateEglWindowBoolean =>
        "wayland.create_egl_window"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_CREATE_WAYLAND_WL_SURFACE_POINTER \"wayland.wl_surface\""
    )]
    public static ReadOnlySpan<byte> PropWindowCreateWaylandWlSurfacePointer =>
        "wayland.wl_surface"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_WIN32_HWND_POINTER \"win32.hwnd\"")]
    public static ReadOnlySpan<byte> PropWindowCreateWin32HwndPointer => "win32.hwnd"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_CREATE_WIN32_PIXEL_FORMAT_HWND_POINTER \"win32.pixel_format_hwnd\""
    )]
    public static ReadOnlySpan<byte> PropWindowCreateWin32PixelFormatHwndPointer =>
        "win32.pixel_format_hwnd"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_CREATE_X11_WINDOW_NUMBER \"x11.window\"")]
    public static ReadOnlySpan<byte> PropWindowCreateX11WindowNumber => "x11.window"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_SHAPE_POINTER \"SDL.window.shape\"")]
    public static ReadOnlySpan<byte> PropWindowShapePointer => "SDL.window.shape"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_ANDROID_WINDOW_POINTER \"SDL.window.android.window\"")]
    public static ReadOnlySpan<byte> PropWindowAndroidWindowPointer =>
        "SDL.window.android.window"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_ANDROID_SURFACE_POINTER \"SDL.window.android.surface\""
    )]
    public static ReadOnlySpan<byte> PropWindowAndroidSurfacePointer =>
        "SDL.window.android.surface"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_UIKIT_WINDOW_POINTER \"SDL.window.uikit.window\"")]
    public static ReadOnlySpan<byte> PropWindowUikitWindowPointer => "SDL.window.uikit.window"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_UIKIT_METAL_VIEW_TAG_NUMBER \"SDL.window.uikit.metal_view_tag\""
    )]
    public static ReadOnlySpan<byte> PropWindowUikitMetalViewTagNumber =>
        "SDL.window.uikit.metal_view_tag"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_KMSDRM_DEVICE_INDEX_NUMBER \"SDL.window.kmsdrm.dev_index\""
    )]
    public static ReadOnlySpan<byte> PropWindowKmsdrmDeviceIndexNumber =>
        "SDL.window.kmsdrm.dev_index"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_KMSDRM_DRM_FD_NUMBER \"SDL.window.kmsdrm.drm_fd\"")]
    public static ReadOnlySpan<byte> PropWindowKmsdrmDrmFdNumber => "SDL.window.kmsdrm.drm_fd"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_KMSDRM_GBM_DEVICE_POINTER \"SDL.window.kmsdrm.gbm_dev\""
    )]
    public static ReadOnlySpan<byte> PropWindowKmsdrmGbmDevicePointer =>
        "SDL.window.kmsdrm.gbm_dev"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_COCOA_WINDOW_POINTER \"SDL.window.cocoa.window\"")]
    public static ReadOnlySpan<byte> PropWindowCocoaWindowPointer => "SDL.window.cocoa.window"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_COCOA_METAL_VIEW_TAG_NUMBER \"SDL.window.cocoa.metal_view_tag\""
    )]
    public static ReadOnlySpan<byte> PropWindowCocoaMetalViewTagNumber =>
        "SDL.window.cocoa.metal_view_tag"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_VIVANTE_DISPLAY_POINTER \"SDL.window.vivante.display\""
    )]
    public static ReadOnlySpan<byte> PropWindowVivanteDisplayPointer =>
        "SDL.window.vivante.display"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_VIVANTE_WINDOW_POINTER \"SDL.window.vivante.window\"")]
    public static ReadOnlySpan<byte> PropWindowVivanteWindowPointer =>
        "SDL.window.vivante.window"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_VIVANTE_SURFACE_POINTER \"SDL.window.vivante.surface\""
    )]
    public static ReadOnlySpan<byte> PropWindowVivanteSurfacePointer =>
        "SDL.window.vivante.surface"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_WINRT_WINDOW_POINTER \"SDL.window.winrt.window\"")]
    public static ReadOnlySpan<byte> PropWindowWinrtWindowPointer => "SDL.window.winrt.window"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_WIN32_HWND_POINTER \"SDL.window.win32.hwnd\"")]
    public static ReadOnlySpan<byte> PropWindowWin32HwndPointer => "SDL.window.win32.hwnd"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_WIN32_HDC_POINTER \"SDL.window.win32.hdc\"")]
    public static ReadOnlySpan<byte> PropWindowWin32HdcPointer => "SDL.window.win32.hdc"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_WIN32_INSTANCE_POINTER \"SDL.window.win32.instance\"")]
    public static ReadOnlySpan<byte> PropWindowWin32InstancePointer =>
        "SDL.window.win32.instance"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_WAYLAND_DISPLAY_POINTER \"SDL.window.wayland.display\""
    )]
    public static ReadOnlySpan<byte> PropWindowWaylandDisplayPointer =>
        "SDL.window.wayland.display"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_WAYLAND_SURFACE_POINTER \"SDL.window.wayland.surface\""
    )]
    public static ReadOnlySpan<byte> PropWindowWaylandSurfacePointer =>
        "SDL.window.wayland.surface"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_WAYLAND_EGL_WINDOW_POINTER \"SDL.window.wayland.egl_window\""
    )]
    public static ReadOnlySpan<byte> PropWindowWaylandEglWindowPointer =>
        "SDL.window.wayland.egl_window"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_WAYLAND_XDG_SURFACE_POINTER \"SDL.window.wayland.xdg_surface\""
    )]
    public static ReadOnlySpan<byte> PropWindowWaylandXdgSurfacePointer =>
        "SDL.window.wayland.xdg_surface"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_POINTER \"SDL.window.wayland.xdg_toplevel\""
    )]
    public static ReadOnlySpan<byte> PropWindowWaylandXdgToplevelPointer =>
        "SDL.window.wayland.xdg_toplevel"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_EXPORT_HANDLE_STRING \"SDL.window.wayland.xdg_toplevel_export_handle\""
    )]
    public static ReadOnlySpan<byte> PropWindowWaylandXdgToplevelExportHandleString =>
        "SDL.window.wayland.xdg_toplevel_export_handle"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_WAYLAND_XDG_POPUP_POINTER \"SDL.window.wayland.xdg_popup\""
    )]
    public static ReadOnlySpan<byte> PropWindowWaylandXdgPopupPointer =>
        "SDL.window.wayland.xdg_popup"u8;

    [NativeTypeName(
        "#define SDL_PROP_WINDOW_WAYLAND_XDG_POSITIONER_POINTER \"SDL.window.wayland.xdg_positioner\""
    )]
    public static ReadOnlySpan<byte> PropWindowWaylandXdgPositionerPointer =>
        "SDL.window.wayland.xdg_positioner"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_X11_DISPLAY_POINTER \"SDL.window.x11.display\"")]
    public static ReadOnlySpan<byte> PropWindowX11DisplayPointer => "SDL.window.x11.display"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_X11_SCREEN_NUMBER \"SDL.window.x11.screen\"")]
    public static ReadOnlySpan<byte> PropWindowX11ScreenNumber => "SDL.window.x11.screen"u8;

    [NativeTypeName("#define SDL_PROP_WINDOW_X11_WINDOW_NUMBER \"SDL.window.x11.window\"")]
    public static ReadOnlySpan<byte> PropWindowX11WindowNumber => "SDL.window.x11.window"u8;

    [NativeTypeName("#define SDL_CACHELINE_SIZE 128")]
    public const int CachelineSize = 128;

    [NativeTypeName("#define SDL_JOYSTICK_AXIS_MAX 32767")]
    public const int JoystickAxisMax = 32767;

    [NativeTypeName("#define SDL_JOYSTICK_AXIS_MIN -32768")]
    public const int JoystickAxisMin = -32768;

    [NativeTypeName("#define SDL_IPHONE_MAX_GFORCE 5.0")]
    public const double IphoneMaxGforce = 5.0;

    [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN \"SDL.joystick.cap.mono_led\"")]
    public static ReadOnlySpan<byte> PropJoystickCapMonoLedBoolean => "SDL.joystick.cap.mono_led"u8;

    [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN \"SDL.joystick.cap.rgb_led\"")]
    public static ReadOnlySpan<byte> PropJoystickCapRgbLedBoolean => "SDL.joystick.cap.rgb_led"u8;

    [NativeTypeName(
        "#define SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN \"SDL.joystick.cap.player_led\""
    )]
    public static ReadOnlySpan<byte> PropJoystickCapPlayerLedBoolean =>
        "SDL.joystick.cap.player_led"u8;

    [NativeTypeName("#define SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN \"SDL.joystick.cap.rumble\"")]
    public static ReadOnlySpan<byte> PropJoystickCapRumbleBoolean => "SDL.joystick.cap.rumble"u8;

    [NativeTypeName(
        "#define SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN \"SDL.joystick.cap.trigger_rumble\""
    )]
    public static ReadOnlySpan<byte> PropJoystickCapTriggerRumbleBoolean =>
        "SDL.joystick.cap.trigger_rumble"u8;

    [NativeTypeName("#define SDL_HAT_CENTERED 0x00")]
    public const int HatCentered = 0x00;

    [NativeTypeName("#define SDL_HAT_UP 0x01")]
    public const int HatUp = 0x01;

    [NativeTypeName("#define SDL_HAT_RIGHT 0x02")]
    public const int HatRight = 0x02;

    [NativeTypeName("#define SDL_HAT_DOWN 0x04")]
    public const int HatDown = 0x04;

    [NativeTypeName("#define SDL_HAT_LEFT 0x08")]
    public const int HatLeft = 0x08;

    [NativeTypeName("#define SDL_HAT_RIGHTUP (SDL_HAT_RIGHT|SDL_HAT_UP)")]
    public const int HatRightup = (0x02 | 0x01);

    [NativeTypeName("#define SDL_HAT_RIGHTDOWN (SDL_HAT_RIGHT|SDL_HAT_DOWN)")]
    public const int HatRightdown = (0x02 | 0x04);

    [NativeTypeName("#define SDL_HAT_LEFTUP (SDL_HAT_LEFT|SDL_HAT_UP)")]
    public const int HatLeftup = (0x08 | 0x01);

    [NativeTypeName("#define SDL_HAT_LEFTDOWN (SDL_HAT_LEFT|SDL_HAT_DOWN)")]
    public const int HatLeftdown = (0x08 | 0x04);

    [NativeTypeName("#define SDL_STANDARD_GRAVITY 9.80665f")]
    public const float StandardGravity = 9.80665f;

    [NativeTypeName(
        "#define SDL_PROP_GAMEPAD_CAP_MONO_LED_BOOLEAN SDL_PROP_JOYSTICK_CAP_MONO_LED_BOOLEAN"
    )]
    public static ReadOnlySpan<byte> PropGamepadCapMonoLedBoolean => "SDL.joystick.cap.mono_led"u8;

    [NativeTypeName(
        "#define SDL_PROP_GAMEPAD_CAP_RGB_LED_BOOLEAN SDL_PROP_JOYSTICK_CAP_RGB_LED_BOOLEAN"
    )]
    public static ReadOnlySpan<byte> PropGamepadCapRgbLedBoolean => "SDL.joystick.cap.rgb_led"u8;

    [NativeTypeName(
        "#define SDL_PROP_GAMEPAD_CAP_PLAYER_LED_BOOLEAN SDL_PROP_JOYSTICK_CAP_PLAYER_LED_BOOLEAN"
    )]
    public static ReadOnlySpan<byte> PropGamepadCapPlayerLedBoolean =>
        "SDL.joystick.cap.player_led"u8;

    [NativeTypeName(
        "#define SDL_PROP_GAMEPAD_CAP_RUMBLE_BOOLEAN SDL_PROP_JOYSTICK_CAP_RUMBLE_BOOLEAN"
    )]
    public static ReadOnlySpan<byte> PropGamepadCapRumbleBoolean => "SDL.joystick.cap.rumble"u8;

    [NativeTypeName(
        "#define SDL_PROP_GAMEPAD_CAP_TRIGGER_RUMBLE_BOOLEAN SDL_PROP_JOYSTICK_CAP_TRIGGER_RUMBLE_BOOLEAN"
    )]
    public static ReadOnlySpan<byte> PropGamepadCapTriggerRumbleBoolean =>
        "SDL.joystick.cap.trigger_rumble"u8;

    [NativeTypeName("#define SDLK_SCANCODE_MASK (1<<30)")]
    public const int KScancodeMask = (1 << 30);

    [NativeTypeName("#define SDLK_UNKNOWN 0")]
    public const int KUnknown = 0;

    [NativeTypeName("#define SDLK_RETURN '\r'")]
    public const sbyte KReturn = (sbyte)('\r');

    [NativeTypeName("#define SDLK_ESCAPE '\\x1B'")]
    public const sbyte KEscape = (sbyte)('');

    [NativeTypeName("#define SDLK_BACKSPACE '\\b'")]
    public const sbyte KBackspace = (sbyte)('');

    [NativeTypeName("#define SDLK_TAB '\t'")]
    public const sbyte KTab = (sbyte)('\t');

    [NativeTypeName("#define SDLK_SPACE ' '")]
    public const sbyte KSpace = (sbyte)(' ');

    [NativeTypeName("#define SDLK_EXCLAIM '!'")]
    public const sbyte KExclaim = (sbyte)('!');

    [NativeTypeName("#define SDLK_QUOTEDBL '\"'")]
    public const sbyte KQuotedbl = (sbyte)('"');

    [NativeTypeName("#define SDLK_HASH '#'")]
    public const sbyte KHash = (sbyte)('#');

    [NativeTypeName("#define SDLK_PERCENT '%'")]
    public const sbyte KPercent = (sbyte)('%');

    [NativeTypeName("#define SDLK_DOLLAR '$'")]
    public const sbyte KDollar = (sbyte)('$');

    [NativeTypeName("#define SDLK_AMPERSAND '&'")]
    public const sbyte KAmpersand = (sbyte)('&');

    [NativeTypeName("#define SDLK_QUOTE '\\''")]
    public const sbyte KQuote = (sbyte)('\'');

    [NativeTypeName("#define SDLK_LEFTPAREN '('")]
    public const sbyte KLeftparen = (sbyte)('(');

    [NativeTypeName("#define SDLK_RIGHTPAREN ')'")]
    public const sbyte KRightparen = (sbyte)(')');

    [NativeTypeName("#define SDLK_ASTERISK '*'")]
    public const sbyte KAsterisk = (sbyte)('*');

    [NativeTypeName("#define SDLK_PLUS '+'")]
    public const sbyte KPlus = (sbyte)('+');

    [NativeTypeName("#define SDLK_COMMA ','")]
    public const sbyte KComma = (sbyte)(',');

    [NativeTypeName("#define SDLK_MINUS '-'")]
    public const sbyte KMinus = (sbyte)('-');

    [NativeTypeName("#define SDLK_PERIOD '.'")]
    public const sbyte KPeriod = (sbyte)('.');

    [NativeTypeName("#define SDLK_SLASH '/'")]
    public const sbyte KSlash = (sbyte)('/');

    [NativeTypeName("#define SDLK_0 '0'")]
    public const sbyte K0 = (sbyte)('0');

    [NativeTypeName("#define SDLK_1 '1'")]
    public const sbyte K1 = (sbyte)('1');

    [NativeTypeName("#define SDLK_2 '2'")]
    public const sbyte K2 = (sbyte)('2');

    [NativeTypeName("#define SDLK_3 '3'")]
    public const sbyte K3 = (sbyte)('3');

    [NativeTypeName("#define SDLK_4 '4'")]
    public const sbyte K4 = (sbyte)('4');

    [NativeTypeName("#define SDLK_5 '5'")]
    public const sbyte K5 = (sbyte)('5');

    [NativeTypeName("#define SDLK_6 '6'")]
    public const sbyte K6 = (sbyte)('6');

    [NativeTypeName("#define SDLK_7 '7'")]
    public const sbyte K7 = (sbyte)('7');

    [NativeTypeName("#define SDLK_8 '8'")]
    public const sbyte K8 = (sbyte)('8');

    [NativeTypeName("#define SDLK_9 '9'")]
    public const sbyte K9 = (sbyte)('9');

    [NativeTypeName("#define SDLK_COLON ':'")]
    public const sbyte KColon = (sbyte)(':');

    [NativeTypeName("#define SDLK_SEMICOLON ';'")]
    public const sbyte KSemicolon = (sbyte)(';');

    [NativeTypeName("#define SDLK_LESS '<'")]
    public const sbyte KLess = (sbyte)('<');

    [NativeTypeName("#define SDLK_EQUALS '='")]
    public const sbyte KEquals = (sbyte)('=');

    [NativeTypeName("#define SDLK_GREATER '>'")]
    public const sbyte KGreater = (sbyte)('>');

    [NativeTypeName("#define SDLK_QUESTION '?'")]
    public const sbyte KQuestion = (sbyte)('?');

    [NativeTypeName("#define SDLK_AT '@'")]
    public const sbyte KAt = (sbyte)('@');

    [NativeTypeName("#define SDLK_LEFTBRACKET '['")]
    public const sbyte KLeftbracket = (sbyte)('[');

    [NativeTypeName("#define SDLK_BACKSLASH '\\'")]
    public const sbyte KBackslash = (sbyte)('\\');

    [NativeTypeName("#define SDLK_RIGHTBRACKET ']'")]
    public const sbyte KRightbracket = (sbyte)(']');

    [NativeTypeName("#define SDLK_CARET '^'")]
    public const sbyte KCaret = (sbyte)('^');

    [NativeTypeName("#define SDLK_UNDERSCORE '_'")]
    public const sbyte KUnderscore = (sbyte)('_');

    [NativeTypeName("#define SDLK_BACKQUOTE '`'")]
    public const sbyte KBackquote = (sbyte)('`');

    [NativeTypeName("#define SDLK_a 'a'")]
    public const sbyte Ka = (sbyte)('a');

    [NativeTypeName("#define SDLK_b 'b'")]
    public const sbyte Kb = (sbyte)('b');

    [NativeTypeName("#define SDLK_c 'c'")]
    public const sbyte Kc = (sbyte)('c');

    [NativeTypeName("#define SDLK_d 'd'")]
    public const sbyte Kd = (sbyte)('d');

    [NativeTypeName("#define SDLK_e 'e'")]
    public const sbyte Ke = (sbyte)('e');

    [NativeTypeName("#define SDLK_f 'f'")]
    public const sbyte Kf = (sbyte)('f');

    [NativeTypeName("#define SDLK_g 'g'")]
    public const sbyte Kg = (sbyte)('g');

    [NativeTypeName("#define SDLK_h 'h'")]
    public const sbyte Kh = (sbyte)('h');

    [NativeTypeName("#define SDLK_i 'i'")]
    public const sbyte Ki = (sbyte)('i');

    [NativeTypeName("#define SDLK_j 'j'")]
    public const sbyte Kj = (sbyte)('j');

    [NativeTypeName("#define SDLK_k 'k'")]
    public const sbyte Kk = (sbyte)('k');

    [NativeTypeName("#define SDLK_l 'l'")]
    public const sbyte Kl = (sbyte)('l');

    [NativeTypeName("#define SDLK_m 'm'")]
    public const sbyte Km = (sbyte)('m');

    [NativeTypeName("#define SDLK_n 'n'")]
    public const sbyte Kn = (sbyte)('n');

    [NativeTypeName("#define SDLK_o 'o'")]
    public const sbyte Ko = (sbyte)('o');

    [NativeTypeName("#define SDLK_p 'p'")]
    public const sbyte Kp = (sbyte)('p');

    [NativeTypeName("#define SDLK_q 'q'")]
    public const sbyte Kq = (sbyte)('q');

    [NativeTypeName("#define SDLK_r 'r'")]
    public const sbyte Kr = (sbyte)('r');

    [NativeTypeName("#define SDLK_s 's'")]
    public const sbyte Ks = (sbyte)('s');

    [NativeTypeName("#define SDLK_t 't'")]
    public const sbyte Kt = (sbyte)('t');

    [NativeTypeName("#define SDLK_u 'u'")]
    public const sbyte Ku = (sbyte)('u');

    [NativeTypeName("#define SDLK_v 'v'")]
    public const sbyte Kv = (sbyte)('v');

    [NativeTypeName("#define SDLK_w 'w'")]
    public const sbyte Kw = (sbyte)('w');

    [NativeTypeName("#define SDLK_x 'x'")]
    public const sbyte Kx = (sbyte)('x');

    [NativeTypeName("#define SDLK_y 'y'")]
    public const sbyte Ky = (sbyte)('y');

    [NativeTypeName("#define SDLK_z 'z'")]
    public const sbyte Kz = (sbyte)('z');

    [NativeTypeName("#define SDLK_CAPSLOCK SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_CAPSLOCK)")]
    public const int KCapslock = ((int)(ScancodeCapslock) | (1 << 30));

    [NativeTypeName("#define SDLK_F1 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F1)")]
    public const int KF1 = ((int)(ScancodeF1) | (1 << 30));

    [NativeTypeName("#define SDLK_F2 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F2)")]
    public const int KF2 = ((int)(ScancodeF2) | (1 << 30));

    [NativeTypeName("#define SDLK_F3 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F3)")]
    public const int KF3 = ((int)(ScancodeF3) | (1 << 30));

    [NativeTypeName("#define SDLK_F4 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F4)")]
    public const int KF4 = ((int)(ScancodeF4) | (1 << 30));

    [NativeTypeName("#define SDLK_F5 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F5)")]
    public const int KF5 = ((int)(ScancodeF5) | (1 << 30));

    [NativeTypeName("#define SDLK_F6 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F6)")]
    public const int KF6 = ((int)(ScancodeF6) | (1 << 30));

    [NativeTypeName("#define SDLK_F7 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F7)")]
    public const int KF7 = ((int)(ScancodeF7) | (1 << 30));

    [NativeTypeName("#define SDLK_F8 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F8)")]
    public const int KF8 = ((int)(ScancodeF8) | (1 << 30));

    [NativeTypeName("#define SDLK_F9 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F9)")]
    public const int KF9 = ((int)(ScancodeF9) | (1 << 30));

    [NativeTypeName("#define SDLK_F10 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F10)")]
    public const int KF10 = ((int)(ScancodeF10) | (1 << 30));

    [NativeTypeName("#define SDLK_F11 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F11)")]
    public const int KF11 = ((int)(ScancodeF11) | (1 << 30));

    [NativeTypeName("#define SDLK_F12 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F12)")]
    public const int KF12 = ((int)(ScancodeF12) | (1 << 30));

    [NativeTypeName("#define SDLK_PRINTSCREEN SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_PRINTSCREEN)")]
    public const int KPrintscreen = ((int)(ScancodePrintscreen) | (1 << 30));

    [NativeTypeName("#define SDLK_SCROLLLOCK SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_SCROLLLOCK)")]
    public const int KScrolllock = ((int)(ScancodeScrolllock) | (1 << 30));

    [NativeTypeName("#define SDLK_PAUSE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_PAUSE)")]
    public const int KPause = ((int)(ScancodePause) | (1 << 30));

    [NativeTypeName("#define SDLK_INSERT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_INSERT)")]
    public const int KInsert = ((int)(ScancodeInsert) | (1 << 30));

    [NativeTypeName("#define SDLK_HOME SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_HOME)")]
    public const int KHome = ((int)(ScancodeHome) | (1 << 30));

    [NativeTypeName("#define SDLK_PAGEUP SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_PAGEUP)")]
    public const int KPageup = ((int)(ScancodePageup) | (1 << 30));

    [NativeTypeName("#define SDLK_DELETE '\\x7F'")]
    public const sbyte KDelete = (sbyte)('');

    [NativeTypeName("#define SDLK_END SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_END)")]
    public const int KEnd = ((int)(ScancodeEnd) | (1 << 30));

    [NativeTypeName("#define SDLK_PAGEDOWN SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_PAGEDOWN)")]
    public const int KPagedown = ((int)(ScancodePagedown) | (1 << 30));

    [NativeTypeName("#define SDLK_RIGHT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_RIGHT)")]
    public const int KRight = ((int)(ScancodeRight) | (1 << 30));

    [NativeTypeName("#define SDLK_LEFT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_LEFT)")]
    public const int KLeft = ((int)(ScancodeLeft) | (1 << 30));

    [NativeTypeName("#define SDLK_DOWN SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_DOWN)")]
    public const int KDown = ((int)(ScancodeDown) | (1 << 30));

    [NativeTypeName("#define SDLK_UP SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_UP)")]
    public const int KUp = ((int)(ScancodeUp) | (1 << 30));

    [NativeTypeName("#define SDLK_NUMLOCKCLEAR SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_NUMLOCKCLEAR)")]
    public const int KNumlockclear = ((int)(ScancodeNumlockclear) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_DIVIDE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_DIVIDE)")]
    public const int KKpDivide = ((int)(ScancodeKpDivide) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_MULTIPLY SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_MULTIPLY)")]
    public const int KKpMultiply = ((int)(ScancodeKpMultiply) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_MINUS SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_MINUS)")]
    public const int KKpMinus = ((int)(ScancodeKpMinus) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_PLUS SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_PLUS)")]
    public const int KKpPlus = ((int)(ScancodeKpPlus) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_ENTER SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_ENTER)")]
    public const int KKpEnter = ((int)(ScancodeKpEnter) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_1 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_1)")]
    public const int KKp1 = ((int)(ScancodeKp1) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_2 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_2)")]
    public const int KKp2 = ((int)(ScancodeKp2) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_3 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_3)")]
    public const int KKp3 = ((int)(ScancodeKp3) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_4 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_4)")]
    public const int KKp4 = ((int)(ScancodeKp4) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_5 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_5)")]
    public const int KKp5 = ((int)(ScancodeKp5) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_6 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_6)")]
    public const int KKp6 = ((int)(ScancodeKp6) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_7 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_7)")]
    public const int KKp7 = ((int)(ScancodeKp7) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_8 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_8)")]
    public const int KKp8 = ((int)(ScancodeKp8) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_9 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_9)")]
    public const int KKp9 = ((int)(ScancodeKp9) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_0 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_0)")]
    public const int KKp0 = ((int)(ScancodeKp0) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_PERIOD SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_PERIOD)")]
    public const int KKpPeriod = ((int)(ScancodeKpPeriod) | (1 << 30));

    [NativeTypeName("#define SDLK_APPLICATION SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_APPLICATION)")]
    public const int KApplication = ((int)(ScancodeApplication) | (1 << 30));

    [NativeTypeName("#define SDLK_POWER SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_POWER)")]
    public const int KPower = ((int)(ScancodePower) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_EQUALS SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_EQUALS)")]
    public const int KKpEquals = ((int)(ScancodeKpEquals) | (1 << 30));

    [NativeTypeName("#define SDLK_F13 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F13)")]
    public const int KF13 = ((int)(ScancodeF13) | (1 << 30));

    [NativeTypeName("#define SDLK_F14 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F14)")]
    public const int KF14 = ((int)(ScancodeF14) | (1 << 30));

    [NativeTypeName("#define SDLK_F15 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F15)")]
    public const int KF15 = ((int)(ScancodeF15) | (1 << 30));

    [NativeTypeName("#define SDLK_F16 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F16)")]
    public const int KF16 = ((int)(ScancodeF16) | (1 << 30));

    [NativeTypeName("#define SDLK_F17 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F17)")]
    public const int KF17 = ((int)(ScancodeF17) | (1 << 30));

    [NativeTypeName("#define SDLK_F18 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F18)")]
    public const int KF18 = ((int)(ScancodeF18) | (1 << 30));

    [NativeTypeName("#define SDLK_F19 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F19)")]
    public const int KF19 = ((int)(ScancodeF19) | (1 << 30));

    [NativeTypeName("#define SDLK_F20 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F20)")]
    public const int KF20 = ((int)(ScancodeF20) | (1 << 30));

    [NativeTypeName("#define SDLK_F21 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F21)")]
    public const int KF21 = ((int)(ScancodeF21) | (1 << 30));

    [NativeTypeName("#define SDLK_F22 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F22)")]
    public const int KF22 = ((int)(ScancodeF22) | (1 << 30));

    [NativeTypeName("#define SDLK_F23 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F23)")]
    public const int KF23 = ((int)(ScancodeF23) | (1 << 30));

    [NativeTypeName("#define SDLK_F24 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_F24)")]
    public const int KF24 = ((int)(ScancodeF24) | (1 << 30));

    [NativeTypeName("#define SDLK_EXECUTE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_EXECUTE)")]
    public const int KExecute = ((int)(ScancodeExecute) | (1 << 30));

    [NativeTypeName("#define SDLK_HELP SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_HELP)")]
    public const int KHelp = ((int)(ScancodeHelp) | (1 << 30));

    [NativeTypeName("#define SDLK_MENU SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_MENU)")]
    public const int KMenu = ((int)(ScancodeMenu) | (1 << 30));

    [NativeTypeName("#define SDLK_SELECT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_SELECT)")]
    public const int KSelect = ((int)(ScancodeSelect) | (1 << 30));

    [NativeTypeName("#define SDLK_STOP SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_STOP)")]
    public const int KStop = ((int)(ScancodeStop) | (1 << 30));

    [NativeTypeName("#define SDLK_AGAIN SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AGAIN)")]
    public const int KAgain = ((int)(ScancodeAgain) | (1 << 30));

    [NativeTypeName("#define SDLK_UNDO SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_UNDO)")]
    public const int KUndo = ((int)(ScancodeUndo) | (1 << 30));

    [NativeTypeName("#define SDLK_CUT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_CUT)")]
    public const int KCut = ((int)(ScancodeCut) | (1 << 30));

    [NativeTypeName("#define SDLK_COPY SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_COPY)")]
    public const int KCopy = ((int)(ScancodeCopy) | (1 << 30));

    [NativeTypeName("#define SDLK_PASTE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_PASTE)")]
    public const int KPaste = ((int)(ScancodePaste) | (1 << 30));

    [NativeTypeName("#define SDLK_FIND SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_FIND)")]
    public const int KFind = ((int)(ScancodeFind) | (1 << 30));

    [NativeTypeName("#define SDLK_MUTE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_MUTE)")]
    public const int KMute = ((int)(ScancodeMute) | (1 << 30));

    [NativeTypeName("#define SDLK_VOLUMEUP SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_VOLUMEUP)")]
    public const int KVolumeup = ((int)(ScancodeVolumeup) | (1 << 30));

    [NativeTypeName("#define SDLK_VOLUMEDOWN SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_VOLUMEDOWN)")]
    public const int KVolumedown = ((int)(ScancodeVolumedown) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_COMMA SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_COMMA)")]
    public const int KKpComma = ((int)(ScancodeKpComma) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_KP_EQUALSAS400 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_EQUALSAS400)"
    )]
    public const int KKpEqualsas400 = ((int)(ScancodeKpEqualsas400) | (1 << 30));

    [NativeTypeName("#define SDLK_ALTERASE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_ALTERASE)")]
    public const int KAlterase = ((int)(ScancodeAlterase) | (1 << 30));

    [NativeTypeName("#define SDLK_SYSREQ SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_SYSREQ)")]
    public const int KSysreq = ((int)(ScancodeSysreq) | (1 << 30));

    [NativeTypeName("#define SDLK_CANCEL SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_CANCEL)")]
    public const int KCancel = ((int)(ScancodeCancel) | (1 << 30));

    [NativeTypeName("#define SDLK_CLEAR SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_CLEAR)")]
    public const int KClear = ((int)(ScancodeClear) | (1 << 30));

    [NativeTypeName("#define SDLK_PRIOR SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_PRIOR)")]
    public const int KPrior = ((int)(ScancodePrior) | (1 << 30));

    [NativeTypeName("#define SDLK_RETURN2 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_RETURN2)")]
    public const int KReturn2 = ((int)(ScancodeReturn2) | (1 << 30));

    [NativeTypeName("#define SDLK_SEPARATOR SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_SEPARATOR)")]
    public const int KSeparator = ((int)(ScancodeSeparator) | (1 << 30));

    [NativeTypeName("#define SDLK_OUT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_OUT)")]
    public const int KOut = ((int)(ScancodeOut) | (1 << 30));

    [NativeTypeName("#define SDLK_OPER SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_OPER)")]
    public const int KOper = ((int)(ScancodeOper) | (1 << 30));

    [NativeTypeName("#define SDLK_CLEARAGAIN SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_CLEARAGAIN)")]
    public const int KClearagain = ((int)(ScancodeClearagain) | (1 << 30));

    [NativeTypeName("#define SDLK_CRSEL SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_CRSEL)")]
    public const int KCrsel = ((int)(ScancodeCrsel) | (1 << 30));

    [NativeTypeName("#define SDLK_EXSEL SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_EXSEL)")]
    public const int KExsel = ((int)(ScancodeExsel) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_00 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_00)")]
    public const int KKp00 = ((int)(ScancodeKp00) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_000 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_000)")]
    public const int KKp000 = ((int)(ScancodeKp000) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_THOUSANDSSEPARATOR SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_THOUSANDSSEPARATOR)"
    )]
    public const int KThousandsseparator = ((int)(ScancodeThousandsseparator) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_DECIMALSEPARATOR SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_DECIMALSEPARATOR)"
    )]
    public const int KDecimalseparator = ((int)(ScancodeDecimalseparator) | (1 << 30));

    [NativeTypeName("#define SDLK_CURRENCYUNIT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_CURRENCYUNIT)")]
    public const int KCurrencyunit = ((int)(ScancodeCurrencyunit) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_CURRENCYSUBUNIT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_CURRENCYSUBUNIT)"
    )]
    public const int KCurrencysubunit = ((int)(ScancodeCurrencysubunit) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_LEFTPAREN SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_LEFTPAREN)")]
    public const int KKpLeftparen = ((int)(ScancodeKpLeftparen) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_KP_RIGHTPAREN SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_RIGHTPAREN)"
    )]
    public const int KKpRightparen = ((int)(ScancodeKpRightparen) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_LEFTBRACE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_LEFTBRACE)")]
    public const int KKpLeftbrace = ((int)(ScancodeKpLeftbrace) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_KP_RIGHTBRACE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_RIGHTBRACE)"
    )]
    public const int KKpRightbrace = ((int)(ScancodeKpRightbrace) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_TAB SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_TAB)")]
    public const int KKpTab = ((int)(ScancodeKpTab) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_BACKSPACE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_BACKSPACE)")]
    public const int KKpBackspace = ((int)(ScancodeKpBackspace) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_A SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_A)")]
    public const int KKpA = ((int)(ScancodeKpA) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_B SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_B)")]
    public const int KKpB = ((int)(ScancodeKpB) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_C SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_C)")]
    public const int KKpC = ((int)(ScancodeKpC) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_D SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_D)")]
    public const int KKpD = ((int)(ScancodeKpD) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_E SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_E)")]
    public const int KKpE = ((int)(ScancodeKpE) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_F SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_F)")]
    public const int KKpF = ((int)(ScancodeKpF) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_XOR SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_XOR)")]
    public const int KKpXor = ((int)(ScancodeKpXor) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_POWER SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_POWER)")]
    public const int KKpPower = ((int)(ScancodeKpPower) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_PERCENT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_PERCENT)")]
    public const int KKpPercent = ((int)(ScancodeKpPercent) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_LESS SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_LESS)")]
    public const int KKpLess = ((int)(ScancodeKpLess) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_GREATER SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_GREATER)")]
    public const int KKpGreater = ((int)(ScancodeKpGreater) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_AMPERSAND SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_AMPERSAND)")]
    public const int KKpAmpersand = ((int)(ScancodeKpAmpersand) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_KP_DBLAMPERSAND SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_DBLAMPERSAND)"
    )]
    public const int KKpDblampersand = ((int)(ScancodeKpDblampersand) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_KP_VERTICALBAR SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_VERTICALBAR)"
    )]
    public const int KKpVerticalbar = ((int)(ScancodeKpVerticalbar) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_KP_DBLVERTICALBAR SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_DBLVERTICALBAR)"
    )]
    public const int KKpDblverticalbar = ((int)(ScancodeKpDblverticalbar) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_COLON SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_COLON)")]
    public const int KKpColon = ((int)(ScancodeKpColon) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_HASH SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_HASH)")]
    public const int KKpHash = ((int)(ScancodeKpHash) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_SPACE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_SPACE)")]
    public const int KKpSpace = ((int)(ScancodeKpSpace) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_AT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_AT)")]
    public const int KKpAt = ((int)(ScancodeKpAt) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_EXCLAM SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_EXCLAM)")]
    public const int KKpExclam = ((int)(ScancodeKpExclam) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_MEMSTORE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_MEMSTORE)")]
    public const int KKpMemstore = ((int)(ScancodeKpMemstore) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_MEMRECALL SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_MEMRECALL)")]
    public const int KKpMemrecall = ((int)(ScancodeKpMemrecall) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_MEMCLEAR SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_MEMCLEAR)")]
    public const int KKpMemclear = ((int)(ScancodeKpMemclear) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_MEMADD SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_MEMADD)")]
    public const int KKpMemadd = ((int)(ScancodeKpMemadd) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_KP_MEMSUBTRACT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_MEMSUBTRACT)"
    )]
    public const int KKpMemsubtract = ((int)(ScancodeKpMemsubtract) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_KP_MEMMULTIPLY SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_MEMMULTIPLY)"
    )]
    public const int KKpMemmultiply = ((int)(ScancodeKpMemmultiply) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_MEMDIVIDE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_MEMDIVIDE)")]
    public const int KKpMemdivide = ((int)(ScancodeKpMemdivide) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_PLUSMINUS SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_PLUSMINUS)")]
    public const int KKpPlusminus = ((int)(ScancodeKpPlusminus) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_CLEAR SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_CLEAR)")]
    public const int KKpClear = ((int)(ScancodeKpClear) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_KP_CLEARENTRY SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_CLEARENTRY)"
    )]
    public const int KKpClearentry = ((int)(ScancodeKpClearentry) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_BINARY SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_BINARY)")]
    public const int KKpBinary = ((int)(ScancodeKpBinary) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_OCTAL SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_OCTAL)")]
    public const int KKpOctal = ((int)(ScancodeKpOctal) | (1 << 30));

    [NativeTypeName("#define SDLK_KP_DECIMAL SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_DECIMAL)")]
    public const int KKpDecimal = ((int)(ScancodeKpDecimal) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_KP_HEXADECIMAL SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KP_HEXADECIMAL)"
    )]
    public const int KKpHexadecimal = ((int)(ScancodeKpHexadecimal) | (1 << 30));

    [NativeTypeName("#define SDLK_LCTRL SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_LCTRL)")]
    public const int KLctrl = ((int)(ScancodeLctrl) | (1 << 30));

    [NativeTypeName("#define SDLK_LSHIFT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_LSHIFT)")]
    public const int KLshift = ((int)(ScancodeLshift) | (1 << 30));

    [NativeTypeName("#define SDLK_LALT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_LALT)")]
    public const int KLalt = ((int)(ScancodeLalt) | (1 << 30));

    [NativeTypeName("#define SDLK_LGUI SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_LGUI)")]
    public const int KLgui = ((int)(ScancodeLgui) | (1 << 30));

    [NativeTypeName("#define SDLK_RCTRL SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_RCTRL)")]
    public const int KRctrl = ((int)(ScancodeRctrl) | (1 << 30));

    [NativeTypeName("#define SDLK_RSHIFT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_RSHIFT)")]
    public const int KRshift = ((int)(ScancodeRshift) | (1 << 30));

    [NativeTypeName("#define SDLK_RALT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_RALT)")]
    public const int KRalt = ((int)(ScancodeRalt) | (1 << 30));

    [NativeTypeName("#define SDLK_RGUI SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_RGUI)")]
    public const int KRgui = ((int)(ScancodeRgui) | (1 << 30));

    [NativeTypeName("#define SDLK_MODE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_MODE)")]
    public const int KMode = ((int)(ScancodeMode) | (1 << 30));

    [NativeTypeName("#define SDLK_AUDIONEXT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AUDIONEXT)")]
    public const int KAudionext = ((int)(ScancodeAudionext) | (1 << 30));

    [NativeTypeName("#define SDLK_AUDIOPREV SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AUDIOPREV)")]
    public const int KAudioprev = ((int)(ScancodeAudioprev) | (1 << 30));

    [NativeTypeName("#define SDLK_AUDIOSTOP SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AUDIOSTOP)")]
    public const int KAudiostop = ((int)(ScancodeAudiostop) | (1 << 30));

    [NativeTypeName("#define SDLK_AUDIOPLAY SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AUDIOPLAY)")]
    public const int KAudioplay = ((int)(ScancodeAudioplay) | (1 << 30));

    [NativeTypeName("#define SDLK_AUDIOMUTE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AUDIOMUTE)")]
    public const int KAudiomute = ((int)(ScancodeAudiomute) | (1 << 30));

    [NativeTypeName("#define SDLK_MEDIASELECT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_MEDIASELECT)")]
    public const int KMediaselect = ((int)(ScancodeMediaselect) | (1 << 30));

    [NativeTypeName("#define SDLK_WWW SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_WWW)")]
    public const int KWww = ((int)(ScancodeWww) | (1 << 30));

    [NativeTypeName("#define SDLK_MAIL SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_MAIL)")]
    public const int KMail = ((int)(ScancodeMail) | (1 << 30));

    [NativeTypeName("#define SDLK_CALCULATOR SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_CALCULATOR)")]
    public const int KCalculator = ((int)(ScancodeCalculator) | (1 << 30));

    [NativeTypeName("#define SDLK_COMPUTER SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_COMPUTER)")]
    public const int KComputer = ((int)(ScancodeComputer) | (1 << 30));

    [NativeTypeName("#define SDLK_AC_SEARCH SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AC_SEARCH)")]
    public const int KAcSearch = ((int)(ScancodeAcSearch) | (1 << 30));

    [NativeTypeName("#define SDLK_AC_HOME SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AC_HOME)")]
    public const int KAcHome = ((int)(ScancodeAcHome) | (1 << 30));

    [NativeTypeName("#define SDLK_AC_BACK SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AC_BACK)")]
    public const int KAcBack = ((int)(ScancodeAcBack) | (1 << 30));

    [NativeTypeName("#define SDLK_AC_FORWARD SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AC_FORWARD)")]
    public const int KAcForward = ((int)(ScancodeAcForward) | (1 << 30));

    [NativeTypeName("#define SDLK_AC_STOP SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AC_STOP)")]
    public const int KAcStop = ((int)(ScancodeAcStop) | (1 << 30));

    [NativeTypeName("#define SDLK_AC_REFRESH SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AC_REFRESH)")]
    public const int KAcRefresh = ((int)(ScancodeAcRefresh) | (1 << 30));

    [NativeTypeName("#define SDLK_AC_BOOKMARKS SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AC_BOOKMARKS)")]
    public const int KAcBookmarks = ((int)(ScancodeAcBookmarks) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_BRIGHTNESSDOWN SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_BRIGHTNESSDOWN)"
    )]
    public const int KBrightnessdown = ((int)(ScancodeBrightnessdown) | (1 << 30));

    [NativeTypeName("#define SDLK_BRIGHTNESSUP SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_BRIGHTNESSUP)")]
    public const int KBrightnessup = ((int)(ScancodeBrightnessup) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_DISPLAYSWITCH SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_DISPLAYSWITCH)"
    )]
    public const int KDisplayswitch = ((int)(ScancodeDisplayswitch) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_KBDILLUMTOGGLE SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KBDILLUMTOGGLE)"
    )]
    public const int KKbdillumtoggle = ((int)(ScancodeKbdillumtoggle) | (1 << 30));

    [NativeTypeName("#define SDLK_KBDILLUMDOWN SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KBDILLUMDOWN)")]
    public const int KKbdillumdown = ((int)(ScancodeKbdillumdown) | (1 << 30));

    [NativeTypeName("#define SDLK_KBDILLUMUP SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_KBDILLUMUP)")]
    public const int KKbdillumup = ((int)(ScancodeKbdillumup) | (1 << 30));

    [NativeTypeName("#define SDLK_EJECT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_EJECT)")]
    public const int KEject = ((int)(ScancodeEject) | (1 << 30));

    [NativeTypeName("#define SDLK_SLEEP SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_SLEEP)")]
    public const int KSleep = ((int)(ScancodeSleep) | (1 << 30));

    [NativeTypeName("#define SDLK_APP1 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_APP1)")]
    public const int KApp1 = ((int)(ScancodeApp1) | (1 << 30));

    [NativeTypeName("#define SDLK_APP2 SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_APP2)")]
    public const int KApp2 = ((int)(ScancodeApp2) | (1 << 30));

    [NativeTypeName("#define SDLK_AUDIOREWIND SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AUDIOREWIND)")]
    public const int KAudiorewind = ((int)(ScancodeAudiorewind) | (1 << 30));

    [NativeTypeName(
        "#define SDLK_AUDIOFASTFORWARD SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_AUDIOFASTFORWARD)"
    )]
    public const int KAudiofastforward = ((int)(ScancodeAudiofastforward) | (1 << 30));

    [NativeTypeName("#define SDLK_SOFTLEFT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_SOFTLEFT)")]
    public const int KSoftleft = ((int)(ScancodeSoftleft) | (1 << 30));

    [NativeTypeName("#define SDLK_SOFTRIGHT SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_SOFTRIGHT)")]
    public const int KSoftright = ((int)(ScancodeSoftright) | (1 << 30));

    [NativeTypeName("#define SDLK_CALL SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_CALL)")]
    public const int KCall = ((int)(ScancodeCall) | (1 << 30));

    [NativeTypeName("#define SDLK_ENDCALL SDL_SCANCODE_TO_KEYCODE(SDL_SCANCODE_ENDCALL)")]
    public const int KEndcall = ((int)(ScancodeEndcall) | (1 << 30));

    [NativeTypeName("#define SDL_BUTTON_LEFT 1")]
    public const int ButtonLeft = 1;

    [NativeTypeName("#define SDL_BUTTON_MIDDLE 2")]
    public const int ButtonMiddle = 2;

    [NativeTypeName("#define SDL_BUTTON_RIGHT 3")]
    public const int ButtonRight = 3;

    [NativeTypeName("#define SDL_BUTTON_X1 4")]
    public const int ButtonX1 = 4;

    [NativeTypeName("#define SDL_BUTTON_X2 5")]
    public const int ButtonX2 = 5;

    [NativeTypeName("#define SDL_BUTTON_LMASK SDL_BUTTON(SDL_BUTTON_LEFT)")]
    public const int ButtonLmask = (1 << ((1) - 1));

    [NativeTypeName("#define SDL_BUTTON_MMASK SDL_BUTTON(SDL_BUTTON_MIDDLE)")]
    public const int ButtonMmask = (1 << ((2) - 1));

    [NativeTypeName("#define SDL_BUTTON_RMASK SDL_BUTTON(SDL_BUTTON_RIGHT)")]
    public const int ButtonRmask = (1 << ((3) - 1));

    [NativeTypeName("#define SDL_BUTTON_X1MASK SDL_BUTTON(SDL_BUTTON_X1)")]
    public const int ButtonX1Mask = (1 << ((4) - 1));

    [NativeTypeName("#define SDL_BUTTON_X2MASK SDL_BUTTON(SDL_BUTTON_X2)")]
    public const int ButtonX2Mask = (1 << ((5) - 1));

    [NativeTypeName("#define SDL_PEN_INVALID ((SDL_PenID)0)")]
    public const uint PenInvalid = ((uint)(0));

    [NativeTypeName("#define SDL_PEN_MOUSEID ((SDL_MouseID)-2)")]
    public const uint PenMouseid = unchecked((uint)(-2));

    [NativeTypeName("#define SDL_PEN_INFO_UNKNOWN (-1)")]
    public const int PenInfoUnknown = (-1);

    [NativeTypeName("#define SDL_PEN_FLAG_DOWN_BIT_INDEX 13")]
    public const int PenFlagDownBitIndex = 13;

    [NativeTypeName("#define SDL_PEN_FLAG_INK_BIT_INDEX 14")]
    public const int PenFlagInkBitIndex = 14;

    [NativeTypeName("#define SDL_PEN_FLAG_ERASER_BIT_INDEX 15")]
    public const int PenFlagEraserBitIndex = 15;

    [NativeTypeName("#define SDL_PEN_FLAG_AXIS_BIT_OFFSET 16")]
    public const int PenFlagAxisBitOffset = 16;

    [NativeTypeName("#define SDL_PEN_TIP_INK SDL_PEN_FLAG_INK_BIT_INDEX")]
    public const int PenTipInk = 14;

    [NativeTypeName("#define SDL_PEN_TIP_ERASER SDL_PEN_FLAG_ERASER_BIT_INDEX")]
    public const int PenTipEraser = 15;

    [NativeTypeName("#define SDL_PEN_DOWN_MASK SDL_PEN_CAPABILITY(SDL_PEN_FLAG_DOWN_BIT_INDEX)")]
    public const nuint PenDownMask = (1U << (13));

    [NativeTypeName("#define SDL_PEN_INK_MASK SDL_PEN_CAPABILITY(SDL_PEN_FLAG_INK_BIT_INDEX)")]
    public const nuint PenInkMask = (1U << (14));

    [NativeTypeName(
        "#define SDL_PEN_ERASER_MASK SDL_PEN_CAPABILITY(SDL_PEN_FLAG_ERASER_BIT_INDEX)"
    )]
    public const nuint PenEraserMask = (1U << (15));

    [NativeTypeName(
        "#define SDL_PEN_AXIS_PRESSURE_MASK SDL_PEN_AXIS_CAPABILITY(SDL_PEN_AXIS_PRESSURE)"
    )]
    public const nuint PenAxisPressureMask = (1U << ((int)(AxisPressure) + 16));

    [NativeTypeName("#define SDL_PEN_AXIS_XTILT_MASK SDL_PEN_AXIS_CAPABILITY(SDL_PEN_AXIS_XTILT)")]
    public const nuint PenAxisXtiltMask = (1U << ((int)(AxisXtilt) + 16));

    [NativeTypeName("#define SDL_PEN_AXIS_YTILT_MASK SDL_PEN_AXIS_CAPABILITY(SDL_PEN_AXIS_YTILT)")]
    public const nuint PenAxisYtiltMask = (1U << ((int)(AxisYtilt) + 16));

    [NativeTypeName(
        "#define SDL_PEN_AXIS_DISTANCE_MASK SDL_PEN_AXIS_CAPABILITY(SDL_PEN_AXIS_DISTANCE)"
    )]
    public const nuint PenAxisDistanceMask = (1U << ((int)(AxisDistance) + 16));

    [NativeTypeName(
        "#define SDL_PEN_AXIS_ROTATION_MASK SDL_PEN_AXIS_CAPABILITY(SDL_PEN_AXIS_ROTATION)"
    )]
    public const nuint PenAxisRotationMask = (1U << ((int)(AxisRotation) + 16));

    [NativeTypeName(
        "#define SDL_PEN_AXIS_SLIDER_MASK SDL_PEN_AXIS_CAPABILITY(SDL_PEN_AXIS_SLIDER)"
    )]
    public const nuint PenAxisSliderMask = (1U << ((int)(AxisSlider) + 16));

    [NativeTypeName(
        "#define SDL_PEN_AXIS_BIDIRECTIONAL_MASKS (SDL_PEN_AXIS_XTILT_MASK | SDL_PEN_AXIS_YTILT_MASK)"
    )]
    public const nuint PenAxisBidirectionalMasks = (
        (1U << ((int)(AxisXtilt) + 16)) | (1U << ((int)(AxisYtilt) + 16))
    );

    [NativeTypeName("#define SDL_TOUCH_MOUSEID ((SDL_MouseID)-1)")]
    public const uint TouchMouseid = unchecked((uint)(-1));

    [NativeTypeName("#define SDL_MOUSE_TOUCHID ((SDL_TouchID)-1)")]
    public const ulong MouseTouchid = unchecked((ulong)(-1));

    [NativeTypeName("#define SDL_RELEASED 0")]
    public const int Released = 0;

    [NativeTypeName("#define SDL_PRESSED 1")]
    public const int Pressed = 1;

    [NativeTypeName("#define SDL_TEXTEDITINGEVENT_TEXT_SIZE 64")]
    public const int TexteditingeventTextSize = 64;

    [NativeTypeName("#define SDL_DROPEVENT_DATA_SIZE 64")]
    public const int DropeventDataSize = 64;

    [NativeTypeName("#define SDL_GLOB_CASEINSENSITIVE (1 << 0)")]
    public const int GlobCaseinsensitive = (1 << 0);

    [NativeTypeName("#define SDL_HAPTIC_CONSTANT (1u<<0)")]
    public const uint HapticConstant = (1U << 0);

    [NativeTypeName("#define SDL_HAPTIC_SINE (1u<<1)")]
    public const uint HapticSine = (1U << 1);

    [NativeTypeName("#define SDL_HAPTIC_SQUARE (1<<2)")]
    public const int HapticSquare = (1 << 2);

    [NativeTypeName("#define SDL_HAPTIC_TRIANGLE (1u<<3)")]
    public const uint HapticTriangle = (1U << 3);

    [NativeTypeName("#define SDL_HAPTIC_SAWTOOTHUP (1u<<4)")]
    public const uint HapticSawtoothup = (1U << 4);

    [NativeTypeName("#define SDL_HAPTIC_SAWTOOTHDOWN (1u<<5)")]
    public const uint HapticSawtoothdown = (1U << 5);

    [NativeTypeName("#define SDL_HAPTIC_RAMP (1u<<6)")]
    public const uint HapticRamp = (1U << 6);

    [NativeTypeName("#define SDL_HAPTIC_SPRING (1u<<7)")]
    public const uint HapticSpring = (1U << 7);

    [NativeTypeName("#define SDL_HAPTIC_DAMPER (1u<<8)")]
    public const uint HapticDamper = (1U << 8);

    [NativeTypeName("#define SDL_HAPTIC_INERTIA (1u<<9)")]
    public const uint HapticInertia = (1U << 9);

    [NativeTypeName("#define SDL_HAPTIC_FRICTION (1u<<10)")]
    public const uint HapticFriction = (1U << 10);

    [NativeTypeName("#define SDL_HAPTIC_LEFTRIGHT (1u<<11)")]
    public const uint HapticLeftright = (1U << 11);

    [NativeTypeName("#define SDL_HAPTIC_RESERVED1 (1u<<12)")]
    public const uint HapticReserved1 = (1U << 12);

    [NativeTypeName("#define SDL_HAPTIC_RESERVED2 (1u<<13)")]
    public const uint HapticReserved2 = (1U << 13);

    [NativeTypeName("#define SDL_HAPTIC_RESERVED3 (1u<<14)")]
    public const uint HapticReserved3 = (1U << 14);

    [NativeTypeName("#define SDL_HAPTIC_CUSTOM (1u<<15)")]
    public const uint HapticCustom = (1U << 15);

    [NativeTypeName("#define SDL_HAPTIC_GAIN (1u<<16)")]
    public const uint HapticGain = (1U << 16);

    [NativeTypeName("#define SDL_HAPTIC_AUTOCENTER (1u<<17)")]
    public const uint HapticAutocenter = (1U << 17);

    [NativeTypeName("#define SDL_HAPTIC_STATUS (1u<<18)")]
    public const uint HapticStatus = (1U << 18);

    [NativeTypeName("#define SDL_HAPTIC_PAUSE (1u<<19)")]
    public const uint HapticPause = (1U << 19);

    [NativeTypeName("#define SDL_HAPTIC_POLAR 0")]
    public const int HapticPolar = 0;

    [NativeTypeName("#define SDL_HAPTIC_CARTESIAN 1")]
    public const int HapticCartesian = 1;

    [NativeTypeName("#define SDL_HAPTIC_SPHERICAL 2")]
    public const int HapticSpherical = 2;

    [NativeTypeName("#define SDL_HAPTIC_STEERING_AXIS 3")]
    public const int HapticSteeringAxis = 3;

    [NativeTypeName("#define SDL_HAPTIC_INFINITY 4294967295U")]
    public const uint HapticInfinity = 4294967295U;

    [NativeTypeName(
        "#define SDL_HINT_ALLOW_ALT_TAB_WHILE_GRABBED \"SDL_ALLOW_ALT_TAB_WHILE_GRABBED\""
    )]
    public static ReadOnlySpan<byte> HintAllowAltTabWhileGrabbed =>
        "SDL_ALLOW_ALT_TAB_WHILE_GRABBED"u8;

    [NativeTypeName(
        "#define SDL_HINT_ANDROID_ALLOW_RECREATE_ACTIVITY \"SDL_ANDROID_ALLOW_RECREATE_ACTIVITY\""
    )]
    public static ReadOnlySpan<byte> HintAndroidAllowRecreateActivity =>
        "SDL_ANDROID_ALLOW_RECREATE_ACTIVITY"u8;

    [NativeTypeName("#define SDL_HINT_ANDROID_BLOCK_ON_PAUSE \"SDL_ANDROID_BLOCK_ON_PAUSE\"")]
    public static ReadOnlySpan<byte> HintAndroidBlockOnPause => "SDL_ANDROID_BLOCK_ON_PAUSE"u8;

    [NativeTypeName(
        "#define SDL_HINT_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO \"SDL_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO\""
    )]
    public static ReadOnlySpan<byte> HintAndroidBlockOnPausePauseaudio =>
        "SDL_ANDROID_BLOCK_ON_PAUSE_PAUSEAUDIO"u8;

    [NativeTypeName("#define SDL_HINT_ANDROID_TRAP_BACK_BUTTON \"SDL_ANDROID_TRAP_BACK_BUTTON\"")]
    public static ReadOnlySpan<byte> HintAndroidTrapBackButton => "SDL_ANDROID_TRAP_BACK_BUTTON"u8;

    [NativeTypeName("#define SDL_HINT_APP_ID \"SDL_APP_ID\"")]
    public static ReadOnlySpan<byte> HintAppId => "SDL_APP_ID"u8;

    [NativeTypeName("#define SDL_HINT_APP_NAME \"SDL_APP_NAME\"")]
    public static ReadOnlySpan<byte> HintAppName => "SDL_APP_NAME"u8;

    [NativeTypeName(
        "#define SDL_HINT_APPLE_TV_CONTROLLER_UI_EVENTS \"SDL_APPLE_TV_CONTROLLER_UI_EVENTS\""
    )]
    public static ReadOnlySpan<byte> HintAppleTvControllerUiEvents =>
        "SDL_APPLE_TV_CONTROLLER_UI_EVENTS"u8;

    [NativeTypeName(
        "#define SDL_HINT_APPLE_TV_REMOTE_ALLOW_ROTATION \"SDL_APPLE_TV_REMOTE_ALLOW_ROTATION\""
    )]
    public static ReadOnlySpan<byte> HintAppleTvRemoteAllowRotation =>
        "SDL_APPLE_TV_REMOTE_ALLOW_ROTATION"u8;

    [NativeTypeName("#define SDL_HINT_AUDIO_CATEGORY \"SDL_AUDIO_CATEGORY\"")]
    public static ReadOnlySpan<byte> HintAudioCategory => "SDL_AUDIO_CATEGORY"u8;

    [NativeTypeName("#define SDL_HINT_AUDIO_DEVICE_APP_NAME \"SDL_AUDIO_DEVICE_APP_NAME\"")]
    public static ReadOnlySpan<byte> HintAudioDeviceAppName => "SDL_AUDIO_DEVICE_APP_NAME"u8;

    [NativeTypeName(
        "#define SDL_HINT_AUDIO_DEVICE_SAMPLE_FRAMES \"SDL_AUDIO_DEVICE_SAMPLE_FRAMES\""
    )]
    public static ReadOnlySpan<byte> HintAudioDeviceSampleFrames =>
        "SDL_AUDIO_DEVICE_SAMPLE_FRAMES"u8;

    [NativeTypeName("#define SDL_HINT_AUDIO_DEVICE_STREAM_NAME \"SDL_AUDIO_DEVICE_STREAM_NAME\"")]
    public static ReadOnlySpan<byte> HintAudioDeviceStreamName => "SDL_AUDIO_DEVICE_STREAM_NAME"u8;

    [NativeTypeName("#define SDL_HINT_AUDIO_DEVICE_STREAM_ROLE \"SDL_AUDIO_DEVICE_STREAM_ROLE\"")]
    public static ReadOnlySpan<byte> HintAudioDeviceStreamRole => "SDL_AUDIO_DEVICE_STREAM_ROLE"u8;

    [NativeTypeName("#define SDL_HINT_AUDIO_DRIVER \"SDL_AUDIO_DRIVER\"")]
    public static ReadOnlySpan<byte> HintAudioDriver => "SDL_AUDIO_DRIVER"u8;

    [NativeTypeName("#define SDL_HINT_AUDIO_INCLUDE_MONITORS \"SDL_AUDIO_INCLUDE_MONITORS\"")]
    public static ReadOnlySpan<byte> HintAudioIncludeMonitors => "SDL_AUDIO_INCLUDE_MONITORS"u8;

    [NativeTypeName("#define SDL_HINT_AUTO_UPDATE_JOYSTICKS \"SDL_AUTO_UPDATE_JOYSTICKS\"")]
    public static ReadOnlySpan<byte> HintAutoUpdateJoysticks => "SDL_AUTO_UPDATE_JOYSTICKS"u8;

    [NativeTypeName("#define SDL_HINT_AUTO_UPDATE_SENSORS \"SDL_AUTO_UPDATE_SENSORS\"")]
    public static ReadOnlySpan<byte> HintAutoUpdateSensors => "SDL_AUTO_UPDATE_SENSORS"u8;

    [NativeTypeName("#define SDL_HINT_BMP_SAVE_LEGACY_FORMAT \"SDL_BMP_SAVE_LEGACY_FORMAT\"")]
    public static ReadOnlySpan<byte> HintBmpSaveLegacyFormat => "SDL_BMP_SAVE_LEGACY_FORMAT"u8;

    [NativeTypeName("#define SDL_HINT_CAMERA_DRIVER \"SDL_CAMERA_DRIVER\"")]
    public static ReadOnlySpan<byte> HintCameraDriver => "SDL_CAMERA_DRIVER"u8;

    [NativeTypeName("#define SDL_HINT_CPU_FEATURE_MASK \"SDL_CPU_FEATURE_MASK\"")]
    public static ReadOnlySpan<byte> HintCpuFeatureMask => "SDL_CPU_FEATURE_MASK"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_DIRECTINPUT \"SDL_JOYSTICK_DIRECTINPUT\"")]
    public static ReadOnlySpan<byte> HintJoystickDirectinput => "SDL_JOYSTICK_DIRECTINPUT"u8;

    [NativeTypeName("#define SDL_HINT_FILE_DIALOG_DRIVER \"SDL_FILE_DIALOG_DRIVER\"")]
    public static ReadOnlySpan<byte> HintFileDialogDriver => "SDL_FILE_DIALOG_DRIVER"u8;

    [NativeTypeName("#define SDL_HINT_DISPLAY_USABLE_BOUNDS \"SDL_DISPLAY_USABLE_BOUNDS\"")]
    public static ReadOnlySpan<byte> HintDisplayUsableBounds => "SDL_DISPLAY_USABLE_BOUNDS"u8;

    [NativeTypeName("#define SDL_HINT_EMSCRIPTEN_ASYNCIFY \"SDL_EMSCRIPTEN_ASYNCIFY\"")]
    public static ReadOnlySpan<byte> HintEmscriptenAsyncify => "SDL_EMSCRIPTEN_ASYNCIFY"u8;

    [NativeTypeName(
        "#define SDL_HINT_EMSCRIPTEN_CANVAS_SELECTOR \"SDL_EMSCRIPTEN_CANVAS_SELECTOR\""
    )]
    public static ReadOnlySpan<byte> HintEmscriptenCanvasSelector =>
        "SDL_EMSCRIPTEN_CANVAS_SELECTOR"u8;

    [NativeTypeName(
        "#define SDL_HINT_EMSCRIPTEN_KEYBOARD_ELEMENT \"SDL_EMSCRIPTEN_KEYBOARD_ELEMENT\""
    )]
    public static ReadOnlySpan<byte> HintEmscriptenKeyboardElement =>
        "SDL_EMSCRIPTEN_KEYBOARD_ELEMENT"u8;

    [NativeTypeName("#define SDL_HINT_ENABLE_SCREEN_KEYBOARD \"SDL_ENABLE_SCREEN_KEYBOARD\"")]
    public static ReadOnlySpan<byte> HintEnableScreenKeyboard => "SDL_ENABLE_SCREEN_KEYBOARD"u8;

    [NativeTypeName("#define SDL_HINT_EVENT_LOGGING \"SDL_EVENT_LOGGING\"")]
    public static ReadOnlySpan<byte> HintEventLogging => "SDL_EVENT_LOGGING"u8;

    [NativeTypeName("#define SDL_HINT_FORCE_RAISEWINDOW \"SDL_FORCE_RAISEWINDOW\"")]
    public static ReadOnlySpan<byte> HintForceRaisewindow => "SDL_FORCE_RAISEWINDOW"u8;

    [NativeTypeName("#define SDL_HINT_FRAMEBUFFER_ACCELERATION \"SDL_FRAMEBUFFER_ACCELERATION\"")]
    public static ReadOnlySpan<byte> HintFramebufferAcceleration =>
        "SDL_FRAMEBUFFER_ACCELERATION"u8;

    [NativeTypeName("#define SDL_HINT_GAMECONTROLLERCONFIG \"SDL_GAMECONTROLLERCONFIG\"")]
    public static ReadOnlySpan<byte> HintGamecontrollerconfig => "SDL_GAMECONTROLLERCONFIG"u8;

    [NativeTypeName("#define SDL_HINT_GAMECONTROLLERCONFIG_FILE \"SDL_GAMECONTROLLERCONFIG_FILE\"")]
    public static ReadOnlySpan<byte> HintGamecontrollerconfigFile =>
        "SDL_GAMECONTROLLERCONFIG_FILE"u8;

    [NativeTypeName("#define SDL_HINT_GAMECONTROLLERTYPE \"SDL_GAMECONTROLLERTYPE\"")]
    public static ReadOnlySpan<byte> HintGamecontrollertype => "SDL_GAMECONTROLLERTYPE"u8;

    [NativeTypeName(
        "#define SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES \"SDL_GAMECONTROLLER_IGNORE_DEVICES\""
    )]
    public static ReadOnlySpan<byte> HintGamecontrollerIgnoreDevices =>
        "SDL_GAMECONTROLLER_IGNORE_DEVICES"u8;

    [NativeTypeName(
        "#define SDL_HINT_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT \"SDL_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT\""
    )]
    public static ReadOnlySpan<byte> HintGamecontrollerIgnoreDevicesExcept =>
        "SDL_GAMECONTROLLER_IGNORE_DEVICES_EXCEPT"u8;

    [NativeTypeName(
        "#define SDL_HINT_GAMECONTROLLER_SENSOR_FUSION \"SDL_GAMECONTROLLER_SENSOR_FUSION\""
    )]
    public static ReadOnlySpan<byte> HintGamecontrollerSensorFusion =>
        "SDL_GAMECONTROLLER_SENSOR_FUSION"u8;

    [NativeTypeName(
        "#define SDL_HINT_GDK_TEXTINPUT_DEFAULT_TEXT \"SDL_GDK_TEXTINPUT_DEFAULT_TEXT\""
    )]
    public static ReadOnlySpan<byte> HintGdkTextinputDefaultText =>
        "SDL_GDK_TEXTINPUT_DEFAULT_TEXT"u8;

    [NativeTypeName("#define SDL_HINT_GDK_TEXTINPUT_DESCRIPTION \"SDL_GDK_TEXTINPUT_DESCRIPTION\"")]
    public static ReadOnlySpan<byte> HintGdkTextinputDescription =>
        "SDL_GDK_TEXTINPUT_DESCRIPTION"u8;

    [NativeTypeName("#define SDL_HINT_GDK_TEXTINPUT_MAX_LENGTH \"SDL_GDK_TEXTINPUT_MAX_LENGTH\"")]
    public static ReadOnlySpan<byte> HintGdkTextinputMaxLength => "SDL_GDK_TEXTINPUT_MAX_LENGTH"u8;

    [NativeTypeName("#define SDL_HINT_GDK_TEXTINPUT_SCOPE \"SDL_GDK_TEXTINPUT_SCOPE\"")]
    public static ReadOnlySpan<byte> HintGdkTextinputScope => "SDL_GDK_TEXTINPUT_SCOPE"u8;

    [NativeTypeName("#define SDL_HINT_GDK_TEXTINPUT_TITLE \"SDL_GDK_TEXTINPUT_TITLE\"")]
    public static ReadOnlySpan<byte> HintGdkTextinputTitle => "SDL_GDK_TEXTINPUT_TITLE"u8;

    [NativeTypeName(
        "#define SDL_HINT_HIDAPI_ENUMERATE_ONLY_CONTROLLERS \"SDL_HIDAPI_ENUMERATE_ONLY_CONTROLLERS\""
    )]
    public static ReadOnlySpan<byte> HintHidapiEnumerateOnlyControllers =>
        "SDL_HIDAPI_ENUMERATE_ONLY_CONTROLLERS"u8;

    [NativeTypeName("#define SDL_HINT_HIDAPI_IGNORE_DEVICES \"SDL_HIDAPI_IGNORE_DEVICES\"")]
    public static ReadOnlySpan<byte> HintHidapiIgnoreDevices => "SDL_HIDAPI_IGNORE_DEVICES"u8;

    [NativeTypeName("#define SDL_HINT_IME_INTERNAL_EDITING \"SDL_IME_INTERNAL_EDITING\"")]
    public static ReadOnlySpan<byte> HintImeInternalEditing => "SDL_IME_INTERNAL_EDITING"u8;

    [NativeTypeName("#define SDL_HINT_IME_SHOW_UI \"SDL_IME_SHOW_UI\"")]
    public static ReadOnlySpan<byte> HintImeShowUi => "SDL_IME_SHOW_UI"u8;

    [NativeTypeName("#define SDL_HINT_IOS_HIDE_HOME_INDICATOR \"SDL_IOS_HIDE_HOME_INDICATOR\"")]
    public static ReadOnlySpan<byte> HintIosHideHomeIndicator => "SDL_IOS_HIDE_HOME_INDICATOR"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_ALLOW_BACKGROUND_EVENTS \"SDL_JOYSTICK_ALLOW_BACKGROUND_EVENTS\""
    )]
    public static ReadOnlySpan<byte> HintJoystickAllowBackgroundEvents =>
        "SDL_JOYSTICK_ALLOW_BACKGROUND_EVENTS"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_ARCADESTICK_DEVICES \"SDL_JOYSTICK_ARCADESTICK_DEVICES\""
    )]
    public static ReadOnlySpan<byte> HintJoystickArcadestickDevices =>
        "SDL_JOYSTICK_ARCADESTICK_DEVICES"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_ARCADESTICK_DEVICES_EXCLUDED \"SDL_JOYSTICK_ARCADESTICK_DEVICES_EXCLUDED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickArcadestickDevicesExcluded =>
        "SDL_JOYSTICK_ARCADESTICK_DEVICES_EXCLUDED"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_BLACKLIST_DEVICES \"SDL_JOYSTICK_BLACKLIST_DEVICES\""
    )]
    public static ReadOnlySpan<byte> HintJoystickBlacklistDevices =>
        "SDL_JOYSTICK_BLACKLIST_DEVICES"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_BLACKLIST_DEVICES_EXCLUDED \"SDL_JOYSTICK_BLACKLIST_DEVICES_EXCLUDED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickBlacklistDevicesExcluded =>
        "SDL_JOYSTICK_BLACKLIST_DEVICES_EXCLUDED"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_DEVICE \"SDL_JOYSTICK_DEVICE\"")]
    public static ReadOnlySpan<byte> HintJoystickDevice => "SDL_JOYSTICK_DEVICE"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_FLIGHTSTICK_DEVICES \"SDL_JOYSTICK_FLIGHTSTICK_DEVICES\""
    )]
    public static ReadOnlySpan<byte> HintJoystickFlightstickDevices =>
        "SDL_JOYSTICK_FLIGHTSTICK_DEVICES"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_FLIGHTSTICK_DEVICES_EXCLUDED \"SDL_JOYSTICK_FLIGHTSTICK_DEVICES_EXCLUDED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickFlightstickDevicesExcluded =>
        "SDL_JOYSTICK_FLIGHTSTICK_DEVICES_EXCLUDED"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_GAMECUBE_DEVICES \"SDL_JOYSTICK_GAMECUBE_DEVICES\"")]
    public static ReadOnlySpan<byte> HintJoystickGamecubeDevices =>
        "SDL_JOYSTICK_GAMECUBE_DEVICES"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_GAMECUBE_DEVICES_EXCLUDED \"SDL_JOYSTICK_GAMECUBE_DEVICES_EXCLUDED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickGamecubeDevicesExcluded =>
        "SDL_JOYSTICK_GAMECUBE_DEVICES_EXCLUDED"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI \"SDL_JOYSTICK_HIDAPI\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapi => "SDL_JOYSTICK_HIDAPI"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_COMBINE_JOY_CONS \"SDL_JOYSTICK_HIDAPI_COMBINE_JOY_CONS\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiCombineJoyCons =>
        "SDL_JOYSTICK_HIDAPI_COMBINE_JOY_CONS"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_GAMECUBE \"SDL_JOYSTICK_HIDAPI_GAMECUBE\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiGamecube => "SDL_JOYSTICK_HIDAPI_GAMECUBE"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_GAMECUBE_RUMBLE_BRAKE \"SDL_JOYSTICK_HIDAPI_GAMECUBE_RUMBLE_BRAKE\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiGamecubeRumbleBrake =>
        "SDL_JOYSTICK_HIDAPI_GAMECUBE_RUMBLE_BRAKE"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_JOY_CONS \"SDL_JOYSTICK_HIDAPI_JOY_CONS\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiJoyCons => "SDL_JOYSTICK_HIDAPI_JOY_CONS"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_JOYCON_HOME_LED \"SDL_JOYSTICK_HIDAPI_JOYCON_HOME_LED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiJoyconHomeLed =>
        "SDL_JOYSTICK_HIDAPI_JOYCON_HOME_LED"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_LUNA \"SDL_JOYSTICK_HIDAPI_LUNA\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiLuna => "SDL_JOYSTICK_HIDAPI_LUNA"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_NINTENDO_CLASSIC \"SDL_JOYSTICK_HIDAPI_NINTENDO_CLASSIC\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiNintendoClassic =>
        "SDL_JOYSTICK_HIDAPI_NINTENDO_CLASSIC"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_PS3 \"SDL_JOYSTICK_HIDAPI_PS3\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiPs3 => "SDL_JOYSTICK_HIDAPI_PS3"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_PS3_SIXAXIS_DRIVER \"SDL_JOYSTICK_HIDAPI_PS3_SIXAXIS_DRIVER\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiPs3SixaxisDriver =>
        "SDL_JOYSTICK_HIDAPI_PS3_SIXAXIS_DRIVER"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_PS4 \"SDL_JOYSTICK_HIDAPI_PS4\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiPs4 => "SDL_JOYSTICK_HIDAPI_PS4"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_PS4_RUMBLE \"SDL_JOYSTICK_HIDAPI_PS4_RUMBLE\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiPs4Rumble =>
        "SDL_JOYSTICK_HIDAPI_PS4_RUMBLE"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_PS5 \"SDL_JOYSTICK_HIDAPI_PS5\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiPs5 => "SDL_JOYSTICK_HIDAPI_PS5"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_PS5_PLAYER_LED \"SDL_JOYSTICK_HIDAPI_PS5_PLAYER_LED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiPs5PlayerLed =>
        "SDL_JOYSTICK_HIDAPI_PS5_PLAYER_LED"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_PS5_RUMBLE \"SDL_JOYSTICK_HIDAPI_PS5_RUMBLE\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiPs5Rumble =>
        "SDL_JOYSTICK_HIDAPI_PS5_RUMBLE"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_SHIELD \"SDL_JOYSTICK_HIDAPI_SHIELD\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiShield => "SDL_JOYSTICK_HIDAPI_SHIELD"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_STADIA \"SDL_JOYSTICK_HIDAPI_STADIA\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiStadia => "SDL_JOYSTICK_HIDAPI_STADIA"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_STEAM \"SDL_JOYSTICK_HIDAPI_STEAM\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiSteam => "SDL_JOYSTICK_HIDAPI_STEAM"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_STEAMDECK \"SDL_JOYSTICK_HIDAPI_STEAMDECK\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiSteamdeck =>
        "SDL_JOYSTICK_HIDAPI_STEAMDECK"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_SWITCH \"SDL_JOYSTICK_HIDAPI_SWITCH\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiSwitch => "SDL_JOYSTICK_HIDAPI_SWITCH"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_SWITCH_HOME_LED \"SDL_JOYSTICK_HIDAPI_SWITCH_HOME_LED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiSwitchHomeLed =>
        "SDL_JOYSTICK_HIDAPI_SWITCH_HOME_LED"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED \"SDL_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiSwitchPlayerLed =>
        "SDL_JOYSTICK_HIDAPI_SWITCH_PLAYER_LED"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS \"SDL_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiVerticalJoyCons =>
        "SDL_JOYSTICK_HIDAPI_VERTICAL_JOY_CONS"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_WII \"SDL_JOYSTICK_HIDAPI_WII\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiWii => "SDL_JOYSTICK_HIDAPI_WII"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_WII_PLAYER_LED \"SDL_JOYSTICK_HIDAPI_WII_PLAYER_LED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiWiiPlayerLed =>
        "SDL_JOYSTICK_HIDAPI_WII_PLAYER_LED"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_XBOX \"SDL_JOYSTICK_HIDAPI_XBOX\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiXbox => "SDL_JOYSTICK_HIDAPI_XBOX"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_XBOX_360 \"SDL_JOYSTICK_HIDAPI_XBOX_360\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiXbox360 => "SDL_JOYSTICK_HIDAPI_XBOX_360"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED \"SDL_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiXbox360PlayerLed =>
        "SDL_JOYSTICK_HIDAPI_XBOX_360_PLAYER_LED"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_XBOX_360_WIRELESS \"SDL_JOYSTICK_HIDAPI_XBOX_360_WIRELESS\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiXbox360Wireless =>
        "SDL_JOYSTICK_HIDAPI_XBOX_360_WIRELESS"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_HIDAPI_XBOX_ONE \"SDL_JOYSTICK_HIDAPI_XBOX_ONE\"")]
    public static ReadOnlySpan<byte> HintJoystickHidapiXboxOne => "SDL_JOYSTICK_HIDAPI_XBOX_ONE"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED \"SDL_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickHidapiXboxOneHomeLed =>
        "SDL_JOYSTICK_HIDAPI_XBOX_ONE_HOME_LED"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_IOKIT \"SDL_JOYSTICK_IOKIT\"")]
    public static ReadOnlySpan<byte> HintJoystickIokit => "SDL_JOYSTICK_IOKIT"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_LINUX_CLASSIC \"SDL_JOYSTICK_LINUX_CLASSIC\"")]
    public static ReadOnlySpan<byte> HintJoystickLinuxClassic => "SDL_JOYSTICK_LINUX_CLASSIC"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_LINUX_DEADZONES \"SDL_JOYSTICK_LINUX_DEADZONES\"")]
    public static ReadOnlySpan<byte> HintJoystickLinuxDeadzones => "SDL_JOYSTICK_LINUX_DEADZONES"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_LINUX_DIGITAL_HATS \"SDL_JOYSTICK_LINUX_DIGITAL_HATS\""
    )]
    public static ReadOnlySpan<byte> HintJoystickLinuxDigitalHats =>
        "SDL_JOYSTICK_LINUX_DIGITAL_HATS"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_LINUX_HAT_DEADZONES \"SDL_JOYSTICK_LINUX_HAT_DEADZONES\""
    )]
    public static ReadOnlySpan<byte> HintJoystickLinuxHatDeadzones =>
        "SDL_JOYSTICK_LINUX_HAT_DEADZONES"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_MFI \"SDL_JOYSTICK_MFI\"")]
    public static ReadOnlySpan<byte> HintJoystickMfi => "SDL_JOYSTICK_MFI"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_RAWINPUT \"SDL_JOYSTICK_RAWINPUT\"")]
    public static ReadOnlySpan<byte> HintJoystickRawinput => "SDL_JOYSTICK_RAWINPUT"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_RAWINPUT_CORRELATE_XINPUT \"SDL_JOYSTICK_RAWINPUT_CORRELATE_XINPUT\""
    )]
    public static ReadOnlySpan<byte> HintJoystickRawinputCorrelateXinput =>
        "SDL_JOYSTICK_RAWINPUT_CORRELATE_XINPUT"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_ROG_CHAKRAM \"SDL_JOYSTICK_ROG_CHAKRAM\"")]
    public static ReadOnlySpan<byte> HintJoystickRogChakram => "SDL_JOYSTICK_ROG_CHAKRAM"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_THREAD \"SDL_JOYSTICK_THREAD\"")]
    public static ReadOnlySpan<byte> HintJoystickThread => "SDL_JOYSTICK_THREAD"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_THROTTLE_DEVICES \"SDL_JOYSTICK_THROTTLE_DEVICES\"")]
    public static ReadOnlySpan<byte> HintJoystickThrottleDevices =>
        "SDL_JOYSTICK_THROTTLE_DEVICES"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_THROTTLE_DEVICES_EXCLUDED \"SDL_JOYSTICK_THROTTLE_DEVICES_EXCLUDED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickThrottleDevicesExcluded =>
        "SDL_JOYSTICK_THROTTLE_DEVICES_EXCLUDED"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_WGI \"SDL_JOYSTICK_WGI\"")]
    public static ReadOnlySpan<byte> HintJoystickWgi => "SDL_JOYSTICK_WGI"u8;

    [NativeTypeName("#define SDL_HINT_JOYSTICK_WHEEL_DEVICES \"SDL_JOYSTICK_WHEEL_DEVICES\"")]
    public static ReadOnlySpan<byte> HintJoystickWheelDevices => "SDL_JOYSTICK_WHEEL_DEVICES"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_WHEEL_DEVICES_EXCLUDED \"SDL_JOYSTICK_WHEEL_DEVICES_EXCLUDED\""
    )]
    public static ReadOnlySpan<byte> HintJoystickWheelDevicesExcluded =>
        "SDL_JOYSTICK_WHEEL_DEVICES_EXCLUDED"u8;

    [NativeTypeName(
        "#define SDL_HINT_JOYSTICK_ZERO_CENTERED_DEVICES \"SDL_JOYSTICK_ZERO_CENTERED_DEVICES\""
    )]
    public static ReadOnlySpan<byte> HintJoystickZeroCenteredDevices =>
        "SDL_JOYSTICK_ZERO_CENTERED_DEVICES"u8;

    [NativeTypeName("#define SDL_HINT_KMSDRM_DEVICE_INDEX \"SDL_KMSDRM_DEVICE_INDEX\"")]
    public static ReadOnlySpan<byte> HintKmsdrmDeviceIndex => "SDL_KMSDRM_DEVICE_INDEX"u8;

    [NativeTypeName("#define SDL_HINT_KMSDRM_REQUIRE_DRM_MASTER \"SDL_KMSDRM_REQUIRE_DRM_MASTER\"")]
    public static ReadOnlySpan<byte> HintKmsdrmRequireDrmMaster =>
        "SDL_KMSDRM_REQUIRE_DRM_MASTER"u8;

    [NativeTypeName("#define SDL_HINT_LOGGING \"SDL_LOGGING\"")]
    public static ReadOnlySpan<byte> HintLogging => "SDL_LOGGING"u8;

    [NativeTypeName("#define SDL_HINT_MAC_BACKGROUND_APP \"SDL_MAC_BACKGROUND_APP\"")]
    public static ReadOnlySpan<byte> HintMacBackgroundApp => "SDL_MAC_BACKGROUND_APP"u8;

    [NativeTypeName(
        "#define SDL_HINT_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK \"SDL_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK\""
    )]
    public static ReadOnlySpan<byte> HintMacCtrlClickEmulateRightClick =>
        "SDL_MAC_CTRL_CLICK_EMULATE_RIGHT_CLICK"u8;

    [NativeTypeName("#define SDL_HINT_MAC_OPENGL_ASYNC_DISPATCH \"SDL_MAC_OPENGL_ASYNC_DISPATCH\"")]
    public static ReadOnlySpan<byte> HintMacOpenglAsyncDispatch =>
        "SDL_MAC_OPENGL_ASYNC_DISPATCH"u8;

    [NativeTypeName("#define SDL_HINT_MAIN_CALLBACK_RATE \"SDL_MAIN_CALLBACK_RATE\"")]
    public static ReadOnlySpan<byte> HintMainCallbackRate => "SDL_MAIN_CALLBACK_RATE"u8;

    [NativeTypeName("#define SDL_HINT_MOUSE_AUTO_CAPTURE \"SDL_MOUSE_AUTO_CAPTURE\"")]
    public static ReadOnlySpan<byte> HintMouseAutoCapture => "SDL_MOUSE_AUTO_CAPTURE"u8;

    [NativeTypeName("#define SDL_HINT_MOUSE_DOUBLE_CLICK_RADIUS \"SDL_MOUSE_DOUBLE_CLICK_RADIUS\"")]
    public static ReadOnlySpan<byte> HintMouseDoubleClickRadius =>
        "SDL_MOUSE_DOUBLE_CLICK_RADIUS"u8;

    [NativeTypeName("#define SDL_HINT_MOUSE_DOUBLE_CLICK_TIME \"SDL_MOUSE_DOUBLE_CLICK_TIME\"")]
    public static ReadOnlySpan<byte> HintMouseDoubleClickTime => "SDL_MOUSE_DOUBLE_CLICK_TIME"u8;

    [NativeTypeName("#define SDL_HINT_MOUSE_FOCUS_CLICKTHROUGH \"SDL_MOUSE_FOCUS_CLICKTHROUGH\"")]
    public static ReadOnlySpan<byte> HintMouseFocusClickthrough => "SDL_MOUSE_FOCUS_CLICKTHROUGH"u8;

    [NativeTypeName("#define SDL_HINT_MOUSE_NORMAL_SPEED_SCALE \"SDL_MOUSE_NORMAL_SPEED_SCALE\"")]
    public static ReadOnlySpan<byte> HintMouseNormalSpeedScale => "SDL_MOUSE_NORMAL_SPEED_SCALE"u8;

    [NativeTypeName(
        "#define SDL_HINT_MOUSE_RELATIVE_MODE_CENTER \"SDL_MOUSE_RELATIVE_MODE_CENTER\""
    )]
    public static ReadOnlySpan<byte> HintMouseRelativeModeCenter =>
        "SDL_MOUSE_RELATIVE_MODE_CENTER"u8;

    [NativeTypeName("#define SDL_HINT_MOUSE_RELATIVE_MODE_WARP \"SDL_MOUSE_RELATIVE_MODE_WARP\"")]
    public static ReadOnlySpan<byte> HintMouseRelativeModeWarp => "SDL_MOUSE_RELATIVE_MODE_WARP"u8;

    [NativeTypeName(
        "#define SDL_HINT_MOUSE_RELATIVE_SPEED_SCALE \"SDL_MOUSE_RELATIVE_SPEED_SCALE\""
    )]
    public static ReadOnlySpan<byte> HintMouseRelativeSpeedScale =>
        "SDL_MOUSE_RELATIVE_SPEED_SCALE"u8;

    [NativeTypeName(
        "#define SDL_HINT_MOUSE_RELATIVE_SYSTEM_SCALE \"SDL_MOUSE_RELATIVE_SYSTEM_SCALE\""
    )]
    public static ReadOnlySpan<byte> HintMouseRelativeSystemScale =>
        "SDL_MOUSE_RELATIVE_SYSTEM_SCALE"u8;

    [NativeTypeName(
        "#define SDL_HINT_MOUSE_RELATIVE_WARP_MOTION \"SDL_MOUSE_RELATIVE_WARP_MOTION\""
    )]
    public static ReadOnlySpan<byte> HintMouseRelativeWarpMotion =>
        "SDL_MOUSE_RELATIVE_WARP_MOTION"u8;

    [NativeTypeName("#define SDL_HINT_MOUSE_TOUCH_EVENTS \"SDL_MOUSE_TOUCH_EVENTS\"")]
    public static ReadOnlySpan<byte> HintMouseTouchEvents => "SDL_MOUSE_TOUCH_EVENTS"u8;

    [NativeTypeName("#define SDL_HINT_NO_SIGNAL_HANDLERS \"SDL_NO_SIGNAL_HANDLERS\"")]
    public static ReadOnlySpan<byte> HintNoSignalHandlers => "SDL_NO_SIGNAL_HANDLERS"u8;

    [NativeTypeName("#define SDL_HINT_OPENGL_ES_DRIVER \"SDL_OPENGL_ES_DRIVER\"")]
    public static ReadOnlySpan<byte> HintOpenglEsDriver => "SDL_OPENGL_ES_DRIVER"u8;

    [NativeTypeName("#define SDL_HINT_ORIENTATIONS \"SDL_IOS_ORIENTATIONS\"")]
    public static ReadOnlySpan<byte> HintOrientations => "SDL_IOS_ORIENTATIONS"u8;

    [NativeTypeName("#define SDL_HINT_PEN_DELAY_MOUSE_BUTTON \"SDL_PEN_DELAY_MOUSE_BUTTON\"")]
    public static ReadOnlySpan<byte> HintPenDelayMouseButton => "SDL_PEN_DELAY_MOUSE_BUTTON"u8;

    [NativeTypeName("#define SDL_HINT_PEN_NOT_MOUSE \"SDL_PEN_NOT_MOUSE\"")]
    public static ReadOnlySpan<byte> HintPenNotMouse => "SDL_PEN_NOT_MOUSE"u8;

    [NativeTypeName("#define SDL_HINT_POLL_SENTINEL \"SDL_POLL_SENTINEL\"")]
    public static ReadOnlySpan<byte> HintPollSentinel => "SDL_POLL_SENTINEL"u8;

    [NativeTypeName("#define SDL_HINT_PREFERRED_LOCALES \"SDL_PREFERRED_LOCALES\"")]
    public static ReadOnlySpan<byte> HintPreferredLocales => "SDL_PREFERRED_LOCALES"u8;

    [NativeTypeName("#define SDL_HINT_QUIT_ON_LAST_WINDOW_CLOSE \"SDL_QUIT_ON_LAST_WINDOW_CLOSE\"")]
    public static ReadOnlySpan<byte> HintQuitOnLastWindowClose => "SDL_QUIT_ON_LAST_WINDOW_CLOSE"u8;

    [NativeTypeName(
        "#define SDL_HINT_RENDER_DIRECT3D_THREADSAFE \"SDL_RENDER_DIRECT3D_THREADSAFE\""
    )]
    public static ReadOnlySpan<byte> HintRenderDirect3DThreadsafe =>
        "SDL_RENDER_DIRECT3D_THREADSAFE"u8;

    [NativeTypeName("#define SDL_HINT_RENDER_DIRECT3D11_DEBUG \"SDL_RENDER_DIRECT3D11_DEBUG\"")]
    public static ReadOnlySpan<byte> HintRenderDirect3D11Debug => "SDL_RENDER_DIRECT3D11_DEBUG"u8;

    [NativeTypeName("#define SDL_HINT_RENDER_VULKAN_DEBUG \"SDL_RENDER_VULKAN_DEBUG\"")]
    public static ReadOnlySpan<byte> HintRenderVulkanDebug => "SDL_RENDER_VULKAN_DEBUG"u8;

    [NativeTypeName("#define SDL_HINT_RENDER_DRIVER \"SDL_RENDER_DRIVER\"")]
    public static ReadOnlySpan<byte> HintRenderDriver => "SDL_RENDER_DRIVER"u8;

    [NativeTypeName("#define SDL_HINT_RENDER_LINE_METHOD \"SDL_RENDER_LINE_METHOD\"")]
    public static ReadOnlySpan<byte> HintRenderLineMethod => "SDL_RENDER_LINE_METHOD"u8;

    [NativeTypeName(
        "#define SDL_HINT_RENDER_METAL_PREFER_LOW_POWER_DEVICE \"SDL_RENDER_METAL_PREFER_LOW_POWER_DEVICE\""
    )]
    public static ReadOnlySpan<byte> HintRenderMetalPreferLowPowerDevice =>
        "SDL_RENDER_METAL_PREFER_LOW_POWER_DEVICE"u8;

    [NativeTypeName("#define SDL_HINT_RENDER_PS2_DYNAMIC_VSYNC \"SDL_RENDER_PS2_DYNAMIC_VSYNC\"")]
    public static ReadOnlySpan<byte> HintRenderPs2DynamicVsync => "SDL_RENDER_PS2_DYNAMIC_VSYNC"u8;

    [NativeTypeName("#define SDL_HINT_RENDER_VSYNC \"SDL_RENDER_VSYNC\"")]
    public static ReadOnlySpan<byte> HintRenderVsync => "SDL_RENDER_VSYNC"u8;

    [NativeTypeName("#define SDL_HINT_RETURN_KEY_HIDES_IME \"SDL_RETURN_KEY_HIDES_IME\"")]
    public static ReadOnlySpan<byte> HintReturnKeyHidesIme => "SDL_RETURN_KEY_HIDES_IME"u8;

    [NativeTypeName("#define SDL_HINT_ROG_GAMEPAD_MICE \"SDL_ROG_GAMEPAD_MICE\"")]
    public static ReadOnlySpan<byte> HintRogGamepadMice => "SDL_ROG_GAMEPAD_MICE"u8;

    [NativeTypeName("#define SDL_HINT_ROG_GAMEPAD_MICE_EXCLUDED \"SDL_ROG_GAMEPAD_MICE_EXCLUDED\"")]
    public static ReadOnlySpan<byte> HintRogGamepadMiceExcluded =>
        "SDL_ROG_GAMEPAD_MICE_EXCLUDED"u8;

    [NativeTypeName("#define SDL_HINT_RPI_VIDEO_LAYER \"SDL_RPI_VIDEO_LAYER\"")]
    public static ReadOnlySpan<byte> HintRpiVideoLayer => "SDL_RPI_VIDEO_LAYER"u8;

    [NativeTypeName(
        "#define SDL_HINT_SCREENSAVER_INHIBIT_ACTIVITY_NAME \"SDL_SCREENSAVER_INHIBIT_ACTIVITY_NAME\""
    )]
    public static ReadOnlySpan<byte> HintScreensaverInhibitActivityName =>
        "SDL_SCREENSAVER_INHIBIT_ACTIVITY_NAME"u8;

    [NativeTypeName("#define SDL_HINT_SHUTDOWN_DBUS_ON_QUIT \"SDL_SHUTDOWN_DBUS_ON_QUIT\"")]
    public static ReadOnlySpan<byte> HintShutdownDbusOnQuit => "SDL_SHUTDOWN_DBUS_ON_QUIT"u8;

    [NativeTypeName("#define SDL_HINT_STORAGE_TITLE_DRIVER \"SDL_STORAGE_TITLE_DRIVER\"")]
    public static ReadOnlySpan<byte> HintStorageTitleDriver => "SDL_STORAGE_TITLE_DRIVER"u8;

    [NativeTypeName("#define SDL_HINT_STORAGE_USER_DRIVER \"SDL_STORAGE_USER_DRIVER\"")]
    public static ReadOnlySpan<byte> HintStorageUserDriver => "SDL_STORAGE_USER_DRIVER"u8;

    [NativeTypeName(
        "#define SDL_HINT_THREAD_FORCE_REALTIME_TIME_CRITICAL \"SDL_THREAD_FORCE_REALTIME_TIME_CRITICAL\""
    )]
    public static ReadOnlySpan<byte> HintThreadForceRealtimeTimeCritical =>
        "SDL_THREAD_FORCE_REALTIME_TIME_CRITICAL"u8;

    [NativeTypeName("#define SDL_HINT_THREAD_PRIORITY_POLICY \"SDL_THREAD_PRIORITY_POLICY\"")]
    public static ReadOnlySpan<byte> HintThreadPriorityPolicy => "SDL_THREAD_PRIORITY_POLICY"u8;

    [NativeTypeName("#define SDL_HINT_TIMER_RESOLUTION \"SDL_TIMER_RESOLUTION\"")]
    public static ReadOnlySpan<byte> HintTimerResolution => "SDL_TIMER_RESOLUTION"u8;

    [NativeTypeName("#define SDL_HINT_TOUCH_MOUSE_EVENTS \"SDL_TOUCH_MOUSE_EVENTS\"")]
    public static ReadOnlySpan<byte> HintTouchMouseEvents => "SDL_TOUCH_MOUSE_EVENTS"u8;

    [NativeTypeName("#define SDL_HINT_TRACKPAD_IS_TOUCH_ONLY \"SDL_TRACKPAD_IS_TOUCH_ONLY\"")]
    public static ReadOnlySpan<byte> HintTrackpadIsTouchOnly => "SDL_TRACKPAD_IS_TOUCH_ONLY"u8;

    [NativeTypeName("#define SDL_HINT_TV_REMOTE_AS_JOYSTICK \"SDL_TV_REMOTE_AS_JOYSTICK\"")]
    public static ReadOnlySpan<byte> HintTvRemoteAsJoystick => "SDL_TV_REMOTE_AS_JOYSTICK"u8;

    [NativeTypeName("#define SDL_HINT_VIDEO_ALLOW_SCREENSAVER \"SDL_VIDEO_ALLOW_SCREENSAVER\"")]
    public static ReadOnlySpan<byte> HintVideoAllowScreensaver => "SDL_VIDEO_ALLOW_SCREENSAVER"u8;

    [NativeTypeName("#define SDL_HINT_VIDEO_DOUBLE_BUFFER \"SDL_VIDEO_DOUBLE_BUFFER\"")]
    public static ReadOnlySpan<byte> HintVideoDoubleBuffer => "SDL_VIDEO_DOUBLE_BUFFER"u8;

    [NativeTypeName("#define SDL_HINT_VIDEO_DRIVER \"SDL_VIDEO_DRIVER\"")]
    public static ReadOnlySpan<byte> HintVideoDriver => "SDL_VIDEO_DRIVER"u8;

    [NativeTypeName(
        "#define SDL_HINT_VIDEO_EGL_ALLOW_GETDISPLAY_FALLBACK \"SDL_VIDEO_EGL_GETDISPLAY_FALLBACK\""
    )]
    public static ReadOnlySpan<byte> HintVideoEglAllowGetdisplayFallback =>
        "SDL_VIDEO_EGL_GETDISPLAY_FALLBACK"u8;

    [NativeTypeName("#define SDL_HINT_VIDEO_FORCE_EGL \"SDL_VIDEO_FORCE_EGL\"")]
    public static ReadOnlySpan<byte> HintVideoForceEgl => "SDL_VIDEO_FORCE_EGL"u8;

    [NativeTypeName(
        "#define SDL_HINT_VIDEO_MAC_FULLSCREEN_SPACES \"SDL_VIDEO_MAC_FULLSCREEN_SPACES\""
    )]
    public static ReadOnlySpan<byte> HintVideoMacFullscreenSpaces =>
        "SDL_VIDEO_MAC_FULLSCREEN_SPACES"u8;

    [NativeTypeName(
        "#define SDL_HINT_VIDEO_MINIMIZE_ON_FOCUS_LOSS \"SDL_VIDEO_MINIMIZE_ON_FOCUS_LOSS\""
    )]
    public static ReadOnlySpan<byte> HintVideoMinimizeOnFocusLoss =>
        "SDL_VIDEO_MINIMIZE_ON_FOCUS_LOSS"u8;

    [NativeTypeName(
        "#define SDL_HINT_VIDEO_SYNC_WINDOW_OPERATIONS \"SDL_VIDEO_SYNC_WINDOW_OPERATIONS\""
    )]
    public static ReadOnlySpan<byte> HintVideoSyncWindowOperations =>
        "SDL_VIDEO_SYNC_WINDOW_OPERATIONS"u8;

    [NativeTypeName(
        "#define SDL_HINT_VIDEO_WAYLAND_ALLOW_LIBDECOR \"SDL_VIDEO_WAYLAND_ALLOW_LIBDECOR\""
    )]
    public static ReadOnlySpan<byte> HintVideoWaylandAllowLibdecor =>
        "SDL_VIDEO_WAYLAND_ALLOW_LIBDECOR"u8;

    [NativeTypeName(
        "#define SDL_HINT_VIDEO_WAYLAND_EMULATE_MOUSE_WARP \"SDL_VIDEO_WAYLAND_EMULATE_MOUSE_WARP\""
    )]
    public static ReadOnlySpan<byte> HintVideoWaylandEmulateMouseWarp =>
        "SDL_VIDEO_WAYLAND_EMULATE_MOUSE_WARP"u8;

    [NativeTypeName(
        "#define SDL_HINT_VIDEO_WAYLAND_MODE_EMULATION \"SDL_VIDEO_WAYLAND_MODE_EMULATION\""
    )]
    public static ReadOnlySpan<byte> HintVideoWaylandModeEmulation =>
        "SDL_VIDEO_WAYLAND_MODE_EMULATION"u8;

    [NativeTypeName(
        "#define SDL_HINT_VIDEO_WAYLAND_MODE_SCALING \"SDL_VIDEO_WAYLAND_MODE_SCALING\""
    )]
    public static ReadOnlySpan<byte> HintVideoWaylandModeScaling =>
        "SDL_VIDEO_WAYLAND_MODE_SCALING"u8;

    [NativeTypeName(
        "#define SDL_HINT_VIDEO_WAYLAND_PREFER_LIBDECOR \"SDL_VIDEO_WAYLAND_PREFER_LIBDECOR\""
    )]
    public static ReadOnlySpan<byte> HintVideoWaylandPreferLibdecor =>
        "SDL_VIDEO_WAYLAND_PREFER_LIBDECOR"u8;

    [NativeTypeName(
        "#define SDL_HINT_VIDEO_WAYLAND_SCALE_TO_DISPLAY \"SDL_VIDEO_WAYLAND_SCALE_TO_DISPLAY\""
    )]
    public static ReadOnlySpan<byte> HintVideoWaylandScaleToDisplay =>
        "SDL_VIDEO_WAYLAND_SCALE_TO_DISPLAY"u8;

    [NativeTypeName("#define SDL_HINT_VIDEO_WIN_D3DCOMPILER \"SDL_VIDEO_WIN_D3DCOMPILER\"")]
    public static ReadOnlySpan<byte> HintVideoWinD3Dcompiler => "SDL_VIDEO_WIN_D3DCOMPILER"u8;

    [NativeTypeName(
        "#define SDL_HINT_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR \"SDL_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR\""
    )]
    public static ReadOnlySpan<byte> HintVideoX11NetWmBypassCompositor =>
        "SDL_VIDEO_X11_NET_WM_BYPASS_COMPOSITOR"u8;

    [NativeTypeName("#define SDL_HINT_VIDEO_X11_NET_WM_PING \"SDL_VIDEO_X11_NET_WM_PING\"")]
    public static ReadOnlySpan<byte> HintVideoX11NetWmPing => "SDL_VIDEO_X11_NET_WM_PING"u8;

    [NativeTypeName("#define SDL_HINT_VIDEO_X11_SCALING_FACTOR \"SDL_VIDEO_X11_SCALING_FACTOR\"")]
    public static ReadOnlySpan<byte> HintVideoX11ScalingFactor => "SDL_VIDEO_X11_SCALING_FACTOR"u8;

    [NativeTypeName("#define SDL_HINT_VIDEO_X11_WINDOW_VISUALID \"SDL_VIDEO_X11_WINDOW_VISUALID\"")]
    public static ReadOnlySpan<byte> HintVideoX11WindowVisualid =>
        "SDL_VIDEO_X11_WINDOW_VISUALID"u8;

    [NativeTypeName("#define SDL_HINT_VIDEO_X11_XRANDR \"SDL_VIDEO_X11_XRANDR\"")]
    public static ReadOnlySpan<byte> HintVideoX11Xrandr => "SDL_VIDEO_X11_XRANDR"u8;

    [NativeTypeName("#define SDL_HINT_VITA_TOUCH_MOUSE_DEVICE \"SDL_VITA_TOUCH_MOUSE_DEVICE\"")]
    public static ReadOnlySpan<byte> HintVitaTouchMouseDevice => "SDL_VITA_TOUCH_MOUSE_DEVICE"u8;

    [NativeTypeName("#define SDL_HINT_WAVE_FACT_CHUNK \"SDL_WAVE_FACT_CHUNK\"")]
    public static ReadOnlySpan<byte> HintWaveFactChunk => "SDL_WAVE_FACT_CHUNK"u8;

    [NativeTypeName("#define SDL_HINT_WAVE_RIFF_CHUNK_SIZE \"SDL_WAVE_RIFF_CHUNK_SIZE\"")]
    public static ReadOnlySpan<byte> HintWaveRiffChunkSize => "SDL_WAVE_RIFF_CHUNK_SIZE"u8;

    [NativeTypeName("#define SDL_HINT_WAVE_TRUNCATION \"SDL_WAVE_TRUNCATION\"")]
    public static ReadOnlySpan<byte> HintWaveTruncation => "SDL_WAVE_TRUNCATION"u8;

    [NativeTypeName(
        "#define SDL_HINT_WINDOW_ACTIVATE_WHEN_RAISED \"SDL_WINDOW_ACTIVATE_WHEN_RAISED\""
    )]
    public static ReadOnlySpan<byte> HintWindowActivateWhenRaised =>
        "SDL_WINDOW_ACTIVATE_WHEN_RAISED"u8;

    [NativeTypeName(
        "#define SDL_HINT_WINDOW_ACTIVATE_WHEN_SHOWN \"SDL_WINDOW_ACTIVATE_WHEN_SHOWN\""
    )]
    public static ReadOnlySpan<byte> HintWindowActivateWhenShown =>
        "SDL_WINDOW_ACTIVATE_WHEN_SHOWN"u8;

    [NativeTypeName("#define SDL_HINT_WINDOW_ALLOW_TOPMOST \"SDL_WINDOW_ALLOW_TOPMOST\"")]
    public static ReadOnlySpan<byte> HintWindowAllowTopmost => "SDL_WINDOW_ALLOW_TOPMOST"u8;

    [NativeTypeName(
        "#define SDL_HINT_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN \"SDL_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN\""
    )]
    public static ReadOnlySpan<byte> HintWindowFrameUsableWhileCursorHidden =>
        "SDL_WINDOW_FRAME_USABLE_WHILE_CURSOR_HIDDEN"u8;

    [NativeTypeName("#define SDL_HINT_WINDOWS_CLOSE_ON_ALT_F4 \"SDL_WINDOWS_CLOSE_ON_ALT_F4\"")]
    public static ReadOnlySpan<byte> HintWindowsCloseOnAltF4 => "SDL_WINDOWS_CLOSE_ON_ALT_F4"u8;

    [NativeTypeName(
        "#define SDL_HINT_WINDOWS_ENABLE_MENU_MNEMONICS \"SDL_WINDOWS_ENABLE_MENU_MNEMONICS\""
    )]
    public static ReadOnlySpan<byte> HintWindowsEnableMenuMnemonics =>
        "SDL_WINDOWS_ENABLE_MENU_MNEMONICS"u8;

    [NativeTypeName(
        "#define SDL_HINT_WINDOWS_ENABLE_MESSAGELOOP \"SDL_WINDOWS_ENABLE_MESSAGELOOP\""
    )]
    public static ReadOnlySpan<byte> HintWindowsEnableMessageloop =>
        "SDL_WINDOWS_ENABLE_MESSAGELOOP"u8;

    [NativeTypeName("#define SDL_HINT_WINDOWS_RAW_KEYBOARD \"SDL_WINDOWS_RAW_KEYBOARD\"")]
    public static ReadOnlySpan<byte> HintWindowsRawKeyboard => "SDL_WINDOWS_RAW_KEYBOARD"u8;

    [NativeTypeName(
        "#define SDL_HINT_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS \"SDL_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS\""
    )]
    public static ReadOnlySpan<byte> HintWindowsForceMutexCriticalSections =>
        "SDL_WINDOWS_FORCE_MUTEX_CRITICAL_SECTIONS"u8;

    [NativeTypeName(
        "#define SDL_HINT_WINDOWS_FORCE_SEMAPHORE_KERNEL \"SDL_WINDOWS_FORCE_SEMAPHORE_KERNEL\""
    )]
    public static ReadOnlySpan<byte> HintWindowsForceSemaphoreKernel =>
        "SDL_WINDOWS_FORCE_SEMAPHORE_KERNEL"u8;

    [NativeTypeName("#define SDL_HINT_WINDOWS_INTRESOURCE_ICON \"SDL_WINDOWS_INTRESOURCE_ICON\"")]
    public static ReadOnlySpan<byte> HintWindowsIntresourceIcon => "SDL_WINDOWS_INTRESOURCE_ICON"u8;

    [NativeTypeName(
        "#define SDL_HINT_WINDOWS_INTRESOURCE_ICON_SMALL \"SDL_WINDOWS_INTRESOURCE_ICON_SMALL\""
    )]
    public static ReadOnlySpan<byte> HintWindowsIntresourceIconSmall =>
        "SDL_WINDOWS_INTRESOURCE_ICON_SMALL"u8;

    [NativeTypeName("#define SDL_HINT_WINDOWS_USE_D3D9EX \"SDL_WINDOWS_USE_D3D9EX\"")]
    public static ReadOnlySpan<byte> HintWindowsUseD3D9Ex => "SDL_WINDOWS_USE_D3D9EX"u8;

    [NativeTypeName("#define SDL_HINT_WINRT_HANDLE_BACK_BUTTON \"SDL_WINRT_HANDLE_BACK_BUTTON\"")]
    public static ReadOnlySpan<byte> HintWinrtHandleBackButton => "SDL_WINRT_HANDLE_BACK_BUTTON"u8;

    [NativeTypeName(
        "#define SDL_HINT_WINRT_PRIVACY_POLICY_LABEL \"SDL_WINRT_PRIVACY_POLICY_LABEL\""
    )]
    public static ReadOnlySpan<byte> HintWinrtPrivacyPolicyLabel =>
        "SDL_WINRT_PRIVACY_POLICY_LABEL"u8;

    [NativeTypeName("#define SDL_HINT_WINRT_PRIVACY_POLICY_URL \"SDL_WINRT_PRIVACY_POLICY_URL\"")]
    public static ReadOnlySpan<byte> HintWinrtPrivacyPolicyUrl => "SDL_WINRT_PRIVACY_POLICY_URL"u8;

    [NativeTypeName(
        "#define SDL_HINT_X11_FORCE_OVERRIDE_REDIRECT \"SDL_X11_FORCE_OVERRIDE_REDIRECT\""
    )]
    public static ReadOnlySpan<byte> HintX11ForceOverrideRedirect =>
        "SDL_X11_FORCE_OVERRIDE_REDIRECT"u8;

    [NativeTypeName("#define SDL_HINT_X11_WINDOW_TYPE \"SDL_X11_WINDOW_TYPE\"")]
    public static ReadOnlySpan<byte> HintX11WindowType => "SDL_X11_WINDOW_TYPE"u8;

    [NativeTypeName("#define SDL_HINT_XINPUT_ENABLED \"SDL_XINPUT_ENABLED\"")]
    public static ReadOnlySpan<byte> HintXinputEnabled => "SDL_XINPUT_ENABLED"u8;

    [NativeTypeName("#define SDL_SOFTWARE_RENDERER \"software\"")]
    public static ReadOnlySpan<byte> SoftwareRenderer => "software"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_NAME_STRING \"name\"")]
    public static ReadOnlySpan<byte> PropRendererCreateNameString => "name"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_WINDOW_POINTER \"window\"")]
    public static ReadOnlySpan<byte> PropRendererCreateWindowPointer => "window"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_SURFACE_POINTER \"surface\"")]
    public static ReadOnlySpan<byte> PropRendererCreateSurfacePointer => "surface"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_CREATE_OUTPUT_COLORSPACE_NUMBER \"output_colorspace\""
    )]
    public static ReadOnlySpan<byte> PropRendererCreateOutputColorspaceNumber =>
        "output_colorspace"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_PRESENT_VSYNC_BOOLEAN \"present_vsync\"")]
    public static ReadOnlySpan<byte> PropRendererCreatePresentVsyncBoolean => "present_vsync"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_INSTANCE_POINTER \"vulkan.instance\"")]
    public static ReadOnlySpan<byte> PropRendererCreateVulkanInstancePointer => "vulkan.instance"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_SURFACE_NUMBER \"vulkan.surface\"")]
    public static ReadOnlySpan<byte> PropRendererCreateVulkanSurfaceNumber => "vulkan.surface"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_CREATE_VULKAN_PHYSICAL_DEVICE_POINTER \"vulkan.physical_device\""
    )]
    public static ReadOnlySpan<byte> PropRendererCreateVulkanPhysicalDevicePointer =>
        "vulkan.physical_device"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_CREATE_VULKAN_DEVICE_POINTER \"vulkan.device\"")]
    public static ReadOnlySpan<byte> PropRendererCreateVulkanDevicePointer => "vulkan.device"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_CREATE_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER \"vulkan.graphics_queue_family_index\""
    )]
    public static ReadOnlySpan<byte> PropRendererCreateVulkanGraphicsQueueFamilyIndexNumber =>
        "vulkan.graphics_queue_family_index"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_CREATE_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER \"vulkan.present_queue_family_index\""
    )]
    public static ReadOnlySpan<byte> PropRendererCreateVulkanPresentQueueFamilyIndexNumber =>
        "vulkan.present_queue_family_index"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_NAME_STRING \"SDL.renderer.name\"")]
    public static ReadOnlySpan<byte> PropRendererNameString => "SDL.renderer.name"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_WINDOW_POINTER \"SDL.renderer.window\"")]
    public static ReadOnlySpan<byte> PropRendererWindowPointer => "SDL.renderer.window"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_SURFACE_POINTER \"SDL.renderer.surface\"")]
    public static ReadOnlySpan<byte> PropRendererSurfacePointer => "SDL.renderer.surface"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_OUTPUT_COLORSPACE_NUMBER \"SDL.renderer.output_colorspace\""
    )]
    public static ReadOnlySpan<byte> PropRendererOutputColorspaceNumber =>
        "SDL.renderer.output_colorspace"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_HDR_ENABLED_BOOLEAN \"SDL.renderer.HDR_enabled\"")]
    public static ReadOnlySpan<byte> PropRendererHdrEnabledBoolean => "SDL.renderer.HDR_enabled"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_SDR_WHITE_POINT_FLOAT \"SDL.renderer.SDR_white_point\""
    )]
    public static ReadOnlySpan<byte> PropRendererSdrWhitePointFloat =>
        "SDL.renderer.SDR_white_point"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_HDR_HEADROOM_FLOAT \"SDL.renderer.HDR_headroom\"")]
    public static ReadOnlySpan<byte> PropRendererHdrHeadroomFloat => "SDL.renderer.HDR_headroom"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_D3D9_DEVICE_POINTER \"SDL.renderer.d3d9.device\"")]
    public static ReadOnlySpan<byte> PropRendererD3D9DevicePointer => "SDL.renderer.d3d9.device"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_D3D11_DEVICE_POINTER \"SDL.renderer.d3d11.device\"")]
    public static ReadOnlySpan<byte> PropRendererD3D11DevicePointer =>
        "SDL.renderer.d3d11.device"u8;

    [NativeTypeName("#define SDL_PROP_RENDERER_D3D12_DEVICE_POINTER \"SDL.renderer.d3d12.device\"")]
    public static ReadOnlySpan<byte> PropRendererD3D12DevicePointer =>
        "SDL.renderer.d3d12.device"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_D3D12_COMMAND_QUEUE_POINTER \"SDL.renderer.d3d12.command_queue\""
    )]
    public static ReadOnlySpan<byte> PropRendererD3D12CommandQueuePointer =>
        "SDL.renderer.d3d12.command_queue"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_VULKAN_INSTANCE_POINTER \"SDL.renderer.vulkan.instance\""
    )]
    public static ReadOnlySpan<byte> PropRendererVulkanInstancePointer =>
        "SDL.renderer.vulkan.instance"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_VULKAN_SURFACE_NUMBER \"SDL.renderer.vulkan.surface\""
    )]
    public static ReadOnlySpan<byte> PropRendererVulkanSurfaceNumber =>
        "SDL.renderer.vulkan.surface"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_VULKAN_PHYSICAL_DEVICE_POINTER \"SDL.renderer.vulkan.physical_device\""
    )]
    public static ReadOnlySpan<byte> PropRendererVulkanPhysicalDevicePointer =>
        "SDL.renderer.vulkan.physical_device"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_VULKAN_DEVICE_POINTER \"SDL.renderer.vulkan.device\""
    )]
    public static ReadOnlySpan<byte> PropRendererVulkanDevicePointer =>
        "SDL.renderer.vulkan.device"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER \"SDL.renderer.vulkan.graphics_queue_family_index\""
    )]
    public static ReadOnlySpan<byte> PropRendererVulkanGraphicsQueueFamilyIndexNumber =>
        "SDL.renderer.vulkan.graphics_queue_family_index"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER \"SDL.renderer.vulkan.present_queue_family_index\""
    )]
    public static ReadOnlySpan<byte> PropRendererVulkanPresentQueueFamilyIndexNumber =>
        "SDL.renderer.vulkan.present_queue_family_index"u8;

    [NativeTypeName(
        "#define SDL_PROP_RENDERER_VULKAN_SWAPCHAIN_IMAGE_COUNT_NUMBER \"SDL.renderer.vulkan.swapchain_image_count\""
    )]
    public static ReadOnlySpan<byte> PropRendererVulkanSwapchainImageCountNumber =>
        "SDL.renderer.vulkan.swapchain_image_count"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_COLORSPACE_NUMBER \"colorspace\"")]
    public static ReadOnlySpan<byte> PropTextureCreateColorspaceNumber => "colorspace"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_FORMAT_NUMBER \"format\"")]
    public static ReadOnlySpan<byte> PropTextureCreateFormatNumber => "format"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_ACCESS_NUMBER \"access\"")]
    public static ReadOnlySpan<byte> PropTextureCreateAccessNumber => "access"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_WIDTH_NUMBER \"width\"")]
    public static ReadOnlySpan<byte> PropTextureCreateWidthNumber => "width"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_HEIGHT_NUMBER \"height\"")]
    public static ReadOnlySpan<byte> PropTextureCreateHeightNumber => "height"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_SDR_WHITE_POINT_FLOAT \"SDR_white_point\"")]
    public static ReadOnlySpan<byte> PropTextureCreateSdrWhitePointFloat => "SDR_white_point"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_HDR_HEADROOM_FLOAT \"HDR_headroom\"")]
    public static ReadOnlySpan<byte> PropTextureCreateHdrHeadroomFloat => "HDR_headroom"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_POINTER \"d3d11.texture\"")]
    public static ReadOnlySpan<byte> PropTextureCreateD3D11TexturePointer => "d3d11.texture"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_U_POINTER \"d3d11.texture_u\"")]
    public static ReadOnlySpan<byte> PropTextureCreateD3D11TextureUPointer => "d3d11.texture_u"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D11_TEXTURE_V_POINTER \"d3d11.texture_v\"")]
    public static ReadOnlySpan<byte> PropTextureCreateD3D11TextureVPointer => "d3d11.texture_v"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_POINTER \"d3d12.texture\"")]
    public static ReadOnlySpan<byte> PropTextureCreateD3D12TexturePointer => "d3d12.texture"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_U_POINTER \"d3d12.texture_u\"")]
    public static ReadOnlySpan<byte> PropTextureCreateD3D12TextureUPointer => "d3d12.texture_u"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_D3D12_TEXTURE_V_POINTER \"d3d12.texture_v\"")]
    public static ReadOnlySpan<byte> PropTextureCreateD3D12TextureVPointer => "d3d12.texture_v"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_CREATE_METAL_PIXELBUFFER_POINTER \"metal.pixelbuffer\""
    )]
    public static ReadOnlySpan<byte> PropTextureCreateMetalPixelbufferPointer =>
        "metal.pixelbuffer"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_NUMBER \"opengl.texture\"")]
    public static ReadOnlySpan<byte> PropTextureCreateOpenglTextureNumber => "opengl.texture"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_UV_NUMBER \"opengl.texture_uv\""
    )]
    public static ReadOnlySpan<byte> PropTextureCreateOpenglTextureUvNumber =>
        "opengl.texture_uv"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_U_NUMBER \"opengl.texture_u\"")]
    public static ReadOnlySpan<byte> PropTextureCreateOpenglTextureUNumber => "opengl.texture_u"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_OPENGL_TEXTURE_V_NUMBER \"opengl.texture_v\"")]
    public static ReadOnlySpan<byte> PropTextureCreateOpenglTextureVNumber => "opengl.texture_v"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_NUMBER \"opengles2.texture\""
    )]
    public static ReadOnlySpan<byte> PropTextureCreateOpengles2TextureNumber =>
        "opengles2.texture"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_UV_NUMBER \"opengles2.texture_uv\""
    )]
    public static ReadOnlySpan<byte> PropTextureCreateOpengles2TextureUvNumber =>
        "opengles2.texture_uv"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_U_NUMBER \"opengles2.texture_u\""
    )]
    public static ReadOnlySpan<byte> PropTextureCreateOpengles2TextureUNumber =>
        "opengles2.texture_u"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_V_NUMBER \"opengles2.texture_v\""
    )]
    public static ReadOnlySpan<byte> PropTextureCreateOpengles2TextureVNumber =>
        "opengles2.texture_v"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_CREATE_VULKAN_TEXTURE_NUMBER \"vulkan.texture\"")]
    public static ReadOnlySpan<byte> PropTextureCreateVulkanTextureNumber => "vulkan.texture"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_COLORSPACE_NUMBER \"SDL.texture.colorspace\"")]
    public static ReadOnlySpan<byte> PropTextureColorspaceNumber => "SDL.texture.colorspace"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_SDR_WHITE_POINT_FLOAT \"SDL.texture.SDR_white_point\""
    )]
    public static ReadOnlySpan<byte> PropTextureSdrWhitePointFloat =>
        "SDL.texture.SDR_white_point"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_HDR_HEADROOM_FLOAT \"SDL.texture.HDR_headroom\"")]
    public static ReadOnlySpan<byte> PropTextureHdrHeadroomFloat => "SDL.texture.HDR_headroom"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_D3D11_TEXTURE_POINTER \"SDL.texture.d3d11.texture\"")]
    public static ReadOnlySpan<byte> PropTextureD3D11TexturePointer =>
        "SDL.texture.d3d11.texture"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_D3D11_TEXTURE_U_POINTER \"SDL.texture.d3d11.texture_u\""
    )]
    public static ReadOnlySpan<byte> PropTextureD3D11TextureUPointer =>
        "SDL.texture.d3d11.texture_u"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_D3D11_TEXTURE_V_POINTER \"SDL.texture.d3d11.texture_v\""
    )]
    public static ReadOnlySpan<byte> PropTextureD3D11TextureVPointer =>
        "SDL.texture.d3d11.texture_v"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_D3D12_TEXTURE_POINTER \"SDL.texture.d3d12.texture\"")]
    public static ReadOnlySpan<byte> PropTextureD3D12TexturePointer =>
        "SDL.texture.d3d12.texture"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_D3D12_TEXTURE_U_POINTER \"SDL.texture.d3d12.texture_u\""
    )]
    public static ReadOnlySpan<byte> PropTextureD3D12TextureUPointer =>
        "SDL.texture.d3d12.texture_u"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_D3D12_TEXTURE_V_POINTER \"SDL.texture.d3d12.texture_v\""
    )]
    public static ReadOnlySpan<byte> PropTextureD3D12TextureVPointer =>
        "SDL.texture.d3d12.texture_v"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_NUMBER \"SDL.texture.opengl.texture\""
    )]
    public static ReadOnlySpan<byte> PropTextureOpenglTextureNumber =>
        "SDL.texture.opengl.texture"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_UV_NUMBER \"SDL.texture.opengl.texture_uv\""
    )]
    public static ReadOnlySpan<byte> PropTextureOpenglTextureUvNumber =>
        "SDL.texture.opengl.texture_uv"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_U_NUMBER \"SDL.texture.opengl.texture_u\""
    )]
    public static ReadOnlySpan<byte> PropTextureOpenglTextureUNumber =>
        "SDL.texture.opengl.texture_u"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_V_NUMBER \"SDL.texture.opengl.texture_v\""
    )]
    public static ReadOnlySpan<byte> PropTextureOpenglTextureVNumber =>
        "SDL.texture.opengl.texture_v"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_OPENGL_TEXTURE_TARGET_NUMBER \"SDL.texture.opengl.target\""
    )]
    public static ReadOnlySpan<byte> PropTextureOpenglTextureTargetNumber =>
        "SDL.texture.opengl.target"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEX_W_FLOAT \"SDL.texture.opengl.tex_w\"")]
    public static ReadOnlySpan<byte> PropTextureOpenglTexWFloat => "SDL.texture.opengl.tex_w"u8;

    [NativeTypeName("#define SDL_PROP_TEXTURE_OPENGL_TEX_H_FLOAT \"SDL.texture.opengl.tex_h\"")]
    public static ReadOnlySpan<byte> PropTextureOpenglTexHFloat => "SDL.texture.opengl.tex_h"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_NUMBER \"SDL.texture.opengles2.texture\""
    )]
    public static ReadOnlySpan<byte> PropTextureOpengles2TextureNumber =>
        "SDL.texture.opengles2.texture"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_UV_NUMBER \"SDL.texture.opengles2.texture_uv\""
    )]
    public static ReadOnlySpan<byte> PropTextureOpengles2TextureUvNumber =>
        "SDL.texture.opengles2.texture_uv"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_U_NUMBER \"SDL.texture.opengles2.texture_u\""
    )]
    public static ReadOnlySpan<byte> PropTextureOpengles2TextureUNumber =>
        "SDL.texture.opengles2.texture_u"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_V_NUMBER \"SDL.texture.opengles2.texture_v\""
    )]
    public static ReadOnlySpan<byte> PropTextureOpengles2TextureVNumber =>
        "SDL.texture.opengles2.texture_v"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_OPENGLES2_TEXTURE_TARGET_NUMBER \"SDL.texture.opengles2.target\""
    )]
    public static ReadOnlySpan<byte> PropTextureOpengles2TextureTargetNumber =>
        "SDL.texture.opengles2.target"u8;

    [NativeTypeName(
        "#define SDL_PROP_TEXTURE_VULKAN_TEXTURE_NUMBER \"SDL.texture.vulkan.texture\""
    )]
    public static ReadOnlySpan<byte> PropTextureVulkanTextureNumber =>
        "SDL.texture.vulkan.texture"u8;

    [NativeTypeName("#define SDL_PROP_GLOBAL_SYSTEM_DATE_FORMAT_NUMBER \"SDL.time.date_format\"")]
    public static ReadOnlySpan<byte> PropGlobalSystemDateFormatNumber => "SDL.time.date_format"u8;

    [NativeTypeName("#define SDL_PROP_GLOBAL_SYSTEM_TIME_FORMAT_NUMBER \"SDL.time.time_format\"")]
    public static ReadOnlySpan<byte> PropGlobalSystemTimeFormatNumber => "SDL.time.time_format"u8;

    [NativeTypeName("#define SDL_MS_PER_SECOND 1000")]
    public const int MsPerSecond = 1000;

    [NativeTypeName("#define SDL_US_PER_SECOND 1000000")]
    public const int UsPerSecond = 1000000;

    [NativeTypeName("#define SDL_NS_PER_SECOND 1000000000LL")]
    public const long NsPerSecond = 1000000000L;

    [NativeTypeName("#define SDL_NS_PER_MS 1000000")]
    public const int NsPerMs = 1000000;

    [NativeTypeName("#define SDL_NS_PER_US 1000")]
    public const int NsPerUs = 1000;

    [NativeTypeName("#define SDL_MAJOR_VERSION 3")]
    public const int MajorVersion = 3;

    [NativeTypeName("#define SDL_MINOR_VERSION 1")]
    public const int MinorVersion = 1;

    [NativeTypeName("#define SDL_PATCHLEVEL 2")]
    public const int Patchlevel = 2;

    [NativeTypeName(
        "#define SDL_COMPILEDVERSION SDL_VERSIONNUM(SDL_MAJOR_VERSION, SDL_MINOR_VERSION, SDL_PATCHLEVEL)"
    )]
    public const int Compiledversion = ((3) << 24 | (1) << 8 | (2) << 0);
}
