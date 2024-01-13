using UnityEngine;

namespace Lessons.LS1_State_Behaviour.Scripts
{
    public class PlayerBehaviourActive: IPlayerBehaviour
    {
        public void Enter()
        {
            Debug.Log("Enter ACTIVE behaviour");
        }

        public void Exit()
        {
            Debug.Log("Exit ACTIVE behaviour");
        }

        public void Update()
        {
            Debug.Log("Update ACTIVE behaviour");
        }
    }
}