// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("winmm", ExactSpelling = true)]
    public static extern uint waveOutGetNumDevs();

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutGetDevCapsA(
        [NativeTypeName("UINT_PTR")] nuint uDeviceID,
        [NativeTypeName("LPWAVEOUTCAPSA")] WAVEOUTCAPSA* pwoc,
        uint cbwoc
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutGetDevCapsW(
        [NativeTypeName("UINT_PTR")] nuint uDeviceID,
        [NativeTypeName("LPWAVEOUTCAPSW")] WAVEOUTCAPSW* pwoc,
        uint cbwoc
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutGetVolume(
        HWAVEOUT hwo,
        [NativeTypeName("LPDWORD")] uint* pdwVolume
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutSetVolume(
        HWAVEOUT hwo,
        [NativeTypeName("DWORD")] uint dwVolume
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutGetErrorTextA(
        [NativeTypeName("MMRESULT")] uint mmrError,
        [NativeTypeName("LPSTR")] sbyte* pszText,
        uint cchText
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutGetErrorTextW(
        [NativeTypeName("MMRESULT")] uint mmrError,
        [NativeTypeName("LPWSTR")] ushort* pszText,
        uint cchText
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutOpen(
        [NativeTypeName("LPHWAVEOUT")] HWAVEOUT* phwo,
        uint uDeviceID,
        [NativeTypeName("LPCWAVEFORMATEX")] WAVEFORMATEX* pwfx,
        [NativeTypeName("DWORD_PTR")] nuint dwCallback,
        [NativeTypeName("DWORD_PTR")] nuint dwInstance,
        [NativeTypeName("DWORD")] uint fdwOpen
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutClose(HWAVEOUT hwo);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutPrepareHeader(
        HWAVEOUT hwo,
        [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh,
        uint cbwh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutUnprepareHeader(
        HWAVEOUT hwo,
        [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh,
        uint cbwh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutWrite(
        HWAVEOUT hwo,
        [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh,
        uint cbwh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutPause(HWAVEOUT hwo);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutRestart(HWAVEOUT hwo);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutReset(HWAVEOUT hwo);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutBreakLoop(HWAVEOUT hwo);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutGetPosition(
        HWAVEOUT hwo,
        [NativeTypeName("LPMMTIME")] MMTIME* pmmt,
        uint cbmmt
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutGetPitch(
        HWAVEOUT hwo,
        [NativeTypeName("LPDWORD")] uint* pdwPitch
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutSetPitch(HWAVEOUT hwo, [NativeTypeName("DWORD")] uint dwPitch);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutGetPlaybackRate(
        HWAVEOUT hwo,
        [NativeTypeName("LPDWORD")] uint* pdwRate
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutSetPlaybackRate(
        HWAVEOUT hwo,
        [NativeTypeName("DWORD")] uint dwRate
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutGetID(
        HWAVEOUT hwo,
        [NativeTypeName("LPUINT")] uint* puDeviceID
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveOutMessage(
        HWAVEOUT hwo,
        uint uMsg,
        [NativeTypeName("DWORD_PTR")] nuint dw1,
        [NativeTypeName("DWORD_PTR")] nuint dw2
    );

    [DllImport("winmm", ExactSpelling = true)]
    public static extern uint waveInGetNumDevs();

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInGetDevCapsA(
        [NativeTypeName("UINT_PTR")] nuint uDeviceID,
        [NativeTypeName("LPWAVEINCAPSA")] WAVEINCAPSA* pwic,
        uint cbwic
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInGetDevCapsW(
        [NativeTypeName("UINT_PTR")] nuint uDeviceID,
        [NativeTypeName("LPWAVEINCAPSW")] WAVEINCAPSW* pwic,
        uint cbwic
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInGetErrorTextA(
        [NativeTypeName("MMRESULT")] uint mmrError,
        [NativeTypeName("LPSTR")] sbyte* pszText,
        uint cchText
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInGetErrorTextW(
        [NativeTypeName("MMRESULT")] uint mmrError,
        [NativeTypeName("LPWSTR")] ushort* pszText,
        uint cchText
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInOpen(
        [NativeTypeName("LPHWAVEIN")] HWAVEIN* phwi,
        uint uDeviceID,
        [NativeTypeName("LPCWAVEFORMATEX")] WAVEFORMATEX* pwfx,
        [NativeTypeName("DWORD_PTR")] nuint dwCallback,
        [NativeTypeName("DWORD_PTR")] nuint dwInstance,
        [NativeTypeName("DWORD")] uint fdwOpen
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInClose(HWAVEIN hwi);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInPrepareHeader(
        HWAVEIN hwi,
        [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh,
        uint cbwh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInUnprepareHeader(
        HWAVEIN hwi,
        [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh,
        uint cbwh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInAddBuffer(
        HWAVEIN hwi,
        [NativeTypeName("LPWAVEHDR")] WAVEHDR* pwh,
        uint cbwh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInStart(HWAVEIN hwi);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInStop(HWAVEIN hwi);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInReset(HWAVEIN hwi);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInGetPosition(
        HWAVEIN hwi,
        [NativeTypeName("LPMMTIME")] MMTIME* pmmt,
        uint cbmmt
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInGetID(HWAVEIN hwi, [NativeTypeName("LPUINT")] uint* puDeviceID);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint waveInMessage(
        HWAVEIN hwi,
        uint uMsg,
        [NativeTypeName("DWORD_PTR")] nuint dw1,
        [NativeTypeName("DWORD_PTR")] nuint dw2
    );

    [DllImport("winmm", ExactSpelling = true)]
    public static extern uint midiOutGetNumDevs();

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiStreamOpen(
        [NativeTypeName("LPHMIDISTRM")] HMIDISTRM* phms,
        [NativeTypeName("LPUINT")] uint* puDeviceID,
        [NativeTypeName("DWORD")] uint cMidi,
        [NativeTypeName("DWORD_PTR")] nuint dwCallback,
        [NativeTypeName("DWORD_PTR")] nuint dwInstance,
        [NativeTypeName("DWORD")] uint fdwOpen
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiStreamClose(HMIDISTRM hms);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiStreamProperty(
        HMIDISTRM hms,
        [NativeTypeName("LPBYTE")] byte* lppropdata,
        [NativeTypeName("DWORD")] uint dwProperty
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiStreamPosition(
        HMIDISTRM hms,
        [NativeTypeName("LPMMTIME")] MMTIME* lpmmt,
        uint cbmmt
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiStreamOut(
        HMIDISTRM hms,
        [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh,
        uint cbmh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiStreamPause(HMIDISTRM hms);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiStreamRestart(HMIDISTRM hms);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiStreamStop(HMIDISTRM hms);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiConnect(
        HMIDI hmi,
        HMIDIOUT hmo,
        [NativeTypeName("LPVOID")] void* pReserved
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiDisconnect(
        HMIDI hmi,
        HMIDIOUT hmo,
        [NativeTypeName("LPVOID")] void* pReserved
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutGetDevCapsA(
        [NativeTypeName("UINT_PTR")] nuint uDeviceID,
        [NativeTypeName("LPMIDIOUTCAPSA")] MIDIOUTCAPSA* pmoc,
        uint cbmoc
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutGetDevCapsW(
        [NativeTypeName("UINT_PTR")] nuint uDeviceID,
        [NativeTypeName("LPMIDIOUTCAPSW")] MIDIOUTCAPSW* pmoc,
        uint cbmoc
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutGetVolume(
        HMIDIOUT hmo,
        [NativeTypeName("LPDWORD")] uint* pdwVolume
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutSetVolume(
        HMIDIOUT hmo,
        [NativeTypeName("DWORD")] uint dwVolume
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutGetErrorTextA(
        [NativeTypeName("MMRESULT")] uint mmrError,
        [NativeTypeName("LPSTR")] sbyte* pszText,
        uint cchText
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutGetErrorTextW(
        [NativeTypeName("MMRESULT")] uint mmrError,
        [NativeTypeName("LPWSTR")] ushort* pszText,
        uint cchText
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutOpen(
        [NativeTypeName("LPHMIDIOUT")] HMIDIOUT* phmo,
        uint uDeviceID,
        [NativeTypeName("DWORD_PTR")] nuint dwCallback,
        [NativeTypeName("DWORD_PTR")] nuint dwInstance,
        [NativeTypeName("DWORD")] uint fdwOpen
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutClose(HMIDIOUT hmo);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutPrepareHeader(
        HMIDIOUT hmo,
        [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh,
        uint cbmh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutUnprepareHeader(
        HMIDIOUT hmo,
        [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh,
        uint cbmh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutShortMsg(HMIDIOUT hmo, [NativeTypeName("DWORD")] uint dwMsg);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutLongMsg(
        HMIDIOUT hmo,
        [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh,
        uint cbmh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutReset(HMIDIOUT hmo);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutCachePatches(
        HMIDIOUT hmo,
        uint uBank,
        [NativeTypeName("LPWORD")] ushort* pwpa,
        uint fuCache
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutCacheDrumPatches(
        HMIDIOUT hmo,
        uint uPatch,
        [NativeTypeName("LPWORD")] ushort* pwkya,
        uint fuCache
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutGetID(
        HMIDIOUT hmo,
        [NativeTypeName("LPUINT")] uint* puDeviceID
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiOutMessage(
        HMIDIOUT hmo,
        uint uMsg,
        [NativeTypeName("DWORD_PTR")] nuint dw1,
        [NativeTypeName("DWORD_PTR")] nuint dw2
    );

    [DllImport("winmm", ExactSpelling = true)]
    public static extern uint midiInGetNumDevs();

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInGetDevCapsA(
        [NativeTypeName("UINT_PTR")] nuint uDeviceID,
        [NativeTypeName("LPMIDIINCAPSA")] MIDIINCAPSA* pmic,
        uint cbmic
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInGetDevCapsW(
        [NativeTypeName("UINT_PTR")] nuint uDeviceID,
        [NativeTypeName("LPMIDIINCAPSW")] MIDIINCAPSW* pmic,
        uint cbmic
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInGetErrorTextA(
        [NativeTypeName("MMRESULT")] uint mmrError,
        [NativeTypeName("LPSTR")] sbyte* pszText,
        uint cchText
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInGetErrorTextW(
        [NativeTypeName("MMRESULT")] uint mmrError,
        [NativeTypeName("LPWSTR")] ushort* pszText,
        uint cchText
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInOpen(
        [NativeTypeName("LPHMIDIIN")] HMIDIIN* phmi,
        uint uDeviceID,
        [NativeTypeName("DWORD_PTR")] nuint dwCallback,
        [NativeTypeName("DWORD_PTR")] nuint dwInstance,
        [NativeTypeName("DWORD")] uint fdwOpen
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInClose(HMIDIIN hmi);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInPrepareHeader(
        HMIDIIN hmi,
        [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh,
        uint cbmh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInUnprepareHeader(
        HMIDIIN hmi,
        [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh,
        uint cbmh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInAddBuffer(
        HMIDIIN hmi,
        [NativeTypeName("LPMIDIHDR")] MIDIHDR* pmh,
        uint cbmh
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInStart(HMIDIIN hmi);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInStop(HMIDIIN hmi);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInReset(HMIDIIN hmi);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInGetID(HMIDIIN hmi, [NativeTypeName("LPUINT")] uint* puDeviceID);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint midiInMessage(
        HMIDIIN hmi,
        uint uMsg,
        [NativeTypeName("DWORD_PTR")] nuint dw1,
        [NativeTypeName("DWORD_PTR")] nuint dw2
    );

    [DllImport("winmm", ExactSpelling = true)]
    public static extern uint auxGetNumDevs();

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint auxGetDevCapsA(
        [NativeTypeName("UINT_PTR")] nuint uDeviceID,
        [NativeTypeName("LPAUXCAPSA")] AUXCAPSA* pac,
        uint cbac
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint auxGetDevCapsW(
        [NativeTypeName("UINT_PTR")] nuint uDeviceID,
        [NativeTypeName("LPAUXCAPSW")] AUXCAPSW* pac,
        uint cbac
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint auxSetVolume(uint uDeviceID, [NativeTypeName("DWORD")] uint dwVolume);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint auxGetVolume(
        uint uDeviceID,
        [NativeTypeName("LPDWORD")] uint* pdwVolume
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint auxOutMessage(
        uint uDeviceID,
        uint uMsg,
        [NativeTypeName("DWORD_PTR")] nuint dw1,
        [NativeTypeName("DWORD_PTR")] nuint dw2
    );

    [DllImport("winmm", ExactSpelling = true)]
    public static extern uint mixerGetNumDevs();

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint mixerGetDevCapsA(
        [NativeTypeName("UINT_PTR")] nuint uMxId,
        [NativeTypeName("LPMIXERCAPSA")] MIXERCAPSA* pmxcaps,
        uint cbmxcaps
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint mixerGetDevCapsW(
        [NativeTypeName("UINT_PTR")] nuint uMxId,
        [NativeTypeName("LPMIXERCAPSW")] MIXERCAPSW* pmxcaps,
        uint cbmxcaps
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint mixerOpen(
        [NativeTypeName("LPHMIXER")] HMIXER* phmx,
        uint uMxId,
        [NativeTypeName("DWORD_PTR")] nuint dwCallback,
        [NativeTypeName("DWORD_PTR")] nuint dwInstance,
        [NativeTypeName("DWORD")] uint fdwOpen
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint mixerClose(HMIXER hmx);

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint mixerMessage(
        HMIXER hmx,
        uint uMsg,
        [NativeTypeName("DWORD_PTR")] nuint dwParam1,
        [NativeTypeName("DWORD_PTR")] nuint dwParam2
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint mixerGetLineInfoA(
        HMIXEROBJ hmxobj,
        [NativeTypeName("LPMIXERLINEA")] MIXERLINEA* pmxl,
        [NativeTypeName("DWORD")] uint fdwInfo
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint mixerGetLineInfoW(
        HMIXEROBJ hmxobj,
        [NativeTypeName("LPMIXERLINEW")] MIXERLINEW* pmxl,
        [NativeTypeName("DWORD")] uint fdwInfo
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint mixerGetID(
        HMIXEROBJ hmxobj,
        uint* puMxId,
        [NativeTypeName("DWORD")] uint fdwId
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint mixerGetLineControlsA(
        HMIXEROBJ hmxobj,
        [NativeTypeName("LPMIXERLINECONTROLSA")] MIXERLINECONTROLSA* pmxlc,
        [NativeTypeName("DWORD")] uint fdwControls
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint mixerGetLineControlsW(
        HMIXEROBJ hmxobj,
        [NativeTypeName("LPMIXERLINECONTROLSW")] MIXERLINECONTROLSW* pmxlc,
        [NativeTypeName("DWORD")] uint fdwControls
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint mixerGetControlDetailsA(
        HMIXEROBJ hmxobj,
        [NativeTypeName("LPMIXERCONTROLDETAILS")] MIXERCONTROLDETAILS* pmxcd,
        [NativeTypeName("DWORD")] uint fdwDetails
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint mixerGetControlDetailsW(
        HMIXEROBJ hmxobj,
        [NativeTypeName("LPMIXERCONTROLDETAILS")] MIXERCONTROLDETAILS* pmxcd,
        [NativeTypeName("DWORD")] uint fdwDetails
    );

    [DllImport("winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint mixerSetControlDetails(
        HMIXEROBJ hmxobj,
        [NativeTypeName("LPMIXERCONTROLDETAILS")] MIXERCONTROLDETAILS* pmxcd,
        [NativeTypeName("DWORD")] uint fdwDetails
    );

    [NativeTypeName("#define WAVERR_BADFORMAT (WAVERR_BASE + 0)")]
    public const int WAVERR_BADFORMAT = (32 + 0);

    [NativeTypeName("#define WAVERR_STILLPLAYING (WAVERR_BASE + 1)")]
    public const int WAVERR_STILLPLAYING = (32 + 1);

    [NativeTypeName("#define WAVERR_UNPREPARED (WAVERR_BASE + 2)")]
    public const int WAVERR_UNPREPARED = (32 + 2);

    [NativeTypeName("#define WAVERR_SYNC (WAVERR_BASE + 3)")]
    public const int WAVERR_SYNC = (32 + 3);

    [NativeTypeName("#define WAVERR_LASTERROR (WAVERR_BASE + 3)")]
    public const int WAVERR_LASTERROR = (32 + 3);

    [NativeTypeName("#define WOM_OPEN MM_WOM_OPEN")]
    public const int WOM_OPEN = 0x3BB;

    [NativeTypeName("#define WOM_CLOSE MM_WOM_CLOSE")]
    public const int WOM_CLOSE = 0x3BC;

    [NativeTypeName("#define WOM_DONE MM_WOM_DONE")]
    public const int WOM_DONE = 0x3BD;

    [NativeTypeName("#define WIM_OPEN MM_WIM_OPEN")]
    public const int WIM_OPEN = 0x3BE;

    [NativeTypeName("#define WIM_CLOSE MM_WIM_CLOSE")]
    public const int WIM_CLOSE = 0x3BF;

    [NativeTypeName("#define WIM_DATA MM_WIM_DATA")]
    public const int WIM_DATA = 0x3C0;

    [NativeTypeName("#define WHDR_DONE 0x00000001")]
    public const int WHDR_DONE = 0x00000001;

    [NativeTypeName("#define WHDR_PREPARED 0x00000002")]
    public const int WHDR_PREPARED = 0x00000002;

    [NativeTypeName("#define WHDR_BEGINLOOP 0x00000004")]
    public const int WHDR_BEGINLOOP = 0x00000004;

    [NativeTypeName("#define WHDR_ENDLOOP 0x00000008")]
    public const int WHDR_ENDLOOP = 0x00000008;

    [NativeTypeName("#define WHDR_INQUEUE 0x00000010")]
    public const int WHDR_INQUEUE = 0x00000010;

    [NativeTypeName("#define WAVECAPS_PITCH 0x0001")]
    public const int WAVECAPS_PITCH = 0x0001;

    [NativeTypeName("#define WAVECAPS_PLAYBACKRATE 0x0002")]
    public const int WAVECAPS_PLAYBACKRATE = 0x0002;

    [NativeTypeName("#define WAVECAPS_VOLUME 0x0004")]
    public const int WAVECAPS_VOLUME = 0x0004;

    [NativeTypeName("#define WAVECAPS_LRVOLUME 0x0008")]
    public const int WAVECAPS_LRVOLUME = 0x0008;

    [NativeTypeName("#define WAVECAPS_SYNC 0x0010")]
    public const int WAVECAPS_SYNC = 0x0010;

    [NativeTypeName("#define WAVECAPS_SAMPLEACCURATE 0x0020")]
    public const int WAVECAPS_SAMPLEACCURATE = 0x0020;

    [NativeTypeName("#define waveOutGetDevCaps waveOutGetDevCapsW")]
    public static delegate* <nuint, WAVEOUTCAPSW*, uint, uint> waveOutGetDevCaps =>
        &waveOutGetDevCapsW;

    [NativeTypeName("#define waveOutGetErrorText waveOutGetErrorTextW")]
    public static delegate* <uint, ushort*, uint, uint> waveOutGetErrorText =>
        &waveOutGetErrorTextW;

    [NativeTypeName("#define waveInGetDevCaps waveInGetDevCapsW")]
    public static delegate* <nuint, WAVEINCAPSW*, uint, uint> waveInGetDevCaps =>
        &waveInGetDevCapsW;

    [NativeTypeName("#define waveInGetErrorText waveInGetErrorTextW")]
    public static delegate* <uint, ushort*, uint, uint> waveInGetErrorText => &waveInGetErrorTextW;

    [NativeTypeName("#define MIDIPATCHSIZE 128")]
    public const int MIDIPATCHSIZE = 128;

    [NativeTypeName("#define MOM_OPEN MM_MOM_OPEN")]
    public const int MOM_OPEN = 0x3C7;

    [NativeTypeName("#define MOM_CLOSE MM_MOM_CLOSE")]
    public const int MOM_CLOSE = 0x3C8;

    [NativeTypeName("#define MOM_DONE MM_MOM_DONE")]
    public const int MOM_DONE = 0x3C9;

    [NativeTypeName("#define MOM_POSITIONCB MM_MOM_POSITIONCB")]
    public const int MOM_POSITIONCB = 0x3CA;

    [NativeTypeName("#define MIDIMAPPER ((UINT)-1)")]
    public const uint MIDIMAPPER = unchecked((uint)(-1));

    [NativeTypeName("#define MIDI_MAPPER ((UINT)-1)")]
    public const uint MIDI_MAPPER = unchecked((uint)(-1));

    [NativeTypeName("#define MIDI_IO_STATUS 0x00000020L")]
    public const int MIDI_IO_STATUS = 0x00000020;

    [NativeTypeName("#define MIDI_CACHE_ALL 1")]
    public const int MIDI_CACHE_ALL = 1;

    [NativeTypeName("#define MIDI_CACHE_BESTFIT 2")]
    public const int MIDI_CACHE_BESTFIT = 2;

    [NativeTypeName("#define MIDI_CACHE_QUERY 3")]
    public const int MIDI_CACHE_QUERY = 3;

    [NativeTypeName("#define MIDI_UNCACHE 4")]
    public const int MIDI_UNCACHE = 4;

    [NativeTypeName("#define MIDICAPS_VOLUME 0x0001")]
    public const int MIDICAPS_VOLUME = 0x0001;

    [NativeTypeName("#define MIDICAPS_LRVOLUME 0x0002")]
    public const int MIDICAPS_LRVOLUME = 0x0002;

    [NativeTypeName("#define MIDICAPS_CACHE 0x0004")]
    public const int MIDICAPS_CACHE = 0x0004;

    [NativeTypeName("#define MIDICAPS_STREAM 0x0008")]
    public const int MIDICAPS_STREAM = 0x0008;

    [NativeTypeName("#define MHDR_DONE 0x00000001")]
    public const int MHDR_DONE = 0x00000001;

    [NativeTypeName("#define MHDR_PREPARED 0x00000002")]
    public const int MHDR_PREPARED = 0x00000002;

    [NativeTypeName("#define MHDR_INQUEUE 0x00000004")]
    public const int MHDR_INQUEUE = 0x00000004;

    [NativeTypeName("#define MHDR_ISSTRM 0x00000008")]
    public const int MHDR_ISSTRM = 0x00000008;

    [NativeTypeName("#define MEVT_F_SHORT 0x00000000L")]
    public const int MEVT_F_SHORT = 0x00000000;

    [NativeTypeName("#define MEVT_F_LONG 0x80000000L")]
    public const uint MEVT_F_LONG = 0x80000000;

    [NativeTypeName("#define MEVT_F_CALLBACK 0x40000000L")]
    public const int MEVT_F_CALLBACK = 0x40000000;

    [NativeTypeName("#define MEVT_SHORTMSG ((BYTE)0x00)")]
    public const byte MEVT_SHORTMSG = ((byte)(0x00));

    [NativeTypeName("#define MEVT_TEMPO ((BYTE)0x01)")]
    public const byte MEVT_TEMPO = ((byte)(0x01));

    [NativeTypeName("#define MEVT_NOP ((BYTE)0x02)")]
    public const byte MEVT_NOP = ((byte)(0x02));

    [NativeTypeName("#define MEVT_LONGMSG ((BYTE)0x80)")]
    public const byte MEVT_LONGMSG = ((byte)(0x80));

    [NativeTypeName("#define MEVT_COMMENT ((BYTE)0x82)")]
    public const byte MEVT_COMMENT = ((byte)(0x82));

    [NativeTypeName("#define MEVT_VERSION ((BYTE)0x84)")]
    public const byte MEVT_VERSION = ((byte)(0x84));

    [NativeTypeName("#define MIDISTRM_ERROR (-2)")]
    public const int MIDISTRM_ERROR = (-2);

    [NativeTypeName("#define MIDIPROP_SET 0x80000000L")]
    public const uint MIDIPROP_SET = 0x80000000;

    [NativeTypeName("#define MIDIPROP_GET 0x40000000L")]
    public const int MIDIPROP_GET = 0x40000000;

    [NativeTypeName("#define MIDIPROP_TIMEDIV 0x00000001L")]
    public const int MIDIPROP_TIMEDIV = 0x00000001;

    [NativeTypeName("#define MIDIPROP_TEMPO 0x00000002L")]
    public const int MIDIPROP_TEMPO = 0x00000002;

    [NativeTypeName("#define midiOutGetDevCaps midiOutGetDevCapsW")]
    public static delegate* <nuint, MIDIOUTCAPSW*, uint, uint> midiOutGetDevCaps =>
        &midiOutGetDevCapsW;

    [NativeTypeName("#define midiOutGetErrorText midiOutGetErrorTextW")]
    public static delegate* <uint, ushort*, uint, uint> midiOutGetErrorText =>
        &midiOutGetErrorTextW;

    [NativeTypeName("#define midiInGetDevCaps midiInGetDevCapsW")]
    public static delegate* <nuint, MIDIINCAPSW*, uint, uint> midiInGetDevCaps =>
        &midiInGetDevCapsW;

    [NativeTypeName("#define midiInGetErrorText midiInGetErrorTextW")]
    public static delegate* <uint, ushort*, uint, uint> midiInGetErrorText => &midiInGetErrorTextW;

    [NativeTypeName("#define AUX_MAPPER ((UINT)-1)")]
    public const uint AUX_MAPPER = unchecked((uint)(-1));

    [NativeTypeName("#define AUXCAPS_CDAUDIO 1")]
    public const int AUXCAPS_CDAUDIO = 1;

    [NativeTypeName("#define AUXCAPS_AUXIN 2")]
    public const int AUXCAPS_AUXIN = 2;

    [NativeTypeName("#define AUXCAPS_VOLUME 0x0001")]
    public const int AUXCAPS_VOLUME = 0x0001;

    [NativeTypeName("#define AUXCAPS_LRVOLUME 0x0002")]
    public const int AUXCAPS_LRVOLUME = 0x0002;

    [NativeTypeName("#define auxGetDevCaps auxGetDevCapsW")]
    public static delegate* <nuint, AUXCAPSW*, uint, uint> auxGetDevCaps => &auxGetDevCapsW;

    [NativeTypeName("#define MIXERR_INVALLINE (MIXERR_BASE + 0)")]
    public const int MIXERR_INVALLINE = (1024 + 0);

    [NativeTypeName("#define MIXERR_INVALCONTROL (MIXERR_BASE + 1)")]
    public const int MIXERR_INVALCONTROL = (1024 + 1);

    [NativeTypeName("#define MIXERR_INVALVALUE (MIXERR_BASE + 2)")]
    public const int MIXERR_INVALVALUE = (1024 + 2);

    [NativeTypeName("#define MIXERR_LASTERROR (MIXERR_BASE + 2)")]
    public const int MIXERR_LASTERROR = (1024 + 2);

    [NativeTypeName("#define mixerGetDevCaps mixerGetDevCapsW")]
    public static delegate* <nuint, MIXERCAPSW*, uint, uint> mixerGetDevCaps => &mixerGetDevCapsW;

    [NativeTypeName("#define mixerGetLineInfo mixerGetLineInfoW")]
    public static delegate* <HMIXEROBJ, MIXERLINEW*, uint, uint> mixerGetLineInfo =>
        &mixerGetLineInfoW;

    [NativeTypeName("#define mixerGetLineControls mixerGetLineControlsW")]
    public static delegate* <HMIXEROBJ, MIXERLINECONTROLSW*, uint, uint> mixerGetLineControls =>
        &mixerGetLineControlsW;

    [NativeTypeName("#define mixerGetControlDetails mixerGetControlDetailsW")]
    public static delegate* <HMIXEROBJ, MIXERCONTROLDETAILS*, uint, uint> mixerGetControlDetails =>
        &mixerGetControlDetailsW;
}
