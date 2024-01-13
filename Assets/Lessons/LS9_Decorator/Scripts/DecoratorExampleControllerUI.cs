using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Lessons.LS9_Decorator.Scripts
{
    public class DecoratorExampleControllerUI: MonoBehaviour
    {
        [SerializeField] private UnitExample _unit;
        [SerializeField] private Button _buttonDamage;
        [SerializeField] private WidgetDamageValue _widgetDamageValuePrefab;
        [SerializeField] private Transform _damageValuesContainer;
        
        private Dictionary<DamageType, Color> _damageColorMap = new Dictionary<DamageType, Color>
        {
            {DamageType.Physical, Color.black},
            {DamageType.Electrical, Color.yellow},
            {DamageType.Water, Color.blue}
        };

        private void OnEnable()
        {
            _buttonDamage.onClick.AddListener(OnButtonDamageClick);
        }

        private void OnDisable()
        {
            _buttonDamage.onClick.RemoveListener(OnButtonDamageClick);
        }

        public void CreateWidgetDamageValue(DamageType damageType, int damage)
        {
            var color = _damageColorMap[damageType];
            var widget = Instantiate(_widgetDamageValuePrefab, _damageValuesContainer);
            var maxDistance = 100f;
            var randomOffset = Random.insideUnitCircle * maxDistance;
            var position = _damageValuesContainer.position + new Vector3(randomOffset.x, randomOffset.y, 0f);
            widget.transform.position = position;
            
            widget.SetValue(damage.ToString());
            widget.SetColor(color);
        }
        
        private void OnButtonDamageClick()
        {
            Debug.Log("Damaged!");

            IAbility ability = new Ability(10, DamageType.Physical);
            ability = new AbilityDurationDamage(ability, 20, 10);

            ability = new AbilityAdditionalDamage(ability, 10, DamageType.Electrical);
            ability = new AbilityAdditionalDamage(ability, 12, DamageType.Water);
            
            ability.ApplyDamage(_unit);
            
        }
    }
}