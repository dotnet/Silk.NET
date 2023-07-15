// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFTimedTextCueList"/> struct.</summary>
public static unsafe partial class IMFTimedTextCueListTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFTimedTextCueList"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFTimedTextCueList).GUID, Is.EqualTo(IID_IMFTimedTextCueList));
    }

    /// <summary>Validates that the <see cref = "IMFTimedTextCueList"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFTimedTextCueList>(), Is.EqualTo(sizeof(IMFTimedTextCueList)));
    }

    /// <summary>Validates that the <see cref = "IMFTimedTextCueList"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFTimedTextCueList).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFTimedTextCueList"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFTimedTextCueList), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFTimedTextCueList), Is.EqualTo(4));
        }
    }
}