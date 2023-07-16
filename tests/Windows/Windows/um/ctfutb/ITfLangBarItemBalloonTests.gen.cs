// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfLangBarItemBalloon"/> struct.</summary>
public static unsafe partial class ITfLangBarItemBalloonTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfLangBarItemBalloon"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfLangBarItemBalloon).GUID, Is.EqualTo(IID_ITfLangBarItemBalloon));
    }

    /// <summary>Validates that the <see cref = "ITfLangBarItemBalloon"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfLangBarItemBalloon>(), Is.EqualTo(sizeof(ITfLangBarItemBalloon)));
    }

    /// <summary>Validates that the <see cref = "ITfLangBarItemBalloon"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfLangBarItemBalloon).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfLangBarItemBalloon"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfLangBarItemBalloon), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfLangBarItemBalloon), Is.EqualTo(4));
        }
    }
}