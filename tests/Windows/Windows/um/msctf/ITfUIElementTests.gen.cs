// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfUIElement"/> struct.</summary>
public static unsafe partial class ITfUIElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfUIElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfUIElement).GUID, Is.EqualTo(IID_ITfUIElement));
    }

    /// <summary>Validates that the <see cref = "ITfUIElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfUIElement>(), Is.EqualTo(sizeof(ITfUIElement)));
    }

    /// <summary>Validates that the <see cref = "ITfUIElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfUIElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfUIElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfUIElement), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfUIElement), Is.EqualTo(4));
        }
    }
}