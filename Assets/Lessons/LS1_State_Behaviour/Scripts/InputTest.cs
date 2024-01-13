using UnityEngine;

namespace Lessons.LS1_State_Behaviour.Scripts
{
    public class InputTest : MonoBehaviour
    {
        public Player player;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
                player.SetBehaviourIdle();
            
            if (Input.GetKeyDown(KeyCode.Alpha2))
                player.SetBehaviourAggressive();
            
            if (Input.GetKeyDown(KeyCode.Alpha3))
                player.SetBehaviourActive();
        }
    }
}
