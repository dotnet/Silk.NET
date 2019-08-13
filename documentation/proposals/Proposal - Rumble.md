# Summary

Proposal API for gamepad vibration. 

# Contributors
- Dylan P, Ultz Limited
- Frederik J, Silk.NET Contributors

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions

# Proposed API
## Interfaces
### IRumble
```cs
public interface IMotor
{
    /// <summary>
    /// The index of this vibration motor.
    /// </summary>
    int Index { get; }
    /// <summary>
    /// The motor's vibration intensity, between 0f and 1f.
    /// </summary>
    /// <remarks>
    /// Some backends may truncate this value if variable intensity is not supported.
    /// </remarks>
    float Speed { get; set; }
}
```

### IGamepad
```diff
public interface IGamepad
{
+    /// <summary>
+    /// A list of vibration motors in this gamepad.
+    /// </summary>
+    IReadOnlyList<IMotor> VibrationMotors { get; }
}
```
