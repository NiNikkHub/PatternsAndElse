using UnityEngine;

namespace Lessons.LS1_State_Behaviour.Scripts
{
    public class PlayerBehaviourAggressive: IPlayerBehaviour
    {
        public void Enter()
        {
            Debug.Log("Enter AGGRESSIVE behaviour");
        }

        public void Exit()
        {
            Debug.Log("Exit AGGRESSIVE behaviour");
        }

        public void Update()
        {
            Debug.Log("Update AGGRESSIVE behaviour");
        }
    }
}