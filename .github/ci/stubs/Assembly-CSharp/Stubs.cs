// =============================================================================
// AUTO-GENERATED STUB by csstubgen — DO NOT EDIT
// =============================================================================

using Mirage;
using UnityEngine;

public abstract class CameraBaseState
{
    public abstract void EnterState(CameraStateManager cam);
    public abstract void FixedUpdateState(CameraStateManager cam);
    public abstract void LeaveState(CameraStateManager cam);
    public abstract void UpdateState(CameraStateManager cam);
}

public abstract class SceneSingleton<T> : MonoBehaviour
    where T : SceneSingleton<T>
{
    public static T i;
}

public class Unit : NetworkBehaviour
{
}

public class CameraStateManager : SceneSingleton<CameraStateManager>
{
    public Transform cameraPivot;
    public CameraChaseState chaseState;
    public CameraCockpitState cockpitState;
    public CameraControlledState controlledState;
    public CameraFreeState freeState;
    public CameraOrbitState orbitState;
    public CameraTVState TVState;
    public void SetFollowingUnit(Unit unit) { }
    public void SwitchState(CameraBaseState state) { }
}

public class GameplayUI : SceneSingleton<GameplayUI>
{
    public void ResumeGame() { }
    public void SelectAircraft() { }
}

public class DynamicMap : SceneSingleton<DynamicMap>
{
    public void Minimize() { }
}

public class CameraOrbitState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
}

public class CombatHUD : SceneSingleton<CombatHUD>
{
    public Aircraft aircraft;
}

public class CameraFreeState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
}

public class CameraTVState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
}

public class CameraCockpitState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
}

public class CameraChaseState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
}

public class CameraControlledState : CameraBaseState
{
    public override void EnterState(CameraStateManager cam) { }
    public override void FixedUpdateState(CameraStateManager cam) { }
    public override void LeaveState(CameraStateManager cam) { }
    public override void UpdateState(CameraStateManager cam) { }
}

public class Aircraft : Unit
{
}

