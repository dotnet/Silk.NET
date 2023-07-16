// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfLangBarItemBitmap"/> struct.</summary>
public static unsafe partial class ITfLangBarItemBitmapTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfLangBarItemBitmap"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfLangBarItemBitmap).GUID, Is.EqualTo(IID_ITfLangBarItemBitmap));
    }

    /// <summary>Validates that the <see cref = "ITfLangBarItemBitmap"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfLangBarItemBitmap>(), Is.EqualTo(sizeof(ITfLangBarItemBitmap)));
    }

    /// <summary>Validates that the <see cref = "ITfLangBarItemBitmap"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfLangBarItemBitmap).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfLangBarItemBitmap"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfLangBarItemBitmap), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfLangBarItemBitmap), Is.EqualTo(4));
        }
    }
}