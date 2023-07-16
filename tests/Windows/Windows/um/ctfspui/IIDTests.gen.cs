// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfspui.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ITfSpeechUIServer"/> property is correct.</summary>
    [Test]
    public static void IID_ITfSpeechUIServerTest()
    {
        Assert.That(IID_ITfSpeechUIServer, Is.EqualTo(new Guid(0x90e9a944, 0x9244, 0x489f, 0xa7, 0x8f, 0xde, 0x67, 0xaf, 0xc0, 0x13, 0xa7)));
    }
}