// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Numerics;
using AdvancedDLSupport;

// ReSharper disable ExplicitCallerInfoArgument
namespace Silk.NET.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the public interface for the listener-related functions of OpenAL 1.1.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface IListener
    {
        /// <summary>
        /// Sets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Listenerf")]
        void SetListenerProperty(ListenerFloat param, float value);

        /// <summary>
        /// Sets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        [NativeSymbol("Listener3f")]
        void SetListenerProperty(ListenerVector3 param, float value1, float value2, float value3);

        /// <summary>
        /// Sets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Listenerfv")]
        void SetListenerProperty(ListenerVector3 param, in Vector3 value);

        /// <summary>
        /// Sets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Listenerfv")]
        unsafe void SetListenerProperty(ListenerFloatArray param, float* value);

        /// <summary>
        /// Sets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Listeneri")]
        void SetListenerProperty(ListenerInteger param, int value);

        /// <summary>
        /// Sets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value to set the property to.</param>
        /// <param name="value2">The second value to set the property to.</param>
        /// <param name="value3">The third value to set the property to.</param>
        [NativeSymbol("Listener3i")]
        void SetListenerProperty(ListenerInteger param, int value1, int value2, int value3);

        /// <summary>
        /// Sets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value to set the property to.</param>
        [NativeSymbol("Listeneriv")]
        unsafe void SetListenerProperty(ListenerInteger param, int* value);

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetListenerf")]
        void GetListenerProperty(ListenerFloat param, out float value);

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value of the property.</param>
        /// <param name="value2">The second value of the property.</param>
        /// <param name="value3">The third value of the property.</param>
        [NativeSymbol("GetListener3f")]
        void GetListenerProperty(ListenerVector3 param, out float value1, out float value2, out float value3);

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetListenerfv")]
        void GetListenerProperty(ListenerVector3 param, out Vector3 value);

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetListenerfv")]
        unsafe void GetListenerProperty(ListenerFloatArray param, float* value);

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetListeneri")]
        void GetListenerProperty(ListenerInteger param, out int value);

        /// <summary>
        /// Sets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value1">The first value of the property.</param>
        /// <param name="value2">The second value of the property.</param>
        /// <param name="value3">The third value of the property.</param>
        [NativeSymbol("Listener3i")]
        void GetListenerProperty(ListenerInteger param, out int value1, out int value2, out int value3);

        /// <summary>
        /// Gets the value of a named property on the given listener.
        /// </summary>
        /// <param name="param">The named property.</param>
        /// <param name="value">The value of the property.</param>
        [NativeSymbol("GetListeneriv")]
        unsafe void GetListenerProperty(ListenerInteger param, int* value);
    }
}