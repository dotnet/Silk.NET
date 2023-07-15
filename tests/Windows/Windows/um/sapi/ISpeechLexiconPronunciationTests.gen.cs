// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISpeechLexiconPronunciation"/> struct.</summary>
public static unsafe partial class ISpeechLexiconPronunciationTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISpeechLexiconPronunciation"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISpeechLexiconPronunciation).GUID, Is.EqualTo(IID_ISpeechLexiconPronunciation));
    }

    /// <summary>Validates that the <see cref = "ISpeechLexiconPronunciation"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISpeechLexiconPronunciation>(), Is.EqualTo(sizeof(ISpeechLexiconPronunciation)));
    }

    /// <summary>Validates that the <see cref = "ISpeechLexiconPronunciation"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISpeechLexiconPronunciation).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISpeechLexiconPronunciation"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISpeechLexiconPronunciation), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISpeechLexiconPronunciation), Is.EqualTo(4));
        }
    }
}