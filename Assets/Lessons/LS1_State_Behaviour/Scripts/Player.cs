using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons.LS1_State_Behaviour.Scripts
{
    public class Player : MonoBehaviour
    {
        private Dictionary<Type, IPlayerBehaviour> _behavioursMap;
        private IPlayerBehaviour _behaviourCurrent;

        private void Start()
        {
            InitBehaviours();
            SetBehaviourByDefault();
        }

        private void Update()
        {
            _behaviourCurrent?.Update();
        }
        
        private void InitBehaviours()
        {
            _behavioursMap = new Dictionary<Type, IPlayerBehaviour>();
            
            _behavioursMap[typeof(PlayerBehaviourActive)] = new PlayerBehaviourActive();
            _behavioursMap[typeof(PlayerBehaviourAggressive)] = new PlayerBehaviourAggressive();
            _behavioursMap[typeof(PlayerBehaviourIdle)] = new PlayerBehaviourIdle();
        }

        private void SetBehaviour(IPlayerBehaviour newBehaviour)
        {
            _behaviourCurrent?.Exit();

            _behaviourCurrent = newBehaviour;
            _behaviourCurrent.Enter();
        }

        private void SetBehaviourByDefault()
        {
            SetBehaviourIdle();
        }

        private IPlayerBehaviour GetBehaviour<T>() where T : IPlayerBehaviour
        {
            var type = typeof(T);
            return _behavioursMap[type];
        }

        public void SetBehaviourIdle()
        {
            var behaviour = GetBehaviour<PlayerBehaviourIdle>();
            SetBehaviour(behaviour);
        }
        
        public void SetBehaviourAggressive()
        {
            var behaviour = GetBehaviour<PlayerBehaviourAggressive>();
            SetBehaviour(behaviour);
        }
        
        public void SetBehaviourActive()
        {
            var behaviour = GetBehaviour<PlayerBehaviourActive>();
            SetBehaviour(behaviour);
        }
    }
}

