// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    public struct HResult
    {
        [MethodImpl((MethodImplOptions)768)] public static bool IndicatesSuccess(int hr) => hr >= 0;
        [MethodImpl((MethodImplOptions)768)] public static bool IndicatesFailure(int hr) => hr < 0;
        [MethodImpl((MethodImplOptions)768)] public static bool IndicatesError(int status) => ((uint) status >> 31) == 1;
        [MethodImpl((MethodImplOptions)768)] public static int GetCode(int hr) => hr & 0xFFFF;
        [MethodImpl((MethodImplOptions)768)] public static int GetFacility(int hr) => (hr >> 16) & 0x1FFF;
        [MethodImpl((MethodImplOptions)768)] public static int GetSeverity(int hr) => (hr >> 31) & 1;

        [MethodImpl((MethodImplOptions) 768)]
        public static int Create(int severity, int facility, int code)
            => (int) (((uint) severity << 31) | ((uint) facility << 16) | (uint) code);

        public int Value { get; }

        public HResult(int hr) => Value = hr;
        public HResult(int severity, int facility, int code) => Value = Create(severity, facility, code);

        public static implicit operator int(HResult hr) => hr.Value;
        public static implicit operator HResult(int hr) => new(hr);
        
        public bool IsSuccess { [MethodImpl((MethodImplOptions)768)] get => IndicatesSuccess(Value); }
        public bool IsFailure { [MethodImpl((MethodImplOptions)768)] get => IndicatesFailure(Value); }
        public bool IsError { [MethodImpl((MethodImplOptions)768)] get => IndicatesError(Value); }
        public int Code { [MethodImpl((MethodImplOptions)768)] get => GetCode(Value); }
        public int Facility { [MethodImpl((MethodImplOptions)768)] get => GetFacility(Value); }
        public int Severity { [MethodImpl((MethodImplOptions)768)] get => GetSeverity(Value); }
        public void Throw() => Marshal.ThrowExceptionForHR(Value);
    }
}
