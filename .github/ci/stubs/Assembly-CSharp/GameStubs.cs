// =============================================================================
// AUTO-GENERATED STUB — DO NOT ADD GAME LOGIC
// =============================================================================
// This file contains ONLY the type signatures that ThirdPersonHUD compiles
// against. Method bodies are intentionally empty / throw. No proprietary
// game code is present.
// =============================================================================

using UnityEngine;

// ---------------------------------------------------------------------------
// Camera system
// ---------------------------------------------------------------------------

public class CameraBaseState { }

public class CameraStateManager : MonoBehaviour
{
    public CameraBaseState cockpitState;
    public CameraBaseState TVState;
    public CameraBaseState orbitState;
    public CameraBaseState freeState;
    public CameraBaseState controlledState;
    public CameraBaseState chaseState;

    public virtual void SwitchState(CameraBaseState state)
        => throw new System.NotImplementedException("Stub");

    public virtual void SetFollowingUnit(Unit unit)
        => throw new System.NotImplementedException("Stub");
}

// ---------------------------------------------------------------------------
// Units
// ---------------------------------------------------------------------------

public class Unit : MonoBehaviour { }

// ---------------------------------------------------------------------------
// UI
// ---------------------------------------------------------------------------

public class GameplayUI : MonoBehaviour
{
    public virtual void ResumeGame()
        => throw new System.NotImplementedException("Stub");

    public virtual void SelectAircraft()
        => throw new System.NotImplementedException("Stub");
}

public class DynamicMap : MonoBehaviour
{
    public virtual void Minimize()
        => throw new System.NotImplementedException("Stub");
}

public class CombatHUD : MonoBehaviour
{
    public Unit aircraft;
}

// ---------------------------------------------------------------------------
// Utility
// ---------------------------------------------------------------------------

public class SceneSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T i { get; set; }
}