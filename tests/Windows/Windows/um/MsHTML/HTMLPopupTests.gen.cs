// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTMLPopup"/> struct.</summary>
public static unsafe partial class HTMLPopupTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLPopup"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLPopup).GUID, Is.EqualTo(IID_HTMLPopup));
    }

    /// <summary>Validates that the <see cref = "HTMLPopup"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLPopup>(), Is.EqualTo(sizeof(HTMLPopup)));
    }

    /// <summary>Validates that the <see cref = "HTMLPopup"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLPopup).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLPopup"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLPopup), Is.EqualTo(1));
    }
}