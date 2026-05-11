// =============================================================================
// AUTO-GENERATED STUB — DO NOT ADD GAME LOGIC
// =============================================================================
// This file contains ONLY the type signatures that ThirdPersonHUD compiles
// against. Method bodies are intentionally empty / throw. No proprietary
// game code is present.
//
// Field types, inheritance chains, and virtual/non-virtual must match the
// real Assembly-CSharp.dll exactly — the CLR resolves fields by name+type
// and Harmony patches by exact method signature.
// =============================================================================

using Mirage;
using UnityEngine;

// ---------------------------------------------------------------------------
// Interfaces
// ---------------------------------------------------------------------------

public interface ISceneSingleton
{
    bool ClearInstance();
}

// ---------------------------------------------------------------------------
// SceneSingleton<T> — note: 'i' is a FIELD, not a property
// ---------------------------------------------------------------------------

public abstract class SceneSingleton<T> : MonoBehaviour, ISceneSingleton
    where T : SceneSingleton<T>
{
    public static T i;

    public virtual void Awake()
        => throw new System.NotImplementedException("Stub");

    bool ISceneSingleton.ClearInstance()
        => throw new System.NotImplementedException("Stub");
}

// ---------------------------------------------------------------------------
// Camera system
// ---------------------------------------------------------------------------

public abstract class CameraBaseState
{
    public abstract void EnterState(CameraStateManager cam);
    public abstract void LeaveState(CameraStateManager cam);
    public abstract void UpdateState(CameraStateManager cam);
    public abstract void FixedUpdateState(CameraStateManager cam);
}

public class CameraCockpitState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
}

public class CameraOrbitState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
}

public class CameraTVState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
}

public class CameraFreeState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
}

public class CameraChaseState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
}

public class CameraControlledState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
}

public class CameraStateManager : SceneSingleton<CameraStateManager>
{
    public CameraFreeState freeState;
    public CameraOrbitState orbitState;
    public CameraTVState TVState;
    public CameraCockpitState cockpitState;
    public CameraChaseState chaseState;
    public CameraControlledState controlledState;

    public void SwitchState(CameraBaseState state)
        => throw new System.NotImplementedException("Stub");

    public void SetFollowingUnit(Unit unit)
        => throw new System.NotImplementedException("Stub");
}

// ---------------------------------------------------------------------------
// Units
// ---------------------------------------------------------------------------

public class Unit : NetworkBehaviour { }

public class Aircraft : Unit { }

// ---------------------------------------------------------------------------
// UI
// ---------------------------------------------------------------------------

public class GameplayUI : SceneSingleton<GameplayUI>
{
    public void ResumeGame()
        => throw new System.NotImplementedException("Stub");

    public void SelectAircraft()
        => throw new System.NotImplementedException("Stub");
}

public class DynamicMap : SceneSingleton<DynamicMap>
{
    public void Minimize()
        => throw new System.NotImplementedException("Stub");
}

public class CombatHUD : SceneSingleton<CombatHUD>
{
    public Aircraft aircraft;
}
