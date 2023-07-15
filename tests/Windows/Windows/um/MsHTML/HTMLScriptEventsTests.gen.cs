// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTMLScriptEvents"/> struct.</summary>
public static unsafe partial class HTMLScriptEventsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLScriptEvents"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLScriptEvents).GUID, Is.EqualTo(IID_HTMLScriptEvents));
    }

    /// <summary>Validates that the <see cref = "HTMLScriptEvents"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLScriptEvents>(), Is.EqualTo(sizeof(HTMLScriptEvents)));
    }

    /// <summary>Validates that the <see cref = "HTMLScriptEvents"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLScriptEvents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLScriptEvents"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(HTMLScriptEvents), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(HTMLScriptEvents), Is.EqualTo(4));
        }
    }
}