// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IDOMBeforeUnloadEvent"/> struct.</summary>
public static unsafe partial class IDOMBeforeUnloadEventTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDOMBeforeUnloadEvent"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDOMBeforeUnloadEvent).GUID, Is.EqualTo(IID_IDOMBeforeUnloadEvent));
    }

    /// <summary>Validates that the <see cref = "IDOMBeforeUnloadEvent"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDOMBeforeUnloadEvent>(), Is.EqualTo(sizeof(IDOMBeforeUnloadEvent)));
    }

    /// <summary>Validates that the <see cref = "IDOMBeforeUnloadEvent"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDOMBeforeUnloadEvent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDOMBeforeUnloadEvent"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDOMBeforeUnloadEvent), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDOMBeforeUnloadEvent), Is.EqualTo(4));
        }
    }
}