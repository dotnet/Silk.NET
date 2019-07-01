//
// IDeferredUpdatesState.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;
using OpenToolkit.OpenAL.Interfaces;

// ReSharper disable ExplicitCallerInfoArgument
namespace OpenToolkit.OpenAL.Extensions.Soft.DeferredUpdates
{
    /// <summary>
    /// Defines the public API of state-related functions in the Deferred Updates extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface IDeferredUpdatesState : IExtensions
    {
        /// <summary>
        /// Gets a named value from the state. This overload covers additional valid values added by the Deferred
        /// Updates extension.
        /// </summary>
        /// <param name="param">The name of the value to retrieve.</param>
        /// <returns>The value.</returns>
        bool GetBoolean(DeferredStateBoolean param);

        /// <summary>
        /// Defers updates until <see cref="ProcessUpdates"/> is called.
        ///
        /// When called, samples will continue to render and be sent to the output device, but the effects of changing
        /// playback properties, such as the source or listener gain, or auxiliary slot gain or effect if EFX is
        /// supported, among others, will be deferred. Multiple changes can be batched so that they all apply at once at
        /// a later time.
        /// </summary>
        [NativeSymbol("DeferUpdatesSOFT")]
        void DeferUpdates();

        /// <summary>
        /// Resumes update processing, reverting a call to <see cref="DeferUpdates"/>.
        ///
        /// Once called, all pending deferred updates will be processed. Any following state changes will also apply as
        /// normal.
        /// </summary>
        [NativeSymbol("ProcessUpdatesSOFT")]
        void ProcessUpdates();
    }
}
