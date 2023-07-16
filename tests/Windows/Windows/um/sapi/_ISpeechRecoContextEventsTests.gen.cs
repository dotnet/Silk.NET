// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.Windows;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "_ISpeechRecoContextEvents"/> struct.</summary>
public static unsafe partial class _ISpeechRecoContextEventsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "_ISpeechRecoContextEvents"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(_ISpeechRecoContextEvents).GUID, Is.EqualTo(DIID__ISpeechRecoContextEvents));
    }

    /// <summary>Validates that the <see cref = "_ISpeechRecoContextEvents"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<_ISpeechRecoContextEvents>(), Is.EqualTo(sizeof(_ISpeechRecoContextEvents)));
    }

    /// <summary>Validates that the <see cref = "_ISpeechRecoContextEvents"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(_ISpeechRecoContextEvents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "_ISpeechRecoContextEvents"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(_ISpeechRecoContextEvents), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(_ISpeechRecoContextEvents), Is.EqualTo(4));
        }
    }
}