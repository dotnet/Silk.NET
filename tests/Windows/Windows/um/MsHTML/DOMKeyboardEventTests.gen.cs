// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DOMKeyboardEvent"/> struct.</summary>
public static unsafe partial class DOMKeyboardEventTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "DOMKeyboardEvent"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DOMKeyboardEvent).GUID, Is.EqualTo(IID_DOMKeyboardEvent));
    }

    /// <summary>Validates that the <see cref = "DOMKeyboardEvent"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DOMKeyboardEvent>(), Is.EqualTo(sizeof(DOMKeyboardEvent)));
    }

    /// <summary>Validates that the <see cref = "DOMKeyboardEvent"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DOMKeyboardEvent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DOMKeyboardEvent"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DOMKeyboardEvent), Is.EqualTo(1));
    }
}